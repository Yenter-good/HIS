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
using HIS.Service.Core;
using HIS.Service.Core.Entities;

namespace App_Sys
{
    public partial class FormDicManager : FormBaseSet
    {
        private readonly ISysDicDetailService _sysDicDetailService;
        public FormDicManager(ISysDicDetailService sysDicDetailService, ICatalogService catalogService, ISysDicService sysDicService, IIdService idService)
        {
            InitializeComponent();

            //初始化服务
            this._sysDicDetailService = sysDicDetailService;
            this.ucDicCatalog._catalogService = catalogService;
            this.ucDicCatalog._sysDicService = sysDicService;
            this.ucDicCatalog._idService = idService;
            this.ucDicCatalog._sysDicDetailService = sysDicDetailService;
            //界面布局
            this.pnl.Controls.Add(this.bar1);
            this.bar1.Dock = DockStyle.Top;
            this.pnl.Controls.Add(this.grid);
            this.grid.BringToFront();
            this.grid.Dock = DockStyle.Fill;
            this.pnl.Dock = DockStyle.Fill;
            this.pnl.Enabled = false;
            //设置Grid
            this.grid.PrimaryGrid.UseAlternateRowStyle = true;
            //注册事件
            this.ucDicCatalog.OnSelectedDic += UcDicCatalog_OnSelectedDic;
        }

        private void UcDicCatalog_OnRemoverDic(object sender, EventArgs e)
        {
            this.pnl.Enabled = false;
            this.grid.PrimaryGrid.Rows.Clear();
        }

        private void UcDicCatalog_OnSelectedDic(object sender, string dicCode)
        {
            this.pnl.Enabled = true;
            if (dicCode == "")
            {
                this.grid.PrimaryGrid.Rows.Clear();
                this.pnl.Enabled = false;
                return;
            }
            this.grid.ShowMask(() =>
            {
                this.AddRows(this._sysDicDetailService.GetListByDicCode(dicCode, true));
            });
        }

        public override void LoadData()
        {
            this.grid.ShowMask(() =>
            {
                this.AddRows(this._sysDicDetailService.GetListByDicCode(this.ucDicCatalog._currentSelectedDic.Code, true));
            });
        }

        private void AddRows(List<SysDicDetailEntity> sysDicDetailEntities)
        {
            this.grid.PrimaryGrid.Rows.Clear();
            foreach (var detailEntity in sysDicDetailEntities)
            {
                var newRow = this.grid.PrimaryGrid.NewRow();
                newRow.Cells[colCode.ColumnIndex].Value = detailEntity.Code;
                newRow.Cells[colValue.ColumnIndex].Value = detailEntity.Value;
                newRow.Cells[colExtend.ColumnIndex].Value = detailEntity.Extensibility;
                newRow.Cells[colIsBuildIn.ColumnIndex].Value = detailEntity.IsBuiltIn;
                newRow.Cells[colDataStatus.ColumnIndex].Value = detailEntity.DataStatus.AsBoolean();
                newRow.Cells[colDescription.ColumnIndex].Value = detailEntity.Description;
                newRow.Tag = detailEntity;
                if (detailEntity.DataStatus == HIS.Service.Core.Enums.DataStatus.Disable)
                {
                    newRow.CellStyles.Default.TextColor = Color.Gray;
                }

                this.grid.PrimaryGrid.Rows.Add(newRow);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            this.ucDicCatalog.Init();
            this.SetToolBarBtiEnable();
        }

        public override void AddData()
        {
            var selectedDicEntity = this.ucDicCatalog._currentSelectedDic;

            FormDicDetailEdit form = App.Instance.CreateView<FormDicDetailEdit>();
            form.SelectedDicEntity = selectedDicEntity;
            form.Operation = HIS.Service.Core.Enums.DataOperation.New;
            form.NewDetail += Form_NewDetail;
            form.ShowDialog();
        }
        public override void EditData()
        {
            var selectedDicDetailEntity = this.GetCurrentSelectedRowBindTag<SysDicDetailEntity>();

            FormDicDetailEdit form = App.Instance.CreateView<FormDicDetailEdit>();
            form.SelectedDetailEntity = selectedDicDetailEntity;
            form.Operation = HIS.Service.Core.Enums.DataOperation.Modify;
            form.NewDetail += Form_NewDetail;
            if (form.ShowDialog() == DialogResult.OK)
            {
                var selectedRow = this.CurrentSelectedRow;
                selectedRow.Cells[colCode.ColumnIndex].Value = selectedDicDetailEntity.Code;
                selectedRow.Cells[colValue.ColumnIndex].Value = selectedDicDetailEntity.Value;
                selectedRow.Cells[colExtend.ColumnIndex].Value = selectedDicDetailEntity.Extensibility;
                selectedRow.Cells[colIsBuildIn.ColumnIndex].Value = selectedDicDetailEntity.IsBuiltIn;
                selectedRow.Cells[colDescription.ColumnIndex].Value = selectedDicDetailEntity.Description;
                selectedRow.Cells[colDataStatus.ColumnIndex].Value = selectedDicDetailEntity.DataStatus.AsBoolean();
                switch (selectedDicDetailEntity.DataStatus)
                {
                    case HIS.Service.Core.Enums.DataStatus.Disable:
                        selectedRow.CellStyles.Default.TextColor = Color.Gray;
                        break;
                    case HIS.Service.Core.Enums.DataStatus.Enable:
                        selectedRow.CellStyles.Default.TextColor = Color.Empty;
                        break;
                }
            }
        }

        public override void RemoverData()
        {
            var selectedDicDetailEntity = this.GetCurrentSelectedRowBindTag<SysDicDetailEntity>();
            if (MsgBox.YesNo($"是否确认删除明细{selectedDicDetailEntity.Value}") == DialogResult.No)
                return;

            var result = this._sysDicDetailService.Delete(selectedDicDetailEntity.Id);
            if (result.Success)
            {
                this.ClearDeletedRows();
                AlertBox.Info("删除成功");
            }
            else
            {
                MsgBox.OK(result.Message);
            }
        }
        public override void RemoverAllData()
        {
            if (MsgBox.YesNo("是否确认全部删除") == DialogResult.No)
                return;

            var selectedDicEntity = this.ucDicCatalog._currentSelectedDic;
            var result = this._sysDicDetailService.DeleteAll(selectedDicEntity.Code);
            if (result.Success)
            {
                this.LoadData();
            }
            else
                MsgBox.OK($"全部删除失败\r\n{result.Message}");
        }

        private void Form_NewDetail(object sender, SysDicDetailEntity e)
        {
            var newRow = this.grid.PrimaryGrid.NewRow();
            newRow.Cells[colCode.ColumnIndex].Value = e.Code;
            newRow.Cells[colValue.ColumnIndex].Value = e.Value;
            newRow.Cells[colExtend.ColumnIndex].Value = e.Extensibility;
            newRow.Cells[colIsBuildIn.ColumnIndex].Value = e.IsBuiltIn;
            newRow.Cells[colDescription.ColumnIndex].Value = e.Description;
            newRow.Cells[colDataStatus.ColumnIndex].Value = e.DataStatus.AsBoolean();
            newRow.Tag = e;
            switch (e.DataStatus)
            {
                case HIS.Service.Core.Enums.DataStatus.Disable:
                    newRow.CellStyles.Default.TextColor = Color.Gray;
                    break;
                case HIS.Service.Core.Enums.DataStatus.Enable:
                    newRow.CellStyles.Default.TextColor = Color.Empty;
                    break;
            }
            this.grid.PrimaryGrid.Rows.Add(newRow);
        }
    }
}
