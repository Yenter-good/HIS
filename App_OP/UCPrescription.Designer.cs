
namespace App_OP.Prescription
{
    partial class UCPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrescription));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvPrescription = new HIS.ControlLib.DataGridViewExt();
            this.colCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescriptionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnUndo = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvPrescription);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx1.Size = new System.Drawing.Size(693, 330);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.AllowUserToAddRows = false;
            this.dgvPrescription.AllowUserToDeleteRows = false;
            this.dgvPrescription.AllowUserToResizeColumns = false;
            this.dgvPrescription.AllowUserToResizeRows = false;
            this.dgvPrescription.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrescription.ClickBlankClearSelect = false;
            this.dgvPrescription.ColumnHeadersHeight = 30;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreationTime,
            this.colCreatorName,
            this.colPrescriptionType,
            this.colDetailNumber,
            this.colPrescriptionStatus,
            this.colWhite});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrescription.Delay = 200;
            this.dgvPrescription.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvPrescription.DeleteLineRowIndexCollection")));
            this.dgvPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrescription.EnableSpecialKeyIntercept = true;
            this.dgvPrescription.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.dgvPrescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvPrescription.Location = new System.Drawing.Point(1, 30);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            this.dgvPrescription.RowHeadersVisible = false;
            this.dgvPrescription.RowTemplate.Height = 23;
            this.dgvPrescription.SelectColumn = null;
            this.dgvPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrescription.Size = new System.Drawing.Size(691, 299);
            this.dgvPrescription.TabIndex = 5;
            this.dgvPrescription.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPrescription_CellMouseDoubleClick);
            this.dgvPrescription.MouseLeave += new System.EventHandler(this.dgvPrescription_MouseLeave);
            this.dgvPrescription.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPrescription_MouseMove);
            // 
            // colCreationTime
            // 
            this.colCreationTime.HeaderText = "创建时间";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.ReadOnly = true;
            this.colCreationTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCreationTime.Width = 150;
            // 
            // colCreatorName
            // 
            this.colCreatorName.HeaderText = "创建人";
            this.colCreatorName.Name = "colCreatorName";
            this.colCreatorName.ReadOnly = true;
            this.colCreatorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrescriptionType
            // 
            this.colPrescriptionType.HeaderText = "处方类型";
            this.colPrescriptionType.Name = "colPrescriptionType";
            this.colPrescriptionType.ReadOnly = true;
            this.colPrescriptionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrescriptionType.Width = 150;
            // 
            // colDetailNumber
            // 
            this.colDetailNumber.HeaderText = "记录数";
            this.colDetailNumber.Name = "colDetailNumber";
            this.colDetailNumber.ReadOnly = true;
            this.colDetailNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDetailNumber.Width = 70;
            // 
            // colPrescriptionStatus
            // 
            this.colPrescriptionStatus.HeaderText = "处方状态";
            this.colPrescriptionStatus.Name = "colPrescriptionStatus";
            this.colPrescriptionStatus.ReadOnly = true;
            this.colPrescriptionStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite.HeaderText = "预览";
            this.colWhite.Name = "colWhite";
            this.colWhite.ReadOnly = true;
            this.colWhite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrint,
            this.btnUndo,
            this.btnDelete,
            this.btnRefresh});
            this.bar1.Location = new System.Drawing.Point(1, 1);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(691, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 4;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印选中项";
            // 
            // btnUndo
            // 
            this.btnUndo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Text = "召回处方";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除处方";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BeginGroup = true;
            this.btnRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCPrescription";
            this.Size = new System.Drawing.Size(693, 330);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private HIS.ControlLib.DataGridViewExt dgvPrescription;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem btnUndo;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescriptionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
    }
}
