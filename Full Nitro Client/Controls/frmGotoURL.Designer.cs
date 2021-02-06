
namespace Full_Nitro_Client.Controls
{
    partial class frmGotoURL
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
            this.tbURL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGotoURL = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            // 
            // 
            // 
            this.tbURL.CustomButton.Image = null;
            this.tbURL.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.tbURL.CustomButton.Name = "";
            this.tbURL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbURL.CustomButton.TabIndex = 1;
            this.tbURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbURL.CustomButton.UseSelectable = true;
            this.tbURL.CustomButton.Visible = false;
            this.tbURL.Lines = new string[0];
            this.tbURL.Location = new System.Drawing.Point(12, 33);
            this.tbURL.MaxLength = 32767;
            this.tbURL.Name = "tbURL";
            this.tbURL.PasswordChar = '\0';
            this.tbURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbURL.SelectedText = "";
            this.tbURL.SelectionLength = 0;
            this.tbURL.SelectionStart = 0;
            this.tbURL.ShortcutsEnabled = true;
            this.tbURL.Size = new System.Drawing.Size(317, 23);
            this.tbURL.TabIndex = 4;
            this.tbURL.UseSelectable = true;
            this.tbURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "URL to goto:";
            // 
            // btnGotoURL
            // 
            this.btnGotoURL.CustomColorScheme = false;
            this.btnGotoURL.Location = new System.Drawing.Point(13, 62);
            this.btnGotoURL.Name = "btnGotoURL";
            this.btnGotoURL.Size = new System.Drawing.Size(316, 23);
            this.btnGotoURL.TabIndex = 5;
            this.btnGotoURL.Text = "Goto URL";
            this.btnGotoURL.UseVisualStyleBackColor = true;
            this.btnGotoURL.Click += new System.EventHandler(this.btnGotoURL_Click);
            // 
            // frmGotoURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 97);
            this.Controls.Add(this.btnGotoURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGotoURL";
            this.ShowIcon = false;
            this.Text = "Goto URL";
            this.Load += new System.EventHandler(this.frmGotoURL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbURL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private RED7Studios.UI.Controls.ModernButton btnGotoURL;
    }
}