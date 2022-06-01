using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IMerchantsService: IServiceSingleton
    {
        /// <summary>
        /// 获取单个商家信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MerchantsEntity Get(long id);


        /// <summary>
        /// 获取所有供应商
        /// </summary>
        /// <returns></returns>
        List<MerchantsEntity> GetAllSupplier();


        /// <summary>
        /// 获取所有供应商
        /// </summary>
        /// <returns></returns>
        List<MerchantsEntity> GetAllSupplierJane();

        /// <summary>
        /// 获取所有生产厂商
        /// </summary>
        /// <returns></returns>
        List<MerchantsEntity> GetAllManufacturer();

        /// <summary>
        /// 获取所有生产厂商
        /// </summary>
        /// <returns></returns>
        List<MerchantsEntity> GetAllManufacturerJane();

        /// <summary>
        /// 新增厂商
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult InsertMerchants(MerchantsEntity entity);
        /// <summary>
        /// 更新厂商
        /// </summary>
        /// <param name="entity">厂商实体</param>
        /// <returns></returns>
        DataResult UpdateMerchants(MerchantsEntity entity);

        /// <summary>
        /// 删除厂商
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult DeleteMerchants(long entityId);
    }
}
