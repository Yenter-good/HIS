
namespace App_OP.MedicalTechnology
{
    partial class UCMedicalTechnologyApply
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMedicalTechnologyApply));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.treeCategory = new DevComponents.AdvTree.AdvTree();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.dgvSelected = new HIS.ControlLib.DataGridViewExt();
            this.colItemNameSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantitySelected = new HIS.ControlLib.DataGridViewIntegerInputExtColumn();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnDel = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClear = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.pnlApply = new DevComponents.DotNetBar.PanelEx();
            this.dgvDetail = new HIS.ControlLib.DataGridViewExt();
            this.colDetailName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApply = new HIS.ControlLib.DataGridViewExt();
            this.colItemNameApply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceApply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tbxSearch = new HIS.ControlLib.DelayTextBox();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnNote = new DevComponents.DotNetBar.ButtonItem();
            this.tbxNote = new DevComponents.DotNetBar.TextBoxItem();
            this.btnConditionSummary = new DevComponents.DotNetBar.ButtonItem();
            this.tbxConditionSummary = new DevComponents.DotNetBar.TextBoxItem();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).BeginInit();
            this.pnlSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.pnlApply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.treeCategory);
            this.pnlCategory.Controls.Add(this.panelEx1);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(230, 602);
            this.pnlCategory.TabIndex = 1;
            // 
            // treeCategory
            // 
            this.treeCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeCategory.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeCategory.BackgroundStyle.Class = "TreeBorderKey";
            this.treeCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCategory.DragDropEnabled = false;
            this.treeCategory.DragDropNodeCopyEnabled = false;
            this.treeCategory.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.treeCategory.Location = new System.Drawing.Point(0, 29);
            this.treeCategory.Name = "treeCategory";
            this.treeCategory.NodeStyle = this.elementStyle1;
            this.treeCategory.PathSeparator = ";";
            this.treeCategory.Size = new System.Drawing.Size(230, 573);
            this.treeCategory.Styles.Add(this.elementStyle1);
            this.treeCategory.TabIndex = 4;
            this.treeCategory.Text = "advTree1";
            this.treeCategory.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeCategory_NodeClick);
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(230, 29);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "检验分类";
            // 
            // pnlSelected
            // 
            this.pnlSelected.Controls.Add(this.dgvSelected);
            this.pnlSelected.Controls.Add(this.bar2);
            this.pnlSelected.Controls.Add(this.panelEx2);
            this.pnlSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSelected.Location = new System.Drawing.Point(675, 0);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(420, 602);
            this.pnlSelected.TabIndex = 2;
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.AllowUserToResizeColumns = false;
            this.dgvSelected.AllowUserToResizeRows = false;
            this.dgvSelected.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelected.ClickBlankClearSelect = false;
            this.dgvSelected.ColumnHeadersHeight = 26;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNameSelected,
            this.colQuantitySelected});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelected.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelected.Delay = 200;
            this.dgvSelected.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvSelected.DeleteLineRowIndexCollection")));
            this.dgvSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSelected.EnableSpecialKeyIntercept = true;
            this.dgvSelected.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSelected.Location = new System.Drawing.Point(0, 60);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersVisible = false;
            this.dgvSelected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelected.RowTemplate.Height = 23;
            this.dgvSelected.SelectColumn = null;
            this.dgvSelected.Size = new System.Drawing.Size(420, 542);
            this.dgvSelected.TabIndex = 34;
            // 
            // colItemNameSelected
            // 
            this.colItemNameSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemNameSelected.HeaderText = "项目名称";
            this.colItemNameSelected.Name = "colItemNameSelected";
            this.colItemNameSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantitySelected
            // 
            this.colQuantitySelected.BindFieldName = null;
            this.colQuantitySelected.HeaderText = "数量";
            this.colQuantitySelected.MaxValue = 2147483647;
            this.colQuantitySelected.MinValue = -2147483648;
            this.colQuantitySelected.Name = "colQuantitySelected";
            this.colQuantitySelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantitySelected.Tags = null;
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Right;
            this.bar2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDel,
            this.btnSave,
            this.btnClear});
            this.bar2.Location = new System.Drawing.Point(0, 30);
            this.bar2.Name = "bar2";
            this.bar2.RoundCorners = false;
            this.bar2.Size = new System.Drawing.Size(420, 30);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 7;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnDel
            // 
            this.btnDel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "清空";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(420, 30);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            this.panelEx2.Text = "已选内容";
            // 
            // pnlApply
            // 
            this.pnlApply.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlApply.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlApply.Controls.Add(this.dgvDetail);
            this.pnlApply.Controls.Add(this.dgvApply);
            this.pnlApply.Controls.Add(this.tbxSearch);
            this.pnlApply.Controls.Add(this.bar1);
            this.pnlApply.Controls.Add(this.panelEx3);
            this.pnlApply.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApply.Location = new System.Drawing.Point(230, 0);
            this.pnlApply.Name = "pnlApply";
            this.pnlApply.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlApply.Size = new System.Drawing.Size(439, 602);
            this.pnlApply.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlApply.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlApply.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlApply.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlApply.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlApply.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlApply.Style.GradientAngle = 90;
            this.pnlApply.TabIndex = 21;
            this.pnlApply.Text = "panelEx4";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeColumns = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.ClickBlankClearSelect = false;
            this.dgvDetail.ColumnHeadersHeight = 30;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailName,
            this.colDetailPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.Delay = 200;
            this.dgvDetail.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDetail.DeleteLineRowIndexCollection")));
            this.dgvDetail.EnableSpecialKeyIntercept = true;
            this.dgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDetail.Location = new System.Drawing.Point(6, 231);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectColumn = null;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(395, 201);
            this.dgvDetail.TabIndex = 23;
            // 
            // colDetailName
            // 
            this.colDetailName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetailName.HeaderText = "明细名称";
            this.colDetailName.Name = "colDetailName";
            this.colDetailName.ReadOnly = true;
            // 
            // colDetailPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "0.0000元";
            this.colDetailPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDetailPrice.HeaderText = "价格";
            this.colDetailPrice.Name = "colDetailPrice";
            this.colDetailPrice.ReadOnly = true;
            // 
            // dgvApply
            // 
            this.dgvApply.AllowUserToAddRows = false;
            this.dgvApply.AllowUserToDeleteRows = false;
            this.dgvApply.AllowUserToResizeColumns = false;
            this.dgvApply.AllowUserToResizeRows = false;
            this.dgvApply.BackgroundColor = System.Drawing.Color.White;
            this.dgvApply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApply.ClickBlankClearSelect = false;
            this.dgvApply.ColumnHeadersHeight = 30;
            this.dgvApply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNameApply,
            this.colPriceApply,
            this.colDetail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApply.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvApply.Delay = 200;
            this.dgvApply.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvApply.DeleteLineRowIndexCollection")));
            this.dgvApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApply.EnableSpecialKeyIntercept = true;
            this.dgvApply.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvApply.Location = new System.Drawing.Point(0, 86);
            this.dgvApply.Name = "dgvApply";
            this.dgvApply.ReadOnly = true;
            this.dgvApply.RowTemplate.Height = 23;
            this.dgvApply.SelectColumn = null;
            this.dgvApply.Size = new System.Drawing.Size(438, 516);
            this.dgvApply.TabIndex = 19;
            this.dgvApply.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApply_CellContentClick);
            this.dgvApply.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApply_CellDoubleClick);
            // 
            // colItemNameApply
            // 
            this.colItemNameApply.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemNameApply.HeaderText = "项目名称";
            this.colItemNameApply.Name = "colItemNameApply";
            this.colItemNameApply.ReadOnly = true;
            this.colItemNameApply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPriceApply
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.0000元";
            this.colPriceApply.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPriceApply.HeaderText = "价格";
            this.colPriceApply.Name = "colPriceApply";
            this.colPriceApply.ReadOnly = true;
            this.colPriceApply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDetail
            // 
            this.colDetail.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDetail.HeaderText = "";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDetail.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tbxSearch.Border.BorderBottomWidth = 1;
            this.tbxSearch.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tbxSearch.Border.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.tbxSearch.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.tbxSearch.Border.BorderTopWidth = 1;
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.DelayTime = 200;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSearch.Location = new System.Drawing.Point(0, 60);
            this.tbxSearch.MarkString = null;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(438, 26);
            this.tbxSearch.TabIndex = 18;
            this.tbxSearch.WatermarkText = "输入拼音码检索项目";
            this.tbxSearch.WordWrap = false;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnNote,
            this.btnConditionSummary});
            this.bar1.Location = new System.Drawing.Point(0, 30);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(438, 30);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 13;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNote
            // 
            this.btnNote.AutoExpandOnClick = true;
            this.btnNote.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNote.Image")));
            this.btnNote.Name = "btnNote";
            this.btnNote.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnNote.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tbxNote});
            this.btnNote.Text = "医生说明";
            // 
            // tbxNote
            // 
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.TextBoxHeight = 200;
            this.tbxNote.TextBoxWidth = 400;
            this.tbxNote.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnConditionSummary
            // 
            this.btnConditionSummary.AutoExpandOnClick = true;
            this.btnConditionSummary.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnConditionSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnConditionSummary.Image")));
            this.btnConditionSummary.Name = "btnConditionSummary";
            this.btnConditionSummary.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnConditionSummary.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tbxConditionSummary});
            this.btnConditionSummary.Text = "病史摘要";
            this.btnConditionSummary.ExpandChange += new System.EventHandler(this.btnConditionSummary_ExpandChange);
            // 
            // tbxConditionSummary
            // 
            this.tbxConditionSummary.Name = "tbxConditionSummary";
            this.tbxConditionSummary.TextBoxHeight = 200;
            this.tbxConditionSummary.TextBoxWidth = 400;
            this.tbxConditionSummary.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(438, 30);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 17;
            this.panelEx3.Text = "检验项目列表";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(105, 204);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(260, 126);
            this.textBoxX1.TabIndex = 23;
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter1.Expandable = false;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(669, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 602);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 25;
            this.expandableSplitter1.TabStop = false;
            // 
            // UCMedicalTechnologyApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlApply);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.pnlSelected);
            this.Controls.Add(this.pnlCategory);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMedicalTechnologyApply";
            this.Size = new System.Drawing.Size(1095, 602);
            this.pnlCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeCategory)).EndInit();
            this.pnlSelected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.pnlApply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategory;
        private DevComponents.AdvTree.AdvTree treeCategory;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel pnlSelected;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnDel;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClear;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private HIS.ControlLib.DataGridViewExt dgvSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNameSelected;
        private HIS.ControlLib.DataGridViewIntegerInputExtColumn colQuantitySelected;
        private DevComponents.DotNetBar.PanelEx pnlApply;
        private HIS.ControlLib.DataGridViewExt dgvApply;
        private HIS.ControlLib.DelayTextBox tbxSearch;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnNote;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.TextBoxItem tbxNote;
        private HIS.ControlLib.DataGridViewExt dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailPrice;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNameApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceApply;
        private System.Windows.Forms.DataGridViewLinkColumn colDetail;
        private DevComponents.DotNetBar.ButtonItem btnConditionSummary;
        private DevComponents.DotNetBar.TextBoxItem tbxConditionSummary;
    }
}
