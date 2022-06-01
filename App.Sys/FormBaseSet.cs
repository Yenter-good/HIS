using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using HIS.Core.UI;

namespace App_Sys
{
    public partial class FormBaseSet : BaseForm
    {
        public FormBaseSet()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.SetToolBarBtiEnable();
            this.LoadData();

        }
        private void Grid_SelectionChanged(object sender, GridEventArgs e)
        {
            this.SetToolBarBtiEnable();
        }

        public GridRow CurrentSelectedRow
        {
            get
            {
                switch (this.grid.PrimaryGrid.SelectionGranularity)
                {
                    case SelectionGranularity.Cell:
                        if (this.grid.PrimaryGrid.SelectedCellCount > 0)
                        {
                            var cells = this.grid.PrimaryGrid.GetSelectedCells();
                            if (cells.Count > 0)
                                return (cells[0] as GridCell).GridRow;
                        }
                        break;
                    case SelectionGranularity.Row:
                    case SelectionGranularity.RowWithCellHighlight:
                        if (this.grid.PrimaryGrid.SelectedRowCount > 0)
                        {
                            return this.grid.PrimaryGrid.GetSelectedRows()[0] as GridRow;
                        }
                        break;
                }

                return null;
            }
        }
        public List<GridRow> CurrentSelectedRows
        {
            get
            {
                switch (this.grid.PrimaryGrid.SelectionGranularity)
                {
                    case SelectionGranularity.Cell:
                        if (this.grid.PrimaryGrid.SelectedCellCount > 0)
                        {
                            var cells = this.grid.PrimaryGrid.GetSelectedCells();
                            if (cells.Count > 0)
                                return cells.Cast<GridCell>().Select(d => d.GridRow).Distinct().ToList();
                        }
                        break;
                    case SelectionGranularity.Row:
                    case SelectionGranularity.RowWithCellHighlight:
                        if (this.grid.PrimaryGrid.SelectedRowCount > 0)
                        {
                            return this.grid.PrimaryGrid.GetSelectedRows().Cast<GridRow>().ToList();
                        }
                        break;
                }
                return null;
            }
        }
        private void btiRightMenu_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            var rowCount = this.grid.PrimaryGrid.Rows.Count;
            if (rowCount == 0)
            {
                e.Cancel = true;
            }
            else
            {
                var row = this.CurrentSelectedRow;

                this.btiM_Edit.Enabled = row != null;
                this.btiM_Remover.Enabled = row != null;
            }
        }
        private void btiReflesh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btiAdd_Click(object sender, EventArgs e)
        {
            this.AddData();
        }

        private void btiEdit_Click(object sender, EventArgs e)
        {
            this.EditData();
        }

        private void btiRemover_Click(object sender, EventArgs e)
        {
            this.RemoverData();
        }

        private void btiRemoverAll_Click(object sender, EventArgs e)
        {
            this.RemoverAllData();
        }
        public virtual T GetCurrentSelectedRowBindItem<T>() where T : class
        {
            T t = default(T);

            if (this.CurrentSelectedRow != null)
            {
                t = this.CurrentSelectedRow.DataItem as T;
            }

            return t;
        }
        public virtual T GetCurrentSelectedRowBindTag<T>() where T : class
        {
            T t = default(T);

            if (this.CurrentSelectedRow != null)
            {
                t = this.CurrentSelectedRow.Tag as T;
            }

            return t;
        }
        public virtual List<T> GetCurrentSelectedRowsBindItems<T>() where T : class
        {
            List<T> tList = new List<T>();

            foreach (var row in this.grid.PrimaryGrid.GetSelectedRows())
            {
                T t = (row as GridRow).DataItem as T;

                tList.Add(t);
            }

            return tList;
        }
        public virtual List<T> GetCurrentSelectedRowsBindTags<T>() where T : class
        {
            List<T> tList = new List<T>();

            foreach (var row in this.grid.PrimaryGrid.GetSelectedRows())
            {
                T t = (row as GridRow).Tag as T;

                tList.Add(t);
            }

            return tList;
        }
        public virtual void SetToolBarBtiEnable()
        {
            var row = this.CurrentSelectedRow;

            this.btiEdit.Enabled = row != null;
            this.btiRemover.Enabled = row != null;
            this.bar1.Refresh();
        }

        public virtual void LoadData()
        {

        }
        public virtual void AddData()
        {

        }
        public virtual void EditData()
        {

        }
        public virtual void RemoverData()
        {

        }
        public virtual void RemoverAllData()
        {

        }

        public void ClearDeletedRows()
        {
            var rows = this.CurrentSelectedRows;
            if (rows != null && rows.Count > 0)
            {
                foreach (var row in rows)
                    row.IsDeleted = true;

                this.grid.PrimaryGrid.PurgeDeletedRows(true);
            }
        }

        private void grid_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            if (e.RowArea == RowArea.InContent)
                this.EditData();
        }
    }
}
