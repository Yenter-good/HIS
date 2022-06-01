using HIS.ControlLib.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core;
using HIS.Utility;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-29 10:41:27
/// 功能:
/// </summary>
namespace HIS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        private void InitUI()
        {
            this.btnLogin.Enter += (s, a) =>
            {
                this.btnLogin.BackgroundImage = Properties.Resources.按钮点击;
            };
            this.btnLogin.Leave += (s, a) =>
            {
                this.btnLogin.BackgroundImage = Properties.Resources.按钮普通;
            };
            this.btnLogin.MouseDown += (s, a) =>
            {
                this.btnLogin.BackgroundImage = Properties.Resources.按钮点击;
            };
            this.btnLogin.MouseUp += (s, a) =>
            {
                this.btnLogin.BackgroundImage = Properties.Resources.按钮普通;
            };
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            InitUI();
        }
        private void LoginWorkStation()
        {
            string gh = this.tbxGh.Text.Trim();
            string pwd = this.tbxPwd.Text.Trim();
            if (string.IsNullOrWhiteSpace(gh))
            {
                this.lblMsg.Text = "系统消息：请输入工号！";
                this.tbxGh.Focus();
                return;
            }
            try
            {
                var rs = HIS.Core.App.Instance.Validation(gh, pwd);
                if (!rs.Success)
                {
                    this.lblMsg.Text = $"系统消息：{rs.Message}";
                    return;
                }
                else
                {
                    var roles = ServiceLocator.GetService<IRoleService>().GetByUser(rs.Value.Id);
                    if (roles.Count == 0)
                    {
                        this.lblMsg.Text = "当前工号没有任何角色匹配";
                        return;
                    }
                    DataResult loginResult;

                    if (roles.Count == 1)
                    {
                        loginResult = App.Instance.Login(rs.Value, roles[0]);

                    }
                    else
                    {
                        FormSelectRole form = new FormSelectRole();
                        form.Roles = roles;
                        if (form.ShowDialog(this) == DialogResult.OK)
                        {
                            loginResult = App.Instance.Login(rs.Value, form.Role);
                        }
                        else
                            return;
                    }
                    if (!loginResult.Success)
                    {
                        this.lblMsg.Text = loginResult.Message;
                        return;
                    }

                    var datetime = ServiceLocator.GetService<ITimeService>().ServiceTime();
                    if (datetime.TimeOfDay < App.Instance.User.RoleAddition.AllowStartTime.TimeOfDay || datetime.TimeOfDay > App.Instance.User.RoleAddition.AllowEndTime.TimeOfDay)
                    {
                        this.lblMsg.Text = $"您所处的角色无法在当前时间登录" + Environment.NewLine +
                                           $"允许登录的时间为:{App.Instance.User.RoleAddition.AllowStartTime.ToShortTimeString()}~{App.Instance.User.RoleAddition.AllowEndTime.ToShortTimeString()}";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                this.lblMsg.Text = $"系统消息：{ex.Message}";
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginWorkStation();
        }

        private void tbxGh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == this.tbxGh)
                    this.tbxPwd.Focus();
                else
                    LoginWorkStation();
            }
        }
    }
}
