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
    /// 创建时间:2021-02-02 14:42:21
    /// 描述:
    /// </summary>
    public class PrescriptionEntity
    {
        /// <summary>
        /// 处方ID
        /// </summary>
        public long? Id { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public UserEntity Creator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 处方类型
        /// </summary>
        public PrescriptionTypeEntity PrescriptionType { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 就诊病人
        /// </summary>
        public OutpatientEntity Outpatient { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 明细记录数
        /// </summary>
        public int DetailNumber { get; set; }
        /// <summary>
        /// 医生说明
        /// </summary>
        public string DoctorNote { get; set; }
        /// <summary>
        /// 病史摘要
        /// </summary>
        public string ConditionSummary { get; set; }
        /// <summary>
        /// 下处方科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 处方状态
        /// </summary>
        public PrescriptionStatus PrescriptionStatus { get; set; }
        /// <summary>
        /// 加急标志
        /// </summary>
        public bool EmergencyFlag { get; set; }
        /// <summary>
        /// 草药剂数
        /// </summary>
        public int HerbalMedicineDose { get; set; }
        /// <summary>
        /// 草药用法
        /// </summary>
        public UsageEntity HerbalMedicineUsage { get; set; }
        /// <summary>
        /// 处方对应的诊断
        /// </summary>
        public DiagnosisEntity Diagnosis { get; set; }
        /// <summary>
        /// 处方索引
        /// </summary>
        public int PrescriptionIndex { get; set; }
    }
}
