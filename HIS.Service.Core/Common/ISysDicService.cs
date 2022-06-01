using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core
{
    public interface ISysDicService : IServiceSingleton
    {

        /// <summary>
        /// 获取系统字典
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        List<SysDicEntity> GetList(bool includeDisable = false);
        /// <summary>
        /// 获取字典类型信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        SysDicEntity GetByCode(string code);
        List<ItemEntity> GetList(string dictType);



        /// <summary>
        /// 字典编码是否存在
        /// </summary>
        /// <param name="code">字典编码</param>
        /// <returns></returns>
        bool CodeExists(string code);
        /// <summary>
        /// 获取排序值
        /// </summary>
        /// <param name="catalogId">所属目录Id</param>
        /// <returns></returns>
        int GetNo(long catalogId);
        /// <summary>
        /// 添加字典
        /// </summary>
        /// <param name="sysDicEntity">字典实体</param>
        /// <returns></returns>
        DataResult Add(SysDicEntity sysDicEntity);
        /// <summary>
        /// 获取字典
        /// </summary>
        /// <returns></returns>
        DataResult<List<SysDicEntity>> GetAll();
        /// <summary>
        /// 修改字典名称
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="name">字典名称</param>
        /// <returns></returns>
        DataResult UpdateNameById(long id, string name);
        /// <summary>
        /// 修改字典
        /// </summary>
        /// <param name="sysDicEntity">字典实体</param>
        /// <returns></returns>
        DataResult Update(SysDicEntity sysDicEntity);
        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="code">字典编码</param>
        /// <returns></returns>
        DataResult Delete(long id, string code);
        /// <summary>
        /// 更新字典状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="code">字典编码</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        DataResult UpdateDataStatus(long id, string code, DataStatus dataStatus);
    }
}
