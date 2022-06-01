namespace ConfigurationTool
{
    partial class FormHISConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHISConfig));
            this.pnlTool = new DevComponents.DotNetBar.Bar();
            this.btnFile = new DevComponents.DotNetBar.ButtonItem();
            this.btnOpen = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaveAs = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddConnect = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.gridConnString = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superGridControl2 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridPramms = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.AccessibleDescription = "bar1 (bar1)";
            this.pnlTool.AccessibleName = "bar1";
            this.pnlTool.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.pnlTool.AntiAlias = true;
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlTool.IsMaximized = false;
            this.pnlTool.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnFile,
            this.btnRefresh,
            this.btnAddConnect,
            this.btnEdit,
            this.btnDelete,
            this.buttonItem1});
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.RoundCorners = false;
            this.pnlTool.Size = new System.Drawing.Size(838, 27);
            this.pnlTool.Stretch = true;
            this.pnlTool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlTool.TabIndex = 21;
            this.pnlTool.TabStop = false;
            this.pnlTool.Text = "bar1";
            // 
            // btnFile
            // 
            this.btnFile.Name = "btnFile";
            this.btnFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs});
            this.btnFile.Text = "文件";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Text = "打开";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Text = "另存为";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BeginGroup = true;
            this.btnRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            // 
            // btnAddConnect
            // 
            this.btnAddConnect.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAddConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnAddConnect.Image")));
            this.btnAddConnect.Name = "btnAddConnect";
            this.btnAddConnect.Text = "新增配置";
            this.btnAddConnect.Visible = false;
            this.btnAddConnect.Click += new System.EventHandler(this.btnAddConnect_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "另存为";
            this.buttonItem1.Visible = false;
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 27);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(838, 482);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 22;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.gridPramms});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.gridConnString);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(838, 452);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // gridConnString
            // 
            this.gridConnString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConnString.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridConnString.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gridConnString.Location = new System.Drawing.Point(0, 0);
            this.gridConnString.Name = "gridConnString";
            // 
            // 
            // 
            this.gridConnString.PrimaryGrid.AllowEdit = false;
            this.gridConnString.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.gridConnString.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.gridConnString.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.gridConnString.Size = new System.Drawing.Size(838, 452);
            this.gridConnString.TabIndex = 1;
            this.gridConnString.Text = "superGridControl1";
            this.gridConnString.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.superGridControl1_RowClick);
            this.gridConnString.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.superGridControl1_RowDoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "连接名";
            this.gridColumn1.Width = 300;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "参数";
            this.gridColumn2.Width = 500;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "连接管理";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.superGridControl2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 27);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(838, 458);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.gridPramms;
            // 
            // superGridControl2
            // 
            this.superGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.superGridControl2.Location = new System.Drawing.Point(0, 0);
            this.superGridControl2.Name = "superGridControl2";
            // 
            // 
            // 
            this.superGridControl2.PrimaryGrid.AllowEdit = false;
            this.superGridControl2.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.superGridControl2.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.superGridControl2.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.superGridControl2.Size = new System.Drawing.Size(838, 458);
            this.superGridControl2.TabIndex = 1;
            this.superGridControl2.Text = "superGridControl2";
            this.superGridControl2.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.superGridControl2_RowClick);
            this.superGridControl2.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.superGridControl2_RowDoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "连接名";
            this.gridColumn3.Width = 300;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "参数";
            this.gridColumn4.Width = 500;
            // 
            // gridPramms
            // 
            this.gridPramms.AttachedControl = this.superTabControlPanel2;
            this.gridPramms.GlobalItem = false;
            this.gridPramms.Name = "gridPramms";
            this.gridPramms.Text = "固定参数";
            // 
            // FormHISConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 509);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.pnlTool);
            this.DoubleBuffered = true;
            this.Name = "FormHISConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHISConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar pnlTool;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnAddConnect;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem gridPramms;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridConnString;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.ButtonItem btnFile;
        private DevComponents.DotNetBar.ButtonItem btnOpen;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnSaveAs;
    }
}