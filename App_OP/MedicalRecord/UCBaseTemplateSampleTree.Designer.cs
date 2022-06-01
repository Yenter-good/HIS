namespace App_OP.MedicalRecord
{
    partial class UCBaseTemplateSampleTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBaseTemplateSampleTree));
            this.advTree = new DevComponents.AdvTree.AdvTree();
            this.contextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tbxSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.advTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // advTree
            // 
            this.advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree.AllowDrop = false;
            this.advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar.SetContextMenuEx(this.advTree, this.buttonItem1);
            this.advTree.Controls.Add(this.contextMenuBar);
            this.advTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree.Location = new System.Drawing.Point(0, 23);
            this.advTree.Name = "advTree";
            this.advTree.NodesConnector = this.nodeConnector1;
            this.advTree.NodeStyle = this.elementStyle1;
            this.advTree.PathSeparator = ";";
            this.advTree.Size = new System.Drawing.Size(274, 718);
            this.advTree.Styles.Add(this.elementStyle1);
            this.advTree.TabIndex = 0;
            this.advTree.Text = "advTree1";
            // 
            // contextMenuBar
            // 
            this.contextMenuBar.AntiAlias = true;
            this.contextMenuBar.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar.IsMaximized = false;
            this.contextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar.Location = new System.Drawing.Point(66, 271);
            this.contextMenuBar.Name = "contextMenuBar";
            this.contextMenuBar.Size = new System.Drawing.Size(124, 26);
            this.contextMenuBar.Stretch = true;
            this.contextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar.TabIndex = 0;
            this.contextMenuBar.TabStop = false;
            this.contextMenuBar.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReflesh});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
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
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Open_16x16.png");
            this.imageList.Images.SetKeyName(1, "TextBox_16x16.png");
            // 
            // tbxSearch
            // 
            // 
            // 
            // 
            this.tbxSearch.Border.Class = "TextBoxBorder";
            this.tbxSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSearch.Location = new System.Drawing.Point(0, 0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PreventEnterBeep = true;
            this.tbxSearch.Size = new System.Drawing.Size(274, 23);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.WatermarkText = "请输入名称、拼音码、五笔码检索";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // UCBaseTemplateSampleTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.advTree);
            this.Controls.Add(this.tbxSearch);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCBaseTemplateSampleTree";
            this.Size = new System.Drawing.Size(274, 741);
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.advTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.AdvTree.NodeConnector nodeConnector1;
        public DevComponents.DotNetBar.ElementStyle elementStyle1;
        public System.Windows.Forms.ImageList imageList;
        public DevComponents.AdvTree.AdvTree advTree;
        public DevComponents.DotNetBar.ContextMenuBar contextMenuBar;
        public DevComponents.DotNetBar.ButtonItem buttonItem1;
        public DevComponents.DotNetBar.ButtonItem btnReflesh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearch;
    }
}
