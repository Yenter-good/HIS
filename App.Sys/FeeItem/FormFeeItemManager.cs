using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Service.Core;
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
using HIS.Core;
using HIS.DSkinControl;

namespace App_Sys
{
    /// <summary>
    /// 收费价表管理
    /// </summary>
    public partial class FormFeeItemManager : FormBaseSet
    {
        private IFeeTypeService _feeTypeService;
        private IDeptService _deptService;
        private IFeeItemService _feeItemService;
        private FeeTypeEntity _currentSelectedFeeType;
        private List<DeptEntity> _deptEntitys;
        private List<FeeTypeEntity> _feeTypeEntities;
        private List<FeeItemEntity> _cacheFeeItemEntitys;
        public FormFeeItemManager(IFeeTypeService feeTypeService, IDeptService deptService, IFeeItemService feeItemService)
        {
            InitializeComponent();

            //初始化服务
            this._feeTypeService = feeTypeService;
            this._deptService = deptService;
            this._feeItemService = feeItemService;

            //界面布局初始化
            this.pnl.Controls.Add(this.bar1);
            this.bar1.Dock = DockStyle.Top;
            this.pnl.Controls.Add(this.tbxFilter);
            this.tbxFilter.Dock = DockStyle.Top;
            this.tbxFilter.BringToFront();
            this.pnl.Controls.Add(this.grid);
            this.grid.Dock = DockStyle.Fill;
            this.grid.BringToFront();
            this.pnl.Dock = DockStyle.Fill;
            this.pnl.Enabled = false;

            //设置Grid
            this.grid.PrimaryGrid.AutoGenerateColumns = false;
            this.grid.PrimaryGrid.UseAlternateRowStyle = true;
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            this.grid.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grid.PrimaryGrid.MultiSelect = false;
            this.grid.PrimaryGrid.Filter.Visible = true;
            this.grid.PrimaryGrid.EnableFiltering = true;
            this.grid.PrimaryGrid.EnableRowFiltering = true;
            this.grid.PrimaryGrid.EnableColumnFiltering = true;
            this.grid.PrimaryGrid.ColumnDragBehavior = ColumnDragBehavior.None;

            ColumnGroupHeader columnGroupHeader = new ColumnGroupHeader();
            columnGroupHeader.RowHeight += 30;
            columnGroupHeader.HeaderText = "启用标志";
            columnGroupHeader.StartDisplayIndex = this.colDataStatus.ColumnIndex;
            columnGroupHeader.EndDisplayIndex = this.colVariableFlag.ColumnIndex;
            this.grid.PrimaryGrid.ColumnHeader.GroupHeaders.Add(columnGroupHeader);

            //设置Bar菜单
            this.btiRemover.Visible = false;
            this.btiRemoverAll.Visible = false;

            //设置右键菜单
            this.btiM_Remover.Visible = false;
            this.btiM_RemoverAll.Visible = false;

            //加载科室
            this._deptEntitys = this._deptService.GetList(true);
        }

        #region 方法
        protected override void OnShown(EventArgs e)
        {
            this.rootNode.Nodes.Clear();

            var result = this._feeTypeService.GetAll();
            if (result.Success)
            {
                this._feeTypeEntities = result.Value;
                this.advTree.BeginUpdate();
                foreach (FeeTypeEntity item in this._feeTypeEntities)
                {
                    Node node = new Node();
                    node.Tag = item;
                    node.Text = item.Name;
                    this.rootNode.Nodes.Add(node);
                }
                this.advTree.EndUpdate();

                this.advTree.AfterNodeSelect += AdvTree_AfterNodeSelect;
            }
            else
            {
                MsgBox.Error($"加载数据出现异常\r\n{result.Message}");
            }
        }

        public override void LoadData()
        {
            this.grid.ShowMask(() =>
            {
                this.pnl.Enabled = true;

                DataResult<List<FeeItemEntity>> result = null;
                if (this._currentSelectedFeeType == null)
                    result = this._feeItemService.GetAll();
                else
                    result = this._feeItemService.GetListByFeeTypeCode(this._currentSelectedFeeType.Code);

                if (result.Success)
                {
                    this._cacheFeeItemEntitys = result.Value;
                    this.grid.PrimaryGrid.DataSource = this._cacheFeeItemEntitys;
                }
                else
                    MsgBox.OK($"加载数据出现异常\r\n{result.Message}");
            });
        }

