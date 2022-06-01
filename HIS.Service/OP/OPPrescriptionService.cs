using HIS.Core;
using HIS.Core.Cache;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
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
    /// 创建时间:2021-02-02 11:39:29
    /// 描述:
    /// </summary>
    public class OPPrescriptionService : IOPPrescriptionService
    {
        private readonly IIdService _idService;

        public OPPrescriptionService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取处方类型
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = CacheKeys.IOPPrescriptionService_GetPrescriptionType)]
        public List<PrescriptionTypeEntity> GetPrescriptionType()
        {
            return DBHelper.Instance.HIS.From<OP_PrescriptionType>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<PrescriptionTypeEntity>>();
        }
        /// <summary>
        /// 获取指定就诊号的处方信息
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <returns></returns>
        public List<PrescriptionEntity> GetPrescription(string outpatientNo)
        {
            var models = DBHelper.Instance.HIS.From<View_Prescription>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.OutpatientNo == outpatientNo).OrderByDescending(p => p.PrescriptionIndex).ToList();
            var prescriptionType = this.GetPrescriptionType();

            List<PrescriptionEntity> result = new List<PrescriptionEntity>();
            foreach (var model in models)
            {
                var entity = model.Mapper<PrescriptionEntity>();
                entity.PrescriptionType = prescriptionType.Find(p => p.Code == model.PrescriptionType);

                result.Add(entity);
            }

            return result;
        }
        /// <summary>
        /// 获取指定处方号的明细
        /// </summary>
        /// <param name="prescriptionId"></param>
        /// <returns></returns>
        public List<PrescriptionDetailEntity> GetPrescriptionDetails(long prescriptionId)
        {
            return DBHelper.Instance.HIS.From<View_PrescriptionDetail>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.PrescriptionId == prescriptionId).OrderBy(p => p.No).ToList().Mapper<List<PrescriptionDetailEntity>>();
        }
        /// <summary>
        /// 判断指定门诊号的病人的处方内,有没有处方绑定了指定的诊断
        /// </summary>
        /// <param name="diagnosisCode"></param>
        /// <returns></returns>
        public bool ExistsPrescriptionByDiagnosis(string outpatientNo, string diagnosisCode)
        {
            return DBHelper.Instance.HIS.Exists<OP_Prescription>(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.OutpatientNo == outpatientNo && p.DiagnosisCode == diagnosisCode);
        }
        /// <summary>
        /// 保存处方明细
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public DataResult SavePrescriptionDetail(PrescriptionEntity prescription, List<PrescriptionDetailEntity> details)
        {
            OP_Prescription prescriptionModel = null;

            DataOperation operation = DataOperation.None;

            if (prescription.Id == null)
            {
                prescription.Id = _idService.CreateUUID();
                prescription.PrescriptionStatus = PrescriptionStatus.Send;

                prescriptionModel = prescription.Mapper<OP_Prescription>();
                prescriptionModel.SetCreationValues();

                prescription.CreationTime = prescriptionModel.CreationTime;

                operation = DataOperation.New;
            }
            else
            {
                operation = DataOperation.Modify;
            }

            details.ForEach(p =>
            {
                p.Id = _idService.CreateUUID();
                p.PrescriptionId = prescription.Id.Value;
            });

            var detailModels = details.Mapper<List<OP_PrescriptionDetail>>();
            detailModels.ForEach(p =>
            {
                p.SetCreationValues();
                p.OutpatientNo = prescription.Outpatient.OutpatientNo;
            });

            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    if (operation == DataOperation.New)
                    {
                        var maxPrescriptionIndex = tran.From<OP_Prescription>().Where(p => p.OutpatientNo == prescription.Outpatient.OutpatientNo).Select(OP_Prescription._.PrescriptionIndex.Max()).ToScalar<int>() + 1;

                        prescriptionModel.PrescriptionIndex = maxPrescriptionIndex;
                        prescription.PrescriptionIndex = maxPrescriptionIndex;

                        tran.Insert(prescriptionModel);
                    }
                    else
                    {
                        var prescriptionModify = AuditionHelper.GetModificationValues<OP_Prescription>();
                        prescriptionModify[OP_Prescription._.DetailNumber] = details.Count;
                        prescriptionModify[OP_Prescription._.DoctorNote] = details.Count;
                        prescriptionModify[OP_Prescription._.ConditionSummary] = details.Count;
                        prescriptionModify[OP_Prescription._.EmergencyFlag] = details.Count;
                        prescriptionModify[OP_Prescription._.HerbalMedicineDose] = details.Count;
                        prescriptionModify[OP_Prescription._.DiagnosisCode] = details.Count;
                        prescriptionModify[OP_Prescription._.PrescriptionStatus] = PrescriptionStatus.Send;

                        prescription.PrescriptionStatus = PrescriptionStatus.Send;

                        tran.Update<OP_Prescription>(prescriptionModify, p => p.Id == prescription.Id);
                    }

                    tran.Delete<OP_PrescriptionDetail>(p => p.PrescriptionId == prescription.Id);
                    tran.Insert(detailModels);

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
        /// 召回处方
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        public DataResult<PrescriptionStatus> UndoPrescription(PrescriptionEntity prescription)
        {
            var status = DBHelper.Instance.HIS.From<OP_Prescription>().Where(p => p.Id == prescription.Id).Select(p => p.PrescriptionStatus).ToScalar<PrescriptionStatus>();

            if (status == PrescriptionStatus.Send)
            {
                var modify = AuditionHelper.GetModificationValues<OP_Prescription>();
                modify[OP_Prescription._.PrescriptionStatus] = PrescriptionStatus.New;

                try
                {
                    DBHelper.Instance.HIS.Update<OP_Prescription>(modify, p => p.Id == prescription.Id);
                    prescription.PrescriptionStatus = PrescriptionStatus.New;

                    return DataResult.True(PrescriptionStatus.New);
                }
                catch
                {
                    return DataResult.Fault<PrescriptionStatus>("召回失败", errorData: status);
                }
            }
            else
                return DataResult.Fault<PrescriptionStatus>("召回失败", errorData: status);
        }
        /// <summary>
        /// 删除处方
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        public DataResult<PrescriptionStatus> DeletePrescription(PrescriptionEntity prescription)
        {
            var status = DBHelper.Instance.HIS.From<OP_Prescription>().Where(p => p.Id == prescription.Id).Select(p => p.PrescriptionStatus).ToScalar<PrescriptionStatus>();

            if (status == PrescriptionStatus.Charge || status == PrescriptionStatus.Void)
                return DataResult.Fault<PrescriptionStatus>("删除失败", errorData: status);
            else
            {
                using (var tran = DBHelper.Instance.HIS.BeginTransaction())
                {
                    try
                    {
                        tran.Delete<OP_Prescription>(p => p.Id == prescription.Id);
                        tran.Delete<OP_PrescriptionDetail>(p => p.PrescriptionId == prescription.Id);

                        tran.Commit();
                        return DataResult.True(status);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return DataResult.Fault<PrescriptionStatus>(ex.Message, errorData: status);
                    }
                }
            }
        }
    }
}
