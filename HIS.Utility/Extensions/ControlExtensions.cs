using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HIS.Utility
{
    public static class ControlExtensions
    {


        private static MethodInfo setControlStyleMethod;
        private static object[] setControlStyleArgs = new object[] { ControlStyles.Selectable, false };
        private static void SetChildControlNoFocus(Control ctrl)
        {
            if (ctrl.HasChildren)
                foreach (Control c in ctrl.Controls)
                {
                    UnableToCaptureFocus(c);
                }
        }
        /// <summary>
        /// 设置控件不能捕获焦点
        /// </summary>
        /// <param name="ctrl"></param>
        public static void UnableToCaptureFocus(this Control ctrl)
        {
            if (setControlStyleMethod == null)
                setControlStyleMethod = typeof(Control).GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance);

            setControlStyleMethod.Invoke(ctrl, setControlStyleArgs);
            SetChildControlNoFocus(ctrl);

        }
        /// <summary>
        /// 设置控件双缓存
        /// </summary>
        /// <param name="control"></param>
        /// <param name="setting"></param>
        public static void DoubleBuffered(this Control control, bool setting)
        {
            Type dgvType = control.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            if (pi != null)
                pi.SetValue(control, setting, null);
        }

        public static Point GetCurrentCellPosition(this DataGridViewX dgv)
        {
            Rectangle rect = dgv.GetCellDisplayRectangle(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex, false);
            Point p1 = dgv.PointToScreen(new Point(rect.X, rect.Y));

            return p1;


        }
        public static void ShowTips(this Control control, string tips, int timeOut = 2)
        {
            var b = new DevComponents.DotNetBar.Balloon()
            {
                Text = tips,
                Style = DevComponents.DotNetBar.eBallonStyle.Balloon,
                ShowCloseButton = false,
                AutoClose = true,
                AutoCloseTimeOut = timeOut,
                Height = 70
            };
            b.Show(control);
        }
        public static void ShowTips(this Rectangle rect, string tips, int timeOut = 2)
        {
            var b = new DevComponents.DotNetBar.Balloon()
            {
                Text = tips,
                Style = DevComponents.DotNetBar.eBallonStyle.Balloon,
                ShowCloseButton = false,
                AutoClose = true,
                AutoCloseTimeOut = timeOut,
                Height = 70
            };
            b.Show(rect, false);
        }

        public static DataGridViewRow GetSelectedRow(this DataGridView dgv)
        {
            var selectedRows = dgv.SelectedRows;
            if (selectedRows.Count == 0)
                return null;

            return selectedRows[0] as DataGridViewRow;
        }

        public static GridRow GetSelectedRow(this SuperGridControl dgv)
        {
            var selectedRows = dgv.GetSelectedRows();
            if (selectedRows.Count == 0)
                return null;

            return selectedRows[0] as GridRow;
        }
        public static DataGridViewRow GetSelectedRowByCell(this DataGridView dgv)
        {
            var selectedCells = dgv.SelectedCells;
            if (selectedCells.Count == 0)
                return null;

            return selectedCells[0].OwningRow;
        }

        public static List<DataGridViewRow> GetSelectedRowsByCells(this DataGridView dgv)
        {
            var selectedCells = dgv.SelectedCells;
            if (selectedCells.Count == 0)
                return null;

            return selectedCells.Cast<DataGridViewCell>().Select(p => p.OwningRow).OrderBy(p => p.Index).Distinct().ToList();
        }

        public static GridRow GetSelectedRowByCell(this SuperGridControl dgv)
        {
            var selectedCells = dgv.GetSelectedCells();
            if (selectedCells.Count == 0)
                return null;
            return selectedCells[0].As<GridCell>().GridRow;
        }
    }
}
