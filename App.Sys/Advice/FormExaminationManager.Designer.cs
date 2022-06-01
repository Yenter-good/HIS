namespace App_Sys.Advice
{
    partial class FormExaminationManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAdvice = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnRestop = new DevComponents.DotNetBar.ButtonItem();
            this.btnStop = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fbxName = new HIS.ControlLib.Popups.FindComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRelation = new System.Windows.Forms.RadioButton();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.btnAdd2 = new DevComponents.DotNetBar.ButtonX();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new DevComponents.Editors.IntegerInput();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSpecification = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDetail2 = new System.Windows.Forms.DataGridView();
            this.colFeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeSpecifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeOperate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemOperate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAdvice);
            this.groupBox1.Controls.Add(this.bar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 614);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查项目";
            // 
            // dgvAdvice
            // 
            this.dgvAdvice.BackColor = System.Drawing.Color.White;
            this.dgvAdvice.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvAdvice.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdvice.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvAdvice.ForeColor = System.Drawing.Color.Black;
            this.dgvAdvice.Location = new System.Drawing.Point(3, 48);
            this.dgvAdvice.Name = "dgvAdvice";
            // 
            // 
            // 
            this.dgvAdvice.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvAdvice.PrimaryGrid.AllowRowResize = true;
            this.dgvAdvice.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvAdvice.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvAdvice.PrimaryGrid.Columns.Add(this.colName);
            this.dgvAdvice.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.dgvAdvice.PrimaryGrid.Columns.Add(this.colPrice);
            this.dgvAdvice.PrimaryGrid.Columns.Add(this.colStatus);
            this.dgvAdvice.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvAdvice.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvAdvice.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAdvice.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvAdvice.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvAdvice.PrimaryGrid.EnableFiltering = true;
            this.dgvAdvice.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvAdvice.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvAdvice.PrimaryGrid.Filter.Visible = true;
            this.dgvAdvice.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvAdvice.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvAdvice.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvAdvice.PrimaryGrid.MultiSelect = false;
            this.dgvAdvice.PrimaryGrid.NullString = "<<null>>";
            this.dgvAdvice.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvAdvice.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvAdvice.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvAdvice.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvAdvice.Size = new System.Drawing.Size(457, 563);
            this.dgvAdvice.TabIndex = 44;
            this.dgvAdvice.Text = "superGridControl2";
            this.dgvAdvice.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvAdvice_CellClick);
            this.dgvAdvice.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvAdvice_CellDoubleClick);
            this.dgvAdvice.GetCellFormattedValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellFormattedValueEventArgs>(this.dgvAdvice_GetCellFormattedValue);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "项目名称";
            this.colName.Name = "";
            this.colName.ReadOnly = true;
            // 
            // colSearchCode
            // 
            this.colSearchCode.DataPropertyName = "SearchCode";
            this.colSearchCode.HeaderText = "拼音码";
            this.colSearchCode.Name = "colSearchCode";
            this.colSearchCode.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "总价";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "";
            this.colStatus.HeaderText = "是否停用";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.Name = "";
            this.colWhite.ReadOnly = true;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Left;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnInsert,
            this.btnEdit,
            this.btnRestop,
            this.btnStop,
            this.labelItem2});
            this.bar1.Location = new System.Drawing.Point(3, 19);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(457, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 45;
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
            // btnRestop
            // 
            this.btnRestop.BeginGroup = true;
            this.btnRestop.Name = "btnRestop";
            this.btnRestop.Text = "启用";
            this.btnRestop.Click += new System.EventHandler(this.btnRestop_Click);
            // 
            // btnStop
            // 
            this.btnStop.Name = "btnStop";
            this.btnStop.Text = "停用";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Width = 50;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fbxName);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.rbRelation);
            this.groupBox5.Controls.Add(this.rbContains);
            this.groupBox5.Controls.Add(this.btnAdd2);
            this.groupBox5.Controls.Add(this.txtPrice);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtUnit);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtQuantity);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtSpecification);
            this.groupBox5.Controls.Add(this.cbxType);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 458);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(762, 153);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "关联收费项目维护";
            // 
            // fbxName
            // 
            this.fbxName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fbxName.Border.Class = "TextBoxBorder";
            this.fbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fbxName.CanResizePopup = false;
            this.fbxName.ColumnHeaders = null;
            this.fbxName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fbxName.DataSource = null;
            this.fbxName.DisplayMember = "";
            this.fbxName.FilterFields = null;
            this.fbxName.FocusOpen = false;
            this.fbxName.Location = new System.Drawing.Point(303, 74);
            this.fbxName.Name = "fbxName";
            this.fbxName.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fbxName.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fbxName.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fbxName.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fbxName.PopupOffSet = 2;
            this.fbxName.PreventEnterBeep = true;
            this.fbxName.ReadOnly = true;
            this.fbxName.SelectedItem = null;
            this.fbxName.SelectedValue = null;
            this.fbxName.ShowClearButton = true;
            this.fbxName.ShowPopupShadow = true;
            this.fbxName.Size = new System.Drawing.Size(195, 23);
            this.fbxName.SupportPinyinSearch = false;
            this.fbxName.SupportWubiSearch = false;
            this.fbxName.TabIndex = 22;
            this.fbxName.ValueMember = null;
            this.fbxName.TextChanged += new System.EventHandler(this.fbxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "添加类型：";
            // 
            // rbRelation
            // 
            this.rbRelation.AutoSize = true;
            this.rbRelation.Location = new System.Drawing.Point(222, 35);
            this.rbRelation.Name = "rbRelation";
            this.rbRelation.Size = new System.Drawing.Size(109, 18);
            this.rbRelation.TabIndex = 20;
            this.rbRelation.Text = "关联收费项目";
            this.rbRelation.UseVisualStyleBackColor = true;
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(83, 35);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(109, 18);
            this.rbContains.TabIndex = 19;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "医嘱包含项目";
            this.rbContains.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            this.btnAdd2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd2.Location = new System.Drawing.Point(684, 73);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 61);
            this.btnAdd2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd2.TabIndex = 14;
            this.btnAdd2.Text = "添加";
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrice.Location = new System.Drawing.Point(559, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(101, 23);
            this.txtPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "单价：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "检索类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "单位：";
            // 
            // txtUnit
            // 
            // 
            // 
            // 
            this.txtUnit.Border.Class = "TextBoxBorder";
            this.txtUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUnit.Location = new System.Drawing.Point(83, 109);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PreventEnterBeep = true;
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(130, 23);
            this.txtUnit.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 7;
            this.label10.Text = "规格：";
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtQuantity.Location = new System.Drawing.Point(559, 71);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ShowUpDown = true;
            this.txtQuantity.Size = new System.Drawing.Size(101, 23);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Value = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "数量：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 3;
            this.label12.Text = "项目名称：";
            // 
            // txtSpecification
            // 
            // 
            // 
            // 
            this.txtSpecification.Border.Class = "TextBoxBorder";
            this.txtSpecification.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSpecification.Location = new System.Drawing.Point(303, 109);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.PreventEnterBeep = true;
            this.txtSpecification.ReadOnly = true;
            this.txtSpecification.Size = new System.Drawing.Size(195, 23);
            this.txtSpecification.TabIndex = 2;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(78, 73);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(135, 22);
            this.cbxType.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(463, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 614);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "包含项目";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDetail2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 144);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "关联收费项目";
            // 
            // dgvDetail2
            // 
            this.dgvDetail2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeeName,
            this.colFeeSpecifications,
            this.colFeePrice,
            this.colFeeQuantity,
            this.colFeeOperate});
            this.dgvDetail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail2.Location = new System.Drawing.Point(3, 19);
            this.dgvDetail2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail2.Name = "dgvDetail2";
            this.dgvDetail2.ReadOnly = true;
            this.dgvDetail2.RowHeadersWidth = 51;
            this.dgvDetail2.RowTemplate.Height = 27;
            this.dgvDetail2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail2.Size = new System.Drawing.Size(756, 122);
            this.dgvDetail2.TabIndex = 6;
            this.dgvDetail2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail2_CellClick);
            // 
            // colFeeName
            // 
            this.colFeeName.DataPropertyName = "FeeItemName";
            this.colFeeName.HeaderText = "收费项目名称";
            this.colFeeName.MinimumWidth = 6;
            this.colFeeName.Name = "colFeeName";
            this.colFeeName.ReadOnly = true;
            this.colFeeName.Width = 125;
            // 
            // colFeeSpecifications
            // 
            this.colFeeSpecifications.DataPropertyName = "FeeItemSpecifications";
            this.colFeeSpecifications.HeaderText = "规格";
            this.colFeeSpecifications.MinimumWidth = 6;
            this.colFeeSpecifications.Name = "colFeeSpecifications";
            this.colFeeSpecifications.ReadOnly = true;
            this.colFeeSpecifications.Width = 125;
            // 
            // colFeePrice
            // 
            this.colFeePrice.DataPropertyName = "FeeItemPrice";
            this.colFeePrice.HeaderText = "单价";
            this.colFeePrice.MinimumWidth = 6;
            this.colFeePrice.Name = "colFeePrice";
            this.colFeePrice.ReadOnly = true;
            this.colFeePrice.Width = 125;
            // 
            // colFeeQuantity
            // 
            this.colFeeQuantity.DataPropertyName = "Quantity";
            this.colFeeQuantity.HeaderText = "数量";
            this.colFeeQuantity.MinimumWidth = 6;
            this.colFeeQuantity.Name = "colFeeQuantity";
            this.colFeeQuantity.ReadOnly = true;
            this.colFeeQuantity.Width = 125;
            // 
            // colFeeOperate
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.colFeeOperate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFeeOperate.HeaderText = "操作";
            this.colFeeOperate.MinimumWidth = 6;
            this.colFeeOperate.Name = "colFeeOperate";
            this.colFeeOperate.ReadOnly = true;
            this.colFeeOperate.Text = "删除";
            this.colFeeOperate.Width = 125;
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colItemSpecification,
            this.colItemPrice,
            this.colItemQuantity,
            this.colItemOperate});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 19);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 27;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(762, 439);
            this.dgvDetail.TabIndex = 13;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "FeeItemName";
            this.colItemName.HeaderText = "物价名称";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 125;
            // 
            // colItemSpecification
            // 
            this.colItemSpecification.DataPropertyName = "FeeItemSpecification";
            this.colItemSpecification.HeaderText = "规格";
            this.colItemSpecification.MinimumWidth = 6;
            this.colItemSpecification.Name = "colItemSpecification";
            this.colItemSpecification.ReadOnly = true;
            this.colItemSpecification.Width = 125;
            // 
            // colItemPrice
            // 
            this.colItemPrice.DataPropertyName = "FeeItemPrice";
            this.colItemPrice.HeaderText = "单价";
            this.colItemPrice.MinimumWidth = 6;
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.ReadOnly = true;
            this.colItemPrice.Width = 125;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.DataPropertyName = "Quantity";
            this.colItemQuantity.HeaderText = "数量";
            this.colItemQuantity.MinimumWidth = 6;
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.ReadOnly = true;
            this.colItemQuantity.Width = 125;
            // 
            // colItemOperate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.colItemOperate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colItemOperate.HeaderText = "操作";
            this.colItemOperate.MinimumWidth = 6;
            this.colItemOperate.Name = "colItemOperate";
            this.colItemOperate.ReadOnly = true;
            this.colItemOperate.Text = "删除";
            this.colItemOperate.Width = 125;
            // 
            // FormExaminationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExaminationManager";
            this.Text = "检查医嘱";
            this.Load += new System.EventHandler(this.FormExaminationManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvAdvice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnRestop;
        private DevComponents.DotNetBar.ButtonItem btnStop;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnit;
        private System.Windows.Forms.Label label10;
        private DevComponents.Editors.IntegerInput txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSpecification;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDetail2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private DevComponents.DotNetBar.ButtonX btnAdd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRelation;
        private System.Windows.Forms.RadioButton rbContains;
        private HIS.ControlLib.Popups.FindComboBox fbxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn colItemOperate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeSpecifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn colFeeOperate;
    }
}