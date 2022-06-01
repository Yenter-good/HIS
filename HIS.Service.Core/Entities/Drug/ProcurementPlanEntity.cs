using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities.Drug
{
    public class ProcurementPlanEntity
    {
        //ID
        public long Id { get; set; }
        //状态 0计划生成中 1审核完成
        public int  AuditStatus { get; set; }
        //创建时间
        public DateTime CreationTime { get; set; }
        //单据编号
        public String ReceiptCode { get; set; }


    }
}
