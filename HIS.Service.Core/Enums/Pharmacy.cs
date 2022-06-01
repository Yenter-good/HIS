using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 盘点状态
    /// </summary>
    public enum TakeStockStatus
    {
        [Description("新增")]
        New,
        [Description("盘点中")]
        Perform,
        [Description("盘点完成")]
        Complete
    }
    public enum ReceiptAuditStatus
    {
        [Description("未审核")]
        None,
        [Description("已审核")]
        Audit,
    }
    /// <summary>
    /// 药库入出库单据类型
    /// </summary>
    public enum WarehouseInOutReceiptType
    {
        入库单,
        退货单,
        科室出库单
    }
    /// <summary>
    /// 药库入库记录表类型
    /// </summary>
    public enum WarehouseInInventoryType
    {
        入库,
        调拨,
        上调,
        药房退库,
        盘点盘盈
    }
    /// <summary>
    /// 药库出库记录表类型
    /// </summary>
    public enum WarehouseOutInventoryType
    {
        退货,
        报损,
        调拨,
        抽检,
        下调,
        药房申领,
        盘点盘亏,
        发向药房
    }
    /// <summary>
    /// 药房入库记录表类型
    /// </summary>
    public enum PharmacyInInventoryType
    {
        进货,
        调拨,
        上调,
        退药,
        盘点盘盈
    }
    /// <summary>
    /// 药房出库记录表类型
    /// </summary>
    public enum PharmacyOutInventoryType
    {
        退库,
        报损,
        调拨,
        抽检,
        下调,
        发药,
        盘点盘亏
    }
    /// <summary>
    /// 药房入出单据表类型
    /// </summary>
    public enum PharmacyInOutReceiptType
    {
        入库,
        退库
    }
    /// <summary>
    /// 药库药房库存变更单据类型
    /// </summary>
    public enum ChangeInventoryType
    {
        上调,
        下调,
        报损,
        抽检,
    }
}
