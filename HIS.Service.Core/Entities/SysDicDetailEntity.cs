using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class SysDicDetailEntity
    {
        /// <summary>
		/// Id
		/// </summary>
		public long Id { get; set; }
        /// <summary>
        /// 所属数据字典代码
        /// </summary>
        public string DicCode { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 源头Id 无源头的默认为等于ID
        /// </summary>
        public long SourceId { get; set; }
        /// <summary>
        /// 是否可扩展  0 否 1 是
        /// </summary>
        public bool Extensibility { get; set; }
        /// <summary>
        /// 是否系统内置编码  0 否 1 是
        /// </summary>
        public bool IsBuiltIn { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 是否允许当做下拉项目时是否可见  1是 0 否
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }

    }
}
