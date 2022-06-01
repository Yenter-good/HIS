namespace App_Sys
{
    partial class FormFeeTypeManager
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
            this.colWidth = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Size = new System.Drawing.Size(1115, 27);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(0, 27);
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colCode);
            this.grid.PrimaryGrid.Columns.Add(this.colName);
            this.grid.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.grid.PrimaryGrid.Columns.Add(this.colDataStatus);
            this.grid.PrimaryGrid.Columns.Add(this.colWidth);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.grid.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.Size = new System.Drawing.Size(1115, 572);
            this.grid.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.grid_DataBindingComplete);
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 27);
            this.pnl.Size = new System.Drawing.Size(1115, 572);
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
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "费用类型编码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "费用类型名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.HeaderText = "拼音码";
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colDataStatus
            // 
            this.colDataStatus.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colDataStatus.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.colDataStatus.HeaderText = "启用状态";
            this.colDataStatus.Name = "colDataStatus";
            this.colDataStatus.ReadOnly = true;
            this.colDataStatus.Width = 50;
            // 
            // colWidth
            // 
            this.colWidth.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWidth.Name = "";
            // 
            // FormFeeTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 599);
            this.Name = "FormFeeTypeManager";
            this.Text = "费用类型管理";
            this.Controls.SetChildIndex(this.bar1, 0);
            this.Controls.SetChildIndex(this.pnl, 0);
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
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWidth;
    }
}