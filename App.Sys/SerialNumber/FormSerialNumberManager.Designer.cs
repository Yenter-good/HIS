namespace App_Sys
{
    partial class FormSerialNumberManager
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colTotalLength = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStartPrefix = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMiddleFormat = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colChangeType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCacheFlag = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.grid);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1062, 601);
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
            // grid
            // 
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            this.grid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(0, 26);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colType);
            this.grid.PrimaryGrid.Columns.Add(this.colTotalLength);
            this.grid.PrimaryGrid.Columns.Add(this.colStartPrefix);
            this.grid.PrimaryGrid.Columns.Add(this.colMiddleFormat);
            this.grid.PrimaryGrid.Columns.Add(this.colChangeType);
            this.grid.PrimaryGrid.Columns.Add(this.colCacheFlag);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.Size = new System.Drawing.Size(1062, 575);
            this.grid.TabIndex = 1;
            this.grid.Text = "superGridControl1";
            this.grid.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grid_RowDoubleClick);
            // 
            // colType
            // 
            this.colType.Name = "类型";
            this.colType.ReadOnly = true;
            // 
            // colTotalLength
            // 
            this.colTotalLength.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colTotalLength.Name = "总长度";
            this.colTotalLength.ReadOnly = true;
            // 
            // colStartPrefix
            // 
            this.colStartPrefix.Name = "起始值";
            this.colStartPrefix.ReadOnly = true;
            // 
            // colMiddleFormat
            // 
            this.colMiddleFormat.Name = "中间格式";
            this.colMiddleFormat.ReadOnly = true;
            // 
            // colChangeType
            // 
            this.colChangeType.Name = "变化类型";
            this.colChangeType.ReadOnly = true;
            // 
            // colCacheFlag
            // 
            this.colCacheFlag.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colCacheFlag.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colCacheFlag.Name = "是否缓存";
            this.colCacheFlag.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn1.Name = "";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReflesh,
            this.btnAdd,
            this.btnEdit});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1062, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BeginGroup = true;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormSerialNumberManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 601);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormSerialNumberManager";
            this.Text = "流水号管理";
            this.Shown += new System.EventHandler(this.FormSerialNumberManager_Shown);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnReflesh;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStartPrefix;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMiddleFormat;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colTotalLength;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colChangeType;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCacheFlag;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
    }
}