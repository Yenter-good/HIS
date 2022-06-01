namespace App_Sys.Drug
{
    partial class FormTakeStockDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTakeStockDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxEnd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBegin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetail = new HIS.ControlLib.DataGridViewExt();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.colClassCode_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackageUnit_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrugformValue_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentBigQuantity_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentSmallQuantity_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity_ppd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturer_wpd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxBegin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 100);
            this.groupBox1.TabIndex = 1004;
            this.groupBox1.TabStop = false;
            // 
            // tbxEnd
            // 
            // 
            // 
            // 
            this.tbxEnd.Border.Class = "TextBoxBorder";
            this.tbxEnd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxEnd.Location = new System.Drawing.Point(533, 38);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.PreventEnterBeep = true;
            this.tbxEnd.ReadOnly = true;
            this.tbxEnd.Size = new System.Drawing.Size(216, 23);
            this.tbxEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "盘点金额（元）：";
            // 
            // tbxBegin
            // 
            // 
            // 
            // 
            this.tbxBegin.Border.Class = "TextBoxBorder";
            this.tbxBegin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxBegin.Location = new System.Drawing.Point(151, 38);
            this.tbxBegin.Name = "tbxBegin";
            this.tbxBegin.PreventEnterBeep = true;
            this.tbxBegin.ReadOnly = true;
            this.tbxBegin.Size = new System.Drawing.Size(216, 23);
            this.tbxBegin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "期初金额（元）：";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ClickBlankClearSelect = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassCode_wpd,
            this.colName_wpd,
            this.colSpecification_wpd,
            this.colPackageUnit_wpd,
            this.colDrugformValue_wpd,
            this.colCurrentBigQuantity_wpd,
            this.colQuantity_wpd,
            this.colCurrentSmallQuantity_wpd,
            this.colQuantity_ppd,
            this.colManufacturer_wpd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.Delay = 200;
            this.dgvDetail.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDetail.DeleteLineRowIndexCollection")));
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetail.EnableSpecialKeyIntercept = true;
            this.dgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDetail.Location = new System.Drawing.Point(0, 127);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 60;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectColumn = null;
            this.dgvDetail.Size = new System.Drawing.Size(1184, 498);
            this.dgvDetail.TabIndex = 1006;
            this.dgvDetail.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetail_SpecialKeyDown);
            this.dgvDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellEndEdit);
            this.dgvDetail.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDetail_RowStateChanged);
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(0, 104);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(1184, 23);
            this.tbxSearch.TabIndex = 1005;
            this.tbxSearch.WatermarkText = "请输入名称、拼音码检索(按回车检索)";
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // colClassCode_wpd
            // 
            this.colClassCode_wpd.DataPropertyName = "SpecificationCode";
            this.colClassCode_wpd.HeaderText = "药品编码";
            this.colClassCode_wpd.MinimumWidth = 120;
            this.colClassCode_wpd.Name = "colClassCode_wpd";
            this.colClassCode_wpd.ReadOnly = true;
            this.colClassCode_wpd.Width = 120;
            // 
            // colName_wpd
            // 
            this.colName_wpd.DataPropertyName = "DrugName";
            this.colName_wpd.HeaderText = "药品名称";
            this.colName_wpd.MinimumWidth = 200;
            this.colName_wpd.Name = "colName_wpd";
            this.colName_wpd.ReadOnly = true;
            this.colName_wpd.Width = 200;
            // 
            // colSpecification_wpd
            // 
            this.colSpecification_wpd.DataPropertyName = "Specification";
            this.colSpecification_wpd.HeaderText = "规格";
            this.colSpecification_wpd.MinimumWidth = 150;
            this.colSpecification_wpd.Name = "colSpecification_wpd";
            this.colSpecification_wpd.ReadOnly = true;
            this.colSpecification_wpd.Width = 150;
            // 
            // colPackageUnit_wpd
            // 
            this.colPackageUnit_wpd.DataPropertyName = "BigPackageUnit";
            this.colPackageUnit_wpd.HeaderText = "单位";
            this.colPackageUnit_wpd.MinimumWidth = 60;
            this.colPackageUnit_wpd.Name = "colPackageUnit_wpd";
            this.colPackageUnit_wpd.ReadOnly = true;
            // 
            // colDrugformValue_wpd
            // 
            this.colDrugformValue_wpd.DataPropertyName = "DrugformValue";
            this.colDrugformValue_wpd.HeaderText = "剂型";
            this.colDrugformValue_wpd.MinimumWidth = 60;
            this.colDrugformValue_wpd.Name = "colDrugformValue_wpd";
            this.colDrugformValue_wpd.ReadOnly = true;
            // 
            // colCurrentBigQuantity_wpd
            // 
            this.colCurrentBigQuantity_wpd.DataPropertyName = "CurrentBigQuantity";
            this.colCurrentBigQuantity_wpd.HeaderText = "盘点前数量（大）";
            this.colCurrentBigQuantity_wpd.MinimumWidth = 150;
            this.colCurrentBigQuantity_wpd.Name = "colCurrentBigQuantity_wpd";
            this.colCurrentBigQuantity_wpd.ReadOnly = true;
            this.colCurrentBigQuantity_wpd.Width = 150;
            // 
            // colQuantity_wpd
            // 
            this.colQuantity_wpd.DataPropertyName = "ActualBigQuantity";
            this.colQuantity_wpd.HeaderText = "实盘数（大）";
            this.colQuantity_wpd.MinimumWidth = 150;
            this.colQuantity_wpd.Name = "colQuantity_wpd";
            this.colQuantity_wpd.ReadOnly = true;
            this.colQuantity_wpd.Width = 150;
            // 
            // colCurrentSmallQuantity_wpd
            // 
            this.colCurrentSmallQuantity_wpd.DataPropertyName = "CurrentSmallQuantity";
            this.colCurrentSmallQuantity_wpd.HeaderText = "盘点前数量（小）";
            this.colCurrentSmallQuantity_wpd.MinimumWidth = 150;
            this.colCurrentSmallQuantity_wpd.Name = "colCurrentSmallQuantity_wpd";
            this.colCurrentSmallQuantity_wpd.ReadOnly = true;
            this.colCurrentSmallQuantity_wpd.Width = 150;
            // 
            // colQuantity_ppd
            // 
            this.colQuantity_ppd.DataPropertyName = "ActualSmallQuantity";
            this.colQuantity_ppd.HeaderText = "实盘数（小）";
            this.colQuantity_ppd.MinimumWidth = 150;
            this.colQuantity_ppd.Name = "colQuantity_ppd";
            this.colQuantity_ppd.ReadOnly = true;
            this.colQuantity_ppd.Width = 150;
            // 
            // colManufacturer_wpd
            // 
            this.colManufacturer_wpd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colManufacturer_wpd.DataPropertyName = "Manufacturer";
            this.colManufacturer_wpd.HeaderText = "生产厂家";
            this.colManufacturer_wpd.MinimumWidth = 100;
            this.colManufacturer_wpd.Name = "colManufacturer_wpd";
            this.colManufacturer_wpd.ReadOnly = true;
            // 
            // FormTakeStockDetails
            // 
            this.AbortBtn.AutoSize = false;
            this.AbortBtn.Enable = true;
            this.AbortBtn.Text = "中止";
            this.AbortBtn.Width = 64;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.Enable = true;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Width = 64;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.groupBox1);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormTakeStockDetails";
            this.NoBtn.AutoSize = false;
            this.NoBtn.Enable = true;
            this.NoBtn.Text = "否";
            this.NoBtn.Width = 64;
            this.OKBtn.AutoSize = false;
            this.OKBtn.Enable = true;
            this.OKBtn.Text = "确定";
            this.OKBtn.Width = 64;
            this.RetryBtn.AutoSize = false;
            this.RetryBtn.Enable = true;
            this.RetryBtn.Text = "重试";
            this.RetryBtn.Width = 64;
            this.Text = "盘点单详情";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormTakeStockDetails_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tbxSearch, 0);
            this.Controls.SetChildIndex(this.dgvDetail, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxEnd;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxBegin;
        private System.Windows.Forms.Label label1;
        private HIS.ControlLib.DataGridViewExt dgvDetail;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassCode_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackageUnit_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugformValue_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentBigQuantity_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentSmallQuantity_wpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity_ppd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturer_wpd;
    }
}