namespace HIS.Core.UI
{
    partial class MsgBox
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemDockContainer1 = new DevComponents.DotNetBar.ItemDockContainer();
            this.lbMsg = new DevComponents.DotNetBar.LabelItem();
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.itemPanel1.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemDockContainer1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(50, 4);
            this.itemPanel1.MultiLine = true;
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(418, 168);
            this.itemPanel1.TabIndex = 7;
            this.itemPanel1.TabStop = false;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemDockContainer1
            // 
            this.itemDockContainer1.Name = "itemDockContainer1";
            this.itemDockContainer1.Stretch = true;
            this.itemDockContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbMsg});
            // 
            // lbMsg
            // 
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Stretch = true;
            this.lbMsg.WordWrap = true;
            // 
            // symbolBox1
            // 
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.symbolBox1.Location = new System.Drawing.Point(0, 4);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(50, 168);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.symbolBox1.TabIndex = 8;
            this.symbolBox1.TabStop = false;
            this.symbolBox1.Text = "symbolBox1";
            // 
            // MsgBox
            // 
            this.AbortBtn.AutoSize = false;
            this.AbortBtn.Enable = true;
            this.AbortBtn.Text = "中止";
            this.AbortBtn.Width = 64;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.Enable = true;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Width = 64;
            this.ClientSize = new System.Drawing.Size(468, 208);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.symbolBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.MaximumSize = new System.Drawing.Size(760, 450);
            this.MinimumSize = new System.Drawing.Size(484, 247);
            this.Name = "MsgBox";
            this.NoBtn.AutoSize = false;
            this.NoBtn.Enable = true;
            this.NoBtn.Text = "否";
            this.NoBtn.Width = 64;
            this.OKBtn.AutoSize = false;
            this.OKBtn.Enable = true;
            this.OKBtn.Text = "确定";
            this.OKBtn.Width = 64;
            this.RetryBtn.AutoSize = false;
            this.RetryBtn.Enable = true;
            this.RetryBtn.Text = "重试";
            this.RetryBtn.Width = 64;
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Controls.SetChildIndex(this.symbolBox1, 0);
            this.Controls.SetChildIndex(this.itemPanel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemDockContainer itemDockContainer1;
        private DevComponents.DotNetBar.LabelItem lbMsg;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
    }
}
