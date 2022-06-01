using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.DSkinControl;
using HIS.Service.Core.Entities;
using HIS.Service.Core;
using DevComponents.AdvTree;
using HIS.Core;
using DevComponents.DotNetBar;

namespace App_Sys.Dic
{
    internal partial class UCDicCatalog : UserControl
    {
        public UCDicCatalog()
        {
            InitializeComponent();
        }

        private List<CatalogEntity> _catalogEntitys;
        private List<SysDicEntity> _sysDicEntitys;
        internal ICatalogService _catalogService;
        internal ISysDicService _sysDicService;
        internal IIdService _idService;
        internal ISysDicDetailService _sysDicDetailService;
        internal event EventHandler<string> OnSelectedDic;
        /// <summary>
        /// 当前选中的目录
        /// </summary>
        internal CatalogEntity _currentSelectedCatalog
        {
            get
            {
                Node node = this.CurrentSelectedNode;
                if (node != null && node.Tag is CatalogEntity)
                {
                    return node.Tag as CatalogEntity;
                }

                return null;
            }
        }
        /// <summary>
        /// 当前选中的字典
        /// </summary>
        internal SysDicEntity _currentSelectedDic
        {
            get
            {
                Node node = this.CurrentSelectedNode;
                if (node != null && node.Tag is SysDicEntity)
                {
                    return node.Tag as SysDicEntity;
                }

                return null;
            }
        }
        /// <summary>
        /// 当前选中的节点
        /// </summary>
        private Node CurrentSelectedNode
        {
            get
            {
                return this.DicTree.SelectedNode;
            }
        }

        internal void Init()
        {
            this.ShowMask(() =>
            {
                this.DicTree.Nodes.Clear();

                var catalogResult = this._catalogService.GetAll();
                if (catalogResult.Success)
                {
                    this._catalogEntitys = catalogResult.Value;

                    var dicResult = this._sysDicService.GetAll();
                    if (dicResult.Success)
                        this._sysDicEntitys = dicResult.Value;
                    else
                        MsgBox.OK($"字典加载失败\r\n{dicResult.Message}");

                    this.BindCatalog(this._catalogEntitys, 0, this._sysDicEntitys);
                }
                else
                    MsgBox.OK($"字典目录加载失败\r\n{catalogResult.Message}");
            });
        }
        private void BindCatalog(List<CatalogEntity> catalogEntities, long parentId, List<SysDicEntity> sysDicEntities, Node parentNode = null)
        {
            var parentEntities = catalogEntities.Where(p => p.ParentId == parentId);

            foreach (var item in parentEntities)
            {
                Node node = this.CreateCatalogNode(item);
                if (parentNode == null)
                    this.DicTree.Nodes.Add(node);
                else
                    parentNode.Nodes.Add(node);
                this.BindDic(node, item.Id, sysDicEntities);

                this.BindCatalog(catalogEntities, item.Id, sysDicEntities, node);
            }
        }

        private void BindDic(Node parentNode, long id, List<SysDicEntity> sysDicEntities)
        {
            foreach (var item in sysDicEntities.FindAll(d => d.CatalogId == id))
                parentNode.Nodes.Add(this.CreateDicNode(item));
        }

        private Node CreateCatalogNode(CatalogEntity catalogEntity)
        {
            Node node = new Node();
            node.Text = catalogEntity.Name;
            node.Tag = catalogEntity;
            node.Image = this.imgList.Images[0];
            node.ExpandAll();

            return node;
        }

        private Node CreateDicNode(SysDicEntity sysDicEntity)
        {
            Node node = new Node();
            node.Text = $"{sysDicEntity.Code}_{sysDicEntity.Name}";
            node.Tag = sysDicEntity;
            node.Image = this.imgList.Images[1];
            if (sysDicEntity.DataStatus == HIS.Service.Core.Enums.DataStatus.Disable)
            {
                node.Text = @"<font color=""#ED1C24"">" + node.Text + "</font>";
            }

            return node;
        }

        private void btnMenu_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            Node node = this.CurrentSelectedNode;
            bool isCatalogEntity = false;
            if (node != null)
                isCatalogEntity = node.Tag is CatalogEntity;
            //控制目录右键菜单
            this.btnAddCatalog.Visible =
                node == null || isCatalogEntity;
            this.btnRenameCatalog.Visible =
                node != null && isCatalogEntity;
            //控制字典右键菜单
            this.btnAddDic.Visible =
                node != null && isCatalogEntity;
            this.btnRenameDic.Visible =
                node != null && !isCatalogEntity;
            this.btnEditDic.Visible =
                node != null && !isCatalogEntity;
            this.btnRemoverDic.Visible =
                node != null && !isCatalogEntity && !(node.Tag as SysDicEntity).IsBuiltIn;
            this.btnStopDic.Visible =
                node != null && !isCatalogEntity && (node.Tag as SysDicEntity).DataStatus == HIS.Service.Core.Enums.DataStatus.Enable;
            this.btnStartDic.Visible =
                node != null && !isCatalogEntity && (node.Tag as SysDicEntity).DataStatus == HIS.Service.Core.Enums.DataStatus.Disable;
        }

