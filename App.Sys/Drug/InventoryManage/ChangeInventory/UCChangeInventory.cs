﻿using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
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
using DevComponents.Editors;
using HIS.DSkinControl;
using HIS.Utility;

namespace App_Sys.Drug.InventoryManage
{
    internal partial class UCChangeInventory : UserControl, IUCInit
    {
        private IChangeInventoryReceiptService _changeInventoryService;
        private ChangeInventoryReceiptEntity _selectedReceiptEntity;

        public UCChangeInventory()
        {
            InitializeComponent();
        }

        public ViewData ViewData { get; set; }

        public void Init()
        {
            HIS.DSkinControl.QLoading.Show(this);

            this._changeInventoryService = ServiceLocator.GetService<IChangeInventoryReceiptService>();

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

            var value = this.cbxReceiptType.SelectedItem.As<ComboItem>().Value.AsInt(0);
            List<ChangeInventoryReceiptEntity> receiptEntities;

            if (value == -1)
                receiptEntities = _changeInventoryService.GetReceipt(ViewData.Dept.Id, null, this.dtStartDate.Value, this.dtEndDate.Value, this.tbxReceiptCode.Text);
            else
                receiptEntities = _changeInventoryService.GetReceipt(ViewData.Dept.Id, (ChangeInventoryType)value, this.dtStartDate.Value, this.dtEndDate.Value, this.tbxReceiptCode.Text);

            foreach (var receiptEntity in receiptEntities)
            {
                var newRow = BuildNewRow(receiptEntity);
                this.dgvReceipt.PrimaryGrid.Rows.Add(newRow);
                InitLinkButton(newRow);
            }
        }

