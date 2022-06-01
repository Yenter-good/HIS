using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IOPChronicDiseases : IServiceSingleton
    {
        /// <summary>
        /// 增加慢性病
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<DiseasesEntity> AddDiseases(DiseasesEntity entity);
        /// <summary>
        /// 修改慢性病
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<DiseasesEntity> UpdateDiseases(long entityId,DiseasesEntity entity);
        /// <summary>
        /// 删除慢性病
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<DiseasesEntity> DeleteDiseases(long entityId);
        /// <summary>
        /// 获取所有慢性病
        /// </summary>
        /// <returns></returns>
        List<DiseasesEntity> GetAll();
        /// <summary>
        /// 获取慢性病可开药品明细
        /// </summary>
        /// <param name="diseasesId"></param>
        /// <returns></returns>
        List<DiseasesMapperEntity> GetByDiseasesId(long diseasesId);
        /// <summary>
        /// 增加可开药品
        /// </summary>
        /// <param name="diseasesId"></param>
        /// <param name="ClassCode"></param>
        /// <param name="SpecificationCode"></param>
        /// <returns></returns>
        DataResult<DiseasesMapperEntity> AddDetail(long diseasesId,string ClassCode, string SpecificationCode);
        /// <summary>
        /// 删除可开药品
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DataResult<DiseasesMapperEntity> DeleteDetail(long entityId);

    }
}