        #region 右键菜单操作
        //刷新
        private void btnReflesh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
        //添加目录
        private void btnAddCatalog_Click(object sender, EventArgs e)
        {
            CatalogEntity catalogEntity = new CatalogEntity();
            catalogEntity.Id = this._idService.CreateUUID();
            catalogEntity.ParentId = this._currentSelectedCatalog?.Id ?? 0;
            catalogEntity.Name = "新目录";
            catalogEntity.DataStatus = HIS.Service.Core.Enums.DataStatus.Enable;
            catalogEntity.No = this._catalogService.GetNo(catalogEntity.ParentId);

            var result = this._catalogService.Add(catalogEntity);
            if (result.Success)
            {
                Node node = this.CreateCatalogNode(catalogEntity);
                if (catalogEntity.ParentId == 0)
                    this.DicTree.Nodes.Add(node);
                else
                    this.CurrentSelectedNode.Nodes.Add(node);

                this.DicTree.SelectedNode = node;

                node.BeginEdit();
            }
            else
                MsgBox.OK($"添加目录失败 \r\n{result.Message}");

        }
        //添加一级目录
        private void btnAddOnCatalog_Click(object sender, EventArgs e)
        {
            CatalogEntity catalogEntity = new CatalogEntity();
            catalogEntity.Id = this._idService.CreateUUID();
            catalogEntity.ParentId = 0;
            catalogEntity.Name = "新目录";
            catalogEntity.DataStatus = HIS.Service.Core.Enums.DataStatus.Enable;
            catalogEntity.No = this._catalogService.GetNo(catalogEntity.ParentId);

            var result = this._catalogService.Add(catalogEntity);
            if (result.Success)
            {
                Node node = this.CreateCatalogNode(catalogEntity);
                this.DicTree.Nodes.Add(node);
                this.DicTree.SelectedNode = node;

                node.BeginEdit();
            }
            else
                MsgBox.OK($"添加目录失败 \r\n{result.Message}");
        }
        //目录重命名
        private void btnRenameCatalog_Click(object sender, EventArgs e)
        {
            this.CurrentSelectedNode.BeginEdit();
        }
        //添加字典
        private void btnAddDic_Click(object sender, EventArgs e)
        {
            Node catalogNode = this.CurrentSelectedNode;
            CatalogEntity catalogEntity = catalogNode.Tag as CatalogEntity;
            using (FormDicAdd dialog = new FormDicAdd(catalogEntity.Id, (sysDic) =>
            {
                Node node = this.CreateDicNode(sysDic);
                node.EnsureVisible();
                catalogNode.Nodes.Add(node);
                this.DicTree.SelectedNode = node;
            }))
            {
                dialog.ShowDialog();
            }
        }
        //字典重命名
        private void btnRenameDic_Click(object sender, EventArgs e)
        {
            if (this.CurrentSelectedNode.Text.Contains("_"))
                this.CurrentSelectedNode.Text = this.CurrentSelectedNode.Text.Split('_')[1];//取名称
            this.CurrentSelectedNode.BeginEdit();
        }
        //修改字典
        private void btnEditDic_Click(object sender, EventArgs e)
        {
            Node selectedNode = this.CurrentSelectedNode;
            SysDicEntity sysDicEntity = selectedNode.Tag as SysDicEntity;
            using (FormDicEdit dialog = new FormDicEdit(sysDicEntity))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedNode.Text = $"{sysDicEntity.Code}_{sysDicEntity.Name}";
                    if (sysDicEntity.DataStatus == HIS.Service.Core.Enums.DataStatus.Disable)
                    {
                        selectedNode.Text = @"<font color=""#ED1C24"">" + selectedNode.Text + "</font>";
                    }
                }
            }
        }
        //删除字典
        private void btnRemoverDic_Click(object sender, EventArgs e)
        {
            string dicCode = this._currentSelectedDic.Code;
            bool builtInDicDetailExists = this._sysDicDetailService.BuiltInDicDetailExists(dicCode);
            if (builtInDicDetailExists)
            {
                MsgBox.OK("明细中存在内置编码,不允许删除");
                return;
            }

            SysDicEntity sysDicEntity = this._currentSelectedDic;
            DialogResult dialogResult = MsgBox.YesNo($"是否删除字典:{sysDicEntity.Name}?");
            if (dialogResult == DialogResult.Yes)
            {
                var result = this._sysDicService.Delete(sysDicEntity.Id, sysDicEntity.Code);
                if (result.Success)
                {
                    this.CurrentSelectedNode.Remove();
                    //触发事件
                    this.OnSelectedDic?.Invoke(this, "");
                }
                else
                    MsgBox.OK($"字典删除失败\r\n{result.Message}");
            }
        }
        //停用字典
        private void btnStopDic_Click(object sender, EventArgs e)
        {
            SysDicEntity sysDicEntity = this._currentSelectedDic;
            DialogResult dialogResult = MsgBox.YesNo($"是否停用字典:{sysDicEntity.Name}?");
            if (dialogResult == DialogResult.Yes)
            {
                var result = this._sysDicService.UpdateDataStatus(sysDicEntity.Id, sysDicEntity.Code, HIS.Service.Core.Enums.DataStatus.Disable);
                if (result.Success)
                {
                    sysDicEntity.DataStatus = HIS.Service.Core.Enums.DataStatus.Disable;
                    CurrentSelectedNode.Text = @"<font color=""#ED1C24"">" + $"{sysDicEntity.Code}_{sysDicEntity.Name}" + "</font>";
                    //触发事件
                    this.OnSelectedDic?.Invoke(this, sysDicEntity.Code);
                }
                else
                    MsgBox.OK($"字典停用失败\r\n{result.Message}");
            }
        }
        //启用字典
        private void btnStartDic_Click(object sender, EventArgs e)
        {
            SysDicEntity sysDicEntity = this._currentSelectedDic;
            DialogResult dialogResult = MsgBox.YesNo($"是否启用字典:{sysDicEntity.Name}?");
            if (dialogResult == DialogResult.Yes)
            {
                var result = this._sysDicService.UpdateDataStatus(sysDicEntity.Id, sysDicEntity.Code, HIS.Service.Core.Enums.DataStatus.Enable);
                if (result.Success)
                {
                    sysDicEntity.DataStatus = HIS.Service.Core.Enums.DataStatus.Enable;
                    CurrentSelectedNode.Text = $"{sysDicEntity.Code}_{sysDicEntity.Name}";
                    //触发事件
                    this.OnSelectedDic?.Invoke(this, sysDicEntity.Code);
                }
                else
                    MsgBox.OK($"字典启用失败\r\n{result.Message}");
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
                var current = this._catalogEntitys.Find(p => p.Id == id);
                ids.Add(id);
                if (current != null)
                    GetParentIds(current.ParentId, ref ids);
            }
        }
        #endregion
        //过滤
        private void delaytbxInput_TextChanged(object sender, EventArgs e)
        {
            if (this._sysDicEntitys == null || this._sysDicEntitys.Count == 0) return;

            string inputText = this.delaytbxInput.Text.Trim().ToUpper();

            List<SysDicEntity> sysDicEntities = this._sysDicEntitys.Where(d => d.SearchCode.Contains(inputText) || d.Name.Contains(inputText)).ToList();
            List<long> catalogIds = sysDicEntities.Select(d => d.CatalogId).Distinct().ToList();

            List<long> parentIds = new List<long>();
            foreach (long catalogId in catalogIds)
            {
                this.GetParentIds(catalogId, ref parentIds);
            }

            List<CatalogEntity> catalogEntitys = this._catalogEntitys.Where(d => d.Id._In(parentIds)).ToList();

            this.DicTree.Nodes.Clear();

            this.BindCatalog(catalogEntitys, 0, sysDicEntities);
        }
        private void advTree_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            string newName = e.NewText.Trim();
            object tag = e.Cell.Parent.Tag;
            if (tag is CatalogEntity)
            {
                CatalogEntity catalogEntity = tag as CatalogEntity;
                if (newName == "")
                    e.Cell.Text = catalogEntity.Name;
                else if (newName == catalogEntity.Name)
                    return;
                else
                {
                    var result = this._catalogService.UpdateNameById(newName, catalogEntity.Id);
                    if (!result.Success)
                        MsgBox.OK($"目录重命名失败{result.Message}");
                    else
                    {
                        catalogEntity.Name = newName;
                    }
                }
                return;
            }
            if (tag is SysDicEntity)
            {
                SysDicEntity sysDicEntity = tag as SysDicEntity;
                if (newName == "" || newName == sysDicEntity.Name)
                    e.Cell.Text = $"{sysDicEntity.Code}_{sysDicEntity.Name}";
                else
                {
                    var result = this._sysDicService.UpdateNameById(sysDicEntity.Id, newName);
                    if (!result.Success)
                        MsgBox.OK($"字典重命名失败{result.Message}");
                    else
                    {
                        sysDicEntity.Name = newName;
                        e.Cell.Text = $"{sysDicEntity.Code}_{sysDicEntity.Name}";
                    }
                }

                e.Cancel = true;
            }
        }

        private void advTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this.OnSelectedDic?.Invoke(this, this._currentSelectedCatalog != null ? "" : this._currentSelectedDic?.Code ?? "");
        }
    }
}
