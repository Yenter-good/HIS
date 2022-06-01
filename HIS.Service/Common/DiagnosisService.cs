using HIS.Core.Cache;
using HIS.Core.Interceptors;
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
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 15:55:35
    /// 描述:
    /// </summary>
    public class DiagnosisService : IDiagnosisService
    {


        private readonly IIdService _idService;

        public DiagnosisService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 获取诊断
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = CacheKeys.IDiagnosisService_Get, Time = 24*3600)]
        public List<DiagnosisEntity> Get()
        {
            return DBHelper.Instance.HIS.From<View_ICD>().ToList().Mapper<List<DiagnosisEntity>>();
        }
        /// <summary>
        /// 获取诊断
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DiagnosisEntity Get(string code)
        {
            return DBHelper.Instance.HIS.From<View_ICD>().Where(p => p.Code == code).First().Mapper<DiagnosisEntity>();
        }

        /// <summary>
        /// 增加科室诊断
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<DeptDiagnosisEntity> AddDeptDiagnosis(DeptDiagnosisEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();
                var model = entity.Mapper<OP_DiagnosisGroup>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_DiagnosisGroup>(model);

                return DataResult.True<DeptDiagnosisEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<DeptDiagnosisEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除科室诊断
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataResult<DeptDiagnosisEntity> DeleteDeptDiagnosis(string code, string name, long deptId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<OP_DiagnosisGroup>(OP_DiagnosisGroup._.Code == code && OP_DiagnosisGroup._.Name == name && OP_DiagnosisGroup._.DeptId == deptId);
                return DataResult.True<DeptDiagnosisEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DeptDiagnosisEntity>(ex.Message);
            }

        }
    }
}
