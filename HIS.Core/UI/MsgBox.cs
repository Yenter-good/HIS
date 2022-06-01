using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HIS.Core.UI
{
    partial class MsgBox : BaseDialogForm
    {
        private bool iconVisible = false;//窗体未显示时直接设置显示的值 获取会与其不一致，所以使用临时变量存储
        private MsgBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 消息框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        public static void Show(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.itemPanel1.RecalcLayout();
            msgBox.DialogMode = MessageBoxButtons.OK;
            msgBox.TopMost = true;
            msgBox.ShowDialog();
        }
        /// <summary>
        /// 错误
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public static void Error(string message, string title = "错误")
        {
            MsgBox.Show(message, title, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 警告
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public static void Warning(string message, string title = "警告")
        {
            MsgBox.Show(message, title, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 确定取消
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult OKCancel(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.itemPanel1.RecalcLayout();
            msgBox.DialogMode = MessageBoxButtons.OKCancel;
            msgBox.SetDefaultButton(defaultButton);
            msgBox.TopMost = true;
            return msgBox.ShowDialog();
        }
        /// <summary>
        /// 是否
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult YesNo(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.itemPanel1.RecalcLayout();
            msgBox.DialogMode = MessageBoxButtons.YesNo;
            msgBox.SetDefaultButton(defaultButton);
            msgBox.TopMost = true;
            return msgBox.ShowDialog();
        }
        /// <summary>
        /// 是否取消
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult YesNoCancel(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.DialogMode = MessageBoxButtons.YesNoCancel;
            msgBox.SetDefaultButton(defaultButton);
            msgBox.TopMost = true;
            return msgBox.ShowDialog();
        }
        /// <summary>
        /// 终止重试忽略
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult AbortRetryIgnore(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.itemPanel1.RecalcLayout();
            msgBox.DialogMode = MessageBoxButtons.AbortRetryIgnore;
            msgBox.SetDefaultButton(defaultButton);
            msgBox.TopMost = true;
            return msgBox.ShowDialog();
        }
        /// <summary>
        /// 重试取消
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static DialogResult RetryCancel(string message, string title = "提示", MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2)
        {
            MsgBox msgBox = new MsgBox();
            msgBox.Text = title;
            msgBox.SetIcon(icon);
            msgBox.SetMsg(message);
            msgBox.itemPanel1.RecalcLayout();
            msgBox.DialogMode = MessageBoxButtons.RetryCancel;
            msgBox.SetDefaultButton(defaultButton);
            msgBox.TopMost = true;
            return msgBox.ShowDialog();
        }
        private void SetMsg(string text)
        {
            if (this.IsDisposed) return;
            if (!this.IsHandleCreated) this.CreateControl();
            //文本显示区域最大值
            Size maxSize = new Size(this.GetTextMaxWidth(this.MaximumSize.Width), this.GetTextMaxHeight(this.MaximumSize.Height));
            //文本显示区域最小值
            Size minSize = new Size(this.GetTextMaxWidth(this.MinimumSize.Width), this.GetTextMaxHeight(this.MinimumSize.Height));
            var textSize = TextRenderer.MeasureText(text, itemPanel1.Font);
            //设置显示窗体大小
            this.Width = this.GetFormWidth(Math.Max(minSize.Width, Math.Min(maxSize.Width, textSize.Width)));
            this.Height = this.GetFromHeight(Math.Max(minSize.Height, Math.Min(maxSize.Height, textSize.Height)));
            int hopeTextHeight = GetTextMaxHeight(this.Height);
            textSize = TextRenderer.MeasureText(text, itemPanel1.Font, new Size(this.GetTextMaxWidth(this.Width), hopeTextHeight));
            int line = (int)Math.Ceiling(textSize.Height / itemPanel1.Font.GetHeight());
            if (line == 1)
            {
                ////当只有1行时 默认为居中显示
                this.itemDockContainer1.Stretch = true;
                this.lbMsg.TextAlignment = StringAlignment.Center;
                this.lbMsg.TextLineAlignment = StringAlignment.Center;
                if (this.itemPanel1.Width - this.GetMsgIconSize() - 32 > textSize.Width)
                    this.lbMsg.PaddingRight = this.GetMsgIconSize();
            }
            else if (textSize.Height <= hopeTextHeight)
            {
                //垂直居中左对齐
                this.itemDockContainer1.Stretch = true;
                this.lbMsg.TextAlignment = StringAlignment.Near;
                this.lbMsg.TextLineAlignment = StringAlignment.Center;
                if (!iconVisible && itemPanel1.Width - 32 > textSize.Width)
                {
                    //尽量居中显示 纯文本情况下
                    this.lbMsg.PaddingLeft = (itemPanel1.Width - 32 - textSize.Width) / 2;
                }
            }
            else
            {
                //顶端左对齐
                this.itemDockContainer1.Stretch = false;
                this.lbMsg.TextAlignment = StringAlignment.Near;
                this.lbMsg.TextLineAlignment = StringAlignment.Near;

                if (!iconVisible && itemPanel1.Width - 32 > textSize.Width)
                {
                    //尽量居中显示 纯文本情况下
                    this.lbMsg.PaddingLeft = (itemPanel1.Width - 32 - textSize.Width) / 2;
                }
            }
            this.lbMsg.Text = text;
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            if (icon == MessageBoxIcon.None)
            {
                this.symbolBox1.Visible = false;
                iconVisible = false;
            }
            else
            {
                iconVisible = true;
                this.symbolBox1.Visible = true; //窗体未显示时直接设置的值 获取会与其不一致
                if (icon == MessageBoxIcon.Hand || icon == MessageBoxIcon.Error)
                {
                    this.symbolBox1.Symbol = "";
                    this.symbolBox1.SymbolColor = Color.Red;
                }
                else
                if (icon == MessageBoxIcon.Warning || icon == MessageBoxIcon.Exclamation)
                {
                    this.symbolBox1.Symbol = "";
                    this.symbolBox1.SymbolColor = Color.Red;
                }
                else
                if (icon == MessageBoxIcon.Question)
                {
                    this.symbolBox1.Symbol = "";
                    this.symbolBox1.SymbolColor = Color.White;
                }
                else
                if (icon == MessageBoxIcon.Stop)
                {
                    this.symbolBox1.Symbol = "";
                    this.symbolBox1.SymbolColor = Color.FromArgb(35, 74, 142);
                }
                else
                if (icon == MessageBoxIcon.Information || icon == MessageBoxIcon.Asterisk)
                {
                    this.symbolBox1.Symbol = "";
                    this.symbolBox1.SymbolColor = Color.FromArgb(35, 74, 142);
                }
            }
        }

        /// <summary>
        /// 获取图标所占位置大小
        /// </summary>
        /// <returns></returns>
        private int GetMsgIconSize()
        {
            if (iconVisible)
                return this.symbolBox1.Width;
            return 0;
        }
        /// <summary>
        /// 获取指定窗体宽度下无滚动情况下文本最大显示宽度
        /// </summary>
        /// <param name="formWidth"></param>
        /// <returns></returns>
        private int GetTextMaxWidth(int formWidth)
        {
            return formWidth
                - (this.Width - this.ClientSize.Width)//窗体左右边框
                - this.GetMsgIconSize()
                - 32;
        }
        /// <summary>
        /// 获取指定窗体高度下无滚动情况下文本最大显示高度
        /// </summary>
        /// <param name="formHeight"></param>
        /// <returns></returns>
        private int GetTextMaxHeight(int formHeight)
        {
            return formHeight
                - this.Padding.Bottom //下边距
                - (this.Height - this.ClientSize.Height)//窗体上下边框与标题栏
                - 10;
        }
        /// <summary>
        /// 获取符合文本宽度的窗体宽度值
        /// </summary>
        /// <param name="textWidth"></param>
        /// <returns></returns>
        private int GetFormWidth(int textWidth)
        {
            return textWidth
                + 32
                + (this.Width - this.ClientSize.Width)//窗体左右边框
               + this.GetMsgIconSize();
        }
        /// <summary>
        /// 获取符合文本高度的窗体高度值
        /// </summary>
        /// <param name="textHeight"></param>
        /// <returns></returns>
        private int GetFromHeight(int textHeight)
        {
            return textHeight
                + this.Padding.Bottom //下边距
                + (this.Height - this.ClientSize.Height)//窗体上下边框与标题栏
                + 10;
        }

    }
}
