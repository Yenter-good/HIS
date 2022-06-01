using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Drug
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-01-23 12:25:53
    /// 描述:
    /// </summary>
    public class DrugSplitOrMergeService : IDrugSplitOrMergeService
    {
        /// <summary>
        /// 药品拆分与合并
        /// </summary>
        /// <param name="drugInventoryEntity">药品实体</param>
        /// <param name="pharmacy">药房标识 1门诊药房 2住院药房</param>
        /// <param name="Operation">操作类型 0全拆 1全合 2 自定义拆分 3 自定义合并</param>
        /// <param name="operationPackageNumber">操作的包装数</param>
        /// <returns></returns>
        public DataResult DrugSplitOrMerge(long inventoryId, int pharmacy, int Operation, int operationPackageNumber = 0)
        {
            try
            {
                var dt = DBHelper.Instance.HIS.FromProc("[dbo].[Proc_DrugSplitOrMerge]")
                     .AddInParameter("@HosId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                     .AddInParameter("@InventoryId", System.Data.DbType.Int64, inventoryId)
                     .AddInParameter("@ExecUserId", System.Data.DbType.Int64, App.Instance.RuntimeSystemInfo.UserInfo.Id)
                     .AddInParameter("@Pharmacy", System.Data.DbType.Int32, pharmacy)
                     .AddInParameter("@Operation", System.Data.DbType.Int32, Operation)
                     .AddInParameter("@OperationPackageNumber", System.Data.DbType.Int32, operationPackageNumber)
                     .ToDataTable();
                if (dt.Rows[0][0].ToString() == "0")
                    return DataResult.Fault(dt.Rows[0][1].ToString());

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
