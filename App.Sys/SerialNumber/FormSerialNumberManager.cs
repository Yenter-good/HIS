using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Core;
using HIS.Service.Core.Entities;
using DevComponents.DotNetBar.SuperGrid;

namespace App_Sys
{
    /// <summary>
    /// 流水号管理
    /// </summary>
    public partial class FormSerialNumberManager : BaseForm
    {
        /// <summary>
        /// 流水号服务
        /// </summary>
        private readonly IInvoiceService _invoiceService;

        public FormSerialNumberManager(IInvoiceService invoiceService)
        {
            InitializeComponent();

            this._invoiceService = invoiceService;

            //设置Grid
            this.grid.PrimaryGrid.UseAlternateRowStyle = true;
            this.grid.PrimaryGrid.MultiSelect = false;
            this.grid.PrimaryGrid.ShowRowGridIndex = true;
            this.grid.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grid.PrimaryGrid.ColumnDragBehavior = ColumnDragBehavior.None;
            this.grid.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
        }

        private void FormSerialNumberManager_Shown(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            var result = this._invoiceService.GetAll();
            if (result.Success)
                this.AddRows(result.Value);
            else
                MsgBox.OK($"加载失败 \r\n{result.Message}");
        }

        private void AddRows(List<SerialNumberEntity> sns)
        {
            this.grid.PrimaryGrid.Rows.Clear();
            if (sns != null)
            {
                foreach (SerialNumberEntity sn in sns)
                {
                    this.grid.PrimaryGrid.Rows.Add(this.CreateRow(sn));
                }
            }
        }
        private GridRow CreateRow(SerialNumberEntity sn)
        {
            var gr = this.grid.PrimaryGrid.NewRow();

            gr.Cells[colType.ColumnIndex].Value = sn.Type.ToString();
            gr.Cells[colTotalLength.ColumnIndex].Value = sn.TotalLength;
            gr.Cells[colStartPrefix.ColumnIndex].Value = sn.StartPrefix;
            gr.Cells[colMiddleFormat.ColumnIndex].Value = sn.MiddleFormat.ToString();
            gr.Cells[colChangeType.ColumnIndex].Value = sn.ChangeType.ToString();
            gr.Cells[colCacheFlag.ColumnIndex].Value = sn.CacheFlag;
            gr.Tag = sn;

            return gr;

        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormSerialNumberEdit dialog = App.Instance.CreateView<FormSerialNumberEdit>();
            dialog.dataOperation = HIS.Service.Core.Enums.DataOperation.New;
            dialog.NewSerialNumber += (x, y) =>
            {
                var gr = this.CreateRow(y);
                this.grid.PrimaryGrid.Rows.Add(gr);
                if (!gr.IsOnScreen)
                    gr.EnsureVisible();
                gr.IsSelected = true;
            };
            dialog.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var grs = this.grid.PrimaryGrid.GetSelectedRows();
            if (grs.Count == 0)
                return;
            var gr = grs[0] as GridRow;
            var sn = gr.Tag as SerialNumberEntity;

            FormSerialNumberEdit dialog = App.Instance.CreateView<FormSerialNumberEdit>();
            dialog.dataOperation = HIS.Service.Core.Enums.DataOperation.Modify;
            dialog.SelectedSerialNumber = sn;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gr.Cells[colTotalLength.ColumnIndex].Value = sn.TotalLength;
                gr.Cells[colStartPrefix.ColumnIndex].Value = sn.StartPrefix;
                gr.Cells[colMiddleFormat.ColumnIndex].Value = sn.MiddleFormat.ToString();
                gr.Cells[colChangeType.ColumnIndex].Value = sn.ChangeType.ToString();
                gr.Cells[colCacheFlag.ColumnIndex].Value = sn.CacheFlag;
            }
        }

        private void grid_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            this.btnEdit_Click(null, null);
        }
    }
}
