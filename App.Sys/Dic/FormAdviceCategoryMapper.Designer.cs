
namespace App_Sys.Dic
{
    partial class FormAdviceCategoryMapper
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dgvAllAdvice = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSpell = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSample = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBuret = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPart = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colModality = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnAddToCategory = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvCategoryAdvice = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colExistName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistSpell = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistSample = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistBuret = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistPart = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistModality = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExistWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.btnDeleteFromCategory = new DevComponents.DotNetBar.ButtonItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeCategory = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAddCategory = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditCategory = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeleteCategory = new DevComponents.DotNetBar.ButtonItem();
            this.tabType = new DevComponents.DotNetBar.SuperTabStrip();
            this.tabTest = new DevComponents.DotNetBar.SuperTabItem();
            this.tabInspect = new DevComponents.DotNetBar.SuperTabItem();
            this.pnlForm.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panelEx5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlAll);
            this.pnlForm.Controls.Add(this.expandableSplitter2);
            this.pnlForm.Controls.Add(this.panel1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 30);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1235, 768);
            this.pnlForm.TabIndex = 8;
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.pnlTop);
            this.pnlAll.Controls.Add(this.expandableSplitter1);
            this.pnlAll.Controls.Add(this.pnlBottom);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(280, 0);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(955, 768);
            this.pnlAll.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.dgvAllAdvice);
            this.pnlTop.Controls.Add(this.panelEx5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(955, 455);
            this.pnlTop.TabIndex = 3;
            // 
            // dgvAllAdvice
            // 
            this.dgvAllAdvice.BackColor = System.Drawing.Color.White;
            this.dgvAllAdvice.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor3.Bottom = System.Drawing.Color.Transparent;
            borderColor3.Left = System.Drawing.Color.Transparent;
            borderColor3.Right = System.Drawing.Color.Transparent;
            borderColor3.Top = System.Drawing.Color.Transparent;
            this.dgvAllAdvice.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor3;
            this.dgvAllAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllAdvice.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvAllAdvice.ForeColor = System.Drawing.Color.Black;
            this.dgvAllAdvice.Location = new System.Drawing.Point(0, 55);
            this.dgvAllAdvice.Name = "dgvAllAdvice";
            // 
            // 
            // 
            this.dgvAllAdvice.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvAllAdvice.PrimaryGrid.AllowRowResize = true;
            this.dgvAllAdvice.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvAllAdvice.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colName);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colPrice);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colSpell);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colSample);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colBuret);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colPart);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colModality);
            this.dgvAllAdvice.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvAllAdvice.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvAllAdvice.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAllAdvice.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAllAdvice.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvAllAdvice.PrimaryGrid.EnableFiltering = true;
            this.dgvAllAdvice.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvAllAdvice.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvAllAdvice.PrimaryGrid.Filter.Visible = true;
            this.dgvAllAdvice.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvAllAdvice.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvAllAdvice.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvAllAdvice.PrimaryGrid.NullString = "<<null>>";
            this.dgvAllAdvice.PrimaryGrid.ReadOnly = true;
            this.dgvAllAdvice.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvAllAdvice.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvAllAdvice.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvAllAdvice.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvAllAdvice.Size = new System.Drawing.Size(955, 400);
            this.dgvAllAdvice.TabIndex = 43;
            this.dgvAllAdvice.Text = "superGridControl2";
            this.dgvAllAdvice.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvAllAdvice_CellDoubleClick);
            // 
            // colName
            // 
            this.colName.Name = "医嘱名";
            this.colName.Width = 300;
            // 
            // colPrice
            // 
            this.colPrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colPrice.Name = "总价";
            // 
            // colSpell
            // 
            this.colSpell.Name = "拼音码";
            // 
            // colSample
            // 
            this.colSample.Name = "标本类型";
            // 
            // colBuret
            // 
            this.colBuret.Name = "试管类型";
            // 
            // colPart
            // 
            this.colPart.Name = "检查部位";
            // 
            // colModality
            // 
            this.colModality.Name = "设备类型";
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
            this.panelEx5.Size = new System.Drawing.Size(955, 55);
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
            this.bar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar2.DockTabStripHeight = 30;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddToCategory});
            this.bar2.Location = new System.Drawing.Point(0, 29);
            this.bar2.Name = "bar2";
            this.bar2.RoundCorners = false;
            this.bar2.Size = new System.Drawing.Size(955, 26);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 24;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnAddToCategory
            // 
            this.btnAddToCategory.Name = "btnAddToCategory";
            this.btnAddToCategory.Text = "添加";
            this.btnAddToCategory.Click += new System.EventHandler(this.btnAddToCategory_Click);
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
            this.labelX1.Text = "待选医嘱列表";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandableSplitter1.Expandable = false;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 455);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(955, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 6;
            this.expandableSplitter1.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgvCategoryAdvice);
            this.pnlBottom.Controls.Add(this.panelEx1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 461);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(955, 307);
            this.pnlBottom.TabIndex = 4;
            // 
            // dgvCategoryAdvice
            // 
            this.dgvCategoryAdvice.BackColor = System.Drawing.Color.White;
            this.dgvCategoryAdvice.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvCategoryAdvice.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvCategoryAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoryAdvice.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvCategoryAdvice.ForeColor = System.Drawing.Color.Black;
            this.dgvCategoryAdvice.Location = new System.Drawing.Point(0, 55);
            this.dgvCategoryAdvice.Name = "dgvCategoryAdvice";
            // 
            // 
            // 
            this.dgvCategoryAdvice.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvCategoryAdvice.PrimaryGrid.AllowRowResize = true;
            this.dgvCategoryAdvice.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvCategoryAdvice.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistName);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistPrice);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistSpell);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistSample);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistBuret);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistPart);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistModality);
            this.dgvCategoryAdvice.PrimaryGrid.Columns.Add(this.colExistWhite);
            this.dgvCategoryAdvice.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvCategoryAdvice.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvCategoryAdvice.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvCategoryAdvice.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvCategoryAdvice.PrimaryGrid.EnableFiltering = true;
            this.dgvCategoryAdvice.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvCategoryAdvice.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvCategoryAdvice.PrimaryGrid.Filter.Visible = true;
            this.dgvCategoryAdvice.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvCategoryAdvice.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvCategoryAdvice.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvCategoryAdvice.PrimaryGrid.NullString = "<<null>>";
            this.dgvCategoryAdvice.PrimaryGrid.ReadOnly = true;
            this.dgvCategoryAdvice.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvCategoryAdvice.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvCategoryAdvice.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvCategoryAdvice.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvCategoryAdvice.Size = new System.Drawing.Size(955, 252);
            this.dgvCategoryAdvice.TabIndex = 44;
            this.dgvCategoryAdvice.Text = "superGridControl2";
            this.dgvCategoryAdvice.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvCategoryAdvice_CellDoubleClick);
            // 
            // colExistName
            // 
            this.colExistName.Name = "医嘱名";
            this.colExistName.Width = 300;
            // 
            // colExistPrice
            // 
            this.colExistPrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colExistPrice.Name = "总价";
            // 
            // colExistSpell
            // 
            this.colExistSpell.Name = "拼音码";
            // 
            // colExistSample
            // 
            this.colExistSample.Name = "标本类型";
            // 
            // colExistBuret
            // 
            this.colExistBuret.Name = "试管类型";
            // 
            // colExistPart
            // 
            this.colExistPart.Name = "检查部位";
            // 
            // colExistModality
            // 
            this.colExistModality.Name = "设备类型";
            // 
            // colExistWhite
            // 
            this.colExistWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colExistWhite.Name = "";
            this.colExistWhite.ReadOnly = true;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bar3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(955, 55);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 0;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 51;
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
            this.btnDeleteFromCategory});
            this.bar3.Location = new System.Drawing.Point(0, 29);
            this.bar3.Name = "bar3";
            this.bar3.RoundCorners = false;
            this.bar3.Size = new System.Drawing.Size(955, 26);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 24;
            this.bar3.TabStop = false;
            this.bar3.Text = "bar3";
            // 
            // btnDeleteFromCategory
            // 
            this.btnDeleteFromCategory.Name = "btnDeleteFromCategory";
            this.btnDeleteFromCategory.Text = "删除";
            this.btnDeleteFromCategory.Click += new System.EventHandler(this.btnDeleteFromCategory_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "已选医嘱列表";
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.expandableSplitter2.Location = new System.Drawing.Point(274, 0);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(6, 768);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 10;
            this.expandableSplitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeCategory);
            this.panel1.Controls.Add(this.bar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 768);
            this.panel1.TabIndex = 1;
            // 
            // treeCategory
            // 
            this.treeCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.treeCategory.BackgroundStyle.Class = "TreeBorderKey";
            this.treeCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCategory.DragDropEnabled = false;
            this.treeCategory.DragDropNodeCopyEnabled = false;
            this.treeCategory.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.treeCategory.Location = new System.Drawing.Point(0, 26);
            this.treeCategory.Name = "treeCategory";
            this.treeCategory.NodesConnector = this.nodeConnector1;
            this.treeCategory.NodeStyle = this.elementStyle1;
            this.treeCategory.PathSeparator = ";";
            this.treeCategory.Size = new System.Drawing.Size(274, 742);
            this.treeCategory.Styles.Add(this.elementStyle1);
            this.treeCategory.TabIndex = 1;
            this.treeCategory.Text = "advTree1";
            this.treeCategory.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeCategory_NodeClick);
            this.treeCategory.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeCategory_NodeDoubleClick);
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
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Left;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddCategory,
            this.btnEditCategory,
            this.btnDeleteCategory});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(274, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Text = "添加分类";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Text = "编辑分类";
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Text = "删除分类";
            // 
            // tabType
            // 
            this.tabType.AutoCloseTabs = false;
            this.tabType.AutoSelectAttachedControl = false;
            // 
            // 
            // 
            this.tabType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabType.CloseButtonOnTabsAlwaysDisplayed = false;
            this.tabType.ContainerControlProcessDialogKey = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabType.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabType.ControlBox.MenuBox.Name = "";
            this.tabType.ControlBox.Name = "";
            this.tabType.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabType.ControlBox.MenuBox,
            this.tabType.ControlBox.CloseBox});
            this.tabType.ControlBox.Visible = false;
            this.tabType.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabType.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabType.Location = new System.Drawing.Point(0, 0);
            this.tabType.Name = "tabType";
            this.tabType.ReorderTabsEnabled = true;
            this.tabType.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabType.SelectedTabIndex = 0;
            this.tabType.Size = new System.Drawing.Size(1235, 30);
            this.tabType.TabCloseButtonHot = null;
            this.tabType.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabType.TabIndex = 7;
            this.tabType.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabTest,
            this.tabInspect});
            this.tabType.Text = "superTabStrip1";
            this.tabType.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tabType_SelectedTabChanged);
            // 
            // tabTest
            // 
            this.tabTest.GlobalItem = false;
            this.tabTest.Name = "tabTest";
            this.tabTest.Text = "检验归类";
            // 
            // tabInspect
            // 
            this.tabInspect.GlobalItem = false;
            this.tabInspect.Name = "tabInspect";
            this.tabInspect.Text = "检查归类";
            // 
            // FormAdviceCategoryMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 798);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.tabType);
            this.Name = "FormAdviceCategoryMapper";
            this.Text = "检验检查归类";
            this.Shown += new System.EventHandler(this.FormAdviceCategoryMapper_Shown);
            this.pnlForm.ResumeLayout(false);
            this.pnlAll.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panelEx5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvCategoryAdvice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistSample;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistBuret;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistPart;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistModality;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistWhite;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvAllAdvice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSample;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBuret;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPart;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colModality;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.SuperTabStrip tabType;
        private DevComponents.DotNetBar.SuperTabItem tabTest;
        private System.Windows.Forms.Panel pnlForm;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAddCategory;
        private DevComponents.DotNetBar.ButtonItem btnEditCategory;
        private DevComponents.DotNetBar.ButtonItem btnDeleteCategory;
        private DevComponents.DotNetBar.SuperTabItem tabInspect;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.AdvTree.AdvTree treeCategory;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSpell;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExistSpell;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnAddToCategory;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.ButtonItem btnDeleteFromCategory;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}