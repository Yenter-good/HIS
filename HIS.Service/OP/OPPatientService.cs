using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-01 10:05:59
    /// 描述:
    /// </summary>
    public class OPPatientService : IOPPatientService
    {
        /// <summary>
        /// 获取门诊患者列表
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="day">门诊患者有效天数</param>
        /// <returns></returns>
        public List<OutpatientEntity> GetOPPatientList(long deptId, int patientEffectiveDay = 0)
        {
            return DBHelper.Instance.HIS.From<IView_HIS_Outpatients>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id 
                    && d.DeptId == deptId && d.RegisterTime >= DateTime.Parse(DateTime.Now.AddDays(-patientEffectiveDay).ToYMD()))
                .OrderBy(d => d.OrderNumber)
                .ToList()
                .Mapper<List<OutpatientEntity>>();
        }
    }
}
