using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
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

namespace App_Sys.Dept
{
    public partial class FormDeptManager : BaseForm
    {
        private readonly IDeptService _deptService;

        private List<DeptEntity> _allDeptEntities;

        public FormDeptManager(IDeptService deptService)
        {
            InitializeComponent();
            this._deptService = deptService;
        }

        #region 初始化

        private void InitData()
        {
            _allDeptEntities = _deptService.GetList(true);
        }

        private void InitUI()
        {
            this.dgvDept.PrimaryGrid.Rows.Clear();
            BuildDeptTree(0, this.dgvDept.PrimaryGrid.Rows, -1);
            this.dgvDept.PrimaryGrid.ExpandAll();
            foreach (GridRow row in this.dgvDept.PrimaryGrid.Rows)
                SetDisableDeptVisible(row, !this.swShowDisable.Value, DataStatus.Disable.GetDescription());
        }
        #endregion

        #region 方法

        /// <summary>
        /// 设置停用科室的显示状态
        /// </summary>
        /// <param name="parentRow"></param>
        /// <param name="isHide"></param>
        /// <param name="disableText"></param>
        private void SetDisableDeptVisible(GridRow parentRow, bool isHide, string disableText)
        {
            if (parentRow.Cells[colStatus.ColumnIndex].Value.ToString() == disableText)
            {
                if (isHide)
                    parentRow.Visible = false;
                else
                    parentRow.Visible = true;
            }
            foreach (GridRow row in parentRow.Rows)
                SetDisableDeptVisible(row, isHide, disableText);
        }

        private void BuildDeptTree(long parentId, GridItemsCollection rows, int deepIndex)
        {
            var depts = _allDeptEntities.Where(p => p.Parent.Id == parentId).ToList();
            deepIndex++;
            foreach (var dept in depts)
            {
                var newRow = this.dgvDept.PrimaryGrid.NewRow();
                newRow.Cells[colCode.ColumnIndex].Value = dept.Code;
                newRow.Cells[colName.ColumnIndex].Value = "".PadRight(deepIndex * 2, '　') + dept.Name;
                newRow.Cells[colAliasName.ColumnIndex].Value = dept.AliasName;
                newRow.Cells[colCategory.ColumnIndex].Value = dept.Category.Value;
                newRow.Cells[colStatus.ColumnIndex].Value = ((DataStatus)dept.DataStatus).GetDescription();
                if (dept.DataStatus == (int)DataStatus.Disable)
                    newRow.CellStyles.Default.TextColor = Color.Red;
                newRow.Cells[colLocation.ColumnIndex].Value = dept.Location;
                newRow.Tag = dept;

                rows.Add(newRow);
                BuildDeptTree(dept.Id, newRow.Rows, deepIndex);
            }
        }
        /// <summary>
        /// 寻找到指定科室id得数据行
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="parentRows"></param>
        /// <returns></returns>
        private GridRow FindRow(long deptId, GridItemsCollection parentRows)
        {
            GridRow row = null;
            foreach (GridRow gridRow in parentRows)
            {
                if (gridRow.Tag.As<DeptEntity>().Id == deptId)
                    row = gridRow;
                if (row == null)
                    row = FindRow(deptId, gridRow.Rows);
                else
                    continue;
            }
            return row;
        }
        /// <summary>
        /// 寻找指定数据行在第几层
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private int FindRowDeep(GridElement row, int deep)
        {
            if (row.Parent != this.dgvDept.PrimaryGrid)
            {
                deep++;
                return FindRowDeep(row.Parent, deep);
            }
            return deep;
        }
        #endregion

