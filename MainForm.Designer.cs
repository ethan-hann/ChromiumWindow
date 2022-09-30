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
            this.newTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsListView = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer = new Krypton.Toolkit.KryptonSplitContainer();
            this.backButton = new Krypton.Toolkit.KryptonButton();
            this.forwardButton = new Krypton.Toolkit.KryptonButton();
            this.addressBar = new Krypton.Toolkit.KryptonTextBox();
            this.refreshBtn = new Krypton.Toolkit.ButtonSpecAny();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(38, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTabButton
            // 
            this.newTabButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.saveTabsToolStripMenuItem,
            this.loadTabsToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.printToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator3,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newTabButton.Image = global::ChromiumWindow.Properties.Resources.menu_burger_16x_16x;
            this.newTabButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(28, 20);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.plus_16x_16x;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // saveTabsToolStripMenuItem
            // 
            this.saveTabsToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.disk_16x_16x;
            this.saveTabsToolStripMenuItem.Name = "saveTabsToolStripMenuItem";
            this.saveTabsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveTabsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveTabsToolStripMenuItem.Text = "Save Tabs...";
            // 
            // loadTabsToolStripMenuItem
            // 
            this.loadTabsToolStripMenuItem.Name = "loadTabsToolStripMenuItem";
            this.loadTabsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.loadTabsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.loadTabsToolStripMenuItem.Text = "Load Tabs...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockViewToolStripMenuItem,
            this.toolStripSeparator5,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.sideBarToolStripMenuItem,
            this.addressBarToolStripMenuItem,
            this.menuBarToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.eye_16x_16x;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lockViewToolStripMenuItem
            // 
            this.lockViewToolStripMenuItem.CheckOnClick = true;
            this.lockViewToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.lock_16x_16x;
            this.lockViewToolStripMenuItem.Name = "lockViewToolStripMenuItem";
            this.lockViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.lockViewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.lockViewToolStripMenuItem.Text = "&Lock View";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.minimize_arrows_16x_16x;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.minimizeToolStripMenuItem.Text = "&Minimize";
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.maximize_16x_16x;
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.maximizeToolStripMenuItem.Text = "Ma&ximize";
            // 
            // sideBarToolStripMenuItem
            // 
            this.sideBarToolStripMenuItem.Checked = true;
            this.sideBarToolStripMenuItem.CheckOnClick = true;
            this.sideBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sideBarToolStripMenuItem.Name = "sideBarToolStripMenuItem";
            this.sideBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.sideBarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sideBarToolStripMenuItem.Text = "&Side Bar";
            // 
            // addressBarToolStripMenuItem
            // 
            this.addressBarToolStripMenuItem.Checked = true;
            this.addressBarToolStripMenuItem.CheckOnClick = true;
            this.addressBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressBarToolStripMenuItem.Name = "addressBarToolStripMenuItem";
            this.addressBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addressBarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addressBarToolStripMenuItem.Text = "&Address Bar";
            // 
            // menuBarToolStripMenuItem
            // 
            this.menuBarToolStripMenuItem.Checked = true;
            this.menuBarToolStripMenuItem.CheckOnClick = true;
            this.menuBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBarToolStripMenuItem.Name = "menuBarToolStripMenuItem";
            this.menuBarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.menuBarToolStripMenuItem.Text = "Men&u Bar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.search_16x_16x;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.findToolStripMenuItem.Text = "Find...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.print_16x_16x;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.printToolStripMenuItem.Text = "Print...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.copy_alt_16x_16x;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.scissors_16x_16x;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.paste_16x_16x;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.exit_16x_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabsListView
            // 
            this.tabsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.tabsListView.BackColor = System.Drawing.Color.White;
            this.tabsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsListView.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsListView.HideSelection = false;
            this.tabsListView.Location = new System.Drawing.Point(0, 0);
            this.tabsListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabsListView.Name = "tabsListView";
            this.tabsListView.Size = new System.Drawing.Size(263, 735);
            this.tabsListView.TabIndex = 0;
            this.tabsListView.UseCompatibleStateImageBehavior = false;
            this.tabsListView.View = System.Windows.Forms.View.List;
            this.tabsListView.SelectedIndexChanged += new System.EventHandler(this.tabsListView_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Controls.Add(this.backButton);
            this.flowLayoutPanel1.Controls.Add(this.forwardButton);
            this.flowLayoutPanel1.Controls.Add(this.addressBar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1436, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 33);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabsListView);
            this.splitContainer.Size = new System.Drawing.Size(1436, 735);
            this.splitContainer.SplitterDistance = 263;
            this.splitContainer.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.backButton.Location = new System.Drawing.Point(41, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(20, 20);
            this.backButton.TabIndex = 2;
            this.backButton.Values.Image = global::ChromiumWindow.Properties.Resources.angle_left_16x_16x;
            this.backButton.Values.Text = "";
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.forwardButton.Location = new System.Drawing.Point(67, 6);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(20, 20);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Values.Image = global::ChromiumWindow.Properties.Resources.angle_right_16x_16x;
            this.forwardButton.Values.Text = "";
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.refreshBtn});
            this.addressBar.Location = new System.Drawing.Point(93, 5);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(1280, 23);
            this.addressBar.TabIndex = 4;
            this.addressBar.Text = "https://google.com";
            this.addressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.refreshBtn.Image = global::ChromiumWindow.Properties.Resources.rotate_right_16x_16x;
            this.refreshBtn.UniqueName = "d44d76b195bb4658bb28bf8de5c55298";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 768);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView tabsListView;

        private System.Windows.Forms.ToolStripMenuItem newTabButton;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem lockViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private Krypton.Toolkit.KryptonSplitContainer splitContainer;
        private Krypton.Toolkit.KryptonButton backButton;
        private Krypton.Toolkit.KryptonButton forwardButton;
        private Krypton.Toolkit.KryptonTextBox addressBar;
        private Krypton.Toolkit.ButtonSpecAny refreshBtn;
    }
}