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

namespace App_Sys.Drug.InventoryManage
{
    internal partial class FormAddWarehouseInInventoryReceipt : BaseForm
    {
        private readonly IMerchantsService _merchantsService;
        private readonly IWarehouseInOutInventoryService _warehouseService;
        private readonly IInvoiceService _invoiceService;

        private List<DrugInventoryEntity> _allDrugEntities;
        /// <summary>
        /// 进货价加成系数
        /// </summary>
        private decimal _purchasePriceBonusCoefficient;

        public FormAddWarehouseInInventoryReceipt(IMerchantsService merchantsService, IWarehouseInOutInventoryService warehouseService, IInvoiceService invoiceService)
        {
            InitializeComponent();
            this._merchantsService = merchantsService;
            this._warehouseService = warehouseService;
            this._invoiceService = invoiceService;

            this.colPurchasePrice.Digits = 4;
            this.colPrice.Digits = 4;
            this.dgvDrugFilter.AutoGenerateColumns = false;
        }

        public DeptEntity Dept { get; set; }

        /// <summary>
        /// 入库单据对象
        /// </summary>
        public WarehouseInOutInventoryReceiptEntitiy Receipt { get; set; }
        /// <summary>
        /// 操作模式
        /// </summary>
        public DataOperation Operation { get; set; }

        #region 初始化

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            var supplierEntities = _merchantsService.GetAllSupplier();
            this.fcbSupplier.DisplayMember = nameof(MerchantsEntity.Name);
            this.fcbSupplier.ValueMember = nameof(MerchantsEntity.Id);
            this.fcbSupplier.FilterFields = new string[] { nameof(MerchantsEntity.SearchCode), nameof(MerchantsEntity.Name) };
            this.fcbSupplier.DataSource = supplierEntities;

            if (Dept.CategoryDetail == DeptCategoryDetail.WMWarehouse)
                _allDrugEntities = _warehouseService.GetAllDrugInfoCanIn(DrugType.西药, Dept.Id);
            else if (Dept.CategoryDetail == DeptCategoryDetail.HMWarehouse)
            {
                _allDrugEntities = _warehouseService.GetAllDrugInfoCanIn(DrugType.草药, Dept.Id);
                _allDrugEntities.AddRange(_warehouseService.GetAllDrugInfoCanIn(DrugType.颗粒剂, Dept.Id));
            }
            else
            {
                MsgBox.OK("药库药房对应信息出现问题,无法打开窗口");
                this.DialogResult = DialogResult.Cancel;
            }

            _allDrugEntities.ForEach(p => p.DataStatus = DataStatus.Enable);

            _purchasePriceBonusCoefficient = App.Instance.GlobalSet.PurchasePriceBonusCoefficient.AsDecimal(0);
        }
        /// <summary>
        /// 初始化界面显示
        /// </summary>
        private void InitUI()
        {
            this.dgvDrugFilter.Container = new HIS.ControlLib.Container(this.dgvDrugs, this.colName);

            if (Operation == DataOperation.New)
            {
                var result = _invoiceService.GetInvoiceNumber(InvoiceType.药库入库单据);
                if (result.Success)
                {
                    this.tbxReceiptCode.Text = result.Value;
                }
                else
                {
                    MsgBox.OK("单据号生成失败");
                    this.DialogResult = DialogResult.Cancel;

                }
            }
            else if (Operation == DataOperation.Modify)
            {
                this.tbxReceiptCode.Text = Receipt.ReceiptCode;
                this.tbxInvoiceNo.Text = Receipt.InvoiceNo;
                this.tbxTotal.Text = Receipt.Total.ToString();
                this.fcbSupplier.Text = Receipt.SupplyUnit;

                var detailEntities = _warehouseService.GetWarehouseInOutReceiptDetail(Receipt.Id);

                foreach (var entity in detailEntities)
                {
                    var newIndex = this.dgvDrugs.Rows.Add();
                    var newRow = this.dgvDrugs.Rows[newIndex];

                    var drug = _allDrugEntities.Find(p => p.ClassCode == entity.Drug.ClassCode && p.SpecificationCode == entity.Drug.SpecificationCode);
                    drug.DataStatus = DataStatus.Delete;

                    newRow.Cells[colName.Index].Value = entity.Drug.DrugName;
                    newRow.Cells[colSpecification.Index].Value = entity.Drug.Specification;
                    newRow.Cells[colQuantity.Index].Value = entity.Quantity;
                    newRow.Cells[colPurchasePrice.Index].Value = entity.PurchasePrice;
                    newRow.Cells[colPrice.Index].Value = entity.Price;
                    newRow.Cells[colProduction.Index].Value = entity.Drug.Manufacturer;
                    newRow.Cells[colBatchNumber.Index].Value = entity.BatchNumber;
                    newRow.Cells[colMemo.Index].Value = entity.Memo;
                    newRow.DefaultCellStyle.ForeColor = Color.Blue;
                    newRow.Tag = entity;

                    newRow.Cells[colName.Index].ReadOnly = true;
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
                var filter = _allDrugEntities.Where(p => p.DataStatus == DataStatus.Enable && (p.SearchCode.Contains(searchCode) || p.TradeName.Contains(searchCode) || p.TradeName.Contains(searchCode))).ToList();
                foreach (var drug in filter)
                {
                    var newIndex = this.dgvDrugFilter.Rows.Add();
                    var newRow = this.dgvDrugFilter.Rows[newIndex];

                    newRow.Cells[colName1.Index].Value = drug.DrugName;
                    newRow.Cells[colTradeName1.Index].Value = drug.TradeName;
                    newRow.Cells[colSpecification1.Index].Value = drug.Specification;
                    newRow.Cells[colQuantity1.Index].Value = drug.BigPackageQuantity;
                    newRow.Cells[colProduction1.Index].Value = drug.Manufacturer;
                    newRow.Cells[colApprovalNumber.Index].Value = drug.ApprovalNumber;
                    newRow.Tag = drug;
                }
            });
        }
        #endregion

