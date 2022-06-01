using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIS.Service.Core
{
    /// <summary>
    /// 目录服务
    /// </summary>
    public interface ICatalogService : IServiceSingleton
    {
        /// <summary>
        /// 获取目录
        /// </summary>
        /// <returns></returns>
        DataResult<List<CatalogEntity>> GetAll();
        /// <summary>
        /// 获取序号
        /// </summary>
        /// <param name="parentId">父节点Id</param>
        /// <returns></returns>
        int GetNo(long parentId);
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="catalogEntity"></param>
        /// <returns></returns>
        DataResult Add(CatalogEntity catalogEntity);
        /// <summary>
        /// 修改目录名称
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult UpdateNameById(string name, long id);
    }
}