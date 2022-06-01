using DCSoft.Writer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ControlLib
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-20 10:26:59
    /// 描述:
    /// </summary>
    public class CWrite : DCSoft.Writer.Controls.WriterControl
    {
        public CWrite()
        {
            this.RegisterCode = "02324EA500000000000027000000E6B7B1E59CB3E4B99DE6988EE78FA0E4BFA1E681AFE7A791E68A80E69C89E99990E585ACE58FB88AAF15000000E4B99DE6988EE78FA0454D52E7BC96E8BE91E599A80400";
            this.DocumentOptions.BehaviorOptions.MaximizedPrintPreviewDialog = true;
        }
        /// <summary>
        /// 对话框模式文件存储为XML
        /// </summary>
        public void DialogFileSaveToXml()
        {
            this.ExecuteCommand(StandardCommandNames.FileSaveAs, true, null);
        }
        /// <summary>
        /// 安全运行
        /// </summary>
        /// <param name="action"></param>
        public void SafeOperation(Action action)
        {
            try
            {
                this.FormView = DCSoft.Writer.Controls.FormViewMode.Disable;
                action?.Invoke();
            }
            finally
            {
                this.FormView = DCSoft.Writer.Controls.FormViewMode.Strict;
            }
        }
        /// <summary>
        /// 打印预览
        /// </summary>
        public virtual void Preview()
        {
            this.ExecuteCommand("FilePrintPreview", true, null);
        }
        /// <summary>
        /// 打印
        /// </summary>
        public virtual void Print(Func<bool> afterPrintFunc = null)
        {
            if (afterPrintFunc != null)
            {
                if (!afterPrintFunc.Invoke())
                {
                    return;
                }
            }
            this.ExecuteCommand("FilePrint", false, null);
        }
    }
}
