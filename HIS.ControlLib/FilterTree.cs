using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using HIS.ControlLib.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class FilterTree : DevComponents.DotNetBar.Controls.TextBoxX
    {
        private Popups.PopupControlHost _host;
        private ComboTreePopupView _tree;
        private SymbolBox sbClear = new SymbolBox();


        private DataEntry _selectedEntry;
        private long _selectedValue;
        private bool _showClearButton = true;

        public FilterTree()
        {
            _tree = new ComboTreePopupView();
            _host = new Popups.PopupControlHost(_tree);
            _host.AutoClose = true;
            _tree.ViewLostFocus += _tree_ViewLostFocus;
            _tree.SelectedEntryChanged += _tree_SelectedEntryChanged;
            base.ReadOnly = true;
            base.BackColor = Color.White;

            this.sbClear.TabStop = false;
            this.sbClear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbClear.BackColor = this.BackColor;
            this.sbClear.Location = new Point(this.Width - 22, 0);
            this.sbClear.Size = new System.Drawing.Size(22, this.Height);
            this.sbClear.Symbol = "57676";
            this.sbClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sbClear.SymbolColor = System.Drawing.Color.FromArgb(68, 136, 229);
            this.sbClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.sbClear.Click += (sender, e) => { this.SelectedEntry = null; };
            base.Controls.Add(sbClear);
            sbClear.BringToFront();
            this.sbClear.Visible = false;
        }

        [Browsable(true)]
        public event EventHandler SelectedChanged;

        /// <summary>
        /// 弹出框的高度
        /// </summary>
        [Description("弹出框的高度")]
        [Browsable(true)]
        public int PopupHeight { get; set; } = 300;
        /// <summary>
        /// 默认根节点ID
        /// </summary>
        [Description("默认根节点ID")]
        [Browsable(true)]
        public string RootId { get; set; } = "0";
        [Browsable(false)]
        public new bool ReadOnly { get; set; }
        [Browsable(true)]
        public SymbolBox ClearButton
        {
            get { return sbClear; }
        }
        [Browsable(true)]
        public bool ShowClearButton
        {
            get { return _showClearButton; }
            set
            {
                _showClearButton = value;
                if (_showClearButton)
                {
                    if (!string.IsNullOrEmpty(this.Text) && this.Enabled)
                        sbClear.Visible = true;
                    else
                        sbClear.Visible = false;
                }
                else
                {
                    sbClear.Visible = false;
                }
            }
        }

        /// <summary>
        /// 数据源
        /// </summary>
        public List<DataEntry> DataSource
        {
            get
            {
                return this._tree.DataSource; ;
            }
            set
            {
                this._tree.DataSource = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataEntry SelectedEntry
        {
            get
            {
                return _selectedEntry;
            }
            set
            {
                _selectedEntry = value;
                if (value == null)
                    this.Text = "";
                else
                    this.Text = _selectedEntry.Name.AsString("");
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                _selectedValue = value;
                var entry = this.DataSource.Find(p => p.Id == _selectedValue);
                this.SelectedEntry = entry;
            }
        }

        public void ShowPopup()
        {
            this._tree.Width = this.Width;
            this._tree.Height = this.PopupHeight;
            this._host.Show(this);
            this._tree.Focus();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            ShowPopup();
            base.OnMouseClick(e);
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.sbClear.BackColor = this.BackColor;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (this.ShowClearButton)
            {
                this.sbClear.Visible = !string.IsNullOrEmpty(this.Text);
            }
        }
        private void _tree_ViewLostFocus(object sender, EventArgs e)
        {
            this._host.Close();
        }

        private void _tree_SelectedEntryChanged(object sender, DataEntry e)
        {
            this.SelectedEntry = e;
            SelectedChanged?.Invoke(this, EventArgs.Empty);
            this._host.Close();
        }

    }
    public class DataEntry
    {
        public DataEntry(long id, long parentId, string name, params string[] searchValues)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            for (int i = 0; i < searchValues.Length; i++)
                searchValues[i] = searchValues[i].AsString("");
            SearchValues = searchValues;
        }

        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Name { get; set; }
        public string[] SearchValues { get; set; }
    }
}