        private GridRow BuildNewRow(ChangeInventoryReceiptEntity receiptEntity)
        {
            var newRow = this.dgvReceipt.PrimaryGrid.NewRow();

            newRow.Cells[colReceiptCode.ColumnIndex].Value = receiptEntity.ReceiptCode;
            newRow.Cells[colCreatorUserName.ColumnIndex].Value = receiptEntity.CreateUser.Name;
            newRow.Cells[colReceiptCode.ColumnIndex].Value = receiptEntity.ReceiptCode;
            newRow.Cells[colCreationTime.ColumnIndex].Value = receiptEntity.CreationTime;
            newRow.Cells[colAuditName.ColumnIndex].Value = receiptEntity.AuditUser?.Name;
            newRow.Cells[colAuditTime.ColumnIndex].Value = receiptEntity.AuditTime;
            newRow.Cells[colReceiptType.ColumnIndex].Value = receiptEntity.ReceiptType.GetDescription();
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
                row.Cells[colAudit.ColumnIndex].Value = "审核";

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
                row.Cells[colAudit.ColumnIndex].Value = "取消审核";

                row.Cells[colEdit.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                row.Cells[colEdit.ColumnIndex].ReadOnly = true;
                row.Cells[colDelete.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                row.Cells[colDelete.ColumnIndex].ReadOnly = true;
            }

            row.Cells[colAudit.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
            var auditButton = row.Cells[colAudit.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
            auditButton.LinkClicked -= AuditButton_LinkClicked;
            auditButton.LinkClicked += AuditButton_LinkClicked;
        }


        /// <summary>
        /// 审核指定单据
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <returns></returns>
        private bool AuditReceipt(ChangeInventoryReceiptEntity receiptEntity)
        {
            if (!App.Instance.User.HasPermission(PermissionsContants.Instance.Drug_PharmacyOutInventoryReceiptAudit))
            {
                MsgBox.OK("您在当前角色中没有权限审核库存变更单");
                return false;
            }

            if (MsgBox.YesNo("是否确定审核该条库存变更单") != DialogResult.Yes)
                return false;

            DataResult<DateTime> result;
            if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMPharmacy || ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMPharmacy)
                result = _changeInventoryService.AuditPharmacyReceipt(receiptEntity.Id, ViewData.Dept.Id, receiptEntity.ReceiptType);
            else
                result = _changeInventoryService.AuditWarehouseReceipt(receiptEntity.Id, ViewData.Dept.Id, receiptEntity.ReceiptType);

            if (result.Success)
            {
                receiptEntity.AuditStatus = true;
                receiptEntity.AuditTime = result.Value;
                receiptEntity.AuditUser = new UserEntity() { Name = App.Instance.User.UserName };
                AlertBox.Info("审核成功");
                return true;
            }
            else
            {
                MsgBox.OK("审核失败" + Environment.NewLine + result.Message);
                return false;
            }
        }
        /// <summary>
        /// 取消审核指定单据
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <returns></returns>
        private bool CancelAuditReceipt(ChangeInventoryReceiptEntity receiptEntity)
        {
            if (!App.Instance.User.HasPermission(PermissionsContants.Instance.Drug_WarehouseInInventoryReceiptAudit))
            {
                MsgBox.OK("您在当前角色中没有权限取消审核库存变更单据");
                return false;
            }

            if (MsgBox.YesNo("是否确定对该条库存变更单取消审核") != DialogResult.Yes)
                return false;

            DataResult result;
            if (ViewData.Dept.CategoryDetail == DeptCategoryDetail.HMPharmacy || ViewData.Dept.CategoryDetail == DeptCategoryDetail.WMPharmacy)
                result = _changeInventoryService.CancelAuditPharmacyReceipt(receiptEntity.Id, ViewData.Dept.Id, receiptEntity.ReceiptType);
            else
                result = _changeInventoryService.CancelAuditWarehouseReceipt(receiptEntity.Id, ViewData.Dept.Id, receiptEntity.ReceiptType);

            if (result.Success)
            {
                receiptEntity.AuditStatus = false;
                receiptEntity.AuditTime = null;
                receiptEntity.AuditUser = null;
                AlertBox.Info("取消审核成功");
                return true;
            }
            else
            {
                MsgBox.OK("取消审核失败" + Environment.NewLine + result.Message);
                return false;
            }
        }
        private bool CheckAudit(GridRow selectedRow, ChangeInventoryReceiptEntity receipt)
        {

            var auditStatus = _changeInventoryService.GetAuditStatus(receipt.Id);
            if (receipt.AuditStatus != auditStatus)
            {
                var newReceipt = _changeInventoryService.GetReceipt(receipt.Id);
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var value = this.cbxReceiptType.SelectedItem.As<ComboItem>().Value.AsInt(0);
            if (value == -1)
            {
                MsgBox.OK("请选择详细类型单据");
                return;
            }

            FormAddChangeInventoryReceipt form = App.Instance.CreateView<FormAddChangeInventoryReceipt>();
            form.Dept = ViewData.Dept;
            form.Operation = DataOperation.New;
            form.ReceiptType = (ChangeInventoryType)value;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newRow = BuildNewRow(form.Receipt);
                this.dgvReceipt.PrimaryGrid.Rows.Insert(0, newRow);
                newRow.CellStyles.Default.TextColor = Color.Green;
                InitLinkButton(newRow);
            }
        }

        private void AuditButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.dgvReceipt.GetSelectedRowByCell();
                if (selectedRow != null)
                {
                    var receipt = selectedRow.Tag as ChangeInventoryReceiptEntity;

                    //如果当前缓存的审核状态和后台获取的审核状态不一致
                    if (!CheckAudit(selectedRow, receipt))
                        return;

                    var result = false;
                    if (receipt.AuditStatus)
                        result = CancelAuditReceipt(receipt);
                    else
                        result = AuditReceipt(receipt);

                    if (result)
                    {
                        InitLinkButton(selectedRow);
                        if (receipt.AuditStatus)
                        {
                            selectedRow.Cells[colStatus.ColumnIndex].Value = "已审核";
                            selectedRow.Cells[colAuditName.ColumnIndex].Value = receipt.AuditUser.Name;
                            selectedRow.Cells[colAuditTime.ColumnIndex].Value = receipt.AuditTime;
                            selectedRow.CellStyles.Default.TextColor = Color.Black;
                        }
                        else
                        {
                            selectedRow.Cells[colStatus.ColumnIndex].Value = "待审核";
                            selectedRow.Cells[colAuditName.ColumnIndex].Value = "";
                            selectedRow.Cells[colAuditTime.ColumnIndex].Value = "";
                            selectedRow.CellStyles.Default.TextColor = Color.Green;
                        }
                    }
                }
            });
        }

        private void DeleteButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.dgvReceipt.GetSelectedRowByCell();
                if (selectedRow == null)
                    return;

                if (MsgBox.YesNo("是否确定删除当前单据,此操作无法回退") != DialogResult.Yes)
                    return;

                var receipt = selectedRow.Tag as ChangeInventoryReceiptEntity;

                if (!CheckAudit(selectedRow, receipt))
                    return;

                var result = _changeInventoryService.DeleteReceipt(receipt.Id);
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

            var receipt = selectedRow.Tag as ChangeInventoryReceiptEntity;

            //如果当前缓存的审核状态和后台获取的审核状态不一致
            if (!CheckAudit(selectedRow, receipt))
                return;

            FormAddChangeInventoryReceipt form = App.Instance.CreateView<FormAddChangeInventoryReceipt>();
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
                var newReceipt = _changeInventoryService.GetReceipt(receipt.Id);
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            InitReceipt();
        }
        private void dgvReceipt_CellClick(object sender, GridCellClickEventArgs e)
        {
            var selectedReceiptEntity = e.GridCell.GridRow.Tag as ChangeInventoryReceiptEntity;
            if (_selectedReceiptEntity == selectedReceiptEntity)
                return;
            _selectedReceiptEntity = selectedReceiptEntity;

            this.dgvReceiptDetail.ShowMask(() =>
            {
                var detailEntities = _changeInventoryService.GetReceiptDetail(_selectedReceiptEntity.Id);

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
    }
}
