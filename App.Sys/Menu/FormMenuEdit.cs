using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Utility;
using DevComponents.AdvTree;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HIS.Core.UI;
using HIS.Service.Core.Enums;

namespace App_Sys
{
    /// <summary>
    /// 编辑模块
    /// </summary>
    public partial class FormMenuEdit : BaseDialogForm
    {
        private bool _isInsertOpration = false;
        private MenuEntity _updateModel;
        private long _appId;
        private long _parentId;

        private IAppService _appService;
        private IMenuService _menuService;

        public MenuEntity ViewModel { get; private set; }
        public string PText
        {
            get
            {
                if (this.cmbMenu.SelectedNode == null) return "";
                return this.cmbMenu.SelectedNode.Text;
            }
        }

        public FormMenuEdit(long appId, long parentId)
        {
            this.InitializeComponent();

            this._appService = HIS.Core.ServiceLocator.GetService<IAppService>();
            this._menuService = HIS.Core.ServiceLocator.GetService<IMenuService>();

            this._appId = appId;
            this._parentId = parentId;

            this._isInsertOpration = true;

            this.InitializeUI();
        }
        public FormMenuEdit(MenuEntity menu)
        {
            menu.CheckNotNull(nameof(menu));
            menu.AppInfo.CheckNotNull(nameof(menu.AppInfo));
            menu.Parent.CheckNotNull(nameof(menu.Parent));

            this.InitializeComponent();

            this._appService = HIS.Core.ServiceLocator.GetService<IAppService>();
            this._menuService = HIS.Core.ServiceLocator.GetService<IMenuService>();

            this._updateModel = menu;
            this._appId = menu.AppInfo.Id;
            this._parentId = menu.Parent.Id;

            this._isInsertOpration = false;
            this.InitializeUI();
        }
        private void InitializeUI()
        {

            this.InitializeAppList(this._appId);
            this.InitCategoryList(this._appId, this._parentId);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.GetEnumDict<MenuStyle>();
            this.cmbOpenStyle.ValueMember = "Key";
            this.cmbOpenStyle.DisplayMember = "Value";
            this.cmbOpenStyle.DataSource = bindingSource;

            if (this._updateModel != null)
            {
                this.txtName.Text = this._updateModel.Name;
                this.txtAssmely.Text = this._updateModel.Assmely;
                this.txtClassName.Text = this._updateModel.ClassName;
                this.txtInitParam.Text = this._updateModel.InitParam;
                this.txtNo.Text = this._updateModel.No.ToString();
                this.tbxPath.Text = this._updateModel.ImagePath;
                if (this._updateModel.Style.HasValue)
                    this.cmbOpenStyle.SelectedValue = this._updateModel.Style;
                else
                    this.cmbOpenStyle.SelectedIndex = -1;
                if (this._updateModel.Status == DataStatus.Enable)
                    this.rbtnEnable.Checked = true;
                else
                    this.rbtnDisable.Checked = true;
            }

        }
        /// <summary>
        /// 初始化系统模块列表
        /// </summary>
        /// <param name="appId"></param>
        private void InitializeAppList(long? appId)
        {
            this.cmbApp.DataBind(this._appService.GetList(false)
                , nameof(AppEntity.Id), nameof(AppEntity.Name), appId);
        }
        /// <summary>
        /// 初始化菜单分类
        /// </summary>
        /// <param name="appCode"></param>
        /// <param name="selectedMenuCode"></param>
        private void InitCategoryList(long appId, long? menuId = null)
        {
            var models = this._menuService.GetCategoryList(appId)
                .Select(m => new TreeModel { Code = m.Id.ToString(), ParentCode = m.Parent.Id.ToString(), Sort = m.No, Text = m.Name, Tag = m })
                .ToList();

            this.cmbMenu.AdvTree.BeginUpdate();
            var rootNode = new Node();
            rootNode.Name = "0";
            rootNode.Text = "根目录";
            this.cmbMenu.AdvTree.Nodes.Clear();
            this.cmbMenu.AdvTree.Nodes.Add(rootNode);
            this.cmbMenu.AdvTree.Nodes.AddRange(HIS.Utility.TreeHelper.CreateChildNodes(models, false));
            this.cmbMenu.AdvTree.EndUpdate();

            this.cmbMenu.AdvTree.ExpandAll();
            if (!menuId.HasValue)
                return;

            var node = this.cmbMenu.AdvTree.FindNodeByName(menuId.ToString());
            if (node != null)
                this.cmbMenu.SelectedNode = node;
        }

