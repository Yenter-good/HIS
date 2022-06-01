using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 目录实体类
    /// </summary>
    public class CatalogEntity
    {
        /// <summary>
        /// 父节点id
        /// </summary>
        public long ParentId { get; set; }
        /// <summary>
        /// 节点id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 目录名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DataStatus DataStatus { get; set; }

        /// <summary>
        /// 转换为通用的树节点
        /// </summary>
        /// <returns></returns>
        //public TreeModel CastToTreeModel()
        //{
        //    TreeModel treeModel = new TreeModel();
        //    treeModel.Code = this.Id.ToString();
        //    treeModel.ParentCode = this.ParentId.ToString();
        //    treeModel.Text = this.Name;
        //    treeModel.Tag = this;
        //    treeModel.Sort = this.No;
        //    return treeModel;
        //}
    }
}
