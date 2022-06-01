namespace App_ChargeSystem.Empi
{
    partial class FormPatientManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnHealthCare = new DevComponents.DotNetBar.ButtonX();
            this.btnIdCard = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tbxPhoneNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tbxAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cbxCounty = new HIS.ControlLib.Popups.FindComboBox();
            this.cbxCity = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbxProvince = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.tbxId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbxBirthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbxIdNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxUnitAddr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.tbxWeigth = new DevComponents.Editors.DoubleInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.tbxHeight = new DevComponents.Editors.DoubleInput();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.cbxProfessiona = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.cbxEducationId = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBirthday)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxWeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMain);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索患者";
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientName,
            this.colPatientIdCard});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 97);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(345, 521);
            this.dgvMain.TabIndex = 15;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colPatientName
            // 
            this.colPatientName.DataPropertyName = "Name";
            this.colPatientName.HeaderText = "姓名";
            this.colPatientName.MinimumWidth = 6;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 125;
            // 
            // colPatientIdCard
            // 
            this.colPatientIdCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPatientIdCard.DataPropertyName = "IdCard";
            this.colPatientIdCard.HeaderText = "身份证号";
            this.colPatientIdCard.MinimumWidth = 6;
            this.colPatientIdCard.Name = "colPatientIdCard";
            this.colPatientIdCard.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.btnHealthCare);
            this.groupBox2.Controls.Add(this.btnIdCard);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快捷读卡";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(264, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnHealthCare
            // 
            this.btnHealthCare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHealthCare.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHealthCare.Location = new System.Drawing.Point(104, 22);
            this.btnHealthCare.Name = "btnHealthCare";
            this.btnHealthCare.Size = new System.Drawing.Size(75, 23);
            this.btnHealthCare.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHealthCare.TabIndex = 2;
            this.btnHealthCare.Text = "医保卡";
            // 
            // btnIdCard
            // 
            this.btnIdCard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIdCard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIdCard.Location = new System.Drawing.Point(23, 22);
            this.btnIdCard.Name = "btnIdCard";
            this.btnIdCard.Size = new System.Drawing.Size(75, 23);
            this.btnIdCard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIdCard.TabIndex = 1;
            this.btnIdCard.Text = "身份证";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.tbxPhoneNo);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.labelX10);
            this.groupBox3.Controls.Add(this.tbxAge);
            this.groupBox3.Controls.Add(this.tbxAddress);
            this.groupBox3.Controls.Add(this.labelX9);
            this.groupBox3.Controls.Add(this.cbxCounty);
            this.groupBox3.Controls.Add(this.cbxCity);
            this.groupBox3.Controls.Add(this.labelX8);
            this.groupBox3.Controls.Add(this.cbxProvince);
            this.groupBox3.Controls.Add(this.labelX7);
            this.groupBox3.Controls.Add(this.labelX6);
            this.groupBox3.Controls.Add(this.labelX5);
            this.groupBox3.Controls.Add(this.cbxSex);
            this.groupBox3.Controls.Add(this.tbxId);
            this.groupBox3.Controls.Add(this.labelX4);
            this.groupBox3.Controls.Add(this.tbxBirthday);
            this.groupBox3.Controls.Add(this.labelX3);
            this.groupBox3.Controls.Add(this.tbxIdNo);
            this.groupBox3.Controls.Add(this.labelX2);
            this.groupBox3.Controls.Add(this.tbxName);
            this.groupBox3.Controls.Add(this.labelX1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(351, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(813, 327);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "患者基本信息";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(295, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 46);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "清空";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(191, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 46);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "修改";
            // 
            // tbxPhoneNo
            // 
            // 
            // 
            // 
            this.tbxPhoneNo.Border.Class = "TextBoxBorder";
            this.tbxPhoneNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPhoneNo.Location = new System.Drawing.Point(91, 172);
            this.tbxPhoneNo.Name = "tbxPhoneNo";
            this.tbxPhoneNo.PreventEnterBeep = true;
            this.tbxPhoneNo.Size = new System.Drawing.Size(309, 23);
            this.tbxPhoneNo.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(91, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 46);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "注册";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(6, 169);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(79, 23);
            this.labelX10.TabIndex = 19;
            this.labelX10.Text = "联系电话：";
            // 
            // tbxAge
            // 
            // 
            // 
            // 
            this.tbxAge.Border.Class = "TextBoxBorder";
            this.tbxAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAge.Location = new System.Drawing.Point(707, 89);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.PreventEnterBeep = true;
            this.tbxAge.ReadOnly = true;
            this.tbxAge.Size = new System.Drawing.Size(75, 23);
            this.tbxAge.TabIndex = 18;
            // 
            // tbxAddress
            // 
            // 
            // 
            // 
            this.tbxAddress.Border.Class = "TextBoxBorder";
            this.tbxAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAddress.Location = new System.Drawing.Point(91, 215);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PreventEnterBeep = true;
            this.tbxAddress.Size = new System.Drawing.Size(309, 23);
            this.tbxAddress.TabIndex = 17;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(37, 212);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(48, 23);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "住址：";
            // 
            // cbxCounty
            // 
            this.cbxCounty.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxCounty.Border.Class = "TextBoxBorder";
            this.cbxCounty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxCounty.CanResizePopup = false;
            this.cbxCounty.ColumnHeaders = null;
            this.cbxCounty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxCounty.DataSource = null;
            this.cbxCounty.DisplayMember = "";
            this.cbxCounty.FilterFields = null;
            this.cbxCounty.FocusOpen = false;
            this.cbxCounty.Location = new System.Drawing.Point(553, 212);
            this.cbxCounty.Name = "cbxCounty";
            this.cbxCounty.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxCounty.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxCounty.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxCounty.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxCounty.PopupOffSet = 2;
            this.cbxCounty.PreventEnterBeep = true;
            this.cbxCounty.ReadOnly = true;
            this.cbxCounty.SelectedItem = null;
            this.cbxCounty.SelectedValue = null;
            this.cbxCounty.ShowClearButton = true;
            this.cbxCounty.ShowPopupShadow = true;
            this.cbxCounty.Size = new System.Drawing.Size(229, 23);
            this.cbxCounty.SupportPinyinSearch = false;
            this.cbxCounty.SupportWubiSearch = false;
            this.cbxCounty.TabIndex = 15;
            this.cbxCounty.ValueMember = null;
            // 
            // cbxCity
            // 
            this.cbxCity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxCity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxCity.CanResizePopup = false;
            this.cbxCity.ColumnHeaders = null;
            this.cbxCity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxCity.DataSource = null;
            this.cbxCity.DisplayMember = "";
            this.cbxCity.FilterFields = null;
            this.cbxCity.FocusOpen = false;
            this.cbxCity.Location = new System.Drawing.Point(553, 169);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxCity.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxCity.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxCity.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxCity.PopupOffSet = 2;
            this.cbxCity.PreventEnterBeep = true;
            this.cbxCity.ReadOnly = true;
            this.cbxCity.SelectedItem = null;
            this.cbxCity.SelectedValue = null;
            this.cbxCity.ShowClearButton = true;
            this.cbxCity.ShowPopupShadow = true;
            this.cbxCity.Size = new System.Drawing.Size(229, 17);
            this.cbxCity.SupportPinyinSearch = false;
            this.cbxCity.SupportWubiSearch = false;
            this.cbxCity.TabIndex = 14;
            this.cbxCity.ValueMember = null;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(448, 212);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(114, 23);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "籍贯（区/县）：";
            // 
            // cbxProvince
            // 
            this.cbxProvince.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxProvince.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxProvince.CanResizePopup = false;
            this.cbxProvince.ColumnHeaders = null;
            this.cbxProvince.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxProvince.DataSource = null;
            this.cbxProvince.DisplayMember = "";
            this.cbxProvince.FilterFields = null;
            this.cbxProvince.FocusOpen = false;
            this.cbxProvince.Location = new System.Drawing.Point(553, 127);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxProvince.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxProvince.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxProvince.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxProvince.PopupOffSet = 2;
            this.cbxProvince.PreventEnterBeep = true;
            this.cbxProvince.ReadOnly = true;
            this.cbxProvince.SelectedItem = null;
            this.cbxProvince.SelectedValue = null;
            this.cbxProvince.ShowClearButton = true;
            this.cbxProvince.ShowPopupShadow = true;
            this.cbxProvince.Size = new System.Drawing.Size(229, 17);
            this.cbxProvince.SupportPinyinSearch = false;
            this.cbxProvince.SupportWubiSearch = false;
            this.cbxProvince.TabIndex = 12;
            this.cbxProvince.ValueMember = null;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(463, 169);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(96, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "籍贯（市）：";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(463, 127);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(93, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "籍贯（省）：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(244, 86);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "性别：";
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(310, 85);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(90, 22);
            this.cbxSex.TabIndex = 8;
            // 
            // tbxId
            // 
            // 
            // 
            // 
            this.tbxId.Border.Class = "TextBoxBorder";
            this.tbxId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxId.Location = new System.Drawing.Point(91, 42);
            this.tbxId.Name = "tbxId";
            this.tbxId.PreventEnterBeep = true;
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(691, 23);
            this.tbxId.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(21, 42);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(64, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "患者ID：";
            // 
            // tbxBirthday
            // 
            // 
            // 
            // 
            this.tbxBirthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tbxBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBirthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.tbxBirthday.ButtonDropDown.Visible = true;
            this.tbxBirthday.IsPopupCalendarOpen = false;
            this.tbxBirthday.Location = new System.Drawing.Point(553, 89);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tbxBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.tbxBirthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.tbxBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.tbxBirthday.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.tbxBirthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tbxBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.tbxBirthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tbxBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBirthday.MonthCalendar.TodayButtonVisible = true;
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.Size = new System.Drawing.Size(146, 23);
            this.tbxBirthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbxBirthday.TabIndex = 5;
            this.tbxBirthday.ValueChanged += new System.EventHandler(this.tbxBirthday_ValueChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(476, 89);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "出生日期：";
            // 
            // tbxIdNo
            // 
            // 
            // 
            // 
            this.tbxIdNo.Border.Class = "TextBoxBorder";
            this.tbxIdNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxIdNo.Location = new System.Drawing.Point(91, 127);
            this.tbxIdNo.Name = "tbxIdNo";
            this.tbxIdNo.PreventEnterBeep = true;
            this.tbxIdNo.Size = new System.Drawing.Size(309, 23);
            this.tbxIdNo.TabIndex = 3;
            this.tbxIdNo.Leave += new System.EventHandler(this.tbxIdNo_Leave);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "身份证号：";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(91, 86);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(147, 23);
            this.tbxName.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(33, 89);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(52, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "姓名：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxUnitAddr);
            this.groupBox4.Controls.Add(this.tbxUnit);
            this.groupBox4.Controls.Add(this.labelX16);
            this.groupBox4.Controls.Add(this.labelX15);
            this.groupBox4.Controls.Add(this.tbxWeigth);
            this.groupBox4.Controls.Add(this.labelX14);
            this.groupBox4.Controls.Add(this.tbxHeight);
            this.groupBox4.Controls.Add(this.labelX13);
            this.groupBox4.Controls.Add(this.cbxProfessiona);
            this.groupBox4.Controls.Add(this.labelX12);
            this.groupBox4.Controls.Add(this.cbxEducationId);
            this.groupBox4.Controls.Add(this.labelX11);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(351, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(813, 294);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "附属信息";
            // 
            // tbxUnitAddr
            // 
            // 
            // 
            // 
            this.tbxUnitAddr.Border.Class = "TextBoxBorder";
            this.tbxUnitAddr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxUnitAddr.Location = new System.Drawing.Point(520, 107);
            this.tbxUnitAddr.Name = "tbxUnitAddr";
            this.tbxUnitAddr.PreventEnterBeep = true;
            this.tbxUnitAddr.Size = new System.Drawing.Size(262, 23);
            this.tbxUnitAddr.TabIndex = 26;
            // 
            // tbxUnit
            // 
            // 
            // 
            // 
            this.tbxUnit.Border.Class = "TextBoxBorder";
            this.tbxUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxUnit.Location = new System.Drawing.Point(91, 107);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.PreventEnterBeep = true;
            this.tbxUnit.Size = new System.Drawing.Size(309, 23);
            this.tbxUnit.TabIndex = 25;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(448, 110);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(79, 23);
            this.labelX16.TabIndex = 24;
            this.labelX16.Text = "单位地址：";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(6, 107);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(79, 23);
            this.labelX15.TabIndex = 22;
            this.labelX15.Text = "工作单位：";
            // 
            // tbxWeigth
            // 
            // 
            // 
            // 
            this.tbxWeigth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tbxWeigth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxWeigth.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.tbxWeigth.Increment = 1D;
            this.tbxWeigth.Location = new System.Drawing.Point(699, 53);
            this.tbxWeigth.Name = "tbxWeigth";
            this.tbxWeigth.ShowUpDown = true;
            this.tbxWeigth.Size = new System.Drawing.Size(83, 23);
            this.tbxWeigth.TabIndex = 21;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(627, 53);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(80, 23);
            this.labelX14.TabIndex = 20;
            this.labelX14.Text = "体重(kg)：";
            // 
            // tbxHeight
            // 
            // 
            // 
            // 
            this.tbxHeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tbxHeight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxHeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.tbxHeight.Increment = 1D;
            this.tbxHeight.Location = new System.Drawing.Point(520, 53);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.ShowUpDown = true;
            this.tbxHeight.Size = new System.Drawing.Size(88, 23);
            this.tbxHeight.TabIndex = 19;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(448, 53);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(80, 23);
            this.labelX13.TabIndex = 18;
            this.labelX13.Text = "身高(cm)：";
            // 
            // cbxProfessiona
            // 
            this.cbxProfessiona.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxProfessiona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxProfessiona.CanResizePopup = false;
            this.cbxProfessiona.ColumnHeaders = null;
            this.cbxProfessiona.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxProfessiona.DataSource = null;
            this.cbxProfessiona.DisplayMember = "";
            this.cbxProfessiona.FilterFields = null;
            this.cbxProfessiona.FocusOpen = false;
            this.cbxProfessiona.Location = new System.Drawing.Point(284, 53);
            this.cbxProfessiona.Name = "cbxProfessiona";
            this.cbxProfessiona.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxProfessiona.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxProfessiona.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxProfessiona.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxProfessiona.PopupOffSet = 2;
            this.cbxProfessiona.PreventEnterBeep = true;
            this.cbxProfessiona.ReadOnly = true;
            this.cbxProfessiona.SelectedItem = null;
            this.cbxProfessiona.SelectedValue = null;
            this.cbxProfessiona.ShowClearButton = true;
            this.cbxProfessiona.ShowPopupShadow = true;
            this.cbxProfessiona.Size = new System.Drawing.Size(116, 17);
            this.cbxProfessiona.SupportPinyinSearch = false;
            this.cbxProfessiona.SupportWubiSearch = false;
            this.cbxProfessiona.TabIndex = 17;
            this.cbxProfessiona.ValueMember = null;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(214, 53);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(52, 23);
            this.labelX12.TabIndex = 16;
            this.labelX12.Text = "职业：";
            // 
            // cbxEducationId
            // 
            this.cbxEducationId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxEducationId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxEducationId.CanResizePopup = false;
            this.cbxEducationId.ColumnHeaders = null;
            this.cbxEducationId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxEducationId.DataSource = null;
            this.cbxEducationId.DisplayMember = "";
            this.cbxEducationId.FilterFields = null;
            this.cbxEducationId.FocusOpen = false;
            this.cbxEducationId.Location = new System.Drawing.Point(91, 53);
            this.cbxEducationId.Name = "cbxEducationId";
            this.cbxEducationId.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxEducationId.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxEducationId.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxEducationId.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxEducationId.PopupOffSet = 2;
            this.cbxEducationId.PreventEnterBeep = true;
            this.cbxEducationId.ReadOnly = true;
            this.cbxEducationId.SelectedItem = null;
            this.cbxEducationId.SelectedValue = null;
            this.cbxEducationId.ShowClearButton = true;
            this.cbxEducationId.ShowPopupShadow = true;
            this.cbxEducationId.Size = new System.Drawing.Size(116, 17);
            this.cbxEducationId.SupportPinyinSearch = false;
            this.cbxEducationId.SupportWubiSearch = false;
            this.cbxEducationId.TabIndex = 15;
            this.cbxEducationId.ValueMember = null;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(33, 53);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(52, 23);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "学历：";
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(3, 19);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(10);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(345, 23);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.WatermarkText = "身份证号、姓名、拼音码、手机号 查询";
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            // 
            // FormPatientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 621);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPatientManager";
            this.Text = "患者信息编辑";
            this.Load += new System.EventHandler(this.FormPatientManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxBirthday)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxWeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnHealthCare;
        private DevComponents.DotNetBar.ButtonX btnIdCard;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientIdCard;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxPhoneNo;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAge;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAddress;
        private DevComponents.DotNetBar.LabelX labelX9;
        private HIS.ControlLib.Popups.FindComboBox cbxCounty;
        private HIS.ControlLib.Popups.FindComboBox cbxCity;
        private DevComponents.DotNetBar.LabelX labelX8;
        private HIS.ControlLib.Popups.FindComboBox cbxProvince;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ComboBox cbxSex;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxId;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput tbxBirthday;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxIdNo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.LabelX labelX13;
        private HIS.ControlLib.Popups.FindComboBox cbxProfessiona;
        private DevComponents.DotNetBar.LabelX labelX12;
        private HIS.ControlLib.Popups.FindComboBox cbxEducationId;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.Editors.DoubleInput tbxWeigth;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.Editors.DoubleInput tbxHeight;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxUnitAddr;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxUnit;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
    }
}