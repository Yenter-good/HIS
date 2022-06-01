using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Service.Core.Entities;

namespace App_OP.PatientInfo
{
    internal partial class UCPatientList : UCBasePatientList
    {
        internal UCPatientList()
        {
            InitializeComponent();
        }

        internal override GridRow CreateRow(OutpatientEntity outpatient)
        {
            GridRow gr = base.CreateRow(outpatient);
            gr.Cells[this.colFirstAcceptDoctorName.ColumnIndex].Value = outpatient.FirstAcceptDoctor?.Name;

            return gr;
        }
    }
}
