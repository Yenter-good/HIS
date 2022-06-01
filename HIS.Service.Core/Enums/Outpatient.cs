using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 15:11:29
    /// 描述:
    /// </summary>
    public enum OutpatientStatus
    {
        /// <summary>
        /// 待就诊
        /// </summary>
        [Description("待就诊")]
        Idle,
        /// <summary>
        /// 就诊中
        /// </summary>
        [Description("就诊中")]
        Process,
        /// <summary>
        /// 就诊结束
        /// </summary>
        [Description("就诊结束")]
        Finish,
    }

    public enum Gender
    {
        [Description("男")]
        Man = 1,
        [Description("女")]
        Woman = 2,
        [Description("其他")]
        Other = 9
    }

    public enum PayType
    {
        /// <summary>
        /// 自费
        /// </summary>
        [Description("自费")]
        Self,
        /// <summary>
        /// 医保
        /// </summary>
        [Description("医保")]
        MedicalInsurance
    }
    /// <summary>
    /// 大模板类型
    /// </summary>
    public enum BigTemplateType
    {
        /// <summary>
        /// 初诊模板
        /// </summary>
        [Description("初诊模板")]
        FirstVisit = 0,
        /// <summary>
        /// 复诊模板
        /// </summary>
        [Description("复诊模板")]
        FollowUpVisit = 1,
    }
}
