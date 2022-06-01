namespace App_OP.MedicalRecord
{
    partial class UCDataElement
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
            this.AdvTreeDataElement = new DevComponents.AdvTree.AdvTree();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemover = new DevComponents.DotNetBar.ButtonItem();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.RootNode = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTreeDataElement)).BeginInit();
            this.AdvTreeDataElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvTreeDataElement
            // 
            this.AdvTreeDataElement.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTreeDataElement.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTreeDataElement.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.AdvTreeDataElement.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTreeDataElement.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar1.SetContextMenuEx(this.AdvTreeDataElement, this.buttonItem1);
            this.AdvTreeDataElement.Controls.Add(this.contextMenuBar1);
            this.AdvTreeDataElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTreeDataElement.Location = new System.Drawing.Point(0, 0);
            this.AdvTreeDataElement.Name = "AdvTreeDataElement";
            this.AdvTreeDataElement.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.RootNode});
            this.AdvTreeDataElement.NodesConnector = this.nodeConnector1;
            this.AdvTreeDataElement.NodeStyle = this.elementStyle1;
            this.AdvTreeDataElement.PathSeparator = ";";
            this.AdvTreeDataElement.Size = new System.Drawing.Size(279, 545);
            this.AdvTreeDataElement.Styles.Add(this.elementStyle1);
            this.AdvTreeDataElement.TabIndex = 0;
            this.AdvTreeDataElement.Text = "advTree1";
            this.AdvTreeDataElement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdvTreeDataElement_MouseMove);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(63, 33);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(128, 26);
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
            this.btnAdd,
            this.btnEdit,
            this.btnRemover,
            this.btnReflesh});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Text = "删除";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnReflesh
            // 
            this.btnReflesh.BeginGroup = true;
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // RootNode
            // 
            this.RootNode.Expanded = true;
            this.RootNode.Name = "RootNode";
            this.RootNode.Text = "数据源";
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
            // UCDataElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdvTreeDataElement);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCDataElement";
            this.Size = new System.Drawing.Size(279, 545);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTreeDataElement)).EndInit();
            this.AdvTreeDataElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree AdvTreeDataElement;
        private DevComponents.AdvTree.Node RootNode;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRemover;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnReflesh;
    }
}
