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
            this.newTabBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTabsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTabsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockViewBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowAddressBar = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.cutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backButton = new Krypton.Toolkit.KryptonButton();
            this.forwardButton = new Krypton.Toolkit.KryptonButton();
            this.addressTxtBox = new Krypton.Toolkit.KryptonTextBox();
            this.refreshBtn = new Krypton.Toolkit.ButtonSpecAny();
            this.mainMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dockingManager = new Krypton.Docking.KryptonDockingManager();
            this.backPanel = new Krypton.Toolkit.KryptonPanel();
            this.dockableWorkspace = new Krypton.Docking.KryptonDockableWorkspace();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPanel)).BeginInit();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // newTabBtn
            // 
            this.newTabBtn.Image = global::ChromiumWindow.Properties.Resources.plus_16x_16x;
            this.newTabBtn.Name = "newTabBtn";
            this.newTabBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabBtn.Size = new System.Drawing.Size(207, 22);
            this.newTabBtn.Text = "New Tab";
            this.newTabBtn.Click += new System.EventHandler(this.newTabBtn_Click);
            // 
            // saveTabsBtn
            // 
            this.saveTabsBtn.Image = global::ChromiumWindow.Properties.Resources.disk_16x_16x;
            this.saveTabsBtn.Name = "saveTabsBtn";
            this.saveTabsBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveTabsBtn.Size = new System.Drawing.Size(207, 22);
            this.saveTabsBtn.Text = "Save Tabs...";
            this.saveTabsBtn.Click += new System.EventHandler(this.saveTabsBtn_Click);
            // 
            // loadTabsBtn
            // 
            this.loadTabsBtn.Name = "loadTabsBtn";
            this.loadTabsBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.loadTabsBtn.Size = new System.Drawing.Size(207, 22);
            this.loadTabsBtn.Text = "Load Tabs...";
            this.loadTabsBtn.Click += new System.EventHandler(this.loadTabsBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockViewBtn,
            this.toolStripSeparator5,
            this.minimizeBtn,
            this.maximizeBtn,
            this.chkShowTabs,
            this.chkShowAddressBar,
            this.chkShowMenuBar});
            this.viewToolStripMenuItem.Image = global::ChromiumWindow.Properties.Resources.eye_16x_16x;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lockViewBtn
            // 
            this.lockViewBtn.CheckOnClick = true;
            this.lockViewBtn.Image = global::ChromiumWindow.Properties.Resources.lock_16x_16x;
            this.lockViewBtn.Name = "lockViewBtn";
            this.lockViewBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.lockViewBtn.Size = new System.Drawing.Size(200, 22);
            this.lockViewBtn.Text = "&Lock View";
            this.lockViewBtn.Click += new System.EventHandler(this.lockViewBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = global::ChromiumWindow.Properties.Resources.minimize_arrows_16x_16x;
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.minimizeBtn.Size = new System.Drawing.Size(200, 22);
            this.minimizeBtn.Text = "&Minimize";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Image = global::ChromiumWindow.Properties.Resources.maximize_16x_16x;
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.maximizeBtn.Size = new System.Drawing.Size(200, 22);
            this.maximizeBtn.Text = "Ma&ximize";
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // chkShowTabs
            // 
            this.chkShowTabs.Checked = true;
            this.chkShowTabs.CheckOnClick = true;
            this.chkShowTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowTabs.Name = "chkShowTabs";
            this.chkShowTabs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.chkShowTabs.Size = new System.Drawing.Size(200, 22);
            this.chkShowTabs.Text = "&Side Bar";
            this.chkShowTabs.CheckedChanged += new System.EventHandler(this.chkShowTabs_CheckedChanged);
            // 
            // chkShowAddressBar
            // 
            this.chkShowAddressBar.Checked = true;
            this.chkShowAddressBar.CheckOnClick = true;
            this.chkShowAddressBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAddressBar.Name = "chkShowAddressBar";
            this.chkShowAddressBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.chkShowAddressBar.Size = new System.Drawing.Size(200, 22);
            this.chkShowAddressBar.Text = "&Address Bar";
            this.chkShowAddressBar.CheckedChanged += new System.EventHandler(this.chkShowAddressBar_CheckedChanged);
            // 
            // chkShowMenuBar
            // 
            this.chkShowMenuBar.Checked = true;
            this.chkShowMenuBar.CheckOnClick = true;
            this.chkShowMenuBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowMenuBar.Name = "chkShowMenuBar";
            this.chkShowMenuBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.chkShowMenuBar.Size = new System.Drawing.Size(200, 22);
            this.chkShowMenuBar.Text = "Men&u Bar";
            this.chkShowMenuBar.CheckedChanged += new System.EventHandler(this.chkShowMenuBar_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // findBtn
            // 
            this.findBtn.Image = global::ChromiumWindow.Properties.Resources.search_16x_16x;
            this.findBtn.Name = "findBtn";
            this.findBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findBtn.Size = new System.Drawing.Size(207, 22);
            this.findBtn.Text = "Find...";
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Image = global::ChromiumWindow.Properties.Resources.print_16x_16x;
            this.printBtn.Name = "printBtn";
            this.printBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printBtn.Size = new System.Drawing.Size(207, 22);
            this.printBtn.Text = "Print...";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyBtn,
            this.cutBtn,
            this.pasteBtn});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyBtn
            // 
            this.copyBtn.Image = global::ChromiumWindow.Properties.Resources.copy_alt_16x_16x;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyBtn.Size = new System.Drawing.Size(144, 22);
            this.copyBtn.Text = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // cutBtn
            // 
            this.cutBtn.Image = global::ChromiumWindow.Properties.Resources.scissors_16x_16x;
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutBtn.Size = new System.Drawing.Size(144, 22);
            this.cutBtn.Text = "Cut";
            this.cutBtn.Click += new System.EventHandler(this.cutBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Image = global::ChromiumWindow.Properties.Resources.paste_16x_16x;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteBtn.Size = new System.Drawing.Size(144, 22);
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideBtn,
            this.aboutBtn});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideBtn
            // 
            this.userGuideBtn.Name = "userGuideBtn";
            this.userGuideBtn.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userGuideBtn.Size = new System.Drawing.Size(150, 22);
            this.userGuideBtn.Text = "User Guide";
            this.userGuideBtn.Click += new System.EventHandler(this.userGuideBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutBtn.Size = new System.Drawing.Size(150, 22);
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::ChromiumWindow.Properties.Resources.exit_16x_16x;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitBtn.Size = new System.Drawing.Size(207, 22);
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Controls.Add(this.forwardButton);
            this.topPanel.Controls.Add(this.addressTxtBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.topPanel.Size = new System.Drawing.Size(1436, 42);
            this.topPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.backButton.Location = new System.Drawing.Point(131, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(20, 20);
            this.backButton.TabIndex = 2;
            this.backButton.Values.Image = global::ChromiumWindow.Properties.Resources.angle_left_16x_16x;
            this.backButton.Values.Text = "";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.forwardButton.Location = new System.Drawing.Point(157, 11);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(20, 20);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Values.Image = global::ChromiumWindow.Properties.Resources.angle_right_16x_16x;
            this.forwardButton.Values.Text = "";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.refreshBtn});
            this.addressTxtBox.Location = new System.Drawing.Point(183, 5);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(794, 32);
            this.addressTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.addressTxtBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.addressTxtBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressTxtBox.StateCommon.Border.Rounding = 8F;
            this.addressTxtBox.StateCommon.Border.Width = 1;
            this.addressTxtBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(65)))), ((int)(((byte)(69)))));
            this.addressTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtBox.TabIndex = 4;
            this.addressTxtBox.Text = "https://google.com";
            this.addressTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTxtBox_KeyDown);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.refreshBtn.Image = global::ChromiumWindow.Properties.Resources.rotate_right_16x_16x;
            this.refreshBtn.UniqueName = "d44d76b195bb4658bb28bf8de5c55298";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabBtn,
            this.saveTabsBtn,
            this.loadTabsBtn,
            this.toolStripSeparator2,
            this.viewToolStripMenuItem,
            this.toolStripSeparator4,
            this.findBtn,
            this.printBtn,
            this.editToolStripMenuItem,
            this.toolStripSeparator3,
            this.helpToolStripMenuItem,
            this.exitBtn});
            this.mainMenuButton.Image = global::ChromiumWindow.Properties.Resources.menu_burger_16x_16x;
            this.mainMenuButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(28, 20);
            // 
            // dockingManager
            // 
            this.dockingManager.DefaultCloseRequest = Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.dockableWorkspace);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 42);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1436, 726);
            this.backPanel.TabIndex = 2;
            // 
            // dockableWorkspace
            // 
            this.dockableWorkspace.ActivePage = null;
            this.dockableWorkspace.AutoHiddenHost = false;
            this.dockableWorkspace.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.dockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.dockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockableWorkspace.Location = new System.Drawing.Point(0, 0);
            this.dockableWorkspace.Name = "dockableWorkspace";
            // 
            // 
            // 
            this.dockableWorkspace.Root.UniqueName = "10dc56502c474a11885e36a1c4ee1824";
            this.dockableWorkspace.Root.WorkspaceControl = this.dockableWorkspace;
            this.dockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.dockableWorkspace.ShowMaximizeButton = false;
            this.dockableWorkspace.Size = new System.Drawing.Size(1436, 726);
            this.dockableWorkspace.SplitterWidth = 5;
            this.dockableWorkspace.TabIndex = 0;
            this.dockableWorkspace.TabStop = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 768);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPanel)).EndInit();
            this.backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockableWorkspace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem newTabBtn;
        private System.Windows.Forms.ToolStripMenuItem saveTabsBtn;
        private System.Windows.Forms.ToolStripMenuItem loadTabsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBtn;
        private System.Windows.Forms.ToolStripMenuItem cutBtn;
        private System.Windows.Forms.ToolStripMenuItem pasteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeBtn;
        private System.Windows.Forms.ToolStripMenuItem maximizeBtn;
        private System.Windows.Forms.ToolStripMenuItem chkShowTabs;
        private System.Windows.Forms.ToolStripMenuItem chkShowAddressBar;
        private System.Windows.Forms.ToolStripMenuItem chkShowMenuBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem lockViewBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.ToolStripMenuItem findBtn;
        private Krypton.Toolkit.KryptonButton backButton;
        private Krypton.Toolkit.KryptonButton forwardButton;
        private Krypton.Toolkit.KryptonTextBox addressTxtBox;
        private Krypton.Toolkit.ButtonSpecAny refreshBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuButton;
        private Krypton.Docking.KryptonDockingManager dockingManager;
        private Krypton.Toolkit.KryptonPanel backPanel;
        private Krypton.Docking.KryptonDockableWorkspace dockableWorkspace;
    }
}