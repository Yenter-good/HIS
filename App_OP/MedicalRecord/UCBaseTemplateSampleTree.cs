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

namespace App_OP.MedicalRecord
{
    internal partial class UCBaseTemplateSampleTree : UserControl
    {
        /// <summary>
        /// 范文服务
        /// </summary>

        internal IOPTemplateSampleService OPTemplateSampleService;
        /// <summary>
        /// 范文列表
        /// </summary>
        internal List<TemplateSampleEntity> TemplateSamples;
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
        /// 当前选中的范文
        /// </summary>
        internal TemplateSampleEntity CurrentSelectedTemplateSample
        {
            get
            {
                var selectedNode = this.CurrentSelectedNode;
                if (selectedNode == null || selectedNode.Level == 0)
                    return null;
                var templateSample = selectedNode.Tag as TemplateSampleEntity;

                this.FillContent(templateSample);

                return templateSample;
            }
        }
        /// <summary>
        /// 当前科室
        /// </summary>
        internal DeptEntity DeptEntity;
        /// <summary>
        /// 科室节点
        /// </summary>
        internal Node DeptNode;
        /// <summary>
        /// 个人节点
        /// </summary>
        internal Node UserNode;

        public UCBaseTemplateSampleTree()
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
        internal virtual void FillContent(TemplateSampleEntity sampleEntity)
        {
            if (sampleEntity != null && sampleEntity.Content == null)
            {
                var result = this.OPTemplateSampleService.GetContent(sampleEntity.Id);
                if (result.Success)
                    sampleEntity.Content = result.Value;
                else
                    MsgBox.OK($"获取范文内容失败\r\n{result.Message}");
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
        internal virtual void BindTemplateSample(Node parentNode, long parentId, Level level, List<TemplateSampleEntity> sampleEntities = null)
        {
            List<TemplateSampleEntity> data = sampleEntities == null ? this.TemplateSamples : sampleEntities;
            var templateSamples = data.Where(d => d.ParentId == parentId && d.Level == level).ToList();
            foreach (var templateSample in templateSamples)
            {
                var node = this.CreateTemplateSampleNode(templateSample);
                parentNode.Nodes.Add(node);

                this.BindTemplateSample(node, templateSample.Id, level, sampleEntities);
            }
        }
        internal virtual void InitData()
        {
            if (this.OPTemplateSampleService == null)
                this.OPTemplateSampleService = ServiceLocator.GetService<IOPTemplateSampleService>();
            this.TemplateSamples = this.OPTemplateSampleService.GetList(this.DeptEntity.Id);
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
        internal virtual Node CreateTemplateSampleNode(TemplateSampleEntity sampleEntity)
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
            var result = this.OPTemplateSampleService.UpdateContent(this.CurrentSelectedTemplateSample.Id, content);
            if (result.Success)
            {
                this.CurrentSelectedTemplateSample.Content = content;
                AlertBox.Info("范文保存成功");
            }
            else
                MsgBox.OK($"范文保存失败\r\n{result.Message}");
        }
        internal virtual void GetParentIds(long id, ref List<long> ids)
        {
            if (!ids.Exists(d => d == id))
            {
                var current = this.TemplateSamples.Find(p => p.Id == id);
                ids.Add(id);
                if (current != null)
                    this.GetParentIds(current.ParentId, ref ids);
            }
        }
        internal virtual void Filter()
        {
            if (this.TemplateSamples == null || this.TemplateSamples.Count == 0)
                return;

            string inputTxt = this.tbxSearch.Text.Trim().ToUpper();
            if (inputTxt == "")
            {
                this.InitUI();
                return;
            }

            var filterTemplateSamples = this.TemplateSamples.Where(d => d.Name.Contains(inputTxt) || d.SearchCode.Contains(inputTxt) || d.WubiCode.Contains(inputTxt)).ToList();
            if (filterTemplateSamples == null || filterTemplateSamples.Count == 0)
                return;

            var ids = new List<long>();
            var filterIds = filterTemplateSamples.Select(d => d.Id).ToList();

            foreach (var id in filterIds)
            {
                this.GetParentIds(id, ref ids);
            }

            filterTemplateSamples = this.TemplateSamples.Where(d => d.Id._In(ids)).ToList();
            this.DeptNode.Nodes.Clear();
            this.UserNode.Nodes.Clear();
            this.BindTemplateSample(this.DeptNode, 0, Level.Dept, filterTemplateSamples);
            this.BindTemplateSample(this.UserNode, 0, Level.User, filterTemplateSamples);
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
