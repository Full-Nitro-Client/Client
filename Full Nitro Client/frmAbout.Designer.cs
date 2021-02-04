
namespace Full_Nitro_Client
{
    partial class frmAbout
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
            this.lbProductName = new MetroFramework.Controls.MetroLabel();
            this.lbProdName = new MetroFramework.Controls.MetroLabel();
            this.lbVersion = new MetroFramework.Controls.MetroLabel();
            this.lbVer = new MetroFramework.Controls.MetroLabel();
            this.lbDescription = new MetroFramework.Controls.MetroLabel();
            this.lbComp = new MetroFramework.Controls.MetroLabel();
            this.lbCompany = new MetroFramework.Controls.MetroLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbProductName.Location = new System.Drawing.Point(13, 13);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(110, 19);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name:";
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbProdName.Location = new System.Drawing.Point(129, 13);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(104, 19);
            this.lbProdName.TabIndex = 1;
            this.lbProdName.Text = "Full Nitro Client";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbVersion.Location = new System.Drawing.Point(13, 42);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 19);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Version:";
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbVer.Location = new System.Drawing.Point(129, 42);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(57, 19);
            this.lbVer.TabIndex = 3;
            this.lbVer.Text = "v1.0.0.1";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbDescription.Location = new System.Drawing.Point(13, 99);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(89, 19);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description:";
            // 
            // lbComp
            // 
            this.lbComp.AutoSize = true;
            this.lbComp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbComp.Location = new System.Drawing.Point(129, 70);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(102, 19);
            this.lbComp.TabIndex = 5;
            this.lbComp.Text = "RED7 STUDIOS";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbCompany.Location = new System.Drawing.Point(13, 70);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(77, 19);
            this.lbCompany.TabIndex = 4;
            this.lbCompany.Text = "Company:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbDescription.Location = new System.Drawing.Point(13, 122);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(220, 96);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "Full Nitro Client is a client built for the website NitroType which is owned by t" +
    "eaching.com. This client aims to add more features and have a little bit of fun!" +
    "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 221);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(221, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "NitroType is owned by teaching.com";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(241, 251);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbComp);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbProdName);
            this.Controls.Add(this.lbProductName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbProductName;
        private MetroFramework.Controls.MetroLabel lbProdName;
        private MetroFramework.Controls.MetroLabel lbVersion;
        private MetroFramework.Controls.MetroLabel lbVer;
        private MetroFramework.Controls.MetroLabel lbDescription;
        private MetroFramework.Controls.MetroLabel lbComp;
        private MetroFramework.Controls.MetroLabel lbCompany;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}