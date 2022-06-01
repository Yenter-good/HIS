using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.DSkinControl
{
    public static class MaskExtend
    {
        public static void ShowMask(this Control parent, Action action, string message = "")
        {
            QLoading.Show(parent, message);
            try
            {
                action?.Invoke();
            }
            catch (Exception ex) { throw ex; }
            QLoading.Close(parent);
        }
    }
}
