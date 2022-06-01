using Dos.ORM;
using HIS.Core;
using HIS.Core.Interceptors;
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
    public class MerchantsService : IMerchantsService
    {
        private IIdService _idService;
        public MerchantsService(IIdService idService)
        {
            _idService = idService;
        }
        /// <summary>
        /// 获取单个商家信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantsEntity Get(long id)
        {
            var org = DBHelper.Instance.HIS.From<Dic_Merchants>()
                .Where(d => d.Id == id).First();

            return AutoMapperHelper.Instance.Mapper.Map<MerchantsEntity>(org);
        }


        /// <summary>
        /// 获取所有供应商
        /// </summary>
        /// <returns></returns>
        public List<MerchantsEntity> GetAllSupplier()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<MerchantsEntity>>(DBHelper.Instance.HIS.From<Dic_Merchants>().Where(p => p.Type == (int)MerchantType.供应厂商).OrderBy(d => d.No).ToList());
        }

        /// <summary>
        /// 获取所有生产厂家 
        /// </summary>
        /// <returns></returns>
        public List<MerchantsEntity> GetAllManufacturer()
        {
            return DBHelper.Instance.HIS.From<Dic_Merchants>()
                 .Where(p => p.Type == (int)MerchantType.生产厂家)
                 .Select(Dic_Merchants._.Id
                     , Dic_Merchants._.DataStatus
                     , Dic_Merchants._.No
                     , Dic_Merchants._.Name
                     , Dic_Merchants._.LegalPerson
                     , Dic_Merchants._.Address
                     , Dic_Merchants._.PhoneNo
                     , Dic_Merchants._.BusinessLicense
                     , Dic_Merchants._.Type
                     , Dic_Merchants._.SearchCode
                     , Dic_Merchants._.WubiCode)
                 .OrderBy(d => d.No)
                 .ToList()
                 .Mapper<List<MerchantsEntity>>();
        }

        /// <summary>
        /// 新增厂商
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult InsertMerchants(MerchantsEntity entity)
        {
            try
            {
                entity.Id = this._idService.CreateUUID();
                Dic_Merchants item = entity.Mapper<Dic_Merchants>();
                item.SetCreationValues();

                DBHelper.Instance.HIS.Insert(item);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新厂商
        /// </summary>
        /// <param name="entityId">厂商ID</param>
        /// <param name="entity">厂商实体</param>
        /// <returns></returns>
        public DataResult UpdateMerchants(MerchantsEntity entity)
        {
            try
            {
                var modelModify = AuditionHelper.GetModificationValues<Dic_Merchants>();
                modelModify[Dic_Merchants._.Name] = entity.Name;
                modelModify[Dic_Merchants._.SearchCode] = entity.SearchCode;
                modelModify[Dic_Merchants._.WubiCode] = entity.WubiCode;
                modelModify[Dic_Merchants._.PhoneNo] = entity.PhoneNo;
                modelModify[Dic_Merchants._.LegalPerson] = entity.LegalPerson;
                modelModify[Dic_Merchants._.Address] = entity.Address;
                modelModify[Dic_Merchants._.BusinessLicense] = entity.BusinessLicense;

                DBHelper.Instance.HIS.Update<Dic_Merchants>(modelModify, p => p.Id == entity.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }

        }

        /// <summary>
        /// 删除厂商
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult DeleteMerchants(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<Dic_Merchants>(Dic_Merchants._.Id == entityId);
                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }

        }
        /// <summary>
        /// 获取所有供应商只获得 ID，拼音码，名称
        /// </summary>
        /// <returns></returns>
        public List<MerchantsEntity> GetAllSupplierJane()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<MerchantsEntity>>(DBHelper.Instance.HIS.From<Dic_Merchants>()
                .Select(Dic_Merchants._.Id, Dic_Merchants._.Name, Dic_Merchants._.SearchCode).Where(p => p.Type == 2).ToList());
        }
        /// <summary>
        /// 获取所有生产厂商  只获得 ID，拼音码，名称
        /// </summary>
        /// <returns></returns>
        public List<MerchantsEntity> GetAllManufacturerJane()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<MerchantsEntity>>(DBHelper.Instance.HIS.From<Dic_Merchants>()
                .Select(Dic_Merchants._.Id, Dic_Merchants._.Name, Dic_Merchants._.SearchCode).Where(p => p.Type == 1).ToList());
        }
    }
}
