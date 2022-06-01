using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 流水号实体类
    /// </summary>
    public class SerialNumberEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 前缀
        /// </summary>
        public string StartPrefix { get; set; }
        /// <summary>
        /// 中间格式
        /// </summary>
        public MiddleFormat MiddleFormat { get; set; }
        /// <summary>
        /// 总长度
        /// </summary>
        public int TotalLength { get; set; }
        /// <summary>
        /// 变化类型
        /// </summary>
        public ChangeType ChangeType { get; set; }
        /// <summary>
        /// 流水号类型
        /// </summary>
        public InvoiceType Type { get; set; }
        /// <summary>
        /// 缓存标识
        /// </summary>
        public bool CacheFlag { get; set; }
    }
}
