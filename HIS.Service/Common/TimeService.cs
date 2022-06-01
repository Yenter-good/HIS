using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class TimeService : ITimeService
    {
        public DateTime ServiceTime()
        {
            return DBHelper.Instance.ServerTime;
        }
    }
}
