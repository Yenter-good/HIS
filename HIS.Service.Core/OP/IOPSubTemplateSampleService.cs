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
    public interface IOPSubTemplateSampleService : IServiceSingleton
    {
        /// <summary>
        /// 获取子模板列表
        /// </summary>
        /// <returns></returns>
        List<SubTemplateSampleEntity> GetList(long deptId);
        /// <summary>
        /// 删除子模板
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <returns></returns>
        DataResult Delete(long id);
        /// <summary>
        /// 添加子模板
        /// </summary>
        /// <param name="sampleEntity">子模板实体</param>
        /// <returns></returns>
        DataResult Insert(SubTemplateSampleEntity sampleEntity);
        /// <summary>
        /// 获取顺序号
        /// </summary>
        /// <param name="level">节点等级</param>
        /// <returns></returns>
        int GetNo(Level level);
        /// <summary>
        /// 更新子模板名称
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <param name="name">子模板名称</param>
        /// <returns></returns>
        DataResult UpdateName(long id, string name);
        /// <summary>
        /// 更新子模板内容
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <param name="content">子模板内容</param>
        /// <param name="templateNodeId">子模板绑定节点Id</param>
        /// <returns></returns>
        DataResult UpdateContent(long id, string content, long templateNodeId);
        /// <summary>
        /// 获取子模板内容
        /// </summary>
        /// <param name="id">子模板Id</param>
        /// <returns></returns>
        DataResult<string> GetContent(long id);
    }
}
