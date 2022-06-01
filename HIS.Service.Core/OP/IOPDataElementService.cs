using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-20 11:15:32
    /// 描述:
    /// </summary>
    public interface IOPDataElementService : IServiceSingleton
    {
        /// <summary>
        /// 获取数据源
        /// </summary>
        /// <returns></returns>
        List<DataElementEntity> GetList();
        /// <summary>
        /// 检查编码是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool CodeExists(string code);
        /// <summary>
        /// 添加数据源
        /// </summary>
        /// <param name="dataElementEntity">数据源实体</param>
        /// <returns></returns>
        DataResult Insert(DataElementEntity dataElementEntity);
        /// <summary>
        /// 修改数据源
        /// </summary>
        /// <param name="code">编码</param>
        /// <param name="name">名称</param>
        /// <param name="id">Id</param>
        /// <returns></returns>
        DataResult Update(string code, string name, long id);
        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        DataResult Delete(long id);
    }
}