        private void FormDeptManager_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });
        }

        #region 窗体事件

        private void btnRestop_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDept.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var deptEntity = selectedRow.Tag as DeptEntity;

            if (deptEntity.DataStatus != DataStatus.Enable)
            {
                var result = _deptService.EnableDept(deptEntity.Id);
                if (result.Success)
                {
                    AlertBox.Info("修改成功");
                    deptEntity.DataStatus = DataStatus.Enable;
                    selectedRow.Cells[colStatus.ColumnIndex].Value = DataStatus.Enable.GetDescription();
                    selectedRow.CellStyles.Default.TextColor = Color.Black;
                }
                else
                {
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDept.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var deptEntity = selectedRow.Tag as DeptEntity;

            if (deptEntity.DataStatus != (int)DataStatus.Disable)
            {
                DialogResult dialogResult = DialogResult.None;
                DataResult result = DataResult.True();
                if (selectedRow.Rows.Count > 0)
                {
                    dialogResult = MsgBox.YesNoCancel("该科室下属拥有科室,请选择操作" + Environment.NewLine + "是:将下属科室升级到和当前科室平级" + Environment.NewLine + "否:将下属科室一并停用");
                }
                if (dialogResult == DialogResult.Yes)
                {
                    var dict = _allDeptEntities.Where(p => p.Parent.Id == deptEntity.Id).ToDictionary(p => p.Id, p => deptEntity.Parent.Id);
                    result = _deptService.DisableDeptWithUpgrade(deptEntity.Id, dict);
                    if (result.Success)
                    {
                        foreach (var item in dict)
                            _allDeptEntities.Find(p => p.Id == item.Key).Parent = deptEntity.Parent;
                        deptEntity.DataStatus = (int)DataStatus.Disable;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    List<long> disableIds = new List<long>();
                    new DeptManagerHelper().GetChildIds(_allDeptEntities, deptEntity.Id, ref disableIds);
                    disableIds.Add(deptEntity.Id);
                    result = _deptService.DisableDepts(disableIds);
                    if (result.Success)
                    {
                        foreach (var item in disableIds)
                            _allDeptEntities.Find(p => p.Id == item).DataStatus = (int)DataStatus.Disable;
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                    return;
                else
                {
                    result = _deptService.DisableDept(deptEntity.Id);
                    if (result.Success)
                        deptEntity.DataStatus = (int)DataStatus.Disable;
                }

                if (result.Success)
                {
                    AlertBox.Info("修改成功");
                    InitUI();
                }
                else
                {
                    MsgBox.OK("修改失败" + Environment.NewLine + result.Message);
                }
            }
        }

        private void swShowDisable_ValueChanged(object sender, EventArgs e)
        {
            foreach (GridRow row in this.dgvDept.PrimaryGrid.Rows)
                SetDisableDeptVisible(row, !this.swShowDisable.Value, DataStatus.Disable.GetDescription());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvDept.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var deptEntity = selectedRow.Tag as DeptEntity;

            FormDeptEdit form = App.Instance.CreateView<FormDeptEdit>();
            form.SelectedDept = deptEntity;
            form.Operation = DataOperation.Modify;
            form.AllDept = _allDeptEntities.Where(p => p.DataStatus == DataStatus.Enable).ToList();
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedRow.Cells[colAliasName.ColumnIndex].Value = deptEntity.AliasName;
                selectedRow.Cells[colCategory.ColumnIndex].Value = deptEntity.Category.Value;
                selectedRow.Cells[colLocation.ColumnIndex].Value = deptEntity.Location;

                if (selectedRow.Parent != this.dgvDept.PrimaryGrid)
                {
                    var parentRow = this.FindRow(deptEntity.Parent.Id, this.dgvDept.PrimaryGrid.Rows);
                    selectedRow.Parent.As<GridRow>().Rows.Remove(selectedRow);
                    parentRow.Rows.Add(selectedRow);

                    int deep = FindRowDeep(selectedRow, 0);
                    selectedRow.Cells[colName.ColumnIndex].Value = "".PadRight(deep * 2, '　') + deptEntity.Name;
                }
                else
                    selectedRow.Cells[colName.ColumnIndex].Value = deptEntity.Name;
            }
        }

        private void dgvDept_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            var deptEntity = e.GridCell.GridRow.Tag as DeptEntity;

            FormDeptEdit form = App.Instance.CreateView<FormDeptEdit>();
            form.SelectedDept = deptEntity;
            form.Operation = DataOperation.Modify;
            form.AllDept = _allDeptEntities;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var oldName = e.GridCell.GridRow.Cells[colName.ColumnIndex].Value.ToString();
                var count = oldName.ToCharArray().Count(p => p == '　');

                e.GridCell.GridRow.Cells[colName.ColumnIndex].Value = "".PadRight(count, '　') + deptEntity.Name;
                e.GridCell.GridRow.Cells[colAliasName.ColumnIndex].Value = deptEntity.AliasName;
                e.GridCell.GridRow.Cells[colCategory.ColumnIndex].Value = deptEntity.Category.Value;
                e.GridCell.GridRow.Cells[colLocation.ColumnIndex].Value = deptEntity.Location;

                if (e.GridCell.GridRow.Parent != this.dgvDept.PrimaryGrid)
                {
                    if (e.GridCell.GridRow.Parent != this.dgvDept.PrimaryGrid)
                    {
                        var parentRow = this.FindRow(deptEntity.Parent.Id, this.dgvDept.PrimaryGrid.Rows);
                        e.GridCell.GridRow.Parent.As<GridRow>().Rows.Remove(e.GridCell.GridRow);
                        parentRow.Rows.Add(e.GridCell.GridRow);

                        int deep = FindRowDeep(e.GridCell.GridRow, 0);
                        e.GridCell.GridRow.Cells[colName.ColumnIndex].Value = "".PadRight(deep * 2, '　') + deptEntity.Name;
                    }
                    else
                        e.GridCell.GridRow.Cells[colName.ColumnIndex].Value = deptEntity.Name;
                }
            }
        }
        #endregion

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormDeptEdit form = App.Instance.CreateView<FormDeptEdit>();
            form.Operation = DataOperation.New;
            form.NewDept += Form_NewDept;
            form.AllDept = _allDeptEntities;
            form.ShowDialog();
        }

        private void Form_NewDept(object sender, DeptEntity e)
        {
            var parentRow = e.Parent == null ? null : this.FindRow(e.Parent.Id, this.dgvDept.PrimaryGrid.Rows);

            var newRow = this.dgvDept.PrimaryGrid.NewRow();
            newRow.Cells[colCode.ColumnIndex].Value = e.Code;
            newRow.Cells[colName.ColumnIndex].Value = parentRow == null ? e.Name : "".PadRight((this.FindRowDeep(parentRow, 0) + 1) * 2, '　') + e.Name;
            newRow.Cells[colAliasName.ColumnIndex].Value = e.AliasName;
            newRow.Cells[colCategory.ColumnIndex].Value = e.Category.Value;
            newRow.Cells[colStatus.ColumnIndex].Value = ((DataStatus)e.DataStatus).GetDescription();
            newRow.Cells[colLocation.ColumnIndex].Value = e.Location;
            newRow.Tag = e;

            newRow.CellStyles.Default.TextColor = Color.Green;
            if (parentRow == null)
                this.dgvDept.PrimaryGrid.Rows.Add(newRow);
            else
                parentRow.Rows.Add(newRow);

            if (!newRow.IsOnScreen)
                newRow.EnsureVisible();
        }

        private void btnSetPharmacy_Click(object sender, EventArgs e)
        { 
            var selectedRows = this.dgvDept.GetSelectedRows();
            if (selectedRows.Count == 0)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var selectedRow = selectedRows[0] as GridRow;
            var deptEntity = selectedRow.Tag as DeptEntity;

            FormDeptPharmacy from = new FormDeptPharmacy(_deptService);
            from.currDept = deptEntity;
            from.ShowDialog();

        }
    }
}
