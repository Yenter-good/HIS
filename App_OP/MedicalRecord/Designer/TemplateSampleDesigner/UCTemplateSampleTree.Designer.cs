namespace App_OP.MedicalRecord
{
    partial class UCTemplateSampleTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTemplateSampleTree));
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.btnReName = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemover = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.advTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.Images.SetKeyName(0, "Open_16x16.png");
            this.imageList.Images.SetKeyName(1, "TextBox_16x16.png");
            // 
            // advTree
            // 
            // 
            // 
            // 
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar.SetContextMenuEx(this.advTree, this.buttonItem1);
            this.advTree.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.advTree_AfterCellEdit);
            this.advTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree_AfterNodeSelect);
            // 
            // contextMenuBar
            // 
            this.contextMenuBar.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.contextMenuBar_PopupOpen);
            // 
            // buttonItem1
            // 
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReName,
            this.btnRemover,
            this.btnAddGroup,
            this.btnAddTemplate});
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BeginGroup = true;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Text = "添加目录";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Text = "添加范文";
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnReName
            // 
            this.btnReName.Name = "btnReName";
            this.btnReName.Text = "重命名";
            this.btnReName.Click += new System.EventHandler(this.btnReName_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Text = "删除";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // UCTemplateSampleTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCTemplateSampleTree";
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.advTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnAddGroup;
        private DevComponents.DotNetBar.ButtonItem btnAddTemplate;
        private DevComponents.DotNetBar.ButtonItem btnReName;
        private DevComponents.DotNetBar.ButtonItem btnRemover;
    }
}
