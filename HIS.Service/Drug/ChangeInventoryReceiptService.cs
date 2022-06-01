using Dos.ORM;
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

namespace HIS.Service.Drug
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 15:10:37
    /// 描述:
    /// </summary>
    public class ChangeInventoryReceiptService : IChangeInventoryReceiptService
    {
        private readonly IIdService _idService;

        public ChangeInventoryReceiptService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 增加药库库存变更单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataResult AddWarehouseChangeInventoryReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> detailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        Internal.InternalChangeInventoryService.Instance.AddReceipt(_idService, receipt, detailEntities, batch);
                    }
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
        /// 增加药房库存变更单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataResult AddPharmacyChangeInventoryReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> detailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        Internal.InternalChangeInventoryService.Instance.AddReceipt(_idService, receipt, detailEntities, batch);
                    }
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
        /// 获取库存变更单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        public List<ChangeInventoryReceiptEntity> GetReceipt(long deptId, ChangeInventoryType? type, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            List<View_ChangeInventoryReceipt> models = new List<View_ChangeInventoryReceipt>();
            if (receiptCode == "")
            {
                if (type == null)
                    models = DBHelper.Instance.HIS.From<View_ChangeInventoryReceipt>().Where(p => p.DeptId == deptId && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End()).OrderByDescending(p => p.CreationTime).ToList();
                else
                    models = DBHelper.Instance.HIS.From<View_ChangeInventoryReceipt>().Where(p => p.DeptId == deptId && p.ReceiptType == (int)type && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End()).OrderByDescending(p => p.CreationTime).ToList();
            }
            else
            {
                if (type == null)
                    models = DBHelper.Instance.HIS.From<View_ChangeInventoryReceipt>().Where(p => p.DeptId == deptId && p.ReceiptCode == receiptCode).OrderByDescending(p => p.CreationTime).ToList();
                else
                    models = DBHelper.Instance.HIS.From<View_ChangeInventoryReceipt>().Where(p => p.DeptId == deptId && p.ReceiptType == (int)type && p.ReceiptCode == receiptCode).OrderByDescending(p => p.CreationTime).ToList();
            }

            return models.Mapper<List<ChangeInventoryReceiptEntity>>();
        }
        /// <summary>
        /// 获取库存变更单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public ChangeInventoryReceiptEntity GetReceipt(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_ChangeInventoryReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<ChangeInventoryReceiptEntity>();
        }
        /// <summary>
        /// 获取库存变更单据明细
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public List<ChangeInventoryReceiptDetailEntity> GetReceiptDetail(long receiptId)
        {
            var models = DBHelper.Instance.HIS.From<View_ChangeInventoryReceiptDetail>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
            List<ChangeInventoryReceiptDetailEntity> result = new List<ChangeInventoryReceiptDetailEntity>();
            foreach (var model in models)
            {
                var entity = model.Mapper<ChangeInventoryReceiptDetailEntity>();
                entity.Drug = model.Mapper<DrugEntity>();
                result.Add(entity);
            }

            return result;
        }
        /// <summary>
        /// 获取药库所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetWarehouseAllDrugInfo(long deptId)
        {
            var models = DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DeptId == deptId).ToList();
            return models.Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 获取药房所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetPharmacyAllDrugInfo(long deptId)
        {
            var models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId).ToList();
            return models.Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 获取审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetAuditStatus(long receiptId)
        {
            try
            {
                return DBHelper.Instance.HIS.From<Drug_ChangeInventoryReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DataStatus == (int)DataStatus.Enable).Select(p => p.AuditStatus).ToScalar<bool>();
            }
            catch
            {
                return true;
            }
        }
        /// <summary>
        /// 删除指定单据明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataResult DeleteReceiptDetail(long detailId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Drug_ChangeInventoryReceiptDetail>(p => p.Id == detailId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 删除指定单据
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        public DataResult DeleteReceipt(long receiptId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    var delete = AuditionHelper.GetDeletionValues<Drug_ChangeInventoryReceipt>();
                    var deleteDetail = AuditionHelper.GetDeletionValues<Drug_ChangeInventoryReceiptDetail>();

                    tran.Update<Drug_ChangeInventoryReceipt>(delete, p => p.Id == receiptId);
                    tran.Update<Drug_ChangeInventoryReceiptDetail>(deleteDetail, p => p.ReceiptId == receiptId);

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
        /// 更新指定单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="newDetails"></param>
        /// <param name="updateDetails"></param>
        /// <returns></returns>
        public DataResult UpdateReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> newDetails, List<ChangeInventoryReceiptDetailEntity> updateDetails)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //更新入库单据主表
                        var modifyReceipt = AuditionHelper.GetModificationValues<Drug_ChangeInventoryReceipt>();
                        modifyReceipt[Drug_ChangeInventoryReceipt._.Total] = receipt.Total;

                        batch.Update<Drug_ChangeInventoryReceipt>(modifyReceipt, new WhereClip(Drug_ChangeInventoryReceipt._.Id, receipt.Id, QueryOperator.Equal));

                        int no = tran.From<Drug_ChangeInventoryReceiptDetail>().Where(p => p.ReceiptId == receipt.Id && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(Drug_ChangeInventoryReceiptDetail._.No.Max()).ToScalar<int>() + 1;
                        foreach (var receiptDetailEntity in newDetails)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_ChangeInventoryReceiptDetail>().SetCreationValues();
                            receiptDetailEntity.Id = _idService.CreateUUID();
                            insertDetail.Id = receiptDetailEntity.Id;
                            insertDetail.No = no;
                            insertDetail.ReceiptId = receipt.Id;
                            batch.Insert(insertDetail);

                            no++;
                        }

                        //更新明细表
                        foreach (var receiptDetailEntity in updateDetails)
                        {
                            var modifyDetail = AuditionHelper.GetModificationValues<Drug_ChangeInventoryReceiptDetail>();
                            modifyDetail[Drug_ChangeInventoryReceiptDetail._.Quantity] = receiptDetailEntity.Quantity;

                            batch.Update<Drug_ChangeInventoryReceiptDetail>(modifyDetail, new WhereClip(Drug_ChangeInventoryReceiptDetail._.Id, receiptDetailEntity.Id, QueryOperator.Equal));
                        }

                    }
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
        /// 审核药库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult<DateTime> AuditWarehouseReceipt(long receiptId, long deptId, ChangeInventoryType receiptType)
        {
            var auditTime = DBHelper.Instance.ServerTime;

            //药库入出库记录表单据类型
            int inoutReceiptType = 0;
            if (receiptType == ChangeInventoryType.上调)
                inoutReceiptType = (int)WarehouseInInventoryType.上调;
            else if (receiptType == ChangeInventoryType.下调)
                inoutReceiptType = (int)WarehouseOutInventoryType.下调;
            else if (receiptType == ChangeInventoryType.报损)
                inoutReceiptType = (int)WarehouseOutInventoryType.报损;
            else if (receiptType == ChangeInventoryType.抽检)
                inoutReceiptType = (int)WarehouseOutInventoryType.抽检;

            var dt = DBHelper.Instance.HIS.FromProc("Proc_ChangeInventoryAudit")
                                          .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@DeptId", DbType.Int64, deptId)
                                          .AddInParameter("@OperationUserId", DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                          .AddInParameter("@OperationTime", DbType.DateTime, auditTime)
                                          .AddInParameter("@DeptType", DbType.Int32, 0)
                                          .AddInParameter("@ReceiptType", DbType.Int32, (int)receiptType)
                                          .AddInParameter("@InOutReceiptType", DbType.Int32, inoutReceiptType)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());

            return DataResult.True(auditTime);

        }
        /// <summary>
        /// 取消审核药库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult CancelAuditWarehouseReceipt(long receiptId, long deptId, ChangeInventoryType receiptType)
        {
            var dt = DBHelper.Instance.HIS.FromProc("Proc_ChangeInventoryCancelAudit")
                                          .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@DeptId", DbType.Int64, deptId)
                                          .AddInParameter("@OperationUserId", DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                          .AddInParameter("@DeptType", DbType.Int32, 0)
                                          .AddInParameter("@ReceiptType", DbType.Int32, (int)receiptType)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault(dt.Rows[0][1].ToString());

            return DataResult.True();
        }
        /// <summary>
        /// 审核药房单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult<DateTime> AuditPharmacyReceipt(long receiptId, long deptId, ChangeInventoryType receiptType)
        {
            var auditTime = DBHelper.Instance.ServerTime;

            //药房入出库记录表单据类型
            int inoutReceiptType = 0;
            if (receiptType == ChangeInventoryType.上调)
                inoutReceiptType = (int)PharmacyInInventoryType.上调;
            else if (receiptType == ChangeInventoryType.下调)
                inoutReceiptType = (int)PharmacyOutInventoryType.下调;
            else if (receiptType == ChangeInventoryType.报损)
                inoutReceiptType = (int)PharmacyOutInventoryType.报损;
            else if (receiptType == ChangeInventoryType.抽检)
                inoutReceiptType = (int)PharmacyOutInventoryType.抽检;

            var dt = DBHelper.Instance.HIS.FromProc("Proc_ChangeInventoryAudit")
                                          .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@DeptId", DbType.Int64, deptId)
                                          .AddInParameter("@OperationUserId", DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                          .AddInParameter("@OperationTime", DbType.DateTime, auditTime)
                                          .AddInParameter("@DeptType", DbType.Int32, 1)
                                          .AddInParameter("@ReceiptType", DbType.Int32, (int)receiptType)
                                          .AddInParameter("@InOutReceiptType", DbType.Int32, inoutReceiptType)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());

            return DataResult.True(auditTime);
        }
        /// <summary>
        /// 取消审核药房单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult CancelAuditPharmacyReceipt(long receiptId, long deptId, ChangeInventoryType receiptType)
        {
            var dt = DBHelper.Instance.HIS.FromProc("Proc_ChangeInventoryCancelAudit")
                                          .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@DeptId", DbType.Int64, deptId)
                                          .AddInParameter("@OperationUserId", DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                          .AddInParameter("@DeptType", DbType.Int32, 1)
                                          .AddInParameter("@ReceiptType", DbType.Int32, (int)receiptType)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault(dt.Rows[0][1].ToString());

            return DataResult.True();
        }
    }
}
