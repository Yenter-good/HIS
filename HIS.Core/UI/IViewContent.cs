
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HIS.Core.UI
{
    /// <summary>
    /// 工作视图
    /// </summary>
    public interface IViewContent : IDisposable
    {
        /// <summary>
        /// 视图共享的数据
        /// </summary>
        ViewData ViewData { get; }
        /// <summary>
        /// 尝试设置视图单位信息
        /// </summary>
        /// <param name="deptId">科室id</param>
        /// <returns></returns>
        bool SetViewUnitData(long deptId);
        /// <summary>
        /// 是否开启科室列表
        /// </summary>
        bool ShowDeptList { get; set; }
        /// <summary>
        /// 过滤当前视图所拥有的科室实体
        /// </summary>
        /// <returns></returns>
        List<DeptEntity> FilterViewDeptList();
        /// <summary>
        /// 创建参数
        /// </summary>
        string CreateParame { get; set; }

        bool Close();
    }
}
