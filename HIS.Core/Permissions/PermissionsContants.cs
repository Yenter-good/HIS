using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core
{
    public class PermissionsContants : Singleton<PermissionsContants>
    {
        [Permission("处方权", "医生")]
        public string OP_PrescriptionPermission { get; private set; } = "OP_PRESCRIPTIONPERMISSION";

        [Permission("药库入库审核权", "药库")]
        public string Drug_WarehouseInInventoryReceiptAudit { get; private set; } = "Drug_WarehouseInInventoryReceiptAudit";

        [Permission("药房入库审核权", "药库")]
        public string Drug_PharmacyInInventoryReceiptAudit { get; private set; } = "Drug_PharmacyInInventoryReceiptAudit";

        [Permission("药库出库审核权", "药库")]
        public string Drug_WarehouseOutInventoryReceiptAudit { get; private set; } = "Drug_WarehouseOutInventoryReceiptAudit";

        [Permission("药房出库审核权", "药库")]
        public string Drug_PharmacyOutInventoryReceiptAudit { get; private set; } = "Drug_PharmacyOutInventoryReceiptAudit";

        [Permission("药品调价审核权", "药库")]
        public string Drug_PriceChangedReceiptAudit { get; private set; } = "Drug_PriceChangedReceiptAudit";

        [Permission("库存管理审核权", "药库")]
        public string Drug_ChangeInventoryReceiptAudit { get; private set; } = "Drug_ChangeInventoryReceiptAudit";
        [Permission("收费权限", "收费工作站")]       
        public string Charge_IsCashier { get; private set; } = "Charge_IsCashier";      
        [Permission("药品调拨审核权", "药库")]
        public string Drug_TransferReceiptAudit { get; private set; } = "Drug_TransferReceiptAudit";    }
}
