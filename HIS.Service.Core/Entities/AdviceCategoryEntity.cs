using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class AdviceCategoryEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 分类名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上级分类
        /// </summary>
        public AdviceCategoryEntity Parent { get; set; }
        /// <summary>
        /// 所属科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 分类类型
        /// </summary>
        public AdviceCategoryType CategoryType { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }
    }

}
