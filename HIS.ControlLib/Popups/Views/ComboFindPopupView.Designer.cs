
namespace HIS.ControlLib.Popups
{
    partial class ComboFindPopupView
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colDisplayText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.txtFilter = new HIS.ControlLib.DelayTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.BackgroundColor = System.Drawing.Color.White;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.ColumnHeadersVisible = false;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDisplayText});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.EnableHeadersVisualStyles = false;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvView.Location = new System.Drawing.Point(3, 30);
            this.dgvView.MultiSelect = false;
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvView.RowHeadersVisible = false;
            this.dgvView.RowTemplate.Height = 23;
            this.dgvView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(0, 337);
            this.dgvView.TabIndex = 1;
            this.dgvView.UseCustomBackgroundColor = true;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            this.dgvView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvView_KeyDown);
            // 
            // colDisplayText
            // 
            this.colDisplayText.HeaderText = "Column1";
            this.colDisplayText.MinimumWidth = 100;
            this.colDisplayText.Name = "colDisplayText";
            this.colDisplayText.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.symbolBox1);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panel1.Size = new System.Drawing.Size(0, 30);
            this.panel1.TabIndex = 0;
            // 
            // symbolBox1
            // 
            this.symbolBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(-23, 8);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(19, 13);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.SymbolColor = System.Drawing.Color.SteelBlue;
            this.symbolBox1.TabIndex = 1;
            this.symbolBox1.Text = "symbolBox1";
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.Border.Class = "TextBoxBorder";
            this.txtFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(0, 4);
            this.txtFilter.MarkString = null;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PreventEnterBeep = true;
            this.txtFilter.Size = new System.Drawing.Size(0, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ComboFindPopupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(0, 450);
            this.MinimumSize = new System.Drawing.Size(0, 25);
            this.Name = "ComboFindPopupView";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Size = new System.Drawing.Size(0, 370);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvView;
        private System.Windows.Forms.Panel panel1;
        private DelayTextBox txtFilter;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisplayText;
    }
}
