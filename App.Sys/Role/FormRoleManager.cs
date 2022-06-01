using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.AdvTree;
using HIS.Core.UI;
using HIS.Core;
using HIS.Service.Core;
using DevComponents.DotNetBar;
using HIS.Service.Core.Entities;
using System.Reflection;

namespace App_Sys.RoleManager
{
    public partial class FormRoleManager : BaseForm
    {
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        private readonly IMenuService _menuService;
        private readonly IAppService _appService;

        private List<UserEntity> _allUsers;
        public FormRoleManager(IRoleService roleService, IUserService userService, IMenuService menuService, IAppService appService)
        {
            InitializeComponent();
            this._roleService = roleService;
            this._userService = userService;
            this._menuService = menuService;
            this._appService = appService;
        }

        #region 初始化

        /// <summary>
        /// 初始化所有权限信息
        /// </summary>
        private void InitPermission()
        {
            this.treePermission.Nodes.Clear();

            PermissionsContants contants = new PermissionsContants();
            var properties = contants.GetType().GetProperties().Where(p => p.IsDefined(typeof(PermissionAttribute), false)).ToList();

            foreach (var property in properties)
            {
                Node parentNode;
                var attribute = property.GetCustomAttribute<PermissionAttribute>();
                var parentNodes = this.treePermission.Nodes.Find(attribute.ParentName, false);
                if (parentNodes.Length == 0)
                {
                    parentNode = new Node(attribute.ParentName) { Name = attribute.ParentName };
                    this.treePermission.Nodes.Add(parentNode);
                }
                else
                    parentNode = parentNodes[0];

                Node node = new Node(attribute.Name);
                node.Tag = property.GetValue(contants);
                node.CheckBoxVisible = true;
                parentNode.Nodes.Add(node);
            }
            this.treePermission.ExpandAll();
        }
        /// <summary>
        /// 初始化用户列表
        /// </summary>
        private void InitUser()
        {
            _allUsers = _userService.GetAll();
        }
        /// <summary>
        /// 初始化角色列表
        /// </summary>
        private void InitRoleList()
        {
            HIS.DSkinControl.QLoading.Show(this.dgvRole);
            var roleList = _roleService.GetAll();
            roleList.RemoveAll(p => p.Level < App.Instance.User.Role.Level);

            this.dgvRole.PrimaryGrid.DataSource = roleList;
            HIS.DSkinControl.QLoading.Close(this.dgvRole);
        }
        /// <summary>
        /// 初始化所有菜单
        /// </summary>
        private void InitMenuList()
        {
            var apps = _appService.GetList();
            foreach (var app in apps)
            {
                Node appNode = new Node(app.Name);
                var menus = _menuService.GetList(app.Id);
                appNode.Nodes.AddRange(RecursiveMenu(0, menus).ToArray());

                this.treeMenu.Nodes.Add(appNode);
            }
            this.treeMenu.ExpandAll();
        }
        private List<Node> RecursiveMenu(long parentId, List<MenuEntity> menuEntities)
        {
            List<Node> result = new List<Node>();
            var menus = menuEntities.Where(p => p.Parent.Id == parentId);
            foreach (var menu in menus)
            {
                Node node = new Node(menu.Name);
                node.Tag = menu.Id;
                node.CheckBoxVisible = true;
                result.Add(node);

                node.Nodes.AddRange(RecursiveMenu(menu.Id, menuEntities).ToArray());
            }
            return result;
        }
        #endregion

        #region 窗体事件
        private void btnRefreshRole_Click(object sender, EventArgs e)
        {
            InitRoleList();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            FormAddRole form = App.Instance.CreateView<FormAddRole>();
            if (form.ShowDialog() == DialogResult.OK)
                InitRoleList();
        }

