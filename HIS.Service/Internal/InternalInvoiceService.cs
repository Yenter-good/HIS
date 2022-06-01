using HIS.Core;
using HIS.Model;
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
    /// 序列号内置服务
    /// </summary>
    public class InternalInvoiceService : Singleton<InternalInvoiceService>
    {
        public DataResult ReleaseInvoice(InvoiceType invoiceType, Dos.ORM.DbTrans dbTrans = null)
        {
            try
            {
                DbAccessor.Choose(dbTrans, DBHelper.Instance.HIS)
                    .FromSql("delete from Dic_CacheInvoiceNo where HosId=@HosId and SessionId=@SessionId and Type=@Type")
                    .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                    .AddInParameter("@SessionId", System.Data.DbType.Int64, App.Instance.SessionId)
                    .AddInParameter("@Type", System.Data.DbType.Int32, (int)invoiceType)
                    .ExecuteNonQuery();

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
