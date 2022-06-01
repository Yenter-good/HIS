using HIS.Core.UI;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using HIS.Service.Core.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core;
using DevComponents.DotNetBar.SuperGrid;
using HIS.DSkinControl;

namespace App_Sys.Drug.MerchantsManager
{
    public partial class FromSupplierManager : BaseForm
    {
        private readonly IIdService _idService;
        private readonly IMerchantsService _merchantsService;
        public FromSupplierManager(IIdService idService, IMerchantsService merchantsService)
        {
            InitializeComponent();
            this._idService = idService;
            this._merchantsService = merchantsService;
        }
        public FromSupplierManager()
        {
            InitializeComponent();
        }
        private void FromSupplierManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormMerchantsEdit dialog = new FormMerchantsEdit();
            dialog.Operation = HIS.Service.Core.Enums.DataOperation.New;
            dialog.merchantType = HIS.Service.Core.Enums.MerchantType.供应厂商;
            dialog.New += (x, y) =>
            {
                GridRow row = this.dgvMain.PrimaryGrid.NewRow(true);
                var merchant = row.DataItem as MerchantsEntity;
                merchant.Id = y.Id;
                merchant.Name = y.Name;
                merchant.SearchCode = y.SearchCode;
                merchant.WubiCode = y.WubiCode;
                merchant.Address = y.Address;
                merchant.LegalPerson = y.LegalPerson;
                merchant.PhoneNo = y.PhoneNo;
                merchant.No = y.No;
                merchant.BusinessLicense = y.BusinessLicense;
                merchant.Type = y.Type;
                merchant.DataStatus = y.DataStatus;

                if (!row.IsOnScreen)
                    row.EnsureVisible();
                row.IsSelected = true;
            };
            DialogResult dialogResult = dialog.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.PrimaryGrid.SelectedRowCount == 0)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            var row = this.dgvMain.PrimaryGrid.GetSelectedRows()[0] as GridRow;
            FormMerchantsEdit frm = new FormMerchantsEdit();
            frm.Operation = HIS.Service.Core.Enums.DataOperation.Modify;
            frm._entity = row.DataItem as MerchantsEntity;

            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                row.ResolveRow();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.PrimaryGrid.SelectedRowCount == 0)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            if (MsgBox.YesNo("是否删除") != DialogResult.Yes) return;
            var row = this.dgvMain.PrimaryGrid.GetSelectedRows()[0] as GridRow;
            var entity = row.DataItem as MerchantsEntity;
            var result = this._merchantsService.DeleteMerchants(entity.Id);
            if (result.Success)
            {
                this.dgvMain.PrimaryGrid.Rows.Remove(row);
                AlertBox.Info("删除成功");
            }
            else
            {
                AlertBox.Error(result.Message);
            }


        }

        private void dgvMain_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            this.btnEdit_Click(null, null);
        }
        private void LoadData()
        {
            this.ShowMask(() =>
            {
                List<MerchantsEntity> list = this._merchantsService.GetAllManufacturer();
                this.dgvMain.PrimaryGrid.DataSource = list;
            });
        }
    }
}