        private void FormAddWarehouseInInventoryReceipt_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
                InitFilter();
                GotoNewRow();
            });
        }

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
        private bool FillDrugToRow(DataGridViewRow currentRow)
        {
            if (dgvDrugFilter.PopupVisible)
            {
                var selectedRows = this.dgvDrugFilter.SelectedRows;
                if (selectedRows.Count != 0)
                {
                    var selectedRow = selectedRows[0];
                    var drugEntity = selectedRow.Tag as DrugInventoryEntity;
                    drugEntity.DataStatus = DataStatus.Delete;
                    currentRow.Cells[colName.Index].Value = drugEntity.DrugName;
                    currentRow.Cells[colTradeName.Index].Value = drugEntity.TradeName;
                    currentRow.Cells[colSpecification.Index].Value = drugEntity.Specification;
                    currentRow.Cells[colQuantity.Index].Value = 1;
                    currentRow.Cells[colProduction.Index].Value = drugEntity.Manufacturer;
                    currentRow.Cells[colPurchasePrice.Index].Value = drugEntity.PurchasePrice;
                    currentRow.Cells[colPrice.Index].Value = drugEntity.PurchasePrice * _purchasePriceBonusCoefficient;
                    currentRow.Cells[colBatchNumber.Index].Value = this.tbxBatchNumber.Text;

                    currentRow.Tag = drugEntity;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        #endregion

        #region 窗体事件

        private void dgvDrugs_SpecialKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dgvDrugs.EndEdit();

                if (this.dgvDrugs.CurrentCell.ColumnIndex == this.colName.Index)
                {
                    if (!FillDrugToRow(this.dgvDrugs.CurrentCell.OwningRow))
                        return;
                }

                GotoNextCell();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                UnsafeNativeMethods.SendMessage(this.dgvDrugFilter.Handle, (int)WinMsg.WM_KEYDOWN, e.KeyValue, 0);
            }
        }

        private void dgvDrugs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.colQuantity.Index || e.ColumnIndex == this.colPurchasePrice.Index)
            {
                float sum = 0;
                foreach (DataGridViewRow row in this.dgvDrugs.Rows)
                {
                    sum += row.Cells[colQuantity.Index].Value.AsInt(0) * row.Cells[colPurchasePrice.Index].Value.AsFloat(0);
                }
                this.tbxTotal.Text = sum.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GotoNewRow();
        }

        private void dgvDrugs_TextChange(object sender, HIS.ControlLib.TextChangeEventArgs e)
        {
            if (e.ColumnIndex == this.colName.Index)
            {
                if (this.dgvDrugs.Rows[e.RowIndex].Tag is DrugInventoryEntity entity)
                    entity.DataStatus = DataStatus.Enable;

                this.dgvDrugs.Rows[e.RowIndex].Cells[colSpecification.Index].Value = "";
                this.dgvDrugs.Rows[e.RowIndex].Cells[colTradeName.Index].Value = "";
                this.dgvDrugs.Rows[e.RowIndex].Cells[colQuantity.Index].Value = 1;
                this.dgvDrugs.Rows[e.RowIndex].Cells[colProduction.Index].Value = "";
                this.dgvDrugs.Rows[e.RowIndex].Cells[colPurchasePrice.Index].Value = 0;
                this.dgvDrugs.Rows[e.RowIndex].Cells[colPrice.Index].Value = 0;
                this.dgvDrugs.Rows[e.RowIndex].Tag = null;

            }
            else if (e.ColumnIndex == this.colPurchasePrice.Index)
            {
                this.dgvDrugs.Rows[e.RowIndex].Cells[colPrice.Index].Value = e.Text.AsDecimal(0) * _purchasePriceBonusCoefficient;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCells = this.dgvDrugs.SelectedCells;
            if (selectedCells.Count == 0)
                return;

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewCell cell in selectedCells)
            {
                if (selectedRows.Contains(cell.OwningRow))
                    continue;
                selectedRows.Add(cell.OwningRow);
            }

            if (Operation == DataOperation.Modify && selectedRows.Count(p => p.Tag is WarehouseInOutInventoryReceiptDetailEntitiy) > 0)
            {
                var auditStatus = _warehouseService.GetAuditStatus(Receipt.Id);
                if (auditStatus)
                {
                    MsgBox.OK("当前单据已经在别处被审核,无法操作");
                    this.DialogResult = DialogResult.Abort;
                    return;
                }
            }

            var dialogResult = MsgBox.YesNo("是否确定要删除这" + selectedRows.Count + "条记录么");
            if (dialogResult != DialogResult.Yes)
                return;

            List<string> errorText = new List<string>();

            foreach (var row in selectedRows)
            {
                if (row.Tag is DrugInventoryEntity drug)
                {
                    this.dgvDrugs.Rows.Remove(row);
                    drug.DataStatus = DataStatus.Enable;
                }
                else if (row.Tag is WarehouseInOutInventoryReceiptDetailEntitiy detail)
                {
                    var result = _warehouseService.DeleteInOutReceiptDetail(detail.Id);
                    if (result.Success)
                    {
                        this.dgvDrugs.Rows.Remove(row);
                        var drugFilter = _allDrugEntities.Find(p => p.ClassCode == detail.Drug.ClassCode && p.SpecificationCode == detail.Drug.SpecificationCode);
                        drugFilter.DataStatus = DataStatus.Enable;
                    }
                    else
                        errorText.Add(detail.Drug.DrugName + "删除失败" + Environment.NewLine + result.Message);
                }
            }

            if (errorText.Count > 0)
                MsgBox.OK(string.Join(Environment.NewLine, errorText));
        }

        private void dgvDrugFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDrugToRow(this.dgvDrugs.CurrentCell.OwningRow);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Receipt == null)
                Receipt = new WarehouseInOutInventoryReceiptEntitiy();
            Receipt.ReceiptCode = this.tbxReceiptCode.Text;
            Receipt.Total = this.tbxTotal.Text.AsDecimal(0);
            Receipt.SupplyUnit = this.fcbSupplier.Text;
            Receipt.InvoiceNo = this.tbxInvoiceNo.Text;
            Receipt.Dept = Dept;

            List<WarehouseInOutInventoryReceiptDetailEntitiy> newDetailEntities = new List<WarehouseInOutInventoryReceiptDetailEntitiy>();
            List<WarehouseInOutInventoryReceiptDetailEntitiy> updateDetailEntities = new List<WarehouseInOutInventoryReceiptDetailEntitiy>();
            foreach (DataGridViewRow row in this.dgvDrugs.Rows)
            {
                if (row.Tag is DrugEntity drug)
                {
                    var detail = new WarehouseInOutInventoryReceiptDetailEntitiy();
                    detail.Drug = drug;
                    detail.PurchasePrice = row.Cells[colPurchasePrice.Index].Value.AsDecimal(0);
                    detail.Quantity = row.Cells[colQuantity.Index].Value.AsInt(0);
                    detail.Price = row.Cells[colPrice.Index].Value.AsDecimal(0);
                    detail.BatchNumber = row.Cells[colBatchNumber.Index].Value.AsString();
                    detail.Memo = row.Cells[colMemo.Index].Value.AsString();

                    newDetailEntities.Add(detail);
                }
                else if (row.Tag is WarehouseInOutInventoryReceiptDetailEntitiy receiptDetail)
                {
                    var purchasePrice = row.Cells[colPurchasePrice.Index].Value.AsDecimal(0);
                    var quantity = row.Cells[colQuantity.Index].Value.AsInt(0);
                    var price = row.Cells[colPrice.Index].Value.AsDecimal(0);
                    var batchNumber = row.Cells[colBatchNumber.Index].Value.AsString();
                    var memo = row.Cells[colMemo.Index].Value.AsString();

                    //如果当前更新的值有一项和原值不同,则添加到待更新列表中
                    if (receiptDetail.PurchasePrice != purchasePrice || receiptDetail.Quantity != quantity || receiptDetail.Price != price || receiptDetail.BatchNumber != batchNumber || receiptDetail.Memo != memo)
                    {
                        receiptDetail.PurchasePrice = purchasePrice;
                        receiptDetail.Quantity = quantity;
                        receiptDetail.Price = price;
                        receiptDetail.BatchNumber = batchNumber;
                        receiptDetail.Memo = memo;

                        updateDetailEntities.Add(receiptDetail);
                    }
                }
            }
            if (newDetailEntities.Count == 0 && updateDetailEntities.Count == 0)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            DataResult result;
            if (Operation == DataOperation.New)
                result = _warehouseService.AddInInventoryReceipt(Receipt, newDetailEntities);
            else
                result = _warehouseService.UpdateInInventoryReceipt(Receipt, newDetailEntities, updateDetailEntities);

            if (result.Success)
            {
                if (Operation == DataOperation.New)
                    AlertBox.Info("新增入库单成功");
                else if (Operation == DataOperation.Modify)
                    AlertBox.Info("修改入库单成功");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (Operation == DataOperation.New)
                    MsgBox.OK("新增入库单失败" + Environment.NewLine + result.Message);
                else if (Operation == DataOperation.Modify)
                    MsgBox.OK("修改入库单失败" + Environment.NewLine + result.Message);
            }
        }
        #endregion
    }
}