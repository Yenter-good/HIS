using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HIS.Core.UI
{
    /// <summary>
    /// 基础的对话框界面
    /// </summary>
    public partial class BaseDialogForm : BaseForm
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Serializable]
        public class ButtonStyle
        {
            private ButtonX button;
            [Description("文本")]
            public string Text { get { return button.Text; } set { button.Text = value; } }
            [Description("按钮宽度")]
            public int Width { get { return button.Width; } set { button.Width = value; } }
            [Description("是否自动大小")]
            public bool AutoSize { get { return button.AutoSize; } set { button.AutoSize = false; } }
            [Description("获取或设置一个值，该值指示控件是否可以对用户交互作出响应")]
            public bool Enable { get { return button.Enabled; } set { button.Enabled = value; } }
            public ButtonStyle()
            {

            }
            public ButtonStyle(ButtonX btn)
            {
                button = btn;
            }
        }
        private MessageBoxButtons dialogMode = MessageBoxButtons.OKCancel;
        private bool showDialogButton = true;
        private ButtonX defaultFocusButton;
        private bool shown = false;


        /// <summary>
        /// ESC关闭窗体
        /// </summary>
        [Description("ESC关闭窗体")]
        public bool EscClose { get; set; }
        /// <summary>
        /// 对话框模式
        /// </summary>
        [Description("对话框模式")]
        public MessageBoxButtons DialogMode
        {
            get { return dialogMode; }
            set
            {
                dialogMode = value;
                this.btnCancel.Visible = false;
                this.btnOK.Visible = false;
                this.btnNO.Visible = false;
                this.btnIngore.Visible = false;
                this.btnAbort.Visible = false;
                this.btnYes.Visible = false;
                this.btnRetry.Visible = false;
                switch (dialogMode)
                {
                    case MessageBoxButtons.OK:
                        this.btnOK.Visible = true;
                        break;
                    case MessageBoxButtons.OKCancel:
                        this.btnOK.Visible = true;
                        this.btnCancel.Visible = true;
                        break;
                    case MessageBoxButtons.AbortRetryIgnore:
                        this.btnAbort.Visible = true;
                        this.btnRetry.Visible = true;
                        this.btnIngore.Visible = true;
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        this.btnYes.Visible = true;
                        this.btnNO.Visible = true;
                        this.btnCancel.Visible = true;
                        break;
                    case MessageBoxButtons.YesNo:
                        this.btnYes.Visible = true;
                        this.btnNO.Visible = true;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        this.btnRetry.Visible = true;
                        this.btnCancel.Visible = true;
                        break;
                    default:
                        break;
                }
                if (shown)
                    this.SetDefaultButton(MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// 是否显示对话框按钮
        /// </summary>
        [Description("是否显示对话框按钮")]
        public bool ShowDialogButton
        {
            get { return showDialogButton; }
            set
            {
                showDialogButton = value;
                this.fpnlButton.Visible = value;
                this.pnlBackgrond.Visible = value;
                if (value)
                    this.Padding = new System.Windows.Forms.Padding(this.Padding.Left, this.Padding.Top, this.Padding.Right, this.fpnlButton.Height);
                else
                    this.Padding = new System.Windows.Forms.Padding(this.Padding.Left, this.Padding.Top, this.Padding.Right, 0);
            }
        }
        /// <summary>
        /// 确定按钮
        /// </summary>
        [Description("确定按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle OKBtn
        {
            get { return new ButtonStyle(this.btnOK); }
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        [Description("取消按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle CancelBtn
        {
            get { return new ButtonStyle(this.btnCancel); }
        }
        /// <summary>
        /// 中止按钮
        /// </summary>
        [Description("中止按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle AbortBtn
        {
            get { return new ButtonStyle(this.btnAbort); }
        }
        /// <summary>
        /// 重试按钮
        /// </summary>
        [Description("重试按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle RetryBtn
        {
            get { return new ButtonStyle(this.btnRetry); }
        }
        /// <summary>
        /// 忽略按钮
        /// </summary>
        [Description("忽略按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle IgnoreBtn
        {
            get { return new ButtonStyle(this.btnIngore); }
        }
        /// <summary>
        /// 否按钮
        /// </summary>
        [Description("[否]按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle NoBtn
        {
            get { return new ButtonStyle(this.btnNO); }
        }
        /// <summary>
        /// 是按钮
        /// </summary>
        [Description("[是]按钮样式")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyle YesBtn
        {
            get { return new ButtonStyle(this.btnYes); }
        }

        public BaseDialogForm()
        {
            InitializeComponent();
            this.EscClose = true;
        }


        #region  按键触发的方法

        /// <summary>
        /// 确定时发生
        /// </summary>
        protected virtual void OnOK()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 取消时发生
        /// </summary>
        protected virtual void OnCancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// 是时发生
        /// </summary>
        protected virtual void OnYes()
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        /// <summary>
        /// 否时发生
        /// </summary>
        protected virtual void OnNO()
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        /// <summary>
        /// 忽略时发生
        /// </summary>
        protected virtual void OnIgnore()
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }
        /// <summary>
        /// 中止时发生
        /// </summary>
        protected virtual void OnAbort()
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
        /// <summary>
        /// 重试时发生
        /// </summary>
        protected virtual void OnRetry()
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        #endregion
        /// <summary>
        /// 设置默认焦点按钮
        /// </summary>
        /// <param name="defaultButton"></param>
        public void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (this.DialogMode)
            {
                case MessageBoxButtons.OK:
                    defaultFocusButton = this.btnOK;
                    break;
                case MessageBoxButtons.OKCancel:
                    if (defaultButton == MessageBoxDefaultButton.Button2)
                        defaultFocusButton = this.btnCancel;
                    else
                        defaultFocusButton = this.btnOK;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            defaultFocusButton = this.btnAbort;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            defaultFocusButton = this.btnRetry;
                            break;
                        case MessageBoxDefaultButton.Button3:
                            defaultFocusButton = this.btnIngore;
                            break;
                        default:
                            break;
                    }
                    break;
                case MessageBoxButtons.YesNoCancel:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            defaultFocusButton = this.btnYes;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            defaultFocusButton = this.btnNO;
                            break;
                        case MessageBoxDefaultButton.Button3:
                            defaultFocusButton = this.btnCancel;
                            break;
                        default:
                            break;
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button2:
                            defaultFocusButton = this.btnNO;
                            break;
                        default:
                            defaultFocusButton = this.btnYes;
                            break;
                    }
                    break;
                case MessageBoxButtons.RetryCancel:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button2:
                            defaultFocusButton = this.btnCancel;
                            break;
                        default:
                            defaultFocusButton = this.btnRetry;
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public void SetButtonInvoke(MessageBoxDefaultButton defaultButton)
        {
            switch (this.DialogMode)
            {
                case MessageBoxButtons.OK:
                    this.btnOK.Focus();
                    break;
                case MessageBoxButtons.OKCancel:
                    if (defaultButton == MessageBoxDefaultButton.Button2)
                        this.btnCancel.Focus();
                    else
                        this.btnOK.Focus();
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            this.btnAbort.Focus();
                            break;
                        case MessageBoxDefaultButton.Button2:
                            this.btnRetry.Focus();
                            break;
                        case MessageBoxDefaultButton.Button3:
                            this.btnIngore.Focus();
                            break;
                        default:
                            break;
                    }
                    break;
                case MessageBoxButtons.YesNoCancel:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            this.btnYes.Focus();
                            break;
                        case MessageBoxDefaultButton.Button2:
                            this.btnNO.Focus();
                            break;
                        case MessageBoxDefaultButton.Button3:
                            this.btnCancel.Focus();
                            break;
                        default:
                            break;
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button2:
                            this.btnNO.Focus();
                            break;
                        default:
                            this.btnYes.Focus();
                            break;
                    }
                    break;
                case MessageBoxButtons.RetryCancel:
                    switch (defaultButton)
                    {
                        case MessageBoxDefaultButton.Button2:
                            this.btnCancel.Focus();
                            break;
                        default:
                            this.btnRetry.Focus();
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 调整按钮位置
        /// </summary>
        private void AdapterDialogButtonLocaltion()
        {
            if (this.fpnlButton == null) return;
            this.fpnlButton.Width = this.ClientSize.Width - 10;
            this.fpnlButton.Left = 0;
            this.fpnlButton.Top = this.ClientSize.Height - this.fpnlButton.Height;
            this.pnlBackgrond.Top = this.fpnlButton.Top;
            this.pnlBackgrond.Width = this.ClientSize.Width;
        }
        protected override void OnShown(EventArgs e)
        {
            shown = true;
            base.OnShown(e);
            if (defaultFocusButton != null)
                defaultFocusButton.Focus();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.AdapterDialogButtonLocaltion();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.Modal && this.DialogResult == DialogResult.None)
            {
                switch (DialogMode)
                {
                    case MessageBoxButtons.OK:
                        this.DialogResult = DialogResult.OK;
                        break;
                    case MessageBoxButtons.OKCancel:
                        this.DialogResult = DialogResult.Cancel;
                        break;
                    case MessageBoxButtons.AbortRetryIgnore:
                        this.DialogResult = DialogResult.Ignore;
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        this.DialogResult = DialogResult.Cancel;
                        break;
                    case MessageBoxButtons.YesNo:
                        this.DialogResult = DialogResult.No;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        this.DialogResult = DialogResult.Cancel;
                        break;
                    default:
                        break;
                }
            }
            base.OnFormClosed(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && this.EscClose)
            {
                if (this.Modal)
                {
                    if (!this.ShowDialogButton)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        switch (this.DialogMode)
                        {
                            case MessageBoxButtons.OK:
                                this.DialogResult = DialogResult.OK;
                                break;
                            case MessageBoxButtons.OKCancel:
                                this.DialogResult = DialogResult.Cancel;
                                break;
                            case MessageBoxButtons.AbortRetryIgnore:
                                this.DialogResult = DialogResult.Ignore;
                                break;
                            case MessageBoxButtons.YesNoCancel:
                                this.DialogResult = DialogResult.Cancel;
                                break;
                            case MessageBoxButtons.YesNo:
                                this.DialogResult = DialogResult.No;
                                break;
                            case MessageBoxButtons.RetryCancel:
                                this.DialogResult = DialogResult.Cancel;
                                break;
                            default:
                                break;
                        }
                    }
                }
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region 常用的按键事件

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.OnOK();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.OnCancel();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.OnAbort();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.OnRetry();
        }

        private void btnIngore_Click(object sender, EventArgs e)
        {
            this.OnIgnore();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.OnYes();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.OnNO();
        }
        #endregion

    }
}
