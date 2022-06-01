using ConfigurationTool.Untility;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationTool
{
    public partial class FormAddParameter : Form
    {
        public string Name { get; set; }

        public string Value { get; set; }
        public FormAddParameter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Name = txtName.Text.Trim();
            Value = txtValue.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void FormAddParameter_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtValue.Text = Value;
        }

        private void btnJieMi_Click(object sender, EventArgs e)
        {
            txtValue.Text = ConfigurationTool.Untility.NetCryptoHelper.DecryptDes(txtValue.Text.Trim(), NetCryptoHelper.DesKey, NetCryptoHelper.DesIv);
            btnJieMi.Enabled = false;
            btnJiaMi.Enabled = true;
        }

        private void btnJiaMi_Click(object sender, EventArgs e)
        {
            txtValue.Text = ConfigurationTool.Untility.NetCryptoHelper.EncryptDes(txtValue.Text.Trim(), NetCryptoHelper.DesKey, NetCryptoHelper.DesIv);
            btnJiaMi.Enabled = false;
            btnJieMi.Enabled = true;

        }
    }
}
