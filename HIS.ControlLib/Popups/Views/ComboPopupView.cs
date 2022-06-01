using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using HIS.Utility;

namespace HIS.ControlLib.Popups
{
    [ToolboxItem(false)]
    public partial class ComboPopupView : UserControl,IPopupFilterView
    {
        /// <summary>
        /// 通过过滤词获取数据源
        /// </summary>
        public Func<string, object> GetDataSource;
        /// <summary>
        /// 获取或设置过滤的方法
        /// </summary>
        public Func<string,object,object> FilterMethod;
        private object dataSource = null;
        private bool _AutoSizeToDisplay = true;
        public bool Adaptive
        {
            get { return _AutoSizeToDisplay; }
            set { _AutoSizeToDisplay = value; }
        }
        public bool DoubleClickedToSelect
        {
            get;
            set;
        }
        /// <summary>
        /// 获取或设置数据源
        /// </summary>
        public object DataSource
        {
            get { return dataSource; }
            set
            {
                dataSource = value;
                this.dgvView.DataSource = value;
            }
        }

        /// <summary>
        /// 显示的成员字段
        /// </summary>
        public string DisplayMember
        { 
            get { return colDisplayText.DataPropertyName; }
            set { colDisplayText.DataPropertyName = value; }
        }
        /// <summary>
        /// 值的成员字段
        /// </summary>
        public string ValueMember
        {
            get;
            set;
        }
        /// <summary>
        /// 过滤字段
        /// </summary>
        public string[] FilterFields
        {
            get;
            set;
        }

        public Control View
        {
            get { return this.dgvView; }
        }

        public string SelectedText
        {
            get
            {
                var item = this.SelectedItem;
                if (item == null) return null;
                if (string.IsNullOrEmpty(DisplayMember))
                    return null;
                return DataBinder.GetStringValue(item, this.DisplayMember);
            }
        }

        public object SelectedValue
        {
            get
            {
                var item = this.SelectedItem;
                if (item == null) return null;
                if (string.IsNullOrEmpty(ValueMember) )
                    return null;
                return DataBinder.GetValue(item, this.ValueMember);
            }
        }

        public object SelectedItem
        {
            get
            {
                if (this.dgvView.SelectedRows.Count > 0)
                    return this.dgvView.SelectedRows[0].DataBoundItem ;
                return null;
            }
        }

        public event EventHandler ItemSelected;

        public int Filter(string filteText)
        {
            if (this.GetDataSource != null)
            {
                this.DataSource = this.GetDataSource(filteText);
                return this.dgvView.RowCount;
            }
            if (dataSource == null && this.dgvView.DataSource != null)
            {
                this.dgvView.DataSource = dataSource;
                return 0;
            }
            if (this.FilterMethod != null)
            {
                this.dgvView.DataSource = this.FilterMethod(filteText, dataSource);
                return this.dgvView.RowCount;
            }
            this.dgvView.DataSource = DataBinder.Filter(dataSource,this.FilterFields,filteText);
            return this.dgvView.RowCount;

        }
        public Size CalcItemsSize()
        {
           int height = this.dgvView.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
           height += this.dgvView.ColumnHeadersHeight;
           return new System.Drawing.Size(this.Width, height);
        }
        public ComboPopupView()
        {
            InitializeComponent();
            this.dgvView.AutoGenerateColumns = false;
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DoubleClickedToSelect)
            {
                if (e.RowIndex < 0) return;
                if (ItemSelected != null)
                {
                    ItemSelected(this, EventArgs.Empty);
                }
            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.DoubleClickedToSelect)
            {
                if (e.RowIndex < 0) return;
                if (ItemSelected != null)
                {
                    ItemSelected(this, EventArgs.Empty);
                }
            }
        }

        private void dgvView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ItemSelected != null)
                {
                    ItemSelected(this, EventArgs.Empty);
                }
            }
        }



    }
}
