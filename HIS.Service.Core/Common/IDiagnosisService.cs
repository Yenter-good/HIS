using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 15:52:58
    /// 描述:
    /// </summary>
    public interface IDiagnosisService : IServiceSingleton
    {
        List<DiagnosisEntity> Get();
        DiagnosisEntity Get(string code);
        /// <summary>
        /// 增加科室诊断
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<DeptDiagnosisEntity> AddDeptDiagnosis(DeptDiagnosisEntity entity);
        /// <summary>
        /// 删除科室诊断
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<DeptDiagnosisEntity> DeleteDeptDiagnosis(string code , string name , long deptId);



    }

    
}
