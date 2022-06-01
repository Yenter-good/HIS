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
using HIS.Service.Core.Entities.Drug;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace HIS.Service.Drug
{
    public class ProcurementPlanService : IProcurementPlanService
    {
        private IIdService _idService;
        public ProcurementPlanService(IIdService idService)
        {
            this._idService = idService;
        }
        //获取采购计划申请单列表
        public List<ProcurementPlanEntity> GetAll() 
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<ProcurementPlanEntity>>(DBHelper.Instance.HIS.From<Drug_Procurement>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(Drug_Procurement._.CreationTime.Desc).ToList());

        }

        /// <summary>
        /// 新增采购计划
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<ProcurementPlanEntity> AddPlan(ProcurementPlanEntity entity)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                entity.Id = _idService.CreateUUID();
                var model = entity.Mapper<Drug_Procurement>();
                model.SetCreationValues();
                trans.Insert<Drug_Procurement>(model);//新增采购计划

                //同时新增明细 且数量都为0
                string sql = $@"insert into Drug_ProcurementDetail (Id,HosId,CreatorUserId,LastModifierUserId,ReceiptId,ClassCode,SpecificationCode,Quantity)
                            select dbo.fn_GetUUID(NEWID()), @HosId,@CreatorUserId,@LastModifierUserId,@ReceiptId,ClassCode,SpecificationCode,0 from [dbo].[View_WarehouseDrugInfo] where DrugType=0";
                trans.FromSql(sql)
                   .AddInParameter("@HosId", System.Data.DbType.String, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                   .AddInParameter("@CreatorUserId", System.Data.DbType.String, App.Instance.User.Id)
                   .AddInParameter("@LastModifierUserId", System.Data.DbType.String, App.Instance.User.Id)
                   .AddInParameter("@ReceiptId", System.Data.DbType.String, model.Id)
                   .ExecuteNonQuery();

                trans.Commit();
                return DataResult.True<ProcurementPlanEntity>(entity);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<ProcurementPlanEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }

        /// <summary>
        /// 完成采购计划
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<ProcurementPlanEntity> OverPlan(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();

            try {
                // AuditStatus 0 计划生成中 1审核完成
                Dictionary<Field, object> dic = new Dictionary<Field, object>();
                dic.Add(Drug_Procurement._.AuditStatus, 1);
                dic.Add(Drug_Procurement._.AuditTime, DateTime.Now);
                dic.Add(Drug_Procurement._.AuditUserId, App.Instance.User.Id);
                trans.Update<Drug_Procurement>(dic, Drug_Procurement._.Id == entityId);
                //完成采购计划时 清除掉 采购为0的数据
                trans.Delete<Drug_ProcurementDetail>(Drug_ProcurementDetail._.ReceiptId == entityId && Drug_ProcurementDetail._.Quantity == 0);
                
                trans.Commit();
                return DataResult.True<ProcurementPlanEntity>(null);
             
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<ProcurementPlanEntity>(ex.Message);
            } 
            finally
            {
                trans.Close();
            }

         }

        /// <summary>
        /// 删除采购计划及明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<ProcurementPlanEntity> DeletePlan(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();

            try
            {
                //删除采购计划
                trans.Delete<Drug_Procurement>(Drug_Procurement._.Id == entityId);

                //清除掉明细数据
                trans.Delete<Drug_ProcurementDetail>(Drug_ProcurementDetail._.ReceiptId == entityId);

                trans.Commit();
                return DataResult.True<ProcurementPlanEntity>(null);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<ProcurementPlanEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }

        }

        /// <summary>
        /// 根据计划ID获取采购计划明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<ProcurementPlanDetailEntity> GetByPlanId(long entityId)
        {
            string sql = "select * from View_Drug_ProcurementDetail where ReceiptId=@ReceiptId";
            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@ReceiptId", System.Data.DbType.String, entityId)
                .ToList<ProcurementPlanDetailEntity>();
        }

        /// <summary>
        /// 根据筛选条件 查询对应采购明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        public List<ProcurementPlanDetailEntity> GetBySearchStr(long entityId, string searchStr)
        {
            string sql = "select * from View_Drug_ProcurementDetail where ReceiptId=@ReceiptId and SearchCode like '%"+ searchStr + "%' or DrugName like '%"+ searchStr + "%'";
            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@ReceiptId", System.Data.DbType.String, entityId)
                .ToList<ProcurementPlanDetailEntity>();
        }

        /// <summary>
        /// 更改采购明细 数量
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        public DataResult<ProcurementPlanDetailEntity>  UpdateDetailQuantity(long entityId, int quantity)
        {
            try
            {
                DBHelper.Instance.HIS.Update<Drug_ProcurementDetail>(Drug_ProcurementDetail._.Quantity, quantity, Drug_ProcurementDetail._.Id == entityId);
                return DataResult.True<ProcurementPlanDetailEntity>(null);
            }
            catch (Exception ex) {

                return DataResult.Fault<ProcurementPlanDetailEntity>(ex.Message);
            }

        }
        /// <summary>
        /// 按规则填充采购明细的采购量
        /// </summary>
        /// <param name="entityId">采购计划ID</param>
        /// <param name="type">规则类型</param>
        /// <returns></returns>
        public DataResult FillQuantity(long entityId, int type)
        {
            try
            {
                ProcSection proc = DBHelper.Instance.HIS.FromProc("Proc_DrugProcurement")
                .AddInParameter("@Type", System.Data.DbType.Int32, type)
                .AddInParameter("@ReceiptId", System.Data.DbType.String, entityId.ToString());

                proc.ExecuteNonQuery();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
            

        }
    }
}
