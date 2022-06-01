using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 系统参数实体
    /// </summary>
    public class SysParameterEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 参数编码
        /// </summary>
        public string ParameterCode { get; set; }
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParameterName { get; set; }
        /// <summary>
        /// 参数值
        /// </summary>
        public string ParameterValue { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 检索编码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
    }
}
