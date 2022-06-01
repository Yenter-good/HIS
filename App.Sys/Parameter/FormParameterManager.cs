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
using DevComponents.DotNetBar.SuperGrid;
using HIS.Service.Core.Enums;
using HIS.Core;
using System.Reflection;
using DevComponents.AdvTree;

namespace App_Sys
{
    /// <summary>
    /// 系统参数维护
    /// </summary>
    public partial class FormParameterManager : FormBaseSet
    {
        /// <summary>
        /// 参数服务
        /// </summary>
        private ISystemParameterService _systemParameterService;

        public FormParameterManager(ISystemParameterService systemParameterService)
        {
            InitializeComponent();

            //初始化服务
            this._systemParameterService = systemParameterService;

            //设置Grid
            this.grid.PrimaryGrid.UseAlternateRowStyle = true;
            this.grid.PrimaryGrid.AutoGenerateColumns = false;
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            this.grid.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grid.PrimaryGrid.MultiSelect = false;

            //设置右键菜单
            this.btiM_Remover.Visible = false;
            this.btiM_RemoverAll.Visible = false;

            //设置Bar菜单
            this.btiAdd.Visible = false;
            this.btiRemover.Visible = false;
            this.btiRemoverAll.Visible = false;
        }
        public override void LoadData()
        {
            try
            {
                this.Enabled = false;

                var dataResult = this._systemParameterService.GetAll();
                if (dataResult.Success)
                    this.grid.PrimaryGrid.DataSource = dataResult.Value;
                else
                    HIS.Core.MsgBox.Error(dataResult.Message);
            }
            finally
            {
                this.Enabled = true;
            }
        }
        public override void EditData()
        {
            using (FormParameterEdit dialog = new FormParameterEdit(this.GetCurrentSelectedRowBindItem<SysParameterEntity>()))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    GridRow gr = this.CurrentSelectedRow;
                    this.GridShow(gr);
                    gr.ReloadRow();
                }
            }
        }
        private void grid_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (e.GridCell.ColumnIndex == colDataStatus.ColumnIndex)
            {
                SysParameterEntity sysParameterEntity = this.GetCurrentSelectedRowBindItem<SysParameterEntity>();
                if (sysParameterEntity != null)
                {
                    bool cellValue = e.GridCell.Value.AsBoolean();

                    DataStatus dataStatus = cellValue == true ? DataStatus.Disable : DataStatus.Enable;

                    bool result = this._systemParameterService.UpdateDataStatusById(sysParameterEntity.Id, dataStatus);

                    if (result)
                    {
                        e.GridCell.Value = !cellValue;
                        this.CurrentSelectedRow.CellStyles.Default.TextColor = cellValue ? Color.Gray : Color.Empty;

                        sysParameterEntity.DataStatus = dataStatus;
                    }
                }
            }
        }
        private void grid_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow gr in e.GridPanel.Rows)
            {
                if (gr != null && gr.DataItem != null)
                {
                    this.GridShow(gr);
                }
            }
        }

        private void GridShow(GridRow gr)
        {
            SysParameterEntity sysParameterEntity = gr.DataItem as SysParameterEntity;
            if (sysParameterEntity != null)
            {
                switch (sysParameterEntity.DataStatus)
                {
                    case DataStatus.Disable:
                        gr.Cells[colDataStatus.ColumnIndex].Value = false;
                        gr.CellStyles.Default.TextColor = Color.Gray;
                        break;
                    case DataStatus.Enable:
                        gr.Cells[colDataStatus.ColumnIndex].Value = true;
                        gr.CellStyles.Default.TextColor = Color.Empty;
                        break;
                }
            }
        }

    }
}
