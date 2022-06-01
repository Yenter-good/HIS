using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using HIS.Utility.Win32;
using HIS.ControlLib.Popups;

namespace System.Windows.Forms
{
    public static class PopupExtension
    {
        /// <summary>
        /// 临时附加数据
        /// </summary>
        private class TempTag
        {
            public IPopupFilterView View { get; set; }
            public PopupControlHost Host { get; set; }
            public EventHandler ItemSelected { get; set; }
            public EventHandler TextChanged { get; set; }
            public KeyEventHandler KeyDown { get; set; }
            public TempTag(IPopupFilterView view, PopupControlHost host)
            {
                this.View = view;
                this.Host = host;
            }
        }
        /// <summary>
        /// 初始化文本值
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        public static void InitPopupText(this TextBoxBase textBox, string text)
        {
            bool enable = textBox.Enabled;
            if (enable)
                textBox.Enabled = false;
            textBox.Text = text;
            textBox.Enabled = enable;
        }
        /// <summary>
        /// 设置文本框过滤提示框
        /// 调用方式
        /// //只要继承了Textboxbase的控件支持
        ////new TextBox().ComboPopup(selectedItem =>
        ////{
        ////    //selectedItem为选中的对象
        ////    //选中后执行的代码
        ////}
        ////, v =>
        ////{
        ////    v.Size = new Size(100, 100); //设置显示的窗口大小 默认为textbox的宽度，高度为100
        ////    v.DataSource = null; //设置数据源
        ////    v.DisplayMember = ""; //设置显示的字段
        ////    v.ValueMember = ""; //设置值的字段
        ////    v.FilterFields = new string[] { }; //设置用于过滤的字段
        ////}, p => {
        ////    p.CanResize = true;//是否允许拉动窗口大小 默认不支持
        ////    p.BorderColor = Color.Gray; //设置窗口边框颜色 默认为蓝色
        ////    p.AutoClose = true;//设置是否自动关闭窗体 默认为true
        ////}
        ////,true //是否选择后设置textbox文本为选择的文本
        ////, PopupPosition.Bottom //设置窗口显示的位置 默认为文本框的左下角
        ////);
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="itemSelected">选中后发生</param>
        /// <param name="viewAction">可以设置筛选框的数据源，显示字段，与过滤字段</param>
        /// <param name="popupHostAction">可以设置显示窗口的边框样式与拖拽方式</param>
        /// <param name="appendText">是否设置选中后设置文本框文本</param>
        /// <param name="position">设置显示位置</param>
        public static void ComboPopup(this TextBoxBase textBox, Action<object> itemSelected, Action<ComboPopupView> viewAction, Action<PopupControlHost> popupHostAction, Func<string> getFilterText = null, bool updateText = true, PopupPosition position = PopupPosition.Bottom, bool enterTab = true)
        {
            var popupView = new ComboPopupView();
            (popupView as Control).Size = new Size(textBox.Width, 200);
            if (viewAction != null)
                viewAction(popupView);
            Popup<ComboPopupView>(textBox, popupView, itemSelected, popupHostAction, getFilterText, updateText, position, enterTab);
        }
        //public static void ComboFindPopup(this TextBoxBase textBox, Action<object> itemSelected, Action<ComboFindPopupView> viewAction, Action<PopupControlHost> popupHostAction, bool updateText = true, PopupPosition position = PopupPosition.Bottom)
        //{
        //    var popupView = new ComboFindPopupView();
        //    (popupView as Control).Size = new Size(textBox.Width, 200);
        //    if (viewAction != null)
        //        viewAction(popupView);
        //    FindPopup<ComboFindPopupView>(textBox, popupView, itemSelected, popupHostAction, updateText, position);
        //}
        public static void GridPopup(this TextBoxBase textBox, Action<object> itemSelected, Action<GridPopupView> viewAction, Action<PopupControlHost> popupHostAction, Func<string> getFilterText = null, bool updateText = true, PopupPosition position = PopupPosition.Bottom, bool enterTab = true)
        {
            var popupView = new GridPopupView();
            (popupView as Control).Size = new Size(textBox.Width, 200);
            if (viewAction != null)
                viewAction(popupView);
            Popup<GridPopupView>(textBox, popupView, itemSelected, popupHostAction, getFilterText, updateText, position, enterTab);

        }

