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
    /// 作者:wfg
    /// 创建时间:2021-03-01 10:07:16
    /// 描述:
    /// </summary>
    public interface IOPTemplateSampleService : IServiceSingleton
    {
        /// <summary>
        /// 获取范文列表
        /// </summary>
        /// <returns></returns>
        List<TemplateSampleEntity> GetList(long deptId);
        /// <summary>
        /// 删除范文
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <returns></returns>
        DataResult Delete(long id);
        /// <summary>
        /// 添加范文
        /// </summary>
        /// <param name="sampleEntity">范文实体</param>
        /// <returns></returns>
        DataResult Insert(TemplateSampleEntity sampleEntity);
        /// <summary>
        /// 获取顺序号
        /// </summary>
        /// <param name="level">节点等级</param>
        /// <returns></returns>
        int GetNo(Level level);
        /// <summary>
        /// 更新范文名称
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <param name="name">范文名称</param>
        /// <returns></returns>
        DataResult UpdateName(long id, string name);
        /// <summary>
        /// 更新范文内容
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <param name="content">范文内容</param>
        /// <returns></returns>
        DataResult UpdateContent(long id, string content);
        /// <summary>
        /// 获取范文内容
        /// </summary>
        /// <param name="id">范文Id</param>
        /// <returns></returns>
        DataResult<string> GetContent(long id);
    }
}
