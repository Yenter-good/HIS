using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 14:39:04
/// 功能:
/// </summary>
namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 科室实体
    /// </summary>
    public class DeptEntity
    {
        /// <summary>
        /// 科室ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 科室编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 科室别名
        /// </summary>
        public string AliasName { get; set; }
        /// <summary>
        /// 科室位置
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 是否为默认科室
        /// </summary>
        public bool DefaultDept { get; set; }
        /// <summary>
        /// 上级科室
        /// </summary>
        public DeptEntity Parent { get; set; }
        /// <summary>
        /// 科室分类
        /// </summary>
        public ItemEntity Category { get; set; }
        /// <summary>
        /// 科室详细分类
        /// </summary>
        public DeptCategoryDetail CategoryDetail { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 科室状态
        /// </summary>
        public DataStatus DataStatus { get; set; }

    }
    public enum NatureType
    {
        [Description("无")]
        None = 0,
        [Description("药房")]
        Pharmacy = 1,
        [Description("产科")]
        Obstetric = 2,
        [Description("儿科")]
        Pediatric = 3,
        [Description("手术室")]
        SurgeryRoom = 4
    }
}
