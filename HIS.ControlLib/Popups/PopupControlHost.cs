using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Security.Permissions;
using System.ComponentModel;
using HIS.Utility.Win32;

namespace HIS.ControlLib.Popups
{
    [ToolboxItem(false)]

    public class PopupControlHost : ToolStripDropDown

    {
        #region 字段

        private ToolStripControlHost _controlHost;
        private Control _viewControl;


        private bool _changeRegion;
        private bool _openFocused;
        private bool _acceptAlt;
        private bool _resizableTop;
        private bool _resizableLeft;
        private bool _canResize = false;
        private PopupControlHost _ownerPopup;
        private PopupControlHost _childPopup;
        private Color _borderColor = Color.FromArgb(132, 157, 189);

        private bool _autoClose = false;
        private bool _lockMouseDownState = false;//防止一直鼠标一直按着状态也导致窗体关闭
        private Timer _timerAutoClose = null;//监听鼠标是否在窗口外部点击
        private Timer _timerAutoFocus = null;//延迟获取自动获得焦点
        private Rectangle invalidRectangle = Rectangle.Empty;

        /// <summary>
        /// 弹出层内部显示的控件
        /// </summary>
        public Control ViewControl
        {
            get { return _viewControl; }
        }
        /// <summary>
        /// 点击该控件将不会导致窗口关闭
        /// </summary>
        public Control IngoreControl { get; set; }
        #endregion

        #region Constructors
        public PopupControlHost(Control viewControl)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            AutoSize = false;
            base.AutoClose = false;
            Padding = Padding.Empty;
            Margin = Padding.Empty;
            this.DropShadowEnabled = true;
            base.SetStyle(ControlStyles.Selectable, false);
            CreateHost(viewControl);

            this.BubbleControlMouseEvents(viewControl);

            //监听鼠标是否点击窗体外部
            this.AutoClose = true;

            this.Size = viewControl.Size;
        }
        /// <summary>
        /// 冒泡控件的事件都指向PopupControlHost的事件
        /// </summary>
        /// <param name="control"></param>
        private void BubbleControlMouseEvents(Control control)
        {
            if (control == null) return;
            control.MouseDown += (s, e) => { this.OnMouseDown(e); };
            control.MouseUp += (s, e) => { this.OnMouseUp(e); };
            if (control.HasChildren)
            {
                foreach (Control ctr in control.Controls)
                {
                    this.BubbleControlMouseEvents(ctr);
                }
            }
        }
        /// <summary>
        /// 是否启用定时自动关闭
        /// </summary>
        /// <param name="enable"></param>
        private void EnableTimerAutoClose(bool enable)
        {
            if (enable)
            {
                if (_timerAutoClose != null && _timerAutoClose.Enabled) return;
                if (_timerAutoClose == null)
                {
                    _timerAutoClose = new Timer();
                    _timerAutoClose.Interval = 50;
                    _timerAutoClose.Tick += _timerAutoClose_Tick;
                }
                _timerAutoClose.Enabled = true;
            }
            else
            {
                if (_timerAutoClose != null && _timerAutoClose.Enabled)
                {
                    _timerAutoClose.Enabled = false;
                    _timerAutoClose.Dispose();
                    _timerAutoClose = null;
                }
            }

        }
        void _timerAutoClose_Tick(object sender, EventArgs e)
        {
            Point mousePosistion = Control.MousePosition;
            //鼠标点击窗体外时关闭窗体
            if (this.Visible
                && !this.Bounds.Contains(mousePosistion)
                && !AttachInputRect.Contains(mousePosistion)
                && Control.MouseButtons == System.Windows.Forms.MouseButtons.Left
                && !_lockMouseDownState)
            {
                //防止是子弹出层导致当前弹出成关闭
                var childPop = _childPopup;
                while (true)
                {
                    if (childPop == null) break;
                    if (childPop != null && childPop.Visible && childPop.Bounds.Contains(mousePosistion))
                        return;
                    childPop = childPop._childPopup;
                }
                if ((this.IngoreControl == null || !this.IngoreControl.RectangleToScreen(this.IngoreControl.ClientRectangle).Contains(mousePosistion)))

                    Close();
            }
        }

        #endregion

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;//开启双缓冲
        //        return cp;
        //    }
        //}

        #region Properties
        /// <summary>
        /// 附加输入区域
        /// </summary>
        public Rectangle AttachInputRect { get; set; }

