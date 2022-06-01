using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 费用类型实体
    /// </summary>
    public class FeeTypeEntity
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 费用类型编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 费用类型名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
    }
}
