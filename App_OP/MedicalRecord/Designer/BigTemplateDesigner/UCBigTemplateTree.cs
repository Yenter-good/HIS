using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;
using HIS.Service.Core;
using HIS.Core;
using DevComponents.AdvTree;
using HIS.Service.Core.Enums;
using DevComponents.DotNetBar;
using HIS.Utility;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 模板树列表
    /// </summary>
    internal partial class UCBigTemplateTree : UserControl
    {
        /// <summary>
        /// 模板来源类型
        /// </summary>
        enum TemplateSourceType
        {
            /// <summary>
            /// 复制
            /// </summary>
            [Description("粘贴模板失败\r\n{0}")]
            Copy,
            /// <summary>
            /// 导入
            /// </summary>
            [Description("导入模板失败\r\n{0}")]
            Import,
            /// <summary>
            /// 创建
            /// </summary>
            [Description("添加模板失败\r\n{0}")]
            New
        }
        /// <summary>
        /// 科室服务
        /// </summary>
        private IDeptService _deptService;
        /// <summary>
        /// 大模板服务
        /// </summary>
        private IOPBigTemplateService _oPBigTemplateService;
        /// <summary>
        /// 门诊科室
        /// </summary>
        private List<DeptEntity> _deptEntities;
        /// <summary>
        /// 大模板
        /// </summary>
        private List<BigTemplateEntity> _bigTemplateEntities;
        /// <summary>
        /// 当前选中的节点
        /// </summary>
        private Node _currentSelectedNode
        {
            get
            {
                return this.advTree.SelectedNode;
            }
        }
        /// <summary>
        /// 是否是初复诊模板节点
        /// </summary>
        private bool _currentSelectedNodeIsFirstOrSecondNode
        {
            get
            {
                var node = this._currentSelectedNode;
                if (node == null || node.Tag == null)
                    return false;
                if (node.Tag is DeptEntity || node.Tag is BigTemplateEntity)
                    return false;

                return true;
            }
        }
        /// <summary>
        /// 导出模板事件
        /// </summary>
        internal event EventHandler ExportBigTemplate;
        /// <summary>
        /// 选中模板事件
        /// </summary>
        internal event EventHandler<BigTemplateEntity> SelectedBigTemplate;
        public UCBigTemplateTree()
        {
            InitializeComponent();
        }
        internal void Init()
        {
            this.InitData();
            this.InitUI();
        }
        internal void SaveContent(string content)
        {
            var bigTemplateEntity = this._currentSelectedNode.Tag as BigTemplateEntity;
            var result = this._oPBigTemplateService.UpdateContent(bigTemplateEntity.Id, content);
            if (result.Success)
            {
                bigTemplateEntity.Content = content;
                AlertBox.Info("模板保存成功");
            }
            else
                MsgBox.OK($"模板保存失败\r\n{result.Message}");
        }
        private void InitData()
        {
            if (this._deptService == null)
                this._deptService = ServiceLocator.GetService<IDeptService>();
            if (this._oPBigTemplateService == null)
                this._oPBigTemplateService = ServiceLocator.GetService<IOPBigTemplateService>();

            this._deptEntities = this._deptService.GetListByCategory(DeptCategory.门诊);
            this._bigTemplateEntities = this._oPBigTemplateService.GetList();
        }
        private void InitUI()
        {
            this.HospitalNode.Nodes.Clear();
            var hFirstvisitNode = this.CreateTemplateTypeNode(BigTemplateType.FirstVisit);
            var hFollowupvisitNode = this.CreateTemplateTypeNode(BigTemplateType.FollowUpVisit);
            this.HospitalNode.Nodes.Add(hFirstvisitNode);
            this.HospitalNode.Nodes.Add(hFollowupvisitNode);
            this.BindTemplate(hFirstvisitNode, 0, BigTemplateType.FirstVisit);
            this.BindTemplate(hFollowupvisitNode, 0, BigTemplateType.FollowUpVisit);

            this.DeptNode.Nodes.Clear();
            this.BindDept(this.DeptNode, 0);
        }
        private void BindDept(Node parentNode, long parentDeptId, List<DeptEntity> deptEntities = null, List<BigTemplateEntity> bigTemplateEntities = null)
        {
            List<DeptEntity> depts = null;
            if (deptEntities == null)
                depts = this._deptEntities.Where(d => d.Parent.Id == parentDeptId).ToList();
            else
                depts = deptEntities.Where(d => d.Parent.Id == parentDeptId).ToList();
            foreach (var dept in depts)
            {
                var deptNode = this.CreateDepartmentNode(dept);

                var firstVisitNode = this.CreateTemplateTypeNode(BigTemplateType.FirstVisit);
                var followUpVisitNode = this.CreateTemplateTypeNode(BigTemplateType.FollowUpVisit);
                deptNode.Nodes.Add(firstVisitNode);
                deptNode.Nodes.Add(followUpVisitNode);
                this.BindTemplate(firstVisitNode, dept.Id, BigTemplateType.FirstVisit, bigTemplateEntities);
                this.BindTemplate(followUpVisitNode, dept.Id, BigTemplateType.FollowUpVisit, bigTemplateEntities);

                parentNode.Nodes.Add(deptNode);

                this.BindDept(deptNode, dept.Id, deptEntities);
            }
        }
        private void BindTemplate(Node parentNode, long deptId, BigTemplateType bigTemplateType, List<BigTemplateEntity> bigTemplateEntities = null)
        {
            List<BigTemplateEntity> templates = null;
            if (bigTemplateEntities == null)
                templates = this._bigTemplateEntities.Where(d => d.DeptId == deptId && d.TemplateType == bigTemplateType).ToList();
            else
                templates = bigTemplateEntities.Where(d => d.DeptId == deptId && d.TemplateType == bigTemplateType).ToList();
            foreach (var template in templates)
            {
                parentNode.Nodes.Add(this.CreateTemplateNode(template));
            }
        }
        private Node CreateTemplateNode(BigTemplateEntity bigTemplateEntity, bool setColor = true)
        {
            return new Node()
            {
                Tag = bigTemplateEntity,
                Text = setColor ? this.GetNodeText(bigTemplateEntity) : bigTemplateEntity.Name,
                Expanded = true,
                Image = this.imageList1.Images[1]
            };
        }
        private Node CreateDepartmentNode(DeptEntity deptEntity)
        {
            return new Node()
            {
                Tag = deptEntity,
                Text = deptEntity.Name,
                Expanded = true,
                Image = this.imageList1.Images[0]
            };
        }
        private Node CreateTemplateTypeNode(BigTemplateType bigtemplateType)
        {
            return new Node()
            {
                Text = $"[{bigtemplateType.GetDescription()}]",
                Tag = (int)bigtemplateType,
                Expanded = true
            };
        }
        private void SetEffectiveFlag(bool effectiveFlag)
        {
            string msg = effectiveFlag ? "生效" : "失效";
            var dialogResult = MsgBox.YesNo($"是否{msg}?");
            if (dialogResult == DialogResult.Yes)
            {
                var currentSelectedNode = this._currentSelectedNode;
                var bigTemplateEntity = currentSelectedNode.Tag as BigTemplateEntity;
                var result = this._oPBigTemplateService.UpdateEffectiveFlag(bigTemplateEntity.Id, bigTemplateEntity.DeptId, effectiveFlag, bigTemplateEntity.TemplateType);
                if (result.Success)
                {
                    if (effectiveFlag)
                    {
                        var parentNode = currentSelectedNode.Parent;
                        foreach (Node node in parentNode.Nodes)
                        {
                            var entity = node.Tag as BigTemplateEntity;
                            if (entity.EffectiveFlag)
                            {
                                entity.EffectiveFlag = false;
                                node.Text = entity.Name;
                                break;
                            }
                        }
                    }

                    bigTemplateEntity.EffectiveFlag = effectiveFlag;
                    currentSelectedNode.Text = this.GetNodeText(bigTemplateEntity);
                }
                else
                    MsgBox.OK(msg + "失败\r\n" + result.Message);
            }
        }
        private string GetNodeText(BigTemplateEntity bigTemplateEntity)
        {
            if (bigTemplateEntity.EffectiveFlag)
                return $"<font color = \"#ED1C24\">{ bigTemplateEntity.Name }</font> ";
            else
                return bigTemplateEntity.Name;
        }
        private void CancelColor(Node node)
        {
            node.Text = (node.Tag as BigTemplateEntity).Name;
        }
        private void AddBigTemplate(TemplateSourceType addTemplateType, string name = "新模板", string content = null)
        {
            BigTemplateEntity bigTemplateEntity = new BigTemplateEntity();
            bigTemplateEntity.DeptId = 0;
            if (this._currentSelectedNode.Parent.Tag is DeptEntity dept)
                bigTemplateEntity.DeptId = dept.Id;
            bigTemplateEntity.Name = name;
            bigTemplateEntity.Content = content;
            bigTemplateEntity.TemplateType = (BigTemplateType)this._currentSelectedNode.Tag;
            bigTemplateEntity.SearchCode = SpellHelper.GetSpells(bigTemplateEntity.Name);
            bigTemplateEntity.WubiCode = SpellHelper.GetWuBis(bigTemplateEntity.Name);

            var result = this._oPBigTemplateService.Add(bigTemplateEntity);
            if (result.Success)
            {
                this._bigTemplateEntities.Add(bigTemplateEntity);
                var node = this.CreateTemplateNode(bigTemplateEntity, false);
                this._currentSelectedNode.Nodes.Add(node);
                this.advTree.SelectedNode = node;
                node.EnsureVisible();
                node.BeginEdit();
            }
            else
                MsgBox.OK(string.Format(addTemplateType.GetDescription(), result.Message));
        }
        private BigTemplateEntity GetCurrentSelectedBigTemplate()
        {
            var bigTemplateEntity = (this._currentSelectedNode?.Tag as BigTemplateEntity) ?? null;
            if (bigTemplateEntity == null)
                return null;
            if (bigTemplateEntity.Content == null)
            {
                var result = this._oPBigTemplateService.GetContent(bigTemplateEntity.Id);
                if (result.Success)
                    bigTemplateEntity.Content = result.Value;
                else
                    MsgBox.OK($"获取模板内容失败\r\n{result.Message}");
            }

            return bigTemplateEntity;
        }
        private void GetDeptParentIds(long deptId, ref List<long> deptIds)
        {
            if (!deptIds.Exists(d => d == deptId))
            {
                var current = this._deptEntities.Find(p => p.Id == deptId);
                deptIds.Add(deptId);
                if (current != null)
                    this.GetDeptParentIds(current.Parent.Id, ref deptIds);
            }
        }
        private void FilterByDept(string filterText)
        {
            if (this._deptEntities == null || this._deptEntities.Count == 0)
                return;

            var filterDepts = this._deptEntities.Where(d => d.Name.Contains(filterText) || d.SearchCode.Contains(filterText)).ToList();
            if (filterDepts == null || filterDepts.Count == 0)
                return;

            var ids = new List<long>();
            var filterDeptIds = filterDepts.Select(d => d.Id).ToList<long>();
            foreach (var filterDeptId in filterDeptIds)
            {
                this.GetDeptParentIds(filterDeptId, ref ids);
            }

            this.DeptNode.Nodes.Clear();
            filterDepts = this._deptEntities.Where(d => d.Id._In(ids)).ToList();
            this.BindDept(this.DeptNode, 0, filterDepts);
        }
        private void FilterByTemplate(string filterText)
        {
            if (this._bigTemplateEntities == null || this._bigTemplateEntities.Count == 0)
                return;

            var filterTemplates = this._bigTemplateEntities.Where(d => d.Name.Contains(filterText) || d.SearchCode.Contains(filterText)).ToList();
            if (filterTemplates == null || filterTemplates.Count == 0)
                return;

            var ids = new List<long>();
            var filterDeptIds = filterTemplates.Select(d => d.DeptId).ToList<long>();
            foreach (long filterDeptId in filterDeptIds)
            {
                this.GetDeptParentIds(filterDeptId, ref ids);
            }

            this.DeptNode.Nodes.Clear();
            var filterDepts = this._deptEntities.Where(d => d.Id._In(ids)).ToList();
            this.BindDept(this.DeptNode, 0, filterDepts, filterTemplates);
        }

        #region 事件
        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        private void contextMenuBar1_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            var selectedNode = this._currentSelectedNode;

            this.btnAdd.Enabled =
                selectedNode != null && selectedNode.Tag != null && this._currentSelectedNodeIsFirstOrSecondNode;

            this.btnRemover.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity && !(selectedNode.Tag as BigTemplateEntity).EffectiveFlag;

            this.btnRename.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity;

            this.btnImport.Enabled =
                selectedNode != null && selectedNode.Tag != null && this._currentSelectedNodeIsFirstOrSecondNode;

            this.btnExport.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity;

            this.btnEffective.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity && !(selectedNode.Tag as BigTemplateEntity).EffectiveFlag;

            //模板失效仅对科室有用
            this.btnUnEffective.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity && (selectedNode.Tag as BigTemplateEntity).EffectiveFlag && selectedNode.Parent.Parent.Tag is DeptEntity;

            this.btnCopy.Enabled =
                selectedNode != null && selectedNode.Tag is BigTemplateEntity;

            this.btnPast.Enabled =
                selectedNode != null && selectedNode.Tag != null && this._currentSelectedNodeIsFirstOrSecondNode;
        }
        private void btnEffective_Click(object sender, EventArgs e)
        {
            this.SetEffectiveFlag(true);
        }
        private void btnUnEffective_Click(object sender, EventArgs e)
        {
            this.SetEffectiveFlag(false);
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var dialogResult = MsgBox.YesNo("是否删除此模板？");
            if (dialogResult == DialogResult.Yes)
            {
                var node = this._currentSelectedNode;
                var bigTemplateEntity = node.Tag as BigTemplateEntity;
                var result = this._oPBigTemplateService.Delete(bigTemplateEntity.Id);
                if (result.Success)
                {
                    this._bigTemplateEntities.Remove(bigTemplateEntity);

                    var parentNode = node.Parent;
                    //删除节点
                    node.Remove();
                    //定位到父节点
                    this.advTree.SelectedNode = parentNode;
                }
                else
                    MsgBox.OK($"删除模板失败\r\n{result.Message}");
            }
        }
        private void btnRename_Click(object sender, EventArgs e)
        {
            var selectedNode = this._currentSelectedNode;
            this.CancelColor(selectedNode);
            selectedNode.BeginEdit();
        }
        private void advTree_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            var bigTemplateEntity = e.Cell.Parent.Tag as BigTemplateEntity;
            string newText = e.NewText.Trim();
            if (newText != "" && newText != bigTemplateEntity.Name)
            {
                var result = this._oPBigTemplateService.UpdateName(newText, bigTemplateEntity.Id);
                if (!result.Success)
                    MsgBox.OK($"重命名失败\r\n{result.Message}");
                else
                {
                    bigTemplateEntity.Name = newText;
                    bigTemplateEntity.SearchCode = SpellHelper.GetSpells(newText);
                    bigTemplateEntity.WubiCode = SpellHelper.GetWuBis(newText);
                }
            }

            e.Cell.Parent.Text = this.GetNodeText(bigTemplateEntity);
            e.Cancel = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddBigTemplate(TemplateSourceType.New);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML|*.XML";
                ofd.DefaultExt = "*.XML";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string xmlTxt = System.IO.File.ReadAllText(ofd.FileName);
                    this.AddBigTemplate(TemplateSourceType.Import, System.IO.Path.GetFileNameWithoutExtension(ofd.FileName), xmlTxt);
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportBigTemplate?.Invoke(this, EventArgs.Empty);
        }
        private void advTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this.SelectedBigTemplate?.Invoke(this, this.GetCurrentSelectedBigTemplate());
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Serializable, this._currentSelectedNode.Tag as BigTemplateEntity);
        }
        private void btnPast_Click(object sender, EventArgs e)
        {
            object obj = Clipboard.GetData(DataFormats.Serializable);
            if (obj == null) return;
            if (obj is BigTemplateEntity copybigTemplateEntity)
            {
                this.AddBigTemplate(TemplateSourceType.Copy, copybigTemplateEntity.Name, copybigTemplateEntity.Content);
            }
        }
        private void ChangeFilter(object sender, EventArgs e)
        {
            var bti = sender as ButtonItem;
            if (!bti.Checked)
            {
                bti.Checked = true;
                if (bti == this.btnQueryByDept)
                    this.btnQueryByTemplate.Checked = false;
                else
                    this.btnQueryByDept.Checked = false;
            }
            this.tbxSearch.Focus();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string inputText = this.tbxSearch.Text.ToUpper().Trim();
            if (inputText == "")
            {
                this.DeptNode.Nodes.Clear();
                this.BindDept(this.DeptNode, 0);
                return;
            }
            if (this.btnQueryByDept.Checked)
                this.FilterByDept(inputText);
            else
                this.FilterByTemplate(inputText);
        }
        #endregion
    }
}
