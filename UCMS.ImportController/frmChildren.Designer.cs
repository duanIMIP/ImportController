namespace UCMS.ImportController
{
    partial class frmChildren
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(108, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(247, 20);
            this.txt1.TabIndex = 1;
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(108, 37);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(247, 21);
            this.cbo1.TabIndex = 2;
            // 
            // frmChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 292);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmChildren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChildren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cbo1;
    }
}