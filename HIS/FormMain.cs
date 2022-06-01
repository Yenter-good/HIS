using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Core;
using DevComponents.DotNetBar;
using HIS.Service.Core.Entities;
using System.Reflection;
using HIS.Service.Core.Enums;
using HIS.Service.Core;

namespace HIS
{
    public partial class FormMain : BaseForm
    {
        private List<MenuEntity> _currentMenuList;
        public FormMain()
        {
            InitializeComponent();
        }
        #region 初始化
        /// <summary>
        /// 初始化系统按钮
        /// </summary>
        private void InitApp()
        {
            #region 加载工作台

            this._menuApp.Items.Clear();
            foreach (var item in App.Instance.User.AppList)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = item.Name;
                tsmi.Tag = item;
                tsmi.Click += AppButton_Click;
                this._menuApp.Items.Add(tsmi);
            }

            #endregion

            #region 设置用户图标

            switch (App.Instance.RuntimeSystemInfo.UserInfo.UserType)
            {
                case UserType.Doctor:
                    this.picUserLogo.Image = this._userImgList.Images[1];
                    break;
                case UserType.Nurse:
                    this.picUserLogo.Image = this._userImgList.Images[0];
                    break;
                case UserType.Admin:
                    this.picUserLogo.Image = this._userImgList.Images[2];
                    break;
                default:
                    this.picUserLogo.Image = null;
                    break;
            }
            #endregion

            #region 设置状态栏信息

