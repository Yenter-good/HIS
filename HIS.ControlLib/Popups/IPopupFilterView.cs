﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS.ControlLib.Popups
{
    /// <summary>
    /// 弹出式过滤窗口接口
    /// </summary>
    public interface IPopupFilterView
    {
        /// <summary>
        /// 用于展现数据的控件
        /// </summary>
        Control View { get; }
        /// <summary>
        /// 是否自动大小
        /// </summary>
        bool Adaptive { get; set; }
        /// <summary>
        /// 选中的文本
        /// </summary>
        string SelectedText { get; }
        /// <summary>
        /// 选中的值
        /// </summary>
        object SelectedValue { get; }
        /// <summary>
        /// 选中的项目
        /// </summary>
        object SelectedItem { get; }
        /// <summary>
        /// 项目选择后发生
        /// </summary>
        event EventHandler ItemSelected;
        /// <summary>
        /// 数据过滤
        /// </summary>
        /// <param name="filteText"></param>
        int Filter(string filteText);
        /// <summary>
        /// 计算大小
        /// </summary>
        Size CalcItemsSize();
    }

    public interface IFindPopupFilterView : IPopupFilterView
    {
        /// <summary>
        /// 获取或设置过滤文本框对象
        /// </summary>
        TextBoxBase FilterTextBox { get; }
        /// <summary>
        /// 获取或设置默认选中项目值
        /// </summary>
        object DefaultSelectedValue { get; set; }
    }
}
