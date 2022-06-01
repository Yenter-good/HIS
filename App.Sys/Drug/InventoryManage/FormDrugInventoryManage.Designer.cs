
namespace App_Sys.Drug.InventoryManage
{
    partial class FormDrugInventoryManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabPharmacyInInventory = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabWarehouseInInventory = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabPharmacyOutInventory = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabWarehouseOutInventory = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tabError = new DevComponents.DotNetBar.SuperTabItem();
            this.tabChangeInventory = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tabMain.Controls.Add(this.superTabControlPanel6);
            this.tabMain.Controls.Add(this.superTabControlPanel3);
            this.tabMain.Controls.Add(this.superTabControlPanel1);
            this.tabMain.Controls.Add(this.superTabControlPanel2);
            this.tabMain.Controls.Add(this.superTabControlPanel5);
            this.tabMain.Controls.Add(this.superTabControlPanel4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.ReorderTabsEnabled = false;
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1136, 716);
            this.tabMain.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.TabIndex = 0;
            this.tabMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabWarehouseInInventory,
            this.tabPharmacyInInventory,
            this.tabWarehouseOutInventory,
            this.tabPharmacyOutInventory,
            this.tabChangeInventory,
            this.tabError});
            this.tabMain.TabsVisible = false;
            this.tabMain.Text = "superTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabPharmacyInInventory;
            // 
            // tabPharmacyInInventory
            // 
            this.tabPharmacyInInventory.AttachedControl = this.superTabControlPanel2;
            this.tabPharmacyInInventory.GlobalItem = false;
            this.tabPharmacyInInventory.Name = "tabPharmacyInInventory";
            this.tabPharmacyInInventory.Text = "药房入库";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabWarehouseInInventory;
            // 
            // tabWarehouseInInventory
            // 
            this.tabWarehouseInInventory.AttachedControl = this.superTabControlPanel1;
            this.tabWarehouseInInventory.GlobalItem = false;
            this.tabWarehouseInInventory.Name = "tabWarehouseInInventory";
            this.tabWarehouseInInventory.Text = "药库入库";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.tabPharmacyOutInventory;
            // 
            // tabPharmacyOutInventory
            // 
            this.tabPharmacyOutInventory.AttachedControl = this.superTabControlPanel5;
            this.tabPharmacyOutInventory.GlobalItem = false;
            this.tabPharmacyOutInventory.Name = "tabPharmacyOutInventory";
            this.tabPharmacyOutInventory.Text = "药房出库";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.tabWarehouseOutInventory;
            // 
            // tabWarehouseOutInventory
            // 
            this.tabWarehouseOutInventory.AttachedControl = this.superTabControlPanel4;
            this.tabWarehouseOutInventory.GlobalItem = false;
            this.tabWarehouseOutInventory.Name = "tabWarehouseOutInventory";
            this.tabWarehouseOutInventory.Text = "药库出库";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.panelEx1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tabError;
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(363, 243);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(411, 201);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "当前科室非药库药房\r\n无法入库管理";
            // 
            // tabError
            // 
            this.tabError.AttachedControl = this.superTabControlPanel3;
            this.tabError.GlobalItem = false;
            this.tabError.Name = "tabError";
            this.tabError.Text = "科室错误";
            // 
            // tabChangeInventory
            // 
            this.tabChangeInventory.AttachedControl = this.superTabControlPanel6;
            this.tabChangeInventory.GlobalItem = false;
            this.tabChangeInventory.Name = "tabChangeInventory";
            this.tabChangeInventory.Text = "库存调整";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(1136, 686);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.tabChangeInventory;
            // 
            // FormDrugInventoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 716);
            this.Controls.Add(this.tabMain);
            this.Name = "FormDrugInventoryManage";
            this.Text = "";
            this.Shown += new System.EventHandler(this.FormDrugInventoryManage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl tabMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabWarehouseInInventory;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabPharmacyInInventory;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.SuperTabItem tabError;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem tabPharmacyOutInventory;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem tabWarehouseOutInventory;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private DevComponents.DotNetBar.SuperTabItem tabChangeInventory;
    }
}