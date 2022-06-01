using DevComponents.DotNetBar.SuperGrid;
using HIS.Core.UI;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Core;
using HIS.DSkinControl;
using HIS.Utility;

namespace App_Sys.Drug.InventoryManage
{
    public partial class FormTransfer : BaseForm
    {
        private readonly IDrugTransferService _transferService;

        private DrugTransferReceipt _selectedReceiptEntity;

        public FormTransfer(IDrugTransferService transferService)
        {
            InitializeComponent();
            this._transferService = transferService;
        }


        public void Init()
        {
            HIS.DSkinControl.QLoading.Show(this);


            this.dtStartDate.Value = DateTime.Now.AddDays(-7);
            this.dtEndDate.Value = DateTime.Now;

            this.cbxReceiptType.SelectedIndex = 0;

            InitReceipt();

            this.cbxReceiptType.SelectedIndex = 0;

            this.tbxReceiptCode.Text = "";
            this.tbxReceiptCode.Focus();

            HIS.DSkinControl.QLoading.Close(this);
        }

        private void InitReceipt()
        {
            this.dgvReceipt.PrimaryGrid.Rows.Clear();
            this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();

            var receiptEntities = _transferService.GetApplyReceipt(ViewData.Dept.Id, this.dtStartDate.Value, this.dtEndDate.Value, this.tbxReceiptCode.Text);

            foreach (var receiptEntity in receiptEntities)
            {
                var newRow = BuildNewRow(receiptEntity);
                this.dgvReceipt.PrimaryGrid.Rows.Add(newRow);
                InitLinkButton(newRow);
            }
        }

        private GridRow BuildNewRow(DrugTransferReceipt receiptEntity)
        {
            var newRow = this.dgvReceipt.PrimaryGrid.NewRow();

            newRow.Cells[colReceiptCode.ColumnIndex].Value = receiptEntity.ReceiptCode;
            newRow.Cells[colCreatorUserName.ColumnIndex].Value = receiptEntity.CreateUser.Name;
            newRow.Cells[colReceiptCode.ColumnIndex].Value = receiptEntity.ReceiptCode;
            newRow.Cells[colCreationTime.ColumnIndex].Value = receiptEntity.CreationTime;
            newRow.Cells[colAuditName.ColumnIndex].Value = receiptEntity.AuditUser?.Name;
            newRow.Cells[colAuditTime.ColumnIndex].Value = receiptEntity.AuditTime;
            newRow.Cells[colStatus.ColumnIndex].Value = receiptEntity.AuditStatus ? "已审核" : "待审核";
            if (!receiptEntity.AuditStatus)
                newRow.CellStyles.Default.TextColor = Color.Green;
            newRow.Tag = receiptEntity;

            return newRow;
        }

        #region 方法

