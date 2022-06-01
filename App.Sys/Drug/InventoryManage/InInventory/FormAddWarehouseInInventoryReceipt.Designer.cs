
namespace App_Sys.Drug.InventoryManage
{
    partial class FormAddWarehouseInInventoryReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddWarehouseInInventoryReceipt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tbxBatchNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.tbxInvoiceNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbxTotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxReceiptCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.fcbSupplier = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvDrugs = new HIS.ControlLib.DataGridViewExt();
            this.colTradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new HIS.ControlLib.DataGridViewIntegerInputExtColumn();
            this.colPurchasePrice = new HIS.ControlLib.DataGridViewFloatInputExtColumn();
            this.colPrice = new HIS.ControlLib.DataGridViewFloatInputExtColumn();
            this.colProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDrugFilter = new HIS.ControlLib.DataGridViewInput();
            this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTradeName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity1 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.colProduction1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprovalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // colName
            // 
            this.colName.HeaderText = "药品名称";
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.tbxBatchNumber);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.btnSubmit);
            this.panelEx1.Controls.Add(this.btnDelete);
            this.panelEx1.Controls.Add(this.btnNew);
            this.panelEx1.Controls.Add(this.tbxInvoiceNo);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.tbxTotal);
            this.panelEx1.Controls.Add(this.tbxReceiptCode);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.fcbSupplier);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1341, 100);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1004;
            // 
            // tbxBatchNumber
            // 
            // 
            // 
            // 
            this.tbxBatchNumber.Border.Class = "TextBoxBorder";
            this.tbxBatchNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBatchNumber.Location = new System.Drawing.Point(590, 53);
            this.tbxBatchNumber.Name = "tbxBatchNumber";
            this.tbxBatchNumber.PreventEnterBeep = true;
            this.tbxBatchNumber.Size = new System.Drawing.Size(154, 23);
            this.tbxBatchNumber.TabIndex = 7;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(541, 56);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(43, 20);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "批号:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.Checked = true;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(912, 53);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(831, 53);
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
            this.btnNew.Location = new System.Drawing.Point(750, 53);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbxInvoiceNo
            // 
            // 
            // 
            // 
            this.tbxInvoiceNo.Border.Class = "TextBoxBorder";
            this.tbxInvoiceNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxInvoiceNo.Location = new System.Drawing.Point(381, 53);
            this.tbxInvoiceNo.Name = "tbxInvoiceNo";
            this.tbxInvoiceNo.PreventEnterBeep = true;
            this.tbxInvoiceNo.Size = new System.Drawing.Size(154, 23);
            this.tbxInvoiceNo.TabIndex = 4;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(317, 56);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 20);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "发票号:";
            // 
            // tbxTotal
            // 
            // 
            // 
            // 
            this.tbxTotal.Border.Class = "TextBoxBorder";
            this.tbxTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxTotal.Location = new System.Drawing.Point(381, 24);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.PreventEnterBeep = true;
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(107, 23);
            this.tbxTotal.TabIndex = 2;
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
            this.labelX3.Location = new System.Drawing.Point(332, 27);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 20);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "总价:";
            // 
            // fcbSupplier
            // 
            this.fcbSupplier.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fcbSupplier.Border.Class = "TextBoxBorder";
            this.fcbSupplier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fcbSupplier.CanResizePopup = false;
            this.fcbSupplier.ColumnHeaders = null;
            this.fcbSupplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fcbSupplier.DataSource = null;
            this.fcbSupplier.DisplayMember = "";
            this.fcbSupplier.FilterFields = null;
            this.fcbSupplier.FocusOpen = false;
            this.fcbSupplier.Location = new System.Drawing.Point(119, 53);
            this.fcbSupplier.Name = "fcbSupplier";
            this.fcbSupplier.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fcbSupplier.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fcbSupplier.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fcbSupplier.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fcbSupplier.PopupOffSet = 2;
            this.fcbSupplier.PreventEnterBeep = true;
            this.fcbSupplier.ReadOnly = true;
            this.fcbSupplier.SelectedItem = null;
            this.fcbSupplier.SelectedValue = null;
            this.fcbSupplier.ShowClearButton = true;
            this.fcbSupplier.ShowPopupShadow = true;
            this.fcbSupplier.Size = new System.Drawing.Size(192, 23);
            this.fcbSupplier.SupportPinyinSearch = false;
            this.fcbSupplier.SupportWubiSearch = false;
            this.fcbSupplier.TabIndex = 1;
            this.fcbSupplier.ValueMember = null;
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
            this.labelX1.Text = "供货单位:";
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
            this.colQuantity,
            this.colPurchasePrice,
            this.colPrice,
            this.colProduction,
            this.colBatchNumber,
            this.colMemo,
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
            this.dgvDrugs.Location = new System.Drawing.Point(0, 100);
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.RowHeadersVisible = false;
            this.dgvDrugs.RowTemplate.Height = 23;
            this.dgvDrugs.SelectColumn = null;
            this.dgvDrugs.Size = new System.Drawing.Size(1341, 666);
            this.dgvDrugs.TabIndex = 1018;
            this.dgvDrugs.TextChange += new System.EventHandler<HIS.ControlLib.TextChangeEventArgs>(this.dgvDrugs_TextChange);
            this.dgvDrugs.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDrugs_SpecialKeyDown);
            this.dgvDrugs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugs_CellEndEdit);
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
            // colQuantity
            // 
            this.colQuantity.BindFieldName = null;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.MaxValue = 2147483647;
            this.colQuantity.MinValue = -2147483648;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuantity.Tags = null;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.BindFieldName = "";
            this.colPurchasePrice.Digits = 0;
            this.colPurchasePrice.HeaderText = "进货价";
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPurchasePrice.Round = false;
            this.colPurchasePrice.Tags = null;
            // 
            // colPrice
            // 
            this.colPrice.BindFieldName = null;
            this.colPrice.Digits = 0;
            this.colPrice.HeaderText = "零售价";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.Round = false;
            this.colPrice.Tags = null;
            // 
            // colProduction
            // 
            this.colProduction.HeaderText = "生产厂家";
            this.colProduction.Name = "colProduction";
            this.colProduction.Width = 200;
            // 
            // colBatchNumber
            // 
            this.colBatchNumber.HeaderText = "批号";
            this.colBatchNumber.Name = "colBatchNumber";
            // 
            // colMemo
            // 
            this.colMemo.HeaderText = "备注";
            this.colMemo.Name = "colMemo";
            this.colMemo.Width = 200;
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
            this.colName1,
            this.colTradeName1,
            this.colSpecification1,
            this.colQuantity1,
            this.colProduction1,
            this.colApprovalNumber,
            this.colWhite1});
            this.dgvDrugFilter.Container.BindColumn = null;
            this.dgvDrugFilter.Container.Host = null;
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
            // colName1
            // 
            this.colName1.DataPropertyName = "DrugName";
            this.colName1.HeaderText = "药品名称";
            this.colName1.Name = "colName1";
            this.colName1.ReadOnly = true;
            this.colName1.Width = 200;
            // 
            // colTradeName1
            // 
            this.colTradeName1.HeaderText = "商品名";
            this.colTradeName1.Name = "colTradeName1";
            this.colTradeName1.ReadOnly = true;
            this.colTradeName1.Width = 200;
            // 
            // colSpecification1
            // 
            this.colSpecification1.DataPropertyName = "Specification";
            this.colSpecification1.HeaderText = "规格";
            this.colSpecification1.Name = "colSpecification1";
            this.colSpecification1.ReadOnly = true;
            // 
            // colQuantity1
            // 
            // 
            // 
            // 
            this.colQuantity1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colQuantity1.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colQuantity1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuantity1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.colQuantity1.DataPropertyName = "Quautity";
            this.colQuantity1.HeaderText = "现参考库存";
            this.colQuantity1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.ReadOnly = true;
            this.colQuantity1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colProduction1
            // 
            this.colProduction1.DataPropertyName = "Manufacturer";
            this.colProduction1.HeaderText = "生产厂家";
            this.colProduction1.Name = "colProduction1";
            this.colProduction1.ReadOnly = true;
            this.colProduction1.Width = 200;
            // 
            // colApprovalNumber
            // 
            this.colApprovalNumber.DataPropertyName = "ApprovalNumber";
            this.colApprovalNumber.HeaderText = "批准文号";
            this.colApprovalNumber.Name = "colApprovalNumber";
            this.colApprovalNumber.ReadOnly = true;
            // 
            // colWhite1
            // 
            this.colWhite1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite1.HeaderText = "";
            this.colWhite1.Name = "colWhite1";
            this.colWhite1.ReadOnly = true;
            // 
            // FormAddWarehouseInInventoryReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 766);
            this.Controls.Add(this.dgvDrugFilter);
            this.Controls.Add(this.dgvDrugs);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormAddWarehouseInInventoryReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加药库入库单";
            this.Shown += new System.EventHandler(this.FormAddWarehouseInInventoryReceipt_Shown);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private HIS.ControlLib.Popups.FindComboBox fcbSupplier;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxReceiptCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxTotal;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxInvoiceNo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private HIS.ControlLib.DataGridViewExt dgvDrugs;
        private HIS.ControlLib.DataGridViewInput dgvDrugFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification;
        private HIS.ControlLib.DataGridViewIntegerInputExtColumn colQuantity;
        private HIS.ControlLib.DataGridViewFloatInputExtColumn colPurchasePrice;
        private HIS.ControlLib.DataGridViewFloatInputExtColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxBatchNumber;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTradeName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification1;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colQuantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduction1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprovalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite1;
    }
}