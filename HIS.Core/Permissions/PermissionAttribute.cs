using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core
{
    public class PermissionAttribute : Attribute
    {
        public string Name { get; set; }
        public string ParentName { get; set; }

        public PermissionAttribute(string name, string parentName)
        {
            this.Name = name;
            this.ParentName = parentName;
        }
    }
}
