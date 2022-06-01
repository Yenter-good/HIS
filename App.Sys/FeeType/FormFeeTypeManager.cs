using DevComponents.DotNetBar.SuperGrid;
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

namespace App_Sys
{
    /// <summary>
    /// 费用类型管理
    /// </summary>
    public partial class FormFeeTypeManager : FormBaseSet
    {
        private IFeeTypeService _feeTypeService;

        public FormFeeTypeManager(IFeeTypeService feeTypeService)
        {
            InitializeComponent();

            //初始化服务
            this._feeTypeService = feeTypeService;

            //设置Bar菜单
            this.btiRemover.Visible = false;
            this.btiRemoverAll.Visible = false;

            //设置右键菜单
            this.btiM_Remover.Visible = false;
            this.btiM_RemoverAll.Visible = false;

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
        }

        public override void LoadData()
        {
            var result = this._feeTypeService.GetAll();

            if (result.Success)
            {
                this.grid.PrimaryGrid.DataSource = result.Value;
            }
            else
            {
                HIS.Core.MsgBox.OK($"加载失败\r\n{result.Message}");
            }
        }

        private void grid_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow gr in e.GridPanel.Rows)
            {
                if (gr != null && gr.DataItem != null)
                {
                    FeeTypeEntity feeTypeEntity = gr.DataItem as FeeTypeEntity;
                    if (feeTypeEntity != null)
                    {
                        switch (feeTypeEntity.DataStatus)
                        {
                            case HIS.Service.Core.Enums.DataStatus.Disable:
                                gr.Cells[colDataStatus.ColumnIndex].Value = false;
                                gr.CellStyles.Default.TextColor = Color.Gray;
                                break;
                            case HIS.Service.Core.Enums.DataStatus.Enable:
                                gr.Cells[colDataStatus.ColumnIndex].Value = true;
                                break;
                        }
                    }
                }
            }
        }

        public override void AddData()
        {
            using (FormFeeTypeAdd dialog = new FormFeeTypeAdd((feeItem) =>
            {

                GridRow gr = this.grid.PrimaryGrid.NewRow(true);
                FeeTypeEntity feeTypeEntity = gr.DataItem as FeeTypeEntity;

                feeTypeEntity.Code = feeItem.Code;
                feeTypeEntity.Name = feeItem.Name;
                feeTypeEntity.SearchCode = feeItem.SearchCode;

                gr.Cells[colDataStatus.ColumnIndex].Value = feeItem.DataStatus.AsBoolean();

                if (!gr.IsOnScreen)
                    gr.EnsureVisible();
                gr.IsSelected = true;


            }))
            {
                dialog.ShowDialog();
            }
        }

        public override void EditData()
        {
            FeeTypeEntity feeTypeEntity = this.GetCurrentSelectedRowBindItem<FeeTypeEntity>();
            using (FormFeeTypeEdit dialog = new FormFeeTypeEdit(feeTypeEntity))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GridRow gr = this.CurrentSelectedRow;
                    switch (feeTypeEntity.DataStatus)
                    {
                        case HIS.Service.Core.Enums.DataStatus.Disable:
                            gr.Cells[colDataStatus.ColumnIndex].Value = false;
                            gr.CellStyles.Default.TextColor = Color.Gray;
                            break;
                        case HIS.Service.Core.Enums.DataStatus.Enable:
                            gr.Cells[colDataStatus.ColumnIndex].Value = true;
                            gr.CellStyles.Default.TextColor = Color.Empty;
                            break;
                    }

                    gr.ResolveRow();
                }
            }
        }
    }
}