        private void dgvRole_RowClick(object sender, GridRowClickEventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            var selectedRow = e.GridRow as GridRow;
            var roleId = selectedRow.Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            this.dgvRoleUser.PrimaryGrid.Rows.Clear();
            this.dgvAllUser.PrimaryGrid.Rows.Clear();

            var users = _userService.GetByRole(roleId);
            foreach (var user in users)
            {
                GridRow row = this.dgvRoleUser.PrimaryGrid.NewRow();
                row.Cells[colRoleUserCode.ColumnIndex].Value = user.Code;
                row.Cells[colRoleUserId.ColumnIndex].Value = user.Id;
                row.Cells[colRoleUserName.ColumnIndex].Value = user.Name;
                row.Tag = user;
                this.dgvRoleUser.PrimaryGrid.Rows.Add(row);
            }
            var allUsers = _allUsers.Except(users).ToList();
            foreach (var user in allUsers)
            {
                GridRow row = this.dgvAllUser.PrimaryGrid.NewRow();
                row.Cells[colAllUserCode.ColumnIndex].Value = user.Code;
                row.Cells[colAllUserId.ColumnIndex].Value = user.Id;
                row.Cells[colAllUserName.ColumnIndex].Value = user.Name;
                row.Tag = user;
                this.dgvAllUser.PrimaryGrid.Rows.Add(row);
            }

            var menus = _menuService.GetByRole(roleId);
            var permissions = _roleService.GetAuthorityWithoutCache(roleId);
            ClearCheck(this.treeMenu.Nodes);
            ClearCheck(this.treePermission.Nodes);
            SetMenuCheck(this.treeMenu.Nodes, menus);
            SetPermissionCheck(permissions.Select(p => p.Code).ToList());
            RefreshMenuTreeStyle(this.treeMenu.Nodes);

            HIS.DSkinControl.QLoading.Close(this);
        }
        private void treeMenu_AfterCheck(object sender, AdvTreeCellEventArgs e)
        {
            if (e.Action == eTreeAction.Mouse)
            {
                var node = e.Cell.Parent;
                var parentNode = node.Parent;
                if (parentNode.CheckBoxVisible)
                {
                    var checkedNumber = parentNode.Nodes.Cast<Node>().Count(p => p.Checked);
                    if (checkedNumber != parentNode.Nodes.Count && checkedNumber > 0)
                        parentNode.CheckState = CheckState.Indeterminate;
                    else if (checkedNumber == parentNode.Nodes.Count)
                        parentNode.CheckState = CheckState.Checked;
                    else
                        parentNode.CheckState = CheckState.Unchecked;
                }

                node.Nodes.Cast<Node>().ToList().ForEach(p => p.Checked = node.Checked);
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 清除指定节点下的所有节点的选中状态
        /// </summary>
        /// <param name="nodes"></param>
        private void ClearCheck(NodeCollection nodes)
        {
            foreach (Node node in nodes)
            {
                node.CheckState = CheckState.Unchecked;
                ClearCheck(node.Nodes);
            }
        }
        /// <summary>
        /// 菜单树根据指定的菜单列表进行选中操作
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="menuEntities"></param>
        private void SetMenuCheck(NodeCollection nodes, List<MenuEntity> menuEntities)
        {
            foreach (Node node in nodes)
            {
                if (node.Tag == null)
                {
                    SetMenuCheck(node.Nodes, menuEntities);
                    continue;
                }
                if (menuEntities.Exists(p => p.Id == node.Tag.AsLong(0)))
                    node.Checked = true;
                SetMenuCheck(node.Nodes, menuEntities);
            }
        }
        /// <summary>
        /// 权限集树根据指定的权限进行选中操作
        /// </summary>
        /// <param name="permissionCodes"></param>
        private void SetPermissionCheck(List<string> permissionCodes)
        {
            foreach (Node node in this.treePermission.Nodes)
            {
                foreach (Node permissionNode in node.Nodes)
                {
                    if (permissionCodes.Contains(permissionNode.Tag.AsString("")))
                        permissionNode.Checked = true;
                }
            }
        }
        /// <summary>
        /// 刷新菜单树样式
        /// </summary>
        private void RefreshMenuTreeStyle(NodeCollection nodes)
        {
            foreach (Node node in nodes)
            {
                var checkedNumber = node.Nodes.Cast<Node>().Count(p => p.Checked);
                if (checkedNumber < node.Nodes.Count && checkedNumber > 0)
                    node.CheckState = CheckState.Indeterminate;

                RefreshMenuTreeStyle(node.Nodes);
            }
        }
        /// <summary>
        /// 获得指定节点集中选中的节点，包括半选中的节点
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        private List<Node> GetSelectedNode(NodeCollection nodes)
        {
            List<Node> result = new List<Node>();
            foreach (Node node in nodes)
            {
                if (node.CheckState != CheckState.Unchecked)
                    result.Add(node);
                result.AddRange(GetSelectedNode(node.Nodes));
            }
            return result;
        }
        #endregion

        private void FormRoleManager_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            InitPermission();
            InitRoleList();
            InitUser();
            InitMenuList();
            HIS.DSkinControl.QLoading.Close(this);
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            var selectedRole = this.dgvRole.PrimaryGrid.GetSelectedRows();
            if (selectedRole.Count == 0)
            {
                MsgBox.OK("请先选择角色");
                return;
            }
            var roleId = selectedRole[0].As<GridRow>().Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            var selectedNodes = GetSelectedNode(this.treeMenu.Nodes);
            var result = _roleService.InsertMenus(roleId, selectedNodes.Select(p => p.Tag.AsLong(0)).ToList());
            if (result.Success)
                AlertBox.Info("保存成功");
            else
                MsgBox.OK("保存失败，请重试:" + Environment.NewLine + result.Message);
            HIS.DSkinControl.QLoading.Close(this);
        }

        private void btnDelRole_Click(object sender, EventArgs e)
        {
            var selectedRole = this.dgvRole.PrimaryGrid.GetSelectedRows();
            if (selectedRole.Count == 0)
            {
                MsgBox.OK("请先选择角色");
                return;
            }
            if (MsgBox.YesNo("是否确定删除该角色\r\n请注意:该操作为敏感操作") != DialogResult.Yes)
                return;

            var roleId = selectedRole[0].As<GridRow>().Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            var result = _roleService.Delete(roleId);
            if (result.Success)
            {
                this.dgvRole.PrimaryGrid.Rows.Remove(selectedRole[0]);
                AlertBox.Info("删除成功");
            }
            else
                MsgBox.OK("删除失败，请重试:" + Environment.NewLine + result.Message);
        }

        private void btnSavePermission_Click(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            var selectedRole = this.dgvRole.PrimaryGrid.GetSelectedRows();
            if (selectedRole.Count == 0)
            {
                MsgBox.OK("请先选择角色");
                return;
            }
            var roleId = selectedRole[0].As<GridRow>().Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            var checkedNodes = this.treePermission.CheckedNodes;
            var codes = checkedNodes.Cast<Node>().Select(p => p.Tag.AsString("")).ToList();

            var result = _roleService.InsertPermission(roleId, codes);
            if (result.Success)
                AlertBox.Info("保存成功");
            else
                MsgBox.OK("保存失败，请重试:" + Environment.NewLine + result.Message);

            HIS.DSkinControl.QLoading.Close(this);
        }

        private void dgvAllUser_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            var selectedRole = this.dgvRole.PrimaryGrid.GetSelectedRows();
            if (selectedRole.Count == 0)
            {
                MsgBox.OK("请先选择角色");
                return;
            }
            var roleId = selectedRole[0].As<GridRow>().Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            var selectedRow = e.GridRow as GridRow;
            var user = _allUsers.Find(p => p.Id == selectedRow.Tag.As<UserEntity>().Id);

            var result = _roleService.InsertUser(roleId, user.Id);
            if (result.Success)
            {
                e.Cancel = true;
                this.dgvAllUser.PrimaryGrid.Rows.Remove(e.GridRow);
                GridRow row = this.dgvRoleUser.PrimaryGrid.NewRow();
                row.Cells[colRoleUserCode.ColumnIndex].Value = user.Code;
                row.Cells[colRoleUserId.ColumnIndex].Value = user.Id;
                row.Cells[colRoleUserName.ColumnIndex].Value = user.Name;
                row.Tag = user;
                this.dgvRoleUser.PrimaryGrid.Rows.Add(row);
                this.dgvRoleUser.PrimaryGrid.ScrollToBottom();
            }
            else
                MsgBox.OK("添加失败，请重试:" + Environment.NewLine + result.Message);

        }

