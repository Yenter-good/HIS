using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
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

namespace HIS.Service
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-15 09:54:25
    /// 描述:
    /// </summary>
    public class WarehouseInOutInventoryService : IWarehouseInOutInventoryService
    {
        private readonly IIdService _idService;

        public WarehouseInOutInventoryService(IIdService idService)
        {
            this._idService = idService;
        }

        /// <summary>
        /// 获取药库入出库单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public List<WarehouseInOutInventoryReceiptEntitiy> GetWarehouseInOutReceipt(long deptId, WarehouseInOutReceiptType type, DateTime startTime, DateTime endTime, string receiptCode = "")
        {
            if (receiptCode == "")
                return DBHelper.Instance.HIS.From<View_WarehouseReceipt>().Where(p => p.DeptId == deptId && p.ReceiptType == (int)type && p.CreationTime >= startTime.Start() && p.CreationTime <= endTime.End() && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderByDescending(p => p.CreationTime).ToList().Mapper<List<WarehouseInOutInventoryReceiptEntitiy>>();
            else
                return DBHelper.Instance.HIS.From<View_WarehouseReceipt>().Where(p => p.DeptId == deptId && p.ReceiptType == (int)type && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.ReceiptCode == receiptCode).OrderByDescending(p => p.CreationTime).ToList().Mapper<List<WarehouseInOutInventoryReceiptEntitiy>>();
        }
        /// <summary>
        /// 获取药库入出库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public WarehouseInOutInventoryReceiptEntitiy GetWarehouseInOutReceipt(long receiptId)
        {
            return DBHelper.Instance.HIS.From<View_WarehouseReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<WarehouseInOutInventoryReceiptEntitiy>();
        }
        /// <summary>
        /// 获取药库入出库单据明细
        /// </summary>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        public List<WarehouseInOutInventoryReceiptDetailEntitiy> GetWarehouseInOutReceiptDetail(long receiptId)
        {
            var models = DBHelper.Instance.HIS.From<View_WarehouseReceiptDetail>().Where(p => p.ReceiptId == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).OrderBy(p => p.No).ToList();
            List<WarehouseInOutInventoryReceiptDetailEntitiy> result = new List<WarehouseInOutInventoryReceiptDetailEntitiy>();
            foreach (var model in models)
            {
                var entity = model.Mapper<WarehouseInOutInventoryReceiptDetailEntitiy>();
                entity.Drug = model.Mapper<DrugEntity>();
                result.Add(entity);
            }

            return result;
        }
        /// <summary>
        /// 删除入出库单据明细
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataResult DeleteInOutReceiptDetail(long detailId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Drug_WarehouseReceiptDetail>(p => p.Id == detailId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 增加入库单
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <param name="receiptDetailEntities"></param>
        /// <returns></returns>
        public DataResult AddInInventoryReceipt(WarehouseInOutInventoryReceiptEntitiy receiptEntity, List<WarehouseInOutInventoryReceiptDetailEntitiy> receiptDetailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //插入入库单据主表
                        var insertReceipt = receiptEntity.Mapper<Drug_WarehouseReceipt>().SetCreationValues();
                        receiptEntity.CreateUser = new UserEntity() { Name = App.Instance.User.UserName };
                        receiptEntity.CreationTime = insertReceipt.CreationTime;
                        receiptEntity.Id = _idService.CreateUUID();
                        insertReceipt.Id = receiptEntity.Id;
                        insertReceipt.AuditTime = null;
                        insertReceipt.AuditStatus = false;
                        insertReceipt.ReceiptType = (int)WarehouseInOutReceiptType.入库单;
                        insertReceipt.No = 0;

                        batch.Insert(insertReceipt);

                        int no = 0;
                        foreach (var receiptDetailEntity in receiptDetailEntities)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_WarehouseReceiptDetail>().SetCreationValues();
                            receiptDetailEntity.Id = _idService.CreateUUID();
                            insertDetail.Id = receiptDetailEntity.Id;
                            insertDetail.No = no;
                            insertDetail.Production = receiptDetailEntity.Drug.Manufacturer.AsString("");
                            insertDetail.ReceiptId = receiptEntity.Id;
                            batch.Insert(insertDetail);

                            no++;
                        }

                        var result = Internal.InternalInvoiceService.Instance.ReleaseInvoice(InvoiceType.药库入库单据, tran);
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
        /// 增加或者更新入库单
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <param name="newDetailEntities"></param>
        /// <param name="updateDetailEntities"></param>
        /// <returns></returns>
        public DataResult UpdateInInventoryReceipt(WarehouseInOutInventoryReceiptEntitiy receiptEntity, List<WarehouseInOutInventoryReceiptDetailEntitiy> newDetailEntities, List<WarehouseInOutInventoryReceiptDetailEntitiy> updateDetailEntities)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    using (var batch = DBHelper.Instance.HIS.BeginBatchConnection(20, tran))
                    {
                        //插入入库单据主表
                        var modifyReceipt = AuditionHelper.GetModificationValues<Drug_WarehouseReceipt>();
                        modifyReceipt[Drug_WarehouseReceipt._.ReceiptCode] = receiptEntity.ReceiptCode;
                        modifyReceipt[Drug_WarehouseReceipt._.InvoiceNo] = receiptEntity.InvoiceNo;
                        modifyReceipt[Drug_WarehouseReceipt._.TotalPrice] = receiptEntity.Total;
                        modifyReceipt[Drug_WarehouseReceipt._.SupplyUnit] = receiptEntity.SupplyUnit;

                        batch.Update<Drug_WarehouseReceipt>(modifyReceipt, new WhereClip(Drug_WarehouseReceipt._.Id, receiptEntity.Id, QueryOperator.Equal));

                        int no = tran.From<Drug_WarehouseReceiptDetail>().Where(p => p.ReceiptId == receiptEntity.Id).Select(Drug_WarehouseReceiptDetail._.No.Max()).ToScalar<int>() + 1;
                        foreach (var receiptDetailEntity in newDetailEntities)
                        {
                            //插入入库单据明细表
                            var insertDetail = receiptDetailEntity.Mapper<Drug_WarehouseReceiptDetail>().SetCreationValues();
                            receiptDetailEntity.Id = _idService.CreateUUID();
                            insertDetail.Id = receiptDetailEntity.Id;
                            insertDetail.No = no;
                            insertDetail.Production = receiptDetailEntity.Drug.Manufacturer.AsString("");
                            insertDetail.ReceiptId = receiptEntity.Id;
                            batch.Insert(insertDetail);

                            no++;
                        }

                        foreach (var receiptDetailEntity in updateDetailEntities)
                        {
                            var modifyDetail = AuditionHelper.GetModificationValues<Drug_WarehouseReceiptDetail>();
                            modifyDetail[Drug_WarehouseReceiptDetail._.Quantity] = receiptDetailEntity.Quantity;
                            modifyDetail[Drug_WarehouseReceiptDetail._.PurchasePrice] = receiptDetailEntity.PurchasePrice;
                            modifyDetail[Drug_WarehouseReceiptDetail._.Price] = receiptDetailEntity.Price;
                            modifyDetail[Drug_WarehouseReceiptDetail._.BatchNumber] = receiptDetailEntity.BatchNumber;
                            modifyDetail[Drug_WarehouseReceiptDetail._.Memo] = receiptDetailEntity.Memo;

                            batch.Update<Drug_WarehouseReceiptDetail>(modifyDetail, new WhereClip(Drug_WarehouseReceiptDetail._.Id, receiptDetailEntity.Id, QueryOperator.Equal));
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
        /// 获取指定入库单的审核状态
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public bool GetAuditStatus(long receiptId)
        {
            try
            {
                return DBHelper.Instance.HIS.From<Drug_WarehouseReceipt>().Where(p => p.Id == receiptId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).Select(p => p.AuditStatus).ToScalar<bool>();
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
        [Log(Action = "删除指定单据")]
        public DataResult DeleteReceipt(long receiptId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    var delete = AuditionHelper.GetDeletionValues<Drug_WarehouseReceipt>();
                    var deleteDetail = AuditionHelper.GetDeletionValues<Drug_WarehouseReceiptDetail>();

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

        #region 入库操作

        /// <summary>
        /// 获取入库可以检索的药品信息
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public List<DrugInventoryEntity> GetAllDrugInfoCanIn(DrugType drugType, long deptId)
        {
            //获取所有药典信息
            var models = DBHelper.Instance.HIS.From<View_WarehouseDrugInfo>().Where(p => p.DrugType == (int)drugType && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                  .Select(View_WarehouseDrugInfo._.DrugName, View_WarehouseDrugInfo._.Specification, View_WarehouseDrugInfo._.Manufacturer, View_WarehouseDrugInfo._.ApprovalNumber, View_WarehouseDrugInfo._.ClassCode, View_WarehouseDrugInfo._.SpecificationCode, View_WarehouseDrugInfo._.SearchCode, View_WarehouseDrugInfo._.TradeName, View_WarehouseDrugInfo._.WubiCode).OrderBy(View_WarehouseDrugInfo._.DrugName, View_WarehouseDrugInfo._.TradeNameLength).ToList();

            //获取指定科室的库存信息
            var inventory = DBHelper.Instance.HIS.From<Drug_WarehouseInventory>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DeptId == deptId).Select(Drug_WarehouseInventory._.ClassCode, Drug_WarehouseInventory._.SpecificationCode, Drug_WarehouseInventory._.Quantity, Drug_WarehouseInventory._.Price, Drug_WarehouseInventory._.PurchasePrice).ToList();

            var result = models.Mapper<List<DrugEntity>>().Mapper<List<DrugInventoryEntity>>();

            //将库存信息附加到返回值内
            foreach (var item in inventory)
            {
                var match = result.Find(p => p.ClassCode == item.ClassCode && p.SpecificationCode == item.SpecificationCode);
                if (match != null)
                {
                    match.BigPackageQuantity = item.Quantity;
                    match.PurchasePrice = item.PurchasePrice;
                    match.BigPackagePrice = item.Price;
                }
            }

            return result;
        }
        /// <summary>
        /// 审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        public DataResult<DateTime> AuditInReceipt(long receiptId, long deptId)
        {
            //            string checkDifferentSql = @"
            //select b.Name, b.Price as OldPrice, a.Price as NewPrice from Drug_WarehouseReceiptDetail a
            //inner join Drug_WarehouseInventory b on a.SpecificationCode = b.SpecificationCode and a.ClassCode = b.ClassCode and a.Price != b.Price
            //where b.DeptId = @DeptId and a.ReceiptId = @ReceiptId and a.HosId=@HosId
            //";

            //            //审核单据
            //            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            //            {
            //                try
            //                {
            //                    //判断入库单据中的明细和库存中的明细 ,单价是否一致,不一致则要求生成调价单
            //                    var differentPrice = tran.FromSql(checkDifferentSql)
            //                                                              .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                                                              .AddInParameter("@DeptId", System.Data.DbType.Int64, deptId)
            //                                                              .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                                              .ToDataTable();

            //                    if (differentPrice.Rows.Count != 0)
            //                    {
            //                        List<string> errorText = new List<string>();
            //                        errorText.Add("入库的药品中,有部分药品的单价和库存单价不同,请先调价后再审核" + Environment.NewLine);
            //                        foreach (DataRow item in differentPrice.Rows)
            //                            errorText.Add($"药品名:<{item["Name"]}>,药库库存单价:{item["OldPrice"]},入库单单价:{item["NewPrice"]}");
            //                        return DataResult.Fault<DateTime>(string.Join(Environment.NewLine, errorText));
            //                    }

            //                    var auditTime = DBHelper.Instance.ServerTime;

            //                    var modify = AuditionHelper.GetModificationValues<Drug_WarehouseReceipt>();
            //                    modify[Drug_WarehouseReceipt._.AuditStatus] = true;
            //                    modify[Drug_WarehouseReceipt._.AuditTime] = auditTime;
            //                    modify[Drug_WarehouseReceipt._.AuditUserId] = App.Instance.User.Id;

            //                    tran.Update<Drug_WarehouseReceipt>(modify, p => p.Id == receiptId);

            //                    var dt = tran.FromPro("Proc_WarehouseInInventoryAudit")
            //                                 .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
            //                                 .AddInParameter("@DeptId", System.Data.DbType.Int64, deptId)
            //                                 .AddInParameter("@OperationUserId", System.Data.DbType.Int64, App.Instance.User.Id)
            //                                 .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
            //                                 .AddInParameter("@OperationTime", System.Data.DbType.DateTime, auditTime)
            //                                 .ToDataTable();

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
            try
            {
                var auditTime = DBHelper.Instance.ServerTime;

                var dt = DBHelper.Instance.HIS.FromProc("Proc_WarehouseInInventoryAudit")
                                              .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                              .AddInParameter("@DeptId", System.Data.DbType.Int64, deptId)
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
        public DataResult CancelAuditInReceipt(long receiptId, long deptId)
        {
            using (var tran = DBHelper.Instance.HIS.BeginTransaction())
            {
                try
                {
                    #region 取消审核前,先判断要取消审核的药品在库存中是否销售价一致

                    string checkDifferentSql = @"
select b.Name, b.Price as InventoryPrice, a.Price as ReceiptPrice from Drug_WarehouseReceiptDetail a
inner join Drug_WarehouseInventory b on a.SpecificationCode = b.SpecificationCode and a.ClassCode = b.ClassCode and a.Price != b.Price
where b.DeptId = @DeptId and a.ReceiptId = @ReceiptId and a.HosId=@HosId and b.HosId=@HosId
";
                    //判断入库单据中的明细和库存中的明细 ,单价是否一致,不一致则要求生成调价单
                    var differentPrice = tran.FromSql(checkDifferentSql)
                                             .AddInParameter("@ReceiptId", System.Data.DbType.Int64, receiptId)
                                             .AddInParameter("@DeptId", System.Data.DbType.Int64, deptId)
                                             .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                             .ToDataTable();

                    if (differentPrice.Rows.Count != 0)
                    {
                        List<string> errorText = new List<string>();
                        errorText.Add("入库的药品中,有部分药品的单价和库存单价不同,无法取消审核" + Environment.NewLine);
                        foreach (DataRow item in differentPrice.Rows)
                            errorText.Add($"药品名:<{item["Name"]}>,药库库存单价:{item["InventoryPrice"]},入库单单价:{item["ReceiptPrice"]}");
                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
                    }
                    #endregion

                    #region 在判断库存是否大于入库单中的数量

                    checkDifferentSql = @"
select b.Name,b.Quantity as InventoryQuantity,a.Quantity as ReceiptQuantity from Drug_WarehouseReceiptDetail a
inner join Drug_WarehouseInventory b on a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode and a.Quantity>b.Quantity
where b.DeptId=@DeptId and a.ReceiptId=@ReceiptId and a.HosId=@HosId and b.HosId=@HosId
";
                    var differentQuantity = tran.FromSql(checkDifferentSql)
                                                .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                                .AddInParameter("@DeptId", DbType.Int64, deptId)
                                                .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                                .ToDataTable();
                    if (differentQuantity.Rows.Count > 0)
                    {
                        List<string> errorText = new List<string>();
                        errorText.Add("药库的库存中,因为有部分药品库存不够,导致无法退回" + Environment.NewLine);
                        foreach (DataRow item in differentQuantity.Rows)
                            errorText.Add($"药品名:<{item["Name"]}>,药库库存:{item["InventoryQuantity"]},入库单数量:{item["ReceiptQuantity"]}");
                        return DataResult.Fault(string.Join(Environment.NewLine, errorText));
                    }
                    #endregion

                    string updateInventory = @"
update a set a.Quantity=a.Quantity-b.Quantity from Drug_WarehouseInventory a inner join Drug_WarehouseReceiptDetail b on
a.SpecificationCode=b.SpecificationCode and a.ClassCode=b.ClassCode
and a.HosId=b.HosId where a.DeptId=@DeptId and b.ReceiptId=@ReceiptId and a.HosId=@HosId
";
                    var dt = tran.FromSql(updateInventory)
                                 .AddInParameter("@ReceiptId", DbType.Int64, receiptId)
                                 .AddInParameter("@DeptId", DbType.Int64, deptId)
                                 .AddInParameter("@HosId", DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                                 .ExecuteNonQuery();

                    tran.Delete<Drug_WarehouseInInventory>(p => p.ReceiptId == receiptId);

                    var modify = AuditionHelper.GetModificationValues<Drug_WarehouseReceipt>();
                    modify[Drug_WarehouseReceipt._.AuditStatus] = false;
                    modify[Drug_WarehouseReceipt._.AuditTime] = null;
                    modify[Drug_WarehouseReceipt._.AuditUserId] = null;

                    tran.Update<Drug_WarehouseReceipt>(modify, p => p.Id == receiptId);

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

        #endregion
    }
}
