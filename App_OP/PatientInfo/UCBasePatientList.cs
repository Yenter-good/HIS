using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Service.Core.Enums;

namespace App_OP.PatientInfo
{
    internal partial class UCBasePatientList : UserControl
    {
        /// <summary>
        /// 性别中文描述字典
        /// </summary>
        private Dictionary<int, string> _dicGender;
        /// <summary>
        /// 身份类别中文描述字典
        /// </summary>
        private Dictionary<int, string> _dicPayType;
        /// <summary>
        /// 急诊标识中文描述字典
        /// </summary>
        private Dictionary<bool, string> _dicEmerency;
        /// <summary>
        /// 选择患者
        /// </summary>
        internal event EventHandler<OutpatientEntity> SelectedPatient;
        /// <summary>
        /// 当前选中行
        /// </summary>
        internal GridRow CurrentSelectedRow
        {
            get
            {
                if (this.grid.PrimaryGrid.SelectedRowCount == 0)
                    return null;

                return this.grid.PrimaryGrid.GetSelectedRows()[0] as GridRow;
            }
        }
        /// <summary>
        /// 缓存数据
        /// </summary>
        private List<OutpatientEntity> _cacheDataSource;
        /// <summary>
        /// 数据源
        /// </summary>
        internal List<OutpatientEntity> DataSource
        {
            set
            {
                if (this._cacheDataSource == null)
                    this._cacheDataSource = value;
                this.AddRows(value);
            }
        }
        public UCBasePatientList()
        {
            InitializeComponent();
            this._dicGender = typeof(Gender).GetEnumDictEx<Gender>();
            this._dicPayType = typeof(PayType).GetEnumDictEx<PayType>();
            this._dicEmerency = new Dictionary<bool, string>() { { true, "急诊" }, { false, "非急诊" } };

            this.grid.PrimaryGrid.UseAlternateRowStyle = true;
            this.grid.PrimaryGrid.ColumnDragBehavior = ColumnDragBehavior.None;
            this.grid.PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None;
        }
        internal void Init()
        {
            this._cacheDataSource = null;
            this.tbxSearch.Text = "";
        }
        private void AddRows(List<OutpatientEntity> dataSource)
        {
            this.grid.PrimaryGrid.Rows.Clear();
            foreach (var outpatient in dataSource)
            {
                this.grid.PrimaryGrid.Rows.Add(this.CreateRow(outpatient));
            }
        }

        internal virtual GridRow CreateRow(OutpatientEntity outpatient)
        {
            GridRow gr = this.grid.PrimaryGrid.NewRow();
            gr.Tag = outpatient;
            gr.Cells[colPatientCode.ColumnIndex].Value = outpatient.OutpatientNo;
            gr.Cells[colName.ColumnIndex].Value = outpatient.PatientName;
            gr.Cells[colAge.ColumnIndex].Value = outpatient.Age.Trim();
            gr.Cells[colGender.ColumnIndex].Value = this._dicGender[(int)outpatient.Gender];
            gr.Cells[colPayType.ColumnIndex].Value = this._dicPayType[(int)outpatient.PayType];
            gr.Cells[colRegisterTime.ColumnIndex].Value = outpatient.RegisterTime.ToYMD();
            gr.Cells[colOrderNumber.ColumnIndex].Value = outpatient.OrderNumber;
            gr.Cells[colCategory.ColumnIndex].Value = outpatient.Category;
            gr.Cells[colJz.ColumnIndex].Value = this._dicEmerency[outpatient.EmerencyFlag];
            gr.Cells[colDept.ColumnIndex].Value = outpatient.Dept.Name;
            //急诊红色显示
            if (outpatient.EmerencyFlag)
                gr.CellStyles.Default.TextColor = Color.Red;
            gr.Tag = outpatient;

            return gr;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (this._cacheDataSource == null)
                return;

            string inputTxt = this.tbxSearch.Text.Trim().ToUpper();
            if (inputTxt == "")
            {
                this.DataSource = this._cacheDataSource;
                return;
            }

            this.DataSource = this._cacheDataSource.Where(d => d.PatientName.Contains(inputTxt) || d.SearchCode.Contains(inputTxt) || d.WubiCode.Contains(inputTxt) || d.OutpatientNo.Contains(inputTxt) || d.IDCard.AsNotNullString().Contains(inputTxt)).ToList();
        }

        private void grid_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            this.SelectedPatient?.Invoke(this, e.GridRow.Tag as OutpatientEntity);
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.CurrentSelectedRow.Cells[this.colPatientCode.ColumnIndex].Value.AsString(""));
        }

        private void btnCopyName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.CurrentSelectedRow.Cells[this.colName.ColumnIndex].Value.AsString(""));
        }

        private void btnCopyCardNo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.CurrentSelectedRow.Tag.As<OutpatientEntity>().CardNo.AsString(""));
        }

        private void contextMenuBar_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            e.Cancel = this.CurrentSelectedRow == null;
        }
    }
}
