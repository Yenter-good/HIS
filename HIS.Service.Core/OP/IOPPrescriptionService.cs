using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-02 11:26:06
    /// 描述:
    /// </summary>
    public interface IOPPrescriptionService
    {
        /// <summary>
        /// 获取处方类型
        /// </summary>
        /// <returns></returns>
        List<PrescriptionTypeEntity> GetPrescriptionType();
        /// <summary>
        /// 获取指定就诊号的处方信息
        /// </summary>
        /// <param name="outpatientNo"></param>
        /// <returns></returns>
        List<PrescriptionEntity> GetPrescription(string outpatientNo);
        /// <summary>
        /// 获取指定处方号的明细
        /// </summary>
        /// <param name="prescriptionId"></param>
        /// <returns></returns>
        List<PrescriptionDetailEntity> GetPrescriptionDetails(long prescriptionId);
        /// <summary>
        /// 判断指定门诊号的病人的处方内,有没有处方绑定了指定的诊断
        /// </summary>
        /// <param name="diagnosisCode"></param>
        /// <returns></returns>
        bool ExistsPrescriptionByDiagnosis(string outpatientNo, string diagnosisCode);
        /// <summary>
        /// 保存处方明细
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        DataResult SavePrescriptionDetail(PrescriptionEntity prescription, List<PrescriptionDetailEntity> details);
        /// <summary>
        /// 召回处方
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        DataResult<PrescriptionStatus> UndoPrescription(PrescriptionEntity prescription);
        /// <summary>
        /// 删除处方
        /// </summary>
        /// <param name="prescription"></param>
        /// <returns></returns>
        DataResult<PrescriptionStatus> DeletePrescription(PrescriptionEntity prescription);
    }
}
