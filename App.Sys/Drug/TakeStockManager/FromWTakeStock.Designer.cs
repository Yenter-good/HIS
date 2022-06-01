namespace App_Sys.Drug
{
    partial class FromWTakeStock
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.dtStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnAudit = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.btnQuery = new DevComponents.DotNetBar.ButtonItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colReceiptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Controls.Add(this.dtStart);
            this.bar1.Controls.Add(this.dtEnd);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnAudit,
            this.labelItem1,
            this.controlContainerItem1,
            this.labelItem2,
            this.controlContainerItem2,
            this.btnQuery});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1189, 30);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 46;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // dtStart
            // 
            // 
            // 
            // 
            this.dtStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStart.ButtonDropDown.Visible = true;
            this.dtStart.IsPopupCalendarOpen = false;
            this.dtStart.Location = new System.Drawing.Point(257, 2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStart.MonthCalendar.TodayButtonVisible = true;
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 25);
            this.dtStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            // 
            // 
            // 
            this.dtEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEnd.ButtonDropDown.Visible = true;
            this.dtEnd.IsPopupCalendarOpen = false;
            this.dtEnd.Location = new System.Drawing.Point(497, 2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEnd.MonthCalendar.TodayButtonVisible = true;
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 25);
            this.dtEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEnd.TabIndex = 48;
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
            this.btnEdit.Text = "详情";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Text = "审核盘点";
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "盘点日期";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.dtStart;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "到：";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.dtEnd;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // btnQuery
            // 
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReceiptCode,
            this.colDate,
            this.colAuditUserName,
            this.colAuditTime,
            this.colAuditStatus,
            this.colBeginAmount,
            this.colEndAmount});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 30);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1189, 600);
            this.dgvMain.TabIndex = 47;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            this.dgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMain_CellFormatting);
            // 
            // colReceiptCode
            // 
            this.colReceiptCode.DataPropertyName = "ReceiptCode";
            this.colReceiptCode.HeaderText = "单据号";
            this.colReceiptCode.MinimumWidth = 200;
            this.colReceiptCode.Name = "colReceiptCode";
            this.colReceiptCode.ReadOnly = true;
            this.colReceiptCode.Width = 200;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CreationTime";
            this.colDate.HeaderText = "盘点时间";
            this.colDate.MinimumWidth = 180;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 180;
            // 
            // colAuditUserName
            // 
            this.colAuditUserName.DataPropertyName = "AuditUserName";
            this.colAuditUserName.HeaderText = "审核人";
            this.colAuditUserName.MinimumWidth = 120;
            this.colAuditUserName.Name = "colAuditUserName";
            this.colAuditUserName.ReadOnly = true;
            this.colAuditUserName.Width = 120;
            // 
            // colAuditTime
            // 
            this.colAuditTime.DataPropertyName = "AuditTime";
            this.colAuditTime.HeaderText = "审核时间";
            this.colAuditTime.MinimumWidth = 180;
            this.colAuditTime.Name = "colAuditTime";
            this.colAuditTime.ReadOnly = true;
            this.colAuditTime.Width = 180;
            // 
            // colAuditStatus
            // 
            this.colAuditStatus.DataPropertyName = "AuditStatus";
            this.colAuditStatus.HeaderText = "状态";
            this.colAuditStatus.MinimumWidth = 150;
            this.colAuditStatus.Name = "colAuditStatus";
            this.colAuditStatus.ReadOnly = true;
            this.colAuditStatus.Width = 150;
            // 
            // colBeginAmount
            // 
            this.colBeginAmount.DataPropertyName = "BeginAmount";
            this.colBeginAmount.HeaderText = "期初金额（元）";
            this.colBeginAmount.MinimumWidth = 220;
            this.colBeginAmount.Name = "colBeginAmount";
            this.colBeginAmount.ReadOnly = true;
            this.colBeginAmount.Width = 220;
            // 
            // colEndAmount
            // 
            this.colEndAmount.DataPropertyName = "EndAmount";
            this.colEndAmount.HeaderText = "期末金额（元）";
            this.colEndAmount.MinimumWidth = 220;
            this.colEndAmount.Name = "colEndAmount";
            this.colEndAmount.ReadOnly = true;
            this.colEndAmount.Width = 220;
            // 
            // FromWTakeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 630);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.bar1);
            this.Name = "FromWTakeStock";
            this.Text = "盘点管理";
            this.Shown += new System.EventHandler(this.FromWTakeStock_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private System.Windows.Forms.DataGridView dgvMain;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEnd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStart;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.ButtonItem btnQuery;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndAmount;
    }
}