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

namespace App_Sys.Dic
{
    public partial class FormUsage : BaseForm
    {
        private readonly IUsageService _usageService;

        private List<UsageEntity> _allUsageEntities;
        public FormUsage(IUsageService usageService)
        {
            InitializeComponent();
            this._usageService = usageService;
        }

        #region 初始化

        private void InitData()
        {
            _allUsageEntities = _usageService.GetAll(true);

        }

        private void InitUI()
        {
            _allUsageEntities = _allUsageEntities.OrderBy(p => (int)p.Category).ThenBy(p => p.No).ToList();
            this.dgvUsage.PrimaryGrid.Rows.Clear();
            foreach (var usage in _allUsageEntities)
            {
                var newRow = this.dgvUsage.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = usage.Name;
                newRow.Cells[colCode.ColumnIndex].Value = usage.Code;
                newRow.Cells[colSearchCode.ColumnIndex].Value = usage.SearchCode;
                newRow.Cells[colWubiCode.ColumnIndex].Value = usage.WubiCode;
                newRow.Cells[colCategory.ColumnIndex].Value = usage.Category.GetDescription();
                newRow.Cells[colStatus.ColumnIndex].Value = usage.DataStatus.GetDescription();
                newRow.Tag = usage;
                if (usage.DataStatus == DataStatus.Disable && !this.swShowDisable.Value)
                    newRow.Visible = false;

                this.dgvUsage.PrimaryGrid.Rows.Add(newRow);
            }
        }
        #endregion

        private void FormUsage_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });
        }

        #region 窗体事件

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormUsageEdit form = App.Instance.CreateView<FormUsageEdit>();
            form.Operation = DataOperation.New;
            form.NewUsage += Form_NewUsage;
            form.ShowDialog();
        }

        private void Form_NewUsage(object sender, UsageEntity e)
        {
            _allUsageEntities.Add(e);
            InitUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUsage.PrimaryGrid.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var selectedUsage = selectedRow.Tag as UsageEntity;
            FormUsageEdit form = App.Instance.CreateView<FormUsageEdit>();
            form.Operation = DataOperation.Modify;
            form.SelectedUsage = selectedUsage;
            if (form.ShowDialog() == DialogResult.OK)
                InitUI();
        }


        private void btnEnable_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUsage.PrimaryGrid.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var usageEntity = selectedRow.Tag as UsageEntity;
            if (usageEntity.DataStatus == DataStatus.Enable)
                return;

            var result = _usageService.EnableUsage(usageEntity.Id);
            if (result.Success)
            {
                AlertBox.Info("启用成功");
                usageEntity.DataStatus = DataStatus.Enable;
                selectedRow.Cells[colStatus.ColumnIndex].Value = DataStatus.Enable.GetDescription();
            }
            else
                MsgBox.OK("启用失败" + Environment.NewLine + result.Message);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUsage.PrimaryGrid.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var usageEntity = selectedRow.Tag as UsageEntity;
            if (usageEntity.DataStatus == DataStatus.Disable)
                return;

            var result = _usageService.DisableUsage(usageEntity.Id);
            if (result.Success)
            {
                AlertBox.Info("停用成功");
                usageEntity.DataStatus = DataStatus.Disable;
                selectedRow.Cells[colStatus.ColumnIndex].Value = DataStatus.Disable.GetDescription();
                if (!this.swShowDisable.Value)
                    selectedRow.Visible = false;
            }
            else
                MsgBox.OK("停用失败" + Environment.NewLine + result.Message);
        }

        private void swShowDisable_ValueChanged(object sender, EventArgs e)
        {
            if (swShowDisable.Value)
            {
                foreach (GridRow row in this.dgvUsage.PrimaryGrid.Rows)
                    row.Visible = true;
            }
            else
            {
                var disableText = DataStatus.Disable.GetDescription();
                foreach (GridRow row in this.dgvUsage.PrimaryGrid.Rows)
                {
                    if (row.Cells[colStatus.ColumnIndex].Value.ToString() == disableText)
                        row.Visible = false;
                }
            }
        }

        private void dgvUsage_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            var selectedRow = e.GridCell.GridRow;
            var selectedUsage = selectedRow.Tag as UsageEntity;
            FormUsageEdit form = App.Instance.CreateView<FormUsageEdit>();
            form.Operation = DataOperation.Modify;
            form.SelectedUsage = selectedUsage;
            if (form.ShowDialog() == DialogResult.OK)
                InitUI();
        }
        #endregion
    }
}
