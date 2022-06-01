using Dos.ORM;
using HIS.Core;
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
    /// 创建时间:2021-01-25 09:49:29
    /// 描述:
    /// </summary>
    public class DrugTransferService : IDrugTransferService
    {
        private readonly IIdService _idService;

        public DrugTransferService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 增加调拨单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataResult AddTransferReceipt(DrugTransferReceipt receipt, List<DrugTransferDetailEntity> detailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {

                        var insertReceipt = receipt.Mapper<Drug_TransferReceipt>();
                        receipt.Id = _idService.CreateUUID();
                        insertReceipt.Id = receipt.Id;
                        insertReceipt.AuditTime = null;
                        insertReceipt.AuditStatus = false;
                        insertReceipt.No = 0;
                        insertReceipt.TotalPrice = receipt.Total;

                        int no = 0;
                        foreach (var receiptDetailEntity in detailEntities)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_TransferReceiptDetail>().SetCreationValues();
                            receiptDetailEntity.Id = _idService.CreateUUID();
                            insertDetail.Id = receiptDetailEntity.Id;
                            insertDetail.No = no;
                            insertDetail.ReceiptId = receipt.Id;
                            batch.Insert(insertDetail);

                            no++;
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
        /// 获取申请的调拨单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param> 
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        public List<DrugTransferReceipt> GetApplyReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            List<DrugTransferReceipt> result = new List<DrugTransferReceipt>();
            if (receiptCode == "")
            {
                var models = DBHelper.Instance.HIS.From<View_DrugTrasnferReceipt>().Where(p => p.ApplyDeptId == deptId && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End() && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList();
                result = models.Mapper<List<DrugTransferReceipt>>();
            }
            else
            {
                var models = DBHelper.Instance.HIS.From<View_DrugTrasnferReceipt>().Where(p => p.ApplyDeptId == deptId && p.ReceiptCode == receiptCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList();
                result = models.Mapper<List<DrugTransferReceipt>>();
            }

            return result;
        }
        /// <summary>
        /// 获取接受的调拨单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        public List<DrugTransferReceipt> GetAcceptReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            List<DrugTransferReceipt> result = new List<DrugTransferReceipt>();
            if (receiptCode == "")
            {
                var models = DBHelper.Instance.HIS.From<View_DrugTrasnferReceipt>().Where(p => p.AcceptDeptId == deptId && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End() && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList();
                result = models.Mapper<List<DrugTransferReceipt>>();
            }
            else
            {
                var models = DBHelper.Instance.HIS.From<View_DrugTrasnferReceipt>().Where(p => p.AcceptDeptId == deptId && p.ReceiptCode == receiptCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList();
                result = models.Mapper<List<DrugTransferReceipt>>();
            }

            return result;
        }
        /// <summary>
        /// 获取调拨单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public DrugTransferReceipt GetReceipt(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_DrugTrasnferReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<DrugTransferReceipt>();
        }
        /// <summary>
        /// 获取调拨单据明细
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="type">0药库 1药房</param>
        /// <returns></returns>
        public List<DrugTransferDetailEntity> GetReceiptDetail(long receiptId, int type)
        {
            if (type == 0)
                return DBHelper.Instance.HIS.From<View_DrugTransferReceiptDetailByWarehouse>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<DrugTransferDetailEntity>>();
            else
                return DBHelper.Instance.HIS.From<View_DrugTransferReceiptDetailByPharmacy>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<DrugTransferDetailEntity>>();
        }
        /// <summary>
        /// 获取所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type">0药库 1药房</param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllDrugInfo(long deptId, int type)
        {
            if (type == 0)
                return DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DeptId == deptId).ToList().Mapper<List<DrugInventoryEntity>>();
            else
                return DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DeptId == deptId).ToList().Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 获取审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetAuditStatus(long receiptId)
        {
            return DBHelper.Instance.HIS.From<Drug_TransferReceipt>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.Id == receiptId && p.DataStatus == (int)DataStatus.Enable).Select(p => p.AuditStatus).ToScalar<bool>();
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
                DBHelper.Instance.HIS.Delete<Drug_TransferReceiptDetail>(p => p.Id == detailId);
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
                    var deleteTime = DBHelper.Instance.ServerTime;

                    var deleteReceipt = AuditionHelper.GetDeletionValues<Drug_TransferReceipt>(deleteTime);
                    var deleteDetail = AuditionHelper.GetDeletionValues<Drug_TransferReceiptDetail>(deleteTime);

                    tran.Update<Drug_TransferReceipt>(deleteReceipt, p => p.Id == receiptId);
                    tran.Update<Drug_TransferReceiptDetail>(deleteDetail, p => p.ReceiptId == receiptId);

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
        /// 更新单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="newDetails"></param>
        /// <param name="updateDetails"></param>
        /// <returns></returns>
        public DataResult UpdateReceipt(DrugTransferReceipt receipt, List<DrugTransferDetailEntity> newDetails, List<DrugTransferDetailEntity> updateDetails)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //更新入库单据主表
                        var modifyReceipt = AuditionHelper.GetModificationValues<Drug_TransferReceipt>();
                        modifyReceipt[Drug_TransferReceipt._.TotalPrice] = receipt.Total;

                        batch.Update<Drug_TransferReceipt>(modifyReceipt, new WhereClip(Drug_TransferReceipt._.Id, receipt.Id, QueryOperator.Equal));

                        int no = tran.From<Drug_TransferReceiptDetail>().Where(p => p.ReceiptId == receipt.Id).Select(Drug_TransferReceiptDetail._.No.Max()).ToScalar<int>() + 1;
                        foreach (var receiptDetailEntity in newDetails)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_TransferReceiptDetail>().SetCreationValues();
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
                            var modifyDetail = AuditionHelper.GetModificationValues<Drug_TransferReceiptDetail>();
                            modifyDetail[Drug_TransferReceiptDetail._.Quantity] = receiptDetailEntity.Quantity;
                            modifyDetail[Drug_TransferReceiptDetail._.Price] = receiptDetailEntity.Price;

                            batch.Update<Drug_TransferReceiptDetail>(modifyDetail, new WhereClip(Drug_TransferReceiptDetail._.Id, receiptDetailEntity.Id, QueryOperator.Equal));
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
        /// 审核单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="applyDeptId"></param>
        /// <param name="acceptDeptId"></param>
        /// <param name="deptType">0药库 1药房</param>
        /// <returns></returns>
        public DataResult<DateTime> AuditWarehouseReceipt(long receiptId, long applyDeptId, long acceptDeptId, int deptType)
        {
            try
            {
                var auditTime = DBHelper.Instance.ServerTime;

                var dt = DBHelper.Instance.HIS.FromProc("Proc_DrugTransferAudit")
                                            .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                            .AddInParameter("@ApplyDeptId", System.Data.DbType.Int64, applyDeptId)
                                            .AddInParameter("@AcceptDeptId", System.Data.DbType.Int64, acceptDeptId)
                                            .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
                                            .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                            .AddInParameter("@OperationTime", System.Data.DbType.DateTime, auditTime)
                                            .AddInParameter("@DeptType", System.Data.DbType.Int32, deptType)
                                            .ToDataTable();

                if (dt.Rows[0][0].ToString() == "0")
                    return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());

                return DataResult.True(auditTime);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DateTime>(ex.Message);
            }
        }
        /// <summary>
        /// 取消审核单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult CancelAuditWarehouseReceipt(long receiptId, long applyDeptId, long acceptDeptId, int deptType)
        {
            try
            {
                var auditTime = DBHelper.Instance.ServerTime;

                var dt = DBHelper.Instance.HIS.FromProc("Proc_DrugTransferCancelAudit")
                                              .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                              .AddInParameter("@ApplyDeptId", System.Data.DbType.Int64, applyDeptId)
                                              .AddInParameter("@AcceptDeptId", System.Data.DbType.Int64, acceptDeptId)
                                              .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
                                              .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                              .AddInParameter("@DeptType", System.Data.DbType.Int32, deptType)
                                              .ToDataTable();

                if (dt.Rows[0][0].ToString() == "0")
                    return DataResult.Fault(dt.Rows[0][1].ToString());

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
