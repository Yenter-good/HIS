
namespace App_OP.Prescription
{
    partial class UCPatientDiagnosis
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
            HIS.ControlLib.BindColumn bindColumn1 = new HIS.ControlLib.BindColumn();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPatientDiagnosis));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvDiagnosisFilter = new HIS.ControlLib.DataGridViewInput();
            this.colFilterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilterWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiagnosis = new HIS.ControlLib.DataGridViewExt();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnCommon = new DevComponents.DotNetBar.ButtonItem();
            this.btnICD = new DevComponents.DotNetBar.ButtonItem();
            this.btnCMDiagnosis = new DevComponents.DotNetBar.ButtonItem();
            this.btnCMSymptoms = new DevComponents.DotNetBar.ButtonItem();
            this.colPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostfix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMainFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvDiagnosisFilter);
            this.panelEx1.Controls.Add(this.dgvDiagnosis);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx1.Size = new System.Drawing.Size(660, 289);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgvDiagnosisFilter
            // 
            this.dgvDiagnosisFilter.AllowUserToAddRows = false;
            this.dgvDiagnosisFilter.AllowUserToDeleteRows = false;
            this.dgvDiagnosisFilter.AllowUserToResizeColumns = false;
            this.dgvDiagnosisFilter.AllowUserToResizeRows = false;
            this.dgvDiagnosisFilter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosisFilter.ClickBlankClearSelect = false;
            this.dgvDiagnosisFilter.ColumnHeadersHeight = 30;
            this.dgvDiagnosisFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnosisFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilterName,
            this.colFilterType,
            this.colFilterWhite});
            bindColumn1.Column = null;
            this.dgvDiagnosisFilter.Container.BindColumn = bindColumn1;
            this.dgvDiagnosisFilter.Container.Host = this.dgvDiagnosis;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnosisFilter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiagnosisFilter.Delay = 200;
            this.dgvDiagnosisFilter.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDiagnosisFilter.DeleteLineRowIndexCollection")));
            this.dgvDiagnosisFilter.EnableSpecialKeyIntercept = false;
            this.dgvDiagnosisFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.dgvDiagnosisFilter.Location = new System.Drawing.Point(20, 92);
            this.dgvDiagnosisFilter.Name = "dgvDiagnosisFilter";
            this.dgvDiagnosisFilter.ReadOnly = true;
            this.dgvDiagnosisFilter.RowHeadersVisible = false;
            this.dgvDiagnosisFilter.RowTemplate.Height = 23;
            this.dgvDiagnosisFilter.SelectColumn = null;
            this.dgvDiagnosisFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosisFilter.Size = new System.Drawing.Size(463, 264);
            this.dgvDiagnosisFilter.TabIndex = 2;
            this.dgvDiagnosisFilter.Visible = false;
            this.dgvDiagnosisFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosisFilter_CellDoubleClick);
            // 
            // colFilterName
            // 
            this.colFilterName.HeaderText = "诊断名称";
            this.colFilterName.Name = "colFilterName";
            this.colFilterName.ReadOnly = true;
            this.colFilterName.Width = 200;
            // 
            // colFilterType
            // 
            this.colFilterType.HeaderText = "诊断类型";
            this.colFilterType.Name = "colFilterType";
            this.colFilterType.ReadOnly = true;
            // 
            // colFilterWhite
            // 
            this.colFilterWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilterWhite.HeaderText = "";
            this.colFilterWhite.Name = "colFilterWhite";
            this.colFilterWhite.ReadOnly = true;
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.AllowUserToAddRows = false;
            this.dgvDiagnosis.AllowUserToDeleteRows = false;
            this.dgvDiagnosis.AllowUserToResizeColumns = false;
            this.dgvDiagnosis.AllowUserToResizeRows = false;
            this.dgvDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiagnosis.ClickBlankClearSelect = false;
            this.dgvDiagnosis.ColumnHeadersHeight = 30;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrefix,
            this.colName,
            this.colPostfix,
            this.colConfirmFlag,
            this.colMainFlag,
            this.colWhite});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnosis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnosis.Delay = 200;
            this.dgvDiagnosis.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvDiagnosis.DeleteLineRowIndexCollection")));
            this.dgvDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagnosis.EnableSpecialKeyIntercept = true;
            this.dgvDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.dgvDiagnosis.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvDiagnosis.Location = new System.Drawing.Point(1, 30);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.RowHeadersVisible = false;
            this.dgvDiagnosis.RowTemplate.Height = 23;
            this.dgvDiagnosis.SelectColumn = null;
            this.dgvDiagnosis.Size = new System.Drawing.Size(658, 258);
            this.dgvDiagnosis.TabIndex = 0;
            this.dgvDiagnosis.SpecialKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDiagnosis_SpecialKeyDown);
            this.dgvDiagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellClick);
            this.dgvDiagnosis.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellEndEdit);
            this.dgvDiagnosis.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiagnosis_CellFormatting);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnCommon,
            this.btnICD,
            this.btnCMDiagnosis,
            this.btnCMSymptoms});
            this.bar1.Location = new System.Drawing.Point(1, 1);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(658, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加诊断";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除诊断";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCommon
            // 
            this.btnCommon.BeginGroup = true;
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Text = "常用诊断";
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // btnICD
            // 
            this.btnICD.Checked = true;
            this.btnICD.Name = "btnICD";
            this.btnICD.Text = "西医诊断";
            this.btnICD.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // btnCMDiagnosis
            // 
            this.btnCMDiagnosis.Name = "btnCMDiagnosis";
            this.btnCMDiagnosis.Text = "中医诊断";
            this.btnCMDiagnosis.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // btnCMSymptoms
            // 
            this.btnCMSymptoms.Name = "btnCMSymptoms";
            this.btnCMSymptoms.Text = "中医症候";
            this.btnCMSymptoms.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // colPrefix
            // 
            this.colPrefix.HeaderText = "前缀";
            this.colPrefix.Name = "colPrefix";
            this.colPrefix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.HeaderText = "诊断名称";
            this.colName.Name = "colName";
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 200;
            // 
            // colPostfix
            // 
            this.colPostfix.HeaderText = "后缀";
            this.colPostfix.Name = "colPostfix";
            this.colPostfix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colConfirmFlag
            // 
            this.colConfirmFlag.HeaderText = "确诊";
            this.colConfirmFlag.Name = "colConfirmFlag";
            this.colConfirmFlag.ReadOnly = true;
            this.colConfirmFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colConfirmFlag.Width = 60;
            // 
            // colMainFlag
            // 
            this.colMainFlag.HeaderText = "主诊断";
            this.colMainFlag.Name = "colMainFlag";
            this.colMainFlag.ReadOnly = true;
            this.colMainFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMainFlag.Width = 80;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite.HeaderText = "";
            this.colWhite.Name = "colWhite";
            this.colWhite.ReadOnly = true;
            this.colWhite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UCPatientDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCPatientDiagnosis";
            this.Size = new System.Drawing.Size(660, 289);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private HIS.ControlLib.DataGridViewExt dgvDiagnosis;
        private DevComponents.DotNetBar.Bar bar1;
        private HIS.ControlLib.DataGridViewInput dgvDiagnosisFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilterWhite;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnCommon;
        private DevComponents.DotNetBar.ButtonItem btnICD;
        private DevComponents.DotNetBar.ButtonItem btnCMDiagnosis;
        private DevComponents.DotNetBar.ButtonItem btnCMSymptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostfix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMainFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
    }
}
