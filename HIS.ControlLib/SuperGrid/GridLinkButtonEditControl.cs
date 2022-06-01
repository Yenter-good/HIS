using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIS.ControlLib.SuperGrid
{
    [ToolboxItem(false)]
    public partial class GridLinkButtonEditControl : LinkLabel, IGridCellEditControl
    {
        public GridLinkButtonEditControl()
        {
            BackColor = Color.Transparent;
            ActiveLinkColor = LinkColor = VisitedLinkColor = ForeColor = Color.FromArgb(0, 0, 204);
            AutoSize = false;
            TextAlign = ContentAlignment.MiddleCenter;
            LinkBehavior = LinkBehavior.HoverUnderline;
        }
        public bool CanInterrupt { get { return true; } }

        public CellEditMode CellEditMode { get { return CellEditMode.NonModal; } }

        public GridCell EditorCell { get; set; }

        public Bitmap EditorCellBitmap { get; set; }

        public string EditorFormattedValue => Text;

        public EditorPanel EditorPanel { get; set; }

        public object EditorValue { get { return Text; } set { Text = value.AsString(); } }

        public bool EditorValueChanged { get; set; }

        public Type EditorValueType { get { return typeof(string); } }

        public StretchBehavior StretchBehavior { get { return StretchBehavior.Both; } }

        public bool SuspendUpdate { get; set; }

        public ValueChangeBehavior ValueChangeBehavior { get { return ValueChangeBehavior.None; } }

        public bool BeginEdit(bool selectAll)
        {
            return false;
        }

        public bool CancelEdit()
        {
            return false;
        }

        public void CellKeyDown(KeyEventArgs e)
        {
        }

        public void CellRender(Graphics g)
        {
            EditorCell?.CellRender(this, g);
        }

        public bool EndEdit()
        {
            return false;
        }

        public Size GetProposedSize(Graphics g, GridCell cell, CellVisualStyle style, Size constraintSize)
        {
            return Size;
        }

        public virtual void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            EditorCell = cell;
            EditorValue = cell.Value;
            if (style != null)
            {
                Enabled = !EditorCell.ReadOnly;
                Font = style.Font;
                ForeColor = style.TextColor;
            }
        }

        public void OnCellMouseDown(MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        public void OnCellMouseEnter(EventArgs e)
        {
            OnMouseEnter(e);
        }

        public void OnCellMouseLeave(EventArgs e)
        {
            OnMouseLeave(e);
        }

        public void OnCellMouseMove(MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        public void OnCellMouseUp(MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        public bool WantsInputKey(Keys key, bool gridWantsKey)
        {
            return gridWantsKey;
        }
    }
}
