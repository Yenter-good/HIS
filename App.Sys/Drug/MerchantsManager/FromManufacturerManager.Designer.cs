namespace App_Sys.Drug.MerchantsManager
{
    partial class FromManufacturerManager
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
            this.dgvMain = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAddress = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colLegalPerson = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPhoneNo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBusinessLicense = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.BackColor = System.Drawing.Color.White;
            this.dgvMain.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvMain.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvMain.ForeColor = System.Drawing.Color.Black;
            this.dgvMain.Location = new System.Drawing.Point(0, 29);
            this.dgvMain.Name = "dgvMain";
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvMain.PrimaryGrid.AllowRowResize = true;
            this.dgvMain.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvMain.PrimaryGrid.Columns.Add(this.colName);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colAddress);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colLegalPerson);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colPhoneNo);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colBusinessLicense);
            this.dgvMain.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvMain.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMain.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMain.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvMain.PrimaryGrid.EnableFiltering = true;
            this.dgvMain.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvMain.PrimaryGrid.Filter.Visible = true;
            this.dgvMain.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvMain.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvMain.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvMain.PrimaryGrid.MultiSelect = false;
            this.dgvMain.PrimaryGrid.NullString = "<<null>>";
            this.dgvMain.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvMain.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvMain.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvMain.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvMain.Size = new System.Drawing.Size(1082, 574);
            this.dgvMain.TabIndex = 48;
            this.dgvMain.Text = "供应商维护";
            this.dgvMain.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvMain_CellDoubleClick);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "厂商名称";
            this.colName.Name = "";
            this.colName.ReadOnly = true;
            this.colName.Width = 220;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.HeaderText = "拼音码";
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "地址";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colLegalPerson
            // 
            this.colLegalPerson.DataPropertyName = "LegalPerson";
            this.colLegalPerson.FillWeight = 200;
            this.colLegalPerson.HeaderText = "法人";
            this.colLegalPerson.Name = "colLegalPerson";
            this.colLegalPerson.ReadOnly = true;
            this.colLegalPerson.Width = 80;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.HeaderText = "联系电话";
            this.colPhoneNo.Name = "colPhoneNo";
            // 
            // colBusinessLicense
            // 
            this.colBusinessLicense.DataPropertyName = "BusinessLicense";
            this.colBusinessLicense.HeaderText = "营业执照";
            this.colBusinessLicense.Name = "colBusinessLicense";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.labelItem2});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1082, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 49;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BeginGroup = true;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Text = "添加";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BeginGroup = true;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Width = 50;
            // 
            // FromManufacturerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.bar1);
            this.Name = "FromManufacturerManager";
            this.Text = "生产厂家维护";
            this.Shown += new System.EventHandler(this.FromManufacturerManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvMain;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAddress;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colLegalPerson;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPhoneNo;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBusinessLicense;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
    }
}