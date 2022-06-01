namespace App_Sys.RoleManager
{
    partial class FormRoleManager
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoleManager));
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor3 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.dgvRoleUser = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colRoleUserCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoleUserName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoleUserId = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.treePermission = new DevComponents.AdvTree.AdvTree();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnSavePermission = new DevComponents.DotNetBar.ButtonItem();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvAllUser = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colAllUserCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAllUserName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAllUserId = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expandableSplitter4 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRole = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colRoleCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoleName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoleDescription = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoleId = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.barRoleList = new DevComponents.DotNetBar.Bar();
            this.btnRefreshRole = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddRole = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelRole = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeMenu = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveMenu = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter3 = new DevComponents.DotNetBar.ExpandableSplitter();
            ((System.ComponentModel.ISupportInitialize)(this.treePermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelEx5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barRoleList)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoleUser
            // 
            this.dgvRoleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRoleUser.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvRoleUser.Location = new System.Drawing.Point(0, 55);
            this.dgvRoleUser.Name = "dgvRoleUser";
            // 
            // 
            // 
            this.dgvRoleUser.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvRoleUser.PrimaryGrid.AllowRowResize = true;
            this.dgvRoleUser.PrimaryGrid.AutoGenerateColumns = false;
            this.dgvRoleUser.PrimaryGrid.Columns.Add(this.colRoleUserCode);
            this.dgvRoleUser.PrimaryGrid.Columns.Add(this.colRoleUserName);
            this.dgvRoleUser.PrimaryGrid.Columns.Add(this.colRoleUserId);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvRoleUser.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvRoleUser.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvRoleUser.PrimaryGrid.EnableFiltering = true;
            this.dgvRoleUser.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvRoleUser.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvRoleUser.PrimaryGrid.Filter.ShowPanelFilterExpr = true;
            this.dgvRoleUser.PrimaryGrid.Filter.Visible = true;
            this.dgvRoleUser.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvRoleUser.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvRoleUser.PrimaryGrid.MultiSelect = false;
            this.dgvRoleUser.PrimaryGrid.ReadOnly = true;
            this.dgvRoleUser.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvRoleUser.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.dgvRoleUser.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvRoleUser.Size = new System.Drawing.Size(366, 280);
            this.dgvRoleUser.TabIndex = 4;
            this.dgvRoleUser.Text = "superGridControl1";
            this.dgvRoleUser.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.dgvRoleUser_RowDoubleClick);
            // 
            // colRoleUserCode
            // 
            this.colRoleUserCode.DataPropertyName = "Code";
            this.colRoleUserCode.HeaderText = "工号";
            this.colRoleUserCode.Name = "gridCurrUser_Code";
            // 
            // colRoleUserName
            // 
            this.colRoleUserName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colRoleUserName.DataPropertyName = "Name";
            this.colRoleUserName.HeaderText = "姓名";
            this.colRoleUserName.Name = "girdCurrUser_Name";
            // 
            // colRoleUserId
            // 
            this.colRoleUserId.DataPropertyName = "Id";
            this.colRoleUserId.Name = "gridColumn1";
            this.colRoleUserId.Visible = false;
            // 
            // treePermission
            // 
            this.treePermission.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treePermission.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treePermission.BackgroundStyle.Class = "TreeBorderKey";
            this.treePermission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treePermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePermission.Font = new System.Drawing.Font("宋体", 10.5F);
            this.treePermission.ImageList = this.imageList;
            this.treePermission.Location = new System.Drawing.Point(0, 58);
            this.treePermission.Name = "treePermission";
            this.treePermission.NodesConnector = this.nodeConnector1;
            this.treePermission.NodeStyle = this.elementStyle1;
            this.treePermission.PathSeparator = ";";
            this.treePermission.Size = new System.Drawing.Size(270, 639);
            this.treePermission.Styles.Add(this.elementStyle1);
            this.treePermission.TabIndex = 5;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.ico");
            this.imageList.Images.SetKeyName(1, "2.ico");
            this.imageList.Images.SetKeyName(2, "3.ico");
            this.imageList.Images.SetKeyName(3, "4.ico");
            this.imageList.Images.SetKeyName(4, "5.ico");
            this.imageList.Images.SetKeyName(5, "6.ico");
            this.imageList.Images.SetKeyName(6, "7.ico");
            this.imageList.Images.SetKeyName(7, "8.ico");
            this.imageList.Images.SetKeyName(8, "9.ico");
            this.imageList.Images.SetKeyName(9, "10.ico");
            this.imageList.Images.SetKeyName(10, "11.ico");
            this.imageList.Images.SetKeyName(11, "12.ico");
            this.imageList.Images.SetKeyName(12, "13.ico");
            this.imageList.Images.SetKeyName(13, "14.ico");
            this.imageList.Images.SetKeyName(14, "15.ico");
            this.imageList.Images.SetKeyName(15, "16.ico");
            this.imageList.Images.SetKeyName(16, "17.ico");
            this.imageList.Images.SetKeyName(17, "18.ico");
            this.imageList.Images.SetKeyName(18, "19.ico");
            this.imageList.Images.SetKeyName(19, "20.ico");
            this.imageList.Images.SetKeyName(20, "21.ico");
            this.imageList.Images.SetKeyName(21, "22.ico");
            this.imageList.Images.SetKeyName(22, "23.ico");
            this.imageList.Images.SetKeyName(23, "24.ico");
            this.imageList.Images.SetKeyName(24, "25.ico");
            this.imageList.Images.SetKeyName(25, "26.ico");
            this.imageList.Images.SetKeyName(26, "27.ico");
            this.imageList.Images.SetKeyName(27, "28.ico");
            this.imageList.Images.SetKeyName(28, "29.ico");
            this.imageList.Images.SetKeyName(29, "30.ico");
            this.imageList.Images.SetKeyName(30, "31.ico");
            this.imageList.Images.SetKeyName(31, "32.ico");
            this.imageList.Images.SetKeyName(32, "33.ico");
            this.imageList.Images.SetKeyName(33, "34.ico");
            this.imageList.Images.SetKeyName(34, "35.ico");
            this.imageList.Images.SetKeyName(35, "36.ico");
            this.imageList.Images.SetKeyName(36, "37.ico");
            this.imageList.Images.SetKeyName(37, "38.ico");
            this.imageList.Images.SetKeyName(38, "39.ico");
            this.imageList.Images.SetKeyName(39, "40.ico");
            this.imageList.Images.SetKeyName(40, "41.ico");
            this.imageList.Images.SetKeyName(41, "42.ico");
            this.imageList.Images.SetKeyName(42, "43.ico");
            this.imageList.Images.SetKeyName(43, "44.ico");
            this.imageList.Images.SetKeyName(44, "45.ico");
            this.imageList.Images.SetKeyName(45, "46.ico");
            this.imageList.Images.SetKeyName(46, "47.ico");
            this.imageList.Images.SetKeyName(47, "48.ico");
            this.imageList.Images.SetKeyName(48, "49.ico");
            this.imageList.Images.SetKeyName(49, "50.ico");
            this.imageList.Images.SetKeyName(50, "51.ico");
            this.imageList.Images.SetKeyName(51, "52.ico");
            this.imageList.Images.SetKeyName(52, "53.ico");
            this.imageList.Images.SetKeyName(53, "54.ico");
            this.imageList.Images.SetKeyName(54, "55.ico");
            this.imageList.Images.SetKeyName(55, "56.ico");
            this.imageList.Images.SetKeyName(56, "57.ico");
            this.imageList.Images.SetKeyName(57, "58.ico");
            this.imageList.Images.SetKeyName(58, "59.ico");
            this.imageList.Images.SetKeyName(59, "60.ico");
            this.imageList.Images.SetKeyName(60, "61.ico");
            this.imageList.Images.SetKeyName(61, "62.ico");
            this.imageList.Images.SetKeyName(62, "63.ico");
            this.imageList.Images.SetKeyName(63, "64.ico");
            this.imageList.Images.SetKeyName(64, "65.ico");
            this.imageList.Images.SetKeyName(65, "66.ico");
            this.imageList.Images.SetKeyName(66, "67.ico");
            this.imageList.Images.SetKeyName(67, "68.ico");
            this.imageList.Images.SetKeyName(68, "69.ico");
            this.imageList.Images.SetKeyName(69, "70.ico");
            this.imageList.Images.SetKeyName(70, "71.ico");
            this.imageList.Images.SetKeyName(71, "72.ico");
            this.imageList.Images.SetKeyName(72, "73.ico");
            this.imageList.Images.SetKeyName(73, "74.ico");
            this.imageList.Images.SetKeyName(74, "75.ico");
            this.imageList.Images.SetKeyName(75, "76.ico");
            this.imageList.Images.SetKeyName(76, "77.ico");
            this.imageList.Images.SetKeyName(77, "78.ico");
            this.imageList.Images.SetKeyName(78, "79.ico");
            this.imageList.Images.SetKeyName(79, "80.ico");
            this.imageList.Images.SetKeyName(80, "81.ico");
            this.imageList.Images.SetKeyName(81, "82.ico");
            this.imageList.Images.SetKeyName(82, "83.ico");
            this.imageList.Images.SetKeyName(83, "84.ico");
            this.imageList.Images.SetKeyName(84, "85.ico");
            this.imageList.Images.SetKeyName(85, "86.ico");
            this.imageList.Images.SetKeyName(86, "87.ico");
            this.imageList.Images.SetKeyName(87, "88.ico");
            this.imageList.Images.SetKeyName(88, "89.ico");
            this.imageList.Images.SetKeyName(89, "90.ico");
            this.imageList.Images.SetKeyName(90, "91.ico");
            this.imageList.Images.SetKeyName(91, "92.ico");
            this.imageList.Images.SetKeyName(92, "93.ico");
            this.imageList.Images.SetKeyName(93, "94.ico");
            this.imageList.Images.SetKeyName(94, "95.ico");
            this.imageList.Images.SetKeyName(95, "96.ico");
            this.imageList.Images.SetKeyName(96, "97.ico");
            this.imageList.Images.SetKeyName(97, "98.ico");
            this.imageList.Images.SetKeyName(98, "99.ico");
            this.imageList.Images.SetKeyName(99, "100.ico");
            this.imageList.Images.SetKeyName(100, "101.ico");
            this.imageList.Images.SetKeyName(101, "102.ico");
            this.imageList.Images.SetKeyName(102, "103.ico");
            this.imageList.Images.SetKeyName(103, "104.ico");
            this.imageList.Images.SetKeyName(104, "105.ico");
            this.imageList.Images.SetKeyName(105, "106.ico");
            this.imageList.Images.SetKeyName(106, "107.ico");
            this.imageList.Images.SetKeyName(107, "108.ico");
            this.imageList.Images.SetKeyName(108, "109.ico");
            this.imageList.Images.SetKeyName(109, "110.ico");
            this.imageList.Images.SetKeyName(110, "111.ico");
            this.imageList.Images.SetKeyName(111, "112.ico");
            this.imageList.Images.SetKeyName(112, "113.ico");
            this.imageList.Images.SetKeyName(113, "114.ico");
            this.imageList.Images.SetKeyName(114, "115.ico");
            this.imageList.Images.SetKeyName(115, "116.ico");
            this.imageList.Images.SetKeyName(116, "117.ico");
            this.imageList.Images.SetKeyName(117, "118.ico");
            this.imageList.Images.SetKeyName(118, "119.ico");
            this.imageList.Images.SetKeyName(119, "120.ico");
            this.imageList.Images.SetKeyName(120, "121.ico");
            this.imageList.Images.SetKeyName(121, "122.ico");
            this.imageList.Images.SetKeyName(122, "123.ico");
            this.imageList.Images.SetKeyName(123, "124.ico");
            this.imageList.Images.SetKeyName(124, "125.ico");
            this.imageList.Images.SetKeyName(125, "126.ico");
            this.imageList.Images.SetKeyName(126, "127.ico");
            this.imageList.Images.SetKeyName(127, "128.ico");
            this.imageList.Images.SetKeyName(128, "129.ico");
            this.imageList.Images.SetKeyName(129, "130.ico");
            this.imageList.Images.SetKeyName(130, "131.ico");
            this.imageList.Images.SetKeyName(131, "132.ico");
            this.imageList.Images.SetKeyName(132, "133.ico");
            this.imageList.Images.SetKeyName(133, "134.ico");
            this.imageList.Images.SetKeyName(134, "135.ico");
            this.imageList.Images.SetKeyName(135, "136.ico");
            this.imageList.Images.SetKeyName(136, "137.ico");
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.Transparent;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Controls.Add(this.labelX9);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Right;
            this.bar1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSavePermission});
            this.bar1.Location = new System.Drawing.Point(0, 31);
            this.bar1.Name = "bar1";
            this.bar1.PaddingLeft = 5;
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(270, 27);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 4;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelX9.Location = new System.Drawing.Point(52, 2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(118, 18);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "单击或勾选添加权限";
            // 
            // btnSavePermission
            // 
            this.btnSavePermission.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSavePermission.Name = "btnSavePermission";
            this.btnSavePermission.Text = "保存";
            this.btnSavePermission.Click += new System.EventHandler(this.btnSavePermission_Click);
            // 
            // gridColumn3
            // 
            this.gridColumn3.DataPropertyName = "ID";
            this.gridColumn3.Name = "gridAllUser_ID";
            this.gridColumn3.Visible = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn5.DataPropertyName = "Name";
            this.gridColumn5.HeaderText = "姓名";
            this.gridColumn5.Name = "gridAllUser_Name";
            // 
            // gridColumn4
            // 
            this.gridColumn4.DataPropertyName = "Code";
            this.gridColumn4.HeaderText = "工号";
            this.gridColumn4.Name = "gridAllUser_Code";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.labelX5);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(366, 55);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderWidth = 0;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 4;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelX5.Location = new System.Drawing.Point(143, 27);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(81, 18);
            this.labelX5.TabIndex = 21;
            this.labelX5.Text = "双击移除用户";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(136, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 20);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "当前角色用户";
            // 
            // dgvAllUser
            // 
            this.dgvAllUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUser.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvAllUser.Location = new System.Drawing.Point(0, 399);
            this.dgvAllUser.Name = "dgvAllUser";
            // 
            // 
            // 
            this.dgvAllUser.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvAllUser.PrimaryGrid.AllowRowResize = true;
            this.dgvAllUser.PrimaryGrid.AutoGenerateColumns = false;
            this.dgvAllUser.PrimaryGrid.Columns.Add(this.colAllUserCode);
            this.dgvAllUser.PrimaryGrid.Columns.Add(this.colAllUserName);
            this.dgvAllUser.PrimaryGrid.Columns.Add(this.colAllUserId);
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            borderColor2.Left = System.Drawing.Color.Transparent;
            borderColor2.Right = System.Drawing.Color.Transparent;
            borderColor2.Top = System.Drawing.Color.Transparent;
            this.dgvAllUser.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            this.dgvAllUser.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvAllUser.PrimaryGrid.EnableFiltering = true;
            this.dgvAllUser.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvAllUser.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvAllUser.PrimaryGrid.Filter.ShowPanelFilterExpr = true;
            this.dgvAllUser.PrimaryGrid.Filter.Visible = true;
            this.dgvAllUser.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvAllUser.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvAllUser.PrimaryGrid.MultiSelect = false;
            this.dgvAllUser.PrimaryGrid.ReadOnly = true;
            this.dgvAllUser.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvAllUser.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.dgvAllUser.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvAllUser.Size = new System.Drawing.Size(366, 298);
            this.dgvAllUser.TabIndex = 19;
            this.dgvAllUser.Text = "superGridControl1";
            this.dgvAllUser.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.dgvAllUser_RowDoubleClick);
            // 
            // colAllUserCode
            // 
            this.colAllUserCode.DataPropertyName = "Code";
            this.colAllUserCode.HeaderText = "工号";
            this.colAllUserCode.Name = "gridCurrUser_Code";
            // 
            // colAllUserName
            // 
            this.colAllUserName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colAllUserName.DataPropertyName = "Name";
            this.colAllUserName.HeaderText = "姓名";
            this.colAllUserName.Name = "girdCurrUser_Name";
            // 
            // colAllUserId
            // 
            this.colAllUserId.DataPropertyName = "Id";
            this.colAllUserId.Name = "gridColumn1";
            this.colAllUserId.Visible = false;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.labelX2);
            this.panelEx4.Controls.Add(this.labelX3);
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx4.Location = new System.Drawing.Point(0, 341);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(366, 58);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.BorderWidth = 0;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelX2.Location = new System.Drawing.Point(50, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(266, 18);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "双击添加用户(仅能添加用户默认科室角色权限)";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(151, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 20);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "所有用户";
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.labelX7);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx5.Location = new System.Drawing.Point(0, 0);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(270, 31);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.BorderWidth = 0;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 8;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.FontBold = true;
            this.labelX7.Location = new System.Drawing.Point(110, 5);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(51, 20);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "权限集";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAllUser);
            this.panel1.Controls.Add(this.panelEx4);
            this.panel1.Controls.Add(this.expandableSplitter4);
            this.panel1.Controls.Add(this.dgvRoleUser);
            this.panel1.Controls.Add(this.panelEx3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 697);
            this.panel1.TabIndex = 23;
            // 
            // expandableSplitter4
            // 
            this.expandableSplitter4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter4.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter4.Expandable = false;
            this.expandableSplitter4.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter4.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter4.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter4.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter4.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter4.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter4.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter4.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter4.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter4.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter4.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter4.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter4.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter4.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter4.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter4.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter4.Location = new System.Drawing.Point(0, 335);
            this.expandableSplitter4.Name = "expandableSplitter4";
            this.expandableSplitter4.Size = new System.Drawing.Size(366, 6);
            this.expandableSplitter4.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter4.TabIndex = 27;
            this.expandableSplitter4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treePermission);
            this.panel2.Controls.Add(this.bar1);
            this.panel2.Controls.Add(this.panelEx5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1051, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 697);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvRole);
            this.panel3.Controls.Add(this.barRoleList);
            this.panel3.Controls.Add(this.panelEx2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 697);
            this.panel3.TabIndex = 25;
            // 
            // dgvRole
            // 
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvRole.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dgvRole.Location = new System.Drawing.Point(0, 58);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            // 
            // 
            // 
            this.dgvRole.PrimaryGrid.AutoGenerateColumns = false;
            this.dgvRole.PrimaryGrid.Columns.Add(this.colRoleCode);
            this.dgvRole.PrimaryGrid.Columns.Add(this.colRoleName);
            this.dgvRole.PrimaryGrid.Columns.Add(this.colRoleDescription);
            this.dgvRole.PrimaryGrid.Columns.Add(this.colRoleId);
            borderColor3.Bottom = System.Drawing.Color.Transparent;
            borderColor3.Left = System.Drawing.Color.Transparent;
            borderColor3.Right = System.Drawing.Color.Transparent;
            borderColor3.Top = System.Drawing.Color.Transparent;
            this.dgvRole.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor3;
            this.dgvRole.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvRole.PrimaryGrid.EnableFiltering = true;
            this.dgvRole.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvRole.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvRole.PrimaryGrid.Filter.Visible = true;
            this.dgvRole.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvRole.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvRole.PrimaryGrid.MultiSelect = false;
            this.dgvRole.PrimaryGrid.ReadOnly = true;
            this.dgvRole.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvRole.PrimaryGrid.RowHeaderWidth = 0;
            this.dgvRole.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvRole.Size = new System.Drawing.Size(273, 639);
            this.dgvRole.TabIndex = 6;
            this.dgvRole.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.dgvRole_RowClick);
            // 
            // colRoleCode
            // 
            this.colRoleCode.DataPropertyName = "Code";
            this.colRoleCode.HeaderText = "代码";
            this.colRoleCode.Name = "gridRole_Code";
            this.colRoleCode.Width = 150;
            // 
            // colRoleName
            // 
            this.colRoleName.DataPropertyName = "Name";
            this.colRoleName.HeaderText = "角色名称";
            this.colRoleName.Name = "gridRole_Name";
            this.colRoleName.Width = 150;
            // 
            // colRoleDescription
            // 
            this.colRoleDescription.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colRoleDescription.DataPropertyName = "Description";
            this.colRoleDescription.HeaderText = "角色描述";
            this.colRoleDescription.Name = "gridRole_Description";
            // 
            // colRoleId
            // 
            this.colRoleId.DataPropertyName = "Id";
            this.colRoleId.Name = "gridColumn8";
            this.colRoleId.Visible = false;
            // 
            // barRoleList
            // 
            this.barRoleList.AntiAlias = true;
            this.barRoleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.barRoleList.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barRoleList.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.barRoleList.IsMaximized = false;
            this.barRoleList.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefreshRole,
            this.btnAddRole,
            this.btnDelRole});
            this.barRoleList.Location = new System.Drawing.Point(0, 28);
            this.barRoleList.Name = "barRoleList";
            this.barRoleList.RoundCorners = false;
            this.barRoleList.Size = new System.Drawing.Size(273, 30);
            this.barRoleList.Stretch = true;
            this.barRoleList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barRoleList.TabIndex = 5;
            this.barRoleList.TabStop = false;
            this.barRoleList.Text = "bar1";
            // 
            // btnRefreshRole
            // 
            this.btnRefreshRole.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefreshRole.Name = "btnRefreshRole";
            this.btnRefreshRole.Text = "刷新";
            this.btnRefreshRole.Click += new System.EventHandler(this.btnRefreshRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Text = "添加";
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnDelRole
            // 
            this.btnDelRole.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelRole.Name = "btnDelRole";
            this.btnDelRole.Text = "删除";
            this.btnDelRole.Click += new System.EventHandler(this.btnDelRole_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX8);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(273, 28);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 0;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.FontBold = true;
            this.labelX8.Location = new System.Drawing.Point(104, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(65, 20);
            this.labelX8.TabIndex = 21;
            this.labelX8.Text = "角色列表";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter1.Expandable = false;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(273, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 697);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 26;
            this.expandableSplitter1.TabStop = false;
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter2.Expandable = false;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(1045, 0);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(6, 697);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 27;
            this.expandableSplitter2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.treeMenu);
            this.panel4.Controls.Add(this.bar2);
            this.panel4.Controls.Add(this.panelEx1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(651, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 697);
            this.panel4.TabIndex = 10;
            // 
            // treeMenu
            // 
            this.treeMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeMenu.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeMenu.BackgroundStyle.Class = "TreeBorderKey";
            this.treeMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.Font = new System.Drawing.Font("宋体", 10.5F);
            this.treeMenu.ImageList = this.imageList;
            this.treeMenu.Location = new System.Drawing.Point(0, 58);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.NodesConnector = this.nodeConnector2;
            this.treeMenu.NodeStyle = this.elementStyle2;
            this.treeMenu.PathSeparator = ";";
            this.treeMenu.Size = new System.Drawing.Size(394, 639);
            this.treeMenu.Styles.Add(this.elementStyle2);
            this.treeMenu.TabIndex = 13;
            this.treeMenu.AfterCheck += new DevComponents.AdvTree.AdvTreeCellEventHandler(this.treeMenu_AfterCheck);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.Color.Transparent;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Controls.Add(this.labelX4);
            this.bar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Right;
            this.bar2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveMenu});
            this.bar2.Location = new System.Drawing.Point(0, 31);
            this.bar2.Name = "bar2";
            this.bar2.PaddingLeft = 5;
            this.bar2.RoundCorners = false;
            this.bar2.Size = new System.Drawing.Size(394, 27);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 12;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelX4.Location = new System.Drawing.Point(52, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(176, 23);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "单击或勾选添加权限";
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Text = "保存";
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(394, 31);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 0;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 14;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.FontBold = true;
            this.labelX6.Location = new System.Drawing.Point(165, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(65, 20);
            this.labelX6.TabIndex = 21;
            this.labelX6.Text = "权限列表";
            // 
            // expandableSplitter3
            // 
            this.expandableSplitter3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter3.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter3.Expandable = false;
            this.expandableSplitter3.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter3.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter3.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter3.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter3.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter3.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter3.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter3.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter3.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter3.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter3.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter3.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter3.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter3.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter3.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter3.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter3.Location = new System.Drawing.Point(645, 0);
            this.expandableSplitter3.Name = "expandableSplitter3";
            this.expandableSplitter3.Size = new System.Drawing.Size(6, 697);
            this.expandableSplitter3.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter3.TabIndex = 28;
            this.expandableSplitter3.TabStop = false;
            // 
            // FormRoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 697);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.expandableSplitter3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.expandableSplitter2);
            this.Controls.Add(this.panel2);
            this.Name = "FormRoleManager";
            this.Text = "角色管理";
            this.Shown += new System.EventHandler(this.FormRoleManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.treePermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.bar1.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            this.panelEx5.ResumeLayout(false);
            this.panelEx5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barRoleList)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnSavePermission;
        private DevComponents.AdvTree.AdvTree treePermission;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvRoleUser;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleUserCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleUserName;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvAllUser;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAllUserCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAllUserName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvRole;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleDescription;
        private DevComponents.DotNetBar.Bar barRoleList;
        private DevComponents.DotNetBar.ButtonItem btnRefreshRole;
        private DevComponents.DotNetBar.ButtonItem btnAddRole;
        private DevComponents.DotNetBar.ButtonItem btnDelRole;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleId;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoleUserId;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAllUserId;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.AdvTree.AdvTree treeMenu;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonItem btnSaveMenu;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter3;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter4;
    }
}