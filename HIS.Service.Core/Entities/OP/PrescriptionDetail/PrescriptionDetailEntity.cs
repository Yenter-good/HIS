using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-02 15:42:14
    /// 描述:
    /// </summary>
    public class PrescriptionDetailEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 处方ID
        /// </summary>
        public long PrescriptionId { get; set; }
        /// <summary>
        /// 项目类型
        /// </summary>
        public ItemType ItemType { get; set; }
        /// <summary>
        /// 药典编码
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 规格编码
        /// </summary>
        public string SpecificationCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 规格名称
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 同组号
        /// </summary>
        public int GroupNo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 数量单位
        /// </summary>
        public string PackageUnit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 用法
        /// </summary>
        public UsageEntity Usage { get; set; }
        /// <summary>
        /// 间隔
        /// </summary>
        public IntervalEntity Interval { get; set; }
        /// <summary>
        /// 皮试标识
        /// </summary>
        public SkinTestFlag SkinTestFlag { get; set; }
        /// <summary>
        /// 执行科室
        /// </summary>
        public DeptEntity ExecDept { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// 一次用量
        /// </summary>
        public float Dose { get; set; }
        /// <summary>
        /// 一次用量单位
        /// </summary>
        public string DoseUnit { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 是否大包装
        /// </summary>
        public bool BigPackageFlag { get; set; }
        /// <summary>
        /// 是否自定义价格
        /// </summary>
        public bool CustomPriceFlag { get; set; }
    }
}
