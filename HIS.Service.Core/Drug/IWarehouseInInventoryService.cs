using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-15 09:53:35
    /// 描述:
    /// </summary>
    public interface IWarehouseInOutInventoryService : IServiceSingleton
    {
        /// <summary>
        /// 获取药库入出库单据
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<WarehouseInOutInventoryReceiptEntitiy> GetWarehouseInOutReceipt(long deptId, WarehouseInOutReceiptType type, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取药库入出库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        WarehouseInOutInventoryReceiptEntitiy GetWarehouseInOutReceipt(long receiptId);
        /// <summary>
        /// 获取药库入出库单据明细
        /// </summary>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        List<WarehouseInOutInventoryReceiptDetailEntitiy> GetWarehouseInOutReceiptDetail(long receiptId);

        /// <summary>
        /// 删除入出库单据明细
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        DataResult DeleteInOutReceiptDetail(long detailId);
        /// <summary>
        /// 增加入库单
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <param name="receiptDetailEntities"></param>
        /// <returns></returns>
        DataResult AddInInventoryReceipt(WarehouseInOutInventoryReceiptEntitiy receiptEntity, List<WarehouseInOutInventoryReceiptDetailEntitiy> receiptDetailEntities);
        /// <summary>
        /// 增加或者更新入库单
        /// </summary>
        /// <param name="receiptEntity"></param>
        /// <param name="newDetailEntities"></param>
        /// <param name="updateDetailEntities"></param>
        /// <returns></returns>
        DataResult UpdateInInventoryReceipt(WarehouseInOutInventoryReceiptEntitiy receiptEntity, List<WarehouseInOutInventoryReceiptDetailEntitiy> newDetailEntities, List<WarehouseInOutInventoryReceiptDetailEntitiy> updateDetailEntities);

        /// <summary>
        /// 获取指定入库单的审核状态
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        bool GetAuditStatus(long receiptId);
        /// <summary>
        /// 删除指定单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        DataResult DeleteReceipt(long receiptId);
        /// <summary>
        /// 获取入库可以检索的药品信息
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllDrugInfoCanIn(DrugType drugType, long deptId);
        /// <summary>
        /// 审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditInReceipt(long receiptId, long deptId);
        /// <summary>
        /// 取消审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditInReceipt(long receiptId, long deptId);
    }
}
