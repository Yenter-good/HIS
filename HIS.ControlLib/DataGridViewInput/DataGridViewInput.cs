using DevComponents.DotNetBar.Controls;
using HIS.ControlLib.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-01-14 09:41:28
    /// 描述:
    /// </summary>
    public class DataGridViewInput : DataGridViewExt
    {
        private Popups.PopupControlHost _innerHost;
        private Container container = new Container();

        private Action<string> _filterCondition;
        private Action<string> _initEditCondition;

        public DataGridViewInput()
        {
            base.Hide();
            base.BackgroundColor = Color.White;
            Container.ValueChanged += _container_ValueChanged;
        }

        private void _container_ValueChanged(object sender, EventArgs e)
        {
            if (Container.Host != null && Container.BindColumn.Column != null)
            {
                Container.Host.CellBeginEdit -= Host_CellBeginEdit;
                Container.Host.CellBeginEdit += Host_CellBeginEdit;
                Container.Host.CellEndEdit -= Host_CellEndEdit;
                Container.Host.CellEndEdit += Host_CellEndEdit;
                Container.Host.CellMouseClick -= Host_CellMouseClick;
                Container.Host.CellMouseClick += Host_CellMouseClick;
                Container.Host.TextChangeDelay -= Host_TextChange;
                Container.Host.TextChangeDelay += Host_TextChange;
                Container.Host.InitEditControl -= Host_InitEditControl;
                Container.Host.InitEditControl += Host_InitEditControl;
            }
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new Container Container
        {
            get => container; set
            {
                container = value;
                _container_ValueChanged(this, EventArgs.Empty);
            }
        }

        public void SetFilterCondition(Action<string> action)
        {
            _filterCondition = action;
        }
        public void SetInitEditCondition(Action<string> action)
        {
            _initEditCondition = action;
        }

        private void Host_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this._innerHost != null)
            {
                if (e.ColumnIndex == Container.BindColumn.Column.Index && this.Rows.Count > 0)
                {
                    this.Show(Container.Host.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                }
            }
        }
        private void Host_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Container.BindColumn.Column.Index && this._innerHost != null)
                this.Close();
        }
        private void Host_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this._innerHost != null)
            {
                if (e.ColumnIndex == Container.BindColumn.Column.Index && !this._innerHost.Visible && this.Rows.Count > 0)
                {
                    this.Show(Container.Host.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                }
            }
        }
        private void Host_TextChange(object sender, TextChangeEventArgs e)
        {
            if (e.ColumnIndex == Container.BindColumn.Column.Index)
            {
                if (_filterCondition != null)
                    _filterCondition(e.Text);
                if (this.Rows.Count > 0)
                    this.Show(Container.Host.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                else
                    this.Close();
            }
        }
        private void Host_InitEditControl(object sender, TextChangeEventArgs e)
        {
            if (e.ColumnIndex == Container.BindColumn.Column.Index)
            {
                if (_initEditCondition != null)
                {
                    _initEditCondition(e.Text);
                    if (this.Rows.Count > 0)
                        this.Show(Container.Host.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    else
                        this.Close();
                }
            }
        }

        /// <summary>
        /// 获取是否显示
        /// </summary>
        public bool PopupVisible { get => this._innerHost == null ? false : this._innerHost.Visible; }

        public void Show(Control control)
        {
            base.Visible = true;
            this.BorderStyle = BorderStyle.None;

            if (this._innerHost == null)
            {
                this._innerHost = new PopupControlHost(this);
                this._innerHost.AutoClose = true;
            }

            this._innerHost.AttachInputRect = new Rectangle(control.Parent.PointToScreen(control.Location), control.Size);
            this._innerHost.Show(control);
        }

        public void Show(DataGridViewCell cell)
        {
            base.Visible = true;
            this.BorderStyle = BorderStyle.None;

            if (this._innerHost == null)
            {
                var columnStyle = this.ColumnHeadersDefaultCellStyle.Clone();
                var cellStyle = this.DefaultCellStyle.Clone();

                this._innerHost = new PopupControlHost(this);
                this._innerHost.AutoClose = true;

                this.ColumnHeadersDefaultCellStyle = columnStyle;
                this.DefaultCellStyle = cellStyle;
            }

            Rectangle rect = cell.DataGridView.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
            var point = cell.DataGridView.PointToScreen(rect.Location);

            this._innerHost.AttachInputRect = new Rectangle(point, rect.Size);

            if (point.Y + rect.Height + this.Height >= Screen.PrimaryScreen.WorkingArea.Height)
                this._innerHost.Show(new Point(point.X, point.Y - this.Height));
            else
                this._innerHost.Show(new Point(point.X, point.Y + rect.Height));
        }
        public void Close()
        {
            if (this._innerHost == null)
                return;
            this.Rows.Clear();
            this._innerHost.Close();
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Container
    {
        public Container()
        {

        }

        public Container(DataGridViewExt dgv, DataGridViewColumn column)
        {
            this.host = dgv;
            this.bindColumn = new BindColumn() { Column = column };
        }

        private DataGridViewExt host;
        private BindColumn bindColumn;

        public event EventHandler ValueChanged;

        public DataGridViewExt Host
        {
            get => host; set
            {
                host = value;
                if (!this.IsDesignMode())
                    ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Editor(typeof(SelectColumnsEdit), typeof(UITypeEditor))]
        public BindColumn BindColumn
        {
            get => bindColumn; set
            {
                bindColumn = value;
                if (!this.IsDesignMode())
                    ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return "宿主关系";
        }

    }

    public class BindColumn
    {
        public DataGridViewColumn Column { get; set; }
        public override string ToString()
        {
            return Column == null ? "" : Column.HeaderText;
        }
    }
}
