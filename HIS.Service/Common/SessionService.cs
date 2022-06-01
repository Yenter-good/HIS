using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-16 12:42:30
    /// 描述:
    /// </summary>
    public class SessionService : ISessionService
    {
        private readonly IIdService _idService;

        public SessionService(IIdService idService)
        {
            this._idService = idService;
        }

        public DataResult<long> Generate()
        {
            try
            {
                var sessionId = _idService.CreateUUID();
                var dt = DBHelper.Instance.HIS.FromProc("Proc_Session")
                                              .AddInParameter("@Operation", System.Data.DbType.Int32, 0)
                                              .AddInParameter("@SessionId", System.Data.DbType.Int64, sessionId)
                                              .AddInParameter("@UserId", System.Data.DbType.Int64, App.Instance.User.Id).ToDataTable();
                if (dt.Rows[0][0].ToString() == "0")
                    return DataResult.Fault<long>(dt.Rows[0][1].ToString());
                else
                    return DataResult.True<long>(sessionId);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<long>(ex.Message);
            }
        }

        public void Release()
        {
            try
            {
                DBHelper.Instance.HIS.FromProc("Proc_Session")
                                     .AddInParameter("@Operation", System.Data.DbType.Int32, 1)
                                     .AddInParameter("@SessionId", System.Data.DbType.Int64, App.Instance.SessionId)
                                     .AddInParameter("@UserId", System.Data.DbType.Int64, App.Instance.User.Id).ExecuteNonQuery();

            }
            catch
            {
            }
        }
    }
}
