
namespace App_OP.Prescription
{
    partial class UCItemPrescription
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
                base.Dispose(disposing);
            }
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCItemPrescription));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnHistoryPrescription = new DevComponents.DotNetBar.ButtonItem();
            this.btnSelectAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnUp = new DevComponents.DotNetBar.ButtonItem();
            this.btnDown = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.dgvDrug = new App_OP.Prescription.PrescriptionDataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new HIS.ControlLib.DataGridViewIntegerInputExtColumn();
            this.colPackageUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new HIS.ControlLib.DataGridViewFloatInputExtColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.dgvDrugFilter = new HIS.ControlLib.DataGridViewInput();
            this.colNameFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecificationFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhiteFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.menuBar = new DevComponents.DotNetBar.ButtonItem();
            this.menuNew = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.ColorScheme.BarDockedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar1.ColorScheme.BarFloatingBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.btnNew,
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnHistoryPrescription,
            this.btnSelectAll,
            this.btnUp,
            this.btnDown});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1074, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            // 
            // btnNew
            // 
            this.btnNew.AutoExpandOnClick = true;
            this.btnNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "新建处方";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加一行";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除治疗";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存治疗";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHistoryPrescription
            // 
            this.btnHistoryPrescription.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHistoryPrescription.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryPrescription.Image")));
            this.btnHistoryPrescription.Name = "btnHistoryPrescription";
            this.btnHistoryPrescription.Text = "历史处方";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.BeginGroup = true;
            this.btnUp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Name = "btnUp";
            this.btnUp.Text = "向上";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Name = "btnDown";
            this.btnDown.Text = "向下";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // dgvDrug
            // 
            this.dgvDrug.AllowUserToAddRows = false;
            this.dgvDrug.AllowUserToDeleteRows = false;
            this.dgvDrug.AllowUserToResizeColumns = false;
            this.dgvDrug.AllowUserToResizeRows = false;
            this.dgvDrug.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrug.ClickBlankClearSelect = false;
            this.dgvDrug.ColumnHeadersHeight = 30;
            this.dgvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSpecification,
            this.colQuantity,
            this.colPackageUnit,
            this.colPrice,
            this.colTotal,
            this.colWhite});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrug.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrug.Delay = 200;
            this.dgvDrug.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDrug.DeleteLineRowIndexCollection")));
            this.dgvDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrug.EnableSpecialKeyIntercept = true;
            this.dgvDrug.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDrug.GroupDisplayColumn = null;
            this.dgvDrug.GroupValueColumn = null;
            this.dgvDrug.Location = new System.Drawing.Point(0, 29);
            this.dgvDrug.Name = "dgvDrug";
            this.dgvDrug.NameColumn = null;
            this.dgvDrug.RowTemplate.Height = 23;
            this.dgvDrug.SelectColumn = null;
            this.dgvDrug.Size = new System.Drawing.Size(1074, 542);
            this.dgvDrug.TabIndex = 8;
            this.dgvDrug.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDrug_SpecialKeyDown);
            this.dgvDrug.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrug_CellEndEdit);
            this.dgvDrug.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDrug_CellMouseClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "项目名称";
            this.colName.Name = "colName";
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 200;
            // 
            // colSpecification
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            this.colSpecification.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSpecification.HeaderText = "规格";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSpecification.Width = 110;
            // 
            // colQuantity
            // 
            this.colQuantity.BindFieldName = null;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.MaxValue = 2147483647;
            this.colQuantity.MinValue = -2147483648;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuantity.Tags = null;
            this.colQuantity.Width = 60;
            // 
            // colPackageUnit
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            this.colPackageUnit.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPackageUnit.HeaderText = "单位";
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.ReadOnly = true;
            this.colPackageUnit.Width = 60;
            // 
            // colPrice
            // 
            this.colPrice.BindFieldName = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.Digits = 0;
            this.colPrice.HeaderText = "单价";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.Round = false;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrice.Tags = null;
            // 
            // colTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "总价";
            this.colTotal.Name = "colTotal";
            this.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite.HeaderText = "";
            this.colWhite.Name = "colWhite";
            this.colWhite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = " 吃几副";
            // 
            // dgvDrugFilter
            // 
            this.dgvDrugFilter.AllowUserToAddRows = false;
            this.dgvDrugFilter.AllowUserToDeleteRows = false;
            this.dgvDrugFilter.AllowUserToResizeColumns = false;
            this.dgvDrugFilter.AllowUserToResizeRows = false;
            this.dgvDrugFilter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugFilter.ClickBlankClearSelect = false;
            this.dgvDrugFilter.ColumnHeadersHeight = 30;
            this.dgvDrugFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameFilter,
            this.colSpecificationFilter,
            this.colPriceFilter,
            this.colWhiteFilter});
            this.dgvDrugFilter.Container.BindColumn = null;
            this.dgvDrugFilter.Container.Host = null;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugFilter.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDrugFilter.Delay = 200;
            this.dgvDrugFilter.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDrugFilter.DeleteLineRowIndexCollection")));
            this.dgvDrugFilter.EnableSpecialKeyIntercept = false;
            this.dgvDrugFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDrugFilter.Location = new System.Drawing.Point(167, 124);
            this.dgvDrugFilter.Name = "dgvDrugFilter";
            this.dgvDrugFilter.RowHeadersVisible = false;
            this.dgvDrugFilter.RowTemplate.Height = 23;
            this.dgvDrugFilter.SelectColumn = null;
            this.dgvDrugFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugFilter.Size = new System.Drawing.Size(740, 325);
            this.dgvDrugFilter.TabIndex = 9;
            this.dgvDrugFilter.Visible = false;
            // 
            // colNameFilter
            // 
            this.colNameFilter.HeaderText = "项目名称";
            this.colNameFilter.Name = "colNameFilter";
            this.colNameFilter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNameFilter.Width = 200;
            // 
            // colSpecificationFilter
            // 
            this.colSpecificationFilter.HeaderText = "规格";
            this.colSpecificationFilter.Name = "colSpecificationFilter";
            this.colSpecificationFilter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSpecificationFilter.Width = 110;
            // 
            // colPriceFilter
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.0000元";
            this.colPriceFilter.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPriceFilter.HeaderText = "单价";
            this.colPriceFilter.Name = "colPriceFilter";
            this.colPriceFilter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWhiteFilter
            // 
            this.colWhiteFilter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhiteFilter.HeaderText = "";
            this.colWhiteFilter.Name = "colWhiteFilter";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuBar});
            this.contextMenuBar1.Location = new System.Drawing.Point(531, 238);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(111, 26);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 11;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // menuBar
            // 
            this.menuBar.AutoExpandOnClick = true;
            this.menuBar.Name = "menuBar";
            this.menuBar.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuNew,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5,
            this.buttonItem6,
            this.buttonItem7,
            this.buttonItem8,
            this.buttonItem9});
            this.menuBar.Text = "buttonItem1";
            // 
            // menuNew
            // 
            this.menuNew.AutoExpandOnClick = true;
            this.menuNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.Name = "menuNew";
            this.menuNew.Text = "新建处方";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "添加一行";
            this.buttonItem3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "删除治疗";
            this.buttonItem4.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // buttonItem5
            // 
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "保存治疗";
            this.buttonItem5.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "历史处方";
            // 
            // buttonItem7
            // 
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem7.Image")));
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "全选";
            this.buttonItem7.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // buttonItem8
            // 
            this.buttonItem8.BeginGroup = true;
            this.buttonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "向上";
            this.buttonItem8.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // buttonItem9
            // 
            this.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem9.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem9.Image")));
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "向下";
            this.buttonItem9.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // UCItemPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.dgvDrugFilter);
            this.Controls.Add(this.dgvDrug);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCItemPrescription";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Size = new System.Drawing.Size(1074, 573);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnNew;
        public DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnHistoryPrescription;
        private DevComponents.DotNetBar.ButtonItem btnSelectAll;
        private DevComponents.DotNetBar.ButtonItem btnUp;
        private DevComponents.DotNetBar.ButtonItem btnDown;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private PrescriptionDataGridView dgvDrug;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private HIS.ControlLib.DataGridViewInput dgvDrugFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecificationFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhiteFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification;
        private HIS.ControlLib.DataGridViewIntegerInputExtColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackageUnit;
        private HIS.ControlLib.DataGridViewFloatInputExtColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem menuBar;
        public DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem menuNew;
    }
}