        private static void Popup<TPopupView>(TextBoxBase textBox, TPopupView popupView, Action<object> itemSelected, Action<PopupControlHost> popupHostAction, Func<string> getFilterText = null, bool updateText = true, PopupPosition position = PopupPosition.Bottom, bool enterTab = true) where TPopupView : Control, IPopupFilterView
        {
            DisposeTag(textBox);
            var popupHost = new PopupControlHost(popupView as Control);
            popupHost.BorderColor = Color.Gray;
            if (popupHostAction != null)
                popupHostAction(popupHost);
            bool isItemSelected = false;
            var itemSelectedEventHandler = new EventHandler((s, e) =>
            {
                isItemSelected = true;
                if (updateText)
                {
                    textBox.Text = popupView.SelectedText;
                    textBox.SelectAll();
                }
                if (itemSelected != null)
                {
                    itemSelected(popupView.SelectedItem);
                }
                if (popupHost.Visible)
                    popupHost.Close();
                isItemSelected = false;
            });
            var textChangedEventHandler = new EventHandler((s, e) =>
            {
                if (isItemSelected || !textBox.Enabled || textBox.ReadOnly) return;
                string filterText = textBox.Text;
                if (getFilterText != null)
                    filterText = getFilterText();
                int count = popupView.Filter(filterText);
                if (popupView.Adaptive)
                {
                    Size size = popupView.CalcItemsSize();
                    popupView.Size = size;
                }
                if (count == 0)
                {
                    if (popupHost.Visible)
                    {
                        popupHost.Close();
                    }
                }
                else
                    //if (!popupHost.Visible)
                    popupHost.Show(textBox, position);
            });
            var keyDowChanged = new KeyEventHandler((s, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                    case Keys.Up:
                    case Keys.PageUp:
                    case Keys.PageDown:
                        if (popupView.View != null && (popupView as Control).IsHandleCreated && popupHost.Visible)
                        {
                            UnsafeNativeMethods.SendMessage(popupView.View.Handle, (int)WinMsg.WM_KEYDOWN, (int)e.KeyCode, 0);
                            e.Handled = true;
                        }
                        break;
                    case Keys.Enter:
                        if (popupView.View != null && (popupView as Control).IsHandleCreated && popupHost.Visible)
                        {
                            UnsafeNativeMethods.SendMessage(popupView.View.Handle, (int)WinMsg.WM_KEYDOWN, (int)e.KeyCode, 0);
                            e.Handled = true;
                        }
                        else
                        {
                            if (enterTab)
                                SendKeys.Send("{Tab}");
                        }
                        break;
                    default:
                        break;
                }
            });

            popupView.ItemSelected += itemSelectedEventHandler;
            textBox.TextChanged += textChangedEventHandler;
            textBox.KeyDown += keyDowChanged;

            var tag = new TempTag(popupView, popupHost);
            tag.ItemSelected = itemSelectedEventHandler;
            tag.TextChanged = textChangedEventHandler;
            tag.KeyDown = keyDowChanged;
            textBox.Tag = tag;
        }

        private static void DisposeTag(TextBoxBase textBox)
        {
            if (textBox.Tag is TempTag)
            {
                var tag = textBox.Tag as TempTag;
                if (tag.View != null)
                {
                    tag.View.ItemSelected -= tag.ItemSelected;
                    (tag.View as Control).Dispose();
                    tag.View = null;
                }
                if (tag.Host != null)
                {
                    tag.Host.Dispose();
                    tag.Host = null;
                }
                textBox.TextChanged -= tag.TextChanged;
                textBox.KeyDown -= tag.KeyDown;
            }
        }
        //private static void FindPopup<TPopupView>(TextBoxBase textBox, TPopupView popupView, Action<object> itemSelected, Action<PopupControlHost> popupHostAction, bool updateText = true, PopupPosition position = PopupPosition.Bottom) where TPopupView : Control, IFindPopupFilterView
        //{
        //    textBox.ReadOnly = true;

        //    PopupControlHost popupHost = new PopupControlHost(popupView as Control);
        //    popupHost.IngoreControl = textBox;
        //    popupHost.BorderColor = Color.Gray;
        //    popupHost.OpenFocused = true;
        //    if (popupHostAction != null)
        //        popupHostAction(popupHost);
        //    popupView.FilterTextChanged += (filterText) => {
        //        if (popupView.Adaptive)
        //        {
        //            popupView.Size = popupView.CalcItemsSize();
        //        }
        //    };
        //    popupView.ItemSelected += (s, e) =>
        //    {
        //        if (updateText)
        //        {
        //            textBox.Text = popupView.SelectedText;
        //            textBox.SelectAll();
        //        }
        //        if (itemSelected != null)
        //        {
        //            itemSelected(popupView.SelectedItem);
        //        }
        //        if (popupHost.Visible)
        //            popupHost.Close();
        //    };

        //    textBox.MouseClick += (s, e) =>
        //    {
        //        //popupView.Filter(textBox.Text.Trim());
        //        if (popupView.Adaptive)
        //        {
        //            Size size = popupView.CalcItemsSize();
        //            popupView.Size = size;
        //        }
        //        if (!popupHost.Visible)
        //            popupHost.Show(textBox, position);
        //        else
        //            popupHost.Close();
        //    };
        //    textBox.KeyDown += (s, e) => {
        //        if (e.KeyCode == Keys.Down)
        //        {
        //            if(!popupHost.Visible)
        //                popupHost.Show(textBox, position);
        //        }
        //    };
        //}
    }
}
