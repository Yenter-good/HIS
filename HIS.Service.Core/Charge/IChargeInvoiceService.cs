using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;

namespace HIS.Service.Core
{
    /// <summary>
    /// 发票单据管理服务
    /// </summary>
    public interface IChargeInvoiceService : IServiceSingleton
    {
        /// <summary>
        /// 新增票据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<ChargeInvoiceEntity> AddInvoice(ChargeInvoiceEntity entity);
        /// <summary>
        /// 更改票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<ChargeInvoiceEntity> UpdateInvoice(long entityId,ChargeInvoiceEntity entity);
        /// <summary>
        /// 删除票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name=""></param>
        /// <returns></returns>
        DataResult<ChargeInvoiceEntity> DeleteInvoice(long entityId);

        /// <summary>
        /// 获取个人收费票据信息
        /// </summary>
        /// <param name="type">票据类型</param>
        /// <param name="userId">收费员ID</param>
        /// <returns></returns>
        DataResult<ChargeInvoiceEntity> GetInvoice(int type,long userId);
        /// <summary>
        /// 获取所有票据信息 按类型 枚举 ChargeInvoiceType 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<ChargeInvoiceEntity> GetAll(int type);
        /// <summary>
        /// 获取收银员列表
        /// </summary>
        /// <returns></returns>
        List<UserEntity> GetCashier();

    }
}
