using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Service.Core.Entities;

namespace HIS.Service.Core
{
    public interface ISysDicDetailService : IServiceSingleton
    {
        /// <summary>
        /// 根据字典编码获取明细
        /// </summary>
        /// <param name="dicCode"></param>
        /// <param name="includeDisable">是否包含停用的</param>
        /// <returns></returns>
        List<SysDicDetailEntity> GetListByDicCode(string dicCode, bool includeDisable = false);
        /// <summary>
        /// 是否存在内置字典明细
        /// </summary>
        /// <param name="dicCode">字典编码</param>
        /// <returns></returns>
        bool BuiltInDicDetailExists(string dicCode);
        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult Add(SysDicDetailEntity entity);
        /// <summary>
        /// 更新明细
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DataResult Update(SysDicDetailEntity entity);
        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
         DataResult Delete(long Id);
        /// <summary>
        /// 删除全部明细
        /// </summary>
        /// <param name="dicCode"></param>
        /// <returns></returns>
        DataResult DeleteAll(string dicCode);
        /// <summary>
        /// 明细编码是否重复
        /// </summary>
        /// <param name="code"></param>
        /// <param name="dicCode"></param>
        /// <returns></returns>
        bool ExistCode(string code, string dicCode);
    }
}
