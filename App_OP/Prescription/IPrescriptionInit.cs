using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_OP.Prescription
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-03-01 10:26:14
    /// 描述:
    /// </summary>
    internal interface IPrescriptionInit
    {
        /// <summary>
        /// 当前患者
        /// </summary>
        OutpatientEntity Outpatient { get; set; }
        /// <summary>
        /// 当前科室
        /// </summary>
        DeptEntity Dept { get; set; }
        /// <summary>
        /// 当前主诊断
        /// </summary>
        PatientDiagnosisEntity MainDiagnosis { get; set; }
        /// <summary>
        /// 诊断变更
        /// </summary>
        void DiagnosisChanged(List<PatientDiagnosisEntity> diagnosis);
        /// <summary>
        /// 初始化数据
        /// </summary>
        void InitData();
        /// <summary>
        /// 初始化药房
        /// </summary>
        /// <param name="execDepts"></param>
        bool InitPharmacy(List<DeptEntity> execDepts);
        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="prescriptionTypes"></param>
        void InitUI(List<PrescriptionTypeEntity> prescriptionTypes);
        /// <summary>
        /// 初始化默认处方
        /// </summary>
        void InitNormalPresciption();
        /// <summary>
        /// 清空处方
        /// </summary>
        void ClearAll();
        /// <summary>
        /// 是否开启新增按钮
        /// </summary>
        /// <param name="enable"></param>
        void EnableNewPrescription(bool enable);
        /// <summary>
        /// 是否开启功能按钮
        /// </summary>
        /// <param name="enable"></param>
        void EnableButton(bool enable);

        event EventHandler<PrescriptionSubmitEventArgs> Submit;
    }
}
