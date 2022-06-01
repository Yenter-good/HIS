namespace App_Sys
{
    partial class FormParameterManager
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
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDataStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDescription = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colValue = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Size = new System.Drawing.Size(1129, 27);
            // 
            // grid
            // 
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.grid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(0, 27);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colCode);
            this.grid.PrimaryGrid.Columns.Add(this.colName);
            this.grid.PrimaryGrid.Columns.Add(this.colValue);
            this.grid.PrimaryGrid.Columns.Add(this.colDescription);
            this.grid.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.grid.PrimaryGrid.Columns.Add(this.colDataStatus);
            this.grid.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.grid.PrimaryGrid.EnableColumnFiltering = true;
            this.grid.PrimaryGrid.EnableFiltering = true;
            this.grid.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.grid.PrimaryGrid.Filter.Visible = true;
            this.grid.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.Size = new System.Drawing.Size(1129, 626);
            this.grid.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.grid_CellClick);
            this.grid.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.grid_DataBindingComplete);
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Size = new System.Drawing.Size(1129, 653);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            // 
            // btiEdit
            // 
            this.btiEdit.BeginGroup = true;
            this.btiEdit.Enabled = false;
            // 
            // btiRemover
            // 
            this.btiRemover.Enabled = false;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "ParameterCode";
            this.colCode.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colCode.FilterAutoScan = true;
            this.colCode.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colCode.HeaderText = "参数编码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "ParameterName";
            this.colName.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colName.FilterAutoScan = true;
            this.colName.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colName.HeaderText = "参数名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colSearchCode.FilterAutoScan = true;
            this.colSearchCode.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colSearchCode.HeaderText = "检索码";
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colDataStatus
            // 
            this.colDataStatus.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colDataStatus.DataPropertyName = "";
            this.colDataStatus.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colDataStatus.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colDataStatus.FilterAutoScan = true;
            this.colDataStatus.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.CheckBox;
            this.colDataStatus.HeaderText = "启用状态";
            this.colDataStatus.Name = "colDataStatus";
            this.colDataStatus.ReadOnly = true;
            this.colDataStatus.Width = 60;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colDescription.FilterAutoScan = true;
            this.colDescription.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colDescription.HeaderText = "描述";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 150;
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "ParameterValue";
            this.colValue.EnableFiltering = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.colValue.FilterAutoScan = true;
            this.colValue.FilterEditType = DevComponents.DotNetBar.SuperGrid.FilterEditType.TextBox;
            this.colValue.HeaderText = "参数值";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 300;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn1.HeaderText = " ";
            this.gridColumn1.Name = "colWhite";
            // 
            // FormParameterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 653);
            this.Name = "FormParameterManager";
            this.Text = "系统参数";
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.bar1, 0);
            this.Controls.SetChildIndex(this.contextMenuBar1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDataStatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDescription;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colValue;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
    }
}