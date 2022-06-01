using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;

namespace HIS.Service.Core
{
    public interface IEmpiPatientService : IServiceSingleton
    {
        /// <summary>
        /// 根据条件查询患者信息
        /// </summary>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        List<PatientEntity> GetBySearchStr(string searchStr);
        /// <summary>
        /// 新增患者（注册）
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        DataResult<PatientEntity> AddPatient(PatientEntity entity);

        /// <summary>
        /// 修改患者信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<PatientEntity> UpdatePatient(long entityId,PatientEntity entity);


    }
}
