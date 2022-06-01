using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 药品调价单据服务接口
    /// </summary>
    public interface IPriceChangedReceiptService : IServiceSingleton
    {
        /// <summary>
        /// 获取调价单据
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns></returns>
        List<PriceChangedReceiptEntity> GetPriceChangedReceipt(long deptId, DateTime startTime, DateTime endTime);
        /// <summary>
        /// 获取调价单据
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="receiptCode">单据ID</param>
        /// <returns></returns>
        List<PriceChangedReceiptEntity> GetPriceChangedReceipt(long deptId, string receiptCode);
        /// <summary>
        /// 获取药库库存中的药品
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllWarehouseDrugInfo(DrugType drugType, long deptId);
        /// <summary>
        /// 获取药房库存中的药品
        /// </summary>
        /// <param name="drugType"></param>
        /// <param name="deptId"></param>
        /// <returns></returns>
        List<DrugInventoryEntity> GetAllPharmacyDrugInfo(DrugType drugType, long deptId);
        /// <summary>
        /// 删除药品调价单据明细
        /// </summary>
        /// <param name="detailIds">明细id</param>
        /// <returns></returns>
        DataResult DeletePriceChangedReceiptDetail(List<long> detailIds);
        /// <summary>
        /// 新增药品调价单
        /// </summary>
        /// <param name="receipt">药品调价单实体</param>
        /// <param name="receiptDetails">药品调价单明细</param>
        /// <returns></returns>
        DataResult AddPriceChangedReceipt(PriceChangedReceiptEntity receipt, List<PriceChangedReceiptDetailEntity> receiptDetails);
        /// <summary>
        /// 获取调价单据明细
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        List<PriceChangedReceiptDetailEntity> GetPriceChangedDetailReceiptDetail(long receiptId);
        /// <summary>
        /// 修改调价单据
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="addReceiptDetails"></param>
        /// <param name="modifyReceiptDetails"></param>
        /// <returns></returns>
        DataResult UpdatePriceChangedReceipt(PriceChangedReceiptEntity receipt, List<PriceChangedReceiptDetailEntity> addReceiptDetails, List<PriceChangedReceiptDetailEntity> modifyReceiptDetails);
        /// <summary>
        /// 获取单据顺序号
        /// </summary>
        /// <returns></returns>
        int GetPriceChangedReceiptNo();
        /// <summary>
        /// 删除调价单据
        /// </summary>
        /// <param name="Id">调价单ID</param>
        /// <returns></returns>
        DataResult DeleteReceipt(long receiptId);
        /// <summary>
        /// 获取指定调价单的审核状态
        /// </summary>
        /// <param name="receiptId">调价单ID</param>
        /// <returns></returns>
        bool? GetAuditStatus(long receiptId);
        /// <summary>
        /// 获取药品调价单据
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        PriceChangedReceiptEntity GetReceiptById(long receiptId);
        /// <summary>
        /// 审核调价单
        /// </summary>
        /// <param name="receiptId">调价单ID</param>
        /// <returns></returns>
        DataResult<DateTime> Audit(long receiptId);
        /// <summary>
        /// 取消审核
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <returns></returns>
        DataResult CancelAudit(long receiptId);
        /// <summary>
        /// 调价单生效
        /// </summary>
        /// <param name="receiptId">单据Id</param>
        /// <param name="tran">事务</param>
        /// <returns></returns>
        DataResult<DateTime> Effect(long receiptId, DateTime? serverTime = null);
        /// <summary>
        /// 获取影响的记录
        /// </summary>
        /// <param name="receiptId">单据ID</param>
        /// <param name="receiptDetailId">单据明细</param>
        /// <returns></returns>
        List<PriceChangedDeptInfluenceEntity> GetPriceChangedDeptInfluence(long receiptId, long receiptDetailId);
    }
}
