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
    internal partial class UCTemplateSampleTree : UCBaseTemplateSampleTree
    {
        /// <summary>
        /// 创建范文时使用的默认新名称
        /// </summary>
        private const string NewName = "新范文";
        /// <summary>
        /// 选中范文事件
        /// </summary>
        internal event EventHandler<TemplateSampleEntity> SelectedTemplateSample;
        /// <summary>
        /// 构造函数
        /// </summary>
        public UCTemplateSampleTree()
        {
            InitializeComponent();
        }

        #region 方法
        private void AddTemplateSample(NodeType nodeType)
        {
            var templateSample = this.CurrentSelectedTemplateSample;
            TemplateSampleEntity sampleEntity = new TemplateSampleEntity();
            sampleEntity.Name = NewName;
            sampleEntity.ParentId = templateSample == null ? 0 : templateSample.Id;
            sampleEntity.NodeType = nodeType;
            sampleEntity.SearchCode = SpellHelper.GetSpells(sampleEntity.Name);
            sampleEntity.WubiCode = SpellHelper.GetWuBis(sampleEntity.Name);
            sampleEntity.Level = templateSample == null ? (Level)this.CurrentSelectedNode.Tag : templateSample.Level;
            if (sampleEntity.Level == Level.User)
                sampleEntity.OwnerId = App.Instance.RuntimeSystemInfo.UserInfo.Id;
            else
                sampleEntity.OwnerId = this.DeptEntity.Id;
            var result = this.OPTemplateSampleService.Insert(sampleEntity);
            if (result.Success)
            {
                this.TemplateSamples.Add(sampleEntity);
                var node = this.CreateTemplateSampleNode(sampleEntity);
                this.CurrentSelectedNode.Nodes.Add(node);
                this.advTree.SelectedNode = node;
                node.BeginEdit();
            }
            else
                MsgBox.OK($"添加{sampleEntity.Level.GetDescription()}失败\r\n{result.Message}");
        }
        private void GetChildIds(long id, ref List<long> ids)
        {
            var childIds = this.TemplateSamples.Where(d => d.ParentId == id).Select(d => d.Id).ToList();
            foreach (var childId in childIds)
            {
                ids.Add(childId);
                this.GetChildIds(childId, ref ids);
            }
        }
        #endregion

        #region 事件
        private void contextMenuBar_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            var selectedNode = this.CurrentSelectedNode;
            var selectedTemplateSample = this.CurrentSelectedTemplateSample;

            this.btnAddGroup.Enabled = selectedNode != null && (selectedNode.Level == 0 || selectedTemplateSample != null && selectedTemplateSample.NodeType == NodeType.Folder);
            this.btnAddTemplate.Enabled = selectedNode != null && (selectedNode.Level == 0 || selectedTemplateSample != null && selectedTemplateSample.NodeType == NodeType.Folder);
            this.btnReName.Enabled = selectedNode != null && selectedTemplateSample != null;
            this.btnRemover.Enabled = selectedNode != null && selectedTemplateSample != null;
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            this.AddTemplateSample(NodeType.Folder);
        }
        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            this.AddTemplateSample(NodeType.Content);
        }
        private void btnReName_Click(object sender, EventArgs e)
        {
            this.CurrentSelectedNode.BeginEdit();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var templateSample = this.CurrentSelectedTemplateSample;
            var dialogResult = MsgBox.YesNo($"是否删除 {templateSample.Name}?");
            if (dialogResult == DialogResult.Yes)
            {
                var result = this.OPTemplateSampleService.Delete(templateSample.Id);
                if (result.Success)
                {
                    var ids = new List<long>() { templateSample.Id };
                    this.GetChildIds(templateSample.Id, ref ids);
                    this.TemplateSamples.RemoveAll(d => ids.Contains(d.Id));

                    var parentNode = this.CurrentSelectedNode.Parent;
                    this.CurrentSelectedNode.Remove();

                    this.advTree.SelectedNode = parentNode;
                }
            }
        }
        private void advTree_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            var templateSampleEntity = e.Cell.Parent.Tag as TemplateSampleEntity;
            string newText = e.NewText.Trim();
            if (newText != "" && newText != templateSampleEntity.Name)
            {
                var result = this.OPTemplateSampleService.UpdateName(templateSampleEntity.Id, newText);
                if (!result.Success)
                    MsgBox.OK($"重命名失败\r\n{result.Message}");
                else
                {
                    templateSampleEntity.Name = newText;
                    templateSampleEntity.SearchCode = SpellHelper.GetSpells(templateSampleEntity.Name);
                    templateSampleEntity.WubiCode = SpellHelper.GetWuBis(templateSampleEntity.Name);
                }
            }

            e.Cell.Parent.Text = templateSampleEntity.Name;
        }
        private void advTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this.SelectedTemplateSample?.Invoke(this, this.CurrentSelectedTemplateSample);
        }
        #endregion
    }
}
