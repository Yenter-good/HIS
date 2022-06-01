using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Sys.User;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.SuperGrid;
using HIS.ControlLib.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;

namespace App_Sys.UserManager
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2020-08-10 15:30:03
    /// 描述:
    /// </summary>
    public partial class FormUserManager : BaseForm
    {
        private readonly IDeptService _deptService;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public FormUserManager(IDeptService deptService, IUserService userService, IRoleService roleService)
        {
            InitializeComponent();
            this._deptService = deptService;
            this._userService = userService;
            this._roleService = roleService;
        }

        #region 初始化
        private void InitUser()
        {
            this.dgvUser.PrimaryGrid.Rows.Clear();

            var users = _userService.GetAllWithRole();
            var userDistinct = users.Select(p => new UserEntity
            {
                Code = p.Code,
                Name = p.Name,
                Password = p.Password,
                Id = p.Id,
                UserType = p.UserType,
                UserNature = p.UserNature,
                Education = p.Education,
                Role = p.Role,
                Status = p.Status
            }).Distinct().ToList();

            foreach (var user in userDistinct)
            {
                var newRow = this.dgvUser.PrimaryGrid.NewRow();
                newRow.Cells[colCode.ColumnIndex].Value = user.Code;
                newRow.Cells[colName.ColumnIndex].Value = user.Name;
                newRow.Cells[colType.ColumnIndex].Value = user.UserType.GetDescription();
                newRow.Cells[colPassword.ColumnIndex].Value = "****";
                newRow.Cells[colPassword.ColumnIndex].Tag = user.Password;
                newRow.Cells[colNature.ColumnIndex].Value = user.UserNature.GetDescription();
                newRow.Cells[colEducation.ColumnIndex].Value = user.Education == null ? "" : user.Education.Value;
                newRow.Cells[colDefaultRole.ColumnIndex].Value = user.Role == null ? "" : user.Role.Name;
                newRow.Cells[colStatus.ColumnIndex].Value = user.Status.GetDescription();
                newRow.Cells[colRoles.ColumnIndex].EditorType = typeof(GridLinkButtonEditControl);
                newRow.Cells[colRoles.ColumnIndex].Value = "点击获取";
                newRow.Tag = user;
                this.dgvUser.PrimaryGrid.Rows.Add(newRow);

                var button = newRow.Cells[colRoles.ColumnIndex].EditControl as GridLinkButtonEditControl;
                button.LinkClicked -= Button_LinkClicked;
                button.LinkClicked += Button_LinkClicked;

                if (!this.swShowDisable.Value && user.Status == DataStatus.Disable)
                    newRow.Visible = false;
            }
        }

        private void Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedRows = this.dgvUser.PrimaryGrid.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;

            var selectedRow = selectedRows[0] as GridRow;
            var userEntity = selectedRow.Tag as UserEntity;

            List<RoleEntity> roles = _roleService.GetByUser(userEntity.Id);
            selectedRow.Cells[colRoles.ColumnIndex].EditorType = typeof(GridTextBoxXEditControl);
            this.dgvUser.Invalidate();

            selectedRow.Cells[colRoles.ColumnIndex].Value = string.Join(",", roles.Select(p => p.Name).ToList());
        }

        private void InitRole()
        {

        }
        #endregion

        private void FormUserManager_Shown(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);

            InitUser();

            HIS.DSkinControl.QLoading.Close(this);
        }

        #region 窗体事件
        private void dgvUser_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            e.GridCell.GridRow.Cells[colPassword.ColumnIndex].Value = "****";
            Application.DoEvents();
            var selectedUser = e.GridCell.GridRow.Tag as UserEntity;
            FormUserEdit form = App.Instance.CreateView<FormUserEdit>();
            form.Operation = DataOperation.Modify;
            form.SelectedUser = selectedUser;
            if (form.ShowDialog() == DialogResult.OK)
                UpdateUser(selectedUser, e.GridCell.GridRow);
        }
        private void dgvUser_CellMouseUp(object sender, DevComponents.DotNetBar.SuperGrid.GridCellMouseEventArgs e)
        {
            if (e.GridCell.ColumnIndex == this.colPassword.ColumnIndex)
            {
                e.GridCell.Value = "****";
            }
        }
        private void dgvUser_CellMouseDown(object sender, DevComponents.DotNetBar.SuperGrid.GridCellMouseEventArgs e)
        {
            if (e.GridCell.ColumnIndex == this.colPassword.ColumnIndex)
            {
                e.GridCell.Value = e.GridCell.Tag.AsString("");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HIS.DSkinControl.QLoading.Show(this);
            InitUser();
            HIS.DSkinControl.QLoading.Close(this);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUser.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;
            var selectedRow = selectedRows[0] as GridRow;

            var selectedUser = selectedRow.Tag as UserEntity;
            FormUserEdit form = App.Instance.CreateView<FormUserEdit>();
            form.Operation = DataOperation.Modify;
            form.SelectedUser = selectedUser;
            if (form.ShowDialog() == DialogResult.OK)
                UpdateUser(selectedUser, selectedRow);
        }
        private void btnRestop_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUser.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;
            var selectedRow = selectedRows[0] as GridRow;

            var selectedUser = selectedRow.Tag as UserEntity;
            if (selectedUser.Status == DataStatus.Disable)
            {
                var result = _userService.EnableUser(selectedUser.Id);
                if (result.Success)
                {
                    selectedUser.Status = DataStatus.Enable;
                    selectedRow.CellStyles.Default.TextColor = Color.Black;
                    selectedRow.Cells[colStatus.ColumnIndex].Value = DataStatus.Enable.GetDescription();
                    AlertBox.Info("启用成功");
                }
                else
                    MsgBox.OK("启用失败" + Environment.NewLine + result.Message);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dgvUser.GetSelectedRows();
            if (selectedRows.Count == 0)
                return;
            var selectedRow = selectedRows[0] as GridRow;

            var selectedUser = selectedRow.Tag as UserEntity;
            if (selectedUser.Status == DataStatus.Enable)
            {
                var result = _userService.DisableUser(selectedUser.Id);
                if (result.Success)
                {
                    selectedUser.Status = DataStatus.Disable;
                    selectedRow.CellStyles.Default.TextColor = Color.Red;
                    selectedRow.Cells[colStatus.ColumnIndex].Value = DataStatus.Disable.GetDescription();
                    if (!swShowDisable.Value)
                        selectedRow.Visible = false;
                    AlertBox.Info("停用成功");
                }
                else
                    MsgBox.OK("停用失败" + Environment.NewLine + result.Message);
            }
        }
        private void swShowDisable_ValueChanged(object sender, EventArgs e)
        {
            RefreshDGV();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormUserEdit form = App.Instance.CreateView<FormUserEdit>();
            form.Operation = DataOperation.New;
            form.NewUser += Form_NewUser;
            form.ShowDialog();
        }

        private void Form_NewUser(object sender, UserEntity e)
        {
            var newRow = this.dgvUser.PrimaryGrid.NewRow();
            newRow.Cells[colCode.ColumnIndex].Value = e.Code;
            newRow.Cells[colName.ColumnIndex].Value = e.Name;
            newRow.Cells[colType.ColumnIndex].Value = e.UserType.GetDescription();
            newRow.Cells[colPassword.ColumnIndex].Value = "****";
            newRow.Cells[colPassword.ColumnIndex].Tag = e.Password;
            newRow.Cells[colNature.ColumnIndex].Value = e.UserNature.GetDescription();
            newRow.Cells[colEducation.ColumnIndex].Value = e.Education == null ? "" : e.Education.Value;
            newRow.Cells[colDefaultRole.ColumnIndex].Value = e.Role == null ? "" : e.Role.Name;
            newRow.Cells[colStatus.ColumnIndex].Value = e.Status.GetDescription();
            newRow.Cells[colRoles.ColumnIndex].EditorType = typeof(GridLinkButtonEditControl);
            newRow.Cells[colRoles.ColumnIndex].Value = "点击获取";
            newRow.Tag = e;
            this.dgvUser.PrimaryGrid.Rows.Insert(0, newRow);

            var button = newRow.Cells[colRoles.ColumnIndex].EditControl as GridLinkButtonEditControl;
            button.LinkClicked -= Button_LinkClicked;
            button.LinkClicked += Button_LinkClicked;
        }
        #endregion

        #region 方法
        private void RefreshDGV()
        {
            if (this.swShowDisable.Value)
            {
                foreach (GridRow row in this.dgvUser.PrimaryGrid.Rows)
                    row.Visible = true;
            }
            else
            {
                var disableText = DataStatus.Disable.GetDescription();
                foreach (GridRow row in this.dgvUser.PrimaryGrid.Rows)
                {
                    if (row.Cells[colStatus.ColumnIndex].Value.ToString() == disableText)
                        row.Visible = false;
                }
            }
        }

        private void UpdateUser(UserEntity user, GridRow row)
        {
            row.Cells[colCode.ColumnIndex].Value = user.Code;
            row.Cells[colName.ColumnIndex].Value = user.Name;
            row.Cells[colType.ColumnIndex].Value = user.UserType.GetDescription();
            row.Cells[colPassword.ColumnIndex].Tag = user.Password;
            row.Cells[colNature.ColumnIndex].Value = user.UserNature.GetDescription();
            row.Cells[colEducation.ColumnIndex].Value = user.Education == null ? "" : user.Education.Value;
            row.Cells[colDefaultRole.ColumnIndex].Value = user.Role == null ? "" : user.Role.Name;
        }
        #endregion


    }
}
