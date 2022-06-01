using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;

namespace HIS.Service
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-28 11:07:03
    /// 描述:
    /// </summary>
    public class OPPatientDiagnosisService : IOPPatientDiagnosisService
    {
        private readonly IIdService _idService;

        public OPPatientDiagnosisService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取指定门诊号的诊断
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <returns></returns>
        public List<PatientDiagnosisEntity> Get(string outpatientNo)
        {
            var entities = DBHelper.Instance.HIS.From<OP_PatientDiagnosis>().OrderBy(OP_PatientDiagnosis._.Type, OP_PatientDiagnosis._.No).Where(p => p.OutpatientNo == outpatientNo).ToList().Mapper<List<PatientDiagnosisEntity>>();
            var users = DBHelper.Instance.HIS.From<Sys_User>().Where(p => p.Id.In(entities.Select(d => d.CreatorUser.Id).Distinct().ToList())).Select(Sys_User._.Name, Sys_User._.Id).ToList();

            foreach (var model in entities)
                model.CreatorUser.Name = users.Find(p => p.Id == model.CreatorUser.Id)?.Name;

            return entities;
        }
        /// <summary>
        /// 更新主诊断标识
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataResult UpdateMainFlag(long Id, string outpatientNo)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    var modify = AuditionHelper.GetModificationValues<OP_PatientDiagnosis>();
                    modify[OP_PatientDiagnosis._.MainFlag] = false;

                    tran.Update<OP_PatientDiagnosis>(modify, p => p.OutpatientNo == outpatientNo);
                    modify[OP_PatientDiagnosis._.MainFlag] = true;
                    tran.Update<OP_PatientDiagnosis>(modify, p => p.Id == Id);

                    tran.Commit();
                    return DataResult.True();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    return DataResult.Fault(ex.Message);
                }
            }
        }
        /// <summary>
        /// 更新确诊标识
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public DataResult UpdateConfirmFlag(long Id, bool value)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_PatientDiagnosis>();

                modify[OP_PatientDiagnosis._.ConfirmFlag] = value;

                DBHelper.Instance.HIS.Update<OP_PatientDiagnosis>(modify, p => p.Id == Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新前缀
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public DataResult UpdatePrefix(long Id, string value)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_PatientDiagnosis>();

                modify[OP_PatientDiagnosis._.Prefix] = value;

                DBHelper.Instance.HIS.Update<OP_PatientDiagnosis>(modify, p => p.Id == Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新后缀
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public DataResult UpdatePostfix(long Id, string value)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_PatientDiagnosis>();

                modify[OP_PatientDiagnosis._.Postfix] = value;

                DBHelper.Instance.HIS.Update<OP_PatientDiagnosis>(modify, p => p.Id == Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取指定科室的常用诊断
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DiagnosisEntity> GetDiagnosisGroup(long deptId)
        {
            return DBHelper.Instance.HIS.From<View_DiagnosisGroup>().Where(p => p.DeptId == deptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<DiagnosisEntity>>();
        }
        /// <summary>
        /// 增加诊断
        /// </summary>
        /// <param name="diagnosisEntity"></param>
        /// <returns></returns>
        public DataResult<long> AddDiagnosis(PatientDiagnosisEntity diagnosisEntity, string outpatientNo, long deptId)
        {
            try
            {
                //如果当前病人已经有主诊断了,并且当前待添加的诊断也是主诊断,则将当前诊断设为非主诊断
                var count = DBHelper.Instance.HIS.Count<OP_PatientDiagnosis>(p => p.OutpatientNo == outpatientNo && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.MainFlag == true);

                OP_PatientDiagnosis model = diagnosisEntity.Mapper<OP_PatientDiagnosis>().SetCreationValues();
                model.Id = _idService.CreateUUID();
                model.OutpatientNo = outpatientNo;
                model.DeptId = deptId;
                model.No = DBHelper.Instance.HIS.From<OP_PatientDiagnosis>().Where(p => p.OutpatientNo == outpatientNo).Select(OP_PatientDiagnosis._.No.Max()).ToScalar<int>() + 1;

                if (count > 0 && model.MainFlag)
                {
                    model.MainFlag = false;
                    diagnosisEntity.MainFlag = false;
                }

                DBHelper.Instance.HIS.Insert(model);
                return DataResult.True(model.Id);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<long>(ex.Message);
            }
        }
        /// <summary>
        /// 修改诊断
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="diagnosisEntity"></param>
        /// <returns></returns>
        public DataResult UpdateDiagnosis(long Id, DiagnosisEntity diagnosisEntity)
        {
            try
            {
                var modify = AuditionHelper.GetModificationValues<OP_PatientDiagnosis>();
                modify[OP_PatientDiagnosis._.Code] = diagnosisEntity.Code;
                modify[OP_PatientDiagnosis._.Name] = diagnosisEntity.Name;
                modify[OP_PatientDiagnosis._.Type] = diagnosisEntity.Type;

                DBHelper.Instance.HIS.Update<OP_PatientDiagnosis>(modify, p => p.Id == Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除诊断
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataResult DeleteDiagnosis(long Id)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<OP_PatientDiagnosis>(p => p.Id == Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
