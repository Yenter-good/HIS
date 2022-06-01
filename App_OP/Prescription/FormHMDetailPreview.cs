using HIS.Core.UI;
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

namespace App_OP.Prescription
{
    public partial class FormHMDetailPreview : Form
    {
        public FormHMDetailPreview()
        {
            InitializeComponent();
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom | DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right;
        }

        public void Init(PrescriptionEntity prescription, List<PrescriptionDetailEntity> details)
        {
            this.lvDrug.Items.Clear();

            foreach (var detail in details)
            {
                var item = new ListViewItem();
                this.lvDrug.Items.Add(item);

                item.Text = detail.ItemName + " " + detail.Dose + detail.DoseUnit;
                if (prescription.HerbalMedicineUsage.Code != detail.Usage.Code)
                    item.Text += " " + detail.Usage.Name;

            }
            this.panelEx2.Text = "总额:" + details.Sum(p => p.Total).ToString("0.0000元");
        }
    }
}
