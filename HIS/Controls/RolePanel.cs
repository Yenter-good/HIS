using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS
{
    internal class RolePanel : Panel
    {
        private LabelX _label = new LabelX();

        private bool _isSelected = false;

        private Size _size = new Size(1, 1);
        public RolePanel()
        {
            this.MinimumSize = new System.Drawing.Size(150, 50);
            this.MaximumSize = new System.Drawing.Size(150, 50);
            this.BackColor = Color.FromArgb(248, 198, 24);
            this.ForeColor = Color.FromArgb(192, 0, 192);
            this._label.Font = new Font("宋体", 12, FontStyle.Bold);
            this.Controls.Add(_label);
            _label.AutoSize = true;
            _label.Text = "";

            this._label.MouseClick += (s, e) => this.OnMouseClick(e);

            this.Paint += RolePanel_Paint;

        }

        private void RolePanel_Paint(object sender, PaintEventArgs e)
        {
            if (_isSelected)
                e.Graphics.DrawRectangle(Pens.Red, new Rectangle(Point.Empty, this.Size - _size));
        }

        public bool IsSelected
        {
            get => this._isSelected;
            set
            {
                _isSelected = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        public new string Text
        {
            get => this._label.Text; set => this._label.Text = value;
        }

        public void ResetLocation()
        {
            this._label.Left = this.Width / 2 - this._label.Width / 2;
            this._label.Top = this.Height / 2 - this._label.Height / 2;
        }
    }
}
