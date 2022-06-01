using System;
using System.Collections.Generic;

namespace HIS.Utility
{
    /// <summary>
    /// 通用树节点实体
    /// </summary>
    public class TreeModel
    {

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 父节点编码
        /// </summary>
        public string ParentCode { get; set; }
        /// <summary>
        /// 显示文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 用于类型树网格控件 填充单元格的值
        /// </summary>
        public object[] Cells { get; set; }
        /// <summary>
        /// 一般情况下存储实体对象
        /// </summary>
        public object Tag { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 判断是否为根节点
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool IsRootNode(string code)
        {
            string node = code.AsNotNullString();
            switch (node)
            {
                case "":
                case "ROOT":
                case "0":
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// 判断是否包含该子节点
        /// </summary>
        /// <param name="child"></param>
        /// <param name="allList"></param>
        /// <returns></returns>
        public bool ContainsChild(TreeModel child, List<TreeModel> allList)
        {
            if (child.ParentCode == this.Code) return true;
            var parent = allList.Find(d => d.ParentCode == child.ParentCode);
            while (parent!=null && parent.Code!=this.Code)
            {
                allList.Find(d => d.ParentCode == parent.ParentCode);
            }
            return parent != null && parent.Code == this.Code;
        }
        /// <summary>
        /// 判断是否包含任意子节点
        /// </summary>
        /// <param name="child"></param>
        /// <param name="allList"></param>
        /// <returns></returns>
        public bool AnyChild(List<TreeModel> childs, List<TreeModel> allList)
        {
            foreach (var item in childs)
            {
                if (this.ContainsChild(item, allList))
                    return true;
            }
            return false;
        }
    }

    public class TreeModelAdv
    {
        public string Code { get; set; }

        public string ParentCode { get; set; }

        public string Text { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public int ImgIndex { get; set; }

        public object Obj { get; set; }
    }
}
