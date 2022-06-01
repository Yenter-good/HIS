using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.OP
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-02 14:47:06
    /// 描述:
    /// </summary>
    public class OPJournalService : IOPJournalService
    {
        private IIdService _idService;
        public OPJournalService(IIdService idService)
        {
            _idService = idService;
        }
        /// <summary>
        /// 添加门诊日志
        /// </summary>
        /// <param name="patientJournalEntity"></param>
        /// <returns></returns>
        public DataResult AddJournal(OutpatientEntity outpatientEntity)
        {
            try
            {
                if (!this.JournalExists(outpatientEntity.OutpatientNo))
                {
                    OP_Journal ormJournal = new OP_Journal();
                    ormJournal.SetCreationValues();
                    ormJournal.Id = this._idService.CreateUUID();//ID
                    ormJournal.OutpatientNo = outpatientEntity.OutpatientNo;//门诊号
                    ormJournal.PatientName = outpatientEntity.PatientName;//患者姓名
                    ormJournal.Gender = (int)outpatientEntity.Gender;//患者性别
                    ormJournal.Age = outpatientEntity.Age;//患者年龄
                    ormJournal.Birthday = outpatientEntity.Birthday;//患者出生日期
                    ormJournal.IDCard = outpatientEntity.IDCard;//身份证号
                    ormJournal.CardNo = outpatientEntity.CardNo;//医保卡号
                    ormJournal.Address = outpatientEntity.Address;//本人住址
                    ormJournal.Phone = outpatientEntity.Phone;//本人联系电话
                    ormJournal.No = 0;//排序值
                    ormJournal.FirstOrSecond = 0;//默认为初诊
                    if (!string.IsNullOrWhiteSpace(outpatientEntity.IDCard))//身份证号存在，则去查询
                    {
                        string sql = @"select 1 from OP_Journal where HosId=@HosId and IDCard=@IDCard and DeptId=@DeptId and DataStatus=1 and EffectiveFlag=1
union  select 1 from OP_JournalHistory where HosId=@HosId and IDCard=@IDCard and DeptId=@DeptId and DataStatus=1 and EffectiveFlag=1;";
                        bool exists = DBHelper.Instance.HIS.FromSql(sql)
                              .AddInParameter("@HosId", DbType.Int64, ormJournal.HosId)
                              .AddInParameter("@IDCard", DbType.String, ormJournal.IDCard)
                              .AddInParameter("@DeptId", DbType.Int64, ormJournal.DeptId)
                              .ToScalar<int>() > 0;
                        if (exists)
                            ormJournal.FirstOrSecond = 1;
                    }
                    DBHelper.Instance.HIS.Insert<OP_Journal>(ormJournal);
                }
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 根据门诊号判断门诊日志是否存在
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        public bool JournalExists(string outPatientNo)
        {
            return DBHelper.Instance.HIS.Exists<OP_Journal>(d => d.OutpatientNo == outPatientNo
                     && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable);

        }
        /// <summary>
        /// 根据门诊号判断门诊日志是否有效
        /// </summary>
        /// <param name="outPatientNo"></param>
        /// <returns></returns>
        public bool JournalEffective(string outPatientNo)
        {
            return DBHelper.Instance.HIS.From<OP_Journal>().Where(d => d.OutpatientNo == outPatientNo
                    && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable)
                    .Select(OP_Journal._.EffectiveFlag)
                    .ToScalar<bool>();
        }
        /// <summary>
        /// 根据门诊号获取门诊日志
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        public PatientJournalEntity GetJournal(string outPatientNo)
        {
            return DBHelper.Instance.HIS.From<OP_Journal>()
                 .Where(d => d.OutpatientNo == outPatientNo && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable)
                 .First()
                 .Mapper<PatientJournalEntity>();
        }
        /// <summary>
        /// 更新门诊日志
        /// </summary>
        /// <param name="outpatientEntity"></param>
        /// <returns></returns>
        public DataResult UpdateJournal(PatientJournalEntity patientJournalEntity)
        {

            DateTime serverTime = DBHelper.Instance.ServerTime;
            patientJournalEntity.TreatmentTime = serverTime;

            OP_Journal journal = DBHelper.Instance.HIS.From<OP_Journal>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                    && d.DataStatus == (int)DataStatus.Enable && d.OutpatientNo == patientJournalEntity.OutpatientNo)
                    .Select(OP_Journal._.FirstAcceptDoctorId, OP_Journal._.TreatmentTime)
                    .First();

            if (journal != null)
            {
                if (journal.TreatmentTime != null)
                    patientJournalEntity.TreatmentTime = journal.TreatmentTime;

                if (journal.FirstAcceptDoctorId != null)
                {
                    Sys_User user = DBHelper.Instance.HIS.From<Sys_User>()
                        .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Id == journal.FirstAcceptDoctorId.Value)
                        .Select(Sys_User._.Id, Sys_User._.Code, Sys_User._.Name)
                        .First();
                    patientJournalEntity.FirstAcceptDoctor.Id = user.Id;
                    patientJournalEntity.FirstAcceptDoctor.Code = user.Code;
                    patientJournalEntity.FirstAcceptDoctor.Name = user.Name;
                }
            }

            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {

                var modify = patientJournalEntity.Mapper<OP_Journal>();
                modify.LastModificationTime = serverTime;
                modify.LastModifierUserId = App.Instance.RuntimeSystemInfo.UserInfo.Id;

                tran.FromSql(@"update IOP_OutPatient set FirstAcceptDoctorCode=@FirstAcceptDoctorCode,FirstAcceptDoctorName=@FirstAcceptDoctorName,CurrentStatus=(case when CurrentStatus=0 then 1 else CurrentStatus end) where PatientNo=@PatientNo and HosId=@HosId ")
                    .AddInParameter("@FirstAcceptDoctorCode", System.Data.DbType.String, patientJournalEntity.FirstAcceptDoctor.Code)
                    .AddInParameter("@FirstAcceptDoctorName", System.Data.DbType.String, patientJournalEntity.FirstAcceptDoctor.Name)
                    .AddInParameter("@PatientNo", System.Data.DbType.String, patientJournalEntity.OutpatientNo)
                    .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                    .ExecuteNonQuery();

                tran.Update<OP_Journal>(modify);

                tran.Commit();

                return DataResult.True();

            }
            catch (Exception ex)
            {
                tran.Rollback();
                return DataResult.Fault(ex.Message);
            }
            finally
            {
                if (tran != null)
                    tran.Close();
            }
        }

        /// <summary>
        /// 患者初复诊
        /// </summary>
        /// <param name="outPatientNo">门诊号</param>
        /// <returns></returns>
        public int FirstOrSecond(string outPatientNo)
        {
            return DBHelper.Instance.HIS.From<OP_Journal>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.OutpatientNo == outPatientNo && d.DataStatus == (int)DataStatus.Enable)
                .Select(OP_Journal._.FirstOrSecond)
                .ToScalar<int>();
        }
    }
}
