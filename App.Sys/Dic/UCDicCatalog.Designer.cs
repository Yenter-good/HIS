namespace App_Sys.Dic
{
    partial class UCDicCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDicCatalog));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.DicTree = new DevComponents.AdvTree.AdvTree();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddCatalog = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddOnCatalog = new DevComponents.DotNetBar.ButtonItem();
            this.btnRenameCatalog = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddDic = new DevComponents.DotNetBar.ButtonItem();
            this.btnRenameDic = new DevComponents.DotNetBar.ButtonItem();
            this.btnEditDic = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemoverDic = new DevComponents.DotNetBar.ButtonItem();
            this.btnStopDic = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartDic = new DevComponents.DotNetBar.ButtonItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.delaytbxInput = new HIS.ControlLib.DelayTextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicTree)).BeginInit();
            this.DicTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.DicTree);
            this.panelEx1.Controls.Add(this.delaytbxInput);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(258, 601);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // DicTree
            // 
            this.DicTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.DicTree.AllowDrop = false;
            this.DicTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DicTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.DicTree.BackgroundStyle.Class = "TreeBorderKey";
            this.DicTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar1.SetContextMenuEx(this.DicTree, this.btnMenu);
            this.DicTree.Controls.Add(this.contextMenuBar1);
            this.DicTree.Location = new System.Drawing.Point(3, 26);
            this.DicTree.Name = "DicTree";
            this.DicTree.NodesConnector = this.nodeConnector1;
            this.DicTree.NodeStyle = this.elementStyle1;
            this.DicTree.PathSeparator = ";";
            this.DicTree.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.DicTree.Size = new System.Drawing.Size(252, 572);
            this.DicTree.Styles.Add(this.elementStyle1);
            this.DicTree.TabIndex = 1;
            this.DicTree.Text = "advTree1";
            this.DicTree.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.advTree_AfterCellEdit);
            this.DicTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree_AfterNodeSelect);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(249, 26);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 0;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReflesh,
            this.btnAddCatalog,
            this.btnAddOnCatalog,
            this.btnRenameCatalog,
            this.btnAddDic,
            this.btnRenameDic,
            this.btnEditDic,
            this.btnRemoverDic,
            this.btnStopDic,
            this.btnStartDic});
            this.btnMenu.Text = "右键菜单";
            this.btnMenu.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.btnMenu_PopupOpen);
            // 
            // btnReflesh
            // 
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // btnAddCatalog
            // 
            this.btnAddCatalog.BeginGroup = true;
            this.btnAddCatalog.Name = "btnAddCatalog";
            this.btnAddCatalog.Text = "添加目录";
            this.btnAddCatalog.Click += new System.EventHandler(this.btnAddCatalog_Click);
            // 
            // btnAddOnCatalog
            // 
            this.btnAddOnCatalog.Name = "btnAddOnCatalog";
            this.btnAddOnCatalog.Text = "添加一级目录";
            this.btnAddOnCatalog.Click += new System.EventHandler(this.btnAddOnCatalog_Click);
            // 
            // btnRenameCatalog
            // 
            this.btnRenameCatalog.Name = "btnRenameCatalog";
            this.btnRenameCatalog.Text = "重命名";
            this.btnRenameCatalog.Click += new System.EventHandler(this.btnRenameCatalog_Click);
            // 
            // btnAddDic
            // 
            this.btnAddDic.BeginGroup = true;
            this.btnAddDic.Name = "btnAddDic";
            this.btnAddDic.Text = "添加字典";
            this.btnAddDic.Click += new System.EventHandler(this.btnAddDic_Click);
            // 
            // btnRenameDic
            // 
            this.btnRenameDic.Name = "btnRenameDic";
            this.btnRenameDic.Text = "重命名";
            this.btnRenameDic.Click += new System.EventHandler(this.btnRenameDic_Click);
            // 
            // btnEditDic
            // 
            this.btnEditDic.Name = "btnEditDic";
            this.btnEditDic.Text = "修改字典";
            this.btnEditDic.Click += new System.EventHandler(this.btnEditDic_Click);
            // 
            // btnRemoverDic
            // 
            this.btnRemoverDic.Name = "btnRemoverDic";
            this.btnRemoverDic.Text = "删除字典";
            this.btnRemoverDic.Click += new System.EventHandler(this.btnRemoverDic_Click);
            // 
            // btnStopDic
            // 
            this.btnStopDic.Name = "btnStopDic";
            this.btnStopDic.Text = "停用字典";
            this.btnStopDic.Click += new System.EventHandler(this.btnStopDic_Click);
            // 
            // btnStartDic
            // 
            this.btnStartDic.Name = "btnStartDic";
            this.btnStartDic.Text = "启用字典";
            this.btnStartDic.Click += new System.EventHandler(this.btnStartDic_Click);
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
            // delaytbxInput
            // 
            this.delaytbxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.delaytbxInput.Border.Class = "TextBoxBorder";
            this.delaytbxInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delaytbxInput.DelayTime = 200;
            this.delaytbxInput.Location = new System.Drawing.Point(3, 3);
            this.delaytbxInput.MarkString = null;
            this.delaytbxInput.Name = "delaytbxInput";
            this.delaytbxInput.PreventEnterBeep = true;
            this.delaytbxInput.Size = new System.Drawing.Size(252, 21);
            this.delaytbxInput.TabIndex = 0;
            this.delaytbxInput.WatermarkText = "输入拼音码、名称检索";
            this.delaytbxInput.TextChanged += new System.EventHandler(this.delaytbxInput_TextChanged);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Open_16x16.png");
            this.imgList.Images.SetKeyName(1, "TextBox_16x16.png");
            // 
            // UCDicCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "UCDicCatalog";
            this.Size = new System.Drawing.Size(258, 601);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DicTree)).EndInit();
            this.DicTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private HIS.ControlLib.DelayTextBox delaytbxInput;
        private DevComponents.AdvTree.AdvTree DicTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAddCatalog;
        private DevComponents.DotNetBar.ButtonItem btnAddDic;
        private DevComponents.DotNetBar.ButtonItem btnEditDic;
        private DevComponents.DotNetBar.ButtonItem btnRemoverDic;
        private DevComponents.DotNetBar.ButtonItem btnStopDic;
        private DevComponents.DotNetBar.ButtonItem btnStartDic;
        private DevComponents.DotNetBar.ButtonItem btnReflesh;
        private DevComponents.DotNetBar.ButtonItem btnRenameCatalog;
        private DevComponents.DotNetBar.ButtonItem btnRenameDic;
        private DevComponents.DotNetBar.ButtonItem btnAddOnCatalog;
        private System.Windows.Forms.ImageList imgList;
    }
}
