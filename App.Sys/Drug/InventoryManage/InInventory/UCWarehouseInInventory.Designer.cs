
namespace App_Sys.Drug.InventoryManage
{
    partial class UCWarehouseInInventory
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbxReceiptType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.tbxReceiptCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.dtEndDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvReceipt = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colAudit = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEdit = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDelete = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colReceiptCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCreatorUserName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCreationTime = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAuditName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAuditTime = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colInvoice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSupplyUnit = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.dgvReceiptDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colDrugName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colQuantity = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPurchasePrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colReceiptPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colProduction = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBatchNumber = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colMemo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbxReceiptType);
            this.panelEx1.Controls.Add(this.tbxReceiptCode);
            this.panelEx1.Controls.Add(this.btnAddNew);
            this.panelEx1.Controls.Add(this.btnQuery);
            this.panelEx1.Controls.Add(this.dtEndDate);
            this.panelEx1.Controls.Add(this.dtStartDate);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1254, 79);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Alpha = ((byte)(0));
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // cbxReceiptType
            // 
            this.cbxReceiptType.DisplayMember = "Text";
            this.cbxReceiptType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxReceiptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReceiptType.FormattingEnabled = true;
            this.cbxReceiptType.ItemHeight = 18;
            this.cbxReceiptType.Items.AddRange(new object[] {
            this.comboItem1});
            this.cbxReceiptType.Location = new System.Drawing.Point(91, 28);
            this.cbxReceiptType.Name = "cbxReceiptType";
            this.cbxReceiptType.Size = new System.Drawing.Size(121, 24);
            this.cbxReceiptType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxReceiptType.TabIndex = 4;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "采购入库";
            // 
            // tbxReceiptCode
            // 
            // 
            // 
            // 
            this.tbxReceiptCode.Border.Class = "TextBoxBorder";
            this.tbxReceiptCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxReceiptCode.Location = new System.Drawing.Point(703, 28);
            this.tbxReceiptCode.Name = "tbxReceiptCode";
            this.tbxReceiptCode.PreventEnterBeep = true;
            this.tbxReceiptCode.Size = new System.Drawing.Size(142, 23);
            this.tbxReceiptCode.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Location = new System.Drawing.Point(962, 28);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "新增";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(881, 28);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtEndDate
            // 
            // 
            // 
            // 
            this.dtEndDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndDate.ButtonDropDown.Visible = true;
            this.dtEndDate.IsPopupCalendarOpen = false;
            this.dtEndDate.Location = new System.Drawing.Point(495, 28);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtEndDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtEndDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtEndDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtEndDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDate.MonthCalendar.TodayButtonVisible = true;
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(124, 23);
            this.dtEndDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndDate.TabIndex = 1;
            // 
            // dtStartDate
            // 
            // 
            // 
            // 
            this.dtStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStartDate.ButtonDropDown.Visible = true;
            this.dtStartDate.IsPopupCalendarOpen = false;
            this.dtStartDate.Location = new System.Drawing.Point(337, 28);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtStartDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtStartDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.TodayButtonVisible = true;
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(124, 23);
            this.dtStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStartDate.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(467, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(22, 20);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "至";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(625, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 20);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "查询单号:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(42, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(43, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "类型:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(259, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "查询时间:";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dgvReceipt.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReceipt.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvReceipt.Location = new System.Drawing.Point(0, 79);
            this.dgvReceipt.Name = "dgvReceipt";
            // 
            // 
            // 
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colAudit);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colEdit);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colDelete);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colStatus);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colReceiptCode);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colCreatorUserName);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colCreationTime);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colAuditName);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colAuditTime);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colInvoice);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colSupplyUnit);
            this.dgvReceipt.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvReceipt.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvReceipt.Size = new System.Drawing.Size(1254, 368);
            this.dgvReceipt.TabIndex = 6;
            this.dgvReceipt.Text = "superGridControl1";
            this.dgvReceipt.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvReceipt_CellClick);
            // 
            // colAudit
            // 
            this.colAudit.Name = "审核";
            this.colAudit.Width = 80;
            // 
            // colEdit
            // 
            this.colEdit.Name = "修改";
            this.colEdit.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.Name = "删除";
            this.colDelete.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colStatus.Name = "状态";
            this.colStatus.ReadOnly = true;
            // 
            // colReceiptCode
            // 
            this.colReceiptCode.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.colReceiptCode.Name = "单据号";
            this.colReceiptCode.ReadOnly = true;
            this.colReceiptCode.Width = 150;
            // 
            // colCreatorUserName
            // 
            this.colCreatorUserName.Name = "录入人名称";
            this.colCreatorUserName.ReadOnly = true;
            // 
            // colCreationTime
            // 
            this.colCreationTime.Name = "录入时间";
            this.colCreationTime.ReadOnly = true;
            this.colCreationTime.Width = 150;
            // 
            // colAuditName
            // 
            this.colAuditName.Name = "审核人名称";
            this.colAuditName.ReadOnly = true;
            // 
            // colAuditTime
            // 
            this.colAuditTime.Name = "审核时间";
            this.colAuditTime.ReadOnly = true;
            this.colAuditTime.Width = 150;
            // 
            // colInvoice
            // 
            this.colInvoice.Name = "发票号";
            // 
            // colSupplyUnit
            // 
            this.colSupplyUnit.Name = "供应商";
            this.colSupplyUnit.ReadOnly = true;
            this.colSupplyUnit.Width = 200;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.Name = "";
            this.colWhite.ReadOnly = true;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.Expandable = false;
            this.expandableSplitter1.ExpandActionClick = false;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 447);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(1254, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 10;
            this.expandableSplitter1.TabStop = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dgvReceiptDetail);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 453);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panelEx2.Size = new System.Drawing.Size(1254, 399);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 11;
            // 
            // dgvReceiptDetail
            // 
            this.dgvReceiptDetail.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dgvReceiptDetail.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvReceiptDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceiptDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvReceiptDetail.Location = new System.Drawing.Point(0, 50);
            this.dgvReceiptDetail.Name = "dgvReceiptDetail";
            // 
            // 
            // 
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colDrugName);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colQuantity);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colPurchasePrice);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colPrice);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colReceiptPrice);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colProduction);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colBatchNumber);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.colMemo);
            this.dgvReceiptDetail.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.dgvReceiptDetail.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvReceiptDetail.PrimaryGrid.ReadOnly = true;
            this.dgvReceiptDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvReceiptDetail.Size = new System.Drawing.Size(1254, 349);
            this.dgvReceiptDetail.TabIndex = 7;
            this.dgvReceiptDetail.Text = "superGridControl1";
            // 
            // colDrugName
            // 
            this.colDrugName.Name = "药品名称";
            this.colDrugName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.Name = "数量";
            this.colQuantity.Width = 150;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colPurchasePrice.Name = "进货价";
            // 
            // colPrice
            // 
            this.colPrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colPrice.Name = "零售价";
            // 
            // colReceiptPrice
            // 
            this.colReceiptPrice.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.colReceiptPrice.Name = "单据价格";
            // 
            // colProduction
            // 
            this.colProduction.Name = "生产厂家";
            this.colProduction.Width = 200;
            // 
            // colBatchNumber
            // 
            this.colBatchNumber.Name = "批号";
            this.colBatchNumber.Width = 150;
            // 
            // colMemo
            // 
            this.colMemo.Name = "备注";
            this.colMemo.Width = 200;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn1.Name = "";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(42, 15);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(72, 20);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "单据明细:";
            // 
            // UCWarehouseInInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCWarehouseInInventory";
            this.Size = new System.Drawing.Size(1254, 852);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStartDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxReceiptCode;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxReceiptType;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvReceipt;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAudit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEdit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDelete;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colReceiptCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCreatorUserName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCreationTime;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAuditName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAuditTime;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSupplyUnit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStatus;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvReceiptDetail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBatchNumber;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDrugName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colProduction;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colQuantity;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPurchasePrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colMemo;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colReceiptPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colInvoice;
    }
}
