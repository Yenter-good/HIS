
namespace App_Sys.Dic
{
    partial class FormUsage
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
            this.dgvUsage = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colSearchCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWubiCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCategory = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnEnable = new DevComponents.DotNetBar.ButtonItem();
            this.btnDisable = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.swShowDisable = new DevComponents.DotNetBar.SwitchButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsage
            // 
            this.dgvUsage.BackColor = System.Drawing.Color.White;
            this.dgvUsage.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvUsage.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsage.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvUsage.ForeColor = System.Drawing.Color.Black;
            this.dgvUsage.Location = new System.Drawing.Point(0, 26);
            this.dgvUsage.Name = "dgvUsage";
            // 
            // 
            // 
            this.dgvUsage.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvUsage.PrimaryGrid.AllowRowResize = true;
            this.dgvUsage.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvUsage.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colName);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colCode);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colSearchCode);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colWubiCode);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colCategory);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colStatus);
            this.dgvUsage.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvUsage.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvUsage.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvUsage.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvUsage.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvUsage.PrimaryGrid.EnableFiltering = true;
            this.dgvUsage.PrimaryGrid.EnableRowFiltering = true;
            this.dgvUsage.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle;
            // 
            // 
            // 
            this.dgvUsage.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvUsage.PrimaryGrid.Filter.Visible = true;
            this.dgvUsage.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvUsage.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvUsage.PrimaryGrid.MultiSelect = false;
            this.dgvUsage.PrimaryGrid.NullString = "<<null>>";
            this.dgvUsage.PrimaryGrid.ReadOnly = true;
            this.dgvUsage.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvUsage.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvUsage.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvUsage.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvUsage.PrimaryGrid.ShowTreeButtons = true;
            this.dgvUsage.Size = new System.Drawing.Size(879, 574);
            this.dgvUsage.TabIndex = 46;
            this.dgvUsage.Text = "superGridControl2";
            this.dgvUsage.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvUsage_CellDoubleClick);
            // 
            // colName
            // 
            this.colName.Name = "名称";
            this.colName.Width = 150;
            // 
            // colCode
            // 
            this.colCode.Name = "编码";
            // 
            // colSearchCode
            // 
            this.colSearchCode.Name = "检索码";
            // 
            // colWubiCode
            // 
            this.colWubiCode.Name = "五笔码";
            // 
            // colCategory
            // 
            this.colCategory.Name = "分类";
            // 
            // colStatus
            // 
            this.colStatus.Name = "状态";
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.HeaderText = " ";
            this.colWhite.Name = "colWhite";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnInsert,
            this.btnEdit,
            this.btnEnable,
            this.btnDisable,
            this.labelItem2,
            this.labelItem1,
            this.swShowDisable});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(879, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BeginGroup = true;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Text = "添加";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BeginGroup = true;
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Text = "启用";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Text = "停用";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.BeginGroup = true;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Width = 50;
            // 
            // labelItem1
            // 
            this.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "是否显示停用";
            // 
            // swShowDisable
            // 
            this.swShowDisable.ButtonWidth = 60;
            this.swShowDisable.Name = "swShowDisable";
            this.swShowDisable.OffText = "否";
            this.swShowDisable.OnText = "是";
            this.swShowDisable.SwitchWidth = 30;
            this.swShowDisable.ValueChanged += new System.EventHandler(this.swShowDisable_ValueChanged);
            // 
            // FormUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 600);
            this.Controls.Add(this.dgvUsage);
            this.Controls.Add(this.bar1);
            this.Name = "FormUsage";
            this.Text = "用法设置";
            this.Shown += new System.EventHandler(this.FormUsage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnEnable;
        private DevComponents.DotNetBar.ButtonItem btnDisable;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvUsage;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSearchCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWubiCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCategory;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStatus;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.SwitchButtonItem swShowDisable;
    }
}