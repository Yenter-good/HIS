using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
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
    public partial class FormDosageformUsageMapper : BaseForm
    {
        private readonly ISysDictQueryService _dictQueryService;
        private readonly IUsageService _usageService;

        private List<LongItem> _allDrugformEntities;
        private List<UsageEntity> _allUsageEntities;
        private Dictionary<long, List<UsageEntity>> _drugformUsageMapper;

        private LongItem _selectedDrugform;

        public FormDosageformUsageMapper(ISysDictQueryService dictQueryService, IUsageService usageService)
        {
            InitializeComponent();
            this._dictQueryService = dictQueryService;
            this._usageService = usageService;
        }

        #region 初始化

        /// <summary>
        /// 初始化所有数据
        /// </summary>
        private void InitData()
        {
            _allDrugformEntities = _dictQueryService.GetDrugform();
            _allUsageEntities = _usageService.GetAll(true);
            _drugformUsageMapper = _usageService.GetAllDrugformUsageMapper();
        }
        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitUI()
        {
            foreach (var drugformEntity in _allDrugformEntities)
            {
                var newItem = new ListBoxItem();
                newItem.Text = drugformEntity.Value;
                newItem.Tag = drugformEntity;

                this.lbDosageform.Items.Add(newItem);
            }
        }
        #endregion

        private void FormDosageformUsageMapper_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });

        }

        #region 方法
        private void InsertToDrugform(GridRow row)
        {
            var usageEntity = row.Tag as UsageEntity;
            var result = _usageService.AddToDrugform(_selectedDrugform.Key, usageEntity.Id);

            if (result.Success)
            {
                var newRow = this.dgvDrugformUsage.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = usageEntity.Name;
                newRow.Cells[colCode.ColumnIndex].Value = usageEntity.Code;
                newRow.Cells[colSearchCode.ColumnIndex].Value = usageEntity.SearchCode;
                newRow.Tag = usageEntity;
                this.dgvDrugformUsage.PrimaryGrid.Rows.Add(newRow);

                this.dgvAllUsage.PrimaryGrid.Rows.Remove(row);

                if (!_drugformUsageMapper.ContainsKey(_selectedDrugform.Key))
                    _drugformUsageMapper[_selectedDrugform.Key] = new List<UsageEntity>();
                _drugformUsageMapper[_selectedDrugform.Key].Add(usageEntity);

            }
            else
                MsgBox.OK("添加失败" + Environment.NewLine + result.Message);
        }

        private void InsertToDrugform(SelectedElementCollection rows)
        {
            var usageIds = rows.Select(p => p.Tag.As<UsageEntity>().Id).ToList();
            var result = _usageService.AddToDrugform(_selectedDrugform.Key, usageIds);

            if (result.Success)
            {
                foreach (var row in rows)
                {
                    var usageEntity = row.Tag as UsageEntity;
                    var newRow = this.dgvDrugformUsage.PrimaryGrid.NewRow();
                    newRow.Cells[colName.ColumnIndex].Value = usageEntity.Name;
                    newRow.Cells[colCode.ColumnIndex].Value = usageEntity.Code;
                    newRow.Cells[colSearchCode.ColumnIndex].Value = usageEntity.SearchCode;
                    newRow.Tag = usageEntity;
                    this.dgvDrugformUsage.PrimaryGrid.Rows.Insert(0, newRow);

                    this.dgvAllUsage.PrimaryGrid.Rows.Remove(row);


                    if (!_drugformUsageMapper.ContainsKey(_selectedDrugform.Key))
                        _drugformUsageMapper[_selectedDrugform.Key] = new List<UsageEntity>();
                    _drugformUsageMapper[_selectedDrugform.Key].Add(usageEntity);
                }

            }
            else
                MsgBox.OK("添加失败" + Environment.NewLine + result.Message);
        }

        private void DeleteFromDrugform(GridRow row)
        {
            var usageEntity = row.Tag as UsageEntity;
            var result = _usageService.DeleteFromDrugform(_selectedDrugform.Key, usageEntity.Id);

            if (result.Success)
            {
                var newRow = this.dgvAllUsage.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = usageEntity.Name;
                newRow.Cells[colCode.ColumnIndex].Value = usageEntity.Code;
                newRow.Cells[colSearchCode.ColumnIndex].Value = usageEntity.SearchCode;
                newRow.Tag = usageEntity;
                this.dgvAllUsage.PrimaryGrid.Rows.Insert(0, newRow);

                this.dgvDrugformUsage.PrimaryGrid.Rows.Remove(row);

                _drugformUsageMapper[_selectedDrugform.Key].RemoveAll(p => p.Id == usageEntity.Id);
            }
            else
                MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
        }
        private void DeleteFromDrugform(SelectedElementCollection rows)
        {
            var usageIds = rows.Select(p => p.Tag.As<UsageEntity>().Id).ToList();
            var result = _usageService.DeleteFromDrugform(_selectedDrugform.Key, usageIds);

            if (result.Success)
            {
                foreach (var row in rows)
                {
                    var usageEntity = row.Tag as UsageEntity;
                    var newRow = this.dgvAllUsage.PrimaryGrid.NewRow();
                    newRow.Cells[colName.ColumnIndex].Value = usageEntity.Name;
                    newRow.Cells[colCode.ColumnIndex].Value = usageEntity.Code;
                    newRow.Cells[colSearchCode.ColumnIndex].Value = usageEntity.SearchCode;
                    newRow.Tag = usageEntity;
                    this.dgvAllUsage.PrimaryGrid.Rows.Insert(0, newRow);

                    this.dgvDrugformUsage.PrimaryGrid.Rows.Remove(row);

                    _drugformUsageMapper[_selectedDrugform.Key].RemoveAll(p => p.Id == usageEntity.Id);
                }

            }
            else
                MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
        }
        private void FillDGV(List<UsageEntity> usageEntities, SuperGridControl dgv)
        {
            dgv.PrimaryGrid.Rows.Clear();
            foreach (var usageEntity in usageEntities)
            {
                var newRow = dgv.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = usageEntity.Name;
                newRow.Cells[colCode.ColumnIndex].Value = usageEntity.Code;
                newRow.Cells[colSearchCode.ColumnIndex].Value = usageEntity.SearchCode;
                if (dgv.PrimaryGrid.Columns.Contains(this.colExistDefault))
                    newRow.Cells[colExistDefault.ColumnIndex].Value = usageEntity.IsDefault;
                newRow.Tag = usageEntity;
                dgv.PrimaryGrid.Rows.Add(newRow);
            }
        }
        #endregion

        #region 窗体事件

        private void lbDosageform_ItemClick(object sender, EventArgs e)
        {
            _selectedDrugform = this.lbDosageform.SelectedItem.As<ListBoxItem>().Tag as LongItem;
            if (!_drugformUsageMapper.ContainsKey(_selectedDrugform.Key))
            {
                this.dgvDrugformUsage.PrimaryGrid.Rows.Clear();
                FillDGV(_allUsageEntities, this.dgvAllUsage);
                return;
            }
            var usageEntities = _drugformUsageMapper[_selectedDrugform.Key];
            //指定剂型已经绑定的用法id
            var usageIds = usageEntities.Select(p => p.Id).ToList();
            //默认用法id
            var defaultUsageId = usageEntities.Find(p => p.IsDefault);
            //指定剂型剩余可选的用法
            var allUsageEntities = _allUsageEntities.Where(p => p.Id._NotIn(usageIds)).ToList();
            //指定剂型已经绑定的用法
            var existUsageEntities = _allUsageEntities.Where(p => p.Id._In(usageIds)).ToList();
            //设置默认用法
            var defaultUsage = usageEntities.Find(p => p.IsDefault);
            if (defaultUsage != null)
            {
                existUsageEntities.ForEach(p => p.IsDefault = false);
                existUsageEntities.Find(p => p.Id == defaultUsage.Id).IsDefault = true;
            }

            FillDGV(allUsageEntities, this.dgvAllUsage);
            FillDGV(existUsageEntities, this.dgvDrugformUsage);
        }



        private void dgvAllUsage_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            InsertToDrugform(e.GridCell.GridRow);
        }

        private void dgvDrugformUsage_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            if (e.GridCell.ColumnIndex == this.colExistDefault.ColumnIndex)
                return;
            DeleteFromDrugform(e.GridCell.GridRow);
        }

        private void btnAddToDrugform_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgvAllUsage.PrimaryGrid.GetSelectedRows();
            if (selectedRow.Count == 0)
                return;

            InsertToDrugform(selectedRow);
        }

        private void btnDeleteFromDrugform_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dgvDrugformUsage.PrimaryGrid.GetSelectedRows();
            if (selectedRow.Count == 0)
                return;

            DeleteFromDrugform(selectedRow);
        }

        private void dgvDrugformUsage_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (e.GridCell.ColumnIndex == this.colExistDefault.ColumnIndex)
            {
                var usageEntity = e.GridCell.GridRow.Tag as UsageEntity;
                var result = _usageService.SetDefault(_selectedDrugform.Key, usageEntity.Id);
                if (result.Success)
                {
                    foreach (GridRow row in this.dgvDrugformUsage.PrimaryGrid.Rows)
                        row.Cells[colExistDefault.ColumnIndex].Value = false;
                    e.GridCell.Value = true;
                    _drugformUsageMapper[_selectedDrugform.Key].ForEach(p => p.IsDefault = false);
                    var mapper = _drugformUsageMapper[_selectedDrugform.Key].Find(p => p.Id == usageEntity.Id);
                    if (mapper != null)
                        mapper.IsDefault = true;
                }
            }
        }
        #endregion
    }
}
