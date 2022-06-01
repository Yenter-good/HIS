using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 费用类型服务
    /// </summary>
    public interface IFeeTypeService : IServiceSingleton
    {
        /// <summary>
        /// 获取全部费用类型
        /// </summary>
        /// <returns></returns>
        DataResult<List<FeeTypeEntity>> GetAll();
        /// <summary>
        /// 费用类型编码是否存在
        /// </summary>
        /// <param name="code">编码</param>
        /// <returns></returns>
        bool CodeExists(string code);
        /// <summary>
        /// 添加费用类型
        /// </summary>
        /// <param name="feeTypeEntity">费用类型实体</param>
        /// <returns></returns>
        DataResult Add(FeeTypeEntity feeTypeEntity);
        /// <summary>
        /// 更新费用类型
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="feeTypeEntity">费用类型实体</param>
        /// <returns></returns>
        DataResult Update(FeeTypeEntity feeTypeEntity);
    }
}
