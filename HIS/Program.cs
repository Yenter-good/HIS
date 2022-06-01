using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Utility;

namespace HIS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var wait = new FormWait())
            {

                if (wait.ShowDialog() == DialogResult.OK)
                {
                    using (var login = new FormLogin())
                    {
                        if (login.ShowDialog() == DialogResult.OK)
                            Application.Run(new FormMain());
                    }
                }
            }
        }
    }
}
