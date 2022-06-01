using HIS.Utility;
using DevComponents.DotNetBar.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIS.ControlLib.Popups
{
    public class FindComboBox : DevComponents.DotNetBar.Controls.TextBoxX
    {
        private ComboFindPopupView popupView = new ComboFindPopupView();
        private PopupControlHost popupHost;
        private SymbolBox sbClear = new SymbolBox();

        private object _selectedItem = null;
        private bool _ShowClearButton = true;
        /// <summary>
        /// 通过valuemember值查找项目对象
        /// 配合GetDataSource使用
        /// </summary>
        private Func<object, object> _valueToFindItemMehod = null;

        /// <summary>
        /// 项目选择后事件
        /// </summary>
        public event EventHandler ItemSelected;
        public event EventHandler SelectedValueChanged;

        public bool FocusOpen { get; set; }
        /// <summary>
        /// 是否在选择项目时将文本设置到文本框
        /// </summary>
        [Description("是否在选择项目时将文本设置到文本框"), DefaultValue(true)]
        public bool AutoSetText { get; set; } = true;
        /// <summary>
        /// 获取表格头 例：列名1,属性名1,大小(*自动)|列名2,属性名2,大小(*自动)
        /// </summary>
        public string ColumnHeaders
        {
            get { return popupView.ColumnHeaders; }
            set { popupView.ColumnHeaders = value; }
        }
        /// <summary>
        /// 显示的成员字段
        /// </summary>
        public string DisplayMember
        {
            get { return popupView.DisplayMember; }
            set { popupView.DisplayMember = value; }
        }
        /// <summary>
        /// 值的成员字段
        /// </summary>
        public string ValueMember
        {
            get { return popupView.ValueMember; }
            set { popupView.ValueMember = value; }
        }
        /// <summary>
        /// 过滤字段
        /// </summary>
        public string[] FilterFields
        {
            get { return popupView.FilterFields; }
            set { popupView.FilterFields = value; }
        }
        /// <summary>
        /// 获取或设置是否支持拼音码检索
        /// </summary>
        public bool SupportPinyinSearch { get { return popupView.SupportPinyinSearch; } set { popupView.SupportPinyinSearch = value; } }
        /// <summary>
        /// 获取或设置是否支持五笔码检索
        /// </summary>
        public bool SupportWubiSearch { get { return popupView.SupportWubiSearch; } set { popupView.SupportWubiSearch = value; } }
        /// <summary>
        /// 获取选择的文本
        /// </summary>
        [Browsable(false)]
        public new string SelectedText { get { return DataBinder.GetStringValue(this.SelectedItem, this.DisplayMember); } }
        /// <summary>
        /// 获取选中的值
        /// </summary>
        [Browsable(false)]
        public object SelectedValue
        {
            get { return DataBinder.GetValue(_selectedItem, this.ValueMember); }
            set
            {
                var oldValue = this.SelectedValue;
                if (oldValue != value)
                {
                    if (_valueToFindItemMehod != null)
                        this.SelectedItem = _valueToFindItemMehod(value);
                    else
                        this.SelectedItem = DataBinder.Find(this.DataSource, this.ValueMember, value);
                }
            }
        }

        /// <summary>
        /// 获取或设置选中项目
        /// </summary>
        [Browsable(false)]
        public object SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    popupView.DefaultSelectedValue = DataBinder.GetValue(_selectedItem, this.ValueMember);
                    if (AutoSetText) this.Text = DataBinder.GetStringValue(_selectedItem, this.DisplayMember);
                    this.OnSelectedValueChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// 获取或设置数据源
        /// </summary>
        [Browsable(false)]
        public object DataSource { get { return popupView.DataSource; } set { popupView.DataSource = value; } }
        /// <summary>
        /// 获取或设置窗口的最大限制
        /// </summary>
        public Size PopupMaximumSize { get { return popupView.MaximumSize; } set { popupView.MaximumSize = value; } }
        /// <summary>
        /// 获取或设置窗口的最小限制
        /// </summary>
        public Size PopupMinimumSize { get { return popupView.MinimumSize; } set { popupView.MinimumSize = value; } }
        private new bool ReadOnly { get { return true; } }
        /// <summary>
        /// 是否可以改变窗口大小
        /// </summary>
        public bool CanResizePopup { get { return popupHost.CanResize; } set { popupHost.CanResize = value; } }
        /// <summary>
        /// 是否显示窗口阴影
        /// </summary>
        public bool ShowPopupShadow { get { return popupHost.DropShadowEnabled; } set { popupHost.DropShadowEnabled = value; } }
        /// <summary>
        /// 获取或设置窗口边框宽度
        /// </summary>
        public Padding PopupBorderWidth { get { return popupHost.Padding; } set { popupHost.Padding = value; } }
        /// <summary>
        /// 获取或设置窗口边框颜色
        /// </summary>
        public Color PopupBorderColor { get { return popupHost.BorderColor; } set { popupHost.BorderColor = value; } }
        /// <summary>
        /// 获取或设置窗口的上下偏移量
        /// </summary>
        public int PopupOffSet { get; set; }
        public SymbolBox ClearButton
        {
            get { return sbClear; }
        }

        public bool ShowClearButton
        {
            get { return _ShowClearButton; }
            set
            {
                _ShowClearButton = value;
                if (_ShowClearButton)
                {
                    if (!string.IsNullOrEmpty(this.Text) && this.Enabled)
                        sbClear.Visible = true;
                    else
                        sbClear.Visible = false;
                }
                else
                {
                    sbClear.Visible = false;
                }
            }
        }
        public bool IsPopupOpen { get { return this.popupHost.Visible; } }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        public FindComboBox()
        {
            base.ReadOnly = true;
            this.BackColor = Color.White;
            this.PopupOffSet = 2;
            this.Cursor = Cursors.Arrow;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            popupHost = new PopupControlHost(popupView);
            popupHost.IngoreControl = this; //设置点击当前控件不会自动关闭窗口
            popupHost.OpenFocused = true; //设置显示窗口是获得焦点
            popupHost.Padding = new System.Windows.Forms.Padding(1); //设置窗口边框大小
            popupHost.BorderColor = Color.FromArgb(179, 199, 225); //设置窗口边框颜色
            popupHost.EnableInternalAutoClose = true;
            popupView.DoubleClickedToSelect = false; //设置点击选择项目
            popupView.FilterTextBox.TextChanged += FilterTextBox_TextChanged;
            popupView.ItemSelected += popupView_ItemSelected;

            this.sbClear.TabStop = false;
            this.sbClear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbClear.BackColor = this.BackColor;
            this.sbClear.Location = new Point(this.Width - 22, 0);
            this.sbClear.Size = new System.Drawing.Size(22, this.Height);
            this.sbClear.Symbol = "57676";
            this.sbClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sbClear.SymbolColor = System.Drawing.Color.FromArgb(68, 136, 229);
            this.sbClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.sbClear.Click += (sender, e) => { this.SelectedItem = null; };
            base.Controls.Add(sbClear);
            sbClear.BringToFront();
            this.sbClear.Visible = false;
        }
        /// <summary>
        /// 注册实时过滤的方法
        /// </summary>
        /// <param name="onFilter">过滤查询到对象列表</param>
        /// <param name="valueToFindItem">通过值查找值对应的项目信息</param>
        public void SetRealTimeSearchMethod(Func<string, object> onFilter, Func<object, object> valueToFindItem)
        {
            this.popupView.GetDataSource = onFilter;
            _valueToFindItemMehod = valueToFindItem;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AdjustPopupLoactionAndSize();
        }

        private void popupView_ItemSelected(object sender, EventArgs e)
        {
            this.SelectedItem = popupView.SelectedItem;
            if (this.Visible)
                popupHost.Close();
            this.OnItemSelected(this, e);
        }

        protected virtual void OnItemSelected(object sender, EventArgs e)
        {
            this.ItemSelected?.Invoke(sender, e);
        }

        protected virtual void OnSelectedValueChanged(object sender, EventArgs e)
        {
            this.SelectedValueChanged?.Invoke(sender, e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (popupHost.Visible && this.Visible == false)
                popupHost.Close();
        }

        /// <summary>
        /// 矫正窗口位置和大小
        /// </summary>
        private void AdjustPopupLoactionAndSize()
        {
            var size = popupView.CalcItemsSize();
            if (size.Width < this.Width)
                size.Width = this.Width;
            var screen = Screen.GetWorkingArea(this);
            var pointTop = this.Parent.PointToScreen(this.Location);
            var pointBottom = new Point(pointTop.X, pointTop.Y + this.Height);
            if (popupView.MinimumSize.Width > 0 && size.Width < popupView.MinimumSize.Width)
            {
                size.Width = this.MinimumSize.Width;
            }
            if (popupView.MaximumSize.Width > 0 && size.Width > popupView.MaximumSize.Width)
            {
                size.Width = popupView.MaximumSize.Width;
            }
            if (popupView.MinimumSize.Height > 0 && size.Height < popupView.MinimumSize.Height)
            {
                size.Height = popupView.MinimumSize.Height;
            }
            if (popupView.MaximumSize.Height > 0 && size.Height > popupView.MaximumSize.Height)
            {
                size.Height = popupView.MaximumSize.Height;
            }
            if (size.Width > screen.Width)
                size.Width = screen.Width - 10;
            if (size.Height > screen.Height)
                size.Height = screen.Height - 10;
            if (size.Width <= 0)
                size.Width = this.Width - popupHost.Padding.Horizontal;
            if (size.Height <= 0)
                size.Height = 200;

            var bottomHeight = screen.Height - pointBottom.Y;
            if (size.Height > bottomHeight - this.PopupOffSet && size.Height > pointTop.Y - this.PopupOffSet)
            {
                if (pointTop.Y < bottomHeight)
                {
                    size.Height = bottomHeight - this.PopupOffSet;
                }
                else
                {
                    size.Height = pointTop.Y - this.PopupOffSet;
                }
            }

            popupView.Size = size;

            if (!popupView.UpOrDown)
            {
                popupHost.Location = new Point(pointTop.X, pointTop.Y - size.Height - this.PopupOffSet);
            }

        }
        /// <summary>
        /// 显示窗口
        /// </summary>
        /// <param name="forceUpdate">是否强制显示</param>
        public void ShowPopup(bool forceUpdate = false)
        {
            if (!forceUpdate && popupHost.Visible)
                return;
            popupHost.SetOwnerItem(this);
            var size = popupView.CalcItemsSize();
            if (size.Width < this.Width)
                size.Width = this.Width;
            var pointTop = this.Parent.PointToScreen(this.Location);
            var pointBottom = new Point(pointTop.X, pointTop.Y + this.Height);
            var screen = Screen.GetWorkingArea(this);
            var bottomHeight = screen.Height - pointBottom.Y;
            var rightWidth = screen.Width - pointTop.X;
            int positionX;
            int positionY;
            bool showUpOrDown = false;
            #region 防止大小超出边界

            if (popupView.MinimumSize.Width > 0 && size.Width < popupView.MinimumSize.Width)
            {
                size.Width = this.MinimumSize.Width;
            }
            if (popupView.MaximumSize.Width > 0 && size.Width > popupView.MaximumSize.Width)
            {
                size.Width = popupView.MaximumSize.Width;
            }
            if (popupView.MinimumSize.Height > 0 && size.Height < popupView.MinimumSize.Height)
            {
                size.Height = popupView.MinimumSize.Height;
            }
            if (popupView.MaximumSize.Height > 0 && size.Height > popupView.MaximumSize.Height)
            {
                size.Height = popupView.MaximumSize.Height;
            }
            if (size.Width > screen.Width)
                size.Width = screen.Width - 10;
            if (size.Height > screen.Height)
                size.Height = screen.Height - 10;
            if (size.Width <= 0)
                size.Width = this.Width - popupHost.Padding.Horizontal;
            if (size.Height <= 0)
                size.Height = 200;

            #endregion
            #region 计算X轴坐标和允许显示的宽度

            if (size.Width <= rightWidth)
            {
                positionX = pointTop.X;
            }
            else
            {
                positionX = pointTop.X - (size.Width - rightWidth);
            }
            #endregion
            #region 计算Y轴坐标和允许显示的高度

            if (size.Height <= bottomHeight - this.PopupOffSet)
            {
                positionY = pointBottom.Y + this.PopupOffSet;
            }
            else
            {
                if (size.Height <= pointTop.Y - this.PopupOffSet)
                {
                    positionY = pointTop.Y - size.Height - this.PopupOffSet;
                    showUpOrDown = true;
                }
                else
                {
                    if (pointTop.Y < bottomHeight)
                    {
                        positionY = pointBottom.Y + this.PopupOffSet;
                        size.Height = bottomHeight - this.PopupOffSet;
                    }
                    else
                    {
                        positionY = 0;
                        size.Height = pointTop.Y - this.PopupOffSet;
                        showUpOrDown = true;
                    }
                }
            }
            #endregion
            popupView.UpOrDown = !showUpOrDown;
            popupView.Size = size;
            popupHost.Show(new Point(positionX, positionY));

        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (this.Enabled && this.ShowClearButton && !string.IsNullOrEmpty(this.Text))
            {
                this.ShowClearButton = true;
            }
            else
            {
                this.ShowClearButton = false;
            }
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.sbClear.BackColor = this.BackColor;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (this.ShowClearButton)
            {
                this.sbClear.Visible = !string.IsNullOrEmpty(this.Text);
            }
        }
        /// <summary>
        /// 重写鼠标点击事件
        /// 设置点击显示窗口
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            if (!this.Enabled) return;
            if (this.FocusOpen && !this.Focused) return;
            if (popupHost.Visible)
                popupHost.Close();
            else
            {
                popupView.FilterTextBox.Text = "";
                popupView.DefaultSelectedValue = this.SelectedValue;
                ShowPopup();
            }
            base.OnMouseClick(e);
        }

        /// <summary>
        /// 重写获得焦点时事件
        /// 设置获得焦点是否显示窗口
        /// </summary>
        /// <param name="e"></param>
        protected override void OnGotFocus(EventArgs e)
        {
            if (this.FocusOpen && this.Enabled)
            {
                this.ShowPopup();
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (popupHost.Visible && !popupHost.Focused)
                popupHost.Close();
            base.OnLostFocus(e);
        }
        /// <summary>
        /// 设置显示窗口快捷键(Down)
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && this.Enabled)
            {
                popupView.FilterTextBox.Text = "";
                popupView.DefaultSelectedValue = this.SelectedValue;
                this.ShowPopup();
            }
            if (e.KeyCode == Keys.Back && this.Enabled)
            {
                this.SelectedItem = null;
            }
            else
            {
                char keyChar = (char)e.KeyValue;
                if (char.IsLetter(keyChar)
                    || char.IsNumber(keyChar))
                {
                    popupView.FilterTextBox.Text = keyChar.ToString();
                    popupView.DefaultSelectedValue = this.SelectedValue;
                    this.ShowPopup();
                    popupView.FilterTextBox.SelectionStart = popupView.FilterTextBox.Text.Length;

                }
            }
            base.OnKeyDown(e);
        }

    }
}
