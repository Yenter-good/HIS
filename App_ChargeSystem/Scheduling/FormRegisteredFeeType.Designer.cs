
namespace App_ChargeSystem.Scheduling
{
    partial class FormRegisteredFeeType
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
            this.dgvMain = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPrice = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPriceItemCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPrice = new DevComponents.Editors.DoubleInput();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fcbxFeeItem = new HIS.ControlLib.Popups.FindComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.BackColor = System.Drawing.Color.White;
            this.dgvMain.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvMain.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvMain.ForeColor = System.Drawing.Color.Black;
            this.dgvMain.Location = new System.Drawing.Point(314, 0);
            this.dgvMain.Name = "dgvMain";
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvMain.PrimaryGrid.AllowRowResize = true;
            this.dgvMain.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvMain.PrimaryGrid.Columns.Add(this.colCode);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colName);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colPrice);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colPriceItemCode);
            this.dgvMain.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvMain.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMain.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvMain.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvMain.PrimaryGrid.EnableFiltering = true;
            this.dgvMain.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvMain.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvMain.PrimaryGrid.Filter.Visible = true;
            this.dgvMain.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvMain.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvMain.PrimaryGrid.MultiSelect = false;
            this.dgvMain.PrimaryGrid.NullString = "<<null>>";
            this.dgvMain.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvMain.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvMain.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvMain.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvMain.Size = new System.Drawing.Size(938, 699);
            this.dgvMain.TabIndex = 51;
            this.dgvMain.Text = "供应商维护";
            this.dgvMain.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvMain_CellClick);
            // 
            // colCode
            // 
            this.colCode.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "号费编号";
            this.colCode.MinimumWidth = 120;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "号费名称";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 220;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "价格";
            this.colPrice.MinimumWidth = 60;
            this.colPrice.Name = "colPrice";
            // 
            // colPriceItemCode
            // 
            this.colPriceItemCode.DataPropertyName = "PriceItemCode";
            this.colPriceItemCode.HeaderText = "物价表编号";
            this.colPriceItemCode.MinimumWidth = 220;
            this.colPriceItemCode.Name = "colPriceItemCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.tbxCode);
            this.groupBox1.Controls.Add(this.fcbxFeeItem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 699);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "号费信息";
            // 
            // tbxPrice
            // 
            // 
            // 
            // 
            this.tbxPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tbxPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Increment = 1D;
            this.tbxPrice.Location = new System.Drawing.Point(111, 181);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.ShowUpDown = true;
            this.tbxPrice.Size = new System.Drawing.Size(180, 23);
            this.tbxPrice.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(171, 241);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(66, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(171, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(66, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(111, 95);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(180, 23);
            this.tbxName.TabIndex = 8;
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(111, 54);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.ReadOnly = true;
            this.tbxCode.Size = new System.Drawing.Size(180, 23);
            this.tbxCode.TabIndex = 7;
            // 
            // fcbxFeeItem
            // 
            this.fcbxFeeItem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fcbxFeeItem.Border.Class = "TextBoxBorder";
            this.fcbxFeeItem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fcbxFeeItem.CanResizePopup = false;
            this.fcbxFeeItem.ColumnHeaders = null;
            this.fcbxFeeItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fcbxFeeItem.DataSource = null;
            this.fcbxFeeItem.DisplayMember = "";
            this.fcbxFeeItem.FilterFields = null;
            this.fcbxFeeItem.FocusOpen = false;
            this.fcbxFeeItem.Location = new System.Drawing.Point(111, 137);
            this.fcbxFeeItem.Name = "fcbxFeeItem";
            this.fcbxFeeItem.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fcbxFeeItem.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fcbxFeeItem.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fcbxFeeItem.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fcbxFeeItem.PopupOffSet = 2;
            this.fcbxFeeItem.PreventEnterBeep = true;
            this.fcbxFeeItem.ReadOnly = true;
            this.fcbxFeeItem.SelectedItem = null;
            this.fcbxFeeItem.SelectedValue = null;
            this.fcbxFeeItem.ShowClearButton = true;
            this.fcbxFeeItem.ShowPopupShadow = true;
            this.fcbxFeeItem.Size = new System.Drawing.Size(180, 23);
            this.fcbxFeeItem.SupportPinyinSearch = false;
            this.fcbxFeeItem.SupportWubiSearch = false;
            this.fcbxFeeItem.TabIndex = 6;
            this.fcbxFeeItem.ValueMember = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "物价项目：";
            // 
            // FormRegisteredFeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 699);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegisteredFeeType";
            this.Text = "挂号费用管理";
            this.Load += new System.EventHandler(this.FormRegisteredFeeType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvMain;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPrice;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPriceItemCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DoubleInput tbxPrice;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private HIS.ControlLib.Popups.FindComboBox fcbxFeeItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}