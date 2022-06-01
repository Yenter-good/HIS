using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class UsageEntity
    {

        public long Id { get; set; }
        /// <summary>
        /// 用法编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 用法名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 用法检索码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 用法五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 启用标识
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public UsageType Category { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 是否是默认的
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
