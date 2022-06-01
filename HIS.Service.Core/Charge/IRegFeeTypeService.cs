using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface IRegFeeTypeService : IServiceSingleton
    {
        /// <summary>
        /// 新增号费
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<RegFeeType> AddFeeType(RegFeeType entity);

        /// <summary>
        /// 更改票据信息
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult<RegFeeType> UpdateFeeType(long entityId, RegFeeType entity);

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name=""></param>
        /// <returns></returns>
        DataResult<RegFeeType> DeleteFeeType(long entityId);
        /// <summary>
        /// 获取所有号费信息
        /// </summary>
        /// <returns></returns>
        List<RegFeeType> GetAll();

    }
}
