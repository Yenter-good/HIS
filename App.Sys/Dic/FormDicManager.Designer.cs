namespace App_Sys
{
    partial class FormDicManager
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
            this.ucDicCatalog = new App_Sys.Dic.UCDicCatalog();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colValue = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colExtend = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colIsBuildIn = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDescription = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDataStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.bar1.Location = new System.Drawing.Point(363, 12);
            // 
            // grid
            // 
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(389, 66);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colCode);
            this.grid.PrimaryGrid.Columns.Add(this.colValue);
            this.grid.PrimaryGrid.Columns.Add(this.colExtend);
            this.grid.PrimaryGrid.Columns.Add(this.colIsBuildIn);
            this.grid.PrimaryGrid.Columns.Add(this.colDataStatus);
            this.grid.PrimaryGrid.Columns.Add(this.colDescription);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.grid.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.PrimaryGrid.MultiSelect = false;
            this.grid.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.Size = new System.Drawing.Size(635, 273);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(376, 130);
            this.pnl.Size = new System.Drawing.Size(711, 578);
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
            // contextMenuBar1
            // 
            this.contextMenuBar1.Location = new System.Drawing.Point(912, 154);
            // 
            // ucDicCatalog
            // 
            this.ucDicCatalog.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucDicCatalog.Location = new System.Drawing.Point(0, 0);
            this.ucDicCatalog.Name = "ucDicCatalog";
            this.ucDicCatalog.Size = new System.Drawing.Size(318, 708);
            this.ucDicCatalog.TabIndex = 10;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(318, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(5, 708);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 11;
            this.expandableSplitter1.TabStop = false;
            // 
            // colCode
            // 
            this.colCode.Name = "编码";
            this.colCode.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.Name = "值";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 150;
            // 
            // colExtend
            // 
            this.colExtend.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colExtend.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colExtend.Name = "可扩展性";
            this.colExtend.ReadOnly = true;
            this.colExtend.Width = 60;
            // 
            // colIsBuildIn
            // 
            this.colIsBuildIn.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colIsBuildIn.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colIsBuildIn.Name = "是否内置";
            this.colIsBuildIn.ReadOnly = true;
            this.colIsBuildIn.Width = 60;
            // 
            // colDescription
            // 
            this.colDescription.Name = "描述";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 300;
            // 
            // colDataStatus
            // 
            this.colDataStatus.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colDataStatus.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colDataStatus.Name = "启用状态";
            this.colDataStatus.ReadOnly = true;
            this.colDataStatus.Width = 60;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "快速录入";
            // 
            // FormDicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 708);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.ucDicCatalog);
            this.Name = "FormDicManager";
            this.Text = "系统字典管理";
            this.Controls.SetChildIndex(this.ucDicCatalog, 0);
            this.Controls.SetChildIndex(this.bar1, 0);
            this.Controls.SetChildIndex(this.contextMenuBar1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.expandableSplitter1, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dic.UCDicCatalog ucDicCatalog;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colValue;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colExtend;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colIsBuildIn;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDescription;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDataStatus;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}