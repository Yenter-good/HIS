using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Core;
using DevComponents.AdvTree;
using HIS.Service.Core.Entities;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 数据源
    /// </summary>
    internal partial class UCDataElement : UserControl
    {
        /// <summary>
        /// 数据源服务
        /// </summary>

        private IOPDataElementService _oPDataElementService;
        /// <summary>
        /// 当前选中的节点
        /// </summary>
        private Node _currentSelectedNode
        {
            get { return this.AdvTreeDataElement.SelectedNode; }
        }
        /// <summary>
        /// 当前选中的数据源
        /// </summary>
        private DataElementEntity _currentSelectedDataElement
        {
            get
            {
                var node = this._currentSelectedNode;
                if (node == null)
                    return null;

                return node.Tag as DataElementEntity;
            }
        }
        public UCDataElement()
        {
            InitializeComponent();
        }

        #region 方法
        internal void Init()
        {
            if (this._oPDataElementService == null)
                this._oPDataElementService = ServiceLocator.GetService<IOPDataElementService>();
            var list = this._oPDataElementService.GetList();

            this.RootNode.Nodes.Clear();
            foreach (var item in list)
            {
                this.RootNode.Nodes.Add(this.CreateNode(item));
            }
        }
        private Node CreateNode(DataElementEntity dataElementEntity)
        {
            return new Node()
            {
                Tag = dataElementEntity,
                Text = dataElementEntity.Name
            };
        }
        #endregion

        #region 窗体事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = App.Instance.CreateView<FormDataElementEdit>();
            dialog.DataOperation = HIS.Service.Core.Enums.DataOperation.New;
            dialog.NewDataElement += (x, y) =>
            {
                var node = this.CreateNode(y);
                this.RootNode.Nodes.Add(this.CreateNode(y));
                node.EnsureVisible();
                this.AdvTreeDataElement.SelectedNode = node;
            };
            dialog.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var dialog = App.Instance.CreateView<FormDataElementEdit>();
            dialog.DataOperation = HIS.Service.Core.Enums.DataOperation.Modify;
            dialog.ModifyDataElementEntity = this._currentSelectedDataElement;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this._currentSelectedNode.Text = dialog.ModifyDataElementEntity.Name;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var dataElement = this._currentSelectedDataElement;
            var dialogResult = MsgBox.YesNo("是否删除数据源?名称为:" + dataElement.Name);
            if (dialogResult == DialogResult.Yes)
            {
                var result = this._oPDataElementService.Delete(dataElement.Id);
                if (result.Success)
                {
                    this.RootNode.Nodes.Remove(this._currentSelectedNode);
                }
                else
                    MsgBox.OK($"删除数据源失败\r\n{result.Message}");
            }
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void contextMenuBar1_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            var node = this._currentSelectedNode;

            this.btnAdd.Enabled = node != null && node.Level == 0;
            this.btnEdit.Enabled = node != null && node.Level > 0;
            this.btnRemover.Enabled = node != null && node.Level > 0;
        }

        private void AdvTreeDataElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this._currentSelectedDataElement != null)
                {
                    this.AdvTreeDataElement.DoDragDrop(new DataObject(nameof(DataElementEntity), this._currentSelectedDataElement), DragDropEffects.Move);
                }
            }
        }

        #endregion
    }
}
