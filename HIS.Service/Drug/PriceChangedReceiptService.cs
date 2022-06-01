using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core;
using HIS.Model;
using HIS.Core;
using HIS.Service.Core.Enums;
using HIS.Utility;
using HIS.Core.Interceptors;
using HIS.Service.Internal;
using System.Data;

namespace HIS.Service
{
    public class PriceChangedReceiptService : IPriceChangedReceiptService
    {

        /// <summary>
        /// 获取调价单据列表
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        public List<PriceChangedReceiptEntity> GetPriceChangedReceipt(long deptId, DateTime startTime, DateTime endTime)
        {
            return DBHelper.Instance.HIS.From<View_PriceChangedReceipt>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                    && d.DeptId == deptId && d.CreationTime >= startTime.Start() && d.CreationTime <= endTime.End())
                .OrderBy(View_PriceChangedReceipt._.CreationTime.Desc)
                .ToList<View_PriceChangedReceipt>()
                .Mapper<List<PriceChangedReceiptEntity>>();

        }
        /// <summary>
        /// 获取调价单据列表
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="recriptCode">单据号</param>
        /// <returns></returns>
        public List<PriceChangedReceiptEntity> GetPriceChangedReceipt(long deptId, string recriptCode)
        {
            return DBHelper.Instance.HIS.From<View_PriceChangedReceipt>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DeptId == deptId && d.ReceiptCode == recriptCode)
                .OrderBy(View_PriceChangedReceipt._.CreationTime.Desc)
                .ToList<View_PriceChangedReceipt>()
                .Mapper<List<PriceChangedReceiptEntity>>();
        }
        /// <summary>
        /// 获取药库库存中的药品
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllWarehouseDrugInfo(DrugType drugType, long deptId)
        {
            return DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DrugType == (int)drugType && p.DeptId == deptId).ToList().Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 获取药房库存中的药品
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllPharmacyDrugInfo(DrugType drugType, long deptId)
        {
            return DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DrugType == (int)drugType && p.DeptId == deptId).ToList().Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 删除药品调价单据明细
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        [Log(Action = "删除药品调价单据明细")]
        public DataResult DeletePriceChangedReceiptDetail(List<long> detailIds)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Drug_PriceChangedReceiptDetail>(Drug_PriceChangedReceiptDetail._.Id.SelectIn<long>(detailIds) && Drug_PriceChangedReceiptDetail._.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取单据顺序号
        /// </summary>
        /// <returns></returns>
        public int GetPriceChangedReceiptNo()
        {
            int maxNo = DBHelper.Instance.HIS.From<Drug_PriceChangedReceipt>()
                .Where(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                .Select(Drug_PriceChangedReceipt._.No.Max())
                .ToScalar<int>();

            return maxNo + 1;
        }
        /// <summary>
        /// 新增药品调价单
        /// </summary>
        /// <param name="receipt">药品调价单实体</param>
        /// <param name="receiptDetails">药品调价单明细</param>
        /// <returns></returns>
        public DataResult AddPriceChangedReceipt(PriceChangedReceiptEntity receipt, List<PriceChangedReceiptDetailEntity> receiptDetails)
        {
            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                Drug_PriceChangedReceipt ormReceipt = new Drug_PriceChangedReceipt();
                ormReceipt.SetCreationValues();
                ormReceipt.Id = receipt.Id;
                ormReceipt.ReceiptCode = receipt.ReceiptCode;
                ormReceipt.No = this.GetPriceChangedReceiptNo();
                ormReceipt.AuditUserId = 0;
                ormReceipt.AuditStatus = false;
                ormReceipt.Memo = receipt.Memo;
                ormReceipt.DeptId = receipt.Dept.Id;
                ormReceipt.PlanEffectTime = receipt.PlanEffectTime;
                receipt.CreateUser = new UserEntity() { Id = App.Instance.User.Id.Value, Name = App.Instance.User.UserName };
                receipt.CreationTime = ormReceipt.CreationTime;

                List<Drug_PriceChangedReceiptDetail> ormReceiptDetails = new List<Drug_PriceChangedReceiptDetail>();

                int maxNo = DBHelper.Instance.HIS.From<Drug_PriceChangedReceiptDetail>().Where(d => d.ReceiptId == receipt.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                    .Select(Drug_PriceChangedReceiptDetail._.No.Max()).ToScalar<int>();
                foreach (var item in receiptDetails)
                {
                    ormReceiptDetails.Add(new Drug_PriceChangedReceiptDetail()
                    {
                        Id = item.Id,
                        ReceiptId = item.ReceiptId,
                        HosId = ormReceipt.HosId,
                        CreatorUserId = ormReceipt.CreatorUserId,
                        CreationTime = ormReceipt.CreationTime,
                        LastModifierUserId = ormReceipt.LastModifierUserId,
                        LastModificationTime = ormReceipt.LastModificationTime,
                        DataStatus = (int)DataStatus.Enable,
                        No = ++maxNo,
                        ClassCode = item.Drug.ClassCode,
                        SpecificationCode = item.Drug.SpecificationCode,
                        OldPrice = item.OldPrice.AsDecimal().Value,
                        RealTimePrice = item.OldPrice.AsDecimal().Value,
                        NewPrice = item.NewPrice.AsDecimal().Value,
                        PriceDifference = item.PriceDifference.AsDecimal().Value
                    });
                }

                tran.Insert<Drug_PriceChangedReceipt>(ormReceipt);
                tran.Insert<Drug_PriceChangedReceiptDetail>(ormReceiptDetails);
                InternalInvoiceService.Instance.ReleaseInvoice(InvoiceType.药品调价单据, tran);

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
        /// 修改调价单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="addReceiptDetails"></param>
        /// <param name="modifyReceiptDetails"></param>
        /// <returns></returns>
        public DataResult UpdatePriceChangedReceipt(PriceChangedReceiptEntity receipt, List<PriceChangedReceiptDetailEntity> addReceiptDetails, List<PriceChangedReceiptDetailEntity> modifyReceiptDetails)
        {
            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                //药品调价单据修改
                long userid = App.Instance.RuntimeSystemInfo.UserInfo.Id;
                long hosid = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                DateTime serverTime = DBHelper.Instance.ServerTime;

                var modifyReceipt = new Dictionary<Dos.ORM.Field, object>();
                modifyReceipt[Drug_PriceChangedReceipt._.Memo] = receipt.Memo;
                modifyReceipt[Drug_PriceChangedReceipt._.PlanEffectTime] = receipt.PlanEffectTime;
                modifyReceipt[Drug_PriceChangedReceipt._.LastModificationTime] = serverTime;
                modifyReceipt[Drug_PriceChangedReceipt._.LastModifierUserId] = userid;

                //新增加单据明细
                if (addReceiptDetails != null && addReceiptDetails.Count > 0)
                {
                    List<Drug_PriceChangedReceiptDetail> ormReceiptDetails = new List<Drug_PriceChangedReceiptDetail>();
                    int maxNo = DBHelper.Instance.HIS.From<Drug_PriceChangedReceiptDetail>().Where(d => d.ReceiptId == receipt.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                        .Select(Drug_PriceChangedReceiptDetail._.No.Max()).ToScalar<int>();
                    foreach (var item in addReceiptDetails)
                    {
                        ormReceiptDetails.Add(new Drug_PriceChangedReceiptDetail()
                        {
                            Id = item.Id,
                            ReceiptId = item.ReceiptId,
                            HosId = hosid,
                            CreatorUserId = userid,
                            CreationTime = serverTime,
                            LastModifierUserId = userid,
                            LastModificationTime = serverTime,
                            DataStatus = (int)DataStatus.Enable,
                            No = ++maxNo,
                            ClassCode = item.Drug.ClassCode,
                            SpecificationCode = item.Drug.SpecificationCode,
                            OldPrice = item.OldPrice.AsDecimal().Value,
                            RealTimePrice = item.OldPrice.AsDecimal().Value,
                            NewPrice = item.NewPrice.AsDecimal().Value,
                            PriceDifference = item.PriceDifference.AsDecimal().Value
                        });
                    }

                    tran.Insert<Drug_PriceChangedReceiptDetail>(ormReceiptDetails);
                }

                //修改单据明细
                if (modifyReceiptDetails != null && modifyReceiptDetails.Count > 0)
                {
                    foreach (var item in modifyReceiptDetails)
                    {
                        var modifyReceiptDetail = new Dictionary<Dos.ORM.Field, object>();
                        modifyReceiptDetail[Drug_PriceChangedReceiptDetail._.LastModificationTime] = serverTime;
                        modifyReceiptDetail[Drug_PriceChangedReceiptDetail._.LastModifierUserId] = userid;
                        modifyReceiptDetail[Drug_PriceChangedReceiptDetail._.NewPrice] = item.NewPrice;
                        modifyReceiptDetail[Drug_PriceChangedReceiptDetail._.PriceDifference] = item.PriceDifference;

                        tran.Update<Drug_PriceChangedReceiptDetail>(modifyReceiptDetail, d => d.Id == item.Id && d.HosId == hosid);
                    }
                }
                tran.Update<Drug_PriceChangedReceipt>(modifyReceipt, d => d.Id == receipt.Id && d.HosId == hosid);
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
        /// 获取调价单据明细
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        public List<PriceChangedReceiptDetailEntity> GetPriceChangedDetailReceiptDetail(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_PriceChangedReceiptDetail>()
                  .Where(d => d.ReceiptId == receiptId && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                  .OrderBy(View_PriceChangedReceiptDetail._.No)
                  .ToList()
                  .Mapper<List<PriceChangedReceiptDetailEntity>>();

        }
        /// <summary>
        /// 删除调价单据
        /// </summary>
        /// <param name="Id">调价单据ID</param>
        /// <returns></returns>
        public DataResult DeleteReceipt(long receiptId)
        {
            var tran = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                long userid = App.Instance.RuntimeSystemInfo.UserInfo.Id;
                long hosid = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                DateTime serverTime = DBHelper.Instance.ServerTime;

                Dictionary<Dos.ORM.Field, object> deleteReceipt = new Dictionary<Dos.ORM.Field, object>();
                deleteReceipt[Drug_PriceChangedReceipt._.DataStatus] = (int)DataStatus.Delete;
                deleteReceipt[Drug_PriceChangedReceipt._.LastModificationTime] = serverTime;
                deleteReceipt[Drug_PriceChangedReceipt._.LastModifierUserId] = userid;
                deleteReceipt[Drug_PriceChangedReceipt._.DeleterUserId] = userid;
                deleteReceipt[Drug_PriceChangedReceipt._.DeletionTime] = serverTime;

                Dictionary<Dos.ORM.Field, object> deleteReceiptDetail = new Dictionary<Dos.ORM.Field, object>();
                deleteReceiptDetail[Drug_PriceChangedReceiptDetail._.DataStatus] = (int)DataStatus.Delete;
                deleteReceiptDetail[Drug_PriceChangedReceiptDetail._.LastModificationTime] = serverTime;
                deleteReceiptDetail[Drug_PriceChangedReceiptDetail._.LastModifierUserId] = userid;
                deleteReceiptDetail[Drug_PriceChangedReceiptDetail._.DeleterUserId] = userid;
                deleteReceiptDetail[Drug_PriceChangedReceiptDetail._.DeletionTime] = serverTime;

                tran.Update<Drug_PriceChangedReceipt>(deleteReceipt, d => d.Id == receiptId && d.HosId == hosid);
                tran.Update<Drug_PriceChangedReceiptDetail>(deleteReceipt, d => d.ReceiptId == receiptId && d.HosId == hosid);

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
        /// 获取指定调价单的审核状态
        /// </summary>
        /// <param name="receiptId">调价单ID</param>
        /// <returns></returns>
        public bool? GetAuditStatus(long receiptId)
        {
            return DBHelper.Instance.HIS.From<Drug_PriceChangedReceipt>().Where(d => d.Id == receiptId && d.DataStatus == (int)DataStatus.Enable && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                .Select(d => d.AuditStatus)
                .ToScalar<bool?>();
        }
        /// <summary>
        /// 获取药品调价单据
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        public PriceChangedReceiptEntity GetReceiptById(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_PriceChangedReceipt>().Where(d => d.Id == receiptId && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                .First().Mapper<PriceChangedReceiptEntity>();
        }
        /// <summary>
        /// 审核调价单
        /// </summary>
        /// <param name="receiptId">调价单ID</param>
        /// <returns></returns>
        public DataResult<DateTime> Audit(long receiptId)
        {
            try
            {
                DateTime serverTime = DBHelper.Instance.ServerTime;
                long userid = App.Instance.RuntimeSystemInfo.UserInfo.Id;
                long hosid = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;

                string auditSql = @"update Drug_PriceChangedReceipt 
set AuditStatus=1,AuditUserId=@AuditUserId,AuditTime=@AuditTime,LastModificationTime=@LastModificationTime,LastModifierUserId=@LastModifierUserId 
where Id=@Id and HosId=@HosId";
                DBHelper.Instance.HIS.FromSql(auditSql)
.AddInParameter("@AuditUserId", System.Data.DbType.Int64, userid)
.AddInParameter("@AuditTime", System.Data.DbType.DateTime, serverTime)
.AddInParameter("@LastModificationTime", System.Data.DbType.DateTime, serverTime)
.AddInParameter("@LastModifierUserId", System.Data.DbType.Int64, userid)
.AddInParameter("@Id", System.Data.DbType.Int64, receiptId)
.AddInParameter("@HosId", System.Data.DbType.Int64, hosid)
.ExecuteNonQuery();

                return DataResult.True(serverTime);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DateTime>(ex.Message);
            }
        }
        /// <summary>
        /// 取消审核
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        public DataResult CancelAudit(long receiptId)
        {
            try
            {
                DateTime serverTime = DBHelper.Instance.ServerTime;
                long userid = App.Instance.RuntimeSystemInfo.UserInfo.Id;
                long hosid = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;

                string auditSql = @"update Drug_PriceChangedReceipt 
set AuditStatus=0,AuditUserId=null,AuditTime=null,LastModificationTime=@LastModificationTime,LastModifierUserId=@LastModifierUserId 
where Id=@Id and HosId=@HosId";
                DBHelper.Instance.HIS.FromSql(auditSql)
.AddInParameter("@LastModificationTime", System.Data.DbType.DateTime, serverTime)
.AddInParameter("@LastModifierUserId", System.Data.DbType.Int64, userid)
.AddInParameter("@Id", System.Data.DbType.Int64, receiptId)
.AddInParameter("@HosId", System.Data.DbType.Int64, hosid)
.ExecuteNonQuery();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 调价单生效
        /// </summary>
        /// <param name="receiptId">单据Id</param>
        /// <param name="tran">事务</param>
        /// <returns></returns>
        public DataResult<DateTime> Effect(long receiptId, DateTime? serverTime = null)
        {
            try
            {
                if (!serverTime.HasValue)
                    serverTime = DBHelper.Instance.ServerTime;
                var dt = DBHelper.Instance.HIS.FromProc("[dbo].[Proc_PriceChangedEffect]")
.AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
.AddInParameter("@ReceiptId", DbType.Int64, receiptId)
.AddInParameter("@ExecUserId", DbType.Int64, App.Instance.RuntimeSystemInfo.UserInfo.Id)
.AddInParameter("@ExecTime", DbType.DateTime, serverTime.Value)
.ToDataTable();
                if (dt.Rows[0][0].ToString() == "0")
                    return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());
                else
                    return DataResult.True(serverTime.Value);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DateTime>(ex.Message);
            }
        }
        /// <summary>
        /// 获取影响的记录
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <param name="receiptDetailId">单据明细</param>
        /// <returns></returns>
        public List<PriceChangedDeptInfluenceEntity> GetPriceChangedDeptInfluence(long receiptId, long receiptDetailId)
        {
            return DBHelper.Instance.HIS.From<View_PriceChangedDeptInfluence>()
                .Where(d => d.ReceiptId == receiptId && d.ReceiptDetailId == receiptDetailId && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                .ToList<View_PriceChangedDeptInfluence>()
                .Mapper<List<PriceChangedDeptInfluenceEntity>>();
        }
    }
}
