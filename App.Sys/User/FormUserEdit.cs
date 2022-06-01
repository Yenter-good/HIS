using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;

namespace App_Sys.User
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2020-08-10 17:00:49
    /// 描述:
    /// </summary>
    public partial class FormUserEdit : BaseDialogForm
    {
        private readonly IDeptService _deptService;
        private readonly IRoleService _roleService;
        private readonly ISysDictQueryService _sysDictQueryService;
        private readonly IUserService _userService;
        private readonly ITitleService _titleService;

        private List<TitleEntity> _titleEntities;
        private List<DeptEntity> _allDeptEntities;
        private List<UserEntity> _allUserEntities;

        public FormUserEdit(IDeptService deptService, IRoleService roleService, ISysDictQueryService sysDictQueryService, IUserService userService, ITitleService titleService)
        {
            InitializeComponent();
            this._deptService = deptService;
            this._roleService = roleService;
            this._sysDictQueryService = sysDictQueryService;
            this._userService = userService;
            this._titleService = titleService;
        }
        internal DataOperation Operation { get; set; }
        internal UserEntity SelectedUser { private get; set; }

        internal event EventHandler<UserEntity> NewUser;

        #region 初始化

        private void InitRole()
        {
            if (SelectedUser == null)
                return;

            var allRoles = _roleService.GetAll();

            var roles = _roleService.GetByUser(SelectedUser.Id);
            if (roles.Count > 0)
                this.panelEx2.Hide();

            var notUserRoles = allRoles.Except(roles);
            if (notUserRoles.Count() == 0)
                this.btnAddRole.Visible = false;
            else
            {
                foreach (var notUserRole in notUserRoles)
                {
                    ButtonItem item = new ButtonItem(notUserRole.Id.ToString(), notUserRole.Name);
                    item.Tag = notUserRole;
                    this.menuRoleList.SubItems.Add(item);
                    item.Click += Item_Click;
                }
            }

            _allDeptEntities = _deptService.GetList();
            _allUserEntities = _userService.GetAll();

            SelectedUser.RoleAdditions = _roleService.GetAllAddition(SelectedUser.Id);

            foreach (var role in roles)
            {
                UCUserRoleInfo uc = new UCUserRoleInfo();
                uc.Dock = DockStyle.Fill;
                var item = this.tabRole.CreateTab(role.Name);
                item.AttachedControl.Controls.Add(uc);
                uc.Init(_allDeptEntities, _allUserEntities, role, SelectedUser);
            }

            this.cbxDefaultRole.DisplayMember = nameof(RoleEntity.Name);
            this.cbxDefaultRole.ValueMember = nameof(RoleEntity.Id);
            this.cbxDefaultRole.DataSource = roles;
        }



        private void InitUI()
        {
            var education = _sysDictQueryService.GetEducation();
            this.cbxEduction.DisplayMember = nameof(ItemEntity.Value);
            this.cbxEduction.ValueMember = nameof(ItemEntity.Id);
            this.cbxEduction.DataSource = education;

            this.dtBirthday.Value = DateTime.Now;

            var dicNature = this.GetEnumDictEx<UserNature>();
            var dicType = this.GetEnumDictEx<UserType>();

            this.cbxType.DisplayMember = "Value";
            this.cbxType.ValueMember = "Key";
            this.cbxType.DataSource = new BindingSource(dicType, null);

            this.cbxNature.DisplayMember = "Value";
            this.cbxNature.ValueMember = "Key";
            this.cbxNature.DataSource = new BindingSource(dicNature, null);

            this.cbxTitle.DisplayMember = nameof(TitleEntity.TitleName);
            this.cbxTitle.ValueMember = nameof(TitleEntity.TitleId);

            if (this.Operation == DataOperation.New)
            {
                this.lbContinuousInput.Show();
                this.swContinuousInput.Show();
            }

            this.AddTabOrderContainer(this.tbxCode);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.tbxPassword);
            this.AddTabOrderContainer(this.cbxType);
            this.AddTabOrderContainer(this.cbxTitle);
            this.AddTabOrderContainer(this.cbxNature);
            this.AddTabOrderContainer(this.cbxEduction);
            this.AddTabOrderContainer(this.cbxDefaultRole);
            this.AddTabOrderContainer(this.tbxIDCard);
            this.AddTabOrderContainer(this.dtBirthday);
            this.AddTabOrderContainer(this.tbxPhoneNumber);
            this.EnabledEnterNext = true;

            if (Operation == DataOperation.Modify)
                this.tbxCode.ReadOnly = true;
        }

        private void InitData()
        {
            if (this.SelectedUser == null)
                return;
            if (this.SelectedUser.Role != null)
                this.cbxDefaultRole.SelectedValue = this.SelectedUser.Role.Id;
            if (this.SelectedUser.Education != null)
                this.cbxEduction.SelectedValue = this.SelectedUser.Education.Key;
            this.cbxNature.SelectedValue = (int)this.SelectedUser.UserNature;
            this.cbxType.SelectedValue = (int)this.SelectedUser.UserType;
            this.tbxCode.Text = this.SelectedUser.Code;
            this.tbxName.Text = this.SelectedUser.Name;
            this.tbxIDCard.Text = this.SelectedUser.IDCard;
            this.tbxPhoneNumber.Text = this.SelectedUser.PhoneNumber;
            this.tbxPassword.Text = this.SelectedUser.Password;
            if (this.SelectedUser.Birthday == DateTime.MinValue)
                this.dtBirthday.Value = DateTime.Now;
            else
                this.dtBirthday.Value = this.SelectedUser.Birthday;

        }
        #endregion

        #region 窗体事件
        private void Item_Click(object sender, EventArgs e)
        {
            if (SelectedUser == null)
            {
                MsgBox.OK("请先生成人员信息");
                return;
            }

            var role = sender.As<ButtonItem>().Tag as RoleEntity;

            var result = _roleService.InsertUser(role.Id, SelectedUser.Id);
            if (result.Success)
            {
                UCUserRoleInfo uc = new UCUserRoleInfo();
                uc.Dock = DockStyle.Fill;
                var item = this.tabRole.CreateTab(role.Name);
                item.AttachedControl.Controls.Add(uc);
                uc.Init(_allDeptEntities, _allUserEntities, role, SelectedUser);
                this.menuRoleList.SubItems.Remove(sender as ButtonItem);
            }
            else
            {
                MsgBox.OK("添加角色失败:" + Environment.NewLine + result.Message);
            }
        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = this.cbxType.SelectedValue.AsInt(0);
            if (selectedValue == (int)UserType.Doctor)
                this.cbxTitle.DataSource = _titleEntities.Where(p => p.Scope == Scope.Doctor).ToList();
            else if (selectedValue == (int)UserType.Nurse)
                this.cbxTitle.DataSource = _titleEntities.Where(p => p.Scope == Scope.Nurse).ToList();
            else
                this.cbxTitle.DataSource = _titleEntities.Where(p => p.Scope == Scope.Other).ToList();
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            this.menuRoleList.Popup(MousePosition);
        }
        #endregion

        #region 方法
        private bool Valid()
        {
            if (this.tbxCode.Text == "")
            {
                MsgBox.OK("工号不能为空");
                return false;
            }
            if (this.tbxName.Text == "")
            {
                MsgBox.OK("工号不能为空");
                return false;
            }
            if (this.cbxType.SelectedItem == null)
            {
                MsgBox.OK("类型不能为空");
                return false;
            }

            return true;
        }

        private bool UpdateUser()
        {
            if (SelectedUser.Code != this.tbxCode.Text)
            {
                var exist = _userService.ExistCode(this.tbxCode.Text);
                if (exist)
                {
                    MsgBox.OK("当前工号已经被占用");
                    this.tbxCode.Text = SelectedUser.Code;
                    return false;
                }
            }

            List<IUserRoleInfo> roleInfos = new List<IUserRoleInfo>();
            foreach (var item in this.tabRole.Tabs)
            {
                if (item is SuperTabItem tabItem)
                    roleInfos.Add(tabItem.AttachedControl.Controls[0] as IUserRoleInfo);
            }


            Dictionary<RoleAdditionalEntity, List<DeptEntity>> dict = new Dictionary<RoleAdditionalEntity, List<DeptEntity>>();
            foreach (IUserRoleInfo item in roleInfos)
            {
                var additionInfo = item.GetRoleAddition();
                if (additionInfo == null)
                    continue;
                dict[additionInfo] = item.GetDepts();
            }

            DataResult result = null;
            if (this.UserInfoModified())
            {
                FillUserInfoByUI();
                result = _userService.UpdateUser(SelectedUser.Id, SelectedUser, dict);
            }
            else
                result = _userService.UpdateUser(SelectedUser.Id, null, dict);

            if (result.Success)
                AlertBox.Info("修改成功");
            else
            {
                MessageBox.Show("修改失败" + Environment.NewLine + result.Message);
                return false;
            }
            return true;
        }

        private bool InsertUser()
        {
            var exist = _userService.ExistCode(this.tbxCode.Text);
            if (exist)
            {
                MsgBox.OK("当前工号已经被占用");
                this.tbxCode.Text = "";
                return false;
            }

            List<IUserRoleInfo> roleInfos = new List<IUserRoleInfo>();
            foreach (var item in this.tabRole.Tabs)
            {
                if (item is SuperTabItem tabItem)
                    roleInfos.Add(tabItem.AttachedControl.Controls[0] as IUserRoleInfo);
            }
            SelectedUser = new UserEntity();
            FillUserInfoByUI();

            //Dictionary<RoleAdditionalEntity, List<DeptEntity>> dict = new Dictionary<RoleAdditionalEntity, List<DeptEntity>>();
            //foreach (IUserRoleInfo item in roleInfos)
            //{
            //    var additionInfo = item.GetRoleAddition(true);
            //    if (additionInfo == null)
            //        continue;
            //    dict[additionInfo] = item.GetDepts(true);
            //}

            var result = _userService.InsertUser(SelectedUser);
            if (result.Success)
            {
                AlertBox.Info("增加成功");
                NewUser?.Invoke(this, SelectedUser);
            }
            else
            {
                MessageBox.Show("增加成功" + Environment.NewLine + result.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 从界面数据填充用户信息
        /// </summary>
        private void FillUserInfoByUI()
        {
            SelectedUser.Name = this.tbxName.Text;
            SelectedUser.Code = this.tbxCode.Text;
            SelectedUser.UserType = (UserType)this.cbxType.SelectedValue.AsInt(0);
            SelectedUser.Title = this.cbxTitle.SelectedItem as TitleEntity;
            SelectedUser.UserNature = (UserNature)this.cbxNature.SelectedValue.AsInt(0);

            var education = this.cbxEduction.SelectedItem as ItemEntity;
            SelectedUser.Education = new LongItem(education.Id, education.Value, education.Code);
            SelectedUser.Role = this.cbxDefaultRole.SelectedItem as RoleEntity;
            SelectedUser.IDCard = this.tbxIDCard.Text;
            SelectedUser.Birthday = this.dtBirthday.Value;
            SelectedUser.PhoneNumber = this.tbxPhoneNumber.Text;
            SelectedUser.SearchCode = this.tbxName.Text.GetSpell();
            SelectedUser.Password = this.tbxPassword.Text.AsString("");
        }

        private bool UserInfoModified()
        {
            var modify = false;
            modify |= SelectedUser.Code != this.tbxCode.Text;
            modify |= SelectedUser.Name != this.tbxName.Text;
            modify |= SelectedUser.Password != this.tbxPassword.Text;
            modify |= SelectedUser.UserType.AsInt(0) != this.cbxType.SelectedValue.AsInt(0);
            modify |= SelectedUser.Title?.TitleId != this.cbxTitle.SelectedValue.AsLong(0);
            modify |= SelectedUser.UserNature.AsInt(0) != this.cbxNature.SelectedValue.AsInt(0);
            modify |= SelectedUser.Education?.Key != this.cbxEduction.SelectedValue.AsLong(0);
            modify |= SelectedUser.Role?.Id != this.cbxDefaultRole.SelectedValue.AsLong(0);
            modify |= SelectedUser.IDCard != this.tbxIDCard.Text;
            modify |= SelectedUser.Birthday != this.dtBirthday.Value;
            modify |= SelectedUser.PhoneNumber != this.tbxPhoneNumber.Text;

            return modify;
        }
        #endregion

        private void FormUserEdit_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);

            _titleEntities = _titleService.GetAll();
            InitUI();
            InitData();
            InitRole();

            HIS.DSkinControl.QLoading.Close(this);
        }

        protected override void OnOK()
        {
            if (!Valid())
                return;

            bool result = false;
            if (Operation == DataOperation.Modify)
                result = UpdateUser();
            else
                result = InsertUser();

            if (result)
            {
                if (Operation == DataOperation.New && this.swContinuousInput.Value)
                    return;
                base.OnOK();
            }
        }
    }
}
