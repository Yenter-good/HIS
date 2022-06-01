namespace App_OP.PatientInfo
{
    partial class UCBasePatientList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.contextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.menu = new DevComponents.DotNetBar.ButtonItem();
            this.btnCopyCode = new DevComponents.DotNetBar.ButtonItem();
            this.btnCopyName = new DevComponents.DotNetBar.ButtonItem();
            this.btnCopyCardNo = new DevComponents.DotNetBar.ButtonItem();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colPatientCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colGender = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAge = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPayType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRegisterTime = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colOrderNumber = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCategory = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colJz = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDept = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.contextMenuBar);
            this.pnl.Controls.Add(this.grid);
            this.pnl.Controls.Add(this.tbxSearch);
            this.pnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1212, 763);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 0;
            // 
            // contextMenuBar
            // 
            this.contextMenuBar.AntiAlias = true;
            this.contextMenuBar.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar.IsMaximized = false;
            this.contextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menu});
            this.contextMenuBar.Location = new System.Drawing.Point(299, 241);
            this.contextMenuBar.Name = "contextMenuBar";
            this.contextMenuBar.Size = new System.Drawing.Size(176, 26);
            this.contextMenuBar.Stretch = true;
            this.contextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar.TabIndex = 2;
            this.contextMenuBar.TabStop = false;
            this.contextMenuBar.Text = "contextMenuBar1";
            this.contextMenuBar.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.contextMenuBar_PopupOpen);
            // 
            // menu
            // 
            this.menu.AutoExpandOnClick = true;
            this.menu.Name = "menu";
            this.menu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCopyCode,
            this.btnCopyName,
            this.btnCopyCardNo});
            this.menu.Text = "buttonItem1";
            // 
            // btnCopyCode
            // 
            this.btnCopyCode.Name = "btnCopyCode";
            this.btnCopyCode.Text = "复制就诊号";
            this.btnCopyCode.Click += new System.EventHandler(this.btnCopyCode_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Text = "复制姓名";
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // btnCopyCardNo
            // 
            this.btnCopyCardNo.Name = "btnCopyCardNo";
            this.btnCopyCardNo.Text = "复制医保卡号";
            this.btnCopyCardNo.Click += new System.EventHandler(this.btnCopyCardNo_Click);
            // 
            // grid
            // 
            this.contextMenuBar.SetContextMenuEx(this.grid, this.menu);
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            this.grid.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(0, 23);
            this.grid.Name = "grid";
            // 
            // 
            // 
            this.grid.PrimaryGrid.Columns.Add(this.colPatientCode);
            this.grid.PrimaryGrid.Columns.Add(this.colName);
            this.grid.PrimaryGrid.Columns.Add(this.colGender);
            this.grid.PrimaryGrid.Columns.Add(this.colAge);
            this.grid.PrimaryGrid.Columns.Add(this.colPayType);
            this.grid.PrimaryGrid.Columns.Add(this.colRegisterTime);
            this.grid.PrimaryGrid.Columns.Add(this.colOrderNumber);
            this.grid.PrimaryGrid.Columns.Add(this.colCategory);
            this.grid.PrimaryGrid.Columns.Add(this.colJz);
            this.grid.PrimaryGrid.Columns.Add(this.colDept);
            this.grid.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.grid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.grid.PrimaryGrid.MultiSelect = false;
            this.grid.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.Size = new System.Drawing.Size(1212, 740);
            this.grid.TabIndex = 1;
            this.grid.Text = "superGridControl1";
            this.grid.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grid_RowDoubleClick);
            // 
            // colPatientCode
            // 
            this.colPatientCode.Name = "就诊号";
            this.colPatientCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Name = "姓名";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colGender
            // 
            this.colGender.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colGender.Name = "性别";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 50;
            // 
            // colAge
            // 
            this.colAge.Name = "年龄";
            this.colAge.ReadOnly = true;
            this.colAge.Width = 70;
            // 
            // colPayType
            // 
            this.colPayType.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colPayType.Name = "身份类别";
            this.colPayType.ReadOnly = true;
            this.colPayType.Width = 80;
            // 
            // colRegisterTime
            // 
            this.colRegisterTime.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colRegisterTime.Name = "挂号日期";
            this.colRegisterTime.ReadOnly = true;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colOrderNumber.Name = "序号";
            this.colOrderNumber.ReadOnly = true;
            this.colOrderNumber.Width = 50;
            // 
            // colCategory
            // 
            this.colCategory.Name = "号别";
            this.colCategory.ReadOnly = true;
            // 
            // colJz
            // 
            this.colJz.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colJz.Name = "是否急诊";
            this.colJz.ReadOnly = true;
            this.colJz.Width = 80;
            // 
            // colDept
            // 
            this.colDept.Name = "挂号科室";
            this.colDept.ReadOnly = true;
            this.colDept.Width = 150;
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
            this.tbxSearch.Size = new System.Drawing.Size(1212, 23);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.WatermarkText = "输入姓名、身份证号、拼音首字母、卡号检索";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // UCBasePatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCBasePatientList";
            this.Size = new System.Drawing.Size(1212, 763);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colPatientCode;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colAge;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colGender;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colPayType;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colRegisterTime;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colOrderNumber;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colCategory;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colJz;
        internal DevComponents.DotNetBar.SuperGrid.GridColumn colDept;
        internal DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
        internal DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        internal DevComponents.DotNetBar.PanelEx pnl;
        internal DevComponents.DotNetBar.ContextMenuBar contextMenuBar;
        internal DevComponents.DotNetBar.ButtonItem menu;
        internal DevComponents.DotNetBar.ButtonItem btnCopyCode;
        internal DevComponents.DotNetBar.ButtonItem btnCopyName;
        internal DevComponents.DotNetBar.ButtonItem btnCopyCardNo;
    }
}