        public override void AddData()
        {
            using (FormFeeItemAdd dialog = new FormFeeItemAdd((feeItem) =>
            {
                GridRow gr = this.grid.PrimaryGrid.NewRow(true);
                FeeItemEntity feeItemEntity = gr.DataItem as FeeItemEntity;
                feeItemEntity.Id = feeItem.Id;
                feeItemEntity.Code = feeItem.Code;
                feeItemEntity.Name = feeItem.Name;
                feeItemEntity.DataStatus = feeItem.DataStatus;
                feeItemEntity.Specification = feeItem.Specification;
                feeItemEntity.Measure = feeItem.Measure;
                feeItemEntity.MeasureUnit = feeItem.MeasureUnit;
                feeItemEntity.Price = feeItem.Price;
                feeItemEntity.SearchCode = feeItem.SearchCode;
                feeItemEntity.WubiCode = feeItem.WubiCode;
                feeItemEntity.FinanceTypeCode = feeItem.FinanceTypeCode;
                feeItemEntity.ExecDeptId = feeItem.ExecDeptId;
                feeItemEntity.OFlag = feeItem.OFlag;
                feeItemEntity.IFlag = feeItem.IFlag;
                feeItemEntity.SFlag = feeItem.SFlag;
                feeItemEntity.MFlag = feeItem.MFlag;
                feeItemEntity.VariableFlag = feeItem.VariableFlag;

                gr.Cells[colDataStatus.ColumnIndex].Value = feeItemEntity.DataStatus.AsBoolean();
                if (!gr.IsOnScreen)
                    gr.EnsureVisible();
                gr.IsSelected = true;
                if (this._cacheFeeItemEntitys == null)
                    this._cacheFeeItemEntitys = new List<FeeItemEntity>();
                this._cacheFeeItemEntitys.Add(feeItemEntity);

            }, this._currentSelectedFeeType, this._deptEntitys))
            {
                dialog.ShowDialog();
            }
        }

