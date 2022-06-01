using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 发票服务实现类
    /// </summary>
    public class InvoiceService : IInvoiceService
    {
        private IIdService _idService;
        public InvoiceService(IIdService idService)
        {
            this._idService = idService;
        }
        /// <summary>
        /// 根据发票类型获取发票流水号
        /// </summary>
        /// <param name="invoiceType">发票类型</param>
        /// <returns></returns>
        public DataResult<string> GetInvoiceNumber(InvoiceType invoiceType)
        {
            try
            {
                var proc = DBHelper.Instance.HIS.FromProc("[dbo].[Proc_GetInvoiceNumber]")
                        .AddInParameter("@HosID", DbType.Int64, HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id)
                        .AddInParameter("@Type", DbType.Int32, (int)invoiceType)
                        .AddInParameter("@SessionId", DbType.Int64, HIS.Core.App.Instance.SessionId)
                        .AddOutParameter("@Number", DbType.String, 50);
                proc.ExecuteNonQuery();

                string invoiceNumber = (proc.GetReturnValues()["@Number"]).AsString("");

                return DataResult.True<string>(invoiceNumber);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<string>(ex.Message);
            }
        }
        /// <summary>
        /// 获取全部流水号
        /// </summary>
        /// <returns></returns>
        public DataResult<List<SerialNumberEntity>> GetAll()
        {
            try
            {
                var list = DBHelper.Instance.HIS.From<Dic_SerialNumber>().ToList().Mapper<List<SerialNumberEntity>>();

                return DataResult.True(list);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<SerialNumberEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 检查发票类型是否存在
        /// </summary>
        /// <param name="invoiceType">发票类型</param>
        /// <returns></returns>
        public bool InvoiceTypeExsist(InvoiceType invoiceType)
        {
            bool exists = DBHelper.Instance.HIS.Exists<Dic_SerialNumber>(d => d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.Type == (int)invoiceType);

            return exists;
        }
        /// <summary>
        /// 添加流水号
        /// </summary>
        /// <param name="serialNumberEntity">流水号实体</param>
        /// <returns></returns>
        public DataResult Add(SerialNumberEntity serialNumberEntity)
        {
            try
            {
                Dic_SerialNumber sn = new Dic_SerialNumber();
                sn.Id = this._idService.CreateUUID();
                serialNumberEntity.Id = sn.Id;
                sn.Type = (int)serialNumberEntity.Type;
                sn.ChangeType = (int)serialNumberEntity.ChangeType;
                sn.MiddleFormat = (int)serialNumberEntity.MiddleFormat;
                sn.CacheFlag = serialNumberEntity.CacheFlag;
                sn.TotalLength = serialNumberEntity.TotalLength;
                sn.HosId = App.Instance.RuntimeSystemInfo.HospitalInfo.Id;
                sn.StartPrefix = serialNumberEntity.StartPrefix;
                sn.Description = serialNumberEntity.Description;

                DBHelper.Instance.HIS.Insert<Dic_SerialNumber>(sn);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新流水号配置
        /// </summary>
        /// <param name="serialNumberEntity">流水号实体</param>
        /// <returns></returns>
        public DataResult Update(SerialNumberEntity serialNumberEntity)
        {
            try
            {
                var modify = new Dictionary<Dos.ORM.Field, object>();
                modify[Dic_SerialNumber._.TotalLength] = serialNumberEntity.TotalLength;
                modify[Dic_SerialNumber._.MiddleFormat] = (int)serialNumberEntity.MiddleFormat;
                modify[Dic_SerialNumber._.ChangeType] = (int)serialNumberEntity.ChangeType;
                modify[Dic_SerialNumber._.StartPrefix] = serialNumberEntity.StartPrefix;
                modify[Dic_SerialNumber._.CacheFlag] = serialNumberEntity.CacheFlag;
                DBHelper.Instance.HIS.Update<Dic_SerialNumber>(modify, d => d.Id == serialNumberEntity.Id && d.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
