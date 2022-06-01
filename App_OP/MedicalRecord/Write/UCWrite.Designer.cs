namespace App_OP.MedicalRecord
{
    partial class UCWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWrite));
            this.bar = new DevComponents.DotNetBar.Bar();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnPerview = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnFont = new DevComponents.DotNetBar.ButtonItem();
            this.btnSpecialSymbols = new DevComponents.DotNetBar.ButtonItem();
            this.cWrite = new HIS.ControlLib.CWrite();
            this.wcc = new DCSoft.Writer.Commands.WriterCommandControler(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wcc)).BeginInit();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.AntiAlias = true;
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar.IsMaximized = false;
            this.bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSave,
            this.btnPerview,
            this.btnPrint,
            this.btnFont,
            this.btnSpecialSymbols});
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.RoundCorners = false;
            this.bar.Size = new System.Drawing.Size(890, 26);
            this.bar.Stretch = true;
            this.bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar.TabIndex = 0;
            this.bar.TabStop = false;
            this.bar.Text = "bar1";
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "保存(Ctrl+S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPerview
            // 
            this.btnPerview.BeginGroup = true;
            this.btnPerview.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPerview.Image = ((System.Drawing.Image)(resources.GetObject("btnPerview.Image")));
            this.btnPerview.Name = "btnPerview";
            this.btnPerview.Text = "预览";
            this.btnPerview.Click += new System.EventHandler(this.btnPerview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFont
            // 
            this.btnFont.BeginGroup = true;
            this.btnFont.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.wcc.SetCommandName(this.btnFont, "Font");
            this.btnFont.Image = ((System.Drawing.Image)(resources.GetObject("btnFont.Image")));
            this.btnFont.Name = "btnFont";
            this.btnFont.Text = "字体";
            // 
            // btnSpecialSymbols
            // 
            this.btnSpecialSymbols.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSpecialSymbols.Image = ((System.Drawing.Image)(resources.GetObject("btnSpecialSymbols.Image")));
            this.btnSpecialSymbols.Name = "btnSpecialSymbols";
            this.btnSpecialSymbols.Text = "特殊符号";
            this.btnSpecialSymbols.Click += new System.EventHandler(this.btnSpecialSymbols_Click);
            // 
            // cWrite
            // 
            this.cWrite.AllowDrop = true;
            this.cWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cWrite.Location = new System.Drawing.Point(0, 26);
            this.cWrite.Name = "cWrite";
            this.cWrite.Size = new System.Drawing.Size(890, 526);
            this.cWrite.TabIndex = 1;
            this.cWrite.DragDrop += new System.Windows.Forms.DragEventHandler(this.cWrite_DragDrop);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // UCWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cWrite);
            this.Controls.Add(this.bar);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCWrite";
            this.Size = new System.Drawing.Size(890, 552);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar;
        private HIS.ControlLib.CWrite cWrite;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem btnPerview;
        private DevComponents.DotNetBar.ButtonItem btnFont;
        private DevComponents.DotNetBar.ButtonItem btnSpecialSymbols;
        private DCSoft.Writer.Commands.WriterCommandControler wcc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}
