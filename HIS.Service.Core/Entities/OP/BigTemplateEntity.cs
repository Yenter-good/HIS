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
    /// 创建时间:2021-02-07 19:02:23
    /// 描述:
    /// </summary>
    [Serializable]
    public class BigTemplateEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 科室Id
        /// </summary>
        public long DeptId { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 0 初诊模板 
        /// 1 复诊模板
        /// </summary>
        public BigTemplateType TemplateType { get; set; }
        /// <summary>
        /// 生效标识
        /// </summary>
        public bool EffectiveFlag { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        public int No { get; set; }
    }
}
