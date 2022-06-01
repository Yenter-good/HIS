namespace App_Sys
{
    partial class FormFeeItemManager
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
            this.colOFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.advTree = new DevComponents.AdvTree.AdvTree();
            this.rootNode = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.colIFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colVariableFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSpecification = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMeasure = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMeasureUnit = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExecDeptId = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWubiCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDataStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colFeeType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tbxFilter = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(225, 0);
            this.bar1.Size = new System.Drawing.Size(1012, 27);
            this.bar1.Stretch = false;
            // 
            // grid
            // 
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(289, 60);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colDataStatus);
            this.grid.PrimaryGrid.Columns.Add(this.colOFlag);
            this.grid.PrimaryGrid.Columns.Add(this.colIFlag);
            this.grid.PrimaryGrid.Columns.Add(this.colSFlag);
            this.grid.PrimaryGrid.Columns.Add(this.colMFlag);
            this.grid.PrimaryGrid.Columns.Add(this.colVariableFlag);
            this.grid.PrimaryGrid.Columns.Add(this.colFeeType);
            this.grid.PrimaryGrid.Columns.Add(this.colCode);
            this.grid.PrimaryGrid.Columns.Add(this.colName);
            this.grid.PrimaryGrid.Columns.Add(this.colPrice);
            this.grid.PrimaryGrid.Columns.Add(this.colSpecification);
            this.grid.PrimaryGrid.Columns.Add(this.colMeasure);
            this.grid.PrimaryGrid.Columns.Add(this.colMeasureUnit);
            this.grid.PrimaryGrid.Columns.Add(this.colExecDeptId);
            this.grid.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.grid.PrimaryGrid.Columns.Add(this.colWubiCode);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.grid.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.Size = new System.Drawing.Size(870, 561);
            this.grid.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.grid_DataBindingComplete);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(252, 279);
            this.pnl.Size = new System.Drawing.Size(985, 415);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            // 
            // btiEdit
            // 
            this.btiEdit.Enabled = false;
            // 
            // btiRemover
            // 
            this.btiRemover.Enabled = false;
            // 
            // colOFlag
            // 
            this.colOFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colOFlag.DataPropertyName = "OFlag";
            this.colOFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colOFlag.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colOFlag.FilterAutoScan = true;
            this.colOFlag.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colOFlag.HeaderText = "门诊";
            this.colOFlag.Name = "colOFlag";
            this.colOFlag.ReadOnly = true;
            this.colOFlag.Width = 50;
            // 
            // advTree
            // 
            this.advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree.AllowDrop = false;
            this.advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.advTree.Location = new System.Drawing.Point(0, 0);
            this.advTree.Name = "advTree";
            this.advTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.rootNode});
            this.advTree.NodesConnector = this.nodeConnector1;
            this.advTree.NodeStyle = this.elementStyle1;
            this.advTree.PathSeparator = ";";
            this.advTree.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.advTree.Size = new System.Drawing.Size(200, 694);
            this.advTree.Styles.Add(this.elementStyle1);
            this.advTree.TabIndex = 10;
            this.advTree.Text = "advTree1";
            // 
            // rootNode
            // 
            this.rootNode.Expanded = true;
            this.rootNode.Name = "rootNode";
            this.rootNode.Text = "全部";
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
            this.expandableSplitter1.Location = new System.Drawing.Point(200, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(5, 694);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 11;
            this.expandableSplitter1.TabStop = false;
            // 
            // colIFlag
            // 
            this.colIFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colIFlag.DataPropertyName = "IFlag";
            this.colIFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colIFlag.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colIFlag.FilterAutoScan = true;
            this.colIFlag.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colIFlag.HeaderText = "住院";
            this.colIFlag.Name = "colIFlag";
            this.colIFlag.ReadOnly = true;
            this.colIFlag.Width = 50;
            // 
            // colSFlag
            // 
            this.colSFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colSFlag.DataPropertyName = "SFlag";
            this.colSFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colSFlag.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colSFlag.FilterAutoScan = true;
            this.colSFlag.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colSFlag.HeaderText = "手术";
            this.colSFlag.Name = "colSFlag";
            this.colSFlag.ReadOnly = true;
            this.colSFlag.Width = 50;
            // 
            // colMFlag
            // 
            this.colMFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colMFlag.DataPropertyName = "MFlag";
            this.colMFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colMFlag.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colMFlag.FilterAutoScan = true;
            this.colMFlag.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colMFlag.HeaderText = "医技";
            this.colMFlag.Name = "colMFlag";
            this.colMFlag.ReadOnly = true;
            this.colMFlag.Width = 50;
            // 
            // colVariableFlag
            // 
            this.colVariableFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colVariableFlag.DataPropertyName = "VariableFlag";
            this.colVariableFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colVariableFlag.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colVariableFlag.FilterAutoScan = true;
            this.colVariableFlag.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colVariableFlag.HeaderText = "可调价";
            this.colVariableFlag.Name = "colVariableFlag";
            this.colVariableFlag.ReadOnly = true;
            this.colVariableFlag.Width = 50;
            // 
            // colCode
            // 
            this.colCode.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colCode.DataPropertyName = "Code";
            this.colCode.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colCode.FilterAutoScan = true;
            this.colCode.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colCode.HeaderText = "编码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.colName.DataPropertyName = "Name";
            this.colName.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colName.FilterAutoScan = true;
            this.colName.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colName.HeaderText = "名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colSpecification
            // 
            this.colSpecification.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colSpecification.DataPropertyName = "Specification";
            this.colSpecification.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colSpecification.FilterAutoScan = true;
            this.colSpecification.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.ComboBox;
            this.colSpecification.HeaderText = "规格";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.ReadOnly = true;
            // 
            // colMeasure
            // 
            this.colMeasure.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colMeasure.DataPropertyName = "Measure";
            this.colMeasure.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colMeasure.FilterAutoScan = true;
            this.colMeasure.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colMeasure.HeaderText = "最小计量";
            this.colMeasure.Name = "colMeasure";
            this.colMeasure.ReadOnly = true;
            // 
            // colMeasureUnit
            // 
            this.colMeasureUnit.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colMeasureUnit.DataPropertyName = "MeasureUnit";
            this.colMeasureUnit.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colMeasureUnit.FilterAutoScan = true;
            this.colMeasureUnit.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.ComboBox;
            this.colMeasureUnit.HeaderText = "计量单位";
            this.colMeasureUnit.Name = "colMeasureUnit";
            this.colMeasureUnit.ReadOnly = true;
            this.colMeasureUnit.Width = 70;
            // 
            // colPrice
            // 
            this.colPrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colPrice.FilterAutoScan = true;
            this.colPrice.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colPrice.HeaderText = "价格";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colExecDeptId
            // 
            this.colExecDeptId.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colExecDeptId.FilterAutoScan = true;
            this.colExecDeptId.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.ComboBox;
            this.colExecDeptId.HeaderText = "默认执行科室";
            this.colExecDeptId.Name = "colExecDeptId";
            this.colExecDeptId.ReadOnly = true;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colSearchCode.FilterAutoScan = true;
            this.colSearchCode.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colSearchCode.HeaderText = "拼音码";
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colWubiCode
            // 
            this.colWubiCode.DataPropertyName = "WubiCode";
            this.colWubiCode.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colWubiCode.FilterAutoScan = true;
            this.colWubiCode.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colWubiCode.HeaderText = "五笔码";
            this.colWubiCode.Name = "colWubiCode";
            this.colWubiCode.ReadOnly = true;
            // 
            // colDataStatus
            // 
            this.colDataStatus.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colDataStatus.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colDataStatus.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colDataStatus.FilterAutoScan = true;
            this.colDataStatus.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colDataStatus.HeaderText = "状态";
            this.colDataStatus.Name = "colDataStatus";
            this.colDataStatus.ReadOnly = true;
            this.colDataStatus.Width = 50;
            // 
            // colFeeType
            // 
            this.colFeeType.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.colFeeType.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colFeeType.FilterAutoScan = true;
            this.colFeeType.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.ComboBox;
            this.colFeeType.HeaderText = "所属财务分类";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.ReadOnly = true;
            // 
            // tbxFilter
            // 
            // 
            // 
            // 
            this.tbxFilter.Border.Class = "TextBoxBorder";
            this.tbxFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxFilter.Location = new System.Drawing.Point(225, 31);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.PreventEnterBeep = true;
            this.tbxFilter.Size = new System.Drawing.Size(310, 23);
            this.tbxFilter.TabIndex = 12;
            this.tbxFilter.WatermarkText = "请输入拼音码、五笔码、名称进行检索";
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // FormFeeItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 694);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.advTree);
            this.Name = "FormFeeItemManager";
            this.Text = "收费价表管理";
            this.Controls.SetChildIndex(this.advTree, 0);
            this.Controls.SetChildIndex(this.expandableSplitter1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.bar1, 0);
            this.Controls.SetChildIndex(this.contextMenuBar1, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.tbxFilter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.SuperGrid.GridColumn colOFlag;
        private DevComponents.AdvTree.AdvTree advTree;
        private DevComponents.AdvTree.Node rootNode;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colIFlag;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSFlag;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMFlag;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colVariableFlag;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSpecification;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMeasure;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMeasureUnit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExecDeptId;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWubiCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDataStatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colFeeType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxFilter;
    }
}