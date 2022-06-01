using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.ItemGroup
{
    public partial class FormAddGroup : BaseDialogForm
    {
        public FormAddGroup(IOPGroupService groupService)
        {
            InitializeComponent();
            _groupService = groupService;
        }
        private IOPGroupService _groupService;


        public string status = "add";//状态 编辑或新增
        public long parentID = 0;//父节点ID
        public int type = 1;//1科室 2个人

        public long deptId;
        public long userId;


        public PrescriptionGroupEntity group = new PrescriptionGroupEntity();

        private void SetValue()
        {
            rdo1.Checked = group.GroupType == 1 || type == 1;
            rdo2.Checked = group.GroupType == 2 || type == 2;
            tbxName.Text = group.Name;
            tbxNo.Text = group.No.ToString();
        }

        private void GetValue()
        {
            group.Name = tbxName.Text.Trim();
            if (rdo1.Checked)
            {
                group.GroupType = 1;
                group.OwnerId = deptId;
            }
            if (rdo2.Checked)
            {
                group.GroupType = 2;
                group.OwnerId = userId;
            }
            group.No = Convert.ToInt32(tbxNo.Value);
            if (status == "add")
            {
                group.ParentId = parentID;
            }
        }

        private void FormAddGroup_Shown(object sender, EventArgs e)
        {
            if (status == "add")
            {
                rdo1.Checked = type == 1;
                rdo2.Checked = type == 2;
            }
            else
            {
                SetValue();
            }
        }
        protected override void OnOK()
        {
            if (!Validing()) return;
            DataResult<PrescriptionGroupEntity> result = null;
            GetValue();

            if (status == "add")
            {
                result = _groupService.AddGroup(group);
            }
            else
            {
                result = _groupService.UpdateGroup(group.Id,group);
            }

            if (result.Success)
            {
                AlertBox.Info("保存成功");
                this.Close();
            }
            else
            {
                AlertBox.Error(result.Message);
            }
        }
        private bool Validing()
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text))
            {
                tbxName.Focus();
                AlertBox.Error("分类名称不可以为空");
                return false;
            }
            return true;
        }
    }
}
