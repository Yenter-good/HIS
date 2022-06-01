namespace HIS
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this._menuImgList = new System.Windows.Forms.ImageList(this.components);
            this._menuApp = new Sunny.UI.UIContextMenuStrip();
            this._menuUserOperation = new Sunny.UI.UIContextMenuStrip();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换工号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._userImgList = new System.Windows.Forms.ImageList(this.components);
            this.tabMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnIP = new DevComponents.DotNetBar.ButtonItem();
            this.btnLoginUserName = new DevComponents.DotNetBar.ButtonItem();
            this.lblLocalTime = new DevComponents.DotNetBar.LabelItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnAppList = new Sunny.UI.UIButton();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.pnlViewUnit = new DevComponents.DotNetBar.PanelEx();
            this.btnDept = new Sunny.UI.UIButton();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.picUserLogo = new System.Windows.Forms.PictureBox();
            this.Header = new Sunny.UI.UINavBar();
            this._menuDept = new Sunny.UI.UIContextMenuStrip();
            this._timerLocalTime = new System.Windows.Forms.Timer(this.components);
            this._menuUserOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.pnlViewUnit.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabItem1
            // 
            this.superTabItem1.CloseButtonVisible = false;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "主页";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // _menuImgList
            // 
            this._menuImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._menuImgList.ImageSize = new System.Drawing.Size(32, 32);
            this._menuImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _menuApp
            // 
            this._menuApp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._menuApp.Name = "_menuApp";
            this._menuApp.Size = new System.Drawing.Size(61, 4);
            // 
            // _menuUserOperation
            // 
            this._menuUserOperation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._menuUserOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.切换工号ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.注销ToolStripMenuItem,
            this.锁屏ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this._menuUserOperation.Name = "_menuUser";
            this._menuUserOperation.Size = new System.Drawing.Size(145, 140);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 切换工号ToolStripMenuItem
            // 
            this.切换工号ToolStripMenuItem.Name = "切换工号ToolStripMenuItem";
            this.切换工号ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.切换工号ToolStripMenuItem.Text = "用户设置";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // 锁屏ToolStripMenuItem
            // 
            this.锁屏ToolStripMenuItem.Name = "锁屏ToolStripMenuItem";
            this.锁屏ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.锁屏ToolStripMenuItem.Text = "锁定";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // _userImgList
            // 
            this._userImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_userImgList.ImageStream")));
            this._userImgList.TransparentColor = System.Drawing.Color.Transparent;
            this._userImgList.Images.SetKeyName(0, "护士.png");
            this._userImgList.Images.SetKeyName(1, "医生.png");
            this._userImgList.Images.SetKeyName(2, "管理员.png");
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabMain.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabMain.ControlBox.MenuBox.Name = "";
            this.tabMain.ControlBox.Name = "";
            this.tabMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMain.ControlBox.MenuBox,
            this.tabMain.ControlBox.CloseBox});
            this.tabMain.ControlBox.Visible = false;
            this.tabMain.Controls.Add(this.superTabControlPanel1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 52);
            this.tabMain.Name = "tabMain";
            this.tabMain.ReorderTabsEnabled = true;
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1234, 655);
            this.tabMain.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.TabIndex = 73;
            this.tabMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem2});
            this.tabMain.Text = "superTabControl1";
            this.tabMain.TabItemClose += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripTabItemCloseEventArgs>(this.tabMain_TabItemClose);
            this.tabMain.SelectedTabChanging += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangingEventArgs>(this.tabMain_SelectedTabChanging);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1234, 625);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel1;
            this.superTabItem2.CloseButtonVisible = false;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "主页";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.btnIP,
            this.btnLoginUserName,
            this.lblLocalTime});
            this.bar1.Location = new System.Drawing.Point(0, 707);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1234, 30);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 78;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "欢迎使用CIS系统";
            // 
            // btnIP
            // 
            this.btnIP.BeginGroup = true;
            this.btnIP.Name = "btnIP";
            this.btnIP.Text = "IP：192.168.0.211";
            // 
            // btnLoginUserName
            // 
            this.btnLoginUserName.BeginGroup = true;
            this.btnLoginUserName.Name = "btnLoginUserName";
            this.btnLoginUserName.Text = "当前登录用户：管理员";
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Text = "labelItem1";
            // 
            // panelEx2
            // 
            this.panelEx2.AutoSize = true;
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnAppList);
            this.panelEx2.Controls.Add(this.line1);
            this.panelEx2.Controls.Add(this.pnlViewUnit);
            this.panelEx2.Controls.Add(this.panelEx3);
            this.panelEx2.Controls.Add(this.Header);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1234, 52);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 79;
            // 
            // btnAppList
            // 
            this.btnAppList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAppList.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnAppList.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnAppList.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnAppList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAppList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnAppList.Location = new System.Drawing.Point(3, 9);
            this.btnAppList.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAppList.Name = "btnAppList";
            this.btnAppList.Radius = 10;
            this.btnAppList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.btnAppList.Size = new System.Drawing.Size(100, 35);
            this.btnAppList.Style = Sunny.UI.UIStyle.Custom;
            this.btnAppList.TabIndex = 83;
            this.btnAppList.Text = "CIS";
            this.btnAppList.Click += new System.EventHandler(this.btnAppList_Click);
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.line1.Location = new System.Drawing.Point(113, 6);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1, 38);
            this.line1.TabIndex = 4;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // pnlViewUnit
            // 
            this.pnlViewUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewUnit.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlViewUnit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlViewUnit.Controls.Add(this.btnDept);
            this.pnlViewUnit.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlViewUnit.Location = new System.Drawing.Point(1034, 6);
            this.pnlViewUnit.Name = "pnlViewUnit";
            this.pnlViewUnit.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.pnlViewUnit.Size = new System.Drawing.Size(153, 38);
            this.pnlViewUnit.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlViewUnit.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.pnlViewUnit.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.pnlViewUnit.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlViewUnit.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlViewUnit.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.pnlViewUnit.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlViewUnit.Style.GradientAngle = 90;
            this.pnlViewUnit.TabIndex = 2;
            // 
            // btnDept
            // 
            this.btnDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnDept.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnDept.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnDept.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btnDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnDept.Location = new System.Drawing.Point(3, 2);
            this.btnDept.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDept.Name = "btnDept";
            this.btnDept.Radius = 10;
            this.btnDept.RectColor = System.Drawing.Color.Transparent;
            this.btnDept.Size = new System.Drawing.Size(147, 35);
            this.btnDept.Style = Sunny.UI.UIStyle.Custom;
            this.btnDept.TabIndex = 0;
            this.btnDept.Text = "科室";
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.picUserLogo);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(1190, 6);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panelEx3.Size = new System.Drawing.Size(44, 38);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // picUserLogo
            // 
            this.picUserLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUserLogo.Location = new System.Drawing.Point(6, 3);
            this.picUserLogo.Name = "picUserLogo";
            this.picUserLogo.Size = new System.Drawing.Size(32, 32);
            this.picUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserLogo.TabIndex = 2;
            this.picUserLogo.TabStop = false;
            this.picUserLogo.Click += new System.EventHandler(this.picUserLogo_Click);
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.Header.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Header.ImageList = this._menuImgList;
            this.Header.Location = new System.Drawing.Point(124, 3);
            this.Header.MenuHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.Header.MenuSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Name = "Header";
            this.Header.NodeAlignment = System.Drawing.StringAlignment.Near;
            this.Header.NodeInterval = -20;
            this.Header.NodeSize = new System.Drawing.Size(160, 45);
            this.Header.SelectedForeColor = System.Drawing.Color.White;
            this.Header.SelectedHighColor = System.Drawing.Color.Transparent;
            this.Header.Size = new System.Drawing.Size(867, 46);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.TabIndex = 77;
            this.Header.Text = "uiNavBar1";
            // 
            // _menuDept
            // 
            this._menuDept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._menuDept.Name = "_menuDept";
            this._menuDept.Size = new System.Drawing.Size(61, 4);
            // 
            // _timerLocalTime
            // 
            this._timerLocalTime.Interval = 1000;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 737);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panelEx2);
            this.Name = "FormMain";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this._menuUserOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.pnlViewUnit.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControl tabMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private Sunny.UI.UINavBar Header;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private System.Windows.Forms.ImageList _menuImgList;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private Sunny.UI.UIButton btnAppList;
        private Sunny.UI.UIContextMenuStrip _menuApp;
        private DevComponents.DotNetBar.Controls.Line line1;
        private Sunny.UI.UIButton btnDept;
        private Sunny.UI.UIContextMenuStrip _menuUserOperation;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换工号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁屏ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picUserLogo;
        private System.Windows.Forms.ImageList _userImgList;
        private DevComponents.DotNetBar.PanelEx pnlViewUnit;
        private Sunny.UI.UIContextMenuStrip _menuDept;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnIP;
        private DevComponents.DotNetBar.ButtonItem btnLoginUserName;
        private System.Windows.Forms.Timer _timerLocalTime;
        private DevComponents.DotNetBar.LabelItem lblLocalTime;
    }
}

