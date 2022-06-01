using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 药品规格服务
    /// </summary>
    public interface IWholehospitalSpecificationService : IServiceSingleton
    {
        /// <summary>
        /// 根据药典编码获取药品规格列表
        /// </summary>
        /// <param name="classCode">药典编码</param>
        /// <param name="includeDisable">是否包含停用的数据</param>
        /// <returns></returns>
        DataResult<List<WholehospitalSpecificationEntity>> GetListByClassCode(string classCode, bool includeDisable = false);
        /// <summary>
        /// 根据规格编码获取序号
        /// </summary>
        /// <param name="classCode">药典编码</param>
        /// <returns></returns>
        int GetNo(string classCode);
        /// <summary>
        /// 添加药品规格
        /// </summary>
        /// <param name="newEntity">药品规格实体</param>
        /// <returns></returns>
        DataResult Add(WholehospitalSpecificationEntity newEntity);
        /// <summary>
        /// 修改药品规格
        /// </summary>
        /// <param name="modifyEntity">药品规格实体</param>
        /// <returns></returns>
        DataResult Update(WholehospitalSpecificationEntity modifyEntity);
        /// <summary>
        /// 检查药品规格编码是否存在
        /// </summary>
        /// <param name="code">规格编码</param>
        /// <returns></returns>
        bool CodeExists(string code);
        /// <summary>
        /// 更新药品规格状态
        /// </summary>
        /// <param name="entity">药品规格实体</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        DataResult UpdateDataStatus(WholehospitalSpecificationEntity entity, DataStatus dataStatus);
    }
}
