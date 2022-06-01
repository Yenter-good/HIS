using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IAdviceService : IServiceSingleton
    {
        /// <summary>
        /// 获取单个医嘱信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AdviceEntity Get(long id);

        /// <summary>
        /// 获取所有医嘱
        /// </summary>
        /// <returns></returns>
        List<AdviceEntity> GetAll();

        /// <summary>
        /// 根据医嘱类型获取所有
        /// </summary>
        /// <param name="type">医嘱类型</param>
        /// <returns></returns>
        List<AdviceEntity> GetAllByType(AdviceType type);
        /// <summary>
        /// 根据 医嘱名称或拼音码查询
        /// </summary>
        /// <param name="searchCode">查询字符串</param>
        /// <param name="type">医嘱类型</param>
        /// <returns></returns>
        List<AdviceEntity> GetByConditions(string searchStr, AdviceType type);
        /// <summary>
        /// 新增医嘱
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<AdviceEntity> InsertAdvice(AdviceEntity entity);
        /// <summary>
        /// 更新医嘱
        /// </summary>
        /// <param name="entityId">医嘱ID</param>
        /// <param name="entity">医嘱实体</param>
        /// <returns></returns>
        DataResult<AdviceEntity> UpdateAdvice(long entityId, AdviceEntity entity);

        /// <summary>
        /// 医嘱停用或启用
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="status">0停用 1启用</param>
        /// <returns></returns>
        DataResult<AdviceEntity> StopAdvice(long entityId, DataStatus status);
        /// <summary>
        /// 获取医嘱明细信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<AdviceFeeItemMapperEntity> GetByAdviceId(long entityId);
        /// <summary>
        /// 获取医嘱关联收费信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<AdviceFeeItemMapperEntity> GetByAdviceMapperId(long entityId);

        /// <summary>
        /// 新增明细或关联信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<AdviceFeeItemMapperEntity> InsertAdviceFeeItemMapper(AdviceFeeItemMapperEntity entity);

        /// <summary>
        /// 删除医嘱明细或关联信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<AdviceFeeItemMapperEntity> DeleteAdviceFeeItemMapper(long adviceId, long entityId);
        /// <summary>
        /// 获取所有医嘱分类
        /// </summary>
        /// <returns></returns>
        List<AdviceCategoryEntity> GetAdviceCategories();
        /// <summary>
        /// 根据分类类型获取医嘱分类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        List<AdviceCategoryEntity> GetAdviceCategories(AdviceCategoryType type);
        /// <summary>
        /// 更新医嘱分类
        /// </summary>
        /// <param name="adviceCategory"></param>
        /// <returns></returns>
        DataResult UpdateAdviceCategory(AdviceCategoryEntity adviceCategory);
        /// <summary>
        /// 新增医嘱分类
        /// </summary>
        /// <param name="adviceCategory"></param>
        /// <returns></returns>
        DataResult AddAdviceCategory(AdviceCategoryEntity adviceCategory);
        /// <summary>
        /// 获取所有医嘱和分类映射
        /// </summary>
        /// <param name="type">0检验 1检查</param>
        /// <returns></returns>
        Dictionary<long, List<long>> GetAdviceCategoryMapper(int type);

        /// <summary>
        /// 插入到分类中
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        DataResult InsertAdviceCategoryMapper(long adviceId, long categoryId, int type);
        /// <summary>
        /// 插入到分类中
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        DataResult InsertAdviceCategoryMapper(List<long> adviceIds, long categoryId);
        /// <summary>
        /// 从分类中删除医嘱
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        DataResult DeleteAdviceCategoryMapper(long adviceId, long categoryId);
        /// <summary>
        /// 从分类中删除医嘱
        /// </summary>
        /// <param name="adviceId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        DataResult DeleteAdviceCategoryMapper(List<long> adviceIds, long categoryId);
    }
}
