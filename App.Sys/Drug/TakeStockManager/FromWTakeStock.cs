using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Entities.Drug;
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

namespace App_Sys.Drug
{
    public partial class FromWTakeStock : BaseForm
    {
        private readonly IWarehouspitalTakeStockService _takeStockService;
        private readonly IPharmacyTakeStockService _smallStockService;
        private readonly IInvoiceService _invoiceService;
        private int _type = 0;//0药库盘点 1药房盘点
        public FromWTakeStock()
        {
            InitializeComponent();
        }
        public FromWTakeStock(IWarehouspitalTakeStockService takeStockService, IPharmacyTakeStockService smallStockService,IInvoiceService invoiceService)
        {
            InitializeComponent();
            this._takeStockService = takeStockService;
            this._invoiceService = invoiceService;
            this._smallStockService = smallStockService;
        }
        private void FromWTakeStock_Shown(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Today.AddDays(-3);
            dtEnd.Value = DateTime.Today;

            dgvMain.AutoGenerateColumns = false; //去除自动绑定列
            dgvMain.AllowUserToAddRows = false;  //去除空白行

            if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMWarehouse || ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMWarehouse)
            {
                _type = 0;
            }
            else {
                _type = 1;
            }

            LoadData();
        }
      

        private void LoadData()
        {
            DateTime startTime = dtStart.Value;
            DateTime endTime = dtEnd.Value.AddDays(1);
            List<TakeStockEntity> list = new List<TakeStockEntity>();
            if (this._type == 0)
            {
                list = _takeStockService.GetByDate(this.ViewData.Dept.Id, startTime, endTime);
            }
            else
            {
                list = _smallStockService.GetByDate(this.ViewData.Dept.Id, startTime, endTime);
            }
            
            this.dgvMain.DataSource = list;
        }
        protected override void OnDeptChanged()
        {
            if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMWarehouse || ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMWarehouse)
            {
                _type = 0;
            }
            else
            {
                _type = 1;
            }
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TakeStockEntity entity = new TakeStockEntity();

            entity.DeptId = ViewData.Dept.Id;
            if (this.dgvMain.Rows.Count < 1)
            {
                entity.BeginAmount = 0;
            }
            else
            {
               var lastTakeStock = this.dgvMain.Rows[0].DataBoundItem as TakeStockEntity;
                entity.BeginAmount = lastTakeStock.EndAmount;
            }

            entity.ReceiptCode = _invoiceService.GetInvoiceNumber(InvoiceType.盘点单).Value;

            DataResult<TakeStockEntity> result = null;
            if (_type == 0)
            {
                result = _takeStockService.AddTakeStock(this.ViewData.Dept.Id, entity);
            }
            else 
            {
                result = _smallStockService.AddTakeStock(this.ViewData.Dept.Id, entity);
            }


            if (result.Success)
            {
                FormTakeStockDetails frm = new FormTakeStockDetails();
                frm.editModel = "add";
                frm.entity = result.Value;
                frm._type = _type;

                DialogResult dialogResult = frm.ShowDialog();
                if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
                {
                    LoadData();
                }
            }
            else
            {
                AlertBox.Error(result.Message);
            }

        }

  

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            FormTakeStockDetails frm = new FormTakeStockDetails();
            frm.editModel = "edit";
            frm._type = _type;
            frm.entity = this.dgvMain.CurrentRow.DataBoundItem as TakeStockEntity;

            DialogResult result = frm.ShowDialog();
           

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var entity = this.dgvMain.CurrentRow.DataBoundItem as TakeStockEntity;
            DataResult<TakeStockEntity> result = null;
            if (_type == 0)
            {
                result = _takeStockService.DeleteTakeStock(entity.Id);
            }
            else
            {
                result = _smallStockService.DeleteTakeStock(entity.Id);
            }


            if (result.Success)
            {
                LoadData();
            }
            else {
                AlertBox.Error(result.Message);
            }
        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMain.Columns["colAuditStatus"] == null) return;

            if (dgvMain.Columns["colAuditStatus"].Index == e.ColumnIndex)
            {
                e.Value = e.Value.ToString() == "0" ? "盘点中" : "审核完成";
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormTakeStockDetails frm = new FormTakeStockDetails();
            frm.editModel = "edit";
            frm._type = _type;
            frm.entity = this.dgvMain.CurrentRow.DataBoundItem as TakeStockEntity;

            DialogResult result = frm.ShowDialog();
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var entity = this.dgvMain.CurrentRow.DataBoundItem as TakeStockEntity;

            if (entity.AuditStatus != 0)
            {
                AlertBox.Info("不可重复审核");
                return;
            }
            DialogResult dialogResult = MsgBox.YesNo("审核成功后会更改相应库存信息且不可逆操作，是否确认审核？", "警告提示");

            if (dialogResult == DialogResult.Yes)
            {
                DataResult<TakeStockEntity> result = _takeStockService.OverTakeStock(entity.Id);

                if (result.Success)
                {
                    LoadData();
                }
                else
                {
                    AlertBox.Error(result.Message);
                }
            }
        }
    }
}
