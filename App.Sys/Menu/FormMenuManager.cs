using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Core.UI;
using HIS.Service.Core.Enums;
using System.ComponentModel;
using HIS.Core;

namespace App_Sys
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    public partial class FormMenuManager : BaseForm
    {
        private IAppService _appService;
        private IMenuService _menuService;
        private IDeptService _deptService;
        private ISysDictQueryService _sysDictQueryService;
        private long? _selectedMenuId;//用于加载完菜单后默认选择的菜单项 记住加载完后清空
        private AppEntity SelectedApp
        {
            get
            {
                if (lbaSystem.SelectedItem != null)
                    return (lbaSystem.SelectedItem as ListBoxItem).Tag as AppEntity;
                return null;
            }
        }
        //private Timer timer;
        public FormMenuManager(IAppService appService, IMenuService menuService, IDeptService deptService, ISysDictQueryService sysDictQueryService)
        {
            InitializeComponent();

            this._appService = appService;
            this._menuService = menuService;
            this._deptService = deptService;
            this._sysDictQueryService = sysDictQueryService;

            #region 更新删除按钮和编辑按钮状态
            //timer = new Timer();
            //timer.Interval = 500;
            //timer.Tick += SetEditOrDeleteButtonEnable;
            //timer.Enabled = true;
            this.lbaSystem.GotFocus += SetEditOrDeleteButtonEnable;
            this.lbaSystem.LostFocus += SetEditOrDeleteButtonEnable;
            this.lbaSystem.VisibleChanged += SetEditOrDeleteButtonEnable;
            this.lbaSystem.SelectedIndexChanged += SetEditOrDeleteButtonEnable;
            this.superGridControl1.GotFocus += SetEditOrDeleteButtonEnable;
            this.superGridControl1.SelectionChanged += SetEditOrDeleteButtonEnable;
            this.superGridControl1.VisibleChanged += SetEditOrDeleteButtonEnable;
            this.superGridControl1.LostFocus += SetEditOrDeleteButtonEnable;

            #endregion

            this.superGridControl1.RowDoubleClick += superGridControl1_RowDoubleClick;
        }

        /// <summary>
        /// 更新删除按钮和编辑按钮状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetEditOrDeleteButtonEnable(object sender, EventArgs e)
        {
            //this.btnEdit.Enabled =
            //             this.btnDelete.Enabled =
            bool enable = (this.lbaSystem.Focused && this.lbaSystem.Visible && this.lbaSystem.SelectedIndices.Count > 0)
                        ||
                        (this.superGridControl1.Focused && this.superGridControl1.Visible && this.superGridControl1.PrimaryGrid.GetSelectedRows().Count > 0);
            if (enable != this.btnEdit.Enabled)
            {
                this.btnEdit.Enabled = enable;
                this.btnDelete.Enabled = enable;
            }
        }
        /// <summary>
        /// 创建系统项目
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        private ListBoxItem CreateSystemItem(AppEntity app)
        {
            ListBoxItem item = new ListBoxItem();
            UpdateSystemItem(item, app);
            return item;
        }
        /// <summary>
        /// 通过实体更新系统项目
        /// </summary>
        /// <param name="item"></param>
        /// <param name="app"></param>
        private void UpdateSystemItem(ListBoxItem item, AppEntity app)
        {
            item.Text = "  <b>{0}</b>".FormatWith(app.Name);
            item.Tag = app;
            item.Name = app.Id.ToString();
            item.Image = Properties.Resources.EmptySystemIcon_32x32;

            if (app.Status == DataStatus.Disable)
                item.TextColor = Color.Gray;
            else
                item.TextColor = Color.Empty;
        }
        /// <summary>
        /// 加载系统列表
        /// </summary>
        public void LoadSystems(long? selectedSystemId = null)
        {
            this.pnlTool.Enabled = false;
            this.rbtnSystemAll.Enabled = false;
            this.rbtnSystemValid.Enabled = false;
            bool allOrEnable = this.rbtnSystemAll.Checked;
            HIS.Utility.LoadHelper.LoadAsync<List<AppEntity>>(this.lbaSystem,
                () =>
                {
                    List<AppEntity> apps;
                    if (allOrEnable)
                        apps = this._appService.GetList(true);
                    else
                        apps = this._appService.GetList(false);
                    return apps;
                },
                data =>
                {
                    this.pnlTool.Enabled = true;
                    this.rbtnSystemAll.Enabled = true;
                    this.rbtnSystemValid.Enabled = true;

                    this.lbaSystem.Items.Clear();
                    this.lbaSystem.BeginUpdate();
                    foreach (var item in data)
                    {
                        this.lbaSystem.Items.Add(CreateSystemItem(item));
                    }
                    this.lbaSystem.EndUpdate();

                    if (selectedSystemId.HasValue) return;
                    foreach (ListBoxItem item in this.lbaSystem.Items)
                    {
                        var app = item.Tag as AppEntity;
                        if (app.Id == selectedSystemId)
                        {
                            this.lbaSystem.SelectedItem = item;
                            break;
                        }
                    }
                });
        }
        /// <summary>
        /// 添加系统
        /// </summary>
        private void AddSystem()
        {
            using (FormSystemEdit dialog = new FormSystemEdit())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var item = this.CreateSystemItem(dialog.App);
                    lbaSystem.Items.Add(item);
                    lbaSystem.SelectedIndex = lbaSystem.Items.Count - 1;
                }
            }

        }
        /// <summary>
        /// 编辑系统
        /// </summary>
        /// <param name="item"></param>
        private void EditSystem(ListBoxItem item)
        {
            if (item == null) return;
            var app = item.Tag as AppEntity;
            using (FormSystemEdit dialog = new FormSystemEdit(app))
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.UpdateSystemItem(item, app);
                }
            }
        }
        /// <summary>
        /// 删除系统
        /// </summary>
        /// <param name="item"></param>
        private void DeleteSystem(ListBoxItem item)
        {
            if (item == null) return;
            var curApp = item.Tag as AppEntity;

            if (HIS.Core.MsgBox.OKCancel("确定删除系统{0}?".FormatWith(item.Text))
                 == System.Windows.Forms.DialogResult.Cancel) return;
            var result = this._appService.Delete(curApp.Id);
            if (!result.Success)
            {
                HIS.Core.AlertBox.Error(result.Message);
            }
            else
            {
                lbaSystem.Items.Remove(item);
            }
        }
        /// <summary>
        /// 模块实体转换为树节点
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        private List<HIS.Utility.TreeModel> ToTreeModel(List<MenuEntity> menus)
        {
            List<HIS.Utility.TreeModel> models = new List<HIS.Utility.TreeModel>();
            foreach (var menu in menus)
            {
                string pname = "";
                var parentModule = menus.Find(m => m.Id == menu.Parent.Id);
                if (parentModule != null)
                    pname = parentModule.Name;
                var model = this.GetTreeModel(menu, pname);
                models.Add(model);
            }
            return models;
        }
        /// <summary>
        /// 通过模块实体和分类名称获取树节点实体
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public HIS.Utility.TreeModel GetTreeModel(MenuEntity menu, string category)
        {
            return new HIS.Utility.TreeModel()
            {
                Code = menu.Id.ToString()
                ,
                Text = menu.Name
                ,
                ParentCode = menu.Parent.Id.ToString()
                ,
                Cells = new object[] {
                            menu.Name                  // 模块名称
                            ,category                       // 上级名称
                            ,menu.Assmely                  // 程序集
                            ,menu.ClassName                // 命名空间
                            ,menu.No                   // 排序
                            ,menu.Style?.GetDescription()           //显示方式
                            ,menu.Status==DataStatus.Enable            //是否启用
             }
             ,
                Tag = menu
             ,
                Sort = menu.No
            };
        }
        /// <summary>
        /// 异步加载菜单信息
        /// </summary>
        public void LoadMenusAsync(long appId)
        {
            this.btnAddMenu.Enabled = false;
            //禁用控件
            this.pnlTool.Enabled = false;
            bool showAllOrEnable = this.rbtnMenuAll.Checked;
            HIS.Utility.LoadHelper.LoadAsync<GridRow[]>(this.superGridControl1
                , () =>
                {
                    //获取有效的模块信息
                    List<MenuEntity> menus;
                    if (showAllOrEnable)
                        menus = this._menuService.GetList(appId);
                    else
                        menus = this._menuService.GetList(appId, true);
                    //转换为树节点数据
                    var models = this.ToTreeModel(menus);
                    //返回行集合
                    return HIS.Utility.TreeHelper.CreateGridRows(models, RowFormat);
                }
                , data =>
                {
                    //加载所有行
                    HIS.Utility.TreeHelper.FillGrid(this.superGridControl1.PrimaryGrid, data);
                    this.superGridControl1.PrimaryGrid.ExpandAll();
                    //设置默认项
                    if (_selectedMenuId.HasValue)
                    {
                        var gr = HIS.Utility.TreeHelper.FindGridRow(this.superGridControl1.PrimaryGrid.Rows, _selectedMenuId.Value.ToString());
                        if (gr != null)
                        {
                            this.superGridControl1.PrimaryGrid.ClearSelectedRows();
                            if (!gr.IsOnScreen)
                                gr.EnsureVisible();
                            gr.IsSelected = true;
                        }
                        _selectedMenuId = null;
                    }
                    //启用控件
                    this.pnlTool.Enabled = true;
                    this.btnAddMenu.Enabled = true;
                }
                );
        }
        /// <summary>
        /// 行格式化
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="model"></param>
        private void RowFormat(GridRow gr, HIS.Utility.TreeModel model)
        {
            var m = model.Tag as MenuEntity;
            gr.CellStyles.Default.TextColor = m.Status == DataStatus.Enable ? Color.Empty : Color.Gray;
            gr.Cells[0].CellStyles.Default.ImageIndex = 0;
        }

        /// <summary>
        /// 获取当前包含的所有模块的代码
        /// 包含本身
        /// </summary>
        /// <param name="gr"></param>
        /// <returns></returns>
        private List<long> GetMenuIdList(GridRow gr)
        {
            if (gr == null) return null;
            var model = (gr.Tag as HIS.Utility.TreeModel).Tag as MenuEntity;
            if (model == null) return null;
            List<long> codes = new List<long>();
            codes.Add(model.Id);
            foreach (GridRow item in gr.Rows)
            {
                var childCodes = this.GetMenuIdList(item);
                if (childCodes != null)
                    codes.AddRange(childCodes);
            }
            return codes;
        }
        /// <summary>
        /// 插入模块
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="pCode"></param>
        private void AddMenu(long appId, long parentId)
        {
            using (FormMenuEdit dialog = new FormMenuEdit(appId, parentId))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //如果变更了系统则加载新的系统列表
                    if (appId != dialog.ViewModel.AppInfo.Id)
                    {
                        this._selectedMenuId = dialog.ViewModel.Id;
                        this.lbaSystem.SelectedItem = this.lbaSystem.GetItem(dialog.ViewModel.AppInfo.Id.ToString());
                        return;
                    }

                    this.superGridControl1.PrimaryGrid.ClearSelectedRows();
                    HIS.Utility.TreeHelper.AddGridRow(this.superGridControl1.PrimaryGrid, this.GetTreeModel(dialog.ViewModel, dialog.PText), RowFormat, true);
                }
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="gr"></param>
        private void EditMenu(GridRow gr)
        {
            if (gr == null) return;
            var model = (gr.Tag as HIS.Utility.TreeModel).Tag as MenuEntity;
            if (model == null) return;
            long oldAppId = model.AppInfo.Id;
            using (FormMenuEdit dialog = new FormMenuEdit(model))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //如果变更了系统则
                    if (oldAppId != dialog.ViewModel.AppInfo.Id)
                    {
                        _selectedMenuId = dialog.ViewModel.Id;
                        var item = this.lbaSystem.GetItem(dialog.ViewModel.AppInfo.Id.ToString());
                        this.lbaSystem.SelectedItem = item;
                    }
                    else
                    {
                        this.superGridControl1.PrimaryGrid.ClearSelectedRows();
                        var ngr = HIS.Utility.TreeHelper.RefreshGridRow(gr, this.GetTreeModel(dialog.ViewModel, dialog.PText), RowFormat);
                    }
                }
            }
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="gr"></param>
        private void DeleteMenu(GridRow gr)
        {
            if (gr == null) return;
            var module = (gr.Tag as HIS.Utility.TreeModel).Tag as MenuEntity;
            if (module == null) return;

            if (gr.Rows.Count > 0)
            {
                if (HIS.Core.MsgBox.YesNo("删除{0},将会连同子数据一起删除,是否继续?".FormatWith(module.Name)) == System.Windows.Forms.DialogResult.No)
                    return;
            }
            else
            {
                if (HIS.Core.MsgBox.YesNo("是否删除{0}?".FormatWith(module.Name)) == System.Windows.Forms.DialogResult.No)
                    return;
            }
            var codes = this.GetMenuIdList(gr);
            if (codes == null) return;
            //删除行
            var result = this._menuService.Delete(module.Id);
            if (result.Success)
            {
                HIS.Utility.TreeHelper.GridRowDelete(gr);
                HIS.Core.AlertBox.Info("<b>成功</b> 删除成功");
            }
            else
                HIS.Core.AlertBox.Error($"<b>错误</b> {result.Message}");

        }
        /// <summary>
        /// 加载所有科室列表
        /// </summary>
        private void LoadDeptAsync()
        {
            HIS.Utility.LoadHelper.LoadAsync<List<Node>>(this.advTree1,
                () =>
                {
                    var depts = this._deptService.GetList();
                    var categroyList = this._sysDictQueryService.GetDeptCategories();

                    List<Node> nodes = new List<Node>();
                    foreach (var item in categroyList)
                    {
                        Node node = new Node(item.Value);
                        node.Name = item.Id.ToString();
                        node.Tag = item;
                        node.CheckBoxVisible = true;
                        node.Nodes.AddRange(HIS.Utility.TreeHelper.CreateChildNodes(depts.Where(d => d.Category.Id == item.Id).Select(d => new HIS.Utility.TreeModel { Code = d.Id.ToString(), ParentCode = d.Parent.Id.ToString(), Text = d.Name, Tag = d }).ToList(), true, DeptNodeFormat));
                        nodes.Add(node);
                    }
                    return nodes;
                }
                , data =>
                {
                    this.advTree1.BeginUpdate();
                    rootNode.Nodes.Clear();
                    rootNode.Nodes.AddRange(data.ToArray());
                    this.advTree1.EndUpdate();
                    this.advTree1.ExpandAll();
                });
        }
        private void DeptNodeFormat(Node node, HIS.Utility.TreeModel tm)
        {

        }
        /// <summary>
        /// 加载系统对应的科室列表
        /// </summary>
        private void LoadDeptBySystem()
        {
            if (this.SelectedApp == null) return;
            this.LoadDepts(this._deptService.GetListByApp(this.SelectedApp.Id));
            this.rootNode.Checked = false;
            this.UpdateNodeCheck(this.rootNode, false);
        }
        /// <summary>
        /// 加载科室列表
        /// </summary>
        /// <param name="depts"></param>
        private void LoadDepts(List<DeptEntity> depts)
        {
            this.lbaDept.BeginUpdate();
            this.lbaDept.Items.Clear();
            foreach (var dept in depts)
            {
                ListBoxItem item = new ListBoxItem();
                item.Text = dept.Name;
                item.Name = dept.Code;
                item.Tag = dept;
                item.Image = Properties.Resources.DeptIcon_32x32;
                this.lbaDept.Items.Add(item);
            }
            this.lbaDept.EndUpdate();
        }
        /// <summary>
        /// 保存科室
        /// </summary>
        private void SaveDepts()
        {
            if (this.SelectedApp == null) return;
            long appId = this.SelectedApp.Id;
            if (!this._appService.SetLoginDeptList(appId, this.lbaDept.Items
                 .Select(i => ((i as ListBoxItem).Tag as DeptEntity).Id)
                 .ToArray()).Success)
            {
                HIS.Core.AlertBox.Error("<b>错误</b>  保存科室列表失败");
            }
        }
        /// <summary>
        /// 通过当前节点的状态更新父节点状态
        /// </summary>
        /// <param name="node"></param>
        private void UpdateParentNodeState(Node node)
        {
            if (node.Parent != null)
            {
                bool allSame = true;
                bool check = node.Parent.Nodes[0].Checked;
                foreach (Node n in node.Parent.Nodes)
                {
                    if (n.Checked != check)
                    {
                        allSame = false;
                        break;
                    }
                }
                if (allSame)
                {
                    node.Parent.Checked = check;
                }
                else
                    node.Parent.CheckState = CheckState.Indeterminate;
                this.UpdateParentNodeState(node.Parent);
            }
        }
        /// <summary>
        /// 根据当前节点的状态更新子节点状态
        /// </summary>
        /// <param name="node"></param>
        /// <param name="updateParent"></param>
        private void UpdateNodeCheck(Node node, bool updateParent)
        {
            if (updateParent)
                this.UpdateParentNodeState(node);
            foreach (Node n in node.Nodes)
            {
                n.Checked = node.Checked;
                UpdateNodeCheck(n, false);
            }
        }
        private void PreviewImage(TypeUri typeUri)
        {
            if (typeUri != null && typeUri.IsValid())
            {
                try
                {
                    var ass = System.Reflection.Assembly.LoadFile(System.IO.Path.Combine(Application.StartupPath, typeUri.Assembly + ".dll"));
                    var type = ass.GetType(typeUri.ClassName);

                    var form = HIS.Core.ServiceLocator.GetService(type) as Form;

                    //var form = ass.CreateInstance(homePage.ClassName) as Form;
                    if (form != null)
                    {
                        form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        form.WindowState = FormWindowState.Maximized;
                        form.Opacity = 0;
                        form.Show();

                        Bitmap image = new Bitmap(form.Width, form.Height);
                        form.DrawToBitmap(image, form.ClientRectangle);
                        form.Close();
                    }
                }
                catch
                {
                }
            }

        }

        private void FormModuleImport_Load(object sender, EventArgs e)
        {
            this.LoadDeptAsync();
            this.LoadSystems();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var app = this.SelectedApp;

            this.LoadSystems(app != null ? (long?)app.Id : null);
        }
        private void btnAddSystem_Click(object sender, EventArgs e)
        {
            this.AddSystem();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            long appId;
            var app = this.SelectedApp;
            if (app != null)
                appId = app.Id;
            else
                return;
            long parientId = 0;
            var selectedRows = this.superGridControl1.GetSelectedRows();
            if (selectedRows != null && selectedRows.Count > 0)
            {
                var model = (selectedRows[0].Tag as HIS.Utility.TreeModel).Tag as MenuEntity;
                parientId = model.Id;
            }
            this.AddMenu(appId, parientId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lbaSystem.Focused && this.lbaSystem.Visible)
            {
                this.EditSystem(this.lbaSystem.SelectedItem as ListBoxItem);
                return;
            }
            if (this.superGridControl1.Focused && this.superGridControl1.Visible)
            {
                var selectedRows = this.superGridControl1.GetSelectedRows();
                if (selectedRows == null || selectedRows.Count == 0) return;
                this.EditMenu(selectedRows[0] as GridRow);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbaSystem.Focused && this.lbaSystem.Visible)
            {
                this.DeleteSystem(this.lbaSystem.SelectedItem as ListBoxItem);
                return;
            }
            if (this.superGridControl1.Focused && this.superGridControl1.Visible)
            {
                var selectedRows = this.superGridControl1.GetSelectedRows();
                if (selectedRows == null || selectedRows.Count == 0) return;
                this.DeleteMenu(selectedRows[0] as GridRow);
            }
        }
        /// <summary>
        /// 仅显示有效系统还是全部系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemShowAllOrValid(object sender, EventArgs e)
        {
            var cb = sender as DevComponents.DotNetBar.Controls.CheckBoxX;
            if (this.rbtnSystemAll.Checked != cb.Checked)
                this.LoadSystems();
        }
        /// <summary>
        /// 加载指定系统的菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbaSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var app = this.SelectedApp;
            if (app != null)
            {
                if (this.superTabControl1.SelectedTab == stabItemMenu)
                {
                    this.LoadMenusAsync(app.Id);
                }
                else if (this.superTabControl1.SelectedTab == stabItemDept)
                {
                    this.LoadDeptBySystem();
                }
            }
        }
        /// <summary>
        /// 仅显示有效菜单还是全部菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuShowAllOrValid(object sender, EventArgs e)
        {
            var cb = sender as DevComponents.DotNetBar.Controls.CheckBoxX;
            if (this.rbtnMenuAll.Checked != cb.Checked)
            {
                if (this.SelectedApp != null)
                {
                    this.LoadMenusAsync(this.SelectedApp.Id);
                }
            }
        }

        private void superGridControl1_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            if (e.RowArea == RowArea.InCellExpand)
                return;
            this.EditMenu(this.superGridControl1.PrimaryGrid.GetSelectedRows()[0] as GridRow);
        }

        private void lbaSystem_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            this.EditSystem(this.lbaSystem.SelectedItem as ListBoxItem);
        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (e.NewValue == this.stabItemDept)
            {
                this.LoadDeptBySystem();
            }
            else if (e.NewValue == this.stabItemMenu)
            {
                if (this.SelectedApp == null) return;
                this.LoadMenusAsync(this.SelectedApp.Id);
            }
            else
            {
            }
        }

        private void advTree1_AfterCheck(object sender, AdvTreeCellEventArgs e)
        {
            if (e.Action == eTreeAction.Code) return;
            var curNode = e.Cell.Parent;
            this.UpdateNodeCheck(curNode, true);

            //设置选中的科室
            var depts = this.advTree1.CheckedNodes
                .Where(n => n.Tag is DeptEntity)
                .Select(m => m.Tag as DeptEntity).ToList();
            this.LoadDepts(depts);
            this.SaveDepts();
        }

        private void advTree1_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //防止点击到checkbox
                if (e.X > e.Node.Bounds.X + 10)
                {
                    e.Node.SetChecked(!e.Node.Checked, eTreeAction.Mouse);
                }
            }
        }

        private void lbaDept_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            var item = (this.lbaDept.SelectedItem as ListBoxItem);
            if (item != null)
            {
                var nodes = this.advTree1.Nodes.Find(item.Name, true);
                if (nodes != null && nodes.Length > 0)
                {
                    foreach (Node node in nodes)
                    {
                        node.SetChecked(false, eTreeAction.Mouse);
                    }
                }
            }
        }


    }
}
