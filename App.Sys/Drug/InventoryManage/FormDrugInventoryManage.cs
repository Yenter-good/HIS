using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Sys.Drug.InventoryManage
{
    public partial class FormDrugInventoryManage : BaseForm
    {
        public FormDrugInventoryManage()
        {
            InitializeComponent();
        }

        protected override void OnDeptChanged()
        {
            ChangeTabByDept();

            base.OnDeptChanged();
        }

        private void ChangeTabByDept()
        {
            if (this.CreateParame == "ChangeInventory")
            {
                var uc = new UCChangeInventory();
                uc.Dock = DockStyle.Fill;
                this.tabChangeInventory.AttachedControl.Controls.Add(uc);
                this.tabMain.SelectedTab = this.tabChangeInventory;
            }
            else if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMPharmacy || ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMPharmacy)
            {
                if (this.CreateParame == "InInventory")
                {
                    var uc = new UCPharmacyInInventory();
                    uc.Dock = DockStyle.Fill;
                    this.tabPharmacyInInventory.AttachedControl.Controls.Add(uc);
                    this.tabMain.SelectedTab = this.tabPharmacyInInventory;
                }
                else
                {
                    var uc = new UCPharmacyOutInventory();
                    uc.Dock = DockStyle.Fill;
                    this.tabPharmacyOutInventory.AttachedControl.Controls.Add(uc);
                    this.tabMain.SelectedTab = this.tabPharmacyOutInventory;
                }
            }
            else if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMWarehouse || ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMWarehouse)
            {
                if (this.CreateParame == "InInventory")
                {
                    var uc = new UCWarehouseInInventory();
                    uc.Dock = DockStyle.Fill;
                    this.tabWarehouseInInventory.AttachedControl.Controls.Add(uc);
                    this.tabMain.SelectedTab = this.tabWarehouseInInventory;
                }
                else
                {
                    var uc = new UCWarehouseOutInventory();
                    uc.Dock = DockStyle.Fill;
                    this.tabWarehouseOutInventory.AttachedControl.Controls.Add(uc);
                    this.tabMain.SelectedTab = this.tabWarehouseOutInventory;
                }
            }
            else
                this.tabMain.SelectedTab = this.tabError;

            if (this.tabMain.SelectedTab.AttachedControl.Controls.Count > 0)
            {
                var control = this.tabMain.SelectedTab.AttachedControl.Controls[0] as IUCInit;
                if (control != null)
                {
                    control.ViewData = this.ViewData;
                    control.Init();
                }
            }
        }

        private void FormDrugInventoryManage_Shown(object sender, EventArgs e)
        {
            if (this.CreateParame == "OutInventory")
                this.Text = "药品出库管理";
            else if (this.CreateParame == "InInventory")
                this.Text = "药品入库管理";
            else if (this.CreateParame == "ChangeInventory")
                this.Text = "库存管理";

            ChangeTabByDept();
        }
    }
}
