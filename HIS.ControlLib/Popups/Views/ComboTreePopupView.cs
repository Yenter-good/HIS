using DevComponents.AdvTree;
using HIS.Utility.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HIS.ControlLib.FilterTree;

namespace HIS.ControlLib.Popups
{
    public partial class ComboTreePopupView : UserControl
    {
        private List<DataEntry> _dataSource;

        public ComboTreePopupView()
        {
            InitializeComponent();
            this.txtFilter.LostFocus += ViewLostFocus;

        }

        public event EventHandler ViewLostFocus;
        public event EventHandler<DataEntry> SelectedEntryChanged;

        /// <summary>
        /// 弹出框的高度
        /// </summary>
        [Description("弹出框的高度")]
        [Browsable(true)]
        public int PopupHeight { get; set; } = 500;
        /// <summary>
        /// 默认根节点ID
        /// </summary>
        [Description("默认根节点ID")]
        [Browsable(true)]
        public long RootId { get; set; } = 0;

        public new void Focus()
        {
            this.txtFilter.Focus();
        }
        /// <summary>
        /// 数据源
        /// </summary>
        public List<DataEntry> DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                this._dataSource = value;
                this.treeFilter.Nodes.Clear();
                if (_dataSource != null)
                {
                    BuildTree(_dataSource, RootId, this.treeFilter.Nodes);
                    this.treeFilter.ExpandAll();
                    if (this.treeFilter.Nodes.Count > 0)
                        this.treeFilter.SelectedNode = this.treeFilter.Nodes[0];
                }
            }
        }

        private void BuildTree(IEnumerable<DataEntry> dataEntries, long parentId, NodeCollection nodes)
        {
            var parents = dataEntries.Where(p => p.ParentId == parentId);
            foreach (var parent in parents)
            {
                var node = new Node(parent.Name);
                node.Name = parent.Id.ToString();
                node.Tag = parent;

                nodes.Add(node);
                BuildTree(dataEntries, parent.Id, node.Nodes);
            }
        }
        /// <summary>
        /// 获取指定id得上级所有id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        private void GetParentIds(long id, ref List<long> ids)
        {
            if (!ids.Contains(id))
            {
                var current = _dataSource.Find(p => p.Id == id);
                ids.Add(id);
                if (current != null)
                    GetParentIds(current.ParentId, ref ids);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.txtFilter.TextChanged -= txtFilter_TextChanged;
            this.treeFilter.Nodes.Clear();

            if (this.txtFilter.Text == "")
            {
                BuildTree(_dataSource, RootId, this.treeFilter.Nodes);
                this.treeFilter.ExpandAll();
            }
            else
            {
                var searchCode = this.txtFilter.Text.ToUpper();
                var filterEntries = _dataSource.Where(p =>
                                               {
                                                   for (int i = 0; i < p.SearchValues.Length; i++)
                                                   {
                                                       if (p.SearchValues[i].Contains(searchCode))
                                                           return true;
                                                   }
                                                   return false;
                                               }).ToList();
                var filterIds = new List<long>();
                foreach (var filterEntry in filterEntries)
                    GetParentIds(filterEntry.Id, ref filterIds);
                filterEntries = _dataSource.Where(p => p.Id._In(filterIds)).ToList();

                BuildTree(filterEntries, RootId, this.treeFilter.Nodes);
                this.treeFilter.ExpandAll();
                if (this.treeFilter.Nodes.Count > 0)
                    this.treeFilter.SelectedNode = this.treeFilter.Nodes[0];
            }

            this.txtFilter.TextChanged += txtFilter_TextChanged;

        }

        private void treeFilter_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            var entry = e.Node.Tag as DataEntry;
            SelectedEntryChanged?.Invoke(this, entry);
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            var selectedNode = this.treeFilter.SelectedNode;

            if (e.KeyCode == Keys.Down)
            {
                if (selectedNode == null)
                {
                    if (this.treeFilter.Nodes.Count > 0)
                        this.treeFilter.SelectedNode = this.treeFilter.Nodes[0];
                }
                else
                    this.treeFilter.SelectedNode = selectedNode.NextVisibleNode;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (selectedNode == null)
                {
                    if (this.treeFilter.Nodes.Count > 0)
                        this.treeFilter.SelectedNode = this.treeFilter.Nodes[0];
                }
                else
                    this.treeFilter.SelectedNode = selectedNode.PrevVisibleNode;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SelectedEntryChanged?.Invoke(this, selectedNode.Tag as DataEntry);
            }
        }
    }
}
