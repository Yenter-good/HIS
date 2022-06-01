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
    /// 系统参数服务
    /// </summary>
    public interface ISystemParameterService : IServiceSingleton
    {
        /// <summary>
        /// 获取指定名称的参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <returns></returns>
        T Get<T>(string code);
        /// <summary>
        /// 获取指定名称的参数值
        /// 当不存在时系统自动添加改参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        T GetOrAdd<T>(string code, T value, string name, string propertyName, string memo = null);
        /// <summary>
        /// 获取全部系统参数
        /// </summary>
        /// <returns></returns>
        DataResult<List<SysParameterEntity>> GetAll();
        /// <summary>
        /// 判断是否存在指定参数
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool Exist(string code);
        /// <summary>
        /// 更新指定编码参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Update<T>(string code, T value);
        /// <summary>
        /// 更新数据状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>
        bool UpdateDataStatusById(long id, DataStatus dataStatus);
        /// <summary>
        /// 更新系统参数
        /// </summary>
        /// <param name="sysParameterEntity">系统参数实体</param>
        /// <returns></returns>
        DataResult Update(SysParameterEntity sysParameterEntity);
    }
}
