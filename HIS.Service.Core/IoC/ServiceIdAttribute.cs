using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-06-30 17:37:46
/// 功能:
/// </summary>
namespace HIS.Service.Core
{
    /// <summary>
    /// 服务标识id
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceIdAttribute : Attribute
    {
        public string Id { get; private set; }
        public ServiceIdAttribute(string id)
        {
            this.Id = id;
        }
    }
}
