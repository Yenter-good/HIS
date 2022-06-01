using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 发票服务接口
    /// </summary>
    public interface IInvoiceService : IServiceSingleton
    {
        /// <summary>
        /// 根据发票类型获取发票流水号
        /// </summary>
        /// <param name="invoiceType">发票类型</param>
        /// <returns></returns>
        DataResult<string> GetInvoiceNumber(InvoiceType invoiceType);
        /// <summary>
        /// 获取全部流水号
        /// </summary>
        /// <returns></returns>
        DataResult<List<SerialNumberEntity>> GetAll();
        /// <summary>
        /// 检查发票类型是否存在
        /// </summary>
        /// <param name="invoiceType">发票类型</param>
        /// <returns></returns>
        bool InvoiceTypeExsist(InvoiceType invoiceType);
        /// <summary>
        /// 添加流水号
        /// </summary>
        /// <param name="serialNumberEntity">流水号实体</param>
        /// <returns></returns>
        DataResult Add(SerialNumberEntity serialNumberEntity);
        /// <summary>
        /// 更新流水号配置
        /// </summary>
        /// <param name="serialNumberEntity">流水号实体</param>
        /// <returns></returns>
        DataResult Update(SerialNumberEntity serialNumberEntity);
    }
}