        /// <summary>
        /// 初始化指定行的按钮事件
        /// </summary>
        /// <param name="row"></param>
        private void InitLinkButton(GridRow row)
        {
            if (!row.Tag.As<ChangeInventoryReceiptEntity>().AuditStatus)
            {
                row.Cells[colEdit.ColumnIndex].Value = "修改";
                row.Cells[colDelete.ColumnIndex].Value = "删除";

                row.Cells[colEdit.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                row.Cells[colEdit.ColumnIndex].ReadOnly = false;
                var editButton = row.Cells[colEdit.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                editButton.LinkClicked -= EditButton_LinkClicked;
                editButton.LinkClicked += EditButton_LinkClicked;

                row.Cells[colDelete.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                row.Cells[colDelete.ColumnIndex].ReadOnly = false;
                var deleteButton = row.Cells[colDelete.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                deleteButton.LinkClicked -= DeleteButton_LinkClicked;
                deleteButton.LinkClicked += DeleteButton_LinkClicked;
            }
            else
            {
                row.Cells[colEdit.ColumnIndex].Value = "";
                row.Cells[colDelete.ColumnIndex].Value = "";

                row.Cells[colEdit.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                row.Cells[colEdit.ColumnIndex].ReadOnly = true;
                row.Cells[colDelete.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                row.Cells[colDelete.ColumnIndex].ReadOnly = true;
            }
        }

        private bool CheckAudit(GridRow selectedRow, DrugTransferReceipt receipt)
        {

            var auditStatus = _transferService.GetAuditStatus(receipt.Id);
            if (receipt.AuditStatus != auditStatus)
            {
                var newReceipt = _transferService.GetReceipt(receipt.Id);
                selectedRow.Tag = newReceipt;
                if (receipt.AuditStatus)
                    MsgBox.OK("该单据已经在别处被取消审核");
                else
                    MsgBox.OK("该单据已经在别处被审核");

                selectedRow.Cells[colStatus.ColumnIndex].Value = newReceipt.AuditStatus ? "已审核" : "待审核";
                selectedRow.Cells[colAuditName.ColumnIndex].Value = newReceipt.AuditUser?.Name;
                selectedRow.Cells[colAuditTime.ColumnIndex].Value = newReceipt.AuditTime;

                InitLinkButton(selectedRow);
                return false;
            }

            return true;
        }
        #endregion

        #region 窗体事件

        private void DeleteButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.dgvReceipt.GetSelectedRowByCell();
                if (selectedRow == null)
                    return;

                if (MsgBox.YesNo("是否确定删除当前单据,此操作无法回退") != DialogResult.Yes)
                    return;

                var receipt = selectedRow.Tag as DrugTransferReceipt;

                if (!CheckAudit(selectedRow, receipt))
                    return;

                var result = _transferService.DeleteReceipt(receipt.Id);
                if (result.Success)
                {
                    AlertBox.Info("删除成功");
                    this.dgvReceipt.PrimaryGrid.Rows.Remove(selectedRow);
                    this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                    _selectedReceiptEntity = null;
                }
                else
                    MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
            });
        }

        private void EditButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedRow = this.dgvReceipt.GetSelectedRowByCell();
            if (selectedRow == null)
                return;

            var receipt = selectedRow.Tag as DrugTransferReceipt;

            //如果当前缓存的审核状态和后台获取的审核状态不一致
            if (!CheckAudit(selectedRow, receipt))
                return;

            FormAddTransferReceipt form = App.Instance.CreateView<FormAddTransferReceipt>();
            form.Operation = DataOperation.Modify;
            form.Dept = ViewData.Dept;
            form.Receipt = receipt;
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _selectedReceiptEntity = null;
                this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                this.dgvReceipt.PrimaryGrid.ClearAll();
            }
            else if (dialogResult == DialogResult.Abort)
            {
                var newReceipt = _transferService.GetReceipt(receipt.Id);
                if (newReceipt == null)
                {
                    this.dgvReceipt.PrimaryGrid.Rows.Remove(selectedRow);
                    _selectedReceiptEntity = null;
                    this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                    return;
                }
                selectedRow.Tag = newReceipt;
                if (receipt.AuditStatus)
                    MsgBox.OK("该单据已经在别处被取消审核");
                else
                    MsgBox.OK("该单据已经在别处被审核");

                selectedRow.Cells[colStatus.ColumnIndex].Value = newReceipt.AuditStatus ? "已审核" : "待审核";
                selectedRow.Cells[colAuditName.ColumnIndex].Value = newReceipt.AuditUser?.Name;
                selectedRow.Cells[colAuditTime.ColumnIndex].Value = newReceipt.AuditTime;

                InitLinkButton(selectedRow);

                _selectedReceiptEntity = null;
                this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                this.dgvReceipt.PrimaryGrid.ClearAll();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddTransferReceipt form = App.Instance.CreateView<FormAddTransferReceipt>();
            form.Dept = ViewData.Dept;
            form.Operation = DataOperation.New;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newRow = BuildNewRow(form.Receipt);
                this.dgvReceipt.PrimaryGrid.Rows.Insert(0, newRow);
                newRow.CellStyles.Default.TextColor = Color.Green;
                InitLinkButton(newRow);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            InitReceipt();
        }
        private void dgvReceipt_CellClick(object sender, GridCellClickEventArgs e)
        {
            var selectedReceiptEntity = e.GridCell.GridRow.Tag as DrugTransferReceipt;
            if (_selectedReceiptEntity == selectedReceiptEntity)
                return;
            _selectedReceiptEntity = selectedReceiptEntity;

            this.dgvReceiptDetail.ShowMask(() =>
            {
                List<DrugTransferDetailEntity> detailEntities;

                if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMPharmacy || ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMPharmacy)
                    detailEntities = _transferService.GetReceiptDetail(_selectedReceiptEntity.Id, 1);
                else
                    detailEntities = _transferService.GetReceiptDetail(_selectedReceiptEntity.Id, 0);

                this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();

                foreach (var detailEntity in detailEntities)
                {
                    var newRow = this.dgvReceiptDetail.PrimaryGrid.NewRow();
                    newRow.Cells[colDrugName.ColumnIndex].Value = detailEntity.Drug.DrugName;

                    newRow.Cells[colProduction.ColumnIndex].Value = detailEntity.Drug.Manufacturer;
                    newRow.Cells[colQuantity.ColumnIndex].Value = detailEntity.Quantity + detailEntity.Drug.BigPackageUnit;
                    newRow.Cells[colPurchasePrice.ColumnIndex].Value = detailEntity.PurchasePrice.ToString("0.0000元");
                    newRow.Cells[colPrice.ColumnIndex].Value = detailEntity.Price.ToString("0.0000元");
                    newRow.Cells[colReceiptPrice.ColumnIndex].Value = detailEntity.ReceiptPrice.ToString("0.0000元");
                    if (detailEntity.Price != detailEntity.ReceiptPrice)
                    {
                        newRow.Cells[colPrice.ColumnIndex].CellStyles.Default.TextColor = Color.Red;
                        newRow.Cells[colReceiptPrice.ColumnIndex].CellStyles.Default.TextColor = Color.Red;
                    }
                    newRow.Tag = detailEntity;

                    this.dgvReceiptDetail.PrimaryGrid.Rows.Add(newRow);
                }
            });
        }
        #endregion

        private void FormTransfer_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
