namespace App_Sys.Drug.ProcurementPlan
{
    partial class FormProcurementPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcurementPlan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFill = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnExecl = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAudit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDetail = new HIS.ControlLib.DataGridViewExt();
            this.colClassCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackageUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugformValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOPInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.btnExecl);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAudit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 645);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购计划申请";
            // 
            // btnFill
            // 
            this.btnFill.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFill.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFill.Location = new System.Drawing.Point(66, 588);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(178, 35);
            this.btnFill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFill.TabIndex = 21;
            this.btnFill.Text = "填充采购数量";
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "采购数量填充方式";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(66, 560);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(178, 22);
            this.cbxType.TabIndex = 19;
            // 
            // btnExecl
            // 
            this.btnExecl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExecl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExecl.Location = new System.Drawing.Point(169, 476);
            this.btnExecl.Name = "btnExecl";
            this.btnExecl.Size = new System.Drawing.Size(75, 42);
            this.btnExecl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExecl.TabIndex = 18;
            this.btnExecl.Text = "导出Execl";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(169, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAudit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAudit.Location = new System.Drawing.Point(66, 476);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(75, 42);
            this.btnAudit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAudit.TabIndex = 16;
            this.btnAudit.Text = "审核完成";
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(66, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "增加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colAuditStatus});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMain.Location = new System.Drawing.Point(3, 19);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(315, 377);
            this.dgvMain.TabIndex = 14;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMain_CellFormatting);
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.DataPropertyName = "CreationTime";
            this.colDate.HeaderText = "申请日期";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colAuditStatus
            // 
            this.colAuditStatus.DataPropertyName = "AuditStatus";
            this.colAuditStatus.HeaderText = "状态";
            this.colAuditStatus.MinimumWidth = 6;
            this.colAuditStatus.Name = "colAuditStatus";
            this.colAuditStatus.ReadOnly = true;
            this.colAuditStatus.Width = 125;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(321, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(10, 645);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 12;
            this.expandableSplitter1.TabStop = false;
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(331, 0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(864, 23);
            this.tbxSearch.TabIndex = 13;
            this.tbxSearch.WatermarkText = "请输入名称、拼音码检索(按回车检索)";
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // dgvDetail
            // 
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.ClickBlankClearSelect = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassCode,
            this.colName,
            this.colSpecification,
            this.colPackageUnit,
            this.colDrugformValue,
            this.colQuantity,
            this.colInventory,
            this.colOPInventory,
            this.colEmergencyInventory,
            this.colIPInventory,
            this.colManufacturer});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.Delay = 200;
            this.dgvDetail.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDetail.DeleteLineRowIndexCollection")));
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetail.EnableSpecialKeyIntercept = true;
            this.dgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDetail.Location = new System.Drawing.Point(331, 23);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 60;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectColumn = null;
            this.dgvDetail.Size = new System.Drawing.Size(864, 622);
            this.dgvDetail.TabIndex = 14;
            this.dgvDetail.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetail_SpecialKeyDown);
            this.dgvDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellEndEdit);
            this.dgvDetail.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDetail_RowStateChanged);
            // 
            // colClassCode
            // 
            this.colClassCode.DataPropertyName = "SpecificationCode";
            this.colClassCode.HeaderText = "药品编码";
            this.colClassCode.MinimumWidth = 120;
            this.colClassCode.Name = "colClassCode";
            this.colClassCode.ReadOnly = true;
            this.colClassCode.Width = 120;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "DrugName";
            this.colName.HeaderText = "药品名称";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colSpecification
            // 
            this.colSpecification.DataPropertyName = "Specification";
            this.colSpecification.HeaderText = "规格";
            this.colSpecification.MinimumWidth = 150;
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.ReadOnly = true;
            this.colSpecification.Width = 150;
            // 
            // colPackageUnit
            // 
            this.colPackageUnit.DataPropertyName = "BigPackageUnit";
            this.colPackageUnit.HeaderText = "单位";
            this.colPackageUnit.MinimumWidth = 60;
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.ReadOnly = true;
            // 
            // colDrugformValue
            // 
            this.colDrugformValue.DataPropertyName = "DrugformValue";
            this.colDrugformValue.HeaderText = "剂型";
            this.colDrugformValue.MinimumWidth = 60;
            this.colDrugformValue.Name = "colDrugformValue";
            this.colDrugformValue.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "采购数量";
            this.colQuantity.MinimumWidth = 60;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colInventory
            // 
            this.colInventory.DataPropertyName = "Inventory";
            this.colInventory.HeaderText = "西药库库存";
            this.colInventory.MinimumWidth = 120;
            this.colInventory.Name = "colInventory";
            this.colInventory.ReadOnly = true;
            this.colInventory.Width = 120;
            // 
            // colOPInventory
            // 
            this.colOPInventory.DataPropertyName = "OPInventory";
            this.colOPInventory.HeaderText = "门诊药房库存";
            this.colOPInventory.MinimumWidth = 140;
            this.colOPInventory.Name = "colOPInventory";
            this.colOPInventory.ReadOnly = true;
            this.colOPInventory.Width = 140;
            // 
            // colEmergencyInventory
            // 
            this.colEmergencyInventory.DataPropertyName = "EmergencyInventory";
            this.colEmergencyInventory.HeaderText = "急诊西药房库存";
            this.colEmergencyInventory.MinimumWidth = 120;
            this.colEmergencyInventory.Name = "colEmergencyInventory";
            this.colEmergencyInventory.ReadOnly = true;
            this.colEmergencyInventory.Width = 120;
            // 
            // colIPInventory
            // 
            this.colIPInventory.DataPropertyName = "IPInventory";
            this.colIPInventory.HeaderText = "住院药房库存";
            this.colIPInventory.MinimumWidth = 60;
            this.colIPInventory.Name = "colIPInventory";
            this.colIPInventory.ReadOnly = true;
            this.colIPInventory.Width = 120;
            // 
            // colManufacturer
            // 
            this.colManufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colManufacturer.DataPropertyName = "Manufacturer";
            this.colManufacturer.HeaderText = "生产厂家";
            this.colManufacturer.MinimumWidth = 100;
            this.colManufacturer.Name = "colManufacturer";
            this.colManufacturer.ReadOnly = true;
            // 
            // FormProcurementPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 645);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProcurementPlan";
            this.Text = "采购计划";
            this.Load += new System.EventHandler(this.FormProcurementPlan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditStatus;
        private DevComponents.DotNetBar.ButtonX btnFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private DevComponents.DotNetBar.ButtonX btnExecl;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAudit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
        private HIS.ControlLib.DataGridViewExt dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackageUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugformValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOPInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturer;
    }
}