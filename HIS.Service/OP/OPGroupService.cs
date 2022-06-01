using Dos.ORM;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.OP
{
    public class OPGroupService : IOPGroupService
    {
        private IIdService _idService;
        public OPGroupService(IIdService idService)
        {
            _idService = idService;
        }

        /// <summary>
        /// 获取材料及诊疗
        /// </summary>
        /// <returns></returns>
        public List<DealWithItemEntity> GetDealWithItem()
        {
            return DBHelper.Instance.HIS.From<View_OPDealWithItem>().ToList().Mapper<List<DealWithItemEntity>>();
        }

        /// <summary>
        /// 获取科室套餐 GroupType 1 科室
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<PrescriptionGroupEntity> GetByDept(long entityId)
        {
            return DBHelper.Instance.HIS.From<OP_PrescriptionGroup>().Where(p => p.GroupType == 1 && p.OwnerId == entityId).ToList().Mapper<List<PrescriptionGroupEntity>>();
        }
        /// <summary>
        /// 获取个人套餐 GroupType 2 个人
        /// </summary> 
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<PrescriptionGroupEntity> GetByUser(long entityId)
        {
            return DBHelper.Instance.HIS.From<OP_PrescriptionGroup>().Where(p => p.GroupType == 2 && p.OwnerId == entityId).ToList().Mapper<List<PrescriptionGroupEntity>>();
        }
        /// <summary>
        /// 增加套餐
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupEntity> AddGroup(PrescriptionGroupEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();

                var model = entity.Mapper<OP_PrescriptionGroup>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_PrescriptionGroup>(model);

                return DataResult.True<PrescriptionGroupEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<PrescriptionGroupEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 更新套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupEntity> UpdateGroup(long entityId, PrescriptionGroupEntity entity)
        {
            try
            {
                var modelModify = entity.Mapper<OP_PrescriptionGroup>();

                DBHelper.Instance.HIS.Update<OP_PrescriptionGroup>(modelModify, p => p.Id == modelModify.Id);

                return DataResult.True<PrescriptionGroupEntity>(entity);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<PrescriptionGroupEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除套餐
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupEntity> DeleteGroup(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                //删除套餐
                trans.Delete<OP_PrescriptionGroup>(OP_PrescriptionGroup._.Id == entityId);
                //清除掉明细数据
                trans.Delete<OP_PrescriptionGroupDetail>(OP_PrescriptionGroupDetail._.GroupId == entityId);

                trans.Commit();
                return DataResult.True<PrescriptionGroupEntity>(null);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<PrescriptionGroupEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }
        /// <summary>
        /// 根据套餐ID获取套餐明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public List<PrescriptionGroupDetailEntity> GetDetailByGroup(long entityId)
        {
            return DBHelper.Instance.HIS.From<View_OPGroupDetail>().Where(p => p.GroupId == entityId)
                .OrderBy(View_OPGroupDetail._.ItemType.Asc && View_OPGroupDetail._.GroupNo.Asc)
                .ToList().Mapper<List<PrescriptionGroupDetailEntity>>();
        }
        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupDetailEntity> AddDetail(PrescriptionGroupDetailEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();

                var model = entity.Mapper<OP_PrescriptionGroupDetail>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_PrescriptionGroupDetail>(model);

                return DataResult.True<PrescriptionGroupDetailEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<PrescriptionGroupDetailEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupDetailEntity> DeleteDetail(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<OP_PrescriptionGroupDetail>(OP_PrescriptionGroupDetail._.Id == entityId);
                return DataResult.True<PrescriptionGroupDetailEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<PrescriptionGroupDetailEntity>(ex.Message);
            }
        }

        /// <summary>
        /// 同组
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupDetailEntity> SameGroup(List<long> entityIds)
        {

            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                OP_PrescriptionGroupDetail temp = trans.From<OP_PrescriptionGroupDetail>().OrderBy(OP_PrescriptionGroupDetail._.GroupNo.Desc).ToFirst();
                int groupNo = 0;
                if (temp != null)
                    groupNo = temp.GroupNo.AsInt(0) + 1;

                for (int i = 0; i < entityIds.Count; i++)
                {
                    trans.Update<OP_PrescriptionGroupDetail>(OP_PrescriptionGroupDetail._.GroupNo, groupNo, OP_PrescriptionGroupDetail._.Id == entityIds[i]);
                }

                trans.Commit();
                return DataResult.True<PrescriptionGroupDetailEntity>(null);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<PrescriptionGroupDetailEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }

        }

        /// <summary>
        /// 取消同组
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<PrescriptionGroupDetailEntity> CancelGroup(List<long> entityIds)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                for (int i = 0; i < entityIds.Count; i++)
                {
                    trans.Update<OP_PrescriptionGroupDetail>(OP_PrescriptionGroupDetail._.GroupNo, 0, OP_PrescriptionGroupDetail._.Id == entityIds[i]);
                }
                trans.Commit();
                return DataResult.True<PrescriptionGroupDetailEntity>(null);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<PrescriptionGroupDetailEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }


    }
}
