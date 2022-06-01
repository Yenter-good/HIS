using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 药品品种定义服务
    /// </summary>
    public interface IWholehospitalClassService : IServiceSingleton
    {
        /// <summary>
        /// 根据药品类型获取药品品种列表
        /// </summary>
        /// <param name="drugType">药品类型</param>
        /// <param name="includeDisable">是否包含停用的数据</param>
        /// <returns></returns>
        DataResult<List<WholehospitalClassEntity>> GetListByDrugType(int drugType, bool includeDisable = false);
        /// <summary>
        /// 检查药品编码是否存在
        /// </summary>
        /// <param name="code">药品编码</param>
        /// <returns></returns>
        bool CodeExists(string code);
        /// <summary>
        /// 获取序号
        /// </summary>
        /// <param name="drugType">所属药品类型</param>
        /// <returns></returns>
        int GetNo(int drugType);
        /// <summary>
        /// 添加药品品种
        /// </summary>
        /// <param name="entity">药品品种实体</param>
        /// <returns></returns>
        DataResult Add(WholehospitalClassEntity entity);
        /// <summary>
        /// 药品修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult Update(WholehospitalClassEntity entity);
    }
}
