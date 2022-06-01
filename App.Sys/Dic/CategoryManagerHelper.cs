using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Sys.Dic
{
    internal class CategoryManagerHelper
    {
        internal void GetChildIds(List<AdviceCategoryEntity> addCategory, long deptId, ref List<long> childIds)
        {
            var childs = addCategory.Where(p => p.Parent.Id == deptId);
            childIds.AddRange(childs.Select(p => p.Id));
            foreach (var child in childs)
                GetChildIds(addCategory, child.Id, ref childIds);
        }
    }
}
