using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 角色实体类
    /// </summary>
    public class RoleEntity
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is RoleEntity role)
            {
                if (role.Id == this.Id)
                    return true;
                return false;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
