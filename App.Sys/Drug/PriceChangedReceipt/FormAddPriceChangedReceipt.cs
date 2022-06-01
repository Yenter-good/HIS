using HIS.Core.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Core;
using HIS.Utility.Win32;
using HIS.DSkinControl;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace App_Sys.Drug
{
    public partial class FormAddPriceChangedReceipt : BaseForm
    {
        /// <summary>
        /// 药品调价单据服务
        /// </summary>
        private readonly IPriceChangedReceiptService _priceChangedReceiptService;
        /// <summary>
        /// 发票流水号服务
        /// </summary>
        private readonly IInvoiceService _invoiceService;
        /// <summary>
        /// 字典服务
        /// </summary>
        private readonly ISysDictQueryService _sysDictQueryService;
        /// <summary>
        /// ID服务
        /// </summary>
        private readonly IIdService _idService;
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 调价单据
        /// </summary>
        public PriceChangedReceiptEntity Receipt { get; set; }
        /// <summary>
        /// 操作模式
        /// </summary>
        public DataOperation Operation { get; set; }
        /// <summary>
        /// 可检索的药品
        /// </summary>
        private List<DrugInventoryEntity> _allDrugEntities;

        public FormAddPriceChangedReceipt(IPriceChangedReceiptService priceChangedReceiptService
            , IInvoiceService invoiceService
            , ISysDictQueryService sysDictQueryService
            , IIdService idService)
        {
            InitializeComponent();

            this._priceChangedReceiptService = priceChangedReceiptService;
            this._invoiceService = invoiceService;
            this._sysDictQueryService = sysDictQueryService;
            this._idService = idService;

            this.colNewPrice.Digits = 4;
            this.colRealTimePrice.Digits = 4;
            this.dgvDrugFilter.AutoGenerateColumns = false;
        }

        #region 初始化

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (this.Dept.CategoryDetail == DeptCategoryDetail.WMWarehouse)
                this._allDrugEntities = this._priceChangedReceiptService.GetAllWarehouseDrugInfo(DrugType.西药, Dept.Id);
            else if (this.Dept.CategoryDetail == DeptCategoryDetail.HMWarehouse)
            {
                this._allDrugEntities = this._priceChangedReceiptService.GetAllWarehouseDrugInfo(DrugType.草药, Dept.Id);
                this._allDrugEntities.AddRange(this._priceChangedReceiptService.GetAllWarehouseDrugInfo(DrugType.颗粒剂, Dept.Id));
            }
            else if (this.Dept.CategoryDetail == DeptCategoryDetail.WMPharmacy)
                this._allDrugEntities = this._priceChangedReceiptService.GetAllPharmacyDrugInfo(DrugType.西药, Dept.Id);
            else if (this.Dept.CategoryDetail == DeptCategoryDetail.HMPharmacy)
            {
                this._allDrugEntities = this._priceChangedReceiptService.GetAllPharmacyDrugInfo(DrugType.草药, Dept.Id);
                this._allDrugEntities.AddRange(this._priceChangedReceiptService.GetAllPharmacyDrugInfo(DrugType.颗粒剂, Dept.Id));
            }
            else
            {
                MsgBox.OK("药库药房对应信息出现问题,无法打开窗口");
                base.Close();
            }
        }
        /// <summary>
        /// 初始化界面显示
        /// </summary>
        private void InitUI()
        {
            this.dgvDrugFilter.Container = new HIS.ControlLib.Container(this.dgvDrugs, this.colName);

            //加载调价原因
            var pricChangeMemos = this._sysDictQueryService.GetPiceChangeMemoType();
            this.cbxMemo.DisplayMember = nameof(LongItem.Value);
            this.cbxMemo.ValueMember = nameof(LongItem.Key);
            this.cbxMemo.DataSource = pricChangeMemos;
            this.cbxMemo.SelectedIndex = -1;
            //设置计划生效日期
            this.dtpPlanEffectTime.Value = DateTime.Now;
            if (Operation == DataOperation.New)
            {
                this.dtpPlanEffectTime.MinDate = DateTime.Now;
                var result = this._invoiceService.GetInvoiceNumber(InvoiceType.药品调价单据);
                if (result.Success)
                    this.tbxReceiptCode.Text = result.Value;
                else
                {
                    MsgBox.OK("单据号生成失败");
                    base.Close();
                }
            }
            else if (Operation == DataOperation.Modify)
            {
                this.tbxReceiptCode.Text = this.Receipt.ReceiptCode;
                this.cbxMemo.Text = this.Receipt.Memo;
                this.dtpPlanEffectTime.Value = this.Receipt.PlanEffectTime;

                var detailEntities = this._priceChangedReceiptService.GetPriceChangedDetailReceiptDetail(Receipt.Id);
                foreach (var entity in detailEntities)
                {
                    var newIndex = this.dgvDrugs.Rows.Add();
                    var newRow = this.dgvDrugs.Rows[newIndex];

                    newRow.Cells[colName.Index].Value = entity.Drug.DrugName;
                    newRow.Cells[colTradeName.Index].Value = entity.Drug.TradeName;
                    newRow.Cells[colSpecification.Index].Value = entity.Drug.Specification;
                    newRow.Cells[colProduction.Index].Value = entity.Drug.Manufacturer;
                    newRow.Cells[colRealTimePrice.Index].Value = entity.RealTimePrice;
                    newRow.Cells[colNewPrice.Index].Value = entity.NewPrice;
                    newRow.DefaultCellStyle.ForeColor = Color.Blue;

                    newRow.Tag = entity;
                }
            }
        }
        /// <summary>
        /// 初始化input框的过滤条件
        /// </summary>
        private void InitFilter()
        {
            this.dgvDrugFilter.SetFilterCondition(text =>
            {
                this.dgvDrugFilter.Rows.Clear();
                if (text == "")
                    return;

                var searchCode = text.ToUpper();
                var filter = this._allDrugEntities.Where(p => p.SearchCode.Contains(searchCode) || p.TradeName.Contains(searchCode) || p.TradeName.Contains(searchCode)).ToList();
                foreach (var drug in filter)
                {
                    var newIndex = this.dgvDrugFilter.Rows.Add();
                    var newRow = this.dgvDrugFilter.Rows[newIndex];

                    newRow.Cells[colFilterName.Index].Value = drug.DrugName;
                    newRow.Cells[colFilterTradeName.Index].Value = drug.TradeName;
                    newRow.Cells[colFilterSpecification.Index].Value = drug.Specification;
                    newRow.Cells[colFilterProduction.Index].Value = drug.Manufacturer;
                    newRow.Cells[colFilterApprovalNumber.Index].Value = drug.ApprovalNumber;

                    newRow.Tag = drug;
                }
            });
        }
        #endregion

        #region 方法

        /// <summary>
        /// 获取下一个可以编辑的单元格并跳转过去
        /// </summary>
        private void GotoNextCell()
        {
            DataGridViewCell cell = this.dgvDrugs.GetNextEditCell(this.dgvDrugs.CurrentCell);
            if (cell == this.dgvDrugs.CurrentCell)
                GotoNewRow();
            else
                this.dgvDrugs.CurrentCell = cell;
        }
        /// <summary>
        /// 获得最新的一行并跳转过去
        /// </summary>
        private void GotoNewRow()
        {
            DataGridViewRow row = this.dgvDrugs.Rows.Cast<DataGridViewRow>().OrderByDescending(p => p.Index).ToList().Find(p => p.Tag == null);
            if (row != null)
                this.dgvDrugs.CurrentCell = this.dgvDrugs.Rows[row.Index].Cells[colName.Index];
            else
            {
                var newRow = NewRow();
                this.dgvDrugs.CurrentCell = newRow.Cells[colName.Index];
            }
            this.dgvDrugs.BeginEdit(true);
        }
        /// <summary>
        /// 新建一行
        /// </summary>
        private DataGridViewRow NewRow()
        {
            int index = this.dgvDrugs.Rows.Add();
            return this.dgvDrugs.Rows[index];
        }
        /// <summary>
        /// 将当前选择的药品填充到数据表格中的指定行
        /// </summary>
        /// <param name="currentRow"></param>
        private bool FillDrugToRow()
        {
            if (this.dgvDrugFilter.PopupVisible)
            {
                var selectedRows = this.dgvDrugFilter.SelectedRows;
                if (selectedRows.Count != 0)
                {
                    var selectedRow = selectedRows[0];
                    var drugEntity = selectedRow.Tag as DrugInventoryEntity;
                    var row = this.FindRow(drugEntity.ClassCode, drugEntity.SpecificationCode);
                    this.dgvDrugs.CurrentCell = row.Cells[colName.Index];
                    row.Cells[colName.Index].Value = drugEntity.DrugName;
                    row.Cells[colTradeName.Index].Value = drugEntity.TradeName;
                    row.Cells[colSpecification.Index].Value = drugEntity.Specification;
                    row.Cells[colProduction.Index].Value = drugEntity.Manufacturer;
                    row.Cells[colRealTimePrice.Index].Value = drugEntity.BigPackagePrice;

                    if (row.Tag == null)
                    {
                        row.Cells[colNewPrice.Index].Value = drugEntity.BigPackagePrice;
                        row.Tag = drugEntity;
                    }
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// 查找行
        /// </summary>
        /// <param name="classCode">药典编码</param>
        /// <param name="SpecificationCode">规格编码</param>
        /// <returns></returns>
        private DataGridViewRow FindRow(string classCode, string SpecificationCode)
        {
            var activeRow = this.dgvDrugs.CurrentCell.OwningRow;
            foreach (DataGridViewRow row in this.dgvDrugs.Rows)
            {
                if (row.Tag == null)
                    return activeRow;
                if (row.Tag is DrugInventoryEntity drugInventoryEntity)
                {
                    if (drugInventoryEntity.ClassCode == classCode
                        && drugInventoryEntity.SpecificationCode == SpecificationCode)
                        return row;
                }
                else if (row.Tag is PriceChangedReceiptDetailEntity priceChangedReceiptDetailEntity)
                {
                    if (priceChangedReceiptDetailEntity.Drug.ClassCode == classCode
                        && priceChangedReceiptDetailEntity.Drug.SpecificationCode == SpecificationCode)
                        return row;
                }
            }

            return activeRow;
        }
        /// <summary>
        /// 检查单据状态
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        private bool CheckReceiptState(long receiptId)
        {
            var result = this._priceChangedReceiptService.GetAuditStatus(receiptId);
            if (result == null)
            {
                this.Receipt = null;
                MsgBox.OK("此单据可能被删除");
                return false;
            }
            if (result.Value)
            {
                MsgBox.OK("此单据已被审核");
                return false;
            }

            return true;
        }
        #endregion

        #region 窗体事件
        private void FormAddWarehouseInInventoryReceipt_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                this.InitData();
                this.InitUI();
                this.InitFilter();
                this.GotoNewRow();
            });
        }
        private void dgvDrugs_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dgvDrugs.EndEdit();
                if (this.dgvDrugs.CurrentCell == null) return;
                if (this.dgvDrugs.CurrentCell.ColumnIndex == this.colName.Index)
                {
                    if (!this.FillDrugToRow())
                        return;
                }

                this.GotoNextCell();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                UnsafeNativeMethods.SendMessage(this.dgvDrugFilter.Handle, (int)WinMsg.WM_KEYDOWN, e.KeyValue, 0);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.GotoNewRow();
        }

        private void dgvDrugs_TextChange(object sender, HIS.ControlLib.TextChangeEventArgs e)
        {
            if (e.ColumnIndex == this.colName.Index)
            {
                var row = this.dgvDrugs.Rows[e.RowIndex];
                row.Cells[colTradeName.Index].Value = "";
                row.Cells[colSpecification.Index].Value = "";
                row.Cells[colRealTimePrice.Index].Value = 0;
                row.Cells[colNewPrice.Index].Value = 0;
                row.Cells[colProduction.Index].Value = "";

                this.dgvDrugs.Rows[e.RowIndex].Tag = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCells = this.dgvDrugs.SelectedCells;
            if (selectedCells.Count == 0)
                return;

            List<DataGridViewRow> selectedRows = selectedCells.Cast<DataGridViewCell>()
                .Select(d => d.OwningRow)
                .Distinct()
                .ToList<DataGridViewRow>();

            var dialogResult = MsgBox.YesNo("是否确定要删除这" + selectedRows.Count + "条记录么");
            if (dialogResult != DialogResult.Yes)
                return;

            List<long> delids = new List<long>();
            List<DataGridViewRow> delRows = new List<DataGridViewRow>();
            foreach (var row in selectedRows)
            {
                if (row.Tag is DrugInventoryEntity drug || row.Tag == null)
                    this.dgvDrugs.Rows.Remove(row);
                else if (row.Tag is PriceChangedReceiptDetailEntity detail)
                {
                    delids.Add(detail.Id);
                    delRows.Add(row);
                }
            }
            if (delids.Count > 0)
            {
                if (this.CheckReceiptState(this.Receipt.Id))
                {
                    var result = this._priceChangedReceiptService.DeletePriceChangedReceiptDetail(delids);
                    if (result.Success)
                    {
                        delRows.ForEach(p =>
                        {
                            this.dgvDrugs.Rows.Remove(p);
                        });
                    }
                    else
                        MsgBox.OK($"删除失败\r\n{result.Message}");
                }
                else
                    base.DialogResult = DialogResult.Abort;
            }
        }

        private void dgvDrugFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FillDrugToRow();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.btnCommit.Enabled = false;

                string memo = this.cbxMemo.Text.Trim();
                if (memo == "")
                {
                    this.cbxMemo.Focus();
                    this.cbxMemo.ShowTips("请选择或输入调价原因");
                    return;
                }

                DateTime? planEffectTime = this.dtpPlanEffectTime.ValueObject as DateTime?;
                if (!planEffectTime.HasValue)
                {
                    this.dtpPlanEffectTime.Focus();
                    this.dtpPlanEffectTime.ShowTips("请选择计划生效时间");
                    return;
                }

                if (this.Receipt == null)
                {
                    this.Receipt = new PriceChangedReceiptEntity();
                    this.Receipt.Id = this._idService.CreateUUID();
                }
                this.Receipt.ReceiptCode = this.tbxReceiptCode.Text;
                this.Receipt.Dept = this.Dept;
                this.Receipt.Memo = memo;
                this.Receipt.AuditStatus = false;
                this.Receipt.PlanEffectTime = planEffectTime.Value;

                List<PriceChangedReceiptDetailEntity> newDetailEntities = new List<PriceChangedReceiptDetailEntity>();
                List<PriceChangedReceiptDetailEntity> updateDetailEntities = new List<PriceChangedReceiptDetailEntity>(); ;
                foreach (DataGridViewRow row in this.dgvDrugs.Rows)
                {
                    if (row.Tag == null) continue;
                    if (row.Tag is DrugEntity drug)
                    {
                        var detail = new PriceChangedReceiptDetailEntity();
                        detail.Drug = drug;
                        detail.Id = this._idService.CreateUUID();
                        detail.ReceiptId = Receipt.Id;
                        detail.OldPrice = row.Cells[colRealTimePrice.Index].Value.AsDecimal(0);
                        detail.RealTimePrice = row.Cells[colRealTimePrice.Index].Value.AsDecimal(0);
                        detail.NewPrice = row.Cells[colNewPrice.Index].Value.AsDecimal(0);
                        detail.PriceDifference = detail.NewPrice - detail.RealTimePrice;

                        newDetailEntities.Add(detail);
                    }
                    else if (row.Tag is PriceChangedReceiptDetailEntity priceChangedReceiptDetailEntity)
                    {
                        //如果价格有变动
                        var newPrice = row.Cells[colNewPrice.Index].Value.AsDecimal(0);
                        if (newPrice - priceChangedReceiptDetailEntity.NewPrice != 0)
                        {
                            priceChangedReceiptDetailEntity.NewPrice = newPrice;

                            var realTimePrice = row.Cells[colRealTimePrice.Index].Value.AsDecimal(0);
                            priceChangedReceiptDetailEntity.PriceDifference = newPrice - realTimePrice;

                            updateDetailEntities.Add(priceChangedReceiptDetailEntity);
                        }
                    }
                }

                DataResult result;
                if (Operation == DataOperation.New)
                    result = this._priceChangedReceiptService.AddPriceChangedReceipt(Receipt, newDetailEntities);
                else
                {
                    if (!this.CheckReceiptState(Receipt.Id))
                    {
                        base.DialogResult = DialogResult.Abort;
                        return;
                    }
                    result = this._priceChangedReceiptService.UpdatePriceChangedReceipt(Receipt, newDetailEntities, updateDetailEntities);
                }

                if (result.Success)
                {
                    if (Operation == DataOperation.New)
                        AlertBox.Info("新增调价单成功");
                    else if (Operation == DataOperation.Modify)
                        AlertBox.Info("修改调价单成功");

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (Operation == DataOperation.New)
                        MsgBox.OK("新增调价单失败" + Environment.NewLine + result.Message);
                    else if (Operation == DataOperation.Modify)
                        MsgBox.OK("修改调价单失败" + Environment.NewLine + result.Message);
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.btnCommit.Enabled = true;
            }
        }
        #endregion
    }
}