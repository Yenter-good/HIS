namespace App_Sys.Drug.SplitOrMergeManager
{
    partial class FormSplitOrMerge
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDrug = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colSplit = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMerge = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colClassCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colClassName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGGCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGGName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDrugform = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPackageNumber = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBigPackageQuantity = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBigPackagePrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSmallPackageQuantity = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSmallPackagePrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWidth = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.tabMain = new DevComponents.DotNetBar.SuperTabControl();
            this.stabMerge = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.stabSplit = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.tabMain);
            this.panelEx1.Controls.Add(this.tbxSearch);
            this.panelEx1.Controls.Add(this.dgvDrug);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(986, 606);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxSearch.Border.BorderColor = System.Drawing.Color.Transparent;
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Location = new System.Drawing.Point(35, 28);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(948, 23);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.WatermarkText = "请输入药品名称、拼音码、五笔码检索....";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dgvDrug
            // 
            this.dgvDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrug.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvDrug.Location = new System.Drawing.Point(0, 26);
            this.dgvDrug.Name = "dgvDrug";
            // 
            // 
            // 
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colSplit);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colMerge);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colClassCode);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colClassName);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colGGCode);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colGGName);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colDrugform);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colPackageNumber);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colBigPackageQuantity);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colBigPackagePrice);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colSmallPackageQuantity);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colSmallPackagePrice);
            this.dgvDrug.PrimaryGrid.Columns.Add(this.colWidth);
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            this.dgvDrug.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            // 
            // 
            // 
            this.dgvDrug.PrimaryGrid.GroupByRow.RowHeight = 28;
            this.dgvDrug.PrimaryGrid.GroupByRow.Visible = true;
            // 
            // 
            // 
            this.dgvDrug.PrimaryGrid.Header.Text = "";
            // 
            // 
            // 
            this.dgvDrug.PrimaryGrid.Title.Visible = false;
            this.dgvDrug.Size = new System.Drawing.Size(986, 580);
            this.dgvDrug.TabIndex = 0;
            this.dgvDrug.Text = "superGridControl1";
            // 
            // colSplit
            // 
            this.colSplit.Name = "拆分";
            this.colSplit.Width = 60;
            // 
            // colMerge
            // 
            this.colMerge.Name = "合并";
            this.colMerge.Width = 60;
            // 
            // colClassCode
            // 
            this.colClassCode.Name = "药品编码";
            this.colClassCode.ReadOnly = true;
            this.colClassCode.Width = 159;
            // 
            // colClassName
            // 
            this.colClassName.Name = "药品名称";
            this.colClassName.ReadOnly = true;
            this.colClassName.Width = 300;
            // 
            // colGGCode
            // 
            this.colGGCode.Name = "规格编码";
            this.colGGCode.ReadOnly = true;
            // 
            // colGGName
            // 
            this.colGGName.Name = "规格名称";
            this.colGGName.ReadOnly = true;
            // 
            // colDrugform
            // 
            this.colDrugform.Name = "药品剂型";
            this.colDrugform.ReadOnly = true;
            // 
            // colPackageNumber
            // 
            this.colPackageNumber.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colPackageNumber.Name = "包装数";
            this.colPackageNumber.ReadOnly = true;
            // 
            // colBigPackageQuantity
            // 
            this.colBigPackageQuantity.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colBigPackageQuantity.Name = "库存数量";
            this.colBigPackageQuantity.ReadOnly = true;
            // 
            // colBigPackagePrice
            // 
            this.colBigPackagePrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colBigPackagePrice.Name = "单价";
            this.colBigPackagePrice.ReadOnly = true;
            // 
            // colSmallPackageQuantity
            // 
            this.colSmallPackageQuantity.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colSmallPackageQuantity.Name = "库存数量";
            this.colSmallPackageQuantity.ReadOnly = true;
            // 
            // colSmallPackagePrice
            // 
            this.colSmallPackagePrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colSmallPackagePrice.Name = "单价";
            this.colSmallPackagePrice.ReadOnly = true;
            // 
            // colWidth
            // 
            this.colWidth.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWidth.Name = "";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReflesh});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(986, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新药品";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // tabMain
            // 
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
            this.tabMain.Controls.Add(this.stabMerge);
            this.tabMain.Controls.Add(this.stabSplit);
            this.tabMain.Location = new System.Drawing.Point(155, 85);
            this.tabMain.Name = "tabMain";
            this.tabMain.ReorderTabsEnabled = true;
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(158, 210);
            this.tabMain.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.TabIndex = 4;
            this.tabMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.tabMain.TabsVisible = false;
            this.tabMain.Text = "superTabControl1";
            // 
            // stabMerge
            // 
            this.stabMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stabMerge.Location = new System.Drawing.Point(0, 28);
            this.stabMerge.Name = "stabMerge";
            this.stabMerge.Size = new System.Drawing.Size(158, 182);
            this.stabMerge.TabIndex = 0;
            this.stabMerge.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.stabMerge;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "药品合并";
            // 
            // stabSplit
            // 
            this.stabSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stabSplit.Location = new System.Drawing.Point(0, 28);
            this.stabSplit.Name = "stabSplit";
            this.stabSplit.Size = new System.Drawing.Size(158, 182);
            this.stabSplit.TabIndex = 1;
            this.stabSplit.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.stabSplit;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "药品拆分";
            // 
            // FormSplitOrMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 606);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormSplitOrMerge";
            this.Text = "药品拆分与合并";
            this.Shown += new System.EventHandler(this.FormSplitOrMerge_Shown);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvDrug;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSplit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMerge;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colClassCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colClassName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colGGCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colGGName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugform;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPackageNumber;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBigPackageQuantity;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnReflesh;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBigPackagePrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSmallPackageQuantity;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSmallPackagePrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWidth;
        internal DevComponents.DotNetBar.SuperTabControl tabMain;
        internal DevComponents.DotNetBar.SuperTabControlPanel stabMerge;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        internal DevComponents.DotNetBar.SuperTabControlPanel stabSplit;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
    }
}