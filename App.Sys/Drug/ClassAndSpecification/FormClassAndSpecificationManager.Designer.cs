namespace App_Sys.Drug
{
    partial class FormClassAndSpecificationManager
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.gridGG = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colYPCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGGCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colspm = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colgg = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colbzs = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.coldbzdw = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colxbzdw = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colzxjl = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colzxjldw = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colsccj = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colqyzt = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGGpym = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGGwbm = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ggBar = new DevComponents.DotNetBar.Bar();
            this.btnGGReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnGGAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnGGEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnGGEnable = new DevComponents.DotNetBar.ButtonItem();
            this.btnGGDisable = new DevComponents.DotNetBar.ButtonItem();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.gridYP = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colypbm = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colypmc = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.coljx = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colyytj = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colfyfs = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colkssjb = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colps = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.coldjlx = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colgmp = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colmzcf = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colzycf = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.delaytbxInput = new HIS.ControlLib.DelayTextBox();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnypReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnypAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnypEdit = new DevComponents.DotNetBar.ButtonItem();
            this.drugTypeTree = new DevComponents.AdvTree.AdvTree();
            this.rootNode = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ggBar)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugTypeTree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonItem2
            // 
            this.buttonItem2.FontBold = true;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "药品规格列表";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.gridGG);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.expandableSplitter1);
            this.panelEx1.Controls.Add(this.gridYP);
            this.panelEx1.Controls.Add(this.delaytbxInput);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(167, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1020, 640);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // gridGG
            // 
            this.gridGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGG.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridGG.Location = new System.Drawing.Point(0, 511);
            this.gridGG.Name = "gridGG";
            // 
            // 
            // 
            this.gridGG.PrimaryGrid.Columns.Add(this.colYPCode);
            this.gridGG.PrimaryGrid.Columns.Add(this.colGGCode);
            this.gridGG.PrimaryGrid.Columns.Add(this.colspm);
            this.gridGG.PrimaryGrid.Columns.Add(this.colgg);
            this.gridGG.PrimaryGrid.Columns.Add(this.colbzs);
            this.gridGG.PrimaryGrid.Columns.Add(this.coldbzdw);
            this.gridGG.PrimaryGrid.Columns.Add(this.colxbzdw);
            this.gridGG.PrimaryGrid.Columns.Add(this.colzxjl);
            this.gridGG.PrimaryGrid.Columns.Add(this.colzxjldw);
            this.gridGG.PrimaryGrid.Columns.Add(this.colsccj);
            this.gridGG.PrimaryGrid.Columns.Add(this.colqyzt);
            this.gridGG.PrimaryGrid.Columns.Add(this.colGGpym);
            this.gridGG.PrimaryGrid.Columns.Add(this.colGGwbm);
            this.gridGG.PrimaryGrid.Columns.Add(this.gridColumn1);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.gridGG.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.gridGG.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.gridGG.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.gridGG.Size = new System.Drawing.Size(1020, 129);
            this.gridGG.TabIndex = 28;
            this.gridGG.Text = "superGridControl1";
            this.gridGG.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gridGG_RowDoubleClick);
            // 
            // colYPCode
            // 
            this.colYPCode.Name = "药品编码";
            this.colYPCode.ReadOnly = true;
            // 
            // colGGCode
            // 
            this.colGGCode.Name = "规格编码";
            this.colGGCode.ReadOnly = true;
            // 
            // colspm
            // 
            this.colspm.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.colspm.Name = "商品名";
            this.colspm.ReadOnly = true;
            // 
            // colgg
            // 
            this.colgg.Name = "规格";
            this.colgg.ReadOnly = true;
            // 
            // colbzs
            // 
            this.colbzs.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colbzs.Name = "包装数";
            this.colbzs.ReadOnly = true;
            // 
            // coldbzdw
            // 
            this.coldbzdw.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.coldbzdw.Name = "大包装单位";
            this.coldbzdw.ReadOnly = true;
            // 
            // colxbzdw
            // 
            this.colxbzdw.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colxbzdw.Name = "小包装单位";
            this.colxbzdw.ReadOnly = true;
            // 
            // colzxjl
            // 
            this.colzxjl.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colzxjl.Name = "最小剂量";
            this.colzxjl.ReadOnly = true;
            // 
            // colzxjldw
            // 
            this.colzxjldw.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colzxjldw.Name = "最小剂量单位";
            this.colzxjldw.ReadOnly = true;
            // 
            // colsccj
            // 
            this.colsccj.Name = "生产厂家";
            this.colsccj.ReadOnly = true;
            // 
            // colqyzt
            // 
            this.colqyzt.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colqyzt.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colqyzt.Name = "启用状态";
            this.colqyzt.ReadOnly = true;
            // 
            // colGGpym
            // 
            this.colGGpym.Name = "拼音码";
            this.colGGpym.ReadOnly = true;
            // 
            // colGGwbm
            // 
            this.colGGwbm.Name = "五笔码";
            this.colGGwbm.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn1.Name = "";
            this.gridColumn1.ReadOnly = true;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.labelX2);
            this.panelEx3.Controls.Add(this.ggBar);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 456);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1020, 55);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 13;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(6, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "药品规格列表";
            // 
            // ggBar
            // 
            this.ggBar.AntiAlias = true;
            this.ggBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ggBar.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.ggBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ggBar.IsMaximized = false;
            this.ggBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGGReflesh,
            this.btnGGAdd,
            this.btnGGEdit,
            this.btnGGEnable,
            this.btnGGDisable});
            this.ggBar.Location = new System.Drawing.Point(0, 29);
            this.ggBar.Name = "ggBar";
            this.ggBar.RoundCorners = false;
            this.ggBar.Size = new System.Drawing.Size(1020, 26);
            this.ggBar.Stretch = true;
            this.ggBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ggBar.TabIndex = 8;
            this.ggBar.TabStop = false;
            this.ggBar.Text = "bar3";
            // 
            // btnGGReflesh
            // 
            this.btnGGReflesh.Name = "btnGGReflesh";
            this.btnGGReflesh.Text = "刷新";
            this.btnGGReflesh.Click += new System.EventHandler(this.btnGGReflesh_Click);
            // 
            // btnGGAdd
            // 
            this.btnGGAdd.BeginGroup = true;
            this.btnGGAdd.Name = "btnGGAdd";
            this.btnGGAdd.Text = "添加";
            this.btnGGAdd.Click += new System.EventHandler(this.btnGGAdd_Click);
            // 
            // btnGGEdit
            // 
            this.btnGGEdit.Name = "btnGGEdit";
            this.btnGGEdit.Text = "修改";
            this.btnGGEdit.Click += new System.EventHandler(this.btnGGEdit_Click);
            // 
            // btnGGEnable
            // 
            this.btnGGEnable.BeginGroup = true;
            this.btnGGEnable.Name = "btnGGEnable";
            this.btnGGEnable.Text = "启用";
            this.btnGGEnable.Click += new System.EventHandler(this.btnGGEnable_Click);
            // 
            // btnGGDisable
            // 
            this.btnGGDisable.Name = "btnGGDisable";
            this.btnGGDisable.Text = "停用";
            this.btnGGDisable.Click += new System.EventHandler(this.btnGGDisable_Click);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.ExpandActionClick = false;
            this.expandableSplitter1.Expanded = false;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 450);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(1020, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 17;
            this.expandableSplitter1.TabStop = false;
            // 
            // gridYP
            // 
            this.gridYP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridYP.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridYP.Location = new System.Drawing.Point(0, 78);
            this.gridYP.Name = "gridYP";
            // 
            // 
            // 
            this.gridYP.PrimaryGrid.Columns.Add(this.colypbm);
            this.gridYP.PrimaryGrid.Columns.Add(this.colypmc);
            this.gridYP.PrimaryGrid.Columns.Add(this.coljx);
            this.gridYP.PrimaryGrid.Columns.Add(this.colyytj);
            this.gridYP.PrimaryGrid.Columns.Add(this.colfyfs);
            this.gridYP.PrimaryGrid.Columns.Add(this.colkssjb);
            this.gridYP.PrimaryGrid.Columns.Add(this.colps);
            this.gridYP.PrimaryGrid.Columns.Add(this.coldjlx);
            this.gridYP.PrimaryGrid.Columns.Add(this.colgmp);
            this.gridYP.PrimaryGrid.Columns.Add(this.colmzcf);
            this.gridYP.PrimaryGrid.Columns.Add(this.colzycf);
            this.gridYP.PrimaryGrid.Columns.Add(this.gridColumn2);
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            this.gridYP.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            this.gridYP.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.gridYP.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.gridYP.PrimaryGrid.MultiSelect = false;
            this.gridYP.Size = new System.Drawing.Size(1020, 372);
            this.gridYP.TabIndex = 1;
            this.gridYP.Text = "superGridControl1";
            this.gridYP.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.gridClass_RowDoubleClick);
            this.gridYP.SelectionChanged += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEventArgs>(this.gridClass_SelectionChanged);
            // 
            // colypbm
            // 
            this.colypbm.Name = "药品编码";
            this.colypbm.ReadOnly = true;
            // 
            // colypmc
            // 
            this.colypmc.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.colypmc.Name = "药品名称";
            this.colypmc.ReadOnly = true;
            // 
            // coljx
            // 
            this.coljx.Name = "剂型";
            this.coljx.ReadOnly = true;
            // 
            // colyytj
            // 
            this.colyytj.Name = "用药途径";
            this.colyytj.ReadOnly = true;
            // 
            // colfyfs
            // 
            this.colfyfs.Name = "发药方式";
            this.colfyfs.ReadOnly = true;
            // 
            // colkssjb
            // 
            this.colkssjb.Name = "抗生素级别";
            this.colkssjb.ReadOnly = true;
            // 
            // colps
            // 
            this.colps.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colps.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colps.Name = "是否皮试";
            this.colps.ReadOnly = true;
            // 
            // coldjlx
            // 
            this.coldjlx.Name = "定价类型";
            this.coldjlx.ReadOnly = true;
            // 
            // colgmp
            // 
            this.colgmp.Name = "GMP编号";
            this.colgmp.ReadOnly = true;
            // 
            // colmzcf
            // 
            this.colmzcf.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colmzcf.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colmzcf.Name = "门诊可拆分";
            this.colmzcf.ReadOnly = true;
            // 
            // colzycf
            // 
            this.colzycf.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colzycf.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colzycf.Name = "住院可拆分";
            this.colzycf.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn2.Name = "";
            this.gridColumn2.ReadOnly = true;
            // 
            // delaytbxInput
            // 
            // 
            // 
            // 
            this.delaytbxInput.Border.Class = "TextBoxBorder";
            this.delaytbxInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delaytbxInput.DelayTime = 200;
            this.delaytbxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.delaytbxInput.Location = new System.Drawing.Point(0, 55);
            this.delaytbxInput.MarkString = null;
            this.delaytbxInput.Name = "delaytbxInput";
            this.delaytbxInput.PreventEnterBeep = true;
            this.delaytbxInput.Size = new System.Drawing.Size(1020, 23);
            this.delaytbxInput.TabIndex = 0;
            this.delaytbxInput.WatermarkText = "请输入名称、拼音码、五笔码检索";
            this.delaytbxInput.TextChanged += new System.EventHandler(this.delaytbxInput_TextChanged);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.bar1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1020, 55);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(6, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "药品品种列表";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnypReflesh,
            this.btnypAdd,
            this.btnypEdit});
            this.bar1.Location = new System.Drawing.Point(0, 29);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1020, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnypReflesh
            // 
            this.btnypReflesh.Name = "btnypReflesh";
            this.btnypReflesh.Text = "刷新";
            this.btnypReflesh.Click += new System.EventHandler(this.btnClassReflesh_Click);
            // 
            // btnypAdd
            // 
            this.btnypAdd.BeginGroup = true;
            this.btnypAdd.Name = "btnypAdd";
            this.btnypAdd.Text = "添加";
            this.btnypAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // btnypEdit
            // 
            this.btnypEdit.Name = "btnypEdit";
            this.btnypEdit.Text = "修改";
            this.btnypEdit.Click += new System.EventHandler(this.btnClassEdit_Click);
            // 
            // drugTypeTree
            // 
            this.drugTypeTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.drugTypeTree.AllowDrop = false;
            this.drugTypeTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.drugTypeTree.BackgroundStyle.Class = "TreeBorderKey";
            this.drugTypeTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.drugTypeTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.drugTypeTree.Location = new System.Drawing.Point(0, 0);
            this.drugTypeTree.Name = "drugTypeTree";
            this.drugTypeTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.rootNode});
            this.drugTypeTree.NodesConnector = this.nodeConnector1;
            this.drugTypeTree.NodeStyle = this.elementStyle1;
            this.drugTypeTree.PathSeparator = ";";
            this.drugTypeTree.Size = new System.Drawing.Size(167, 640);
            this.drugTypeTree.Styles.Add(this.elementStyle1);
            this.drugTypeTree.TabIndex = 0;
            this.drugTypeTree.Text = "advTree1";
            // 
            // rootNode
            // 
            this.rootNode.Expanded = true;
            this.rootNode.Name = "rootNode";
            this.rootNode.Text = "药品类型";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // FormClassAndSpecificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 640);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.drugTypeTree);
            this.Name = "FormClassAndSpecificationManager";
            this.Text = "药品品种及规格管理";
            this.Shown += new System.EventHandler(this.FormClassAndSpecificationManager_Shown);
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ggBar)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugTypeTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree drugTypeTree;
        private DevComponents.AdvTree.Node rootNode;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnypReflesh;
        private HIS.ControlLib.DelayTextBox delaytbxInput;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridYP;
        private DevComponents.DotNetBar.ButtonItem btnypAdd;
        private DevComponents.DotNetBar.ButtonItem btnypEdit;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.Bar ggBar;
        private DevComponents.DotNetBar.ButtonItem btnGGEdit;
        private DevComponents.DotNetBar.ButtonItem btnGGAdd;
        private DevComponents.DotNetBar.ButtonItem btnGGReflesh;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colypbm;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colypmc;
        private DevComponents.DotNetBar.SuperGrid.GridColumn coljx;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colyytj;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colkssjb;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colps;
        private DevComponents.DotNetBar.SuperGrid.GridColumn coldjlx;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colgmp;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colmzcf;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colzycf;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridGG;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colYPCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colGGCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colspm;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colgg;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colbzs;
        private DevComponents.DotNetBar.SuperGrid.GridColumn coldbzdw;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colxbzdw;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colzxjl;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colzxjldw;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colsccj;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colqyzt;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.ButtonItem btnGGEnable;
        private DevComponents.DotNetBar.ButtonItem btnGGDisable;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colGGpym;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colGGwbm;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colfyfs;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
    }
}