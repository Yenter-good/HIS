using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Enums
{
    /// <summary>
    /// 发票类型
    /// </summary>
    public enum InvoiceType
    {
        药库入库单据,
        药品调价单据,
        采购计划单据,
        药房申请药品,
        盘点单,
        药房退库,
        库存变更,
        调拨单
    }
    /// <summary>
    /// 变化类型
    /// </summary>
    public enum ChangeType
    {
        一直累加,
        每天初始化
    }
    /// <summary>
    /// 流水号中间部分类型
    /// </summary>
    public enum MiddleFormat
    {
        空,
        yyyyMMdd,
        yyMMdd
    }
}
