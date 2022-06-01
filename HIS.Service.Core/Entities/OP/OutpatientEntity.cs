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
    /// 创建时间:2021-01-28 15:10:19
    /// 描述:
    /// </summary>
    public class OutpatientEntity
    {
        /// <summary>
        /// 门诊号
        /// </summary>
        public string OutpatientNo { get; set; }
        /// <summary>
        /// 挂号时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 就诊状态
        /// </summary>
        public OutpatientStatus Status { get; set; }
        /// <summary>
        /// 收费状态
        /// </summary>
        public bool ChargeFlag { get; set; }
        /// <summary>
        /// 病人姓名
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
        /// 挂号科室
        /// </summary>
        public DeptEntity Dept { get; set; }
        /// <summary>
        /// 挂号医生
        /// </summary>
        public UserEntity Doctor { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 号别分类(专家号、普通号、急诊号)
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 急诊标识
        /// </summary>
        public bool EmerencyFlag { get; set; }
        /// <summary>
        /// 付费类型
        /// </summary>
        public PayType PayType { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 首诊医生
        /// </summary>
        public UserEntity FirstAcceptDoctor { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }
        /// <summary>
        /// 医保卡
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 初复诊
        /// 0初诊 1复诊
        /// </summary>
        public int FirstOrSecond { get; set; }
    }
}
