using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using System;

namespace App_Sys.RoleManager
{
    public partial class FormAddRole : BaseDialogForm
    {
        private readonly IRoleService _roleService;

        public FormAddRole(IRoleService roleService)
        {
            InitializeComponent();
            this._roleService = roleService;
        }

        protected override void OnOK()
        {
            var result = _roleService.Insert(this.tbxCode.Text, this.tbxName.Text, this.tbxDescription.Text, this.intLevel.Value.AsInt(1));
            if (result.Success)
                AlertBox.Info("保存成功");
            else
            {
                MsgBox.OK("保存失败，请重试:" + Environment.NewLine + result.Message);
                return;
            }

            base.OnOK();
        }

        private void FormAddRole_Load(object sender, EventArgs e)
        {
            this.intLevel.Minimum = App.Instance.User.Role.Level;
        }
    }
}
