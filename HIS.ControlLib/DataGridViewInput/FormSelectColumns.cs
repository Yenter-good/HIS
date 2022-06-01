using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public partial class FormSelectColumns : DevComponents.DotNetBar.Office2007Form
    {
        public FormSelectColumns()
        {
            InitializeComponent();
        }
        public DataGridViewColumnCollection Columns { private get; set; }
        public DataGridViewColumn SelectedColumn
        {
            get
            {
                var selectedRows = this.dgvColumns.PrimaryGrid.GetSelectedRows();
                if (selectedRows.Count == 0)
                    return null;
                return selectedRows[0].As<GridRow>().Tag as DataGridViewColumn;
            }
        }

        private void FormSelectColumns_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in Columns)
            {
                var newRow = this.dgvColumns.PrimaryGrid.NewRow();
                newRow.Cells[colName.ColumnIndex].Value = column.Name;
                newRow.Cells[colHeadText.ColumnIndex].Value = column.HeaderText;
                newRow.Tag = column;

                this.dgvColumns.PrimaryGrid.Rows.Add(newRow);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
