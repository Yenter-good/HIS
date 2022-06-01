using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Sys.Drug.MerchantsManager
{
    /// <summary>
    /// 生产厂家维护
    /// </summary>
    public partial class FromManufacturerManager : BaseForm
    {
        /// <summary>
        /// ID服务
        /// </summary>
        private readonly IIdService _idService;
        /// <summary>
        /// 药品生产厂家厂商服务
        /// </summary>
        private readonly IMerchantsService _merchantsService;
        public FromManufacturerManager(IIdService idService, IMerchantsService merchantsService)
        {
            InitializeComponent();

            //初始化服务
            this._idService = idService;
            this._merchantsService = merchantsService;

            //设置dgve
            this.dgvMain.PrimaryGrid.UseAlternateRowStyle = true;
        }

        #region 窗体事件
        private void FromManufacturerManager_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormMerchantsEdit dialog = new FormMerchantsEdit();
            dialog.Operation = HIS.Service.Core.Enums.DataOperation.New;
            dialog.merchantType = HIS.Service.Core.Enums.MerchantType.生产厂家;
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
                //this.dgvMain.PrimaryGrid.Rows.Remove(row);
                row.IsDeleted = true;
                this.dgvMain.PrimaryGrid.PurgeDeletedRows();
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
        #endregion

        #region 方法
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            this.ShowMask(() =>
            {
                List<MerchantsEntity> list = this._merchantsService.GetAllManufacturer();
                this.dgvMain.PrimaryGrid.DataSource = list;
            });
        }
        #endregion
    }
}
