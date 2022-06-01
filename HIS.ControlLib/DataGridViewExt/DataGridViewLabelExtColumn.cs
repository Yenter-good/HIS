using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class DataGridViewLabelExtColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewLabelExtColumn()
            : base()
        {
            CellTemplate = new DataGridViewLabelExtCell();
        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewLabelExtCell)))
                {
                    throw new Exception("这个列里面必须绑定DataGridViewLabelExtCell");
                }
                base.CellTemplate = value;
            }
        }

    }
    public class DataGridViewLabelExtCell : DataGridViewTextBoxCell
    {
        private string _value;

        protected override bool SetValue(int rowIndex, object value)
        {
            _value = value == null ? "" : value.ToString();
            return true;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            if (_value.AsString().Contains("╋") || _value.AsString().Contains("●") || _value.AsString().Contains("━"))
            {
                var sizeF = graphics.MeasureString(_value.Substring(0, 1), cellStyle.Font);
                var sizeF1 = graphics.MeasureString(_value.Substring(1), cellStyle.Font);

                graphics.DrawString(_value.Substring(0, 1), cellStyle.Font, Brushes.Black, new PointF(cellBounds.Left, cellBounds.Top + cellBounds.Height / 2 - sizeF.Height / 2));
                graphics.DrawString(_value.Substring(1), cellStyle.Font, new SolidBrush(cellStyle.ForeColor), new PointF(cellBounds.Left + sizeF.Width, cellBounds.Top + cellBounds.Height / 2 - sizeF1.Height / 2));

            }
            else
            {
                var sizeF1 = graphics.MeasureString(_value, cellStyle.Font);
                graphics.DrawString(_value, cellStyle.Font, new SolidBrush(cellStyle.ForeColor), new PointF(cellBounds.Left, cellBounds.Top + cellBounds.Height / 2 - sizeF1.Height / 2));
            }
        }
    }
}
