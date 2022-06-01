using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class ModuleInitailizer : IModuleInitializer
    {
        public void OnApplicationStartInitialize(Configuration configuration)
        {
            DBHelper.Instance.RegisterConn(true, configuration);
        }
        public void OnApplicationStartInitialize()
        {
            ServiceLocator.GetService<IDiagnosisService>().Get();

            DCSoft.Writer.WriterAppHost.PreloadSystem();
        }
    }
}
