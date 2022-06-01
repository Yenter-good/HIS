using HIS.Core.UI;
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

namespace App_Sys.Advice
{
    public partial class FormAdviceManager : BaseForm
    {
        public FormAdviceManager()
        {
            InitializeComponent();
        }


        private void FormAdviceManager_Shown(object sender, EventArgs e)
        {
            //加载检查医嘱页面
            FormExaminationManager frm1 = App.Instance.CreateView<FormExaminationManager>();

            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.Visible = true;
            frm1.FormBorderStyle = FormBorderStyle.None;
            superTabItem1.AttachedControl.Controls.Add(frm1);


            //加载检验医嘱页面
            FormInspectionManager frm2 = App.Instance.CreateView<FormInspectionManager>();

            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Visible = true;
            frm2.FormBorderStyle = FormBorderStyle.None;
            superTabItem2.AttachedControl.Controls.Add(frm2);
        }
    }
}
