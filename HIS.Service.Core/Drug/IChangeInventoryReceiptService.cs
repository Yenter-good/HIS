using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Enums;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 15:05:09
    /// 描述:
    /// </summary>
    public interface IChangeInventoryReceiptService : IServiceSingleton
    {
        /// <summary>
        /// 增加药库库存变更单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        DataResult AddWarehouseChangeInventoryReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> detailEntities);
        /// <summary>
        /// 增加药房库存变更单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        DataResult AddPharmacyChangeInventoryReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> detailEntities);
        /// <summary>
        /// 获取库存变更单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        List<ChangeInventoryReceiptEntity> GetReceipt(long deptId, ChangeInventoryType? type, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取药房入出库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        ChangeInventoryReceiptEntity GetReceipt(long receiptId);
        /// <summary>
        /// 获取药库入出库单据明细
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        List<ChangeInventoryReceiptDetailEntity> GetReceiptDetail(long receiptId);
        /// <summary>
        /// 获取药库所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetWarehouseAllDrugInfo(long deptId);
        /// <summary>
        /// 获取药房所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetPharmacyAllDrugInfo(long deptId);
        /// <summary>
        /// 获取审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool GetAuditStatus(long receiptId);
        /// <summary>
        /// 删除指定单据明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult DeleteReceiptDetail(long detailId);
        /// <summary>
        /// 删除指定单据
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        DataResult DeleteReceipt(long receiptId);
        /// <summary>
        /// 更新单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="newDetails"></param>
        /// <param name="updateDetails"></param>
        /// <returns></returns>
        DataResult UpdateReceipt(ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> newDetails, List<ChangeInventoryReceiptDetailEntity> updateDetails);
        /// <summary>
        /// 审核药库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditWarehouseReceipt(long receiptId, long deptId, ChangeInventoryType receiptType);
        /// <summary>
        /// 取消审核药库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditWarehouseReceipt(long receiptId, long deptId, ChangeInventoryType receiptType);
        /// <summary>
        /// 审核药房单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditPharmacyReceipt(long receiptId, long deptId, ChangeInventoryType receiptType);
        /// <summary>
        /// 取消审核药房单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditPharmacyReceipt(long receiptId, long deptId, ChangeInventoryType receiptType);
    }
}
