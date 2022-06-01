using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-23 15:51:48
    /// 描述:
    /// </summary>
    public interface IDrugTransferService : IServiceSingleton
    {
        /// <summary>
        /// 增加调拨单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="detailEntities"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        DataResult AddTransferReceipt(DrugTransferReceipt receipt, List<DrugTransferDetailEntity> detailEntities);
        /// <summary>
        /// 获取申请的调拨单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param> 
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        List<DrugTransferReceipt> GetApplyReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取接受的调拨单据
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="receiptCode"></param>
        /// <returns></returns>
        List<DrugTransferReceipt> GetAcceptReceipt(long deptId, DateTime startTime, DateTime endTime, string receiptCode = "");
        /// <summary>
        /// 获取调拨单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns></returns>
        DrugTransferReceipt GetReceipt(long receiptId);
        /// <summary>
        /// 获取调拨单据明细
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="type">0药库 1药房</param>
        /// <returns></returns>
        List<DrugTransferDetailEntity> GetReceiptDetail(long receiptId, int type);
        /// <summary>
        /// 获取所有可以检索的药品
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllDrugInfo(long deptId, int type);
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
        DataResult UpdateReceipt(DrugTransferReceipt receipt, List<DrugTransferDetailEntity> newDetails, List<DrugTransferDetailEntity> updateDetails);
        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="receiptId"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult<DateTime> AuditWarehouseReceipt(long receiptId, long applyDeptId, long acceptDeptId, int deptType);
        /// <summary>
        /// 取消审核单据
        /// </summary>
        /// <param name="receiptId"></param>    
        /// <param name="deptId"></param>
        /// <returns></returns>
        DataResult CancelAuditWarehouseReceipt(long receiptId, long applyDeptId, long acceptDeptId, int deptType);
    }
}
