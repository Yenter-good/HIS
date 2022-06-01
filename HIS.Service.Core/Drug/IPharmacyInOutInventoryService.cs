using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IPharmacyInOutInventoryService : IServiceSingleton
    {

        /// <summary>
        /// 获取药房入出库单据
        /// </summary>
        /// <param name="acceptDeptId"></param>
        /// <param name="applyDeptId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        List<PharmacyInOutInventoryEntity> GetPharmacyInOutReceipt(long deptId, PharmacyInOutReceiptType type, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取药房入出库单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        PharmacyInOutInventoryEntity GetPharmacyInOutReceipt(long receiptId);
        /// <summary>
        /// 获取向指定科室申请的药房申请单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        List<PharmacyInOutInventoryEntity> GetApplyPharmacyInReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取药库入出库单据明细
        /// </summary>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        List<PharmacyInOutInventoryDetailEntity> GetPharmacyInOutReceiptDetail(long receiptId, PharmacyInOutReceiptType receiptType);
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
        /// 删除指定单据明细
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        DataResult DeleteInOutReceiptDetail(long detailId);

        /// <summary>
        /// 更新指定单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="newDetails"></param>
        /// <param name="updateDetails"></param>
        /// <returns></returns>
        DataResult UpdateInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> newDetails, List<PharmacyInOutInventoryDetailEntity> updateDetails);
        /// <summary>
        /// 增加入库单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <returns></returns>
        DataResult AddInInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> detailEntities);
        /// <summary>
        /// 获取入库可以检索的药品列表
        /// </summary>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllDrugInfoCanIn(long deptId);
        /// <summary>
        /// 审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditInReceipt(long receiptId, long sourceDeptId, long targetDeptId);
        /// <summary>
        /// 取消审核入库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditInReceipt(long receiptId, long sourceDeptId, long targetDeptId);
        /// <summary>
        /// 增加出库单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <returns></returns>
        DataResult AddOutInventoryReceipt(PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> detailEntities);
        /// <summary>
        /// 获取出库可以检索的药品列表
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllDrugInfoCanOut(long deptId);
        /// <summary>
        /// 审核退库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="sourceDeptId"></param>
        /// <param name="targetDeptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditOutReceipt(long receiptId, long sourceDeptId, long targetDeptId);
        /// <summary>
        /// 取消审核出库单
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditOutReceipt(long receiptId, long sourceDeptId, long targetDeptId);
    }
}
