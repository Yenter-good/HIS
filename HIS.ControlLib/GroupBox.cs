using HIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.ControlLib.Controls
{
    public class GroupBoxEx : System.Windows.Forms.GroupBox
    {
        [Browsable(true), Description("获取或设置该控件的边框色")]
        public Color BorderColor { get; set; } = Color.FromArgb(155, 167, 183);

        [Browsable(true), Description("获取或设置该控件的边框宽度")]
        public int BorderWidth { get; set; } = 1;
        [Browsable(true), Description("获取或设置该控件的文字偏移")]
        public int TextOffset { get; set; } = 0;
        [Browsable(true), Description("获取或设置该控件的边框样式")]
        public BorderStyle BorderStyle { get; set; } = BorderStyle.RoundRectangle;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            var vSize = e.Graphics.MeasureString(this.Text, this.Font);

            e.Graphics.Clear(this.BackColor);
            Pen pen = new Pen(this.BorderColor, BorderWidth);
            //拿到文字的大小
            var size = e.Graphics.MeasureString(this.Text, this.Font).ToSize();
            //获得边框的矩形
            Rectangle rectClip = new Rectangle(new Point(1, size.Height / 2), this.Size - new Size(BorderWidth + 1, size.Height / 2 + BorderWidth));
            //用圆角矩形填充
            using (GraphicsPath path = GraphicHelper.CreateRoundedRectanglePath(rectClip, 2))
                e.Graphics.DrawPath(pen, path);

            Rectangle rectFillText = new Rectangle(new Point(8 + TextOffset, 0), size + new Size(2, 0));
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rectFillText);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 10 + TextOffset, 0);
        }
    }

    public enum BorderStyle
    {
        RoundRectangle,
        TopLine,
    }
}
