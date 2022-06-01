using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS.ControlLib
{
    public class DataGridViewTextBoxExtColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewTextBoxExtColumn()
            : base()
        {
            CellTemplate = new DataGridViewTextBoxExtCell();
        }

        #region 属性
        /// <summary>
        /// 附加数据
        /// </summary>
        public object Tags { get; set; }
        /// <summary>
        /// 绑定到的字段名
        /// </summary>
        public string BindFieldName { get; set; }
        #endregion
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewTextBoxExtCell)))
                {
                    throw new Exception("这个列里面必须绑定DataGridViewTextBoxExtCell");
                }
                base.CellTemplate = value;
            }
        }

        public override object Clone()
        {
            DataGridViewTextBoxExtColumn col = (DataGridViewTextBoxExtColumn)base.Clone();
            col.Tags = Tags;
            col.BindFieldName = BindFieldName;
            return col;
        }
    }

    public class DataGridViewTextBoxExtCell : DataGridViewTextBoxCell
    {
        public bool ShowText { get; set; } = true;

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (ShowText)
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            else
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, "", errorText, cellStyle, advancedBorderStyle, paintParts);

        }

    }

    public class DataGridViewBlankCell : DataGridViewTextBoxCell
    {
        protected override bool SetValue(int rowIndex, object value)
        {
            return true;
        }
    }
}
