using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS.Utility.Win32
{
    /// <summary>
    /// 剪切版监听
    /// </summary>
    public class ClipboardMonitor : NativeWindow
    {
        IntPtr _nextClipboardViewer;//用于监听剪切板通知
        Action _onClipboardDataChanged;
        static System.Collections.Concurrent.ConcurrentDictionary<IntPtr, IntPtr> _monitorList = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, IntPtr>();
        /// <summary>
        /// 监听剪切版通知
        /// </summary>
        /// <param name="owner">监听的宿主</param>
        /// <param name="onClipboardDataChanged">剪切版内容数据发生变更时触发方法</param>
        private ClipboardMonitor(Control owner, Action onClipboardDataChanged)
        {
            this.AssignHandle(owner.Handle);
            _onClipboardDataChanged = onClipboardDataChanged;
        }
        /// <summary>
        /// 监听剪切版通知
        /// </summary>
        /// <param name="owner">监听的宿主</param>
        /// <param name="onClipboardDataChanged">剪切版内容数据发生变更时触发方法</param>
        public static void Monitor(Control owner, Action onClipboardDataChanged)
        {
            if (owner == null) return;
            if (owner.IsDisposed) return;
            if (_monitorList.ContainsKey(owner.Handle))
            {
                if (onClipboardDataChanged == null)
                {
                    try
                    {
                        UnsafeNativeMethods.ChangeClipboardChain(owner.Handle, _monitorList[owner.Handle]);
                    }
                    catch { }
                }
                return;
            }
            new ClipboardMonitor(owner, onClipboardDataChanged);
        }
        protected override void OnHandleChange()
        {
            base.OnHandleChange();
            _nextClipboardViewer = UnsafeNativeMethods.SetClipboardViewer(Handle);
            _monitorList[Handle] = _nextClipboardViewer;
        }
        public override void ReleaseHandle()
        {
            base.ReleaseHandle();
            UnsafeNativeMethods.ChangeClipboardChain(Handle, _nextClipboardViewer);
            IntPtr intPtr;
            _monitorList.TryRemove(Handle, out intPtr); ;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                #region 监听剪切板
                case (int)WinMsg.WM_DRAWCLIPBOARD:
                    if (this._onClipboardDataChanged != null)
                        this._onClipboardDataChanged();
                    UnsafeNativeMethods.SendMessage(_nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case (int)HIS.Utility.Win32.WinMsg.WM_CHANGECBCHAIN:
                    if (m.WParam == _nextClipboardViewer)
                        _nextClipboardViewer = m.LParam;
                    else
                        HIS.Utility.Win32.UnsafeNativeMethods.SendMessage(_nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                #endregion

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}
