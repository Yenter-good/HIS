using HIS.Core.Interceptors;
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
    public class SysDictQueryService : ISysDictQueryService
    {
        ISysDicDetailService _sysDicDetailService;
        ISysDicService _sysDicService;

        public SysDictQueryService(ISysDicService sysDicService, ISysDicDetailService sysDicDetailService)
        {
            _sysDicService = sysDicService;
            _sysDicDetailService = sysDicDetailService;
        }


        /// <summary>
        /// 获取科室分类
        /// </summary>
        /// <param name="includeDisable">是否包含禁用</param>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetDeptCategories{0}")]
        public List<ItemEntity> GetDeptCategories(bool includeDisable = false)
        {
            return _sysDicService.GetList("ST1002");
        }
        /// <summary>
        /// 获取教育水平
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetEducation")]
        public List<LongItem> GetEducation()
        {
            return _sysDicDetailService.GetListByDicCode("ST1031").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetModality()
        {
            return _sysDicDetailService.GetListByDicCode("ST1009").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取检查部位
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetPart()
        {
            return _sysDicDetailService.GetListByDicCode("ST1008").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取标本类型
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetSample()
        {
            var a = _sysDicDetailService.GetListByDicCode("ST1007");
            return a.Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取试管类型
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetBuret()
        {
            return _sysDicDetailService.GetListByDicCode("ST1006").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取药品属性
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetDrugProperty")]
        public List<LongItem> GetDrugProperty()
        {
            return _sysDicDetailService.GetListByDicCode("ST2002").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取药品剂型
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetDrugform")]
        public List<LongItem> GetDrugform()
        {
            return _sysDicDetailService.GetListByDicCode("ST2004").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取定价类型
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetPriceType")]
        public List<LongItem> GetPriceType()
        {
            return _sysDicDetailService.GetListByDicCode("ST2003").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取药理分类
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetPharmacologyType")]
        public List<LongItem> GetPharmacologyType()
        {
            return _sysDicDetailService.GetListByDicCode("ST2006").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取发药方式
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetDispensingType")]
        public List<LongItem> GetDispensingType()
        {
            return _sysDicDetailService.GetListByDicCode("ST2005").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取药品调价原因
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetPiceChangeMemoType")]
        public List<LongItem> GetPiceChangeMemoType()
        {
            return _sysDicDetailService.GetListByDicCode("ST2007").Mapper<List<LongItem>>();
        }

        /// <summary>
        /// 获取职业
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetProfessionalType")]
        public List<LongItem> GetProfessionalType()
        {
            return _sysDicDetailService.GetListByDicCode("ST2009").Mapper<List<LongItem>>();
        }

        /// <summary>
        /// 获取民族
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetNational")]
        public List<LongItem> GetNational()
        {
            return _sysDicDetailService.GetListByDicCode("ST2010").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取挂号类别（专家、普通、急诊）
        /// </summary>
        /// <returns></returns>
        public List<LongItem> GetRegCategory()
        {
            return _sysDicDetailService.GetListByDicCode("ST2011").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取血型
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetBlood")]
        public List<LongItem> GetBlood()
        {
            return _sysDicDetailService.GetListByDicCode("ST2012").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取婚姻状况
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetMarry")]
        public List<LongItem> GetMarry()
        {
            return _sysDicDetailService.GetListByDicCode("ST2013").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取国籍
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetNationality")]
        public List<LongItem> GetNationality()
        {
            return _sysDicDetailService.GetListByDicCode("ST1027").Mapper<List<LongItem>>();
        }
        /// <summary>
        /// 获取模板节点
        /// </summary>
        /// <returns></returns>
        [CacheMethod(CachingMethod.Get, Key = "ISysDictQueryService_GetTemplateNode")]
        public List<LongItem> GetOPTemplateNode()
        {
            return _sysDicDetailService.GetListByDicCode("ST2014").Mapper<List<LongItem>>();
        }
    }
}
