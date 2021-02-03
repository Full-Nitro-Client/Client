
namespace Full_Nitro_Client
{
    partial class frmNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotice));
            this.btnAgree = new RED7Studios.UI.Controls.ModernButton();
            this.btnExit = new RED7Studios.UI.Controls.ModernButton();
            this.lbName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbNeverShowAgain = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // btnAgree
            // 
            this.btnAgree.CustomColorScheme = false;
            this.btnAgree.Location = new System.Drawing.Point(14, 169);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(137, 34);
            this.btnAgree.TabIndex = 0;
            this.btnAgree.Text = "Agree and Continue";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnExit
            // 
            this.btnExit.CustomColorScheme = false;
            this.btnExit.Location = new System.Drawing.Point(157, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbName.Location = new System.Drawing.Point(13, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(258, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Welcome to Full Nitro Client!";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(14, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(515, 76);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(300, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(194, 30);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "By clicking \"Agree and Continue\",\r\nyou agree to the following above.";
            // 
            // cbNeverShowAgain
            // 
            this.cbNeverShowAgain.AutoSize = true;
            this.cbNeverShowAgain.Location = new System.Drawing.Point(14, 150);
            this.cbNeverShowAgain.Name = "cbNeverShowAgain";
            this.cbNeverShowAgain.Size = new System.Drawing.Size(142, 15);
            this.cbNeverShowAgain.TabIndex = 5;
            this.cbNeverShowAgain.Text = "Never show this again.";
            this.cbNeverShowAgain.UseSelectable = true;
            // 
            // frmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 216);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.ControlBox = false;
            this.Controls.Add(this.cbNeverShowAgain);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgree);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmNotice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice";
            this.Load += new System.EventHandler(this.frmNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RED7Studios.UI.Controls.ModernButton btnAgree;
        private RED7Studios.UI.Controls.ModernButton btnExit;
        private MetroFramework.Controls.MetroLabel lbName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cbNeverShowAgain;
    }
}