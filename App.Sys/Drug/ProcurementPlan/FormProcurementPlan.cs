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

namespace App_Sys.Drug.ProcurementPlan
{
    public partial class FormProcurementPlan : BaseForm
    {


        private readonly IProcurementPlanService _planService;
        private readonly IInvoiceService _invoiceService;

        public FormProcurementPlan(IProcurementPlanService planService, IInvoiceService invoiceService)
        {
            InitializeComponent();
            this._planService = planService;
            this._invoiceService = invoiceService;
        }
        public FormProcurementPlan()
        {
            InitializeComponent();
        }

        private void FormProcurementPlan_Load(object sender, EventArgs e)
        {
            List<LongItem> typeList = new List<LongItem>();
            typeList.Add(new LongItem(1, "按AI计算规则生成"));
            typeList.Add(new LongItem(2, "按库存下限生成"));
            typeList.Add(new LongItem(3, "按库存上限生成 "));
            cbxType.DataSource = typeList;
            cbxType.DisplayMember = "Value";
            cbxType.ValueMember = "Key";

            dgvMain.AutoGenerateColumns = false; //去除自动绑定列
            dgvMain.AllowUserToAddRows = false;  //去除空白行

            dgvDetail.AutoGenerateColumns = false; //去除自动绑定列
            dgvDetail.AllowUserToAddRows = false;  //去除空白行


            LoadPlan();
        }



        private void LoadPlan()
        {
            List<ProcurementPlanEntity> list = _planService.GetAll();
            dgvMain.DataSource = list;
            if (list.Count > 0) {
                dgvMain.Rows[0].Selected = true;
                ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;
                LoadDetail(entity.Id);
                if (entity.AuditStatus == 0)//计划生成中的单据 可编辑 审核后的不可编辑
                {
                    this.colQuantity.ReadOnly = false;
                }
                else
                {
                    this.colQuantity.ReadOnly = true;
                }
            }
        }

        private void LoadDetail(long id) 
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            List<ProcurementPlanDetailEntity> list = _planService.GetByPlanId(id);
            dgvDetail.DataSource = list;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;

            if (entity.AuditStatus == 1)
            {
                AlertBox.Info("审核完成单据不可删除");
                return;
            }
            DataResult<ProcurementPlanEntity> result = _planService.DeletePlan(entity.Id);
            if (result.Success)
            {
                AlertBox.Info("删除成功");
                LoadPlan();
                dgvDetail.DataSource = null;
            }
            else
            {
                AlertBox.Info("删除失败：" + result.Message);
            }
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;

            if (entity.AuditStatus == 1)
            {
                AlertBox.Info("单据不可再次审核");
                return;
            }

            DataResult<ProcurementPlanEntity> result = _planService.OverPlan(entity.Id);
            if (result.Success)
            {
                AlertBox.Info("审核完成");
                LoadPlan();
            }
            else
            {
                AlertBox.Info("审核失败："+result.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProcurementPlanEntity entity = new ProcurementPlanEntity();
            entity.ReceiptCode = _invoiceService.GetInvoiceNumber(InvoiceType.采购计划单据).Value;
            DataResult<ProcurementPlanEntity> result = _planService.AddPlan(entity);

            if (result.Success)
            {
                AlertBox.Info("新增成功");
                LoadPlan();
            }
            else
            {
                AlertBox.Info("新增失败：" + result.Message);
            }
        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMain.Columns["colAuditStatus"] == null) return;

            if (dgvMain.Columns["colAuditStatus"].Index == e.ColumnIndex)
            {
                e.Value = e.Value.ToString() == "0" ? "计划生成中" : "审核完成";
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;
                LoadDetail(entity.Id);

                if (entity.AuditStatus == 0)//计划生成中的单据 可编辑 审核后的不可编辑
                {
                    this.colQuantity.ReadOnly = false;
                }
                else
                {
                    this.colQuantity.ReadOnly = true;
                }
            }

        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;

            if (e.KeyChar == 13) {

                string searchStr = tbxSearch.Text.Trim();
                List<ProcurementPlanDetailEntity> subList = _planService.GetBySearchStr(entity.Id, searchStr);
                dgvDetail.DataSource = subList;
            }
        }
        
        //按回车后保存采购数量 并且焦点转移到下一行的 采购数量
        private void dgvDetail_SpecialKeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {

                if (dgvDetail.CurrentRow.Index >= dgvDetail.Rows.Count - 1) return;
                dgvDetail.BeginEdit(false);

                int rowIndex = dgvDetail.CurrentRow.Index;
                dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex + 1].Cells["colQuantity"];
                dgvDetail.BeginEdit(true);
            }
            if (e.KeyCode == Keys.Up)
            {
                if (dgvDetail.CurrentRow.Index == 0) return;

                dgvDetail.BeginEdit(false);
                int rowIndex = dgvDetail.CurrentRow.Index;
                dgvDetail.CurrentCell = this.dgvDetail.Rows[rowIndex - 1].Cells["colQuantity"];
                dgvDetail.BeginEdit(true);
            }

        }
        //结束编辑状态时 保存采购数量
        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProcurementPlanDetailEntity entity = dgvDetail.CurrentRow.DataBoundItem as ProcurementPlanDetailEntity;

            if (entity.Quantity < 1) return;

            DataResult<ProcurementPlanDetailEntity> result = _planService.UpdateDetailQuantity(entity.Id, entity.Quantity);
            if (!result.Success)
                AlertBox.Error(result.Message);
        }


        private void dgvDetail_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1 );
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }

            ProcurementPlanEntity entity = dgvMain.CurrentRow.DataBoundItem as ProcurementPlanEntity;
            int type = cbxType.SelectedValue.AsInt(0);
            DataResult result = _planService.FillQuantity(entity.Id, type);

            if (result.Success)
            {
                LoadPlan();
            }
            else
            {
                AlertBox.Error(result.Message);
            }
        }
    }
}
