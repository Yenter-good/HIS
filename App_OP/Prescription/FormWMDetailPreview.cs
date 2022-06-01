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
    public partial class FormWMDetailPreview : Form
    {
        public FormWMDetailPreview()
        {
            InitializeComponent();
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom | DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right;
        }

        public void Init(List<PrescriptionDetailEntity> details)
        {
            this.dgvPreview.Rows.Clear();

            this.dgvPreview.GroupDisplayColumn = this.colGroupDisplay;
            this.dgvPreview.GroupValueColumn = this.colGroupValue;

            foreach (var detail in details)
            {
                var newRow = this.dgvPreview.Rows[this.dgvPreview.Rows.Add()];

                newRow.Cells[colName.Index].Value = detail.ItemName;
                newRow.Cells[colSpecification.Index].Value = detail.Specification;
                newRow.Cells[colDose.Index].Value = detail.Dose + detail.DoseUnit;
                newRow.Cells[colUsage.Index].Value = detail.Usage.Name;
                newRow.Cells[colInterval.Index].Value = detail.Interval.Name;
                newRow.Cells[colDay.Index].Value = detail.Day + "天";
                newRow.Cells[colQuantity.Index].Value = detail.Quantity + detail.PackageUnit;
                newRow.Cells[colGroupValue.Index].Value = detail.GroupNo;
            }

            this.dgvPreview.DrawGroupLine();
            this.panelEx2.Text = "总额:" + details.Sum(p => p.Total).ToString("0.0000元");
        }
    }
}
