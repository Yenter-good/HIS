using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class DealWithItemEntity
    {
        /// <summary>
        /// 项目编码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { set; get; }
        /// <summary>
        /// 包装单位
        /// </summary>
        public string PackageUnit { set; get; }
        /// <summary>
        /// 执行科室
        /// </summary>
        public DeptEntity ExecDept { set; get; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { set; get; }

        public string SearchCode { set; get; }
        public string WubiCode { set; get; }
        /// <summary>
        /// 项目类型
        /// </summary>
        public ItemType ItemType { get; set; }
    }
}
