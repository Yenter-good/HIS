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

namespace App_Sys.Drug
{
    /// <summary>
    /// 药品调价管理
    /// </summary>
    public partial class FormPriceChangedReceipt : BaseForm
    {
        public FormPriceChangedReceipt()
        {
            InitializeComponent();
        }

        protected override void OnDeptChanged()
        {
            this.ucPriceChangedReceipt.ViewData = base.ViewData;
            this.ucPriceChangedReceipt.Init();
            base.OnDeptChanged();
        }

        private void FormPriceChangedReceipt_Shown(object sender, EventArgs e)
        {
            this.ucPriceChangedReceipt.ViewData = base.ViewData;
            this.ucPriceChangedReceipt.Init();
        }
    }
}
