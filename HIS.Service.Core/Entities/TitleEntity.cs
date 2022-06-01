using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class TitleEntity
    {
        /// <summary>
        /// 职称Id
        /// </summary>
        public long? TitleId { get; set; }
        /// <summary>
        /// 职称名称
        /// </summary>
        public string TitleName { get; set; }
        /// <summary>
        /// 职称等级
        /// </summary>
        public int? TitleLevel { get; set; }
        /// <summary>
        /// 职称范畴
        /// </summary>
        public Scope Scope { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }
    }

    public enum Scope
    {
        Doctor = 1,
        Nurse = 2,
        Other = 9
    }
}
