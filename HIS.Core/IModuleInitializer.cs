using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core
{
    public interface IModuleInitializer
    {
        void OnApplicationStartInitialize(Configuration configuration);
        void OnApplicationStartInitialize();
    }
}