        /// <summary>
        /// 验证数据
        /// </summary>
        /// <returns></returns>
        protected bool CheckData()
        {
            if (this.cmbApp.SelectedValue.AsNotNullString().IsNullOrEmpty())
            {
                this.cmbApp.Focus();
                this.warningBox1.Text = "<b>警告</b> 请指定系统";
                this.warningBox1.AutoCloseTimeout = 2;
                this.warningBox1.Show();
                return false;
            }
            if (this.cmbMenu.SelectedNode == null)
            {
                this.cmbMenu.Focus();
                this.warningBox1.Text = "<b>警告</b> 请指定菜单分类";
                this.warningBox1.AutoCloseTimeout = 2;
                this.warningBox1.Show();
                return false;
            }
            if (this.txtName.Text.IsNullOrWhiteSpace())
            {
                this.txtName.Focus();
                this.warningBox1.Text = "<b>警告</b> 菜单名称不能为空";
                this.warningBox1.AutoCloseTimeout = 2;
                this.warningBox1.Show();
                return false;
            }
            //if (this.input_RNO.Text.IsNullOrWhiteSpace())
            //{
            //    this.input_RNO.Focus();
            //    this.warningBox1.Text = "<b>警告</b> 请输入程序集";
            //    this.warningBox1.AutoCloseTimeout = 2;
            //    this.warningBox1.Show();
            //    return false;
            //}
            //if (this.input_FName.Text.IsNullOrWhiteSpace())
            //{
            //    this.input_FName.Focus();
            //    this.warningBox1.Text = "<b>警告</b> 请输入命名空间";
            //    this.warningBox1.AutoCloseTimeout = 2;
            //    this.warningBox1.Show();
            //    return false;
            //}
            return true;
        }
        protected override void OnOK()
        {
            if (!this.CheckData()) return;
            if (this._isInsertOpration)
            {
                var menuEntity = new MenuEntity();
                menuEntity.Name = this.txtName.Text.Trim();
                menuEntity.AppInfo = new AppEntity() { Id = this.cmbApp.SelectedValue.AsLong(0) };
                menuEntity.Parent = new MenuEntity() { Id = this.cmbMenu.SelectedNode.Name.AsLong(0) };
                menuEntity.Style = (MenuStyle?)this.cmbOpenStyle.SelectedValue;
                menuEntity.Assmely = this.txtAssmely.Text.Trim();
                menuEntity.ClassName = this.txtClassName.Text.Trim();
                menuEntity.InitParam = this.txtInitParam.Text.Trim();
                menuEntity.Status = this.rbtnEnable.Checked ? DataStatus.Enable : DataStatus.Disable;
                menuEntity.No = this.txtNo.Text.AsInt(0);
                menuEntity.ImagePath = this.tbxPath.Text;
                this._menuService.Insert(this._appId, menuEntity);
                this.ViewModel = menuEntity;
            }
            else
            {
                this._updateModel.Name = this.txtName.Text.Trim();
                this._updateModel.AppInfo = new AppEntity() { Id = this.cmbApp.SelectedValue.AsLong(0) };
                this._updateModel.Parent = new MenuEntity() { Id = this.cmbMenu.SelectedNode.Name.AsLong(0) };
                this._updateModel.Style = (MenuStyle?)this.cmbOpenStyle.SelectedValue;
                this._updateModel.Assmely = this.txtAssmely.Text.Trim();
                this._updateModel.ClassName = this.txtClassName.Text.Trim();
                this._updateModel.InitParam = this.txtInitParam.Text.Trim();
                this._updateModel.Status = this.rbtnEnable.Checked ? DataStatus.Enable : DataStatus.Disable;
                this._updateModel.No = this.txtNo.Text.AsInt(0);
                this._updateModel.ImagePath = this.tbxPath.Text;
                var result = this._menuService.Update(this._updateModel.Id, this._updateModel);
                if (!result.Success)
                {
                    this.warningBox1.Text = $"<b>警告</b> {result.Message}";
                    this.warningBox1.AutoCloseTimeout = 2;
                    this.warningBox1.Show();
                    return;
                }
                this.ViewModel = this._updateModel;
            }
            base.OnOK();
        }

        private void FormModuleEdit_Load(object sender, EventArgs e)
        {
            this.cmbOpenStyle.ItemHeight = 22;
            this.cmbApp.ItemHeight = 22;

        }

        private void input_System_SelectedIndexChanged(object sender, EventArgs e)
        {
            long? appId = this.cmbApp.SelectedValue.AsLong();
            if (appId.HasValue)
            {
                this.InitCategoryList(appId.Value);
            }
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "图片文件(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";
                ofd.Multiselect = false;
                ofd.InitialDirectory = Application.StartupPath + "\\Resource\\MenuImages";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.tbxPath.Text = @"\Resource\MenuImages\" + Path.GetFileName(ofd.FileName);
                }
            }
        }
    }
}
