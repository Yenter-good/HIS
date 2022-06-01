
namespace App_ChargeSystem.InvoiceManager
{
    partial class FormInvoiceManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.tbxEndNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxBeginNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxCurrNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fcbxUser = new HIS.ControlLib.Popups.FindComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dgvMain = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colUserCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colUserName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCurrNo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colBeginNo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEndNo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbxEndNo);
            this.groupBox1.Controls.Add(this.tbxBeginNo);
            this.groupBox1.Controls.Add(this.tbxCurrNo);
            this.groupBox1.Controls.Add(this.fcbxUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 722);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "票据信息";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(175, 298);
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
            this.btnAdd.Location = new System.Drawing.Point(50, 298);
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
            this.btnDelete.Location = new System.Drawing.Point(175, 351);
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
            this.btnSave.Location = new System.Drawing.Point(50, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxEndNo
            // 
            // 
            // 
            // 
            this.tbxEndNo.Border.Class = "TextBoxBorder";
            this.tbxEndNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxEndNo.Location = new System.Drawing.Point(110, 227);
            this.tbxEndNo.Name = "tbxEndNo";
            this.tbxEndNo.PreventEnterBeep = true;
            this.tbxEndNo.ReadOnly = true;
            this.tbxEndNo.Size = new System.Drawing.Size(180, 23);
            this.tbxEndNo.TabIndex = 9;
            // 
            // tbxBeginNo
            // 
            // 
            // 
            // 
            this.tbxBeginNo.Border.Class = "TextBoxBorder";
            this.tbxBeginNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBeginNo.Location = new System.Drawing.Point(111, 187);
            this.tbxBeginNo.Name = "tbxBeginNo";
            this.tbxBeginNo.PreventEnterBeep = true;
            this.tbxBeginNo.ReadOnly = true;
            this.tbxBeginNo.Size = new System.Drawing.Size(180, 23);
            this.tbxBeginNo.TabIndex = 8;
            // 
            // tbxCurrNo
            // 
            // 
            // 
            // 
            this.tbxCurrNo.Border.Class = "TextBoxBorder";
            this.tbxCurrNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCurrNo.Location = new System.Drawing.Point(111, 146);
            this.tbxCurrNo.Name = "tbxCurrNo";
            this.tbxCurrNo.PreventEnterBeep = true;
            this.tbxCurrNo.ReadOnly = true;
            this.tbxCurrNo.Size = new System.Drawing.Size(180, 23);
            this.tbxCurrNo.TabIndex = 7;
            // 
            // fcbxUser
            // 
            this.fcbxUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fcbxUser.Border.Class = "TextBoxBorder";
            this.fcbxUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fcbxUser.CanResizePopup = false;
            this.fcbxUser.ColumnHeaders = null;
            this.fcbxUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fcbxUser.DataSource = null;
            this.fcbxUser.DisplayMember = "";
            this.fcbxUser.FilterFields = null;
            this.fcbxUser.FocusOpen = false;
            this.fcbxUser.Location = new System.Drawing.Point(111, 101);
            this.fcbxUser.Name = "fcbxUser";
            this.fcbxUser.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fcbxUser.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fcbxUser.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fcbxUser.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fcbxUser.PopupOffSet = 2;
            this.fcbxUser.PreventEnterBeep = true;
            this.fcbxUser.ReadOnly = true;
            this.fcbxUser.SelectedItem = null;
            this.fcbxUser.SelectedValue = null;
            this.fcbxUser.ShowClearButton = true;
            this.fcbxUser.ShowPopupShadow = true;
            this.fcbxUser.Size = new System.Drawing.Size(180, 23);
            this.fcbxUser.SupportPinyinSearch = false;
            this.fcbxUser.SupportWubiSearch = false;
            this.fcbxUser.TabIndex = 6;
            this.fcbxUser.ValueMember = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "终止发票号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "起始发票号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "当前发票号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "收费人员：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "发票类型：";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(110, 50);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(181, 22);
            this.cbxType.TabIndex = 0;
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
            this.dgvMain.PrimaryGrid.Columns.Add(this.colType);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colUserCode);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colUserName);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colCurrNo);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colBeginNo);
            this.dgvMain.PrimaryGrid.Columns.Add(this.colEndNo);
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
            this.dgvMain.Size = new System.Drawing.Size(1034, 722);
            this.dgvMain.TabIndex = 49;
            this.dgvMain.Text = "供应商维护";
            this.dgvMain.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.dgvMain_CellClick);
            this.dgvMain.GetCellFormattedValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellFormattedValueEventArgs>(this.dgvMain_GetCellFormattedValue);
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "发票类型";
            this.colType.MinimumWidth = 150;
            this.colType.Name = "colType";
            // 
            // colUserCode
            // 
            this.colUserCode.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.colUserCode.DataPropertyName = "CashierCode";
            this.colUserCode.HeaderText = "工号";
            this.colUserCode.MinimumWidth = 120;
            this.colUserCode.Name = "colUserCode";
            this.colUserCode.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "CashierName";
            this.colUserName.HeaderText = "收费员姓名";
            this.colUserName.MinimumWidth = 150;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 220;
            // 
            // colCurrNo
            // 
            this.colCurrNo.DataPropertyName = "CurrentInvoiceNo";
            this.colCurrNo.FillWeight = 200;
            this.colCurrNo.HeaderText = "当前发票号";
            this.colCurrNo.MinimumWidth = 220;
            this.colCurrNo.Name = "colCurrNo";
            this.colCurrNo.ReadOnly = true;
            this.colCurrNo.Width = 80;
            // 
            // colBeginNo
            // 
            this.colBeginNo.DataPropertyName = "BeginInvoiceNo";
            this.colBeginNo.HeaderText = "起始发票号";
            this.colBeginNo.MinimumWidth = 220;
            this.colBeginNo.Name = "colBeginNo";
            // 
            // colEndNo
            // 
            this.colEndNo.DataPropertyName = "EndInvoiceNo";
            this.colEndNo.HeaderText = "终止发票号";
            this.colEndNo.MinimumWidth = 220;
            this.colEndNo.Name = "colEndNo";
            // 
            // FormInvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 722);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInvoiceManager";
            this.Text = "发票管理";
            this.Load += new System.EventHandler(this.FormInvoiceManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxEndNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxBeginNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCurrNo;
        private HIS.ControlLib.Popups.FindComboBox fcbxUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvMain;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colUserCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colUserName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCurrNo;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colBeginNo;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEndNo;
    }
}