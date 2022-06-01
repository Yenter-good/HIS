using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utility
{
    public class AutoMapperHelper : Singleton<AutoMapperHelper>
    {
        private bool _alreadyConfig = false;

        public IMapper Mapper { get; private set; }

        public void Configuration()
        {
            if (_alreadyConfig)
                return;

            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly).Concat(
               Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.exe", SearchOption.TopDirectoryOnly))
               .Where(f =>
               {
                   string name = System.IO.Path.GetFileNameWithoutExtension(f);
                   return name.StartsWith("HIS.") || name=="HIS";
               }).ToArray();

            var assemblies = files.Select(Assembly.LoadFrom).Distinct();

            var config = new MapperConfiguration(cfg => cfg.AddMaps(assemblies));
            Mapper = config.CreateMapper();
            _alreadyConfig = true;
        }
    }
}
