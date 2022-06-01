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
    /// 创建时间:2021-01-21 15:16:02
    /// 描述:
    /// </summary>
    public class InternalChangeInventoryService : Singleton<InternalChangeInventoryService>
    {
        public void AddReceipt(IIdService idService, ChangeInventoryReceiptEntity receipt, List<ChangeInventoryReceiptDetailEntity> detailEntities, DbBatch batch)
        {
            var insertReceipt = receipt.Mapper<Drug_ChangeInventoryReceipt>().SetCreationValues();
            receipt.Id = idService.CreateUUID();
            receipt.CreateUser = new UserEntity() { Name = App.Instance.User.UserName };
            receipt.CreationTime = insertReceipt.CreationTime;
            insertReceipt.Id = receipt.Id;
            insertReceipt.AuditTime = null;
            insertReceipt.AuditStatus = false;
            insertReceipt.No = 0;

            batch.Insert(insertReceipt);

            int no = 0;
            foreach (var detail in detailEntities)
            {
                var insertDetail = detail.Mapper<Drug_ChangeInventoryReceiptDetail>().SetCreationValues();
                detail.Id = idService.CreateUUID();
                insertDetail.Id = detail.Id;
                insertDetail.No = no;
                insertDetail.ReceiptId = receipt.Id;
                batch.Insert(insertDetail);

                no++;
            }
        }

    }
}
