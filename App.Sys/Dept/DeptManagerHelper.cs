using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Sys.Dept
{
    internal class DeptManagerHelper
    {
        internal void GetChildIds(List<DeptEntity> allDept, long deptId, ref List<long> childIds)
        {
            var childs = allDept.Where(p => p.Parent.Id == deptId);
            childIds.AddRange(childs.Select(p => p.Id));
            foreach (var child in childs)
                GetChildIds(allDept, child.Id, ref childIds);
        }
    }
}
