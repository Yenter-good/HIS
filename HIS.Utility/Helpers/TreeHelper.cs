using System;
using System.Collections.Generic;
using System.Linq;
using DevComponents.AdvTree;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.Controls;
using System.ComponentModel;

namespace HIS.Utility
{
    public static class TreeHelper
    {

        /// <summary>
        /// 递归创建Node给advTree 控件使用
        /// </summary>
        /// <param name="ParentNode">父节点</param>
        /// <param name="ParentCode">显示文本</param>
        /// <param name="Source">数据</param>
        public static void CreateChildsNode(NodeCollection ParentNode, string ParentCode, List<TreeModelAdv> Source, bool ShowCheckBox, ImageList Img = null, bool IsSort = false)
        {
            List<TreeModelAdv> tmp = Source.Where(p => p.ParentCode == ParentCode).ToList();

            if (IsSort)
                tmp = tmp.OrderBy(p => p.Sort).ToList();

            if (tmp.Count == 0)  //递归终止，区域不包含子区域时
            {
                return;
            }

            foreach (TreeModelAdv item in tmp)
            {
                Node node = new Node();
                node.Tag = item.Obj;
                node.Text = item.Text;
                node.Name = item.Name;
                node.CheckBoxVisible = ShowCheckBox;
                node.ImageIndex = item.ImgIndex;
                if (Img != null)
                    node.Image = Img.Images[item.ImgIndex];
                //添加子节点
                ParentNode.Add(node);
                //递归
                CreateChildsNode(node.Nodes, item.Code, Source, ShowCheckBox, Img, IsSort);
            }

        }

        /// <summary>
        /// 递归创建Node给原生tree控件使用
        /// </summary>
        /// <param name="ParentNode">父节点</param>
        /// <param name="ParentCode">显示文本</param>
        /// <param name="Source">数据</param>
        public static void CreateChildsNode(TreeNodeCollection ParentNode, string ParentCode, List<TreeModel> Source)
        {
            List<TreeModel> tmp = Source.Where(p => p.ParentCode == ParentCode).ToList();
            if (tmp.Count == 0)  //递归终止，区域不包含子区域时
            {
                return;
            }

            foreach (TreeModel item in tmp)
            {
                TreeNode node = new TreeNode();
                node.Tag = item.Tag;
                node.Text = item.Text;
                node.Name = item.Text;
                //添加子节点
                ParentNode.Add(node);
                //递归
                CreateChildsNode(node.Nodes, item.Code, Source);
            }
        }
        #region AdvTree
        /// <summary>
        /// 枚举指定advTree树节点
        /// </summary>
        /// <param name="nd">树节点</param>
        /// <param name="handler">针对树节点处理的方法</param>
        /// <param name="includeSelf">是否包含自身节点</param>
        public static void Enumerate(Node nd, NodeEnumerateEventHandler handler, bool includeSelf = true)
        {
            NodeEnumerateEventArgs args = new NodeEnumerateEventArgs();
            if (includeSelf)
            {
                args.Node = nd;
                args.EnumerateChild = true;
                args.Cancel = false;
                InnerEnumerate(handler, args);
            }
            else
            {
                foreach (Node childnd in nd.Nodes)
                {
                    args.Node = childnd;
                    args.EnumerateChild = true;
                    args.Cancel = false;
                    InnerEnumerate(handler, args);
                    if (args.Cancel)
                        break;
                }
            }
        }
        /// <summary>
        /// 枚举advTree树所有节点
        /// </summary>
        /// <param name="advTree"></param>
        /// <param name="handler"></param>
        public static void Enumerate(AdvTree advTree, NodeEnumerateEventHandler handler)
        {
            NodeEnumerateEventArgs args = new NodeEnumerateEventArgs();
            foreach (Node nd in advTree.Nodes)
            {
                args.Node = nd;
                args.EnumerateChild = true;
                args.Cancel = false;
                InnerEnumerate(handler, args);
                if (args.Cancel)
                    break;
            }
        }
        /// <summary>
        /// 内部advTree枚举树节点的方法
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="args"></param>
        private static void InnerEnumerate(NodeEnumerateEventHandler handler, NodeEnumerateEventArgs args)
        {
            handler(args);
            if (args.Cancel) return;
            if (args.EnumerateChild)
            {
                foreach (Node nd in args.Node.Nodes)
                {
                    args.Node = nd;
                    InnerEnumerate(handler, args);
                    if (args.Cancel) break;
                }
            }
            //args.EnumerateChild = true;
        }

