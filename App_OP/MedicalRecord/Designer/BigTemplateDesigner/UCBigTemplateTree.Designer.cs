namespace App_OP.MedicalRecord
{
    partial class UCBigTemplateTree
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBigTemplateTree));
            this.advTree = new DevComponents.AdvTree.AdvTree();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemover = new DevComponents.DotNetBar.ButtonItem();
            this.btnRename = new DevComponents.DotNetBar.ButtonItem();
            this.btnImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnEffective = new DevComponents.DotNetBar.ButtonItem();
            this.btnUnEffective = new DevComponents.DotNetBar.ButtonItem();
            this.btnCopy = new DevComponents.DotNetBar.ButtonItem();
            this.btnPast = new DevComponents.DotNetBar.ButtonItem();
            this.HospitalNode = new DevComponents.AdvTree.Node();
            this.DeptNode = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnQueryByDept = new DevComponents.DotNetBar.ButtonItem();
            this.btnQueryByTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.advTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // advTree
            // 
            this.advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar1.SetContextMenuEx(this.advTree, this.buttonItem1);
            this.advTree.Controls.Add(this.contextMenuBar1);
            this.advTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree.Location = new System.Drawing.Point(0, 49);
            this.advTree.Name = "advTree";
            this.advTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.HospitalNode,
            this.DeptNode});
            this.advTree.NodesConnector = this.nodeConnector1;
            this.advTree.NodeStyle = this.elementStyle1;
            this.advTree.PathSeparator = ";";
            this.advTree.Size = new System.Drawing.Size(399, 688);
            this.advTree.Styles.Add(this.elementStyle1);
            this.advTree.TabIndex = 0;
            this.advTree.Text = "advTree1";
            this.advTree.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.advTree_AfterCellEdit);
            this.advTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree_AfterNodeSelect);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(50, 135);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(134, 26);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 0;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            this.contextMenuBar1.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.contextMenuBar1_PopupOpen);
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReflesh,
            this.btnAdd,
            this.btnRemover,
            this.btnRename,
            this.btnImport,
            this.btnExport,
            this.btnEffective,
            this.btnUnEffective,
            this.btnCopy,
            this.btnPast});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加模板";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Text = "删除模板";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRename
            // 
            this.btnRename.Name = "btnRename";
            this.btnRename.Text = "重命名";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnImport
            // 
            this.btnImport.BeginGroup = true;
            this.btnImport.Name = "btnImport";
            this.btnImport.Text = "导入模板";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "导出模板";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEffective
            // 
            this.btnEffective.BeginGroup = true;
            this.btnEffective.Name = "btnEffective";
            this.btnEffective.Text = "模板生效";
            this.btnEffective.Click += new System.EventHandler(this.btnEffective_Click);
            // 
            // btnUnEffective
            // 
            this.btnUnEffective.Name = "btnUnEffective";
            this.btnUnEffective.Text = "模板失效";
            this.btnUnEffective.Click += new System.EventHandler(this.btnUnEffective_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BeginGroup = true;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Text = "复制模板";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPast
            // 
            this.btnPast.Name = "btnPast";
            this.btnPast.Text = "粘贴模板";
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // HospitalNode
            // 
            this.HospitalNode.Expanded = true;
            this.HospitalNode.Name = "HospitalNode";
            this.HospitalNode.Text = "全院";
            // 
            // DeptNode
            // 
            this.DeptNode.Expanded = true;
            this.DeptNode.Name = "DeptNode";
            this.DeptNode.Text = "科室";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQueryByDept,
            this.btnQueryByTemplate});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(399, 26);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnQueryByDept
            // 
            this.btnQueryByDept.Checked = true;
            this.btnQueryByDept.Name = "btnQueryByDept";
            this.btnQueryByDept.Text = "根据科室检索";
            this.btnQueryByDept.Click += new System.EventHandler(this.ChangeFilter);
            // 
            // btnQueryByTemplate
            // 
            this.btnQueryByTemplate.BeginGroup = true;
            this.btnQueryByTemplate.Name = "btnQueryByTemplate";
            this.btnQueryByTemplate.Text = "根据模板检索";
            this.btnQueryByTemplate.Click += new System.EventHandler(this.ChangeFilter);
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(0, 26);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(399, 23);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.WatermarkText = "请输入名称、拼音码、五笔码检索";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Open_16x16.png");
            this.imageList1.Images.SetKeyName(1, "TextBox_16x16.png");
            // 
            // UCBigTemplateTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.advTree);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCBigTemplateTree";
            this.Size = new System.Drawing.Size(399, 737);
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.advTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree advTree;
        private DevComponents.AdvTree.Node HospitalNode;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node DeptNode;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnImport;
        private DevComponents.DotNetBar.ButtonItem btnExport;
        private DevComponents.DotNetBar.ButtonItem btnRename;
        private DevComponents.DotNetBar.ButtonItem btnEffective;
        private DevComponents.DotNetBar.ButtonItem btnUnEffective;
        private DevComponents.DotNetBar.ButtonItem btnCopy;
        private DevComponents.DotNetBar.ButtonItem btnPast;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRemover;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnQueryByDept;
        private DevComponents.DotNetBar.ButtonItem btnQueryByTemplate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
        private DevComponents.DotNetBar.ButtonItem btnReflesh;
        private System.Windows.Forms.ImageList imageList1;
    }
}
