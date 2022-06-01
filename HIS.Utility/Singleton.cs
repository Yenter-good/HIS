using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-06-30 18:04:45
/// 功能:
/// </summary>
namespace HIS.Utility
{
    public class Singleton<T> where T : class, new()
    {
        private static T _instance;
        private static object locker = new object();
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
