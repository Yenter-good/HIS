using Dos.ORM;
using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Internal
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-20 14:45:14
    /// 描述:
    /// </summary>
    public class InternalPharmacyInOutInventoryService : Singleton<InternalPharmacyInOutInventoryService>
    {
        public void AddInOutInventoryReceipt(IIdService idService, PharmacyInOutInventoryEntity receipt, List<PharmacyInOutInventoryDetailEntity> detailEntities, PharmacyInOutReceiptType receiptType, DbBatch batch)
        {
            //插入入库单据主表
            var insertReceipt = receipt.Mapper<Drug_PharmacyReceipt>().SetCreationValues();
            receipt.CreateUser = new UserEntity() { Name = App.Instance.User.UserName };
            receipt.CreationTime = insertReceipt.CreationTime;
            receipt.Id = idService.CreateUUID();
            insertReceipt.Id = receipt.Id;
            insertReceipt.AuditTime = null;
            insertReceipt.AuditStatus = false;
            insertReceipt.ReceiptType = (int)receiptType;
            insertReceipt.No = 0;
            insertReceipt.TotalPrice = receipt.Total;

            batch.Insert(insertReceipt);

            int no = 0;
            foreach (var receiptDetailEntity in detailEntities)
            {
                //插入入库单据明细表
                var insertDetail = receiptDetailEntity.Mapper<Drug_PharmacyReceiptDetail>().SetCreationValues();
                receiptDetailEntity.Id = idService.CreateUUID();
                insertDetail.Id = receiptDetailEntity.Id;
                insertDetail.No = no;
                insertDetail.ReceiptId = receipt.Id;
                batch.Insert(insertDetail);

                no++;
            }
        }
    }
}
