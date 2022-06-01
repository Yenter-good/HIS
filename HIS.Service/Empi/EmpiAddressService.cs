using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class EmpiAddressService : IEmpiAddressService
    {
        /// <summary>
        /// 获取所有行政区划
        /// </summary>
        /// <returns></returns>
        public List<AdministrativeDivisionEntity> GetAll()
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<AdministrativeDivisionEntity>>(DBHelper.Instance.HIS.From<Empi_Address>().ToList());
        }

        /// <summary>
        /// 获取省级
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetProvinceSimple()
        {
            var models = DBHelper.Instance.HIS.From<Empi_Address>().Where(p => p.LevelType == 1).Select(Empi_Address._.Id, Empi_Address._.Code
            , Empi_Address._.Name).ToList();
            return models.Select(p => new LongItem(p.Id, p.Name, p.Code)).ToList();
        }

        /// <summary>
        /// 获取省级
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetCitySimple()
        {
            var models = DBHelper.Instance.HIS.From<Empi_Address>().Where(p => p.LevelType == 2).Select(Empi_Address._.Id, Empi_Address._.Code
                , Empi_Address._.Name).ToList();
            return models.Select(p => new LongItem(p.Id, p.Name, p.Code)).ToList();
        }
        /// <summary>
        /// 获取省级
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetCountySimple()
        {
            var models = DBHelper.Instance.HIS.From<Empi_Address>().Where(p => p.LevelType == 3).Select(Empi_Address._.Id, Empi_Address._.Code
            , Empi_Address._.Name).ToList();
            return models.Select(p => new LongItem(p.Id, p.Name, p.Code)).ToList();
        }
        /// <summary>
        /// 根据省 获得市
        /// </summary>
        /// <returns></returns>
        public List<AdministrativeDivisionEntity> GetCity(string pcode)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<AdministrativeDivisionEntity>>(DBHelper.Instance.HIS.From<Empi_Address>()
                 .Where(p => p.LevelType == 2 && p.ParentCode == pcode)
                 .ToList());
        }

        /// <summary>
        /// 根据市 获得区县
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        public List<AdministrativeDivisionEntity> GetCounty(string pcode)
        {
            return AutoMapperHelper.Instance.Mapper.Map<List<AdministrativeDivisionEntity>>(DBHelper.Instance.HIS.From<Empi_Address>()
                     .Where(p => p.LevelType == 3 && p.ParentCode == pcode)
                     .ToList());
        }
    }
}
