using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class PrescriptionGroupDetailEntity : DrugInventoryEntity
    {
        public long Id { set; get; }
        /// <summary>
        /// 药典编码 非药品时不填
        /// </summary>
        public string DrugCode { set; get; }
        /// <summary>
        /// 药品、诊疗、材料 等项目的唯一编码
        /// </summary>
        public string ItemCode { set; get; }
        /// <summary>
        /// 项目类型  取自 枚举GroupDetailType
        /// </summary>
        public int ItemType { set; get; }
        /// <summary>
        /// 套餐ID
        /// </summary>
        public long GroupId { set; get; }
        /// <summary>
        /// 一次用量
        /// </summary>
        public float Dose { set; get; }
        /// <summary>
        /// 用法
        /// </summary>
        public string Usage { set; get; }
        /// <summary>
        /// 用法名称
        /// </summary>
        public string UsageName { set; get; }
        
        /// <summary>
        /// 间隔
        /// </summary>
        public string Interval { set; get; }
        /// <summary>
        /// 间隔名称
        /// </summary>
        public string IntervalName { set; get; }
        /// <summary>
        /// 同组编号
        /// </summary>
        public int GroupNo { set; get; }
        /// <summary>
        /// 执行科室
        /// </summary>
        public string ExecDeptCode { set; get; }

    }
}
