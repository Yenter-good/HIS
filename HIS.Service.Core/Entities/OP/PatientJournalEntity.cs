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
    /// 创建时间:2021-02-02 14:52:03
    /// 描述:
    /// </summary>
    public class PatientJournalEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 首诊医生
        /// </summary>
        public UserEntity FirstAcceptDoctor { get; set; }
        /// <summary>
        /// 就诊时间
        /// </summary>
        public DateTime? TreatmentTime { get; set; }
        /// <summary>
        /// 就诊号
        /// </summary>
        public string OutpatientNo { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 医生
        /// </summary>
        public UserEntity Doctor { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 住址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public int? Stature { get; set; }
        /// <summary>
        /// 出生地
        /// </summary>
        public string BirthPlace { get; set; }
        /// <summary>
        /// 血型
        /// </summary>
        public LongItem Blood { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public int? Wight { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public LongItem Marry { get; set; }
        /// <summary>
        /// 国籍
        /// </summary>
        public LongItem Nationality { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Origin { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public LongItem Nation { get; set; }
        /// <summary>
        /// 文化程度
        /// </summary>
        public LongItem Knowlage { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactsPhone { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactsName { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        public LongItem Job { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        public string JobAddress { get; set; }
        /// <summary>
        /// 单位电话
        /// </summary>
        public string JobPhone { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 复诊还是初诊 0初诊 1复诊
        /// </summary>
        public int? FirstOrSecond { get; set; }
        /// <summary>
        /// 是否传染病 0否 1是
        /// </summary>
        public bool InfectionFlag { get; set; }
        /// <summary>
        /// 血压 高压
        /// </summary>
        public int? BloodPressureHigh { get; set; }
        /// <summary>
        /// 血压 低压
        /// </summary>
        public int? BloodPressureLow { get; set; }
        /// <summary>
        /// 发病日期
        /// </summary>
        public DateTime? OnsetDate { get; set; }
        /// <summary>
        /// 是否为有效的日志 0否 1是
        /// </summary>
        public bool EffectiveFlag { get; set; }
    }
}
