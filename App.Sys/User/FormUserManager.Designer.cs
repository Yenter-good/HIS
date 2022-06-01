namespace App_Sys.UserManager
{
    partial class FormUserManager
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            this.dgvUser = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPassword = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colNature = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEducation = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDefaultRole = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colRoles = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colStatus = new DevComponents.DotNetBar.SuperGrid.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.BackColor = System.Drawing.Color.White;
            this.dgvUser.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            borderColor2.Bottom = System.Drawing.Color.Transparent;
            borderColor2.Left = System.Drawing.Color.Transparent;
            borderColor2.Right = System.Drawing.Color.Transparent;
            borderColor2.Top = System.Drawing.Color.Transparent;
            this.dgvUser.DefaultVisualStyles.GridPanelStyle.BorderColor = borderColor2;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvUser.ForeColor = System.Drawing.Color.Black;
            this.dgvUser.Location = new System.Drawing.Point(0, 29);
            this.dgvUser.Name = "dgvUser";
            // 
            // 
            // 
            this.dgvUser.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvUser.PrimaryGrid.AllowRowResize = true;
            this.dgvUser.PrimaryGrid.AutoGenerateColumns = false;
            // 
            // 
            // 
            this.dgvUser.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.dgvUser.PrimaryGrid.Columns.Add(this.colCode);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colName);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colPassword);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colType);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colNature);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colEducation);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colDefaultRole);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colRoles);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colStatus);
            this.dgvUser.PrimaryGrid.Columns.Add(this.colWhite);
            this.dgvUser.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvUser.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvUser.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvUser.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvUser.PrimaryGrid.EnableFiltering = true;
            this.dgvUser.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.dgvUser.PrimaryGrid.Filter.RowHeight = 30;
            this.dgvUser.PrimaryGrid.Filter.Visible = true;
            this.dgvUser.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.dgvUser.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.dgvUser.PrimaryGrid.MultiSelect = false;
            this.dgvUser.PrimaryGrid.NullString = "<<null>>";
            this.dgvUser.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.dgvUser.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvUser.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvUser.PrimaryGrid.ShowRowGridIndex = true;
            this.dgvUser.Size = new System.Drawing.Size(1139, 741);
            this.dgvUser.TabIndex = 42;
            this.dgvUser.Text = "superGridControl2";
            this.dgvUser.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvUser_CellDoubleClick);
            this.dgvUser.CellMouseDown += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellMouseEventArgs>(this.dgvUser_CellMouseDown);
            this.dgvUser.CellMouseUp += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellMouseEventArgs>(this.dgvUser_CellMouseUp);
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "";
            this.colCode.HeaderText = "工号";
            this.colCode.Name = "";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "";
            this.colName.HeaderText = "姓名";
            this.colName.Name = "";
            this.colName.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "密码";
            this.colPassword.Name = "";
            this.colPassword.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "类型";
            this.colType.Name = "";
            this.colType.ReadOnly = true;
            // 
            // colNature
            // 
            this.colNature.HeaderText = "性质";
            this.colNature.Name = "";
            this.colNature.ReadOnly = true;
            // 
            // colEducation
            // 
            this.colEducation.HeaderText = "学历";
            this.colEducation.Name = "";
            this.colEducation.ReadOnly = true;
            // 
            // colDefaultRole
            // 
            this.colDefaultRole.HeaderText = "默认角色";
            this.colDefaultRole.Name = "";
            this.colDefaultRole.ReadOnly = true;
            // 
            // colRoles
            // 
            this.colRoles.HeaderText = "拥有的角色";
            this.colRoles.Name = "";
            this.colRoles.Width = 300;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "";
            this.colStatus.HeaderText = "是否停用";
            this.colStatus.Name = "";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colWhite
            // 
            this.colWhite.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colWhite.Name = "";
            this.colWhite.ReadOnly = true;
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
            this.swShowDisable});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1139, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 43;
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
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRestop
            // 
            this.btnRestop.BeginGroup = true;
            this.btnRestop.Name = "btnRestop";
            this.btnRestop.Text = "启用";
            this.btnRestop.Click += new System.EventHandler(this.btnRestop_Click);
            // 
            // btnStop
            // 
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
            // FormUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 770);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.bar1);
            this.Name = "FormUserManager";
            this.Text = "用户管理";
            this.Shown += new System.EventHandler(this.FormUserManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvUser;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPassword;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colType;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colNature;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEducation;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDefaultRole;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colRoles;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colStatus;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colWhite;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnInsert;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnRestop;
        private DevComponents.DotNetBar.ButtonItem btnStop;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.SwitchButtonItem swShowDisable;
        private DevComponents.DotNetBar.LabelItem labelItem2;
    }
}