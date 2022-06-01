
namespace App_OP.Diagnosis
{
    partial class FormDeptDiagnosis
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
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvRight = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName_dept = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode_dept = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colType_dept = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvLeft = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName_icd = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode_icd = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colType_icd = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAdd_s = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.groupPanel2);
            this.panelEx2.Controls.Add(this.panelEx1);
            this.panelEx2.Controls.Add(this.groupPanel1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1170, 599);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            this.panelEx2.Text = "panelEx2";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgvRight);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(652, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(518, 599);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 14;
            this.groupPanel2.Text = "常用诊断（双击移除）";
            // 
            // dgvRight
            // 
            this.dgvRight.BackColor = System.Drawing.Color.White;
            this.dgvRight.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvRight.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRight.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvRight.ForeColor = System.Drawing.Color.Black;
            this.dgvRight.Location = new System.Drawing.Point(0, 0);
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
            this.dgvRight.PrimaryGrid.Columns.Add(this.colName_dept);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colSearchCode_dept);
            this.dgvRight.PrimaryGrid.Columns.Add(this.colType_dept);
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
            this.dgvRight.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvRight.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvRight.PrimaryGrid.MultiSelect = false;
            this.dgvRight.PrimaryGrid.NullString = "<<null>>";
            this.dgvRight.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvRight.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvRight.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvRight.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvRight.Size = new System.Drawing.Size(512, 573);
            this.dgvRight.TabIndex = 46;
            this.dgvRight.Text = "superGridControl2";
            this.dgvRight.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvRight_CellDoubleClick);
            // 
            // colName_dept
            // 
            this.colName_dept.DataPropertyName = "Name";
            this.colName_dept.HeaderText = "病种名称";
            this.colName_dept.MinimumWidth = 200;
            this.colName_dept.Name = "colName_dept";
            this.colName_dept.ReadOnly = true;
            // 
            // colSearchCode_dept
            // 
            this.colSearchCode_dept.DataPropertyName = "SearchCode";
            this.colSearchCode_dept.HeaderText = "拼音码";
            this.colSearchCode_dept.MinimumWidth = 80;
            this.colSearchCode_dept.Name = "colSearchCode_dept";
            this.colSearchCode_dept.ReadOnly = true;
            // 
            // colType_dept
            // 
            this.colType_dept.DataPropertyName = "Type";
            this.colType_dept.HeaderText = "类型";
            this.colType_dept.MinimumWidth = 120;
            this.colType_dept.Name = "colType_dept";
            this.colType_dept.ReadOnly = true;
            this.colType_dept.Width = 80;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnRemove);
            this.panelEx1.Controls.Add(this.btnAdd);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(482, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(170, 599);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Location = new System.Drawing.Point(45, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(45, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = ">";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvLeft);
            this.groupPanel1.Controls.Add(this.tbxSearch);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(482, 599);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "标准诊断集合（双击加入）";
            // 
            // dgvLeft
            // 
            this.dgvLeft.BackColor = System.Drawing.Color.White;
            this.dgvLeft.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            borderColor2.Left = System.Drawing.Color.Transparent;
            borderColor2.Right = System.Drawing.Color.Transparent;
            borderColor2.Top = System.Drawing.Color.Transparent;
            this.dgvLeft.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            this.dgvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeft.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvLeft.ForeColor = System.Drawing.Color.Black;
            this.dgvLeft.Location = new System.Drawing.Point(0, 23);
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
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colName_icd);
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colSearchCode_icd);
            this.dgvLeft.PrimaryGrid.Columns.Add(this.colType_icd);
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
            this.dgvLeft.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvLeft.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvLeft.PrimaryGrid.MultiSelect = false;
            this.dgvLeft.PrimaryGrid.NullString = "<<null>>";
            this.dgvLeft.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvLeft.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvLeft.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvLeft.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvLeft.Size = new System.Drawing.Size(476, 402);
            this.dgvLeft.TabIndex = 49;
            this.dgvLeft.Text = "superGridControl2";
            this.dgvLeft.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvLeft_CellDoubleClick);
            // 
            // colName_icd
            // 
            this.colName_icd.DataPropertyName = "Name";
            this.colName_icd.HeaderText = "病种名称";
            this.colName_icd.MinimumWidth = 200;
            this.colName_icd.Name = "colName_icd";
            this.colName_icd.ReadOnly = true;
            // 
            // colSearchCode_icd
            // 
            this.colSearchCode_icd.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.colSearchCode_icd.DataPropertyName = "SearchCode";
            this.colSearchCode_icd.HeaderText = "拼音码";
            this.colSearchCode_icd.MinimumWidth = 80;
            this.colSearchCode_icd.Name = "colSearchCode_icd";
            this.colSearchCode_icd.ReadOnly = true;
            // 
            // colType_icd
            // 
            this.colType_icd.DataPropertyName = "Type";
            this.colType_icd.HeaderText = "类型";
            this.colType_icd.MinimumWidth = 120;
            this.colType_icd.Name = "colType_icd";
            this.colType_icd.ReadOnly = true;
            this.colType_icd.Width = 80;
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(0, 0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(476, 23);
            this.tbxSearch.TabIndex = 48;
            this.tbxSearch.WatermarkText = "按名称、拼音  （回车检索）";
            this.tbxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyUp);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnAdd_s);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.labelX1);
            this.groupPanel3.Controls.Add(this.tbxName);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel3.Location = new System.Drawing.Point(0, 425);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(476, 148);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 47;
            this.groupPanel3.Text = "自定义诊断添加";
            // 
            // btnAdd_s
            // 
            this.btnAdd_s.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd_s.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd_s.Location = new System.Drawing.Point(349, 45);
            this.btnAdd_s.Name = "btnAdd_s";
            this.btnAdd_s.Size = new System.Drawing.Size(75, 34);
            this.btnAdd_s.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd_s.TabIndex = 3;
            this.btnAdd_s.Text = "添加";
            this.btnAdd_s.Click += new System.EventHandler(this.btnAdd_s_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(11, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(320, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "为方便病种统计请选中一个标准诊断";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "诊断名称：";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(96, 56);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(235, 23);
            this.tbxName.TabIndex = 0;
            // 
            // FormDeptDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 599);
            this.Controls.Add(this.panelEx2);
            this.Name = "FormDeptDiagnosis";
            this.Text = "科室常用诊断";
            this.Shown += new System.EventHandler(this.FormDeptDiagnosis_Shown);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvRight;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName_dept;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode_dept;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType_dept;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnRemove;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btnAdd_s;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvLeft;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName_icd;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode_icd;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType_icd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
    }
}