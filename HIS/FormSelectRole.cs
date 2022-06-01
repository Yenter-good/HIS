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

namespace HIS
{
    public partial class FormSelectRole : BaseDialogForm
    {
        private List<RolePanel> _rolePanelList = new List<RolePanel>();

        public FormSelectRole()
        {
            InitializeComponent();
        }

        public RoleEntity Role { get; set; }
        public List<RoleEntity> Roles { get; set; }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            _rolePanelList.ForEach(p => p.IsSelected = false);
            sender.As<RolePanel>().IsSelected = true;
        }

        protected override void OnOK()
        {
            var selected = _rolePanelList.Find(p => p.IsSelected);
            if (selected == null)
                Role = null;
            else
                Role = selected.Tag as RoleEntity;

            base.OnOK();
        }

        private void FormSelectRole_Shown(object sender, EventArgs e)
        {
            this.pnlRoleList.Left = this.Width / 2 - this.pnlRoleList.Width / 2;
            this.pnlRoleList.Top = (this.Height - 36) / 2 - this.pnlRoleList.Height / 2;

            _rolePanelList[0].IsSelected = true;
        }

        private void FormSelectRole_Load(object sender, EventArgs e)
        {
            int left = 0;
            int top = 0;
            for (int i = 1; i <= Roles.Count; i++)
            {
                RolePanel panel = new RolePanel();
                panel.MouseClick += Panel_MouseClick;
                panel.Text = Roles[i - 1].Name;
                panel.Tag = Roles[i - 1];
                this.pnlRoleList.Controls.Add(panel);
                panel.ResetLocation();
                panel.Left = left;
                panel.Top = top;
                left = (i % 3 == 0 ? 0 : left + panel.Width + 40);
                top += (i % 3 == 0 ? panel.Height + 5 : 0);
                _rolePanelList.Add(panel);
            }
        }
    }
}
