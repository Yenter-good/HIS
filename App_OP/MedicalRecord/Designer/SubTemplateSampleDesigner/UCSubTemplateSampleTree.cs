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
    internal partial class UCSubTemplateSampleTree : UCBaseSubTemplateSampleTree
    {
        private const string NewName = "新子模板";
        internal event EventHandler<SubTemplateSampleEntity> SelectedSubTemplateSample;
        public UCSubTemplateSampleTree()
        {
            InitializeComponent();
        }

        #region 方法
        private void AddSubTemplateSample(NodeType nodeType)
        {
            var subTemplateSample = this.CurrentSelectedSubTemplateSample;
            SubTemplateSampleEntity sampleEntity = new SubTemplateSampleEntity();
            sampleEntity.Name = NewName;
            sampleEntity.NodeType = nodeType;
            sampleEntity.ParentId = subTemplateSample == null ? 0 : subTemplateSample.Id;
            sampleEntity.Level = subTemplateSample == null ? (Level)this.CurrentSelectedNode.Tag : subTemplateSample.Level;
            sampleEntity.SearchCode = SpellHelper.GetSpells(sampleEntity.Name);
            sampleEntity.WubiCode = SpellHelper.GetWuBis(sampleEntity.Name);
            if (sampleEntity.Level == Level.User)
                sampleEntity.OwnerId = App.Instance.RuntimeSystemInfo.UserInfo.Id;
            else
                sampleEntity.OwnerId = this.DeptEntity.Id;
            sampleEntity.TemplateNodeId = null;
            var result = this.OPSubTemplateSampleService.Insert(sampleEntity);
            if (result.Success)
            {
                this.SubTemplateSamples.Add(sampleEntity);
                var node = this.CreateSubTemplateSampleNode(sampleEntity);
                this.CurrentSelectedNode.Nodes.Add(node);
                this.advTree.SelectedNode = node;
                node.BeginEdit();
            }
            else
                MsgBox.OK($"添加子模板失败\r\n{result.Message}");
        }
        #endregion

        #region 事件
        private void contextMenuBar_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            var selectedNode = this.CurrentSelectedNode;
            var selectedSubTemplateSample = this.CurrentSelectedSubTemplateSample;

            this.btnAddGroup.Enabled = selectedNode != null && (selectedNode.Level == 0 || selectedSubTemplateSample != null && selectedSubTemplateSample.NodeType == NodeType.Folder);
            this.btnAddTemplate.Enabled = selectedNode != null && (selectedNode.Level == 0 || selectedSubTemplateSample != null && selectedSubTemplateSample.NodeType == NodeType.Folder);
            this.btnReName.Enabled = selectedNode != null && selectedSubTemplateSample != null;
            this.btnRemover.Enabled = selectedNode != null && selectedSubTemplateSample != null;
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            this.AddSubTemplateSample(NodeType.Folder);
        }
        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            this.AddSubTemplateSample(NodeType.Content);
        }
        private void btnReName_Click(object sender, EventArgs e)
        {
            this.CurrentSelectedNode.BeginEdit();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var subTemplateSample = this.CurrentSelectedSubTemplateSample;
            var dialogResult = MsgBox.YesNo($"是否删除 {subTemplateSample.Name}?");
            if (dialogResult == DialogResult.Yes)
            {
                var result = this.OPSubTemplateSampleService.Delete(subTemplateSample.Id);
                if (result.Success)
                {
                    this.SubTemplateSamples.Remove(subTemplateSample);
                    var parentNode = this.CurrentSelectedNode.Parent;
                    this.CurrentSelectedNode.Remove();
                    this.SubTemplateSamples.Remove(subTemplateSample);

                    this.advTree.SelectedNode = parentNode;
                }
            }
        }
        private void advTree_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            var subTemplateSampleEntity = e.Cell.Parent.Tag as SubTemplateSampleEntity;
            string newText = e.NewText.Trim();
            if (newText != "" && newText != subTemplateSampleEntity.Name)
            {
                var result = this.OPSubTemplateSampleService.UpdateName(subTemplateSampleEntity.Id, newText);
                if (!result.Success)
                    MsgBox.OK($"重命名失败\r\n{result.Message}");
                else
                {
                    subTemplateSampleEntity.Name = newText;
                    subTemplateSampleEntity.SearchCode = SpellHelper.GetSpells(newText);
                    subTemplateSampleEntity.WubiCode = SpellHelper.GetWuBis(newText);
                }
            }

            e.Cell.Parent.Text = subTemplateSampleEntity.Name;
        }
        private void advTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this.SelectedSubTemplateSample?.Invoke(this, this.CurrentSelectedSubTemplateSample);
        }
        #endregion
    }
}
