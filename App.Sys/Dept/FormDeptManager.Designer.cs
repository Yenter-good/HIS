
namespace App_Sys.Dept
{
    partial class FormDeptManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeptManager));
            this.dgvDept = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colSymbol = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colAliasName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCategory = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colLocation = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colWhite = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnRestop = new DevComponents.DotNetBar.ButtonItem();
            this.btnStop = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.swShowDisable = new DevComponents.DotNetBar.SwitchButtonItem();
            this.btnSetPharmacy = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDept
            // 
            this.dgvDept.BackColor = System.Drawing.Color.White;
            this.dgvDept.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor1.Bottom = System.Drawing.Color.Transparent;
            borderColor1.Left = System.Drawing.Color.Transparent;
            borderColor1.Right = System.Drawing.Color.Transparent;
            borderColor1.Top = System.Drawing.Color.Transparent;
            this.dgvDept.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor1;
            this.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDept.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvDept.ForeColor = System.Drawing.Color.Black;
            this.dgvDept.Location = new System.Drawing.Point(0, 29);
            this.dgvDept.Name = "dgvDept";
            // 
            // 
            // 
            this.dgvDept.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvDept.PrimaryGrid.AllowRowResize = true;
            this.dgvDept.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvDept.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvDept.PrimaryGrid.Columns.Add(this.colSymbol);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colCode);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colName);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colAliasName);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colCategory);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colStatus);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colLocation);
            this.dgvDept.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvDept.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvDept.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvDept.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvDept.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvDept.PrimaryGrid.EnableFiltering = true;
            this.dgvDept.PrimaryGrid.EnableRowFiltering = true;
            this.dgvDept.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle;
            // 
            // 
            // 
            this.dgvDept.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvDept.PrimaryGrid.Filter.Visible = true;
            this.dgvDept.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions;
            this.dgvDept.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvDept.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvDept.PrimaryGrid.MultiSelect = false;
            this.dgvDept.PrimaryGrid.NullString = "<<null>>";
            this.dgvDept.PrimaryGrid.ReadOnly = true;
            this.dgvDept.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvDept.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvDept.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvDept.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvDept.PrimaryGrid.ShowTreeButtons = true;
            this.dgvDept.Size = new System.Drawing.Size(1152, 595);
            this.dgvDept.TabIndex = 45;
            this.dgvDept.Text = "superGridControl2";
            this.dgvDept.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvDept_CellDoubleClick);
            // 
            // colSymbol
            // 
            this.colSymbol.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            this.colSymbol.HeaderText = " ";
            this.colSymbol.Name = "gridColumn1";
            this.colSymbol.Width = 50;
            // 
            // colCode
            // 
            this.colCode.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.colCode.Name = "科室编号";
            // 
            // colName
            // 
            this.colName.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.colName.Name = "科室名称";
            this.colName.Width = 300;
            // 
            // colAliasName
            // 
            this.colAliasName.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.colAliasName.Name = "科室别名";
            this.colAliasName.Width = 200;
            // 
            // colCategory
            // 
            this.colCategory.Name = "科室类型";
            // 
            // colStatus
            // 
            this.colStatus.Name = "状态";
            // 
            // colLocation
            // 
            this.colLocation.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.colLocation.Name = "科室位置";
            this.colLocation.Width = 300;
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
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRefresh,
            this.btnInsert,
            this.btnEdit,
            this.btnRestop,
            this.btnStop,
            this.labelItem2,
            this.labelItem1,
            this.swShowDisable,
            this.btnSetPharmacy});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1152, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 44;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BeginGroup = true;
            this.btnInsert.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Text = "添加";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRestop
            // 
            this.btnRestop.BeginGroup = true;
            this.btnRestop.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRestop.Image = ((System.Drawing.Image)(resources.GetObject("btnRestop.Image")));
            this.btnRestop.Name = "btnRestop";
            this.btnRestop.Text = "启用";
            this.btnRestop.Click += new System.EventHandler(this.btnRestop_Click);
            // 
            // btnStop
            // 
            this.btnStop.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Name = "btnStop";
            this.btnStop.Text = "停用";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            // btnSetPharmacy
            // 
            this.btnSetPharmacy.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSetPharmacy.Image = ((System.Drawing.Image)(resources.GetObject("btnSetPharmacy.Image")));
            this.btnSetPharmacy.Name = "btnSetPharmacy";
            this.btnSetPharmacy.Text = "设置药房";
            this.btnSetPharmacy.Click += new System.EventHandler(this.btnSetPharmacy_Click);
            // 
            // FormDeptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 624);
            this.Controls.Add(this.dgvDept);
            this.Controls.Add(this.bar1);
            this.Name = "FormDeptManager";
            this.Text = "科室管理";
            this.Shown += new System.EventHandler(this.FormDeptManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnRestop;
        private DevComponents.DotNetBar.ButtonItem btnStop;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.SwitchButtonItem swShowDisable;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvDept;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCategory;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colAliasName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colLocation;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colSymbol;
        private DevComponents.DotNetBar.ButtonItem btnSetPharmacy;
    }
}