using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP
{

    internal class OPStationUserControl : UserControl
    {
        public event EventHandler<GetDataEventArgs> GetDataHandler;
        public event EventHandler<RegisterDataEventArgs> RegisterDataHandler;

        internal event EventHandler ShowMeHandler;

        public void RegisterData(RegisterDataType key, Func<object, object> func)
        {
            if (func is null)
                return;
            RegisterDataHandler?.Invoke(this, new RegisterDataEventArgs() { Key = key, Func = func });
        }

        public void ShowMe()
        {
            ShowMeHandler?.Invoke(this, EventArgs.Empty);
        }

        public T GetData<T>(RegisterDataType key, object arg)
        {
            GetDataEventArgs eventArgs = new GetDataEventArgs() { Key = key, Arg = arg };
            GetDataHandler?.Invoke(this, eventArgs);
            if (eventArgs.Value is null)
                return default(T);
            else
            {
                try
                {
                    return (T)eventArgs.Value;
                }
                catch
                {
                    return default(T);
                }
            }
        }

        public int FunctionAreaHeight { get; set; }

        public T GetData<T>(RegisterDataType key)
        {
            return GetData<T>(key, null);
        }
    }
}
