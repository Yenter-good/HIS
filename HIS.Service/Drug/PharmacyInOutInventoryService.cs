using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;

namespace HIS.Service
{
    public class PharmacyInOutInventoryService : IPharmacyInOutInventoryService
    {
        private readonly IIdService _idService;

        public PharmacyInOutInventoryService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取药房入出库单据
        /// </summary>
        /// <param name="acceptDeptId"></param>
        /// <param name="applyDeptId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public List<PharmacyInOutInventoryEntity> GetPharmacyInOutReceipt(long deptId, PharmacyInOutReceiptType type, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            List<View_PharmacyReceipt> models = new List<View_PharmacyReceipt>();
            if (receiptCode == "")
            {
                if (type == PharmacyInOutReceiptType.入库)
                    models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.TargetDeptId == deptId && p.ReceiptType == (int)type && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End()).OrderByDescending(p => p.CreationTime).ToList();
                else if (type == PharmacyInOutReceiptType.退库)
                    models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.SourceDeptId == deptId && p.ReceiptType == (int)type && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End()).OrderByDescending(p => p.CreationTime).ToList();
            }
            else
            {
                if (type == PharmacyInOutReceiptType.入库)
                    models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.TargetDeptId == deptId && p.ReceiptType == (int)type && p.ReceiptCode == receiptCode).OrderByDescending(p => p.CreationTime).ToList();
                else if (type == PharmacyInOutReceiptType.退库)
                    models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.SourceDeptId == deptId && p.ReceiptType == (int)type && p.ReceiptCode == receiptCode).OrderByDescending(p => p.CreationTime).ToList();
            }

            return models.Mapper<List<PharmacyInOutInventoryEntity>>();
        }
        /// <summary>
        /// 获取药房入出库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public PharmacyInOutInventoryEntity GetPharmacyInOutReceipt(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<PharmacyInOutInventoryEntity>();
        }
        /// <summary>
        /// 获取向指定科室申请的药房申请单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public List<PharmacyInOutInventoryEntity> GetApplyPharmacyInReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            List<View_PharmacyReceipt> models = new List<View_PharmacyReceipt>();
            if (receiptCode != "")
            {
                models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.SourceDeptId == deptId && p.ReceiptType == (int)PharmacyInOutReceiptType.入库 && p.ReceiptCode == receiptCode).ToList();
            }
            else
            {
                models = DBHelper.Instance.HIS.From<View_PharmacyReceipt>().Where(p => p.SourceDeptId == deptId && p.ReceiptType == (int)PharmacyInOutReceiptType.入库 && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End()).ToList();
            }
            return models.Mapper<List<PharmacyInOutInventoryEntity>>();
        }
        /// <summary>
        /// 获取药库入出库单据明细
        /// </summary>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        public List<PharmacyInOutInventoryDetailEntity> GetPharmacyInOutReceiptDetail(long receiptId, PharmacyInOutReceiptType receiptType)
        {
            List<PharmacyInOutInventoryDetailEntity> result = new List<PharmacyInOutInventoryDetailEntity>();
            if (receiptType == PharmacyInOutReceiptType.入库)
            {
                var models = DBHelper.Instance.HIS.From<View_InPharmacyReceiptDetail>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
                foreach (var model in models)
                {
                    var entity = model.Mapper<PharmacyInOutInventoryDetailEntity>();
                    entity.Drug = model.Mapper<DrugEntity>();
                    result.Add(entity);
                }
            }
            else
            {
                var models = DBHelper.Instance.HIS.From<View_OutPharmacyReceiptDetail>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
                foreach (var model in models)
                {
                    var entity = model.Mapper<PharmacyInOutInventoryDetailEntity>();
                    entity.Drug = model.Mapper<DrugEntity>();
                    result.Add(entity);
                }
            }

            return result;
        }

        /// <summary>
        /// 获取指定入库单的审核状态
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public bool GetAuditStatus(long receiptId)
        {
            try
            {
                return DBHelper.Instance.HIS.From<Drug_PharmacyReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DataStatus == (int)DataStatus.Enable).Select(p => p.AuditStatus).ToScalar<bool>();
            }
            catch
            {
                return true;
            }
        }
        /// <summary>
        /// 删除指定单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        [Log("删除指定单据")]
        public DataResult DeleteReceipt(long receiptId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    var deleteTime = DBHelper.Instance.ServerTime;

                    var delete = AuditionHelper.GetDeletionValues<Drug_PharmacyReceipt>(deleteTime);
                    var deleteDetail = AuditionHelper.GetDeletionValues<Drug_PharmacyReceiptDetail>(deleteTime);

                    tran.Update<Drug_WarehouseReceipt>(delete, p => p.Id == receiptId);
                    tran.Update<Drug_WarehouseReceiptDetail>(deleteDetail, p => p.ReceiptId == receiptId);

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
        /// 删除指定单据明细
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        public DataResult DeleteInOutReceiptDetail(long detailId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Drug_PharmacyReceiptDetail>(p => p.Id == detailId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 更新指定单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="newDetails"></param>
        /// <param name="updateDetails"></param>
        /// <returns></returns>
        public DataResult UpdateInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> newDetails, List<PharmacyInOutInventoryDetailEntity> updateDetails)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //更新入库单据主表
                        var modifyReceipt = AuditionHelper.GetModificationValues<Drug_PharmacyReceipt>();
                        modifyReceipt[Drug_PharmacyReceipt._.TotalPrice] = receipt.Total;

                        batch.Update<Drug_PharmacyReceipt>(modifyReceipt, new WhereClip(Drug_PharmacyReceipt._.Id, receipt.Id, QueryOperator.Equal));

                        int no = tran.From<Drug_PharmacyReceiptDetail>().Where(p => p.ReceiptId == receipt.Id).Select(Drug_PharmacyReceiptDetail._.No.Max()).ToScalar<int>() + 1;
                        foreach (var receiptDetailEntity in newDetails)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_PharmacyReceiptDetail>().SetCreationValues();
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
                            var modifyDetail = AuditionHelper.GetModificationValues<Drug_PharmacyReceiptDetail>();
                            modifyDetail[Drug_PharmacyReceiptDetail._.Quantity] = receiptDetailEntity.Quantity;
                            modifyDetail[Drug_PharmacyReceiptDetail._.Price] = receiptDetailEntity.Price;

                            batch.Update<Drug_PharmacyReceiptDetail>(modifyDetail, new WhereClip(Drug_PharmacyReceiptDetail._.Id, receiptDetailEntity.Id, QueryOperator.Equal));
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

        #region 入库操作
        /// <summary>
        /// 增加入库单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <returns></returns>
        public DataResult AddInInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> detailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        Internal.InternalPharmacyInOutInventoryService.Instance.AddInOutInventoryReceipt(_idService, receipt, detailEntities, PharmacyInOutReceiptType.入库, batch);

                        var result = Internal.InternalInvoiceService.Instance.ReleaseInvoice(InvoiceType.药房申请药品, tran);
                        if (!result.Success)
                        {
                            tran.Rollback();
                            return result;
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
        /// 获取入库可以检索的药品列表
        /// </summary>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllDrugInfoCanIn(long deptId)
        {
            var models = DBHelper.Instance.HIS.From<View_WarehouseDrugInventory>().Where(p => p.DeptId == deptId).ToList();
            return models.Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public DataResult<DateTime> AuditInReceipt(long receiptId, long sourceDeptId, long targetDeptId)
        {
            try
            {
                var auditTime = DBHelper.Instance.ServerTime;
                var dt = DBHelper.Instance.HIS.FromProc("Proc_PharmacyInInventoryAudit")
                                              .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                              .AddInParameter("@SourceDeptId", System.Data.DbType.Int64, sourceDeptId)
                                              .AddInParameter("@TargetDeptId", System.Data.DbType.Int64, targetDeptId)
                                              .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
                                              .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                              .AddInParameter("@OperationTime", System.Data.DbType.DateTime, auditTime)
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
        /// 取消审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult CancelAuditInReceipt(long receiptId, long sourceDeptId, long targetDeptId)
        {
            //            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            //            {
            //                try
            //                {
            //                    #region 先判断单据销售价和库存销售价是否一致
            //                    string checkDifferentSql = @"
            //select b.Name,a.Price as ReceiptPrice,b.BigPackagePrice as InventoryPrice from Drug_PharmacyReceiptDetail a
            //inner join Drug_PharmacyInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Price!=b.BigPackagePrice
            //where a.HosId=@HosId and b.HosId=@HosId and b.DeptId=@DeptId and a.ReceiptId=@ReceiptId
            //";
            //                    //判断入库单据中的明细和库存中的明细 ,单价是否一致
            //                    var differentPrice = tran.FromSql(checkDifferentSql)
            //                                             .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                                             .AddInParameter("@DeptId", System.Data.DbType.Int64, targetDeptId)
            //                                             .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                             .ToDataTable();

            //                    if (differentPrice.Rows.Count != 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("入库的药品中,有部分药品的单价和入库单单价不同,无法取消审核" + Environment.NewLine);
            //                        foreach (DataRow item in differentPrice.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药库库存单价:{item["InventoryPrice"]},入库单单价:{item["ReceiptPrice"]}");
            //                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    #region 再判断库存是否大于入库单中的数量

            //                    checkDifferentSql = @"
            //select b.Name,b.BigPackageQuantity as InventoryQuantity,a.Quantity as ReceiptQuantity from Drug_PharmacyReceiptDetail a
            //inner join Drug_PharmacyInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Quantity>b.BigPackageQuantity
            //where b.DeptId=@DeptId and a.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    var differentQuantity = tran.FromSql(checkDifferentSql)
            //                                                .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                                                .AddInParameter("@DeptId", DbType.Int64, targetDeptId)
            //                                                .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                                .ToDataTable();
            //                    if (differentQuantity.Rows.Count > 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("药房的库存中,因为有部分药品库存不够,导致无法退回" + Environment.NewLine);
            //                        foreach (DataRow item in differentQuantity.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药房库存:{item["InventoryQuantity"]},入库单数量:{item["ReceiptQuantity"]}");
            //                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    #region 更新药房库存

            //                    string updateInventory = @"
            //update a set a.BigPackageQuantity=a.BigPackageQuantity-b.Quantity from Drug_PharmacyInventory a inner join Drug_PharmacyReceiptDetail b on
            //a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode
            //where a.DeptId=@DeptId and b.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    tran.FromSql(updateInventory)
            //                        .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                        .AddInParameter("@DeptId", DbType.Int64, targetDeptId)
            //                        .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                        .ExecuteNonQuery();
            //                    #endregion

            //                    #region 更新药库库存

            //                    string updateWarehouseInventorySql = @"
            //update a set a.Quantity=a.Quantity+b.Quantity from Drug_WarehouseInventory a 
            //inner join Drug_PharmacyReceiptDetail b on a.ClassCode=b.ClassCode and a.SpecificationCode=b.SpecificationCode
            //where a.DeptId=@SourceDeptId and b.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    tran.FromSql(updateWarehouseInventorySql)
            //                        .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                        .AddInParameter("@SourceDeptId", DbType.Int64, sourceDeptId)
            //                        .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                        .ExecuteNonQuery();
            //                    #endregion

            //                    //删除药房入库记录
            //                    tran.Delete<Drug_PharmacyInInventory>(p => p.ReceiptType == (int)PharmacyInInventoryType.进货 && p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
            //                    //删除药库出库记录
            //                    tran.Delete<Drug_WarehouseOutInventory>(p => p.ReceiptType == (int)WarehouseOutInventoryType.药房申领 && p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

            //                    var modify = AuditionHelper.GetModificationValues<Drug_PharmacyReceipt>();
            //                    modify[Drug_PharmacyReceipt._.AuditStatus] = false;
            //                    modify[Drug_PharmacyReceipt._.AuditTime] = null;
            //                    modify[Drug_PharmacyReceipt._.AuditUserId] = null;

            //                    tran.Update<Drug_PharmacyReceipt>(modify, p => p.Id == receiptId);

            //                    tran.Commit();
            //                    return DataResult.True();
            //                }
            //                catch (Exception ex)
            //                {
            //                    tran.Rollback();
            //                    return DataResult.Fault(ex.Message);
            //                }
            //            }
            try
            {
                var dt = DBHelper.Instance.HIS.FromProc("Proc_PharmacyInInventoryCancelAudit")
                                          .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@SourceDeptId", DbType.Int64, sourceDeptId)
                                          .AddInParameter("@TargetDeptId", DbType.Int64, targetDeptId)
                                          .AddInParameter("@OperationUserId", DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
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

        #endregion

        #region 出库操作
        /// <summary>
        /// 增加出库单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <returns></returns>
        public DataResult AddOutInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> detailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        Internal.InternalPharmacyInOutInventoryService.Instance.AddInOutInventoryReceipt(_idService, receipt, detailEntities, PharmacyInOutReceiptType.退库, batch);

                        var result = Internal.InternalInvoiceService.Instance.ReleaseInvoice(InvoiceType.药房退库, tran);
                        if (!result.Success)
                        {
                            tran.Rollback();
                            return result;
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
        /// 获取出库可以检索的药品列表
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllDrugInfoCanOut(long deptId)
        {
            var models = DBHelper.Instance.HIS.From<View_PharmacyDrugInventory>().Where(p => p.DeptId == deptId).ToList();
            return models.Mapper<List<DrugInventoryEntity>>();
        }
        /// <summary>
        /// 审核退库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="sourceDeptId"></param>
        /// <param name="targetDeptId"></param>
        /// <returns></returns>
        public DataResult<DateTime> AuditOutReceipt(long receiptId, long sourceDeptId, long targetDeptId)
        {
            //            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            //            {
            //                try
            //                {
            //                    #region 检查药房库存是否足够
            //                    string differentSql = @"
            //select b.Name,a.Quantity as ReceiptQuantity,b.BigPackageQuantity as Inventory from Drug_PharmacyReceiptDetail a
            //left join Drug_PharmacyInventory b on a.ClassCode=b.ClassCode and a.SpecificationCode=b.SpecificationCode and a.Quantity>b.BigPackageQuantity
            //where a.HosId=@HosId and b.HosId=@HosId and b.DataStatus=1 and b.DeptId=@SourceDeptId
            //";

            //                    var dt = tran.FromSql(differentSql)
            //                                 .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                 .AddInParameter("@SourceDeptId", System.Data.DbType.Int64, sourceDeptId)
            //                                 .ToDataTable();

            //                    if (dt.Rows.Count > 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("退库的药品中,有部分药品在药房中的库存不足" + Environment.NewLine);
            //                        foreach (DataRow item in dt.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,计划退库数量:{item["ReceiptQuantity"]},药房剩余库存:{item["Inventory"]}");
            //                        return DataResult.Fault<DateTime>(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    #region 检查单据销售价和库存销售价是否一致
            //                    string checkDifferentSql = @"
            //select b.Name,a.Price as ReceiptPrice,b.BigPackagePrice as InventoryPrice from Drug_PharmacyReceiptDetail a
            //inner join Drug_PharmacyInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Price!=b.BigPackagePrice
            //where a.HosId=@HosId and b.HosId=@HosId and b.DeptId=@DeptId and a.ReceiptId=@ReceiptId
            //";
            //                    //判断入库单据中的明细和库存中的明细 ,单价是否一致
            //                    var differentPrice = tran.FromSql(checkDifferentSql)
            //                                             .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                                             .AddInParameter("@DeptId", System.Data.DbType.Int64, sourceDeptId)
            //                                             .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                             .ToDataTable();

            //                    if (differentPrice.Rows.Count != 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("退库的药品中,有部分药品的单价和退库单单价不同,无法取消审核" + Environment.NewLine);
            //                        foreach (DataRow item in differentPrice.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药库库存单价:{item["InventoryPrice"]},退库单单价:{item["ReceiptPrice"]}");
            //                        return DataResult.Fault<DateTime>(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    var auditTime = DBHelper.Instance.ServerTime;
            //                    var modify = AuditionHelper.GetModificationValues<Drug_PharmacyReceipt>();
            //                    modify[Drug_PharmacyReceipt._.AuditStatus] = true;
            //                    modify[Drug_PharmacyReceipt._.AuditTime] = auditTime;
            //                    modify[Drug_PharmacyReceipt._.AuditUserId] = App.Instance.User.Id;

            //                    tran.Update<Drug_PharmacyReceipt>(modify, p => p.Id == receiptId);

            //                    dt = tran.FromPro("Proc_PharmacyOutInventoryAudit")
            //                             .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                             .AddInParameter("@SourceDeptId", System.Data.DbType.Int64, sourceDeptId)
            //                             .AddInParameter("@TargetDeptId", System.Data.DbType.Int64, targetDeptId)
            //                             .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
            //                             .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                             .AddInParameter("@OperationTime", System.Data.DbType.DateTime, auditTime)
            //                             .ToDataTable();

            //                    if (dt.Rows[0][0].ToString() == "0")
            //                    {
            //                        tran.Rollback();
            //                        return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());
            //                    }

            //                    tran.Commit();
            //                    return DataResult.True(auditTime);
            //                }
            //                catch (Exception ex)
            //                {
            //                    tran.Rollback();
            //                    return DataResult.Fault<DateTime>(ex.Message);
            //                }
            //            }

            var auditTime = DBHelper.Instance.ServerTime;

            var dt = DBHelper.Instance.HIS.FromProc("Proc_PharmacyOutInventoryAudit")
                                          .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@SourceDeptId", System.Data.DbType.Int64, sourceDeptId)
                                          .AddInParameter("@TargetDeptId", System.Data.DbType.Int64, targetDeptId)
                                          .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                          .AddInParameter("@OperationTime", System.Data.DbType.DateTime, auditTime)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault<DateTime>(dt.Rows[0][1].ToString());
            return DataResult.True(auditTime);
        }
        /// <summary>
        /// 取消审核出库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public DataResult CancelAuditOutReceipt(long receiptId, long sourceDeptId, long targetDeptId)
        {
            //            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            //            {
            //                try
            //                {
            //                    #region 先判断单据销售价和库存销售价是否一致
            //                    string checkDifferentSql = @"
            //select b.Name,a.Price as ReceiptPrice,b.BigPackagePrice as InventoryPrice from Drug_PharmacyReceiptDetail a
            //inner join Drug_PharmacyInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Price!=b.BigPackagePrice
            //where a.HosId=@HosId and b.HosId=@HosId and b.DeptId=@DeptId and a.ReceiptId=@ReceiptId
            //";
            //                    //判断入库单据中的明细和库存中的明细 ,单价是否一致
            //                    var differentPrice = tran.FromSql(checkDifferentSql)
            //                                             .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                                             .AddInParameter("@DeptId", System.Data.DbType.Int64, sourceDeptId)
            //                                             .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                             .ToDataTable();

            //                    if (differentPrice.Rows.Count != 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("入库的药品中,有部分药品的单价和出库单单价不同,无法取消审核" + Environment.NewLine);
            //                        foreach (DataRow item in differentPrice.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药库库存单价:{item["InventoryPrice"]},出库单单价:{item["ReceiptPrice"]}");
            //                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    #region 再判断库存是否大于入库单中的数量

            //                    checkDifferentSql = @"
            //select b.Name,b.Quantity as InventoryQuantity,a.Quantity as ReceiptQuantity from Drug_PharmacyReceiptDetail a
            //inner join Drug_WarehouseInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Quantity>b.Quantity
            //where b.DeptId=@DeptId and a.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    var differentQuantity = tran.FromSql(checkDifferentSql)
            //                                                .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                                                .AddInParameter("@DeptId", DbType.Int64, targetDeptId)
            //                                                .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                                .ToDataTable();
            //                    if (differentQuantity.Rows.Count > 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("药库的库存中,因为有部分药品库存不够,导致无法退回" + Environment.NewLine);
            //                        foreach (DataRow item in differentQuantity.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药库库存:{item["InventoryQuantity"]},入库单数量:{item["ReceiptQuantity"]}");
            //                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
            //                    }
            //                    #endregion

            //                    #region 更新药房库存

            //                    string updateInventory = @"
            //update a set a.BigPackageQuantity=a.BigPackageQuantity+abs(b.Quantity) from Drug_PharmacyInventory a 
            //inner join Drug_PharmacyReceiptDetail b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode
            //where a.DeptId=@DeptId and b.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    tran.FromSql(updateInventory)
            //                        .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                        .AddInParameter("@DeptId", DbType.Int64, sourceDeptId)
            //                        .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                        .ExecuteNonQuery();
            //                    #endregion

            //                    #region 更新药库库存

            //                    string updateWarehouseInventorySql = @"
            //update a set a.Quantity=a.Quantity-abs(b.Quantity) from Drug_WarehouseInventory a 
            //inner join Drug_PharmacyReceiptDetail b on a.ClassCode=b.ClassCode and a.SpecificationCode=b.SpecificationCode
            //where a.DeptId=@SourceDeptId and b.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
            //";
            //                    tran.FromSql(updateWarehouseInventorySql)
            //                        .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
            //                        .AddInParameter("@SourceDeptId", DbType.Int64, targetDeptId)
            //                        .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                        .ExecuteNonQuery();
            //                    #endregion

            //                    //删除药房出库记录
            //                    tran.Delete<Drug_PharmacyOutInventory>(p => p.ReceiptType == (int)PharmacyOutInventoryType.退库 && p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
            //                    //删除药库入库记录
            //                    tran.Delete<Drug_WarehouseInInventory>(p => p.ReceiptType == (int)WarehouseInInventoryType.药房退库 && p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

            //                    var modify = AuditionHelper.GetModificationValues<Drug_PharmacyReceipt>();
            //                    modify[Drug_PharmacyReceipt._.AuditStatus] = false;
            //                    modify[Drug_PharmacyReceipt._.AuditTime] = null;
            //                    modify[Drug_PharmacyReceipt._.AuditUserId] = null;

            //                    tran.Update<Drug_PharmacyReceipt>(modify, p => p.Id == receiptId);

            //                    tran.Commit();
            //                    return DataResult.True();
            //                }
            //                catch (Exception ex)
            //                {
            //                    tran.Rollback();
            //                    return DataResult.Fault(ex.Message);
            //                }
            //            }

            var dt = DBHelper.Instance.HIS.FromProc("Proc_PharmacyOutInventoryCancelAudit")
                                          .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                          .AddInParameter("@SourceDeptId", System.Data.DbType.Int64, sourceDeptId)
                                          .AddInParameter("@TargetDeptId", System.Data.DbType.Int64, targetDeptId)
                                          .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
                                          .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                          .ToDataTable();

            if (dt.Rows[0][0].ToString() == "0")
                return DataResult.Fault(dt.Rows[0][1].ToString());
            return DataResult.True();
        }
        #endregion
    }
}