        public override void EditData()
        {
            FeeItemEntity feeItemEntity = this.GetCurrentSelectedRowBindItem<FeeItemEntity>();
            string oldFinanceTypeCode = feeItemEntity.FinanceTypeCode;
            using (FormFeeItemEdit dialog = new FormFeeItemEdit(this._feeTypeEntities, this._deptEntitys, feeItemEntity))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GridRow gr = this.CurrentSelectedRow;
                    if (oldFinanceTypeCode != feeItemEntity.FinanceTypeCode)
                    {
                        gr.IsDeleted = true;
                        this.grid.PrimaryGrid.PurgeDeletedRows();
                    }
                    else
                    {
                        this.CellValueFormat(gr, feeItemEntity);
                        gr.ReloadRow();
                    }
                }
            }
        }
        #endregion

        #region 窗体事件
        private void AdvTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this._currentSelectedFeeType = null;
            if (e.Node.Tag != null)
                this._currentSelectedFeeType = e.Node.Tag as FeeTypeEntity;

            this.btiAdd.Enabled = this._currentSelectedFeeType != null;

            this.LoadData();
        }
        private void grid_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow gr in e.GridPanel.Rows)
            {
                if (gr != null && gr.DataItem != null)
                {
                    FeeItemEntity feeItemEntity = gr.DataItem as FeeItemEntity;
                    if (feeItemEntity != null)
                    {
                        this.CellValueFormat(gr, feeItemEntity);
                    }
                }
            }
        }
        private void CellValueFormat(GridRow gr, FeeItemEntity feeItemEntity)
        {
            //数据状态
            if (feeItemEntity.DataStatus == DataStatus.Enable)
                gr.Cells[colDataStatus.ColumnIndex].Value = true;
            else if (feeItemEntity.DataStatus == DataStatus.Disable)
            {
                gr.Cells[colDataStatus.ColumnIndex].Value = false;
                gr.CellStyles.Default.TextColor = Color.Gray;
            }

            //科室
            if (feeItemEntity.ExecDeptId > 0)
            {
                if (this._deptEntitys == null || this._deptEntitys.Count == 0)
                    gr.Cells[colExecDeptId.ColumnIndex].Value = null;
                else
                    gr.Cells[colExecDeptId.ColumnIndex].Value = this._deptEntitys.Find(d => d.Id == feeItemEntity.ExecDeptId)?.Name ?? null;
            }
            else
                gr.Cells[colExecDeptId.ColumnIndex].Value = null;

            //财务分类
            if (!string.IsNullOrWhiteSpace(feeItemEntity.FinanceTypeCode))
            {
                if (this._feeTypeEntities == null || this._feeTypeEntities.Count == 0)
                    gr.Cells[colFeeType.ColumnIndex].Value = null;
                else
                    gr.Cells[colFeeType.ColumnIndex].Value = this._feeTypeEntities.Find(d => d.Code.Trim() == feeItemEntity.FinanceTypeCode.Trim())?.Name ?? null;
            }
        }
        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            if (this._cacheFeeItemEntitys == null || this._cacheFeeItemEntitys.Count == 0)
                return;
            string inputTxt = this.tbxFilter.Text.Trim().ToUpper();
            if (inputTxt == "")
            {
                this.grid.PrimaryGrid.DataSource = this._cacheFeeItemEntitys;
                return;
            }
            var filterDatas = this._cacheFeeItemEntitys
                .Where(d => d.SearchCode.Contains(inputTxt) || d.WubiCode.Contains(inputTxt) || d.Name.Contains(inputTxt))
                .ToList();

            this.grid.PrimaryGrid.DataSource = filterDatas;

        }
        #endregion

        //private void grid_CellClick(object sender, GridCellClickEventArgs e)
        //{
        //    if (e.GridCell.ColumnIndex == colDataStatus.ColumnIndex)
        //    {
        //        this.EditDataStatus(e.GridCell);
        //    }
        //    else if (e.GridCell.ColumnIndex == colOFlag.ColumnIndex)
        //    {
        //        this.EditFlag(e.GridCell, (f, v) =>
        //        {
        //            return this._feeItemService.UpdateOFlagById(f.Id, v);
        //        });
        //    }
        //    else if (e.GridCell.ColumnIndex == colIFlag.ColumnIndex)
        //    {
        //        this.EditFlag(e.GridCell, (f, v) =>
        //        {
        //            return this._feeItemService.UpdateIFlagById(f.Id, v);
        //        });
        //    }
        //    else if (e.GridCell.ColumnIndex == colSFlag.ColumnIndex)
        //    {
        //        this.EditFlag(e.GridCell, (f, v) =>
        //        {
        //            return this._feeItemService.UpdateSFlagById(f.Id, v);
        //        });
        //    }
        //    else if (e.GridCell.ColumnIndex == colMFlag.ColumnIndex)
        //    {
        //        this.EditFlag(e.GridCell, (f, v) =>
        //        {
        //            return this._feeItemService.UpdateMFlagById(f.Id, v);
        //        });
        //    }
        //    else if (e.GridCell.ColumnIndex == colVariableFlag.ColumnIndex)
        //    {
        //        this.EditFlag(e.GridCell, (f, v) =>
        //        {
        //            return this._feeItemService.UpdateVariableFlagById(f.Id, v);
        //        });
        //    }
        //}

        //private void EditDataStatus(GridCell gridCell)
        //{
        //    FeeItemEntity feeItemEntity = this.GetCurrentSelectedRowBindItem<FeeItemEntity>();
        //    if (feeItemEntity != null)
        //    {
        //        bool cellValue = gridCell.Value.AsBoolean();

        //        DataStatus dataStatus = cellValue == true ? DataStatus.Disable : DataStatus.Enable;

        //        var result = this._feeItemService.UpdateDataStatusById(feeItemEntity.Id, dataStatus);
        //        if (result.Success)
        //        {
        //            gridCell.Value = !cellValue;
        //            this.CurrentSelectedRow.CellStyles.Default.TextColor = cellValue ? Color.Gray : Color.Empty;

        //            feeItemEntity.DataStatus = dataStatus;
        //        }
        //        else
        //            HIS.Core.MsgBox.OK($"修改启用状态失败\r\n{result.Message}");
        //    }
        //}

        //private void EditFlag(GridCell gridCell, Func<FeeItemEntity, bool, DataResult> func)
        //{
        //    FeeItemEntity feeItemEntity = this.GetCurrentSelectedRowBindItem<FeeItemEntity>();
        //    if (feeItemEntity != null)
        //    {
        //        bool cellValue = gridCell.Value.AsBoolean();
        //        var result = func?.Invoke(feeItemEntity, !cellValue);
        //        if (result.Success)
        //        {
        //            gridCell.Value = !cellValue;
        //            typeof(FeeItemEntity).GetProperty(gridCell.GridColumn.DataPropertyName).SetValue(feeItemEntity, !cellValue);
        //        }
        //        else
        //        {
        //            HIS.Core.MsgBox.Error($"操作失败\r\n{result.Message}");
        //        }
        //    }
        //}

    }
}
