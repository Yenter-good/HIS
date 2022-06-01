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
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using DevComponents.AdvTree;
using HIS.DSkinControl;
using HIS.Utility;

namespace App_OP.MedicalRecord
{
    internal partial class UCBaseSubTemplateSampleTree : UserControl
    {
        /// <summary>
        /// 子模板服务
        /// </summary>
        internal IOPSubTemplateSampleService OPSubTemplateSampleService;
        /// <summary>
        /// 子模板列表
        /// </summary>
        internal List<SubTemplateSampleEntity> SubTemplateSamples;
        /// <summary>
        /// 当前选中的节点
        /// </summary>
        internal Node CurrentSelectedNode
        {
            get
            {
                return this.advTree.SelectedNode;
            }
        }
        /// <summary>
        /// 当前选中的子模板
        /// </summary>
        internal SubTemplateSampleEntity CurrentSelectedSubTemplateSample
        {
            get
            {
                var selectedNode = this.CurrentSelectedNode;
                if (selectedNode == null || selectedNode.Level == 0)
                    return null;
                var subTemplateSample = selectedNode.Tag as SubTemplateSampleEntity;

                this.FillContent(subTemplateSample);

                return subTemplateSample;
            }
        }
        /// <summary>
        /// 科室
        /// </summary>
        internal DeptEntity DeptEntity;
        /// <summary>
        /// 科室节点
        /// </summary>
        internal Node DeptNode;
        /// <summary>
        /// 用户节点
        /// </summary>
        internal Node UserNode;
        /// <summary>
        /// 构造函数
        /// </summary>
        public UCBaseSubTemplateSampleTree()
        {
            InitializeComponent();
        }

        #region 方法
        internal virtual void Init()
        {
            this.ShowMask(() =>
            {
                this.InitData();
                this.InitUI();
            });
        }
        internal virtual void FillContent(SubTemplateSampleEntity sampleEntity)
        {
            if (sampleEntity != null && sampleEntity.Content == null)
            {
                var result = this.OPSubTemplateSampleService.GetContent(sampleEntity.Id);
                if (result.Success)
                    sampleEntity.Content = result.Value;
                else
                    MsgBox.OK($"获取子模板内容失败\r\n{result.Message}");
            }
        }
        internal virtual void InitUI()
        {
            this.advTree.Nodes.Clear();
            this.DeptNode = this.CreateRootNode(Level.Dept);
            this.UserNode = this.CreateRootNode(Level.User);
            this.advTree.Nodes.Add(this.DeptNode);
            this.advTree.Nodes.Add(this.UserNode);
            this.BindTemplateSample(this.DeptNode, 0, Level.Dept);
            this.BindTemplateSample(this.UserNode, 0, Level.User);
        }
        internal virtual void BindTemplateSample(Node parentNode, long parentId, Level level, List<SubTemplateSampleEntity> sampleEntities = null)
        {
            List<SubTemplateSampleEntity> data = sampleEntities == null ? this.SubTemplateSamples : sampleEntities;

            var templateSamples = data.Where(d => d.ParentId == parentId && d.Level == level).ToList();
            foreach (var templateSample in templateSamples)
            {
                var node = this.CreateSubTemplateSampleNode(templateSample);
                parentNode.Nodes.Add(node);

                this.BindTemplateSample(node, templateSample.Id, level);
            }
        }
        internal virtual void InitData()
        {
            if (this.OPSubTemplateSampleService == null)
                this.OPSubTemplateSampleService = ServiceLocator.GetService<IOPSubTemplateSampleService>();
            this.SubTemplateSamples = this.OPSubTemplateSampleService.GetList(this.DeptEntity.Id);
        }
        internal virtual Node CreateRootNode(Level level)
        {
            return new Node
            {
                Text = level.GetDescription(),
                Tag = level,
                Expanded = true
            };
        }
        internal virtual Node CreateSubTemplateSampleNode(SubTemplateSampleEntity sampleEntity)
        {
            return new Node
            {
                Text = sampleEntity.Name,
                Tag = sampleEntity,
                Image = this.imageList.Images[(int)sampleEntity.NodeType],
                Expanded = true
            };
        }
        internal virtual void SaveContent(string content)
        {
            var dialog = App.Instance.CreateView<FormBindTemplateNode>();
            dialog.SelectedTemplateNodeId = this.CurrentSelectedSubTemplateSample.TemplateNodeId.GetValueOrDefault(0);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var result = this.OPSubTemplateSampleService.UpdateContent(this.CurrentSelectedSubTemplateSample.Id, content, dialog.SelectedTemplateNodeId);
                if (result.Success)
                {
                    this.CurrentSelectedSubTemplateSample.Content = content;
                    this.CurrentSelectedSubTemplateSample.TemplateNodeId = dialog.SelectedTemplateNodeId;
                    AlertBox.Info("子模板保存成功");
                }
                else
                    MsgBox.OK($"子模板保存失败\r\n{result.Message}");
            }
        }
        internal virtual void GetParentIds(long id, ref List<long> ids)
        {
            if (!ids.Exists(d => d == id))
            {
                var current = this.SubTemplateSamples.Find(p => p.Id == id);
                ids.Add(id);
                if (current != null)
                    this.GetParentIds(current.ParentId, ref ids);
            }
        }
        internal virtual void Filter()
        {
            if (this.SubTemplateSamples == null || this.SubTemplateSamples.Count == 0)
                return;

            string inputTxt = this.tbxSearch.Text.Trim().ToUpper();
            if (inputTxt == "")
            {
                this.InitUI();
                return;
            }

            var filterSubTemplateSamples = this.SubTemplateSamples.Where(d => d.Name.Contains(inputTxt) || d.SearchCode.Contains(inputTxt) || d.WubiCode.Contains(inputTxt)).ToList();
            if (filterSubTemplateSamples == null || filterSubTemplateSamples.Count == 0)
                return;

            var ids = new List<long>();
            var filterIds = filterSubTemplateSamples.Select(d => d.Id).ToList();

            foreach (var id in filterIds)
            {
                this.GetParentIds(id, ref ids);
            }

            filterSubTemplateSamples = this.SubTemplateSamples.Where(d => d.Id._In(ids)).ToList();
            this.DeptNode.Nodes.Clear();
            this.UserNode.Nodes.Clear();
            this.BindTemplateSample(this.DeptNode, 0, Level.Dept, filterSubTemplateSamples);
            this.BindTemplateSample(this.UserNode, 0, Level.User, filterSubTemplateSamples);
        }
        #endregion

        #region 事件
        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            this.Filter();
        }
        #endregion
    }
}
