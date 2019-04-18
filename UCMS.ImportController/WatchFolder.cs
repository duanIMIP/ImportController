using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UCMS.RestClient;

namespace UCMS.ImportController
{
    public partial class WatchFolder : Form
    {
        public UCMSApiClient oUCMSApiClient = null;
        public String tempNameFolders = "";
        public WatchFolder()
        {
            InitializeComponent();
            oUCMSApiClient = new UCMSApiClient(Common.Username, Common.Password, Common.UCMSWebAPIEndPoint, Common.UCMSAuthorizationServer);
        }

        private void WatchFolder_Load(object sender, EventArgs e)
        {
            if (!oUCMSApiClient.Login())
            {
                this.Close();
            }

            //LoadBranch
            LoadBranch();
            LoadLibrary("");
        }

        private void LoadBranch()
        {
            Boolean checkAdd = false;
            if(cboBrank.Items!= null && cboBrank.Items.Count>0)
            {
                cboBrank.Items.Clear();
            }
            var customsetting = oUCMSApiClient.Setting.GetCustomSetting("USCBranches");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(customsetting.Value);
            XmlNode xmlNodeBranch = xmlDocument.DocumentElement.SelectSingleNode("/ActivityConfiguration/Branches");
            foreach (XmlNode item in xmlNodeBranch.ChildNodes)
            {
                checkAdd = false;
                foreach (XmlNode oAccount in item.SelectNodes("Users/Account"))
                {
                    var Name = oAccount.SelectSingleNode("Name").InnerText;
                    if (Name == Common.Username || Name == "Everyone")
                    {
                        checkAdd = true;                        
                    }
                }
                if (checkAdd)
                {
                    cboBrank.Items.Add(item.SelectSingleNode("Name").InnerText);
                }
            }
            if(cboBrank.Items.Count>0)
            {
                cboBrank.SelectedIndex = 0;
            }
        }

        private void LoadLibrary(string BranchId)
        {
            var ListFolder = oUCMSApiClient.Folder.GetFolders(BranchId);
            cboLibrary.DataSource = ListFolder.Items;
            cboLibrary.DisplayMember = "Name";
            cboLibrary.ValueMember = "Id";
        }

