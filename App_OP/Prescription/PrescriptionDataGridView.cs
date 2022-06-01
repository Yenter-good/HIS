using HIS.ControlLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.Prescription
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-23 10:59:34
    /// 描述:
    /// </summary>
    internal class PrescriptionDataGridView : DataGridViewExt
    {
        /// <summary>
        /// 同组值列
        /// </summary>
        public DataGridViewColumn GroupValueColumn { get; set; }
        /// <summary>
        /// 同组显示列
        /// </summary>
        public DataGridViewColumn GroupDisplayColumn { get; set; }

        /// <summary>
        /// 项目名称列
        /// </summary>
        public DataGridViewColumn NameColumn { get; set; }

        /// <summary>
        /// 画出同组项目之间的连线
        /// </summary>
        public void DrawGroupLine()
        {
            string[] zbf = new string[] { "┓", "┫", "┛", "┃" };
            string currTZBH = "";
            for (int i = 0; i < this.Rows.Count; i++)
            {
                //得到当前处理行的同组编号和下一行的同组编号,如果已经是最后一行,那么下一行的同组编号为-1
                if (this.Rows[i].Cells[GroupValueColumn.Index].Value == null) continue;
                string currRowValue = this.Rows[i].Cells[GroupValueColumn.Index].Value.ToString();
                string nextRowValue = i != this.Rows.Count - 1 ? this.Rows[i + 1].Cells[GroupValueColumn.Index].Value == null ? "-1" : this.Rows[i + 1].Cells[GroupValueColumn.Index].Value.ToString() : "-1";

                if (currRowValue == "0")
                {
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Value = "";
                    continue;   //如果没有同组编号则跳过
                }

                //如果当前行等于上一次的同组编号并且已经是最后一行
                if (currRowValue == currTZBH && nextRowValue == "-1")
                {
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Value = zbf[2];
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                }
                //如果当前行不等于上一次的同组编号并且和下一行一样
                else if (currRowValue != currTZBH && nextRowValue == currRowValue)
                {
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Value = zbf[0];
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Style.Alignment = DataGridViewContentAlignment.BottomLeft;
                    currTZBH = currRowValue;
                }
                //如果当前行等于上一次的同组编号并且和下一行一样
                else if (currRowValue == currTZBH && nextRowValue == currRowValue)
                {
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Value = zbf[3];
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                //如果当前行等于上一次的同组编号并且和下一行不一样
                else if (currRowValue == currTZBH && nextRowValue != currRowValue)
                {
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Value = zbf[2];
                    this.Rows[i].Cells[GroupDisplayColumn.Index].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                }
            }
        }

        /// <summary>
        /// 去下一个可编辑的单元格,如果没有,则跳转到下一个可编辑的行
        /// </summary>
        public void GotoNextCell()
        {
            DataGridViewCell cell = this.GetNextEditCell(this.CurrentCell);
            if (cell == this.CurrentCell)
                GotoNextRow();
            else
            {
                this.CurrentCell = cell;
                this.BeginEdit(true);
            }
        }

        /// <summary>
        /// 去下一个可编辑的行,如果没有新行,则创建新行
        /// </summary>
        public void GotoNextRow()
        {
            DataGridViewRow row = this.Rows.Cast<DataGridViewRow>().OrderByDescending(p => p.Index).ToList().Find(p => p.Tag == null);
            if (row != null)
                this.CurrentCell = this.Rows[row.Index].Cells[NameColumn.Index];
            else
            {
                int index = this.Rows.Add();
                var newRow = this.Rows[index];
                this.CurrentCell = newRow.Cells[NameColumn.Index];
            }
            this.BeginEdit(true);
        }

    }
}
