using DevComponents.DotNetBar;
using HIS.Service.Core.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HIS.Core
{
    /// <summary>
    /// 消息提示框
    /// </summary>
    public static class MsgBox
    {
        /// <summary>
        /// 显示确定提示框
        /// </summary>
        /// <param name="text"></param>
        public static void OK(string text)
        {
            HIS.Core.UI.MsgBox.Show(text);
        }
        /// <summary>
        /// 显示错误提示框
        /// </summary>
        /// <param name="text"></param>
        public static void Error(string text)
        {
            HIS.Core.UI.MsgBox.Error(text);
        }
        /// <summary>
        /// 根据结果显示提示对话框
        /// </summary>
        /// <param name="dr"></param>
        public static void Show(DataResult dr)
        {
            if (dr.Success)
                MsgBox.OK(dr.Message);
            else
                MsgBox.Error(dr.Message);
        }

        public static void Ok()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 是否选择对话框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="title">标题</param>
        /// <param name="icon">图标样式</param>
        /// <param name="defaultButton">默认焦点按钮</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult YesNo(string text, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            return HIS.Core.UI.MsgBox.YesNo(text, title, icon, defaultButton);
        }
        /// <summary>
        /// 确定取消选择对话框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="title">标题</param>
        /// <param name="icon">图标样式</param>
        /// <param name="defaultButton">默认焦点按钮</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult OKCancel(string text, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            return HIS.Core.UI.MsgBox.OKCancel(text, title, icon, defaultButton);
        }
        /// <summary>
        /// 终止重试忽略对话框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="title">标题</param>
        /// <param name="icon">图标样式</param>
        /// <param name="defaultButton">默认焦点按钮</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult AbortRetryIgnore(string text, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            return HIS.Core.UI.MsgBox.AbortRetryIgnore(text, title, icon, defaultButton);
        }
        /// <summary>
        /// 重试取消对话框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="title">标题</param>
        /// <param name="icon">图标样式</param>
        /// <param name="defaultButton">默认焦点按钮</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult RetryCancel(string text, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2)
        {
            return HIS.Core.UI.MsgBox.RetryCancel(text, title, icon, defaultButton);
        }
        /// <summary>
        /// 是否取消对话框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="title">标题</param>
        /// <param name="icon">图标样式</param>
        /// <param name="defaultButton">默认焦点按钮</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult YesNoCancel(string text, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            return HIS.Core.UI.MsgBox.YesNoCancel(text, title, icon, defaultButton);
        }
        /// <summary>
        /// 通知信息
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        public static void Notification(Control parent, string message)
        {
            ToastNotification.ToastBackColor = Color.White;
            ToastNotification.ToastForeColor = Color.Blue;
            ToastNotification.Show(parent, message, null, 1500, eToastGlowColor.Blue, eToastPosition.MiddleCenter);
        }
    }
}