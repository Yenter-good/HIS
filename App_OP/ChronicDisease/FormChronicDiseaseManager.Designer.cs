
namespace App_OP.ChronicDisease
{
    partial class FormChronicDiseaseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChronicDiseaseManager));
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor3 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.gpLeft = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvLeft = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.gpRight = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvRight = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colDrugName_H = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode_H = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSpecification_H = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDrugformValue_H = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBigPackagePrice_H = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.btnDeleteDetail = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.gpMiddle = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvMiddle = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colDrugName_A = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode_A = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSpecification_A = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDrugformValue_A = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBigPackagePrice_A = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnAddDetail = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.gpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.gpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.gpMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpLeft
            // 
            this.gpLeft.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpLeft.Controls.Add(this.dgvLeft);
            this.gpLeft.Controls.Add(this.bar1);
            this.gpLeft.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpLeft.Location = new System.Drawing.Point(0, 0);
            this.gpLeft.Name = "gpLeft";
            this.gpLeft.Size = new System.Drawing.Size(480, 697);
            // 
            // 
            // 
            this.gpLeft.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpLeft.Style.BackColorGradientAngle = 90;
            this.gpLeft.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpLeft.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpLeft.Style.BorderBottomWidth = 1;
            this.gpLeft.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpLeft.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpLeft.Style.BorderLeftWidth = 1;
            this.gpLeft.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpLeft.Style.BorderRightWidth = 1;
            this.gpLeft.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpLeft.Style.BorderTopWidth = 1;
            this.gpLeft.Style.CornerDiameter = 4;
            this.gpLeft.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpLeft.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpLeft.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpLeft.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpLeft.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpLeft.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpLeft.TabIndex = 0;
            this.gpLeft.Text = "慢性疾病类目";
            // 
            // dgvLeft
            // 
            this.dgvLeft.BackColor = System.Drawing.Color.White;
            this.dgvLeft.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvLeft.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeft.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvLeft.ForeColor = System.Drawing.Color.Black;
            this.dgvLeft.Location = new System.Drawing.Point(0, 26);
            this.dgvLeft.Name = "dgvLeft";
            // 
            // 
            // 
            this.dgvLeft.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvLeft.PrimaryGrid.AllowRowResize = true;
            this.dgvLeft.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvLeft.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colName);
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colType);
            this.dgvLeft.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvLeft.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvLeft.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvLeft.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvLeft.PrimaryGrid.EnableFiltering = true;
            this.dgvLeft.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvLeft.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvLeft.PrimaryGrid.Filter.Visible = true;
            this.dgvLeft.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvLeft.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvLeft.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvLeft.PrimaryGrid.MultiSelect = false;
            this.dgvLeft.PrimaryGrid.NullString = "<<null>>";
            this.dgvLeft.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvLeft.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvLeft.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvLeft.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvLeft.Size = new System.Drawing.Size(474, 645);
            this.dgvLeft.TabIndex = 45;
            this.dgvLeft.Text = "superGridControl2";
            this.dgvLeft.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvLeft_CellClick);
            this.dgvLeft.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvLeft_CellDoubleClick);
            this.dgvLeft.GetCellFormattedValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellFormattedValueEventArgs>(this.dgvLeft_GetCellFormattedValue);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "病种名称";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "";
            this.colName.ReadOnly = true;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.HeaderText = "拼音码";
            this.colSearchCode.MinimumWidth = 80;
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "类型";
            this.colType.MinimumWidth = 120;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 80;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Left;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(474, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "增加病种";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "编辑病种";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除病种";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gpRight
            // 
            this.gpRight.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpRight.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpRight.Controls.Add(this.dgvRight);
            this.gpRight.Controls.Add(this.bar3);
            this.gpRight.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpRight.Location = new System.Drawing.Point(1177, 0);
            this.gpRight.Name = "gpRight";
            this.gpRight.Size = new System.Drawing.Size(427, 697);
            // 
            // 
            // 
            this.gpRight.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpRight.Style.BackColorGradientAngle = 90;
            this.gpRight.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpRight.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpRight.Style.BorderBottomWidth = 1;
            this.gpRight.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpRight.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpRight.Style.BorderLeftWidth = 1;
            this.gpRight.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpRight.Style.BorderRightWidth = 1;
            this.gpRight.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpRight.Style.BorderTopWidth = 1;
            this.gpRight.Style.CornerDiameter = 4;
            this.gpRight.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpRight.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpRight.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpRight.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpRight.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpRight.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpRight.TabIndex = 2;
            this.gpRight.Text = "病种可开药品";
            // 
            // dgvRight
            // 
            this.dgvRight.BackColor = System.Drawing.Color.White;
            this.dgvRight.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            borderColor2.Left = System.Drawing.Color.Transparent;
            borderColor2.Right = System.Drawing.Color.Transparent;
            borderColor2.Top = System.Drawing.Color.Transparent;
            this.dgvRight.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            this.dgvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRight.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvRight.ForeColor = System.Drawing.Color.Black;
            this.dgvRight.Location = new System.Drawing.Point(0, 26);
            this.dgvRight.Name = "dgvRight";
            // 
            // 
            // 
            this.dgvRight.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvRight.PrimaryGrid.AllowRowResize = true;
            this.dgvRight.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvRight.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvRight.PrimaryGrid.Columns.Add(this.colDrugName_H);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colSearchCode_H);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colSpecification_H);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colDrugformValue_H);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colBigPackagePrice_H);
            this.dgvRight.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvRight.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvRight.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvRight.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvRight.PrimaryGrid.EnableFiltering = true;
            this.dgvRight.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvRight.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvRight.PrimaryGrid.Filter.Visible = true;
            this.dgvRight.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvRight.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvRight.PrimaryGrid.MultiSelect = false;
            this.dgvRight.PrimaryGrid.NullString = "<<null>>";
            this.dgvRight.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvRight.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvRight.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvRight.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvRight.Size = new System.Drawing.Size(421, 645);
            this.dgvRight.TabIndex = 47;
            this.dgvRight.Text = "superGridControl2";
            this.dgvRight.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvRight_CellDoubleClick);
            // 
            // colDrugName_H
            // 
            this.colDrugName_H.DataPropertyName = "DrugName";
            this.colDrugName_H.HeaderText = "药品名称";
            this.colDrugName_H.MinimumWidth = 200;
            this.colDrugName_H.Name = "colDrugName_H";
            this.colDrugName_H.ReadOnly = true;
            // 
            // colSearchCode_H
            // 
            this.colSearchCode_H.DataPropertyName = "SearchCode";
            this.colSearchCode_H.HeaderText = "拼音码";
            this.colSearchCode_H.MinimumWidth = 80;
            this.colSearchCode_H.Name = "colSearchCode_H";
            this.colSearchCode_H.ReadOnly = true;
            // 
            // colSpecification_H
            // 
            this.colSpecification_H.DataPropertyName = "Specification";
            this.colSpecification_H.HeaderText = "规格";
            this.colSpecification_H.MinimumWidth = 120;
            this.colSpecification_H.Name = "colSpecification_H";
            this.colSpecification_H.ReadOnly = true;
            this.colSpecification_H.Width = 80;
            // 
            // colDrugformValue_H
            // 
            this.colDrugformValue_H.DataPropertyName = "Drugform";
            this.colDrugformValue_H.HeaderText = "剂型";
            this.colDrugformValue_H.Name = "colDrugformValue_H";
            // 
            // colBigPackagePrice_H
            // 
            this.colBigPackagePrice_H.DataPropertyName = "BigPackagePrice";
            this.colBigPackagePrice_H.HeaderText = "价格";
            this.colBigPackagePrice_H.Name = "colBigPackagePrice_H";
            // 
            // bar3
            // 
            this.bar3.AntiAlias = true;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar3.DockSide = DevComponents.DotNetBar.eDockSide.Right;
            this.bar3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar3.IsMaximized = false;
            this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDeleteDetail,
            this.labelItem2});
            this.bar3.Location = new System.Drawing.Point(0, 0);
            this.bar3.Name = "bar3";
            this.bar3.RoundCorners = false;
            this.bar3.Size = new System.Drawing.Size(421, 26);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 3;
            this.bar3.TabStop = false;
            this.bar3.Text = "bar3";
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDeleteDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDetail.Image")));
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Text = "删除可用药品";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "（双击可删除）";
            // 
            // gpMiddle
            // 
            this.gpMiddle.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpMiddle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpMiddle.Controls.Add(this.dgvMiddle);
            this.gpMiddle.Controls.Add(this.bar2);
            this.gpMiddle.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpMiddle.Location = new System.Drawing.Point(480, 0);
            this.gpMiddle.Name = "gpMiddle";
            this.gpMiddle.Size = new System.Drawing.Size(697, 697);
            // 
            // 
            // 
            this.gpMiddle.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpMiddle.Style.BackColorGradientAngle = 90;
            this.gpMiddle.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpMiddle.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMiddle.Style.BorderBottomWidth = 1;
            this.gpMiddle.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpMiddle.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMiddle.Style.BorderLeftWidth = 1;
            this.gpMiddle.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMiddle.Style.BorderRightWidth = 1;
            this.gpMiddle.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMiddle.Style.BorderTopWidth = 1;
            this.gpMiddle.Style.CornerDiameter = 4;
            this.gpMiddle.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpMiddle.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpMiddle.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpMiddle.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpMiddle.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpMiddle.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpMiddle.TabIndex = 3;
            this.gpMiddle.Text = "院内药品目录";
            // 
            // dgvMiddle
            // 
            this.dgvMiddle.BackColor = System.Drawing.Color.White;
            this.dgvMiddle.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor3.Bottom = System.Drawing.Color.Transparent;
            borderColor3.Left = System.Drawing.Color.Transparent;
            borderColor3.Right = System.Drawing.Color.Transparent;
            borderColor3.Top = System.Drawing.Color.Transparent;
            this.dgvMiddle.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor3;
            this.dgvMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiddle.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvMiddle.ForeColor = System.Drawing.Color.Black;
            this.dgvMiddle.Location = new System.Drawing.Point(0, 26);
            this.dgvMiddle.Name = "dgvMiddle";
            // 
            // 
            // 
            this.dgvMiddle.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvMiddle.PrimaryGrid.AllowRowResize = true;
            this.dgvMiddle.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvMiddle.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvMiddle.PrimaryGrid.Columns.Add(this.colDrugName_A);
            this.dgvMiddle.PrimaryGrid.Columns.Add(this.colSearchCode_A);
            this.dgvMiddle.PrimaryGrid.Columns.Add(this.colSpecification_A);
            this.dgvMiddle.PrimaryGrid.Columns.Add(this.colDrugformValue_A);
            this.dgvMiddle.PrimaryGrid.Columns.Add(this.colBigPackagePrice_A);
            this.dgvMiddle.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvMiddle.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMiddle.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMiddle.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvMiddle.PrimaryGrid.EnableFiltering = true;
            this.dgvMiddle.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvMiddle.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvMiddle.PrimaryGrid.Filter.Visible = true;
            this.dgvMiddle.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvMiddle.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvMiddle.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvMiddle.PrimaryGrid.MultiSelect = false;
            this.dgvMiddle.PrimaryGrid.NullString = "<<null>>";
            this.dgvMiddle.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvMiddle.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvMiddle.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvMiddle.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvMiddle.Size = new System.Drawing.Size(691, 645);
            this.dgvMiddle.TabIndex = 46;
            this.dgvMiddle.Text = "superGridControl2";
            this.dgvMiddle.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvMiddle_CellDoubleClick);
            // 
            // colDrugName_A
            // 
            this.colDrugName_A.DataPropertyName = "DrugName";
            this.colDrugName_A.HeaderText = "药品名称";
            this.colDrugName_A.MinimumWidth = 200;
            this.colDrugName_A.Name = "colDrugName_A";
            this.colDrugName_A.ReadOnly = true;
            // 
            // colSearchCode_A
            // 
            this.colSearchCode_A.DataPropertyName = "SearchCode";
            this.colSearchCode_A.HeaderText = "拼音码";
            this.colSearchCode_A.MinimumWidth = 80;
            this.colSearchCode_A.Name = "colSearchCode_A";
            this.colSearchCode_A.ReadOnly = true;
            // 
            // colSpecification_A
            // 
            this.colSpecification_A.DataPropertyName = "Specification";
            this.colSpecification_A.HeaderText = "规格";
            this.colSpecification_A.MinimumWidth = 120;
            this.colSpecification_A.Name = "colSpecification_A";
            this.colSpecification_A.ReadOnly = true;
            this.colSpecification_A.Width = 80;
            // 
            // colDrugformValue_A
            // 
            this.colDrugformValue_A.DataPropertyName = "Drugform";
            this.colDrugformValue_A.HeaderText = "剂型";
            this.colDrugformValue_A.Name = "colDrugformValue_A";
            // 
            // colBigPackagePrice_A
            // 
            this.colBigPackagePrice_A.DataPropertyName = "BigPackagePrice";
            this.colBigPackagePrice_A.HeaderText = "价格";
            this.colBigPackagePrice_A.Name = "colBigPackagePrice_A";
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddDetail,
            this.labelItem1});
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.RoundCorners = false;
            this.bar2.Size = new System.Drawing.Size(691, 26);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 2;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Text = "添加可用药品";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "（双击可添加）";
            // 
            // FormChronicDiseaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 697);
            this.Controls.Add(this.gpMiddle);
            this.Controls.Add(this.gpRight);
            this.Controls.Add(this.gpLeft);
            this.Name = "FormChronicDiseaseManager";
            this.Text = "慢性病维护";
            this.Load += new System.EventHandler(this.FormChronicDiseaseManager_Load);
            this.gpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.gpRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.gpMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpLeft;
        private DevComponents.DotNetBar.Controls.GroupPanel gpRight;
        private DevComponents.DotNetBar.Controls.GroupPanel gpMiddle;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvLeft;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvRight;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugName_H;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode_H;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSpecification_H;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugformValue_H;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBigPackagePrice_H;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.ButtonItem btnDeleteDetail;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvMiddle;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugName_A;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode_A;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSpecification_A;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugformValue_A;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBigPackagePrice_A;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnAddDetail;
        private DevComponents.DotNetBar.LabelItem labelItem1;
    }
}