        /// <summary>
        /// 获取在拖拽之前改变的节点索引
        /// </summary>
        /// <param name="TV"></param>
        /// <param name="OldParentNode"></param>
        /// <param name="newParentNode"></param>
        /// <param name="OldNodeIndex"></param>
        /// <param name="InsertPosition"></param>
        /// <returns></returns>
        public static Dictionary<Node, int> GetBeforeNodeDragChangedIndex(AdvTree TV, Node OldParentNode, Node NewParentNode, int OldNodeIndex, int InsertPosition)
        {
            Dictionary<Node, int> sortDict = new Dictionary<Node, int>();
            int last = OldNodeIndex;
            NodeCollection newNodes;
            NodeCollection oldNodes;
            if (OldParentNode != NewParentNode)
            {
                newNodes = (NewParentNode == null ? TV.Nodes : NewParentNode.Nodes);
                last = newNodes.Count;

                oldNodes = (OldParentNode == null ? TV.Nodes : OldParentNode.Nodes);
                for (int i = OldNodeIndex + 1; i < oldNodes.Count; i++)
                {
                    sortDict.Add(oldNodes[i], i - 1);
                }
            }
            else
            {
                oldNodes = newNodes = (OldParentNode == null ? TV.Nodes : OldParentNode.Nodes);
            }
            for (int i = InsertPosition + 1; i < last; i++)
            {
                sortDict.Add(newNodes[i], i + 1);
            }

            if (!sortDict.ContainsKey(oldNodes[OldNodeIndex]))
            {
                sortDict.Add(oldNodes[OldNodeIndex], InsertPosition + 1);
            }

            return sortDict;
        }

        public static void FillNodes(AdvTree TV, List<TreeModel> Source, bool ShowCheckBox = false, Action<Node, TreeModel> NodeFormat = null)
        {
            FillNodes(TV, CreateChildNodes(Source, ShowCheckBox, NodeFormat));
        }
        public static void FillNodes(AdvTree TV, Node[] Nodes)
        {
            TV.Nodes.Clear();
            TV.BeginUpdate();

            if (Nodes != null)
                TV.Nodes.AddRange(Nodes);

            TV.EndUpdate();
        }
        /// <summary>
        /// 递归创建Node给superGrid 控件使用
        /// </summary>
        /// <param name="ParentNode">父节点</param>
        /// <param name="ParentCode">显示文本</param>
        /// <param name="Source">数据</param>
        public static Node[] CreateChildNodes(List<TreeModel> Source, bool ShowCheckBox = false, Action<Node, TreeModel> NodeFormat = null)
        {
            List<Node> rows = new List<Node>();
            foreach (var item in Source.Where(s => !Source.Exists(ss => ss.Code == s.ParentCode)).OrderBy(d => d.Sort))
            {
                rows.Add(CreateChildNode(item, Source, ShowCheckBox, NodeFormat));
            }
            return rows.ToArray();
        }
        //public static Node GetNode(TreeModel tm, bool ShowCheckBox = false, Action<Node, TreeModel> NodeFormat = null)
        //{
        //    Node node = new Node(tm.Text);
        //    node.Name = tm.Code;
        //    node.Tag = tm.Tag;
        //    //格式化行
        //    if (NodeFormat != null)
        //    {
        //        NodeFormat(node, tm);
        //    }
        //    return node;
        //}
        private static Node CreateChildNode(TreeModel ParentNode, List<TreeModel> Source, bool ShowCheckBox = false, Action<Node, TreeModel> NodeFormat = null)
        {
            Node parentNode = new Node(ParentNode.Text);
            parentNode.Name = ParentNode.Code;
            parentNode.Tag = ParentNode.Tag;
            parentNode.CheckBoxVisible = ShowCheckBox;
            if (ParentNode.Cells != null && ParentNode.Cells.Length > 0)
            {
                foreach (var item in ParentNode.Cells)
                {
                    var cell = new Cell();
                    cell.Text = item.AsNotNullString();
                    cell.Tag = item;
                    parentNode.Cells.Add(cell);
                }
            }
            //格式化行
            if (NodeFormat != null)
            {
                NodeFormat(parentNode, ParentNode);
            }
            List<TreeModel> tmp = Source.Where(p => p.ParentCode == ParentNode.Code).ToList();
            if (tmp.Count == 0) return parentNode;

            foreach (var item in tmp)
            {
                parentNode.Nodes.Add(CreateChildNode(item, Source, ShowCheckBox, NodeFormat));
            }
            return parentNode;
        }

        #endregion

