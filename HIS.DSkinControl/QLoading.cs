using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HIS.DSkinControl
{
    [ToolboxItem(false)]
    public partial class QLoading : DSkin.Controls.DSkinUserControl
    {
        private static Hashtable hashtable = Hashtable.Synchronized(new Hashtable());
        private QLayerControl layer;
        private QLoading()
        {
            InitializeComponent();
        }

        internal bool InnerShow(Control parent)
        {
            if (hashtable.ContainsKey(parent)) return false;
            parent.Disposed += Parent_Disposed;
            hashtable[parent] = this;

            if (layer == null || layer.IsDisposed)
            {
                layer = new QLayerControl();
            }
            layer.ParentContainer = parent;
            layer.AttachControl = this;
            layer.ShowLayer();
            Application.DoEvents();
            return true;
        }
        internal void InnerClose()
        {
            if (layer != null && !layer.IsDisposed)
            {
                layer.CloseLayer();
                layer.Dispose();
                layer = null;
            }
            this.Dispose();
        }
        private void Parent_Disposed(object sender, EventArgs e)
        {
            this.InnerClose();
            hashtable.Remove(sender as Control);
            (sender as Control).Disposed -= Parent_Disposed;
        }
        /// <summary>
        /// 显示加载
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static bool Show(Control parent, string message = "")
        {
            var loading = new QLoading();
            if (message != "")
                loading.dSkinLabel1.Text = message;
            return loading.InnerShow(parent);
        }
        /// <summary>
        /// 关闭加载
        /// </summary>
        /// <param name="parent"></param>
        public static void Close(Control parent)
        {
            if (parent.InvokeRequired)
            {
                parent.Invoke((MethodInvoker)delegate { Close(parent); });
                return;
            }
            if (hashtable.ContainsKey(parent))
            {
                var loading = hashtable[parent] as QLoading;
                if (loading != null && !loading.IsDisposed)
                {
                    loading.InnerClose();
                    loading = null;
                }
                hashtable.Remove(parent);
            }
            Application.DoEvents();
        }
        /// <summary>
        /// 加载处理
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="work"></param>
        public static void Processing(Control parent, Action work)
        {
            if (work == null) return;
            if (!Show(parent)) return;
            new System.Threading.Tasks.Task(() =>
            {
                try
                {
                    work();
                }
                finally
                {
                    Close(parent);
                }
            }).Start();


        }
        /// <summary>
        /// 加载处理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parent"></param>
        /// <param name="work"></param>
        /// <param name="args"></param>
        public static void Processing<T>(Control parent, Action<T> work, T args)
        {
            if (work == null) return;
            Processing(parent, () => { work(args); });
        }
    }
}
