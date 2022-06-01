using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IOPGroupService : IServiceSingleton
    {
        /// <summary>
        /// 获取材料及诊疗
        /// </summary>
        /// <returns></returns>
        List<DealWithItemEntity> GetDealWithItem();

        /// <summary>
        /// 获取科室套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<PrescriptionGroupEntity> GetByDept(long entityId);

        /// <summary>
        /// 获取个人套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<PrescriptionGroupEntity> GetByUser(long entityId);
        /// <summary>
        /// 增加套餐
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupEntity> AddGroup(PrescriptionGroupEntity entity);
        /// <summary>
        /// 更新套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupEntity> UpdateGroup(long entityId, PrescriptionGroupEntity entity);
        /// <summary>
        /// 删除套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupEntity> DeleteGroup(long entityId);
        /// <summary>
        /// 根据套餐ID获取套餐明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        List<PrescriptionGroupDetailEntity> GetDetailByGroup(long entityId);
        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupDetailEntity> AddDetail(PrescriptionGroupDetailEntity entity);
       
        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupDetailEntity> DeleteDetail(long entityId);


        /// <summary>
        /// 同组
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupDetailEntity> SameGroup(List<long> entityIds);

        /// <summary>
        /// 同组
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<PrescriptionGroupDetailEntity> CancelGroup(List<long> entityIds);



    }
}
