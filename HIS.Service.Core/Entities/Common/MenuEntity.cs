using HIS.Service.Core;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class MenuEntity
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 程序集
        /// </summary>
        public string Assmely { get; set; }
        /// <summary>
        /// 全命名空间名称
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 菜单样式
        /// </summary>
        public MenuStyle? Style { get; set; }
        /// <summary>
        /// 初始化参数
        /// </summary>
        public string InitParam { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DataStatus Status { get; set; }
        public MenuEntity Parent { get; set; }
        public AppEntity AppInfo { get; set; }
        /// <summary>
        /// 图片相对路径
        /// </summary>
        public string ImagePath { get; set; }
    }
}
