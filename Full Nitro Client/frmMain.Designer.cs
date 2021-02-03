
namespace Full_Nitro_Client
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualTweaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.give1MillionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMembershipToGoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modernButton1 = new RED7Studios.UI.Controls.ModernButton();
            this.timerScripts = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.visualTweaksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giveYourselfMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveYourselfGoldMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dANGERResetEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualTweaksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // visualTweaksToolStripMenuItem
            // 
            this.visualTweaksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.give1MillionToolStripMenuItem,
            this.setMembershipToGoldToolStripMenuItem});
            this.visualTweaksToolStripMenuItem.Name = "visualTweaksToolStripMenuItem";
            this.visualTweaksToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.visualTweaksToolStripMenuItem.Text = "Visual Tweaks";
            // 
            // give1MillionToolStripMenuItem
            // 
            this.give1MillionToolStripMenuItem.Name = "give1MillionToolStripMenuItem";
            this.give1MillionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.give1MillionToolStripMenuItem.Text = "Give 1 millon to player";
            // 
            // setMembershipToGoldToolStripMenuItem
            // 
            this.setMembershipToGoldToolStripMenuItem.Name = "setMembershipToGoldToolStripMenuItem";
            this.setMembershipToGoldToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setMembershipToGoldToolStripMenuItem.Text = "Set Membership to Gold";
            // 
            // modernButton1
            // 
            this.modernButton1.CustomColorScheme = false;
            this.modernButton1.Location = new System.Drawing.Point(46, 388);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(75, 23);
            this.modernButton1.TabIndex = 1;
            this.modernButton1.Text = "modernButton1";
            this.modernButton1.UseVisualStyleBackColor = true;
            this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click);
            // 
            // timerScripts
            // 
            this.timerScripts.Enabled = true;
            this.timerScripts.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 504);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualTweaksToolStripMenuItem1,
            this.additionalToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(172, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // visualTweaksToolStripMenuItem1
            // 
            this.visualTweaksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveYourselfMoneyToolStripMenuItem,
            this.giveYourselfGoldMembershipToolStripMenuItem});
            this.visualTweaksToolStripMenuItem1.Name = "visualTweaksToolStripMenuItem1";
            this.visualTweaksToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.visualTweaksToolStripMenuItem1.Text = "Visual Tweaks";
            // 
            // giveYourselfMoneyToolStripMenuItem
            // 
            this.giveYourselfMoneyToolStripMenuItem.Name = "giveYourselfMoneyToolStripMenuItem";
            this.giveYourselfMoneyToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.giveYourselfMoneyToolStripMenuItem.Text = "Give Yourself One Million";
            this.giveYourselfMoneyToolStripMenuItem.Click += new System.EventHandler(this.giveYourselfMoneyToolStripMenuItem_Click);
            // 
            // giveYourselfGoldMembershipToolStripMenuItem
            // 
            this.giveYourselfGoldMembershipToolStripMenuItem.Name = "giveYourselfGoldMembershipToolStripMenuItem";
            this.giveYourselfGoldMembershipToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.giveYourselfGoldMembershipToolStripMenuItem.Text = "Give Yourself Membership";
            this.giveYourselfGoldMembershipToolStripMenuItem.Click += new System.EventHandler(this.giveYourselfGoldMembershipToolStripMenuItem_Click);
            // 
            // additionalToolStripMenuItem
            // 
            this.additionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dANGERResetEverythingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.additionalToolStripMenuItem.Name = "additionalToolStripMenuItem";
            this.additionalToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.additionalToolStripMenuItem.Text = "Additional";
            // 
            // dANGERResetEverythingToolStripMenuItem
            // 
            this.dANGERResetEverythingToolStripMenuItem.Name = "dANGERResetEverythingToolStripMenuItem";
            this.dANGERResetEverythingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.dANGERResetEverythingToolStripMenuItem.Text = "Reset Everything";
            this.dANGERResetEverythingToolStripMenuItem.Click += new System.EventHandler(this.dangerResetEverythingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutToolStripMenuItem.Text = "About Full Nitro Client";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1142, 538);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.modernButton1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Nitro Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualTweaksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem give1MillionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMembershipToGoldToolStripMenuItem;
        private RED7Studios.UI.Controls.ModernButton modernButton1;
        private System.Windows.Forms.Timer timerScripts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem visualTweaksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem additionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveYourselfMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveYourselfGoldMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dANGERResetEverythingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

