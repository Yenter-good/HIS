
namespace App_Sys.Dept
{
    partial class FormDeptPharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeptPharmacy));
            this.dgvMain = new HIS.ControlLib.DataGridViewExt();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ClickBlankClearSelect = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.Delay = 200;
            this.dgvMain.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvMain.DeleteLineRowIndexCollection")));
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.EnableSpecialKeyIntercept = true;
            this.dgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMain.Location = new System.Drawing.Point(0, 4);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.SelectColumn = null;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(332, 360);
            this.dgvMain.TabIndex = 1004;
            this.dgvMain.SelectValueChanged += new System.EventHandler<HIS.ControlLib.SelectValueChangedEventArgs>(this.dgvMain_SelectValueChanged);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "";
            this.colCheck.MinimumWidth = 40;
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCheck.Width = 40;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "药房名称";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // FormDeptPharmacy
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
            this.ClientSize = new System.Drawing.Size(332, 400);
            this.Controls.Add(this.dgvMain);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormDeptPharmacy";
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
            this.Text = "科室对应药房";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormDeptPharmacy_Load);
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HIS.ControlLib.DataGridViewExt dgvMain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}