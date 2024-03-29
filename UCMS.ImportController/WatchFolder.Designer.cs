﻿namespace UCMS.ImportController
{
    partial class WatchFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboBrank = new System.Windows.Forms.ComboBox();
            this.cboLibrary = new System.Windows.Forms.ComboBox();
            this.lbLibrary = new System.Windows.Forms.Label();
            this.cboWorkflow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWorkflowStep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btlLibraryField = new System.Windows.Forms.Button();
            this.btlContentType = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch";
            // 
            // cboBrank
            // 
            this.cboBrank.FormattingEnabled = true;
            this.cboBrank.Location = new System.Drawing.Point(112, 12);
            this.cboBrank.Name = "cboBrank";
            this.cboBrank.Size = new System.Drawing.Size(460, 21);
            this.cboBrank.TabIndex = 1;
            // 
            // cboLibrary
            // 
            this.cboLibrary.FormattingEnabled = true;
            this.cboLibrary.Location = new System.Drawing.Point(112, 47);
            this.cboLibrary.Name = "cboLibrary";
            this.cboLibrary.Size = new System.Drawing.Size(460, 21);
            this.cboLibrary.TabIndex = 3;
            this.cboLibrary.SelectedIndexChanged += new System.EventHandler(this.cboLibrary_SelectedIndexChanged);
            // 
            // lbLibrary
            // 
            this.lbLibrary.AutoSize = true;
            this.lbLibrary.Location = new System.Drawing.Point(59, 55);
            this.lbLibrary.Name = "lbLibrary";
            this.lbLibrary.Size = new System.Drawing.Size(38, 13);
            this.lbLibrary.TabIndex = 2;
            this.lbLibrary.Text = "Library";
            // 
            // cboWorkflow
            // 
            this.cboWorkflow.FormattingEnabled = true;
            this.cboWorkflow.Location = new System.Drawing.Point(112, 83);
            this.cboWorkflow.Name = "cboWorkflow";
            this.cboWorkflow.Size = new System.Drawing.Size(161, 21);
            this.cboWorkflow.TabIndex = 5;
            this.cboWorkflow.SelectedIndexChanged += new System.EventHandler(this.cboWorkflow_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Workflow";
            // 
            // cboWorkflowStep
            // 
            this.cboWorkflowStep.FormattingEnabled = true;
            this.cboWorkflowStep.Location = new System.Drawing.Point(404, 83);
            this.cboWorkflowStep.Name = "cboWorkflowStep";
            this.cboWorkflowStep.Size = new System.Drawing.Size(168, 21);
            this.cboWorkflowStep.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Workflow Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(112, 116);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(460, 20);
            this.txtContent.TabIndex = 9;
            // 
            // btlLibraryField
            // 
            this.btlLibraryField.Location = new System.Drawing.Point(355, 116);
            this.btlLibraryField.Name = "btlLibraryField";
            this.btlLibraryField.Size = new System.Drawing.Size(88, 23);
            this.btlLibraryField.TabIndex = 10;
            this.btlLibraryField.Text = "Library Fileds";
            this.btlLibraryField.UseVisualStyleBackColor = true;
            this.btlLibraryField.Click += new System.EventHandler(this.btlLibraryField_Click);
            // 
            // btlContentType
            // 
            this.btlContentType.Location = new System.Drawing.Point(475, 115);
            this.btlContentType.Name = "btlContentType";
            this.btlContentType.Size = new System.Drawing.Size(97, 23);
            this.btlContentType.TabIndex = 11;
            this.btlContentType.Text = "Content Type";
            this.btlContentType.UseVisualStyleBackColor = true;
            this.btlContentType.Click += new System.EventHandler(this.btlContentType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Watch Folder";
            // 
            // txtFolders
            // 
            this.txtFolders.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFolders.Location = new System.Drawing.Point(112, 155);
            this.txtFolders.Multiline = true;
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.ReadOnly = true;
            this.txtFolders.Size = new System.Drawing.Size(363, 82);
            this.txtFolders.TabIndex = 13;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(475, 214);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(97, 23);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // WatchFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 297);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFolders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btlContentType);
            this.Controls.Add(this.btlLibraryField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboWorkflowStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboWorkflow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLibrary);
            this.Controls.Add(this.lbLibrary);
            this.Controls.Add(this.cboBrank);
            this.Controls.Add(this.label1);
            this.Name = "WatchFolder";
            this.Text = "WatchFolder";
            this.Load += new System.EventHandler(this.WatchFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBrank;
        private System.Windows.Forms.ComboBox cboLibrary;
        private System.Windows.Forms.Label lbLibrary;
        private System.Windows.Forms.ComboBox cboWorkflow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboWorkflowStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btlLibraryField;
        private System.Windows.Forms.Button btlContentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolders;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSubmit;
    }
}