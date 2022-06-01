using HIS.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using HIS.Core;
using HIS.Model;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Entities.Drug;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace HIS.Service.Drug
{
    public class WarehouspitalTakeStockService : IWarehouspitalTakeStockService
    {
        private IIdService _idService;


        public WarehouspitalTakeStockService(IIdService idService)
        {
            this._idService = idService;
        }
        //获取盘点单列表
        public List<TakeStockEntity> GetByDate(long DeptId,DateTime start, DateTime end)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<TakeStockEntity>>(DBHelper.Instance.HIS.From<Drug_WarehouseTakeStock>().
                Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id &&
                p.DeptId == DeptId && p.CreationTime >= start && p.CreationTime < end)
                .OrderBy(Drug_WarehouseTakeStock._.CreationTime.Desc).ToList());

        }

        /// <summary>
        /// 新增盘点
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<TakeStockEntity> AddTakeStock(long DeptId, TakeStockEntity entity)
        {
             List<Drug_WarehouseTakeStock> list = DBHelper.Instance.HIS.From<Drug_WarehouseTakeStock>().
               Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id &&
               p.DeptId == DeptId && p.AuditStatus == false).ToList();

            if (list.Count > 0) {
                return DataResult.Fault<TakeStockEntity>("有未完成审核的盘点单，请先结束上次盘点！");
            }

            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                entity.Id = _idService.CreateUUID();
                var model = entity.Mapper<Drug_WarehouseTakeStock>();
                model.SetCreationValues();
                model.AuditStatus = false;
                model.AuditTime = null;
                trans.Insert<Drug_WarehouseTakeStock>(model);//新增盘点表

                //同时新增明细 且数量都为0
                string sql = $@"insert into Drug_WarehouseTakeStockDetail(Id,CreatorUserId,LastModifierUserId,
                                TakeStockId,ClassCode,SpecificationCode,CurrentQuantity,ActualQuantity)
                                select dbo.fn_GetUUID(NEWID()), @CreatorUserId,@LastModifierUserId,
                                @TakeStockId,ClassCode,SpecificationCode,Quantity,0 from [dbo].[View_WarehouseDrugInventory] where DeptId=@DeptId";
                trans.FromSql(sql)
                   .AddInParameter("@CreatorUserId", System.Data.DbType.String, App.Instance.User.Id)
                   .AddInParameter("@LastModifierUserId", System.Data.DbType.String, App.Instance.User.Id)
                   .AddInParameter("@TakeStockId", System.Data.DbType.String, model.Id)
                   .AddInParameter("@DeptId", System.Data.DbType.String, entity.DeptId)
                   .ExecuteNonQuery();

                trans.Commit();
                return DataResult.True<TakeStockEntity>(entity);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<TakeStockEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }

        /// <summary>
        /// 完成盘点
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<TakeStockEntity> OverTakeStock(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();

            try
            {
                // AuditStatus 0 盘点中 1盘点并审核完成
                Dictionary<Field, object> dic = new Dictionary<Field, object>();
                dic.Add(Drug_WarehouseTakeStock._.AuditStatus, 1);
                dic.Add(Drug_WarehouseTakeStock._.AuditTime, DateTime.Now);
                dic.Add(Drug_WarehouseTakeStock._.AuditUserId, App.Instance.User.Id);
                dic.Add(Drug_WarehouseTakeStock._.AuditUserName, App.Instance.User.UserName);
                trans.Update<Drug_WarehouseTakeStock>(dic, Drug_WarehouseTakeStock._.Id == entityId);


                // 写入库存活动表  Drug_WarehouseInInventory 盘盈  Drug_WarehouseOutInventory 盘亏 并且更新关联信息
                trans.FromPro("Proc_DrugWarehouseTakeStock")
                .AddInParameter("@TakeStockId", System.Data.DbType.String, entityId.ToString())
                .ExecuteNonQuery();

                trans.Commit();
                return DataResult.True<TakeStockEntity>(null);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<TakeStockEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }

        /// <summary>
        /// 删除盘点及明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<TakeStockEntity> DeleteTakeStock(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();

            try
            {
                //删除盘点单
                trans.Delete<Drug_WarehouseTakeStock>(Drug_WarehouseTakeStock._.Id == entityId);
                //清除掉明细数据
                trans.Delete<Drug_WarehouseTakeStockDetail>(Drug_WarehouseTakeStockDetail._.TakeStockId == entityId);

                trans.Commit();
                return DataResult.True<TakeStockEntity>(null);

            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<TakeStockEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }

        /// <summary>
        /// 根据盘点单ID获取盘点明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<TakeStockDetailEntity> GetByTakeStockId(long entityId)
        {
            string sql = "select * from View_Drug_WarehouseTakeStockDetail where TakeStockId=@TakeStockId";
            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@TakeStockId", System.Data.DbType.String, entityId)
                .ToList<TakeStockDetailEntity>();
        }

        /// <summary>
        /// 根据筛选条件 查询对应盘点明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="searchStr"></param>
        /// <returns></returns>
        public List<TakeStockDetailEntity> GetBySearchStr(long entityId, string searchStr)
        {
            string sql = "select * from View_Drug_WarehouseTakeStockDetail where TakeStockId=@TakeStockId and SearchCode like '%" + searchStr + "%' or DrugName like '%" + searchStr + "%'";
            return DBHelper.Instance.HIS.FromSql(sql)
                .AddInParameter("@TakeStockId", System.Data.DbType.String, entityId)
                .ToList<TakeStockDetailEntity>();
        }

        /// <summary>
        /// 更改盘点明细 数量
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        public DataResult<TakeStockDetailEntity> UpdateDetailQuantity(long entityId, int quantity)
        {
            try
            {
                DBHelper.Instance.HIS.Update<Drug_WarehouseTakeStockDetail>(Drug_WarehouseTakeStockDetail._.ActualQuantity, quantity, Drug_WarehouseTakeStockDetail._.Id == entityId);
                return DataResult.True<TakeStockDetailEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<TakeStockDetailEntity>(ex.Message);
            }

        }
    }
}
