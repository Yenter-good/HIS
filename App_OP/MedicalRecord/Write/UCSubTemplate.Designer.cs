namespace App_OP.MedicalRecord
{
    partial class UCSubTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSubTemplate));
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.advTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // advTree
            // 
            this.advTree.AllowDrop = true;
            // 
            // 
            // 
            this.advTree.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar.SetContextMenuEx(this.advTree, this.buttonItem1);
            this.advTree.Size = new System.Drawing.Size(231, 519);
            this.advTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.advTree_MouseMove);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
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
            this.tbxSearch.Size = new System.Drawing.Size(231, 23);
            // 
            // UCSubTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCSubTemplate";
            this.Size = new System.Drawing.Size(231, 542);
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.advTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
