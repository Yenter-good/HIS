using Dos.ORM;
using HIS.Core;
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
    public class OPChronicDiseases: IOPChronicDiseases
    {

        private IIdService _idService;
        public OPChronicDiseases(IIdService idService)
        {
            _idService = idService;
        }

        /// <summary>
        /// 增加慢性病
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<DiseasesEntity> AddDiseases(DiseasesEntity entity)
        {
            try
            {
                entity.Id = _idService.CreateUUID();

                var model = entity.Mapper<OP_ChronicDiseases>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_ChronicDiseases>(model);

                return DataResult.True<DiseasesEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<DiseasesEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 修改慢性病
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataResult<DiseasesEntity> UpdateDiseases(long entityId, DiseasesEntity entity)
        {
            try
            {
                var modelModify = entity.Mapper<OP_ChronicDiseases>();

                DBHelper.Instance.HIS.Update<OP_ChronicDiseases>(modelModify, p => p.Id == modelModify.Id);

                return DataResult.True<DiseasesEntity>(entity);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DiseasesEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除慢性病
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<DiseasesEntity> DeleteDiseases(long entityId)
        {
            DbTrans trans = DBHelper.Instance.HIS.BeginTransaction();
            try
            {
                //删除套餐
                trans.Delete<OP_ChronicDiseases>(OP_ChronicDiseases._.Id == entityId);
                //清除掉明细数据
                trans.Delete<OP_ChronicDiseasesMapper>(OP_ChronicDiseasesMapper._.DiseaseId == entityId);

                trans.Commit();
                return DataResult.True<DiseasesEntity>(null);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return DataResult.Fault<DiseasesEntity>(ex.Message);
            }
            finally
            {
                trans.Close();
            }
        }
        /// <summary>
        /// 获取所有慢性病
        /// </summary>
        /// <returns></returns>
        public List<DiseasesEntity> GetAll()
        {
            return DBHelper.Instance.HIS.From<OP_ChronicDiseases>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).ToList().Mapper<List<DiseasesEntity>>();
        }
        /// <summary>
        /// 获取慢性病可开药品明细
        /// </summary>
        /// <param name="diseasesId"></param>
        /// <returns></returns>
        public List<DiseasesMapperEntity> GetByDiseasesId(long diseasesId)
        {
            return DBHelper.Instance.HIS.From<View_OPDiseasesDetail>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.DiseaseId == diseasesId).ToList().Mapper<List<DiseasesMapperEntity>>();
        }
        /// <summary>
        /// 增加可开药品
        /// </summary>
        /// <param name="diseasesId"></param>
        /// <param name="ClassCode"></param>
        /// <param name="SpecificationCode"></param>
        /// <returns></returns>
        public DataResult<DiseasesMapperEntity> AddDetail(long diseasesId, string ClassCode, string SpecificationCode)
        {
            try
            {
                DiseasesMapperEntity entity = new DiseasesMapperEntity();
                entity.Id = _idService.CreateUUID();
                entity.DiseaseId = diseasesId;
                entity.ClassCode = ClassCode;
                entity.SpecificationCode = SpecificationCode;

                var model = entity.Mapper<OP_ChronicDiseasesMapper>();
                model.SetCreationValues();
                DBHelper.Instance.HIS.Insert<OP_ChronicDiseasesMapper>(model);

                return DataResult.True<DiseasesMapperEntity>(entity);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<DiseasesMapperEntity>(ex.Message);
            }
        }
        /// <summary>
        /// 删除可开药品
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public DataResult<DiseasesMapperEntity> DeleteDetail(long entityId)
        {
            try
            {
                DBHelper.Instance.HIS.Delete<OP_ChronicDiseasesMapper>(OP_ChronicDiseasesMapper._.Id == entityId);
                return DataResult.True<DiseasesMapperEntity>(null);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<DiseasesMapperEntity>(ex.Message);
            }
        }
    }
}
