namespace App_Sys.User
{
    partial class UCUserRoleInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.dtAllowStartTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtAllowEndTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.fcbTeacher = new HIS.ControlLib.Popups.FindComboBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvDept = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colDeptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbxDept = new HIS.ControlLib.DelayTextBox();
            this.treeDept = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllowStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllowEndTime)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDept)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(113, 104);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(180, 20);
            this.labelX10.TabIndex = 19;
            this.labelX10.Text = "在下面列表中双击删除科室";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(3, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 20);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "检索并添加科室:";
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(244, 15);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(22, 20);
            this.labelX12.TabIndex = 34;
            this.labelX12.Text = "至";
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(17, 15);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(101, 20);
            this.labelX11.TabIndex = 34;
            this.labelX11.Text = "允许登录时间:";
            // 
            // dtAllowStartTime
            // 
            // 
            // 
            // 
            this.dtAllowStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtAllowStartTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowStartTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtAllowStartTime.ButtonDropDown.Visible = true;
            this.dtAllowStartTime.CustomFormat = "HH:mm";
            this.dtAllowStartTime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtAllowStartTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtAllowStartTime.IsPopupCalendarOpen = false;
            this.dtAllowStartTime.Location = new System.Drawing.Point(124, 12);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtAllowStartTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowStartTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtAllowStartTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtAllowStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowStartTime.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dtAllowStartTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtAllowStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtAllowStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAllowStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtAllowStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowStartTime.MonthCalendar.TodayButtonVisible = true;
            this.dtAllowStartTime.MonthCalendar.Visible = false;
            this.dtAllowStartTime.Name = "dtAllowStartTime";
            this.dtAllowStartTime.Size = new System.Drawing.Size(114, 23);
            this.dtAllowStartTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtAllowStartTime.TabIndex = 108;
            this.dtAllowStartTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // dtAllowEndTime
            // 
            // 
            // 
            // 
            this.dtAllowEndTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtAllowEndTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowEndTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtAllowEndTime.ButtonDropDown.Visible = true;
            this.dtAllowEndTime.CustomFormat = "HH:mm";
            this.dtAllowEndTime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtAllowEndTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtAllowEndTime.IsPopupCalendarOpen = false;
            this.dtAllowEndTime.Location = new System.Drawing.Point(272, 12);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtAllowEndTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowEndTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtAllowEndTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtAllowEndTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowEndTime.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dtAllowEndTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtAllowEndTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtAllowEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtAllowEndTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtAllowEndTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtAllowEndTime.MonthCalendar.TodayButtonVisible = true;
            this.dtAllowEndTime.MonthCalendar.Visible = false;
            this.dtAllowEndTime.Name = "dtAllowEndTime";
            this.dtAllowEndTime.Size = new System.Drawing.Size(114, 23);
            this.dtAllowEndTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtAllowEndTime.TabIndex = 109;
            this.dtAllowEndTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(46, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 110;
            this.labelX1.Text = "带教老师:";
            // 
            // fcbTeacher
            // 
            this.fcbTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcbTeacher.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fcbTeacher.Border.Class = "TextBoxBorder";
            this.fcbTeacher.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fcbTeacher.CanResizePopup = false;
            this.fcbTeacher.ColumnHeaders = null;
            this.fcbTeacher.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fcbTeacher.DataSource = null;
            this.fcbTeacher.DisplayMember = "";
            this.fcbTeacher.FilterFields = null;
            this.fcbTeacher.FocusOpen = false;
            this.fcbTeacher.Location = new System.Drawing.Point(124, 41);
            this.fcbTeacher.Name = "fcbTeacher";
            this.fcbTeacher.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fcbTeacher.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fcbTeacher.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fcbTeacher.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fcbTeacher.PopupOffSet = 2;
            this.fcbTeacher.PreventEnterBeep = true;
            this.fcbTeacher.ReadOnly = true;
            this.fcbTeacher.SelectedItem = null;
            this.fcbTeacher.SelectedValue = null;
            this.fcbTeacher.ShowClearButton = true;
            this.fcbTeacher.ShowPopupShadow = true;
            this.fcbTeacher.Size = new System.Drawing.Size(262, 23);
            this.fcbTeacher.SupportPinyinSearch = false;
            this.fcbTeacher.SupportWubiSearch = false;
            this.fcbTeacher.TabIndex = 111;
            this.fcbTeacher.ValueMember = null;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvDept);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 130);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx1.Size = new System.Drawing.Size(407, 225);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 115;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgvDept
            // 
            this.dgvDept.AllowUserToAddRows = false;
            this.dgvDept.AllowUserToDeleteRows = false;
            this.dgvDept.AllowUserToResizeColumns = false;
            this.dgvDept.AllowUserToResizeRows = false;
            this.dgvDept.BackgroundColor = System.Drawing.Color.White;
            this.dgvDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDept.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDept.ColumnHeadersHeight = 25;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeptCode,
            this.colDeptName,
            this.colDefault});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDept.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDept.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDept.Location = new System.Drawing.Point(1, 1);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.RowHeadersVisible = false;
            this.dgvDept.RowTemplate.Height = 23;
            this.dgvDept.Size = new System.Drawing.Size(405, 223);
            this.dgvDept.TabIndex = 115;
            this.dgvDept.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDept_CellMouseClick);
            // 
            // colDeptCode
            // 
            this.colDeptCode.HeaderText = "科室编号";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.ReadOnly = true;
            // 
            // colDeptName
            // 
            this.colDeptName.HeaderText = "科室名称";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.ReadOnly = true;
            this.colDeptName.Width = 200;
            // 
            // colDefault
            // 
            this.colDefault.HeaderText = "默认";
            this.colDefault.Name = "colDefault";
            this.colDefault.ReadOnly = true;
            this.colDefault.Width = 50;
            // 
            // tbxDept
            // 
            this.tbxDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxDept.Border.Class = "TextBoxBorder";
            this.tbxDept.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxDept.DelayTime = 200;
            this.tbxDept.Location = new System.Drawing.Point(124, 70);
            this.tbxDept.MarkString = null;
            this.tbxDept.Name = "tbxDept";
            this.tbxDept.PreventEnterBeep = true;
            this.tbxDept.Size = new System.Drawing.Size(262, 23);
            this.tbxDept.TabIndex = 119;
            this.tbxDept.Click += new System.EventHandler(this.TbxDept_GotFocus);
            this.tbxDept.TextChanged += new System.EventHandler(this.tbxDept_TextChanged);
            // 
            // treeDept
            // 
            this.treeDept.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeDept.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeDept.BackgroundStyle.Class = "TreeBorderKey";
            this.treeDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeDept.DragDropEnabled = false;
            this.treeDept.DragDropNodeCopyEnabled = false;
            this.treeDept.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.treeDept.GridColumnLines = false;
            this.treeDept.Location = new System.Drawing.Point(392, 41);
            this.treeDept.Name = "treeDept";
            this.treeDept.NodesConnector = this.nodeConnector1;
            this.treeDept.NodeStyle = this.elementStyle1;
            this.treeDept.PathSeparator = ";";
            this.treeDept.Size = new System.Drawing.Size(262, 409);
            this.treeDept.Styles.Add(this.elementStyle1);
            this.treeDept.TabIndex = 120;
            this.treeDept.Text = "advTree1";
            this.treeDept.BeforeCheck += new DevComponents.AdvTree.AdvTreeCellBeforeCheckEventHandler(this.treeDept_BeforeCheck);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // UCUserRoleInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.treeDept);
            this.Controls.Add(this.tbxDept);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.fcbTeacher);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.dtAllowStartTime);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.dtAllowEndTime);
            this.Controls.Add(this.labelX5);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCUserRoleInfo";
            this.Padding = new System.Windows.Forms.Padding(0, 130, 0, 0);
            this.Size = new System.Drawing.Size(407, 355);
            ((System.ComponentModel.ISupportInitialize)(this.dtAllowStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllowEndTime)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtAllowStartTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtAllowEndTime;
        private DevComponents.DotNetBar.LabelX labelX1;
        private HIS.ControlLib.Popups.FindComboBox fcbTeacher;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDefault;
        private HIS.ControlLib.DelayTextBox tbxDept;
        private DevComponents.AdvTree.AdvTree treeDept;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}
