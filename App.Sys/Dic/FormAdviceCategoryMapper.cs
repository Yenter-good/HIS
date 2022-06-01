using HIS.Core.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using DevComponents.AdvTree;
using HIS.DSkinControl;
using HIS.Core;
using DevComponents.DotNetBar.SuperGrid;

namespace App_Sys.Dic
{
    public partial class FormAdviceCategoryMapper : BaseForm
    {
        private readonly IAdviceService _adviceService;
        private readonly IDeptService _deptService;

        private List<AdviceEntity> _allAdviceEntities;
        private List<DeptEntity> _allDeptEntities;
        private Dictionary<long, List<long>> _adviceCategoryMapper;
        private List<AdviceCategoryEntity> _testAdviceCategoryEntities;
        private List<AdviceCategoryEntity> _inspectAdviceCategoryEntities;

        private AdviceCategoryType _categoryType = AdviceCategoryType.Test;
        private AdviceCategoryEntity _selectedCategoryEntity;

        public FormAdviceCategoryMapper(IAdviceService adviceService, IDeptService deptService)
        {
            InitializeComponent();
            this._adviceService = adviceService;
            this._deptService = deptService;
        }

        #region 初始化

        private void InitData()
        {
            _allAdviceEntities = _adviceService.GetAll();
            _allDeptEntities = _deptService.GetList();
            _adviceCategoryMapper = _adviceService.GetAdviceCategoryMapper(0);
            var allAdviceCategoryEntities = _adviceService.GetAdviceCategories();

            foreach (var adviceCategoryEntity in allAdviceCategoryEntities)
            {
                if (adviceCategoryEntity.Dept != null)
                    adviceCategoryEntity.Dept = _allDeptEntities.Find(p => p.Id == adviceCategoryEntity.Dept.Id);
            }
            _testAdviceCategoryEntities = allAdviceCategoryEntities.Where(p => p.CategoryType == AdviceCategoryType.Test).ToList();
            _inspectAdviceCategoryEntities = allAdviceCategoryEntities.Where(p => p.CategoryType == AdviceCategoryType.Inspect).ToList();
        }

        private void InitUI()
        {
            InitCategoryTree();
            InitDGVColumn();

        }

