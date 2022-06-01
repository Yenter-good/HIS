namespace HIS.DSkinControl
{
    partial class QLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLoading));
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinPictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.SuspendLayout();
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(54, 22);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(135, 18);
            this.dSkinLabel1.TabIndex = 0;
            this.dSkinLabel1.Text = "数据正在处理请稍后";
            // 
            // dSkinPictureBox1
            // 
            this.dSkinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("dSkinPictureBox1.Image")));
            this.dSkinPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(((System.Drawing.Image)(resources.GetObject("dSkinPictureBox1.Images")))))};
            this.dSkinPictureBox1.Location = new System.Drawing.Point(16, 16);
            this.dSkinPictureBox1.Name = "dSkinPictureBox1";
            this.dSkinPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.dSkinPictureBox1.TabIndex = 1;
            this.dSkinPictureBox1.Text = "dSkinPictureBox1";
            // 
            // QLoading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dSkinPictureBox1);
            this.Controls.Add(this.dSkinLabel1);
            this.DuiBackgroundRender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(211)))));
            this.DuiBackgroundRender.Radius = 5;
            this.DuiBackgroundRender.RenderBorders = true;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "QLoading";
            this.Size = new System.Drawing.Size(211, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox1;
    }
}
