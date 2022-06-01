namespace App_Sys.Dic
{
    partial class FormDosageformUsageMapper
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor3 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbDosageform = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dgvAllUsage = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnAddToDrugform = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvDrugformUsage = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colExistName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistDefault = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.btnDeleteFromDrugform = new DevComponents.DotNetBar.ButtonItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panelEx5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbDosageform);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panelEx1.Size = new System.Drawing.Size(273, 664);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 0;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 52;
            // 
            // lbDosageform
            // 
            this.lbDosageform.AutoScroll = true;
            // 
            // 
            // 
            this.lbDosageform.BackgroundStyle.Class = "ListBoxAdv";
            this.lbDosageform.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDosageform.ContainerControlProcessDialogKey = true;
            this.lbDosageform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDosageform.DragDropSupport = true;
            this.lbDosageform.Location = new System.Drawing.Point(0, 30);
            this.lbDosageform.Name = "lbDosageform";
            this.lbDosageform.Size = new System.Drawing.Size(273, 634);
            this.lbDosageform.TabIndex = 53;
            this.lbDosageform.Text = "listBoxAdv1";
            this.lbDosageform.ItemClick += new System.EventHandler(this.lbDosageform_ItemClick);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(6, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "剂型列表";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(273, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 664);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 56;
            this.expandableSplitter1.TabStop = false;
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.pnlTop);
            this.pnlAll.Controls.Add(this.expandableSplitter2);
            this.pnlAll.Controls.Add(this.pnlBottom);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(279, 0);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(843, 664);
            this.pnlAll.TabIndex = 57;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.dgvAllUsage);
            this.pnlTop.Controls.Add(this.panelEx5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(843, 351);
            this.pnlTop.TabIndex = 3;
            // 
            // dgvAllUsage
            // 
            this.dgvAllUsage.BackColor = System.Drawing.Color.White;
            this.dgvAllUsage.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor3.Bottom = System.Drawing.Color.Transparent;
            borderColor3.Left = System.Drawing.Color.Transparent;
            borderColor3.Right = System.Drawing.Color.Transparent;
            borderColor3.Top = System.Drawing.Color.Transparent;
            this.dgvAllUsage.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor3;
            this.dgvAllUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUsage.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvAllUsage.ForeColor = System.Drawing.Color.Black;
            this.dgvAllUsage.Location = new System.Drawing.Point(0, 55);
            this.dgvAllUsage.Name = "dgvAllUsage";
            // 
            // 
            // 
            this.dgvAllUsage.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvAllUsage.PrimaryGrid.AllowRowResize = true;
            this.dgvAllUsage.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvAllUsage.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvAllUsage.PrimaryGrid.Columns.Add(this.colName);
            this.dgvAllUsage.PrimaryGrid.Columns.Add(this.colCode);
            this.dgvAllUsage.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.dgvAllUsage.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvAllUsage.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvAllUsage.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAllUsage.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAllUsage.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvAllUsage.PrimaryGrid.EnableFiltering = true;
            this.dgvAllUsage.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvAllUsage.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvAllUsage.PrimaryGrid.Filter.Visible = true;
            this.dgvAllUsage.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvAllUsage.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvAllUsage.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvAllUsage.PrimaryGrid.NullString = "<<null>>";
            this.dgvAllUsage.PrimaryGrid.ReadOnly = true;
            this.dgvAllUsage.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvAllUsage.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvAllUsage.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvAllUsage.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvAllUsage.Size = new System.Drawing.Size(843, 296);
            this.dgvAllUsage.TabIndex = 43;
            this.dgvAllUsage.Text = "superGridControl2";
            this.dgvAllUsage.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvAllUsage_CellDoubleClick);
            // 
            // colName
            // 
            this.colName.Name = "用法名称";
            this.colName.Width = 150;
            // 
            // colCode
            // 
            this.colCode.Name = "用法编码";
            // 
            // colSearchCode
            // 
            this.colSearchCode.Name = "检索码";
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.Name = "";
            this.colWhite.ReadOnly = true;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.bar2);
            this.panelEx5.Controls.Add(this.labelX1);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx5.Location = new System.Drawing.Point(0, 0);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(843, 55);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.BorderWidth = 0;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 47;
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.ColorScheme.BarBackground = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.bar2.ColorScheme.BarCaptionBackground = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(254)))));
            this.bar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar2.DockTabStripHeight = 30;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddToDrugform});
            this.bar2.Location = new System.Drawing.Point(0, 29);
            this.bar2.Name = "bar2";
            this.bar2.RoundCorners = false;
            this.bar2.Size = new System.Drawing.Size(843, 26);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 24;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnAddToDrugform
            // 
            this.btnAddToDrugform.Name = "btnAddToDrugform";
            this.btnAddToDrugform.Text = "添加";
            this.btnAddToDrugform.Click += new System.EventHandler(this.btnAddToDrugform_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "待选用法列表";
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandableSplitter2.Expandable = false;
            this.expandableSplitter2.Expanded = false;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(0, 351);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(843, 6);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 6;
            this.expandableSplitter2.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgvDrugformUsage);
            this.pnlBottom.Controls.Add(this.panelEx2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 357);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(843, 307);
            this.pnlBottom.TabIndex = 4;
            // 
            // dgvDrugformUsage
            // 
            this.dgvDrugformUsage.BackColor = System.Drawing.Color.White;
            this.dgvDrugformUsage.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvDrugformUsage.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvDrugformUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrugformUsage.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvDrugformUsage.ForeColor = System.Drawing.Color.Black;
            this.dgvDrugformUsage.Location = new System.Drawing.Point(0, 55);
            this.dgvDrugformUsage.Name = "dgvDrugformUsage";
            // 
            // 
            // 
            this.dgvDrugformUsage.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvDrugformUsage.PrimaryGrid.AllowRowResize = true;
            this.dgvDrugformUsage.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvDrugformUsage.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvDrugformUsage.PrimaryGrid.Columns.Add(this.colExistName);
            this.dgvDrugformUsage.PrimaryGrid.Columns.Add(this.colExistCode);
            this.dgvDrugformUsage.PrimaryGrid.Columns.Add(this.colExistSearchCode);
            this.dgvDrugformUsage.PrimaryGrid.Columns.Add(this.colExistDefault);
            this.dgvDrugformUsage.PrimaryGrid.Columns.Add(this.colExistWhite);
            this.dgvDrugformUsage.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvDrugformUsage.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvDrugformUsage.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvDrugformUsage.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvDrugformUsage.PrimaryGrid.EnableFiltering = true;
            this.dgvDrugformUsage.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvDrugformUsage.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvDrugformUsage.PrimaryGrid.Filter.Visible = true;
            this.dgvDrugformUsage.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvDrugformUsage.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvDrugformUsage.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvDrugformUsage.PrimaryGrid.NullString = "<<null>>";
            this.dgvDrugformUsage.PrimaryGrid.ReadOnly = true;
            this.dgvDrugformUsage.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvDrugformUsage.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvDrugformUsage.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvDrugformUsage.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvDrugformUsage.Size = new System.Drawing.Size(843, 252);
            this.dgvDrugformUsage.TabIndex = 55;
            this.dgvDrugformUsage.Text = "superGridControl2";
            this.dgvDrugformUsage.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvDrugformUsage_CellClick);
            this.dgvDrugformUsage.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvDrugformUsage_CellDoubleClick);
            // 
            // colExistName
            // 
            this.colExistName.Name = "用法名称";
            this.colExistName.Width = 150;
            // 
            // colExistCode
            // 
            this.colExistCode.Name = "用法编码";
            // 
            // colExistSearchCode
            // 
            this.colExistSearchCode.Name = "检索码";
            // 
            // colExistDefault
            // 
            this.colExistDefault.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colExistDefault.Name = "是否默认";
            this.colExistDefault.ReadOnly = true;
            // 
            // colExistWhite
            // 
            this.colExistWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colExistWhite.Name = " ";
            this.colExistWhite.ReadOnly = true;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.bar3);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(843, 55);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 0;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 51;
            // 
            // bar3
            // 
            this.bar3.AntiAlias = true;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar3.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar3.DockTabStripHeight = 30;
            this.bar3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar3.IsMaximized = false;
            this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDeleteFromDrugform});
            this.bar3.Location = new System.Drawing.Point(0, 29);
            this.bar3.Name = "bar3";
            this.bar3.RoundCorners = false;
            this.bar3.Size = new System.Drawing.Size(843, 26);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 24;
            this.bar3.TabStop = false;
            this.bar3.Text = "bar3";
            // 
            // btnDeleteFromDrugform
            // 
            this.btnDeleteFromDrugform.Name = "btnDeleteFromDrugform";
            this.btnDeleteFromDrugform.Text = "删除";
            this.btnDeleteFromDrugform.Click += new System.EventHandler(this.btnDeleteFromDrugform_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 23);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "已选用法列表";
            // 
            // FormDosageformUsageMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 664);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormDosageformUsageMapper";
            this.Text = "剂型和用法对应";
            this.Shown += new System.EventHandler(this.FormDosageformUsageMapper_Shown);
            this.panelEx1.ResumeLayout(false);
            this.pnlAll.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panelEx5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ListBoxAdv lbDosageform;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Panel pnlTop;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvAllUsage;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnAddToDrugform;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private System.Windows.Forms.Panel pnlBottom;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.ButtonItem btnDeleteFromDrugform;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvDrugformUsage;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistWhite;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistDefault;
    }
}