            this.btnIP.Text = $"IP地址:{Utility.MachineHelper.GetIPAddress()}";
            this.btnLoginUserName.Text = $"当前登录用户:{ App.Instance.RuntimeSystemInfo.UserInfo.Name}";
            if (!this._timerLocalTime.Enabled)
            {
                this._timerLocalTime.Enabled = true;
                this._timerLocalTime.Tick += (x, y) =>
                {
                    this.lblLocalTime.Text = $"当前时间:{ DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒")}";
                };
            }
            #endregion
        }
        /// <summary>
        /// 切换系统
        /// </summary>
        /// <param name="app"></param>
        private void SwitchApp(AppEntity app)
        {
            //清空当前打开的界面
            if (!this.CloseAllView())
                return;
            var rs = App.Instance.SwitchApp(app.Id);
            if (rs.Success)
            {
                ///加载系统菜单
                this.btnAppList.Text = app.Name;
                this.Header.Menu.ClearAll();
                this._currentMenuList = App.Instance.User.GetMenuList();
                LoadMenus(this._currentMenuList);
                InitDept();
            }
        }
        private void InitDept()
        {
            List<DeptEntity> depts;
            if (App.Instance.RuntimeSystemInfo.DeptList.Count == 0)
                depts = App.Instance.RuntimeSystemInfo.DefaultDeptList;
            else
                depts = App.Instance.RuntimeSystemInfo.DeptList;

            this.btnDept.Text = "";
            this.btnDept.Tag = null;
            this._menuDept.Items.Clear();
            foreach (var dept in depts)
            {
                ToolStripMenuItem deptItem = new ToolStripMenuItem();
                deptItem.Tag = dept;
                deptItem.Text = dept.Name;
                deptItem.Click += DeptChanged;
                this._menuDept.Items.Add(deptItem);
            }

            var defaultDept = depts[0];
            if (App.Instance.User.RoleAddition.DefaultDept != null)
            {
                var dept = depts.Find(p => p.Id == App.Instance.User.RoleAddition.DefaultDept.Id);
                if (dept != null)
                    defaultDept = dept;
            }

            this.btnDept.Text = defaultDept.Name;
            this.btnDept.Tag = defaultDept;
        }

        private void DeptChanged(object sender, EventArgs e)
        {
            var selectedDept = (sender as ToolStripMenuItem).Tag as DeptEntity;
            var selectedTab = this.tabMain.SelectedTab;
            if (selectedTab == null || selectedTab.AttachedControl.Controls.Count == 0)
                return;
            if (selectedTab.AttachedControl.Controls[0] is IViewContent)
            {
                var view = selectedTab.AttachedControl.Controls[0] as IViewContent;
                var success = view.SetViewUnitData(selectedDept.Id);
                if (success)
                {
                    this.btnDept.Text = selectedDept.Name;
                    this.btnDept.Tag = selectedDept;
                }
            }
        }

        private void FilterDept(IViewContent view)
        {
            this.pnlViewUnit.Visible = view.ShowDeptList;
            if (!this.pnlViewUnit.Visible)
                return;

            var depts = view.FilterViewDeptList();
            if (depts.Count == 0)
                depts = App.Instance.RuntimeSystemInfo.DefaultDeptList;

            this.btnDept.Text = "";
            this.btnDept.Tag = null;
            this._menuDept.Items.Clear();
            foreach (var dept in depts)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = dept.Name;
                tsmi.Tag = dept;
                this._menuDept.Items.Add(tsmi);
                tsmi.Click += DeptChanged;
            }

            DeptEntity deptEntity = null;
            if (view.ViewData.Dept == null)
            {
                var dept = depts.Find(p => p.Id == App.Instance.User.RoleAddition.DefaultDept?.Id);
                if (dept != null)
                    deptEntity = dept;
                else
                    deptEntity = depts[0];
            }
            else
                deptEntity = view.ViewData.Dept;

            this.btnDept.Text = deptEntity.Name;
            this.btnDept.Tag = deptEntity;
        }

        /// <summary>
        /// 显示指定的菜单
        /// </summary>
        /// <param name="menu"></param>
        private void ShowMenu(MenuEntity menu)
        {
            if (!menu.Style.HasValue)
            {
                MsgBox.OK("该功能显示模式定义错误 请联系管理员");
                return;
            }

            if (menu.Style == MenuStyle.Method)
            {
                var assembly = Assembly.Load(menu.Assmely);
                string[] name = menu.ClassName.Split('_');
                Type t = assembly.GetType(menu.Assmely + "." + name[0]);
                t.RunFunction(name[1], new object[] { });
                return;
            }

            var exists = this.tabMain.Tabs.IndexOf("menu_" + menu.ClassName + (menu.InitParam == null ? 0 : menu.InitParam.GetHashCode()));
            if (exists >= 0)
            {
                this.tabMain.SelectedTabIndex = exists;
                return;
            }

            try
            {
                var form = App.Instance.CreateView(menu.Assmely, menu.ClassName);
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Show();

                var tab = this.tabMain.CreateTab(form.Text);
                tab.Name = "menu_" + menu.ClassName + (menu.InitParam == null ? 0 : menu.InitParam.GetHashCode());
                tab.Text = form.Text;
                tab.CloseButtonVisible = true;
                tab.AttachedControl.Controls.Add(form);
                this.tabMain.SelectedTab = tab;

                form.TextChanged += Form_TextChanged;
                var view = form as IViewContent;
                if (view != null)
                {
                    view.CreateParame = menu.InitParam;
                    FilterDept(view);
                    if (view.ShowDeptList)
                        view.SetViewUnitData(this.btnDept.Tag.As<DeptEntity>().Id);
                }

            }
            catch (Exception ex)
            {
                MsgBox.OK("创建菜单失败：" + Environment.NewLine + ex.Message);
            }
        }

        private void Form_TextChanged(object sender, EventArgs e)
        {
            var form = sender as Form;
            var parent = form.Parent as SuperTabControlPanel;
            parent.TabItem.Text = form.Text;
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = sender as ToolStripMenuItem;
            AppEntity app = (AppEntity)btn.Tag;
            try
            {
                SwitchApp(app);
            }
            catch (Exception ex)
            {
                MsgBox.OK(ex.Message);
            }
        }
        #endregion

        #region 创建菜单
        /// <summary>
        /// 创建菜单组
        /// </summary>
        /// <param name="menuList"></param>
        private void LoadMenus(List<MenuEntity> menuList)
        {
            if (menuList.Count < 1)
            {
                return;
            }
            List<MenuEntity> groupMenus = menuList.Where(x => x.Parent == null || x.Parent.Id == 0).ToList<MenuEntity>();
            if (groupMenus.Count == 0)  //递归终止，区域不包含子区域时
            {
                return;
            }
            this._menuImgList.Images.Clear();
            foreach (MenuEntity menu in groupMenus)
            {
                var childMenus = menuList.Where(d => d.Parent != null && d.Parent.Id == menu.Id).ToList();
                //TreeNode node = null;
                //bool bindTag = false;
                //if (childMenus != null && childMenus.Count == 1)
                //    node = this.CreateNode(childMenus[0], bindTag = true);
                //else
                var node = this.CreateNode(menu);
                //if (!bindTag)
                this.LoadChildMenus(node, menu.Id, menuList);
                this.Header.Nodes.Add(node);
            }
            //当前分组下只有一个菜单的话，直接显示一级子菜单
            //foreach (TreeNode node in this.Header.Nodes)
            //{
            //    if (node.Level > 0 || node.Nodes.Count > 1)
            //        continue;
            //    var childNode = node.Nodes[0];
            //    var menu = childNode.Tag as MenuEntity;
            //    node.Text = menu.Name;
            //    node.Tag = menu;
            //    node.ImageIndex = childNode.ImageIndex;
            //    node.Nodes.Clear();
            //}

            this.Header.NodeMouseClick += Header_NodeMouseClick;
            this.Header.Invalidate();
        }

        private void Header_NodeMouseClick(TreeNode node, int menuIndex, int pageIndex)
        {
            if (node.Tag != null)
                this.ShowMenu(node.Tag as MenuEntity);
        }

        /// <summary>
        /// 菜单组子菜单
        /// </summary>
        /// <param name="menuId">父节点ID</param>
        /// <param name="menuList">数据</param>
        private void LoadChildMenus(TreeNode groupNode, long menuId, List<MenuEntity> menuList)
        {
            List<MenuEntity> menus = menuList.Where(x => x.Parent?.Id == menuId).ToList<MenuEntity>();
            if (menus.Count == 0)  //递归终止，区域不包含子区域时
            {
                return;
            }

            foreach (MenuEntity menu in menus)
            {
                var node = this.CreateNode(menu);
                groupNode.Nodes.Add(node);
            }
        }

        private TreeNode CreateNode(MenuEntity menu)
        {
            TreeNode node = new TreeNode();
            node.Text = menu.Name;
            if (!string.IsNullOrWhiteSpace(menu.Assmely))
                node.Tag = menu;
            if (!string.IsNullOrWhiteSpace(menu.ImagePath))
            {
                this._menuImgList.Images.Add(menu.ImagePath.GetLocalRelativePathImage());
                node.ImageIndex = this._menuImgList.Images.Count - 1;
            }

            return node;
        }
        #endregion

        private void FormMain_Shown(object sender, EventArgs e)
        {
            InitApp();
        }

        #region 关闭选项卡轮训是否完成操作
        /// <summary>
        /// 挨个关闭视图
        /// </summary>
        /// <returns></returns>
        protected bool CloseAllView()
        {
            var tabItems = this.tabMain.Tabs.Cast<BaseItem>().Where(p => p is SuperTabItem).ToList();
            foreach (SuperTabItem tabItem in tabItems)
            {
                if (!tabItem.CloseButtonVisible || tabItem.AttachedControl.Controls.Count == 0)
                    continue;
                var view = tabItem.AttachedControl.Controls[0] as IViewContent;
                if (view == null)
                    continue;
                var result = view.Close();
                if (!result)
                    return false;

                this.tabMain.Tabs.Remove(tabItem);
            }
            return true;
        }
        private void tabMain_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
        {
            var item = e.Tab as SuperTabItem;
            if (item.AttachedControl.Controls.Count == 0)
                return;
            var view = item.AttachedControl.Controls[0] as IViewContent;
            var result = view.Close();
            if (!result)
                e.Cancel = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = CloseAllView();
            if (!result)
                e.Cancel = true;

            ServiceLocator.GetService<ISessionService>().Release();
        }
        #endregion

        #region 科室修改
        private void tabMain_SelectedTabChanging(object sender, SuperTabStripSelectedTabChangingEventArgs e)
        {
            if (e.NewValue is SuperTabItem)
            {
                var tabItem = e.NewValue.As<SuperTabItem>();
                if (tabItem.AttachedControl.Controls.Count > 0)
                {
                    if (tabItem.AttachedControl.Controls[0] is IViewContent)
                    {
                        var view = tabItem.AttachedControl.Controls[0] as IViewContent;

                        FilterDept(view);
                    }
                }
            }
        }
        private void btnAppList_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = this.btnAppList.Location.X;
            p.Y = this.btnAppList.Location.Y + this.btnAppList.Height - 9;
            this._menuApp.Show(this.btnAppList, p);
        }
        private void picUserLogo_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = this.picUserLogo.Location.X;
            p.Y = this.picUserLogo.Location.Y + this.picUserLogo.Height;
            this._menuUserOperation.Show(this.picUserLogo, p);
        }
        private void btnDept_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = this.btnDept.Location.X;
            p.Y = this.btnDept.Location.Y + this.btnDept.Height;
            this._menuDept.Show(this.btnDept, p);
        }
        #endregion

    }
}
