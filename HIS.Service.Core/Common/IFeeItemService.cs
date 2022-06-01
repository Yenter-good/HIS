using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IFeeItemService : IServiceSingleton
    {
        /// <summary>
        /// 添加收费项目
        /// </summary>
        /// <param name="feeItemEntity"></param>
        /// <returns></returns>
        DataResult Add(FeeItemEntity feeItemEntity);
        /// <summary>
        /// 根据收费类型的编码获取收费项目
        /// </summary>
        /// <param name="feeTypeCode">费用类型编码</param>
        /// <returns></returns>
        DataResult<List<FeeItemEntity>> GetListByFeeTypeCode(string feeTypeCode);
        /// <summary>
        /// 获取全部收费项目
        /// </summary>
        /// <returns></returns>
        DataResult<List<FeeItemEntity>> GetAll();
        /// <summary>
        /// 更新价表数据状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        DataResult UpdateDataStatusById(long id, DataStatus dataStatus);
        /// <summary>
        /// 更新门诊划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="oflag">是否可用</param>
        /// <returns></returns>
        DataResult UpdateOFlagById(long id, bool oflag);
        /// <summary>
        /// 更新住院划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="iflag">是否可用</param>
        /// <returns></returns>
        DataResult UpdateIFlagById(long id, bool iflag);
        /// <summary>
        /// 更新手术划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="sflag">是否可用</param>
        /// <returns></returns>
        DataResult UpdateSFlagById(long id, bool sflag);
        /// <summary>
        /// 更新医技划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="mflag">是否可用</param>
        /// <returns></returns>
        DataResult UpdateMFlagById(long id, bool mflag);
        /// <summary>
        /// 更新价格可变标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="variableFlag">是否可用</param>
        /// <returns></returns>
        DataResult UpdateVariableFlagById(long id, bool variableFlag);
        /// <summary>
        /// 更新收费项目
        /// </summary>
        /// <param name="feeItemEntity">收费项目</param>
        /// <returns></returns>
        DataResult Update(FeeItemEntity feeItemEntity);
        /// <summary>
        /// 检索查询
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        DataResult<List<FeeItemEntity>> GetListByInputValue(string inputValue);

    }
}
