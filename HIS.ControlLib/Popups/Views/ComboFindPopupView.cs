using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HIS.Utility.Win32;
using HIS.Utility;

namespace HIS.ControlLib.Popups
{
    [ToolboxItem(false)]
    public partial class ComboFindPopupView : UserControl, IFindPopupFilterView
    {
        /// <summary>
        /// 通过过滤词获取数据源
        /// </summary>
        public Func<string, object> GetDataSource;
        private object dataSource = null;
        private string _ColumnHeaders = null;
        private bool _Adaptive = true;

        public bool Adaptive
        {
            get { return _Adaptive; }
            set { _Adaptive = value; }
        }
        public bool DoubleClickedToSelect
        {
            get;
            set;
        }
        /// <summary>
        /// 获取或设置数据源
        /// </summary>
        public object DataSource
        {
            get { return dataSource; }
            set
            {
                dataSource = value;
                this.dgvView.DataSource = value;
            }
        }

        /// <summary>
        /// 获取或设置过滤框显示在上方还是下方
        /// </summary>
        public bool UpOrDown
        {
            get { return this.panel1.Dock == DockStyle.Top; }
            set
            {
                if (value)
                    this.panel1.Dock = DockStyle.Top;
                else
                    this.panel1.Dock = DockStyle.Bottom;
            }
        }
        /// <summary>
        /// 显示的成员字段
        /// </summary>
        public string DisplayMember
        {
            get { return colDisplayText.DataPropertyName; }
            set { colDisplayText.DataPropertyName = value; }
        }
        /// <summary>
        /// 值的成员字段
        /// </summary>
        public string ValueMember
        {
            get;
            set;
        }
        /// <summary>
        /// 过滤字段
        /// </summary>
        public string[] FilterFields
        {
            get;
            set;
        }

        public Control View
        {
            get { return this.dgvView; }
        }

        public string SelectedText
        {
            get
            {
                var item = this.SelectedItem;
                if (item == null) return null;
                if (string.IsNullOrEmpty(DisplayMember))
                    return null;
                return DataBinder.GetStringValue(item, this.DisplayMember);
            }
        }

        public object SelectedValue
        {
            get
            {
                var item = this.SelectedItem;
                if (item == null) return null;
                if (string.IsNullOrEmpty(ValueMember))
                    return null;
                return DataBinder.GetValue(item, this.ValueMember);
            }
        }

