using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-03-01 09:50:02
    /// 描述:
    /// </summary>
    public class TemplateSampleEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 父节点Id
        /// </summary>
        public long ParentId { get; set; }
        /// <summary>
        /// 节点类型
        /// </summary>
        public NodeType NodeType { get; set; }
        /// <summary>
        /// 节点等级
        /// </summary>
        public Level Level { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 拥有者ID
        /// </summary>
        public long OwnerId { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
    }
}
