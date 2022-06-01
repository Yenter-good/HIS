using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ControlLib
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 10:28:45
    /// 描述:
    /// </summary>
    public class SelectColumnsEdit : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var form = new FormSelectColumns();
            var container = context.Instance as Container;
            if (container.Host == null)
                throw new ArgumentException("Host字段为空,请先设置宿主");

            form.Columns = container.Host.Columns;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return new BindColumn() { Column = form.SelectedColumn };

            return base.EditValue(context, provider, value);
        }
    }
}