        public bool ChangeRegion
        {
            get { return _changeRegion; }
            set { _changeRegion = value; }
        }

        public bool OpenFocused
        {
            get { return _openFocused; }
            set { _openFocused = value; }
        }

        public bool AcceptAlt
        {
            get { return _acceptAlt; }
            set { _acceptAlt = value; }
        }

        public bool CanResize
        {
            get { return _canResize; }
            set { _canResize = value; }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }
        /// <summary>
        /// 是否启用ToolStripDropDown自带自带关闭功能
        /// 【将导致ingnorecontrol 无效】
        /// </summary>
        public bool EnableInternalAutoClose
        {
            get
            {
                return base.AutoClose;
            }
            set
            {
                base.AutoClose = value;
                this.EnableTimerAutoClose(!base.AutoClose && _autoClose);
            }
        }
        /// <summary>
        /// 是否自动关闭窗口
        /// 【启用定时器关闭方案】
        /// </summary>
        public new bool AutoClose
        {
            get
            {
                return _autoClose;
            }
            set
            {
                _autoClose = value;
                if (this.IsDesignMode()) return;
                this.EnableTimerAutoClose(value && !base.AutoClose);
            }
        }

        #endregion

        #region Protected Methods
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            if (_viewControl != null)
            {
                base.Size = new Size(
               _viewControl.Size.Width + Padding.Horizontal,
               _viewControl.Size.Height + Padding.Vertical);
            }
        }
        protected override void OnMouseDown(MouseEventArgs mea)
        {
            if (mea.Button == System.Windows.Forms.MouseButtons.Left)
                _lockMouseDownState = true;
        }

        protected override void OnMouseUp(MouseEventArgs mea)
        {
            base.OnMouseUp(mea);
            _lockMouseDownState = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (_acceptAlt && ((keyData & Keys.Alt) == Keys.Alt))
            {
                if ((keyData & Keys.F4) != Keys.F4)
                {
                    return false;
                }
                else
                {
                    Close();
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (_viewControl.IsDisposed || _viewControl.Disposing)
            {
                e.Cancel = true;
                base.OnOpening(e);
                return;
            }
            _viewControl.RegionChanged += new EventHandler(PopupControlRegionChanged);
            UpdateRegion();
            base.OnOpening(e);
        }

        protected override void OnOpened(EventArgs e)
        {
            if (_openFocused)
            {
                //延迟获得焦点
                if (_timerAutoFocus == null)
                {
                    _timerAutoFocus = new Timer();
                    _timerAutoFocus.Interval = 10;
                    _timerAutoFocus.Tick += _timerAutoFocus_Tick;
                }
                _timerAutoFocus.Enabled = true;
                //_viewControl.Focus(); 直接获取焦点有点卡
            }
            base.OnOpened(e);
        }

        private void _timerAutoFocus_Tick(object sender, EventArgs e)
        {
            if (_openFocused && this.Visible && !this._viewControl.Focused)
            {
                this._viewControl.Focus();
                _timerAutoFocus.Enabled = false;
            }
        }

        protected override void OnClosing(ToolStripDropDownClosingEventArgs e)
        {
            _viewControl.RegionChanged -= new EventHandler(PopupControlRegionChanged);
            var childPop = this._childPopup;
            while (true)
            {
                if (childPop == null)
                    break;
                if (childPop.Visible)
                    childPop.Close();
                childPop = childPop._childPopup;
            }
            base.OnClosing(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (_controlHost != null)
            {
                _controlHost.Size = new Size(
                    Width - Padding.Horizontal, Height - Padding.Vertical);
            }
        }

        [SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (!ProcessGrip(ref m))
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!_changeRegion)
            {
                ControlPaint.DrawBorder(
                    e.Graphics,
                    ClientRectangle,
                    _borderColor,
                    ButtonBorderStyle.Solid);
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _timerAutoClose?.Dispose();
                _timerAutoFocus?.Dispose();
            }
            base.Dispose(disposing);
        }
        protected void UpdateRegion()
        {
            if (!_changeRegion)
            {
                return;
            }

            if (base.Region != null)
            {
                base.Region.Dispose();
                base.Region = null;
            }
            if (_viewControl.Region != null)
            {
                base.Region = _viewControl.Region.Clone();
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// 做模式窗口的循环
        /// </summary>
        public void DoModalLoop()
        {
            while (base.Visible)
            {
                Application.DoEvents();
                UnsafeNativeMethods.MsgWaitForMultipleObjectsEx(0, IntPtr.Zero, 250, 255, 4);
            }
        }

        public void Show(Control control)
        {
            Show(control, new Rectangle(Point.Empty, new Size(control.Width, control.Height)));
        }

        public void Show(Control control, bool center)
        {
            Show(control, control.ClientRectangle, center);
        }

        public void Show(Control control, Rectangle rect)
        {
            Show(control, rect, false);
        }
        public void Show(Control control, PopupPosition position)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            SetOwnerItem(control);
            if (!_changeRegion)
            {
                Padding = new Padding(1);
            }
            else
            {
                Padding = Padding.Empty;
            }
            Point location = Point.Empty;
            switch (position)
            {
                case PopupPosition.Left:
                    location = new Point(-this.Width, 0);
                    break;
                case PopupPosition.Right:
                    location = new Point(this.Width, 0);
                    break;
                case PopupPosition.Top:
                    location = new Point(0, -this.Height);
                    var sp1 = control.PointToScreen(location);
                    if (sp1.Y < 0)
                    {
                        this.Height += sp1.Y;
                        location = new Point(0, -this.Height);
                    }
                    break;
                case PopupPosition.Bottom:
                    location = new Point(0, control.Height);
                    Rectangle screenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
                    var sp2 = control.PointToScreen(location);
                    var height = screenArea.Height - sp2.Y;
                    if (this.Height > height)
                        this.Height = height;
                    break;
                default:
                    break;
            }
            location.X -= Padding.Right + 2;
            location.Y -= Padding.Top;
            this.Show(control, location);
        }
        public void Show(Control control, Rectangle rect, bool center)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            SetOwnerItem(control);

            if (!_changeRegion)
            {
                Padding = new Padding(1);
            }
            else
            {
                Padding = Padding.Empty;
            }

            int width = Padding.Horizontal;
            int height = Padding.Vertical;

            base.Size = new Size(
                   _viewControl.Width + width,
                   _viewControl.Height + height);

            _resizableTop = false;
            _resizableLeft = false;
            Point location = control.PointToScreen(
                new Point(rect.Left, rect.Bottom));
            Rectangle screen = Screen.FromControl(control).WorkingArea;
            if (center)
            {
                if (location.X + (rect.Width + Size.Width) / 2 > screen.Right)
                {
                    location.X = screen.Right - Size.Width;
                    _resizableLeft = true;
                }
                else
                {
                    location.X -= (Size.Width - rect.Width) / 2;
                }
            }
            else
            {
                if (location.X + Size.Width > (screen.Left + screen.Width))
                {
                    _resizableLeft = true;
                    location.X = (screen.Left + screen.Width) - Size.Width;
                }
            }

            if (location.Y + Size.Height > (screen.Top + screen.Height))
            {
                _resizableTop = true;
                location.Y -= Size.Height + rect.Height;
            }

            location = control.PointToClient(location);
            location.X -= Padding.Right;
            location.Y -= Padding.Top + 1;
            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// 设置弹出层所属项
        /// </summary>
        /// <param name="control"></param>
        internal void SetOwnerItem(Control control)
        {
            if (control == null)
            {
                return;
            }
            if (control is PopupControlHost)
            {
                PopupControlHost popupControl = control as PopupControlHost;
                _ownerPopup = popupControl;
                _ownerPopup._childPopup = this;
                OwnerItem = popupControl.Items[0];
                return;
            }
            if (control.Parent != null)
            {
                SetOwnerItem(control.Parent);
            }
        }

        private void CreateHost(Control control)
        {
            if (control == null)
            {
                throw new ArgumentException("control");
            }

            _viewControl = control;
            _controlHost = new ToolStripControlHost(control, "popupControlHost");
            _controlHost.AutoSize = false;
            _controlHost.Padding = Padding.Empty;
            _controlHost.Margin = Padding.Empty;
            base.Size = new Size(
                control.Size.Width + Padding.Horizontal,
                control.Size.Height + Padding.Vertical);
            base.Items.Add(_controlHost);

            _viewControl.SizeChanged += _targetControl_SizeChanged;
        }

        void _targetControl_SizeChanged(object sender, EventArgs e)
        {
            base.Size = new Size(
                _viewControl.Size.Width + Padding.Horizontal,
                _viewControl.Size.Height + Padding.Vertical);
        }
        private void PopupControlRegionChanged(object sender, EventArgs e)
        {
            UpdateRegion();
        }
        [SecurityPermission(SecurityAction.LinkDemand,
           Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool ProcessGrip(ref Message m)
        {
            if (_canResize && !_changeRegion)
            {
                switch (m.Msg)
                {
                    case (int)WinMsg.WM_NCHITTEST:
                        return OnNcHitTest(ref m);
                    case (int)WinMsg.WM_GETMINMAXINFO:
                        return OnGetMinMaxInfo(ref m);
                }
            }
            return false;
        }

        [SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool OnGetMinMaxInfo(ref Message m)
        {
            Control hostedControl = _viewControl;
            if (hostedControl != null)
            {
                MINMAXINFO minmax =
                    (MINMAXINFO)Marshal.PtrToStructure(
                    m.LParam, typeof(MINMAXINFO));

                if (hostedControl.MaximumSize.Width != 0)
                {
                    minmax.maxTrackSize.Width = hostedControl.MaximumSize.Width;
                }
                if (hostedControl.MaximumSize.Height != 0)
                {
                    minmax.maxTrackSize.Height = hostedControl.MaximumSize.Height;
                }

                minmax.minTrackSize = new Size(100, 100);
                if (hostedControl.MinimumSize.Width > minmax.minTrackSize.Width)
                {
                    minmax.minTrackSize.Width =
                        hostedControl.MinimumSize.Width + Padding.Horizontal;
                }
                if (hostedControl.MinimumSize.Height > minmax.minTrackSize.Height)
                {
                    minmax.minTrackSize.Height =
                        hostedControl.MinimumSize.Height + Padding.Vertical;
                }

                Marshal.StructureToPtr(minmax, m.LParam, false);
            }
            return true;
        }

        private bool OnNcHitTest(ref Message m)
        {
            Point location = PointToClient(new Point(
                UnsafeNativeMethods.LOW_ORDER((int)m.LParam), UnsafeNativeMethods.HIGH_ORDER((int)m.LParam)));
            Rectangle gripRect = Rectangle.Empty;
            if (_canResize && !_changeRegion)
            {
                if (_resizableLeft)
                {
                    if (_resizableTop)
                    {
                        gripRect = new Rectangle(0, 0, 6, 6);
                    }
                    else
                    {
                        gripRect = new Rectangle(
                            0,
                            Height - 6,
                            6,
                            6);
                    }
                }
                else
                {
                    if (_resizableTop)
                    {
                        gripRect = new Rectangle(Width - 6, 0, 6, 6);
                    }
                    else
                    {
                        gripRect = new Rectangle(
                            Width - 6,
                            Height - 6,
                            6,
                            6);
                    }
                }
            }

            if (gripRect.Contains(location))
            {
                if (_resizableLeft)
                {
                    if (_resizableTop)
                    {
                        m.Result = new IntPtr((int)HitTest.HTTOPLEFT);
                        return true;
                    }
                    else
                    {
                        m.Result = new IntPtr((int)HitTest.HTBOTTOMLEFT);
                        return true;
                    }
                }
                else
                {
                    if (_resizableTop)
                    {
                        m.Result = new IntPtr((int)HitTest.HTTOPRIGHT);
                        return true;
                    }
                    else
                    {
                        m.Result = new IntPtr((int)HitTest.HTBOTTOMRIGHT);
                        return true;
                    }
                }
            }
            else
            {
                Rectangle rectClient = ClientRectangle;
                if (location.X > rectClient.Right - 3 &&
                    location.X <= rectClient.Right &&
                    !_resizableLeft)
                {
                    m.Result = new IntPtr((int)HitTest.HTRIGHT);
                    return true;
                }
                else if (location.Y > rectClient.Bottom - 3 &&
                    location.Y <= rectClient.Bottom &&
                    !_resizableTop)
                {
                    m.Result = new IntPtr((int)HitTest.HTBOTTOM);
                    return true;
                }
                else if (location.X > -1 &&
                    location.X < 3 &&
                    _resizableLeft)
                {
                    m.Result = new IntPtr((int)HitTest.HTLEFT);
                    return true;
                }
                else if (location.Y > -1 &&
                    location.Y < 3 &&
                    _resizableTop)
                {
                    m.Result = new IntPtr((int)HitTest.HTTOP);
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}