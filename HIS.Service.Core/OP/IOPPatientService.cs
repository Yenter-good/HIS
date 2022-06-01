using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-01 10:03:48
    /// 描述:
    /// </summary>
    public interface IOPPatientService : IServiceSingleton
    {
        /// <summary>
        /// 获取门诊患者列表
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="day">门诊患者有效天数</param>
        /// <returns></returns>
        List<OutpatientEntity> GetOPPatientList(long deptId, int patientEffectiveDay = 0);
    }
}