        private void cboLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibrary.SelectedItem != null)
            {
                //Workflow;
                var obj = cboLibrary.SelectedItem as Model.Folder;
                cboWorkflow.DataSource = oUCMSApiClient.Workflow.GetAll(obj.Id);
                cboWorkflow.DisplayMember = "Name";
                cboWorkflow.ValueMember = "Id";
            }
        }

        private void cboWorkflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWorkflow.SelectedItem != null)
            {
                //Workflow;
                var obj = (sender as ComboBox).SelectedItem as Model.Workflow;
                cboWorkflowStep.DataSource = obj.Steps;
                cboWorkflowStep.DisplayMember = "Name";
                cboWorkflowStep.ValueMember = "Id";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {


                Model.Content oContent = new Model.Content();
                if (!CheckSubmit())
                {
                    return;
                }

                oContent.Folder = cboLibrary.SelectedItem as Model.Folder;

                //---------------------------------------------------------
                //oContent.Name = txtContent.Text;
                oContent.Tags = new List<string>();
                oContent.Name = cboBrank.Text + cboWorkflow.Text + DateTime.Now.ToString("yyMMddHHmmssff");
                oContent.Tags.Add(oContent.Name.Replace(" ", "_"));
                //-----------------------------------------------------------

                //Update Field Library
                oContent.LibraryFieldValues = new Dictionary<string, object>();
                var library = oUCMSApiClient.Folder.GetLibrary(oContent.Folder.Id);
                foreach (var item in library.Fields)
                {
                    oContent.LibraryFieldValues.Add(item.Id, item.DefaultValue);
                }

                if (library.ContentTypes.Count > 0)
                {
                    var contentType = oUCMSApiClient.ContentType.GetById(library.ContentTypes[0].Id);
                    oContent.ContentType = new Model.ContentType() { Id = contentType.Id };
                    oContent.Values = new Dictionary<string, object>();
                    foreach (var item in contentType.Fields) //Chon gia tri cho contentType
                    {
                        oContent.Values.Add(item.Name, item.DefaultValue);
                    }
                }
                oContent.Values.Add("BranchId", cboBrank.Text);

                var oContentMd = oUCMSApiClient.Content.Create(oContent);

                //oUCMSApiClient.Content.SetPrivateData(oContentMd.Id, new Model.ContentPrivateData() { });

                // ---------Attachment-----------------------------------------------------------------
                oUCMSApiClient.Content.Checkout(oContentMd.Id);//Checkout content
                foreach (String item in tempNameFolders.Split(';'))
                {
                    if (item.Trim().Length > 0)
                    {
                        var attachment = new Model.Attachment();
                        attachment.Name = Path.GetFileName(item.Trim());
                        attachment.ContentId = oContentMd.Id;
                        attachment.MIME = Path.GetExtension(item.Trim()).Replace(".", "image/");
                        attachment.Data = File.ReadAllBytes(item.Trim());
                        attachment.Type = Model.Enum.AttachmentType.Public;
                        attachment.Path = item.Trim();
                        oUCMSApiClient.Attachment.Upload(attachment);
                    }
                }
                oUCMSApiClient.Content.Checkin(oContentMd.Id);// Checkint content
                                                              //-----------------------------------------------------------------------------------------

                //---Insert content in workflow------------------------------------------------------------
                Model.WorkflowItem oWorkflowItem = new Model.WorkflowItem();
                oWorkflowItem.Content = oContentMd;
                oWorkflowItem.WorkflowStep = new Model.WorkflowStep() { Id = (cboWorkflowStep.SelectedItem as Model.WorkflowStep).Id };
                oWorkflowItem.Workflow = new Model.Workflow() { Id = (cboWorkflow.SelectedItem as Model.Workflow).Id };
                oWorkflowItem.State = Model.Enum.WorkflowItemState.Ready;
                oWorkflowItem.Priority = Model.Enum.WorkflowItemPriority.Normal;
                oUCMSApiClient.WorkflowItem.Insert(oWorkflowItem, true);
                //-----------------------------------------------------------------------------------------

                MessageBox.Show("Cập nhật thành công");
                txtContent.Text = "";
                txtFolders.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private bool CheckSubmit()
        {
            if (cboBrank.Text == "")
            {
                MessageBox.Show("Branch không được để trống");
                return false;
            }

            if (cboLibrary.SelectedItem == null || (cboLibrary.SelectedItem as Model.Folder).Id == "")
            {
                MessageBox.Show("Library không được để trống");
                return false;
            }

            if (cboWorkflow.SelectedItem == null || (cboWorkflow.SelectedItem as Model.Workflow).Id == "")
            {
                MessageBox.Show("Workflow không được để trống");
                return false;
            }

            if (cboWorkflowStep.SelectedItem == null || (cboWorkflowStep.SelectedItem as Model.WorkflowStep).Id == "")
            {
                MessageBox.Show("WorkflowStep không được để trống");
                return false;
            }

            //if (txtContent.Text == "")
            //{
            //    MessageBox.Show("Content không được để trống");
            //    return false;
            //}

            return true;
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.CheckFileExists = true;
            opnfd.AddExtension = true;
            opnfd.Multiselect = true;
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*.doc;*.docx;*.xls;*.xlsx;*.pdf;)|*.jpg;*.jpeg;.*.gif;*.png;*.doc;*.docx;*.xls;*.xlsx;*.pdf;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {                
                foreach (string fileName in opnfd.FileNames)
                {
                    tempNameFolders += fileName + ";" + Environment.NewLine;
                }
                txtFolders.Text = tempNameFolders;
            }
        }

        private void btlLibraryField_Click(object sender, EventArgs e)
        {
            frmChildren frm = new frmChildren();
            frm.ShowDialog();
            //var library = oUCMSApiClient.Folder.GetLibrary(oContent.Folder.Id);
            //foreach (var item in library.Fields)
            //{
            //    oContent.LibraryFieldValues.Add(item.Id, item.DefaultValue);
            //}
        }

        private void btlContentType_Click(object sender, EventArgs e)
        {

        }

        
    }
}