        private void InitCategoryTree()
        {
            this.treeCategory.Nodes.Clear();
            if (_categoryType == AdviceCategoryType.Test)
                BuildCategoryTree(0, _testAdviceCategoryEntities, this.treeCategory.Nodes);
            else
                BuildCategoryTree(0, _inspectAdviceCategoryEntities, this.treeCategory.Nodes);
            this.treeCategory.ExpandAll();
        }
        private void InitDGVColumn()
        {
            if (_categoryType == AdviceCategoryType.Test)
            {
                this.dgvAllAdvice.PrimaryGrid.Columns[colBuret.ColumnIndex].Visible = true;
                this.dgvAllAdvice.PrimaryGrid.Columns[colSample.ColumnIndex].Visible = true;
                this.dgvAllAdvice.PrimaryGrid.Columns[colPart.ColumnIndex].Visible = false;
                this.dgvAllAdvice.PrimaryGrid.Columns[colModality.ColumnIndex].Visible = false;

                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistBuret.ColumnIndex].Visible = true;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistSample.ColumnIndex].Visible = true;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistPart.ColumnIndex].Visible = false;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistModality.ColumnIndex].Visible = false;
            }
            else
            {
                this.dgvAllAdvice.PrimaryGrid.Columns[colPart.ColumnIndex].Visible = true;
                this.dgvAllAdvice.PrimaryGrid.Columns[colModality.ColumnIndex].Visible = true;
                this.dgvAllAdvice.PrimaryGrid.Columns[colBuret.ColumnIndex].Visible = false;
                this.dgvAllAdvice.PrimaryGrid.Columns[colSample.ColumnIndex].Visible = false;

                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistPart.ColumnIndex].Visible = true;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistModality.ColumnIndex].Visible = true;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistBuret.ColumnIndex].Visible = false;
                this.dgvCategoryAdvice.PrimaryGrid.Columns[colExistSample.ColumnIndex].Visible = false;
            }
        }

        private void BuildCategoryTree(long parentId, List<AdviceCategoryEntity> entities, NodeCollection nodes)
        {
            var categories = entities.Where(p => p.Parent.Id == parentId);
            foreach (var category in categories)
            {
                Node node = new Node(category.Name);
                node.Name = category.Id.ToString();
                node.Tag = category;

                nodes.Add(node);
                BuildCategoryTree(category.Id, entities, node.Nodes);
            }
        }
        #endregion

        private void FormAdviceCategoryMapper_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                InitData();
                InitUI();
            });
        }

        #region 方法
        /// <summary>
        /// 修改医嘱分类
        /// </summary>
        /// <param name="selectedNode"></param>
        private void EditCategory(Node selectedNode)
        {
            var selectedEntity = selectedNode.Tag as AdviceCategoryEntity;
            FormAdviceCategoryEdit form = App.Instance.CreateView<FormAdviceCategoryEdit>();
            form.AllAdviceCategories = _categoryType == AdviceCategoryType.Test ? _testAdviceCategoryEntities : _inspectAdviceCategoryEntities;
            form.CategoryType = _categoryType;
            form.AllDepts = _allDeptEntities;
            form.Operation = DataOperation.Modify;
            form.SelectedCategory = selectedEntity;
            form.NewCategory += Form_NewCategory;
            if (form.ShowDialog() == DialogResult.OK)
                selectedNode.Text = selectedEntity.Name;
        }
        /// <summary>
        /// 初始化医嘱表格
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="adviceEntities"></param>
        private void InitAdviceDGV(SuperGridControl dgv, List<AdviceEntity> adviceEntities)
        {
            dgv.PrimaryGrid.Rows.Clear();
            foreach (var adviceEntity in adviceEntities)
            {
                var newRow = dgv.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = adviceEntity.Name;
                newRow.Cells[colPrice.ColumnIndex].Value = adviceEntity.Price.ToString("f4") + "元";
                newRow.Cells[colSpell.ColumnIndex].Value = adviceEntity.SearchCode;
                newRow.Cells[colSample.ColumnIndex].Value = adviceEntity.Sample?.Value;
                newRow.Cells[colBuret.ColumnIndex].Value = adviceEntity.Buret?.Value;
                newRow.Cells[colPart.ColumnIndex].Value = adviceEntity.Part?.Value;
                newRow.Cells[colModality.ColumnIndex].Value = adviceEntity.Modality?.Value;
                newRow.Tag = adviceEntity;
                dgv.PrimaryGrid.Rows.Add(newRow);
            }
        }
        /// <summary>
        /// 将指定医嘱添加到分类中
        /// </summary>
        /// <param name="row"></param>
        private void InsertToCategory(GridRow row)
        {
            if (_selectedCategoryEntity == null)
            {
                MsgBox.OK("未选择分类,无法添加");
                return;
            }

            var advice = row.Tag as AdviceEntity;

            var result = _adviceService.InsertAdviceCategoryMapper(advice.Id, _selectedCategoryEntity.Id, (int)_selectedCategoryEntity.CategoryType);
            if (!result.Success)
            {
                MsgBox.OK("添加失败" + Environment.NewLine + result.Message);
                return;
            }
            else
                AlertBox.Info("添加成功");

            this.dgvAllAdvice.PrimaryGrid.Rows.Remove(row);

            var newRow = this.dgvCategoryAdvice.PrimaryGrid.NewRow();
            newRow.Cells[colName.ColumnIndex].Value = advice.Name;
            newRow.Cells[colPrice.ColumnIndex].Value = advice.Price.ToString("f4") + "元";
            newRow.Cells[colSpell.ColumnIndex].Value = advice.SearchCode;
            newRow.Cells[colSample.ColumnIndex].Value = advice.Sample?.Value;
            newRow.Cells[colBuret.ColumnIndex].Value = advice.Buret?.Value;
            newRow.Cells[colPart.ColumnIndex].Value = advice.Part?.Value;
            newRow.Cells[colModality.ColumnIndex].Value = advice.Modality?.Value;
            newRow.Tag = advice;

            this.dgvCategoryAdvice.PrimaryGrid.Rows.Insert(0, newRow);
        }
        /// <summary>
        /// 批量将医嘱添加到分类中
        /// </summary>
        /// <param name="rows"></param>
        private void InsertToCategory(SelectedElementCollection rows)
        {
            if (_selectedCategoryEntity == null)
            {
                MsgBox.OK("未选择分类,无法添加");
                return;
            }
            List<long> adviceIds = new List<long>();
            foreach (GridRow row in rows)
                adviceIds.Add(row.Tag.As<AdviceEntity>().Id);

            var result = _adviceService.InsertAdviceCategoryMapper(adviceIds, _selectedCategoryEntity.Id);
            if (!result.Success)
            {
                MsgBox.OK("添加失败" + Environment.NewLine + result.Message);
                return;
            }
            else
                AlertBox.Info("添加成功");
            foreach (GridRow row in rows)
            {
                var advice = row.Tag as AdviceEntity;
                this.dgvAllAdvice.PrimaryGrid.Rows.Remove(row);

                var newRow = this.dgvCategoryAdvice.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = advice.Name;
                newRow.Cells[colPrice.ColumnIndex].Value = advice.Price.ToString("f4") + "元";
                newRow.Cells[colSpell.ColumnIndex].Value = advice.SearchCode;
                newRow.Cells[colSample.ColumnIndex].Value = advice.Sample?.Value;
                newRow.Cells[colBuret.ColumnIndex].Value = advice.Buret?.Value;
                newRow.Cells[colPart.ColumnIndex].Value = advice.Part?.Value;
                newRow.Cells[colModality.ColumnIndex].Value = advice.Modality?.Value;
                newRow.Tag = advice;

                this.dgvCategoryAdvice.PrimaryGrid.Rows.Insert(0, newRow);
            }

        }
        /// <summary>
        /// 从分类中删除指定医嘱
        /// </summary>
        /// <param name="row"></param>
        private void DeleteFromCategory(GridRow row)
        {
            if (_selectedCategoryEntity == null)
            {
                MsgBox.OK("未选择分类,无法添加");
                return;
            }

            var advice = row.Tag as AdviceEntity;

            var result = _adviceService.DeleteAdviceCategoryMapper(advice.Id, _selectedCategoryEntity.Id);
            if (!result.Success)
            {
                MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
                return;
            }
            else
                AlertBox.Info("删除成功");

            this.dgvCategoryAdvice.PrimaryGrid.Rows.Remove(row);

            var newRow = this.dgvAllAdvice.PrimaryGrid.NewRow();
            newRow.Cells[colName.ColumnIndex].Value = advice.Name;
            newRow.Cells[colPrice.ColumnIndex].Value = advice.Price.ToString("f4") + "元";
            newRow.Cells[colSpell.ColumnIndex].Value = advice.SearchCode;
            newRow.Cells[colSample.ColumnIndex].Value = advice.Sample?.Value;
            newRow.Cells[colBuret.ColumnIndex].Value = advice.Buret?.Value;
            newRow.Cells[colPart.ColumnIndex].Value = advice.Part?.Value;
            newRow.Cells[colModality.ColumnIndex].Value = advice.Modality?.Value;
            newRow.Tag = advice;

            this.dgvAllAdvice.PrimaryGrid.Rows.Insert(0, newRow);
        }
        /// <summary>
        /// 批量从分类中删除医嘱
        /// </summary>
        /// <param name="rows"></param>
        private void DeleteFromCategory(SelectedElementCollection rows)
        {
            if (_selectedCategoryEntity == null)
            {
                MsgBox.OK("未选择分类,无法添加");
                return;
            }
            List<long> adviceIds = new List<long>();
            foreach (GridRow row in rows)
                adviceIds.Add(row.Tag.As<AdviceEntity>().Id);

            var result = _adviceService.DeleteAdviceCategoryMapper(adviceIds, _selectedCategoryEntity.Id);
            if (!result.Success)
            {
                MsgBox.OK("删除失败" + Environment.NewLine + result.Message);
                return;
            }
            else
                AlertBox.Info("删除成功");
            foreach (GridRow row in rows)
            {
                var advice = row.Tag as AdviceEntity;
                this.dgvCategoryAdvice.PrimaryGrid.Rows.Remove(row);

                var newRow = this.dgvAllAdvice.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = advice.Name;
                newRow.Cells[colPrice.ColumnIndex].Value = advice.Price.ToString("f4") + "元";
                newRow.Cells[colSpell.ColumnIndex].Value = advice.SearchCode;
                newRow.Cells[colSample.ColumnIndex].Value = advice.Sample?.Value;
                newRow.Cells[colBuret.ColumnIndex].Value = advice.Buret?.Value;
                newRow.Cells[colPart.ColumnIndex].Value = advice.Part?.Value;
                newRow.Cells[colModality.ColumnIndex].Value = advice.Modality?.Value;
                newRow.Tag = advice;

                this.dgvAllAdvice.PrimaryGrid.Rows.Insert(0, newRow);
            }

        }
        #endregion

        #region 窗体事件

        private void tabType_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (this.tabTest.IsSelected)
            {
                _categoryType = AdviceCategoryType.Test;
                _adviceCategoryMapper = _adviceService.GetAdviceCategoryMapper(0);
            }
            else
            {
                _categoryType = AdviceCategoryType.Inspect;
                _adviceCategoryMapper = _adviceService.GetAdviceCategoryMapper(1);
            }

            InitCategoryTree();
            InitDGVColumn();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAdviceCategoryEdit form = App.Instance.CreateView<FormAdviceCategoryEdit>();
            form.AllAdviceCategories = _categoryType == AdviceCategoryType.Test ? _testAdviceCategoryEntities : _inspectAdviceCategoryEntities;
            form.CategoryType = _categoryType;
            form.AllDepts = _allDeptEntities;
            form.Operation = DataOperation.New;
            form.NewCategory += Form_NewCategory;
            form.ShowDialog();
        }

        private void Form_NewCategory(object sender, AdviceCategoryEntity e)
        {
            if (_categoryType == AdviceCategoryType.Test)
                _testAdviceCategoryEntities.Add(e);
            else
                _inspectAdviceCategoryEntities.Add(e);

            var parentNode = this.treeCategory.Nodes.Count == 0 ? null : this.treeCategory.FindNodeByName(e.Parent.Id.ToString());
            Node newNode = new Node($@"<font color=""#0AFF10"">{e.Name}</font>");
            newNode.Name = e.Id.ToString();
            newNode.Tag = e;
            if (parentNode == null)
                this.treeCategory.Nodes.Add(newNode);
            else
                parentNode.Nodes.Add(newNode);
            newNode.Parent.Expand();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var selectedNode = this.treeCategory.SelectedNode;
            if (selectedNode == null)
                return;
            EditCategory(selectedNode);
        }

        private void treeCategory_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            EditCategory(e.Node);
        }


        private void treeCategory_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            var selectedNode = this.treeCategory.SelectedNode;
            if (selectedNode == null)
                return;

            _selectedCategoryEntity = selectedNode.Tag as AdviceCategoryEntity;
            List<long> adviceIds = new List<long>();
            if (_adviceCategoryMapper.ContainsKey(_selectedCategoryEntity.Id))
                adviceIds = _adviceCategoryMapper[_selectedCategoryEntity.Id];

            InitAdviceDGV(this.dgvAllAdvice, _allAdviceEntities.Where(p => p.Id._NotIn(adviceIds)).ToList());
            InitAdviceDGV(this.dgvCategoryAdvice, _allAdviceEntities.Where(p => p.Id._In(adviceIds)).ToList());
        }

        private void dgvAllAdvice_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            InsertToCategory(e.GridCell.GridRow);
        }

        private void btnAddToCategory_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvAllAdvice.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;
            else if (selectedRows.Count == 1)
                InsertToCategory(selectedRows[0] as GridRow);
            else
                InsertToCategory(selectedRows);
        }

        private void dgvCategoryAdvice_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            DeleteFromCategory(e.GridCell.GridRow);
        }

        private void btnDeleteFromCategory_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvCategoryAdvice.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;
            else if (selectedRows.Count == 1)
                DeleteFromCategory(selectedRows[0] as GridRow);
            else
                DeleteFromCategory(selectedRows);

        }
        #endregion
    }
}
