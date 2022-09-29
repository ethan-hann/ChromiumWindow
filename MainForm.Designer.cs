using System.ComponentModel;

namespace ChromiumWindow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTabsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.recentTabsDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.browserTabStrip = new FarsiLibrary.Win.FATabStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserTabStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenu, this.helpMenu, this.newTabButton });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newTabsBtn, this.loadTabsBtn, this.recentTabsDropDown, this.toolStripSeparator1, this.exitBtn });
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newTabsBtn
            // 
            this.newTabsBtn.Name = "newTabsBtn";
            this.newTabsBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTabsBtn.Size = new System.Drawing.Size(248, 22);
            this.newTabsBtn.Text = "New Tab Configuration...";
            // 
            // loadTabsBtn
            // 
            this.loadTabsBtn.Name = "loadTabsBtn";
            this.loadTabsBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadTabsBtn.Size = new System.Drawing.Size(248, 22);
            this.loadTabsBtn.Text = "Load Tabs...";
            // 
            // recentTabsDropDown
            // 
            this.recentTabsDropDown.Name = "recentTabsDropDown";
            this.recentTabsDropDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.recentTabsDropDown.Size = new System.Drawing.Size(248, 22);
            this.recentTabsDropDown.Text = "Recent Tabs...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitBtn.Size = new System.Drawing.Size(248, 22);
            this.exitBtn.Text = "Exit";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.aboutBtn });
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(107, 22);
            this.aboutBtn.Text = "About";
            // 
            // newTabButton
            // 
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(64, 20);
            this.newTabButton.Text = "New Tab";
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // browserTabStrip
            // 
            this.browserTabStrip.AlwayDrawToolBarRegion = false;
            this.browserTabStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserTabStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserTabStrip.Location = new System.Drawing.Point(0, 24);
            this.browserTabStrip.Name = "browserTabStrip";
            this.browserTabStrip.Size = new System.Drawing.Size(1231, 689);
            this.browserTabStrip.TabIndex = 1;
            this.browserTabStrip.Text = "faTabStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 713);
            this.Controls.Add(this.browserTabStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserTabStrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem newTabButton;

        private FarsiLibrary.Win.FATabStrip browserTabStrip;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;

        private System.Windows.Forms.ToolStripMenuItem recentTabsDropDown;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newTabsBtn;
        private System.Windows.Forms.ToolStripMenuItem loadTabsBtn;

        #endregion
    }
}