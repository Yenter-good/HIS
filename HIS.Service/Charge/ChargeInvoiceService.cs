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

namespace HIS.Service
{
    public class ChargeInvoiceService : IChargeInvoiceService
    {
        private IIdService _idService;
        private IUserService _userService;
        public ChargeInvoiceService(IIdService idService , IUserService userService)
        {
            _idService = idService;
            _userService = userService;
        }


        /// <summary>
        /// 新增票据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<ChargeInvoiceEntity> AddInvoice(ChargeInvoiceEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();
               
                var model = entity.Mapper<Charge_Invoice>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<Charge_Invoice>(model);

                return DataResult.True<ChargeInvoiceEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<ChargeInvoiceEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 更改票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<ChargeInvoiceEntity> UpdateInvoice(long entityId, ChargeInvoiceEntity entity)
        {
            try
            {
                var modelModify = entity.Mapper<Charge_Invoice>();

                DBHelper.Instance.HIS.Update<Charge_Invoice>(modelModify, p => p.Id == modelModify.Id);

                return DataResult.True<ChargeInvoiceEntity>(entity);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<ChargeInvoiceEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public DataResult<ChargeInvoiceEntity> DeleteInvoice(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Charge_Invoice>(Charge_Invoice._.Id == entityId);
                return DataResult.True<ChargeInvoiceEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<ChargeInvoiceEntity>(ex.Message);
            }
            
        }

        /// <summary>
        /// 获取个人收费票据信息
        /// </summary>
        /// <param name="type">票据类型</param>
        /// <param name="userId">收费员ID</param>
        /// <returns></returns>
        public DataResult<ChargeInvoiceEntity> GetInvoice(int type, long userId) 
        {
            try
            {
                List<ChargeInvoiceEntity> list = AutoMapperHelper.Instance.Mapper.Map<List<ChargeInvoiceEntity>>(DBHelper.Instance.HIS.From<Charge_Invoice>()
                    .Where(p => p.Type == type && p.CashierId == userId)
                    .ToList());
                ChargeInvoiceEntity item = list[0];
                if (list.Count > 0)
                {
                    return DataResult.True<ChargeInvoiceEntity>(item);
                }
                return DataResult.Fault<ChargeInvoiceEntity>("没有查询到票据信息");
            }
            catch (Exception ex)
            {
                return DataResult.Fault<ChargeInvoiceEntity>(ex.Message);
            }

        }
        /// <summary>
        /// 获取所有票据信息
        /// </summary>
        /// <returns></returns>
        public List<ChargeInvoiceEntity> GetAll(int type)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<ChargeInvoiceEntity>>(DBHelper.Instance.HIS.From<Charge_Invoice>()
                .Where(p=>p.Type == type)
                .ToList());

        }
        /// <summary>
        /// 获取收银员列表
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> GetCashier()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<UserEntity>>(DBHelper.Instance.HIS.From<Sys_User>()
                .Where(p => p.UserType == (int) UserType.Cashier)
                     .ToList());
        }

    }
}
