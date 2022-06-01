using DevComponents.DotNetBar;
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
using HIS.Service.Core;
using HIS.Core.UI;
using HIS.Core;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Service.Core.Entities;
using HIS.DSkinControl;
using HIS.Utility;

namespace App_Sys.Drug
{
    internal partial class UCPriceChangedReceipt : UserControl, IUCInit
    {
        /// <summary>
        /// 调价单据服务
        /// </summary>
        private IPriceChangedReceiptService _priceChangedReceiptService;

        #region 当前选中的调价单据行与实体
        /// <summary>
        /// 当前选中的调价单据行
        /// </summary>
        private GridRow CurrentSelectedReceiptRow
        {
            get
            {
                return this.dgvReceipt.GetSelectedRowByCell();
            }
        }
        /// <summary>
        /// 当前选中的调价单据实体
        /// </summary>
        private PriceChangedReceiptEntity CurrentSelectedReceiptEntity
        {
            get
            {
                var gr = this.CurrentSelectedReceiptRow;
                if (gr == null)
                {
                    return null;
                }

                return gr.Tag.As<PriceChangedReceiptEntity>();
            }
        }
        /// <summary>
        /// 当前点击行索引
        /// </summary>
        private int ClickReceiptRowIndex;

        #endregion
        /// <summary>
        /// 当前选中的科室
        /// </summary>
        public ViewData ViewData { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public UCPriceChangedReceipt()
        {
            InitializeComponent();
        }

        #region 初始化

        public void Init()
        {
            QLoading.Show(this);

            //初始化服务
            this._priceChangedReceiptService = ServiceLocator.GetService<IPriceChangedReceiptService>();
            //设置查询时间间隔
            this.dtStartDate.Value = DateTime.Now.AddDays(-7);
            this.dtEndDate.Value = DateTime.Now;
            this.InitReceipt();
            //合并列头为用户操作
            ColumnGroupHeader columnGroupHeader = new ColumnGroupHeader();
            columnGroupHeader.RowHeight += 25;
            columnGroupHeader.HeaderText = "用户操作";
            columnGroupHeader.StartDisplayIndex = this.colAudit.ColumnIndex;
            columnGroupHeader.EndDisplayIndex = this.colDelete.ColumnIndex;
            this.dgvReceipt.PrimaryGrid.ColumnHeader.GroupHeaders.Add(columnGroupHeader);
            this.dgvReceipt.PrimaryGrid.MultiSelect = false;
            this.dgvReceipt.PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None;
            this.dgvReceipt.PrimaryGrid.ColumnDragBehavior = ColumnDragBehavior.None;
            //单据输入域获取焦点
            this.tbxReceiptCode.Text = "";
            this.tbxReceiptCode.Focus();
            //初始化索引
            this.ClickReceiptRowIndex = -1;

            QLoading.Close(this);
        }

        /// <summary>
        /// 初始化单据
        /// </summary>
        private void InitReceipt()
        {
            this.dgvReceipt.PrimaryGrid.Rows.Clear();
            this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
            this.ClickReceiptRowIndex = -1;

            string receiptCode = this.tbxReceiptCode.Text.Trim();
            List<PriceChangedReceiptEntity> receipts = null;
            if (receiptCode == "")
                receipts = this._priceChangedReceiptService.GetPriceChangedReceipt(this.ViewData.Dept.Id, this.dtStartDate.Value, this.dtEndDate.Value);
            else
                receipts = this._priceChangedReceiptService.GetPriceChangedReceipt(this.ViewData.Dept.Id, receiptCode);
            foreach (var receipt in receipts)
            {
                var newRow = this.CreateReceiptRow(receipt);
                this.dgvReceipt.PrimaryGrid.Rows.Add(newRow);

                this.InitLinkButton(newRow);
            }
        }
        /// <summary>
        /// 创建单据行
        /// </summary>
        /// <param name="receipt"></param>
        /// <returns></returns>
        private GridRow CreateReceiptRow(PriceChangedReceiptEntity receipt)
        {
            GridRow gr = this.dgvReceipt.PrimaryGrid.NewRow();
            this.SetReceiptRowValue(gr, receipt);

            return gr;
        }
        /// <summary>
        /// 设置单据行每一个单元格的值
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="receipt"></param>
        private void SetReceiptRowValue(GridRow gr, PriceChangedReceiptEntity receipt)
        {
            gr.Cells[colReceiptCode.ColumnIndex].Value = receipt.ReceiptCode;
            gr.Cells[colCreatorUserName.ColumnIndex].Value = receipt.CreateUser.Name;
            gr.Cells[colCreationTime.ColumnIndex].Value = receipt.CreationTime;
            gr.Cells[colAuditName.ColumnIndex].Value = receipt.AuditUser?.Name;
            gr.Cells[colAuditTime.ColumnIndex].Value = receipt.AuditTime;
            gr.Cells[colPlanEffectTime.ColumnIndex].Value = receipt.PlanEffectTime;
            gr.Cells[colActualEffectTime.ColumnIndex].Value = receipt.ActualEffectTime;
            gr.Cells[colStatus.ColumnIndex].Value = receipt.AuditStatus ? "已审核" : "待审核";
            gr.Cells[colEffectStatus.ColumnIndex].Value = receipt.ActualEffectTime.HasValue ? "已生效" : "待生效";
            gr.Cells[colMemo.ColumnIndex].Value = receipt.Memo;

            if (!receipt.AuditStatus || !receipt.ActualEffectTime.HasValue)
                gr.CellStyles.Default.TextColor = Color.Red;

            gr.Tag = receipt;
        }
        #endregion

        #region 方法
        /// <summary>
        /// 初始化指定行的按钮事件
        /// </summary>
        /// <param name="gr"></param>
        private void InitLinkButton(GridRow gr)
        {
            var receipt = gr.Tag.As<PriceChangedReceiptEntity>();
            if (!receipt.ActualEffectTime.HasValue)//单据未生效
            {
                if (!receipt.AuditStatus)//单据未审核
                {
                    gr.Cells[colEdit.ColumnIndex].Value = "修改";
                    gr.Cells[colDelete.ColumnIndex].Value = "删除";
                    gr.Cells[colAudit.ColumnIndex].Value = "审核";
                    gr.Cells[colEffect.ColumnIndex].Value = "";
                    gr.Cells[colEdit.ColumnIndex].ReadOnly = false;
                    gr.Cells[colDelete.ColumnIndex].ReadOnly = false;

                    gr.Cells[colEdit.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                    var editButton = gr.Cells[colEdit.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                    editButton.LinkClicked -= EditButton_LinkClicked;
                    editButton.LinkClicked += EditButton_LinkClicked;

                    gr.Cells[colDelete.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                    var deleteButton = gr.Cells[colDelete.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                    deleteButton.LinkClicked -= DeleteButton_LinkClicked;
                    deleteButton.LinkClicked += DeleteButton_LinkClicked;

                    gr.Cells[colAudit.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                    var auditButton = gr.Cells[colAudit.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                    auditButton.LinkClicked -= AuditButton_LinkClicked;
                    auditButton.LinkClicked += AuditButton_LinkClicked;

                    gr.Cells[colEffect.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                    gr.Cells[colEffect.ColumnIndex].ReadOnly = true;

                }
                else
                {
                    gr.Cells[colAudit.ColumnIndex].Value = "取消审核";
                    gr.Cells[colEdit.ColumnIndex].Value = "";
                    gr.Cells[colDelete.ColumnIndex].Value = "";
                    gr.Cells[colEffect.ColumnIndex].Value = "立即生效";
                    gr.Cells[colEffect.ColumnIndex].ReadOnly = false;

                    gr.Cells[colAudit.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                    var auditButton = gr.Cells[colAudit.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                    auditButton.LinkClicked -= AuditButton_LinkClicked;
                    auditButton.LinkClicked += AuditButton_LinkClicked;

                    gr.Cells[colEdit.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                    gr.Cells[colEdit.ColumnIndex].ReadOnly = true;

                    gr.Cells[colDelete.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                    gr.Cells[colDelete.ColumnIndex].ReadOnly = true;

                    gr.Cells[colEffect.ColumnIndex].EditorType = typeof(HIS.ControlLib.SuperGrid.GridLinkButtonEditControl);
                    var effectButton = gr.Cells[colEffect.ColumnIndex].EditControl as HIS.ControlLib.SuperGrid.GridLinkButtonEditControl;
                    effectButton.LinkClicked -= EffectButton_LinkClicked;
                    effectButton.LinkClicked += EffectButton_LinkClicked;
                }
            }
            else
            {
                gr.Cells[colEdit.ColumnIndex].Value = "";
                gr.Cells[colDelete.ColumnIndex].Value = "";
                gr.Cells[colAudit.ColumnIndex].Value = "";
                gr.Cells[colEffect.ColumnIndex].Value = "";

                gr.Cells[colEdit.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                gr.Cells[colEdit.ColumnIndex].ReadOnly = true;
                gr.Cells[colDelete.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                gr.Cells[colDelete.ColumnIndex].ReadOnly = true;
                gr.Cells[colAudit.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                gr.Cells[colAudit.ColumnIndex].ReadOnly = true;
                gr.Cells[colEffect.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
                gr.Cells[colEffect.ColumnIndex].ReadOnly = true;
            }
        }

        private bool CheckAudit(GridRow selectedRow, PriceChangedReceiptEntity selectedReceipt)
        {
            var auditStatus = this._priceChangedReceiptService.GetAuditStatus(selectedReceipt.Id);
            if (selectedReceipt.AuditStatus != auditStatus)
            {
                var newReceipt = this._priceChangedReceiptService.GetReceiptById(selectedReceipt.Id);
                if (selectedReceipt.AuditStatus)
                    MsgBox.OK("该单据已经在别处被取消审核");
                else
                    MsgBox.OK("该单据已经在别处被审核");

                this.SetReceiptRowValue(selectedRow, newReceipt);

                this.InitLinkButton(selectedRow);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 审核指定单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <returns></returns>
        private bool AuditReceipt(PriceChangedReceiptEntity receipt)
        {
            if (!App.Instance.User.HasPermission(PermissionsContants.Instance.Drug_PriceChangedReceiptAudit))
            {
                MsgBox.OK("您在当前角色中没有权限审核药品调价单据");
                return false;
            }

            if (MsgBox.YesNo("确定审核该条调价单?") != DialogResult.Yes)
                return false;

            var result = this._priceChangedReceiptService.Audit(receipt.Id);
            if (result.Success)
            {
                receipt.AuditStatus = true;
                receipt.AuditTime = result.Value;
                receipt.AuditUser = new UserEntity() { Name = App.Instance.User.UserName };
                if (DateTime.Compare(receipt.PlanEffectTime.Date, DateTime.Now.Date) == 0)
                {
                    if (MsgBox.YesNo("审核成功,是否立即生效?") == DialogResult.Yes)
                    {
                        result = this._priceChangedReceiptService.Effect(receipt.Id, result.Value);
                        if (result.Success)
                        {
                            AlertBox.Info("生效成功");
                            receipt.ActualEffectTime = result.Value;
                            return true;
                        }

                        MsgBox.OK("生效失败" + Environment.NewLine + result.Message);
                        return false;
                    }
                }
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
        private bool CancelAuditReceipt(PriceChangedReceiptEntity receiptEntity)
        {
            if (!App.Instance.User.HasPermission(PermissionsContants.Instance.Drug_PriceChangedReceiptAudit))
            {
                MsgBox.OK("您在当前角色中没有权限取消审核调价单据");
                return false;
            }

            if (MsgBox.YesNo("确定对该条调价单取消审核?") != DialogResult.Yes)
                return false;

            var result = this._priceChangedReceiptService.CancelAudit(receiptEntity.Id);
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
        #endregion

        #region 窗体事件
        private void EffectButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.CurrentSelectedReceiptRow;
                if (selectedRow == null)
                    return;

                if (MsgBox.YesNo("确定单据立即生效?注意:此操作无法回退") != DialogResult.Yes)
                    return;

                var selectedReceipt = this.CurrentSelectedReceiptEntity;
                var result = this._priceChangedReceiptService.Effect(selectedReceipt.Id);
                if (result.Success)
                {
                    AlertBox.Info("生效成功");
                    selectedReceipt.ActualEffectTime = result.Value;
                }
                else
                {
                    selectedReceipt = this._priceChangedReceiptService.GetReceiptById(selectedReceipt.Id);
                    MsgBox.OK("生效失败" + Environment.NewLine + result.Message);
                }

                this.SetReceiptRowValue(selectedRow, selectedReceipt);
                this.InitLinkButton(selectedRow);

            });
        }
        private void DeleteButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.CurrentSelectedReceiptRow;
                if (selectedRow == null)
                    return;

                if (MsgBox.YesNo("确定删除当前单据?注意:此操作无法回退") != DialogResult.Yes)
                    return;

                var selectedReceipt = this.CurrentSelectedReceiptEntity;
                if (!this.CheckAudit(selectedRow, selectedReceipt))
                    return;

                var result = this._priceChangedReceiptService.DeleteReceipt(selectedReceipt.Id);
                if (result.Success)
                {
                    AlertBox.Info("删除成功");
                    this.dgvReceipt.PrimaryGrid.Rows.Remove(selectedRow);
                    this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                }
                else
                    MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
            });
        }

        private void EditButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedRow = this.CurrentSelectedReceiptRow;
            if (selectedRow == null)
                return;

            var selectedReceipt = this.CurrentSelectedReceiptEntity;
            if (!this.CheckAudit(selectedRow, selectedReceipt))
                return;

            FormAddPriceChangedReceipt dialog = App.Instance.CreateView<FormAddPriceChangedReceipt>();
            dialog.Operation = DataOperation.Modify;
            dialog.Dept = ViewData.Dept;
            dialog.Receipt = selectedReceipt;
            var dialogResult = dialog.ShowDialog();
            this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
            this.dgvReceipt.PrimaryGrid.ClearAll();
            this.ClickReceiptRowIndex = -1;
            if (dialogResult == DialogResult.OK)
                this.SetReceiptRowValue(selectedRow, selectedReceipt);
            if (dialogResult == DialogResult.Abort)
            {
                if (dialog.Receipt == null)
                    this.dgvReceipt.PrimaryGrid.Rows.Remove(selectedRow);
                else
                {
                    selectedReceipt = this._priceChangedReceiptService.GetReceiptById(selectedReceipt.Id);
                    this.SetReceiptRowValue(selectedRow, selectedReceipt);
                    this.InitLinkButton(selectedRow);
                }
            }
        }

        private void AuditButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMask(() =>
            {
                var selectedRow = this.dgvReceipt.GetSelectedRowByCell();
                if (selectedRow != null)
                {
                    var receipt = selectedRow.Tag as PriceChangedReceiptEntity;
                    if (!this.CheckAudit(selectedRow, receipt))
                        return;

                    var result = false;
                    if (receipt.AuditStatus)
                        result = this.CancelAuditReceipt(receipt);
                    else
                    if (!receipt.AuditStatus)
                        result = this.AuditReceipt(receipt);

                    if (result)
                    {
                        this.InitLinkButton(selectedRow);
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
                            selectedRow.CellStyles.Default.TextColor = Color.Red;
                        }

                        if (receipt.ActualEffectTime.HasValue)
                        {
                            selectedRow.Cells[colEffectStatus.ColumnIndex].Value = "已生效";
                            selectedRow.Cells[colActualEffectTime.ColumnIndex].Value = receipt.ActualEffectTime.Value;
                            selectedRow.CellStyles.Default.TextColor = Color.Black;
                        }
                        else
                        {
                            selectedRow.Cells[colEffectStatus.ColumnIndex].Value = "待生效";
                            selectedRow.Cells[colActualEffectTime.ColumnIndex].Value = receipt.ActualEffectTime;
                            selectedRow.CellStyles.Default.TextColor = Color.Red;
                        }

                    }
                }
            });
        }

        private void dgvReceipt_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (this.ClickReceiptRowIndex >= 0)
            {
                if (this.ClickReceiptRowIndex == e.GridCell.GridRow.RowIndex)
                    return;
            }
            this.ClickReceiptRowIndex = e.GridCell.GridRow.RowIndex;

            this.dgvReceiptDetail.ShowMask(() =>
            {
                var detailEntities = this._priceChangedReceiptService.GetPriceChangedDetailReceiptDetail(this.CurrentSelectedReceiptEntity.Id);
                this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();

                foreach (var detailEntity in detailEntities)
                {
                    var newRow = this.dgvReceiptDetail.PrimaryGrid.NewRow();
                    newRow.Cells[colClassCode.ColumnIndex].Value = detailEntity.Drug.ClassCode;
                    newRow.Cells[colName.ColumnIndex].Value = detailEntity.Drug.DrugName;
                    newRow.Cells[colSpecification.ColumnIndex].Value = detailEntity.Drug.Specification;
                    newRow.Cells[colManufacturer.ColumnIndex].Value = detailEntity.Drug.Manufacturer;
                    newRow.Cells[colOldPrice.ColumnIndex].Value = detailEntity.OldPrice.ToString("0.0000元");
                    newRow.Cells[colNewPrice.ColumnIndex].Value = detailEntity.NewPrice.ToString("0.0000元");
                    newRow.Cells[colPriceDifference.ColumnIndex].Value = detailEntity.PriceDifference.ToString("0.0000元");
                    newRow.Tag = detailEntity;

                    this.dgvReceiptDetail.PrimaryGrid.Rows.Add(newRow);
                }
            });
        }

        private void dgvReceiptDetail_SelectionChanged(object sender, GridEventArgs e)
        {
            this.dgvDeptInfluence.PrimaryGrid.Rows.Clear();
            GridRow gr = this.dgvReceiptDetail.GetSelectedRow();
            if (gr != null)
            {
                var selectedReceipt = this.CurrentSelectedReceiptEntity;
                if (selectedReceipt != null && (!selectedReceipt.AuditStatus || !selectedReceipt.ActualEffectTime.HasValue))
                    return;

                var selectedReceiptDetail = gr.Tag.As<PriceChangedReceiptDetailEntity>();
                var deptInfluencets = this._priceChangedReceiptService.GetPriceChangedDeptInfluence(selectedReceiptDetail.ReceiptId, selectedReceiptDetail.Id);

                foreach (var item in deptInfluencets)
                {
                    var newGr = this.dgvDeptInfluence.PrimaryGrid.NewRow();

                    newGr.Cells[colDeptName.ColumnIndex].Value = item.Dept?.Name ?? "";
                    newGr.Cells[ColBigPackageQuantity.ColumnIndex].Value = item.BigPackageQuantity;
                    newGr.Cells[colBigPackageTotal.ColumnIndex].Value = item.BigPackageTotal.ToString("0.0000元");
                    newGr.Cells[colSmallPackageQuantity.ColumnIndex].Value = item.SmallPackageQuantity;
                    newGr.Cells[colSmallPackageTotal.ColumnIndex].Value = item.SmallPackageTotal.ToString("0.0000元");

                    this.dgvDeptInfluence.PrimaryGrid.Rows.Add(newGr);

                    newGr.Tag = item;
                }
            }
        }
        private void tbxReceiptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.tbxReceiptCode.Text.Trim() == "")
                    this.tbxReceiptCode.ShowTips("请输入单据号");
                else
                    this.InitReceipt();
            }
        }
        #endregion

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddPriceChangedReceipt form = App.Instance.CreateView<FormAddPriceChangedReceipt>();
            form.Operation = DataOperation.New;
            form.Dept = this.ViewData.Dept;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newRow = this.CreateReceiptRow(form.Receipt);
                this.dgvReceipt.PrimaryGrid.Rows.Insert(0, newRow);
                newRow.CellStyles.Default.TextColor = Color.Green;
                this.dgvReceiptDetail.PrimaryGrid.Rows.Clear();
                this.dgvReceipt.PrimaryGrid.ClearAll();
                this.ClickReceiptRowIndex = -1;
                this.InitLinkButton(newRow);
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.InitReceipt();
        }
    }
}