        public object SelectedItem
        {
            get
            {
                if (this.dgvView.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                    return this.dgvView.SelectedRows[0].DataBoundItem;
                return null;
            }
        }
        public TextBoxBase FilterTextBox
        {
            get
            {
                return this.txtFilter;
            }
        }
        /// <summary>
        /// 是否支持拼音码检索
        /// </summary>
        public bool SupportPinyinSearch { get; set; }
        /// <summary>
        /// 是否支持五笔码检索
        /// </summary>
        public bool SupportWubiSearch { get; set; }
        /// <summary>
        /// 获取或设置默认的选中值
        /// </summary>
        public object DefaultSelectedValue { get; set; }
        /// <summary>
        /// 获取表格头 例：列名1,属性名1,大小(*自动)|列名2,属性名2,大小(*自动)
        /// </summary>
        public string ColumnHeaders
        {
            get
            {
                return _ColumnHeaders;
            }

            set
            {
                _ColumnHeaders = value;
                this.dgvView.Columns.Clear();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    try
                    {
                        foreach (string item in value.Split('|'))
                        {
                            string[] splitSets = item.Split(',');
                            string headerText = splitSets[0];
                            string dataPropertyName = splitSets[1];
                            var column = new DataGridViewTextBoxColumn() { HeaderText = headerText, DataPropertyName = dataPropertyName, AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
                            if (splitSets.Length >= 3)
                            {
                                int size = splitSets[2].AsInt(0);
                                if (size > 0)
                                {
                                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                                    column.Width = size;
                                    column.MinimumWidth = size;
                                }
                            }
                            this.dgvView.Columns.Add(column);
                        }
                        if (this.dgvView.ColumnCount > 0)
                        {
                            this.dgvView.Columns.Add(new DataGridViewTextBoxColumn() { AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
                        }
                    }
                    catch
                    { }
                }
                if (this.dgvView.ColumnCount == 0)
                {
                    this.dgvView.Columns.Add(colDisplayText);
                    colDisplayText.MinimumWidth = Math.Max(this.dgvView.Width - SystemInformation.VerticalScrollBarWidth, 100);

                    this.dgvView.Columns.Add(new DataGridViewTextBoxColumn() { AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
                }
                this.dgvView.ColumnHeadersVisible = this.dgvView.ColumnCount > 2;
            }
        }

        public event EventHandler ItemSelected;

        private void RaiseSelectedItemCore()
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, EventArgs.Empty);
            }
        }
        public int Filter(string filteText)
        {
            if (this.GetDataSource != null)
            {
                this.dgvView.DataSource = this.GetDataSource(filteText);
                this.dgvView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                return this.dgvView.RowCount;
            }
            if (dataSource == null && this.dgvView.DataSource != null)
            {
                this.dgvView.DataSource = dataSource;
                return 0;
            }

            this.dgvView.DataSource = DataBinder.Filter(dataSource, this.FilterFields, filteText, this.SupportPinyinSearch ? this.DisplayMember : null, this.SupportWubiSearch ? this.DisplayMember : null);
            this.dgvView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            return this.dgvView.RowCount;
        }
        public Size CalcItemsSize()
        {
            int height = this.dgvView.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            if (this.dgvView.ColumnHeadersVisible)
                height += this.dgvView.ColumnHeadersHeight;
            height += this.panel1.Height;
            this.dgvView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            int width = this.Padding.Horizontal;
            for (int i = 0; i < this.dgvView.Columns.Count - 1; i++)
            {
                width += this.dgvView.Columns[i].Width;
            }
            if (height > this.MaximumSize.Height)
            {
                width += SystemInformation.VerticalScrollBarWidth;
            }
            if (this.HScroll)
                height += SystemInformation.HorizontalScrollBarHeight;
            return new System.Drawing.Size(width, height + 10);
        }

        public ComboFindPopupView()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.UnableToCaptureFocus();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            colDisplayText.MinimumWidth = Math.Max(this.dgvView.Width - SystemInformation.VerticalScrollBarWidth, 100);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            //默认选中默认项目
            if (this.Visible && !string.IsNullOrWhiteSpace(this.ValueMember) && !this.DefaultSelectedValue.IsNull())
            {
                if (this.dgvView.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    object curValue = DataBinder.GetValue(this.dgvView.SelectedRows[0].DataBoundItem, this.ValueMember);
                    if (this.DefaultSelectedValue == curValue)
                        return;
                }
                foreach (DataGridViewRow dgvr in this.dgvView.Rows)
                {
                    object curValue = DataBinder.GetValue(dgvr.DataBoundItem, this.ValueMember);
                    if (curValue == this.DefaultSelectedValue)
                    {
                        dgvr.Selected = true;
                        if (!dgvr.Displayed)
                            this.dgvView.FirstDisplayedScrollingRowIndex = dgvr.Index;
                        break;
                    }
                }
            }
        }
        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DoubleClickedToSelect)
            {
                if (e.RowIndex < 0) return;
                this.RaiseSelectedItemCore();
            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.DoubleClickedToSelect)
            {
                if (e.RowIndex < 0) return;
                this.RaiseSelectedItemCore();
            }
        }

        private void dgvView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.RaiseSelectedItemCore();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                e.Handled = true;
            UnsafeNativeMethods.SendMessage(this.dgvView.Handle, (int)WinMsg.WM_KEYDOWN, (int)e.KeyCode, 0);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.Filter(this.txtFilter.Text.Trim());
        }
    }
}
