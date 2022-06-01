using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class AdviceFeeItemMapperEntity
    {
        private long id;
        private int dataStatus;
        private int no;
        private long adviceId;
        private long feeItemId;
        private string feeItemName;
        private string feeItemSpecification;
        private double feeItemPrice;
        private int quantity;
        private int type;
        private int itemType;

        public long Id { get => id; set => id = value; }
        public int DataStatus { get => dataStatus; set => dataStatus = value; }
        public int No { get => no; set => no = value; }
        public long AdviceId { get => adviceId; set => adviceId = value; }
        public long FeeItemId { get => feeItemId; set => feeItemId = value; }
        public string FeeItemName { get => feeItemName; set => feeItemName = value; }
        public double FeeItemPrice { get => feeItemPrice; set => feeItemPrice = value; }
        public string FeeItemSpecification { get => feeItemSpecification; set => feeItemSpecification = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Type { get => type; set => type = value; }
        public int ItemType { get => itemType; set => itemType = value; }
    }
}
