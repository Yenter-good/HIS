
namespace App_OP.Prescription
{
    partial class UCEditPrescription
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
            this.ucwmPrescription1 = new App_OP.Prescription.UCWMPrescription();
            this.tabMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.uchmPrescriptionGranules = new App_OP.Prescription.UCHMPrescription();
            this.tabHMGranules = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.uchmPrescription1 = new App_OP.Prescription.UCHMPrescription();
            this.tabHM = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabWM = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabItem = new DevComponents.DotNetBar.SuperTabItem();
            this.ucItemPrescription1 = new App_OP.Prescription.UCItemPrescription();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucwmPrescription1
            // 
            this.ucwmPrescription1.Dept = null;
            this.ucwmPrescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucwmPrescription1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucwmPrescription1.Location = new System.Drawing.Point(0, 0);
            this.ucwmPrescription1.MainDiagnosis = null;
            this.ucwmPrescription1.Name = "ucwmPrescription1";
            this.ucwmPrescription1.Outpatient = null;
            this.ucwmPrescription1.Size = new System.Drawing.Size(1077, 418);
            this.ucwmPrescription1.TabIndex = 6;
            // 
            // tabMain
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabMain.ControlBox.MenuBox.Name = "";
            this.tabMain.ControlBox.Name = "";
            this.tabMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMain.ControlBox.MenuBox,
            this.tabMain.ControlBox.CloseBox});
            this.tabMain.ControlBox.Visible = false;
            this.tabMain.Controls.Add(this.superTabControlPanel3);
            this.tabMain.Controls.Add(this.superTabControlPanel4);
            this.tabMain.Controls.Add(this.superTabControlPanel1);
            this.tabMain.Controls.Add(this.superTabControlPanel2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.ReorderTabsEnabled = true;
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1077, 448);
            this.tabMain.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.TabIndex = 7;
            this.tabMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabWM,
            this.tabHM,
            this.tabHMGranules,
            this.tabItem});
            this.tabMain.Text = "superTabControl1";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.uchmPrescriptionGranules);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(1077, 418);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.tabHMGranules;
            // 
            // uchmPrescriptionGranules
            // 
            this.uchmPrescriptionGranules.Dept = null;
            this.uchmPrescriptionGranules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uchmPrescriptionGranules.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uchmPrescriptionGranules.GranulesEditor = App_OP.Prescription.HMPrescriptionEditor.颗粒剂;
            this.uchmPrescriptionGranules.Location = new System.Drawing.Point(0, 0);
            this.uchmPrescriptionGranules.MainDiagnosis = null;
            this.uchmPrescriptionGranules.Name = "uchmPrescriptionGranules";
            this.uchmPrescriptionGranules.Outpatient = null;
            this.uchmPrescriptionGranules.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uchmPrescriptionGranules.Size = new System.Drawing.Size(1077, 418);
            this.uchmPrescriptionGranules.TabIndex = 1;
            // 
            // tabHMGranules
            // 
            this.tabHMGranules.AttachedControl = this.superTabControlPanel4;
            this.tabHMGranules.GlobalItem = false;
            this.tabHMGranules.Name = "tabHMGranules";
            this.tabHMGranules.Text = "颗粒剂";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.uchmPrescription1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1077, 418);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabHM;
            // 
            // uchmPrescription1
            // 
            this.uchmPrescription1.Dept = null;
            this.uchmPrescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uchmPrescription1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uchmPrescription1.GranulesEditor = App_OP.Prescription.HMPrescriptionEditor.颗粒剂;
            this.uchmPrescription1.Location = new System.Drawing.Point(0, 0);
            this.uchmPrescription1.MainDiagnosis = null;
            this.uchmPrescription1.Name = "uchmPrescription1";
            this.uchmPrescription1.Outpatient = null;
            this.uchmPrescription1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uchmPrescription1.Size = new System.Drawing.Size(1077, 418);
            this.uchmPrescription1.TabIndex = 0;
            // 
            // tabHM
            // 
            this.tabHM.AttachedControl = this.superTabControlPanel2;
            this.tabHM.GlobalItem = false;
            this.tabHM.Name = "tabHM";
            this.tabHM.Text = "草药";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.ucwmPrescription1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1077, 418);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabWM;
            // 
            // tabWM
            // 
            this.tabWM.AttachedControl = this.superTabControlPanel1;
            this.tabWM.GlobalItem = false;
            this.tabWM.Name = "tabWM";
            this.tabWM.Text = "西(中成)药";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.ucItemPrescription1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(1077, 418);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tabItem;
            // 
            // tabItem
            // 
            this.tabItem.AttachedControl = this.superTabControlPanel3;
            this.tabItem.GlobalItem = false;
            this.tabItem.Name = "tabItem";
            this.tabItem.Text = "诊疗与材料";
            // 
            // ucItemPrescription1
            // 
            this.ucItemPrescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucItemPrescription1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucItemPrescription1.Location = new System.Drawing.Point(0, 0);
            this.ucItemPrescription1.Name = "ucItemPrescription1";
            this.ucItemPrescription1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ucItemPrescription1.Size = new System.Drawing.Size(1077, 418);
            this.ucItemPrescription1.TabIndex = 0;
            // 
            // UCEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCEditPrescription";
            this.Size = new System.Drawing.Size(1077, 448);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCWMPrescription ucwmPrescription1;
        private DevComponents.DotNetBar.SuperTabControl tabMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabWM;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem tabItem;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabHM;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem tabHMGranules;
        private UCHMPrescription uchmPrescriptionGranules;
        private UCHMPrescription uchmPrescription1;
        private UCItemPrescription ucItemPrescription1;
    }
}
