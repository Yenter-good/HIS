namespace App_OP.MedicalRecord
{
    partial class UCRecord
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
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucHistory = new App_OP.MedicalRecord.UCHistory();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucSubTemplate = new App_OP.MedicalRecord.UCSubTemplate();
            this.superTabItem = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucModelEssay = new App_OP.MedicalRecord.UCModelEssay();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.ucWrite = new App_OP.MedicalRecord.UCWrite();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
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
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.superTabControl1.Location = new System.Drawing.Point(761, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(265, 644);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem,
            this.superTabItem3});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.ucHistory);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(265, 614);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // ucHistory
            // 
            this.ucHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHistory.Location = new System.Drawing.Point(0, 0);
            this.ucHistory.Name = "ucHistory";
            this.ucHistory.Size = new System.Drawing.Size(265, 614);
            this.ucHistory.TabIndex = 0;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "历史病历";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.ucSubTemplate);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(265, 614);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem;
            // 
            // ucSubTemplate
            // 
            this.ucSubTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSubTemplate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSubTemplate.Location = new System.Drawing.Point(0, 0);
            this.ucSubTemplate.Name = "ucSubTemplate";
            this.ucSubTemplate.Size = new System.Drawing.Size(265, 614);
            this.ucSubTemplate.TabIndex = 0;
            // 
            // superTabItem
            // 
            this.superTabItem.AttachedControl = this.superTabControlPanel2;
            this.superTabItem.GlobalItem = false;
            this.superTabItem.Name = "superTabItem";
            this.superTabItem.Text = "子模板";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.ucModelEssay);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(265, 614);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // ucModelEssay
            // 
            this.ucModelEssay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModelEssay.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucModelEssay.Location = new System.Drawing.Point(0, 0);
            this.ucModelEssay.Name = "ucModelEssay";
            this.ucModelEssay.Size = new System.Drawing.Size(265, 614);
            this.ucModelEssay.TabIndex = 0;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "范文";
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.ucWrite);
            this.pnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(761, 644);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 1;
            // 
            // ucWrite
            // 
            this.ucWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucWrite.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucWrite.Location = new System.Drawing.Point(0, 0);
            this.ucWrite.Name = "ucWrite";
            this.ucWrite.Size = new System.Drawing.Size(761, 644);
            this.ucWrite.TabIndex = 0;
            // 
            // UCRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.superTabControl1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCRecord";
            this.Size = new System.Drawing.Size(1026, 644);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private UCModelEssay ucModelEssay;
        private UCSubTemplate ucSubTemplate;
        private DevComponents.DotNetBar.PanelEx pnl;
        private UCWrite ucWrite;
        private UCHistory ucHistory;
    }
}
