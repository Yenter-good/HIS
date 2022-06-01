
namespace App_Sys.Drug
{
    partial class FormAddPriceChangedReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPriceChangedReceipt));
            HIS.ControlLib.BindColumn bindColumn1 = new HIS.ControlLib.BindColumn();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dtpPlanEffectTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.cbxMemo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxReceiptCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvDrugs = new HIS.ControlLib.DataGridViewExt();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealTimePrice = new HIS.ControlLib.DataGridViewFloatInputExtColumn();
            this.colNewPrice = new HIS.ControlLib.DataGridViewFloatInputExtColumn();
            this.colProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDrugFilter = new HIS.ControlLib.DataGridViewInput();
            this.colFilterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterTradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterApprovalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPlanEffectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dtpPlanEffectTime);
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.btnCommit);
            this.panelEx1.Controls.Add(this.cbxMemo);
            this.panelEx1.Controls.Add(this.btnDelete);
            this.panelEx1.Controls.Add(this.btnNew);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.tbxReceiptCode);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1341, 111);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1004;
            // 
            // dtpPlanEffectTime
            // 
            // 
            // 
            // 
            this.dtpPlanEffectTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpPlanEffectTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpPlanEffectTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpPlanEffectTime.ButtonDropDown.Visible = true;
            this.dtpPlanEffectTime.IsPopupCalendarOpen = false;
            this.dtpPlanEffectTime.Location = new System.Drawing.Point(119, 83);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpPlanEffectTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpPlanEffectTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpPlanEffectTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpPlanEffectTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpPlanEffectTime.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpPlanEffectTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpPlanEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpPlanEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpPlanEffectTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpPlanEffectTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpPlanEffectTime.MonthCalendar.TodayButtonVisible = true;
            this.dtpPlanEffectTime.Name = "dtpPlanEffectTime";
            this.dtpPlanEffectTime.Size = new System.Drawing.Size(192, 23);
            this.dtpPlanEffectTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpPlanEffectTime.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(560, 82);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommit.Checked = true;
            this.btnCommit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommit.Location = new System.Drawing.Point(479, 82);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 7;
            this.btnCommit.Text = "提交";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // cbxMemo
            // 
            this.cbxMemo.DisplayMember = "Text";
            this.cbxMemo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMemo.FormattingEnabled = true;
            this.cbxMemo.ItemHeight = 18;
            this.cbxMemo.Location = new System.Drawing.Point(119, 53);
            this.cbxMemo.Name = "cbxMemo";
            this.cbxMemo.Size = new System.Drawing.Size(192, 24);
            this.cbxMemo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMemo.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(398, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(317, 82);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(41, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "调价原因:";
            // 
            // tbxReceiptCode
            // 
            // 
            // 
            // 
            this.tbxReceiptCode.Border.Class = "TextBoxBorder";
            this.tbxReceiptCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxReceiptCode.Location = new System.Drawing.Point(119, 24);
            this.tbxReceiptCode.Name = "tbxReceiptCode";
            this.tbxReceiptCode.PreventEnterBeep = true;
            this.tbxReceiptCode.ReadOnly = true;
            this.tbxReceiptCode.Size = new System.Drawing.Size(192, 23);
            this.tbxReceiptCode.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 86);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 20);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "计划生效日期:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(55, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 20);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "单据号:";
            // 
            // dgvDrugs
            // 
            this.dgvDrugs.AllowUserToAddRows = false;
            this.dgvDrugs.AllowUserToDeleteRows = false;
            this.dgvDrugs.AllowUserToResizeColumns = false;
            this.dgvDrugs.AllowUserToResizeRows = false;
            this.dgvDrugs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrugs.ClickBlankClearSelect = false;
            this.dgvDrugs.ColumnHeadersHeight = 30;
            this.dgvDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colTradeName,
            this.colSpecification,
            this.colRealTimePrice,
            this.colNewPrice,
            this.colProduction,
            this.colWhite});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrugs.Delay = 200;
            this.dgvDrugs.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDrugs.DeleteLineRowIndexCollection")));
            this.dgvDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDrugs.EnableSpecialKeyIntercept = true;
            this.dgvDrugs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDrugs.Location = new System.Drawing.Point(0, 111);
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.RowHeadersVisible = false;
            this.dgvDrugs.RowTemplate.Height = 23;
            this.dgvDrugs.SelectColumn = null;
            this.dgvDrugs.Size = new System.Drawing.Size(1341, 655);
            this.dgvDrugs.TabIndex = 1018;
            this.dgvDrugs.TextChange += new System.EventHandler<HIS.ControlLib.TextChangeEventArgs>(this.dgvDrugs_TextChange);
            this.dgvDrugs.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDrugs_SpecialKeyDown);
            // 
            // colName
            // 
            this.colName.HeaderText = "药品名称";
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colTradeName
            // 
            this.colTradeName.HeaderText = "商品名";
            this.colTradeName.Name = "colTradeName";
            this.colTradeName.ReadOnly = true;
            this.colTradeName.Width = 200;
            // 
            // colSpecification
            // 
            this.colSpecification.HeaderText = "规格";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.ReadOnly = true;
            // 
            // colRealTimePrice
            // 
            this.colRealTimePrice.BindFieldName = null;
            this.colRealTimePrice.Digits = 0;
            this.colRealTimePrice.HeaderText = "原零售价";
            this.colRealTimePrice.Name = "colRealTimePrice";
            this.colRealTimePrice.ReadOnly = true;
            this.colRealTimePrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRealTimePrice.Round = false;
            this.colRealTimePrice.Tags = null;
            // 
            // colNewPrice
            // 
            this.colNewPrice.BindFieldName = null;
            this.colNewPrice.Digits = 0;
            this.colNewPrice.HeaderText = "现零售价";
            this.colNewPrice.Name = "colNewPrice";
            this.colNewPrice.Round = false;
            this.colNewPrice.Tags = null;
            // 
            // colProduction
            // 
            this.colProduction.HeaderText = "生产厂家";
            this.colProduction.Name = "colProduction";
            this.colProduction.ReadOnly = true;
            this.colProduction.Width = 200;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite.HeaderText = "";
            this.colWhite.Name = "colWhite";
            this.colWhite.ReadOnly = true;
            // 
            // dgvDrugFilter
            // 
            this.dgvDrugFilter.AllowUserToAddRows = false;
            this.dgvDrugFilter.AllowUserToDeleteRows = false;
            this.dgvDrugFilter.AllowUserToResizeColumns = false;
            this.dgvDrugFilter.AllowUserToResizeRows = false;
            this.dgvDrugFilter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugFilter.ColumnHeadersHeight = 30;
            this.dgvDrugFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilterName,
            this.colFilterTradeName,
            this.colFilterSpecification,
            this.colFilterProduction,
            this.colFilterApprovalNumber,
            this.colFilterWhite});
            bindColumn1.Column = null;
            this.dgvDrugFilter.Container.BindColumn = bindColumn1;
            this.dgvDrugFilter.Container.Host = this.dgvDrugs;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugFilter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrugFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDrugFilter.Location = new System.Drawing.Point(206, 218);
            this.dgvDrugFilter.Name = "dgvDrugFilter";
            this.dgvDrugFilter.ReadOnly = true;
            this.dgvDrugFilter.RowHeadersVisible = false;
            this.dgvDrugFilter.RowTemplate.Height = 23;
            this.dgvDrugFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugFilter.Size = new System.Drawing.Size(949, 304);
            this.dgvDrugFilter.TabIndex = 1022;
            this.dgvDrugFilter.Visible = false;
            this.dgvDrugFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugFilter_CellDoubleClick);
            // 
            // colFilterName
            // 
            this.colFilterName.DataPropertyName = "DrugName";
            this.colFilterName.HeaderText = "药品名称";
            this.colFilterName.Name = "colFilterName";
            this.colFilterName.ReadOnly = true;
            this.colFilterName.Width = 200;
            // 
            // colFilterTradeName
            // 
            this.colFilterTradeName.HeaderText = "商品名";
            this.colFilterTradeName.Name = "colFilterTradeName";
            this.colFilterTradeName.ReadOnly = true;
            this.colFilterTradeName.Width = 200;
            // 
            // colFilterSpecification
            // 
            this.colFilterSpecification.DataPropertyName = "Specification";
            this.colFilterSpecification.HeaderText = "规格";
            this.colFilterSpecification.Name = "colFilterSpecification";
            this.colFilterSpecification.ReadOnly = true;
            // 
            // colFilterProduction
            // 
            this.colFilterProduction.DataPropertyName = "Manufacturer";
            this.colFilterProduction.HeaderText = "生产厂家";
            this.colFilterProduction.Name = "colFilterProduction";
            this.colFilterProduction.ReadOnly = true;
            this.colFilterProduction.Width = 200;
            // 
            // colFilterApprovalNumber
            // 
            this.colFilterApprovalNumber.DataPropertyName = "ApprovalNumber";
            this.colFilterApprovalNumber.HeaderText = "批准文号";
            this.colFilterApprovalNumber.Name = "colFilterApprovalNumber";
            this.colFilterApprovalNumber.ReadOnly = true;
            // 
            // colFilterWhite
            // 
            this.colFilterWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilterWhite.HeaderText = "";
            this.colFilterWhite.Name = "colFilterWhite";
            this.colFilterWhite.ReadOnly = true;
            // 
            // FormAddPriceChangedReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 766);
            this.Controls.Add(this.dgvDrugFilter);
            this.Controls.Add(this.dgvDrugs);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormAddPriceChangedReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加药品调价单";
            this.Shown += new System.EventHandler(this.FormAddWarehouseInInventoryReceipt_Shown);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPlanEffectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxReceiptCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private HIS.ControlLib.DataGridViewExt dgvDrugs;
        private HIS.ControlLib.DataGridViewInput dgvDrugFilter;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMemo;
        private DevComponents.DotNetBar.ButtonX btnCommit;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterTradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterApprovalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterWhite;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpPlanEffectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification;
        private HIS.ControlLib.DataGridViewFloatInputExtColumn colRealTimePrice;
        private HIS.ControlLib.DataGridViewFloatInputExtColumn colNewPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
    }
}