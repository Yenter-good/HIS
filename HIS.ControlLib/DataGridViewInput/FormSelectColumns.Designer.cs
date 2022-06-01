
namespace HIS.ControlLib
{
    partial class FormSelectColumns
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
            this.fpnlButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.dgvColumns = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colHeadText = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.fpnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlButton
            // 
            this.fpnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.fpnlButton.Controls.Add(this.btnCancel);
            this.fpnlButton.Controls.Add(this.btnOK);
            this.fpnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpnlButton.Location = new System.Drawing.Point(0, 258);
            this.fpnlButton.Name = "fpnlButton";
            this.fpnlButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.fpnlButton.Size = new System.Drawing.Size(489, 36);
            this.fpnlButton.TabIndex = 1001;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(422, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 1000;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnOK.Location = new System.Drawing.Point(352, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 999;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvColumns
            // 
            this.dgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumns.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvColumns.Location = new System.Drawing.Point(0, 0);
            this.dgvColumns.Name = "dgvColumns";
            // 
            // 
            // 
            this.dgvColumns.PrimaryGrid.Columns.Add(this.colName);
            this.dgvColumns.PrimaryGrid.Columns.Add(this.colHeadText);
            this.dgvColumns.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvColumns.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvColumns.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvColumns.PrimaryGrid.ReadOnly = true;
            this.dgvColumns.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvColumns.Size = new System.Drawing.Size(489, 258);
            this.dgvColumns.TabIndex = 1002;
            this.dgvColumns.Text = "superGridControl1";
            // 
            // colName
            // 
            this.colName.Name = "列名";
            this.colName.Width = 150;
            // 
            // colHeadText
            // 
            this.colHeadText.Name = "标题";
            this.colHeadText.Width = 150;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.Name = "";
            // 
            // FormSelectColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 294);
            this.Controls.Add(this.dgvColumns);
            this.Controls.Add(this.fpnlButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectColumns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择列";
            this.Shown += new System.EventHandler(this.FormSelectColumns_Shown);
            this.fpnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlButton;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvColumns;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colHeadText;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
    }
}