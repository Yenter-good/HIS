
namespace App_OP.Prescription
{
    partial class FormWMDetailPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWMDetailPreview));
            this.dgvPreview = new App_OP.Prescription.PrescriptionDataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToResizeColumns = false;
            this.dgvPreview.AllowUserToResizeRows = false;
            this.dgvPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreview.ClickBlankClearSelect = false;
            this.dgvPreview.ColumnHeadersHeight = 30;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colGroupDisplay,
            this.colGroupValue,
            this.colSpecification,
            this.colDose,
            this.colUsage,
            this.colInterval,
            this.colDay,
            this.colQuantity,
            this.colWhite});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreview.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreview.Delay = 200;
            this.dgvPreview.DeleteLineRowIndexCollection = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvPreview.DeleteLineRowIndexCollection")));
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreview.EnableSpecialKeyIntercept = true;
            this.dgvPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPreview.GroupDisplayColumn = null;
            this.dgvPreview.GroupValueColumn = null;
            this.dgvPreview.Location = new System.Drawing.Point(1, 1);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.NameColumn = null;
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowHeadersVisible = false;
            this.dgvPreview.RowTemplate.Height = 23;
            this.dgvPreview.SelectColumn = null;
            this.dgvPreview.Size = new System.Drawing.Size(678, 256);
            this.dgvPreview.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "项目名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 150;
            // 
            // colGroupDisplay
            // 
            this.colGroupDisplay.HeaderText = "";
            this.colGroupDisplay.Name = "colGroupDisplay";
            this.colGroupDisplay.ReadOnly = true;
            this.colGroupDisplay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGroupDisplay.Width = 30;
            // 
            // colGroupValue
            // 
            this.colGroupValue.HeaderText = "";
            this.colGroupValue.Name = "colGroupValue";
            this.colGroupValue.ReadOnly = true;
            this.colGroupValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGroupValue.Visible = false;
            this.colGroupValue.Width = 30;
            // 
            // colSpecification
            // 
            this.colSpecification.HeaderText = "规格";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.ReadOnly = true;
            this.colSpecification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDose
            // 
            this.colDose.HeaderText = "用量";
            this.colDose.Name = "colDose";
            this.colDose.ReadOnly = true;
            this.colDose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDose.Width = 80;
            // 
            // colUsage
            // 
            this.colUsage.HeaderText = "用法";
            this.colUsage.Name = "colUsage";
            this.colUsage.ReadOnly = true;
            this.colUsage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUsage.Width = 80;
            // 
            // colInterval
            // 
            this.colInterval.HeaderText = "间隔";
            this.colInterval.Name = "colInterval";
            this.colInterval.ReadOnly = true;
            this.colInterval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInterval.Width = 80;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "天数";
            this.colDay.Name = "colDay";
            this.colDay.ReadOnly = true;
            this.colDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDay.Width = 70;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantity.Width = 70;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWhite.HeaderText = "";
            this.colWhite.Name = "colWhite";
            this.colWhite.ReadOnly = true;
            this.colWhite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvPreview);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx1.Size = new System.Drawing.Size(680, 288);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Text = "panelEx1";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(1, 257);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(678, 30);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 5;
            // 
            // FormWMDetailPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 290);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWMDetailPreview";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPrescriptionDetailPreview";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PrescriptionDataGridView dgvPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
    }
}