        private void dgvRoleUser_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            var selectedRole = this.dgvRole.PrimaryGrid.GetSelectedRows();
            if (selectedRole.Count == 0)
            {
                MsgBox.OK("请先选择角色");
                return;
            }
            var roleId = selectedRole[0].As<GridRow>().Cells[colRoleId.ColumnIndex].Value.AsLong(0);

            var selectedRow = e.GridRow as GridRow;
            var user = _allUsers.Find(p => p.Id == selectedRow.Tag.As<UserEntity>().Id);

            var result = _roleService.DeleteUser(roleId, user.Id);
            if (result.Success)
            {
                e.Cancel = true;
                this.dgvRoleUser.PrimaryGrid.Rows.Remove(e.GridRow);
                GridRow row = this.dgvAllUser.PrimaryGrid.NewRow();
                row.Cells[colRoleUserCode.ColumnIndex].Value = user.Code;
                row.Cells[colRoleUserId.ColumnIndex].Value = user.Id;
                row.Cells[colRoleUserName.ColumnIndex].Value = user.Name;
                row.Tag = user;
                this.dgvAllUser.PrimaryGrid.Rows.Insert(0, row);
                this.dgvAllUser.PrimaryGrid.ScrollToTop();
            }
            else
                MsgBox.OK("删除失败，请重试:" + Environment.NewLine + result.Message);
        }
    }
}