        #region TreeView
        [Obsolete("此方法已作废，请使用其他函数")]
        public static void FillNodes(TreeView TV, List<TreeModel> Source, Action<TreeNode, TreeModel> NodeFormat = null)
        {
            FillNodes(TV, CreateChildNodes(Source, NodeFormat));
        }
        public static void FillNodes(TreeView TV, TreeNode[] Nodes)
        {
            TV.Nodes.Clear();
            TV.BeginUpdate();

            if (Nodes != null)
                TV.Nodes.AddRange(Nodes);

            TV.EndUpdate();
        }
        /// <summary>
        /// 递归创建Node给superGrid 控件使用
        /// </summary>
        /// <param name="ParentNode">父节点</param>
        /// <param name="ParentCode">显示文本</param>
        /// <param name="Source">数据</param>
        public static TreeNode[] CreateChildNodes(List<TreeModel> Source, Action<TreeNode, TreeModel> NodeFormat = null)
        {
            List<TreeNode> rows = new List<TreeNode>();
            foreach (var item in Source.Where(s => TreeModel.IsRootNode(s.ParentCode)))
            {
                rows.Add(CreateChildNodes(item, Source, NodeFormat));
            }
            return rows.ToArray();
        }

        private static TreeNode CreateChildNodes(TreeModel ParentNode, List<TreeModel> Source, Action<TreeNode, TreeModel> NodeFormat = null)
        {
            TreeNode parentNode = new TreeNode(ParentNode.Text);
            parentNode.Name = ParentNode.Code;
            parentNode.Tag = ParentNode.Tag;
            //格式化行
            if (NodeFormat != null)
            {
                NodeFormat(parentNode, ParentNode);
            }
            List<TreeModel> tmp = Source.Where(p => p.ParentCode == ParentNode.Code).ToList();
            if (tmp.Count == 0) return parentNode;

            foreach (var item in tmp)
            {
                parentNode.Nodes.Add(CreateChildNodes(item, Source, NodeFormat));
            }
            return parentNode;
        }

        #endregion

        #region SuperGrid

        public static void FillGrid(GridPanel Grid, List<TreeModel> Source, Action<GridRow, TreeModel> NodeFormat = null)
        {
            FillGrid(Grid, CreateGridRows(Source, NodeFormat));
        }
        public static void FillGrid(GridPanel Grid, GridRow[] Rows)
        {
            Grid.Rows.Clear();
            Grid.SuperGrid.BeginUpdate();

            if (Rows != null)
                Grid.Rows.AddRange(Rows);

            Grid.SuperGrid.EndUpdate();
        }
        /// <summary>
        /// 递归创建Node给superGrid 控件使用
        /// </summary>
        /// <param name="ParentNode">父节点</param>
        /// <param name="ParentCode">显示文本</param>
        /// <param name="Source">数据</param>
        public static GridRow[] CreateGridRows(List<TreeModel> Source, Action<GridRow, TreeModel> NodeFormat = null)
        {
            List<GridRow> rows = new List<GridRow>();
            foreach (var item in Source.Where(s => TreeModel.IsRootNode(s.ParentCode)))
            {
                rows.Add(CreateGridRows(item, Source, NodeFormat));
            }
            return rows.ToArray();
        }

