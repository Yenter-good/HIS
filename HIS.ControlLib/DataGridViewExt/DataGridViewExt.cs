using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class SelectValueChangedEventArgs : PositionEventArgs
    {
        public bool Cancel { get; set; }
        public object Value { get; set; }
    }
    public class PositionEventArgs : EventArgs
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class TextChangeEventArgs : PositionEventArgs
    {
        public string Text { get; set; }
        public bool Select { get; set; }
    }
    public class ValueChangeEventArgs : PositionEventArgs
    {
        public string Value { get; set; }
    }

    public class DataGridViewExt : DataGridViewX
    {
        public DataGridViewExt()
        {
            _timer.Interval = 20;
            _timer.Tick += Timer_Tick;
            this.CellValueChanged += DataGridViewExt_CellValueChanged;
        }

        #region 重绘datagridview表头
        private List<TopHeader> _headers = new List<TopHeader>();
        public List<TopHeader> Headers
        {
            get { return _headers; }
        }
        public struct TopHeader
        {
            public TopHeader(int index, int span, string text)
            {
                this.Index = index;
                this.Span = span;
                this.Text = text;
            }
            public int Index;
            public int Span;
            public string Text;
        }
        int top = 0;
        int left = 0;
        int height = 0;
        int width1 = 0;

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);
            DataGridViewColumn c;
            if (e.ColumnIndex != -1)
                c = this.Columns[e.ColumnIndex];
            DrawColumnsHead(e);
            DrawDeleteLine(e);
            DrawRowHead(e);
            //DrawGroupLine(dgv, e);
        }
        /// <summary>
        /// 画出列头组合
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        private void DrawColumnsHead(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                Rectangle rect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width, e.CellBounds.Height);
                using (Brush backColorBrush = new SolidBrush(Color.FromArgb(228, 236, 247))) //Cell背景颜色
                    e.Graphics.FillRectangle(backColorBrush, rect);
                using (Pen gridLinePen = new Pen(Color.FromArgb(158, 182, 206))) //画笔颜色
                {
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left + e.CellBounds.Width - 1, e.CellBounds.Top, e.CellBounds.Left + e.CellBounds.Width - 1, e.CellBounds.Height);
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left - 1, e.CellBounds.Top + e.CellBounds.Height - 1, e.CellBounds.Left + e.CellBounds.Width - 1, e.CellBounds.Top + e.CellBounds.Height - 1);
                }
            }
            if (e.RowIndex != -1) return;
            foreach (TopHeader item in Headers)
            {
                if (e.ColumnIndex >= item.Index && e.ColumnIndex < item.Index + item.Span)
                {
                    if (e.ColumnIndex == item.Index)
                    {
                        top = e.CellBounds.Top;
                        left = e.CellBounds.Left;
                        height = e.CellBounds.Height;
                    }
                    int width = 0;//总长度
                    for (int i = item.Index; i < item.Span + item.Index; i++)
                    {
                        width += this.Columns[i].Width;
                    }
                    Rectangle rect = new Rectangle(left, top, width, e.CellBounds.Height);
                    //using (LinearGradientBrush backColorBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, height), Color.FromArgb(248, 251, 253), Color.FromArgb(213, 221, 234))) //Cell背景颜色
                    //{
                    //    //抹去原来的cell背景
                    //    e.Graphics.FillRectangle(backColorBrush, rect);
                    //}
                    using (SolidBrush backColorBrush = new SolidBrush(Color.FromArgb(233, 241, 251)))  //标题头背景色
                    {
                        e.Graphics.FillRectangle(backColorBrush, rect);  //抹掉原来的cell背景
                    }

                    using (Pen gridLinePen = new Pen(Color.FromArgb(158, 182, 206))) //画笔颜色
                    {
                        //e.Graphics.DrawLine(gridLinePen, left, top, left + width, top);
                        e.Graphics.DrawLine(gridLinePen, left, top + height / 2, left + width, top + height / 2);
                        e.Graphics.DrawLine(gridLinePen, left, top + height - 1, left + width, top + height - 1); //自定义区域下部横线
                        width1 = 0;
                        e.Graphics.DrawLine(gridLinePen, left + width, top, left + width, top + height);
                        for (int i = item.Index; i < item.Span + item.Index; i++)
                        {
                            width1 += this.Columns[i].Width;
                            if (i == item.Span + item.Index - 1)
                                e.Graphics.DrawLine(gridLinePen, left + width1 - 1, top, left + width1 - 1, top + height);
                            else
                                e.Graphics.DrawLine(gridLinePen, left + width1 - 1, top + height / 2, left + width1 - 1, top + height);
                        }

                        SizeF sf = e.Graphics.MeasureString(item.Text, this.ColumnHeadersDefaultCellStyle.Font);
                        float lstr = (width - sf.Width) / 2;
                        float rstr = (height / 2 - sf.Height) / 2;
                        //画出文本框
                        if (item.Text != "")
                        {
                            e.Graphics.DrawString(item.Text, this.ColumnHeadersDefaultCellStyle.Font,
                                                        new SolidBrush(this.ColumnHeadersDefaultCellStyle.ForeColor),
                                                            left + lstr,
                                                            top + rstr,
                                                            StringFormat.GenericDefault);
                        }
                        width = 0;
                        width1 = 0;
                        for (int i = item.Index; i < item.Span + item.Index; i++)
                        {
                            string columnValue = this.Columns[i].HeaderText;
                            width1 = this.Columns[i].Width;
                            sf = e.Graphics.MeasureString(columnValue, this.ColumnHeadersDefaultCellStyle.Font);
                            lstr = (width1 - sf.Width) / 2;
                            rstr = (height / 2 - sf.Height) / 2;
                            if (columnValue != "")
                            {
                                e.Graphics.DrawString(columnValue, this.ColumnHeadersDefaultCellStyle.Font,
                                                            new SolidBrush(this.ColumnHeadersDefaultCellStyle.ForeColor),
                                                                left + width + lstr,
                                                                top + height / 2 + rstr,
                                                                StringFormat.GenericDefault);
                            }
                            width += this.Columns[i].Width;
                        }
                    }
                }
            }

        }
        ///// <summary>
        ///// 画出同组线
        ///// </summary>
        ///// <param name="dgv"></param>
        ///// <param name="e"></param>
        //private void DrawGroupLine(DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex == -1 || e.RowIndex == -1 || GroupDisplay == null)
        //        return;

        //    if (GroupDisplay.Index == e.ColumnIndex)
        //    {
        //        Rectangle re = new Rectangle(e.CellBounds.Left + 1, e.CellBounds.Top + 1, e.CellBounds.Width - 2, e.CellBounds.Height - 2);
        //        //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        //        DataGridViewRow row = base.Rows[e.RowIndex];
        //        DataGridViewCell cell = row.Cells[e.ColumnIndex];
        //        if (e.PaintParts == DataGridViewPaintParts.Background || e.PaintParts == DataGridViewPaintParts.All)
        //            e.Graphics.FillRectangle(new SolidBrush(row.InheritedStyle.BackColor), e.CellBounds);

        //        if (e.PaintParts == DataGridViewPaintParts.SelectionBackground)
        //            e.Graphics.FillRectangle(new SolidBrush(row.InheritedStyle.SelectionBackColor), e.CellBounds);

        //        e.Graphics.DrawLine(new Pen(this.GridColor, 1), new Point(e.CellBounds.X, e.CellBounds.Y - 1), new Point(e.CellBounds.Right, e.CellBounds.Y - 1));

        //        if (cell.Value.AsString("") == "┓")
        //        {
        //            e.Graphics.DrawArc(new Pen(Color.FromArgb(94, 136, 158), 2), new Rectangle(new Point(re.Left, re.Bottom - re.Width), new Size(re.Width, re.Width)), 270, 90);
        //        }
        //        else if (cell.Value.AsString("") == "┃")
        //            e.Graphics.DrawLine(new Pen(Color.FromArgb(94, 136, 158), 2), new Point(re.Left + re.Width / 2, re.Top), new Point(re.Left + re.Width / 2, re.Top + re.Height));
        //        else if (cell.Value.AsString("") == "┛")
        //        {
        //            e.Graphics.DrawArc(new Pen(Color.FromArgb(94, 136, 158), 2), new Rectangle(new Point(re.Left, re.Top), new Size(re.Width, re.Width)), 0, 90);
        //        }
        //        e.Handled = true;
        //    }
        //}
        /// <summary>
        /// 画出删除线
        /// </summary>
        /// <param name="e"></param>
        private void DrawDeleteLine(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex <= 0 || e.RowIndex == -1 || !this.Columns[e.ColumnIndex].Visible || DeleteLineRowIndexCollection == null)
                return;
            if (DeleteLineRowIndexCollection.Contains(e.RowIndex))
            {
                e.PaintBackground(e.CellBounds, false);
                e.PaintContent(e.CellBounds);
                Rectangle rect = e.CellBounds;
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(rect.Left, rect.Top + rect.Height / 2), new Point(rect.Left + rect.Width - 1, rect.Top + rect.Height / 2));
                e.Handled = true;
            }
        }

        private void DrawRowHead(DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                Color backColor = this.Rows[e.RowIndex].HeaderCell.Style.BackColor;
                e.Graphics.FillRectangle(new SolidBrush(backColor), e.CellBounds);
            }
        }
        #endregion

        #region 变量

        private Timer _timer = new Timer();
        private int _delayTick = 0;
        private Control _editingControl = new Control();
        private object _editingControlValue = null;
        /// <summary>
        /// 当产生输入时
        /// </summary>
        private bool _hasInput = false;

        #endregion

        #region 自定义事件
        [Browsable(true), Description("单元格值延时发生变化时"), Category("操作")]
        public event EventHandler<TextChangeEventArgs> TextChangeDelay;

        [Browsable(true), Description("单元格值实时发生变化时"), Category("操作")]
        public event EventHandler<TextChangeEventArgs> TextChange;

        [Browsable(true), Description("单元格值初始化时"), Category("操作")]
        public event EventHandler<TextChangeEventArgs> InitEditControl;

        [Browsable(true), Description("Dgv失去选中状态时触发"), Category("操作")]
        public event EventHandler LostSelected;


        public event KeyEventHandler SpecialKeyDown;

        [Browsable(true), Description("设定的选择列值实时发生变化时"), Category("操作")]
        public event EventHandler<SelectValueChangedEventArgs> SelectValueChanged;
        #endregion

        #region 事件
        private void DataGridViewExt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (this.Columns[e.ColumnIndex] is DataGridViewFloatInputExtColumn floatColumn)
                {
                    var value = this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsDouble(0);
                    if (floatColumn.Digits != 0)
                    {
                        if (floatColumn.Round)
                            this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Math.Round(value, floatColumn.Digits, MidpointRounding.AwayFromZero);
                        else
                            this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Math.Floor(value * Math.Pow(10, floatColumn.Digits)) / Math.Pow(10, floatColumn.Digits);
                    }
                }
                else if (this.Columns[e.ColumnIndex] is DataGridViewIntegerInputExtColumn intColumn)
                {
                    var value = this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsInt(0);
                    if (value < intColumn.MinValue)
                        this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = intColumn.MinValue;
                    else if (value > intColumn.MaxValue)
                        this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = intColumn.MaxValue;
                }
            }
        }

        #endregion

        #region 属性
        [Browsable(true), Description("延时(毫秒)")]
        public int Delay { get; set; } = 200;
        [Browsable(true), Description("点击空白处是否取消选中")]
        public bool ClickBlankClearSelect { get; set; } = false;
        [Browsable(true), Description("是否开启特殊键拦截")]
        public bool EnableSpecialKeyIntercept { get; set; } = true;
        [Description("用来显示删除线的行")]
        public List<int> DeleteLineRowIndexCollection { get; set; } = new List<int>();
        [Description("获取或设置选中列")]
        public DataGridViewColumn SelectColumn { get; set; }

        #endregion

        #region textbox延时触发
        protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
        {
            _hasInput = false;
            if (e.Control is TextBox tbx)
            {
                tbx.SelectAll();
                tbx.TextChanged += TextBox_TextChanged;
                tbx.KeyPress += TextBox_KeyPress;

                TextChangeEventArgs args = new TextChangeEventArgs() { Text = tbx.Text == null ? "" : tbx.Text, RowIndex = base.CurrentCell.RowIndex, ColumnIndex = base.CurrentCell.ColumnIndex };
                this.InitEditControl?.Invoke(this, args);
            }
            else
                base.OnEditingControlShowing(e);
            _editingControl = e.Control;
        }

        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            base.OnCellEndEdit(e);
            if (this.Columns[e.ColumnIndex] is DataGridViewFloatInputExtColumn floatColumn)
            {
                var value = this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsDouble(0);
                if (floatColumn.Digits != 0)
                {
                    if (floatColumn.Round)
                        this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Math.Round(value, floatColumn.Digits, MidpointRounding.AwayFromZero);
                    else
                        this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Math.Floor(value * Math.Pow(10, floatColumn.Digits)) / Math.Pow(10, floatColumn.Digits);
                }
            }
            else if (this.Columns[e.ColumnIndex] is DataGridViewIntegerInputExtColumn intColumn)
                this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.AsInt(0);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            DataGridViewCell cell = base.CurrentCell;
            var control = sender as TextBox;
            string value = control.Text;
            value = value + e.KeyChar;
            if (cell.OwningColumn is DataGridViewIntegerInputExtColumn)
            {
                int result = 0;
                if (!int.TryParse(value, out result))
                    e.Handled = true;
            }
            else if (cell.OwningColumn is DataGridViewFloatInputExtColumn)
            {
                float result = 0;
                if (!float.TryParse(value, out result))
                    e.Handled = true;
            }

            _hasInput = true;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = base.CurrentCell;
            TextBox box = (sender as TextBox);

            int index = box.SelectionStart;
            box.SelectionStart = index;
            _editingControlValue = box.Text;
            _delayTick = 0;
            _timer.Enabled = true;
            if (_hasInput || box.Text != cell.Value.AsString(""))
                this.TextChange?.Invoke(_editingControl, new TextChangeEventArgs() { Text = _editingControlValue == null ? "" : _editingControlValue.ToString(), RowIndex = cell.RowIndex, ColumnIndex = cell.ColumnIndex });
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_delayTick >= Delay / 20)
            {
                DataGridViewCell cell = base.CurrentCell;
                if (cell == null)
                    return;
                TextChangeEventArgs args = new TextChangeEventArgs() { Text = _editingControlValue == null ? "" : _editingControlValue.ToString(), RowIndex = cell.RowIndex, ColumnIndex = cell.ColumnIndex };

                if (_hasInput || _editingControl.As<TextBox>().Text != cell.Value.AsString(""))
                    this.TextChangeDelay?.Invoke(_editingControl, args);

                _timer.Enabled = false;
            }
            _delayTick++;
        }
        #endregion

        #region 处理键盘事件
        bool ProcessDataGridViewKeyInvoke = false;
        bool ProcessDialogKeyInvoke = false;
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (EnableSpecialKeyIntercept)
            {
                if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Escape || (e.KeyValue >= 112 && e.KeyValue <= 123))
                {
                    if (!ProcessDialogKeyInvoke)
                    {
                        SpecialKeyDown?.Invoke(this, e);
                        ProcessDataGridViewKeyInvoke = true;
                    }
                    else
                        ProcessDialogKeyInvoke = false;
                    return false;
                }
            }
            return base.ProcessDataGridViewKey(e);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (EnableSpecialKeyIntercept)
            {
                if (keyData == Keys.Tab || keyData == Keys.Enter || keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Escape || ((int)keyData >= 112 && (int)keyData <= 123))
                {
                    if (!ProcessDataGridViewKeyInvoke)
                    {
                        SpecialKeyDown?.Invoke(this, new KeyEventArgs(keyData));
                        ProcessDialogKeyInvoke = true;
                    }
                    else
                        ProcessDataGridViewKeyInvoke = false;

                    return false;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

        #region 判断鼠标位置时候没有焦点了

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (ClickBlankClearSelect)
            {
                if (this.RowCount == 0)
                    return;
                Rectangle rectRow = this.GetRowDisplayRectangle(this.RowCount - 1, false);
                //Rectangle rectColumn = this.GetColumnDisplayRectangle(this.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1, false);
                if (e.X > rectRow.Right || e.Y > rectRow.Bottom)
                {
                    if (this.SelectedCells.Count > 0)
                    {
                        this.EndEdit();
                        this.ClearSelection();
                        LostSelected?.Invoke(this, null);
                        this.CurrentCell = null;
                    }
                }
            }
            base.OnMouseClick(e);
        }
        #endregion

        #region 将每一行映射成指定类型
        public T Fill<T>(DataGridViewRow row, T source) where T : class, new()
        {
            PropertyInfo[] infos = source.GetType().GetProperties();
            foreach (DataGridViewCell cell in row.Cells)
            {
                string name;
                if (cell.OwningColumn.GetType() == typeof(DataGridViewTextBoxExtColumn))
                    name = (cell.OwningColumn as DataGridViewTextBoxExtColumn).BindFieldName;
                else if (cell.OwningColumn.GetType() == typeof(DataGridViewIntegerInputExtColumn))
                    name = (cell.OwningColumn as DataGridViewIntegerInputExtColumn).BindFieldName;
                else if (cell.OwningColumn.GetType() == typeof(DataGridViewFloatInputExtColumn))
                    name = (cell.OwningColumn as DataGridViewFloatInputExtColumn).BindFieldName;
                else
                    continue;

                var tmp = infos.Where(p => p.Name == name).ToArray();
                if (tmp.Count() == 0)
                {
                    continue;
                }

                if (tmp[0].PropertyType == typeof(int))
                    tmp[0].SetValue(source, cell.Value.AsInt(0), null);

                else if (tmp[0].PropertyType == typeof(string))
                    tmp[0].SetValue(source, cell.Value.AsString(), null);

                else if (tmp[0].PropertyType == typeof(decimal?))
                    tmp[0].SetValue(source, cell.Value.AsDecimal(), null);

                else if (tmp[0].PropertyType == typeof(int?))
                    tmp[0].SetValue(source, cell.Value.AsInt(), null);

                else if (tmp[0].PropertyType == typeof(long?))
                    tmp[0].SetValue(source, cell.Value.AsLong(), null);

                else if (tmp[0].PropertyType == typeof(decimal))
                    tmp[0].SetValue(source, cell.Value.AsDecimal(0), null);

                else if (tmp[0].PropertyType == typeof(long))
                    tmp[0].SetValue(source, cell.Value.AsLong(0), null);

                else if (tmp[0].PropertyType == typeof(bool) || tmp[0].PropertyType == typeof(bool?))
                    tmp[0].SetValue(source, cell.Value.AsBoolean(), null);
            }
            return source;
        }
        #endregion

        #region 拖动选中列
        protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseEnter(e);
            //在勾选列拖拽鼠标将自动选择
            if (SelectColumn != null && MouseButtons == MouseButtons.Left && e.ColumnIndex == SelectColumn.Index && e.RowIndex >= 0)
            {
                this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value = !this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value.AsBoolean();

                SelectValueChangedEventArgs args = new SelectValueChangedEventArgs() { RowIndex = e.RowIndex, ColumnIndex = e.ColumnIndex, Value = this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value };
                SelectValueChanged?.Invoke(this, args);
                if (args.Cancel)
                    this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value = false;
            }
        }
        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            if (SelectColumn != null && e.ColumnIndex == this.SelectColumn.Index && e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value = !this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value.AsBoolean();

                SelectValueChangedEventArgs args = new SelectValueChangedEventArgs() { RowIndex = e.RowIndex, ColumnIndex = e.ColumnIndex, Value = this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value };
                SelectValueChanged?.Invoke(this, args);
                if (args.Cancel)
                    this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value = !this.Rows[e.RowIndex].Cells[this.SelectColumn.Index].Value.AsBoolean();
            }
            else
            {
                base.OnCellMouseDown(e);
            }
        }
        #endregion

        #region 方法
        public List<DataGridViewRow> GetCheckedRows()
        {
            List<DataGridViewRow> result = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in this.Rows)
            {
                if (row.Cells[SelectColumn.Index].Value.AsBoolean())
                    result.Add(row);
            }
            return result;
        }
        /// <summary>
        /// 返回当前编辑单元格相对容器的位置
        /// </summary>
        /// <returns></returns>
        public Point GetCellPosition()
        {
            if (this.CurrentCell == null)
                return Point.Empty;
            Rectangle rect = this.GetCellDisplayRectangle(this.CurrentCell.ColumnIndex, this.CurrentCell.RowIndex, false);
            //Point p1 = this.Parent.PointToScreen(new Point(rect.X, rect.Y));
            return new Point(rect.X, rect.Y);
        }
        public Rectangle GetCellRectangleToScreen()
        {
            if (this.CurrentCell == null)
                return Rectangle.Empty;
            Rectangle rect = this.GetCellDisplayRectangle(this.CurrentCell.ColumnIndex, this.CurrentCell.RowIndex, false);
            rect.Location = this.PointToScreen(rect.Location);
            //Point p1 = this.Parent.PointToScreen(new Point(rect.X, rect.Y));
            return rect;
        }
        public Rectangle GetCellRectangleToScreen(DataGridViewCell cell)
        {
            if (this.CurrentCell == null)
                return Rectangle.Empty;
            Rectangle rect = this.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
            rect.Location = this.PointToScreen(rect.Location);
            //Point p1 = this.Parent.PointToScreen(new Point(rect.X, rect.Y));
            return rect;
        }
        /// <summary>
        /// 获得下一个可以编辑的单元格
        /// </summary>
        /// <param name="currCell"></param>
        /// <returns></returns>
        public DataGridViewCell GetNextEditCell(DataGridViewCell currCell)
        {
            DataGridViewCell result = currCell;
            if (currCell.ColumnIndex >= this.ColumnCount - 1)
            {
                return result;
            }

            DataGridViewCell cell = currCell.OwningRow.Cells[currCell.ColumnIndex + 1];
            while (cell.ReadOnly || !cell.Visible)
            {
                if (cell.ColumnIndex < this.ColumnCount - 1)
                {
                    cell = cell.OwningRow.Cells[cell.ColumnIndex + 1];
                }
                else
                {
                    break;
                }
            }
            if (!cell.ReadOnly && cell.Visible)
            {
                result = cell;
            }

            return result;
        }

        #endregion

    }
}
