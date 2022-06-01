using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;

namespace HIS.Service.Core
{
    public interface IEmpiAddressService : IServiceSingleton
    {
        /// <summary>
        /// 获取所有行政区划
        /// </summary>
        /// <returns></returns>
        List<AdministrativeDivisionEntity> GetAll();

        /// <summary>
        /// 获取省级
        /// </summary>
        /// <returns></returns>
        List<LongItem> GetProvinceSimple();
        /// <summary>
        /// 获取市级
        /// </summary>
        /// <returns></returns>
        List<LongItem> GetCitySimple();
        /// <summary>
        /// 获取县级
        /// </summary>
        /// <returns></returns>
        List<LongItem> GetCountySimple();
        /// <summary>
        /// 根据省 获得市
        /// </summary>
        /// <returns></returns>
        List<AdministrativeDivisionEntity> GetCity(string pcode);

        /// <summary>
        /// 根据市 获得区县
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        List<AdministrativeDivisionEntity> GetCounty(string pcode);


    }
}