        private static GridRow CreateGridRows(TreeModel ParentNode, List<TreeModel> Source, Action<GridRow, TreeModel> NodeFormat = null)
        {
            var parentRow = CreateGridRow(ParentNode, NodeFormat);
            List<TreeModel> tmp = Source.Where(p => p.ParentCode == ParentNode.Code).ToList();
            if (tmp.Count == 0) return parentRow;

            foreach (var item in tmp)
            {
                parentRow.Rows.Add(CreateGridRows(item, Source, NodeFormat));
            }
            return parentRow;
        }
        public static GridRow CreateGridRow(TreeModel Node, Action<GridRow, TreeModel> NodeFormat = null)
        {

            GridRow row = new GridRow(Node.Cells);

            row.Tag = Node;
            //格式化行
            if (NodeFormat != null)
            {
                NodeFormat(row, Node);
            }
            return row;
        }
        /// <summary>
        /// 查找行
        /// </summary>
        /// <param name="GIC"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        public static GridRow FindGridRow(GridItemsCollection GIC, string Code)
        {
            if (GIC == null || GIC.Count == 0) return null;
            foreach (GridRow GR in GIC)
            {
                var TM = GR.Tag as TreeModel;
                if (TM.Code == Code)
                    return GR;
                else
                {
                    var FindRow = FindGridRow(GR.Rows, Code);
                    if (FindRow == null) continue;
                    return FindRow;
                }
            }
            return null;
        }
        /// <summary>
        /// 通过序号获取贴近改序号的行索引
        /// </summary>
        /// <param name="GIC"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static int GetNearlestGridRowIndex(GridItemsCollection GIC, int sort)
        {
            int index = 0;
            foreach (GridRow GR in GIC)
            {
                var TM = GR.Tag as TreeModel;
                if (sort < TM.Sort)
                    return index;
                index++;
            }
            return index;
        }
        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="GR"></param>
        public static void GridRowDelete(GridRow GR)
        {
            if (GR == null) return;
            if (GR.Parent == null) return;
            GR.IsDeleted = true;
            GR.GridPanel.PurgeDeletedRows();

        }
        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="GP"></param>
        /// <param name="TM"></param>
        /// <param name="RowFormat"></param>
        /// <param name="EnsureVisible"></param>
        public static GridRow AddGridRow(GridPanel GP, TreeModel TM, Action<GridRow, TreeModel> RowFormat = null, bool EnsureVisible = true)
        {
            var PRow = FindGridRow(GP.Rows, TM.ParentCode);
            var Rows = PRow == null ? GP.Rows : PRow.Rows;
            var NewRow = CreateGridRow(TM, RowFormat);
            Rows.Insert(GetNearlestGridRowIndex(Rows, TM.Sort), NewRow);
            if (EnsureVisible && !NewRow.IsOnScreen)
            {
                NewRow.EnsureVisible();
            }
            NewRow.IsSelected = true;
            return NewRow;
        }
        /// <summary>
        /// 通过树节点实体刷新行显示
        /// </summary>
        /// <param name="GR"></param>
        /// <param name="Node"></param>
        /// <param name="NodeFormat"></param>
        public static GridRow RefreshGridRow(GridRow GR, TreeModel Node, Action<GridRow, TreeModel> NodeFormat = null, bool EnsureVisible = true)
        {
            var TM = GR.Tag as TreeModel;
            //判断父节点是否发生变化
            if (TM.ParentCode != Node.ParentCode)
            {
                GridItemsCollection GIC = null;
                if (TreeModel.IsRootNode(Node.ParentCode))
                    GIC = GR.GridPanel.Rows;
                else
                {
                    //发生变化 则找到新的父节点
                    var ParentRow = FindGridRow(GR.GridPanel.Rows, Node.ParentCode);
                    //如果父节点有效
                    if (ParentRow != null)
                        GIC = ParentRow.Rows;
                }

                if (GIC != null)
                {

                    var row = CreateGridRow(Node, NodeFormat);
                    //向新的父节点添加节点
                    GIC.Insert(GetNearlestGridRowIndex(GIC, Node.Sort), row);
                    //移除历史的节点
                    GridRowDelete(GR);
                    if (EnsureVisible && !row.IsOnScreen)
                        row.EnsureVisible();
                    row.IsSelected = true;
                    //退出
                    return row;
                }

            }
            //如果序号发生变化则更新排序
            if (TM.Sort != Node.Sort)
            {
                GridItemsCollection GIC = null;
                if (GR.Parent is GridPanel)
                    GIC = (GR.Parent as GridPanel).Rows;
                else
                    GIC = (GR.Parent as GridRow).Rows;

                var row = CreateGridRow(Node, NodeFormat);
                //移除历史的节点
                GridRowDelete(GR);
                GIC.Insert(GetNearlestGridRowIndex(GIC, Node.Sort), row);
                if (EnsureVisible && !row.IsOnScreen)
                    row.EnsureVisible();
                row.IsSelected = true;

                return row;
            }
            GR.Tag = Node;
            if (Node.Cells != null && GR.Cells != null)
            {
                for (int i = 0; i < GR.Cells.Count; i++)
                {
                    GR.Cells[i].Value = Node.Cells[i];
                }
            }
            //格式化行
            if (NodeFormat != null)
            {
                NodeFormat(GR, Node);
            }
            if (EnsureVisible && !GR.IsOnScreen)
                GR.EnsureVisible();
            GR.IsSelected = true;
            return GR;
        }

        #endregion

        #region ComboTree

        public static void FillNodes(ComboTree CT, List<TreeModel> Source, bool ShowCheckBox = false, Action<Node, TreeModel> NodeFormat = null)
        {
            FillNodes(CT, CreateChildNodes(Source, ShowCheckBox, NodeFormat));
        }
        public static void FillNodes(ComboTree CT, Node[] Nodes)
        {
            CT.Nodes.Clear();
            CT.AdvTree.BeginUpdate();
            if (Nodes != null)
                CT.Nodes.AddRange(Nodes);

            CT.AdvTree.EndUpdate();
        }

        #endregion
    }
    /// <summary>
    /// 枚举advTree树节点的事件参数
    /// </summary>
    public class NodeEnumerateEventArgs : CancelEventArgs
    {
        /// <summary>
        /// 是否枚举子节点
        /// </summary>
        public bool EnumerateChild { get; set; }

        public Node Node { get; internal set; }

        public NodeEnumerateEventArgs()
        {
            this.EnumerateChild = true;
        }
    }

    /// <summary>
    /// 枚举advTree树节点的委托
    /// </summary>
    /// <param name="args"></param>
    public delegate void NodeEnumerateEventHandler(NodeEnumerateEventArgs args);
}
