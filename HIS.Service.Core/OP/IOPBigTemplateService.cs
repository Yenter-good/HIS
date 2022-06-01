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
    /// 创建时间:2021-02-08 14:39:51
    /// 描述:
    /// </summary>
    public interface IOPBigTemplateService : IServiceSingleton
    {
        /// <summary>
        /// 获取大模板
        /// </summary>
        /// <returns></returns>
        List<BigTemplateEntity> GetList();
        /// <summary>
        /// 更新生效标识
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="deptId">科室Id</param>
        /// <param name="effectiveFlag">生效标识</param>
        /// <param name="bigTemplateType">模板类型</param>
        /// <returns></returns>
        DataResult UpdateEffectiveFlag(long id, long deptId, bool effectiveFlag, BigTemplateType bigTemplateType);
        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        DataResult Delete(long id);
        /// <summary>
        /// 修改模板名称
        /// </summary>
        /// <param name="newName">模板名称</param>
        /// <param name="id">模板Id</param>
        /// <returns></returns>
        DataResult UpdateName(string newName, long id);
        /// <summary>
        /// 创建新模板
        /// </summary>
        /// <param name="bigTemplateEntity">大模板实体</param>
        /// <returns></returns>
        DataResult Add(BigTemplateEntity bigTemplateEntity);
        /// <summary>
        /// 获取排序
        /// </summary>
        /// <param name="deptId">科室Id</param>
        /// <param name="bigTemplateType">大模板类型</param>
        /// <returns></returns>
        int GetNo(long deptId, BigTemplateType bigTemplateType);
        /// <summary>
        /// 更新模板内容
        /// </summary>
        /// <param name="id">模板Id</param>
        /// <param name="content">模板内容</param>
        /// <returns></returns>
        DataResult UpdateContent(long id, string content);
        /// <summary>
        /// 获取模板内容
        /// </summary>
        /// <param name="id">模板Id</param>
        /// <returns></returns>
        DataResult<string> GetContent(long id);
    }
}
