using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace HIS.DSkinControl
{

    /// <summary>
    /// 自定义控件:透明罩控件(继承Control)
    /// 原理裁剪父容器图像 视觉欺骗
    /// </summary>
    [ToolboxBitmap(typeof(QLayerControl))]
    public class QLayerControl : System.Windows.Forms.Control
    {
        private int _alpha = 125;                 //设置透明度
        private Control attachControl = null;
        private Control parentContainer = null;
        //设置透明度
        [Category("LayerControl"), Description("设置透明度")]
        public int Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
                this.Invalidate();
            }
        }
        [Category("LayerControl"), Description("附加控件")]
        public Control AttachControl
        {
            get { return attachControl; }
            set
            {
                if (attachControl != value)
                {
                    if (attachControl != null && this.Controls.Contains(attachControl))
                    {
                        this.Controls.Remove(attachControl);
                    }
                    attachControl = value;
                }
            }
        }
        [Category("LayerControl"), Description("遮罩的父容器")]
        public Control ParentContainer
        {
            get { return parentContainer; }
            set
            {
                if (parentContainer != value)
                {
                    if (parentContainer != null && this.Parent == parentContainer)
                    {
                        parentContainer.ClientSizeChanged -= ParentContainer_ClientSizeChanged;
                        parentContainer.Controls.Remove(this);
                    }
                    parentContainer = value;
                }
            }
        }

        public QLayerControl()
            : this(125)
        {
        }


        public QLayerControl(int Alpha)
        {
            this._alpha = Alpha;
            this.BackColor = Color.FromArgb(179, 179, 179);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void ShowLayer()
        {
            if (this.IsDisposed) return;
            if (this.ParentContainer == null) return;
            this.ParentContainer.SizeChanged += ParentContainer_SizeChanged;
            if (this.Parent != this.ParentContainer)
            {
                this.SetSize();
                this.ParentContainer.ClientSizeChanged += ParentContainer_ClientSizeChanged;
                this.ParentContainer.Controls.Add(this);
            }
            if (this.AttachControl != null && !this.Controls.Contains(this.AttachControl))
            {
                if (this.AttachControl is Form)
                {
                    var form = attachControl as Form;
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                }
                this.AttachControl.Location = new Point(Math.Abs(this.ClientSize.Width - this.AttachControl.Width) / 2, (int)Math.Ceiling(Math.Abs((this.ClientSize.Height - this.AttachControl.Height)) * (1f - 0.618)));
                this.Controls.Add(this.AttachControl);
                if (this.AttachControl is Form)
                    this.AttachControl.Show();
            }
            this.BackgroundImage = GetLayerBitmap();
            this.BackgroundImageLayout = ImageLayout.None;
            this.Show();
            this.BringToFront();
            if (this.AttachControl != null)
            {
                this.AttachControl.Focus();
            }
        }

        private void ParentContainer_SizeChanged(object sender, EventArgs e)
        {
            if (this.AttachControl == null)
                return;
            this.AttachControl.Location = new Point(Math.Abs(this.ClientSize.Width - this.AttachControl.Width) / 2, (int)Math.Ceiling(Math.Abs((this.ClientSize.Height - this.AttachControl.Height)) * (1f - 0.618)));
        }

        public void CloseLayer()
        {
            this.ParentContainer = null;
            this.AttachControl = null;
            this.Visible = false;
        }

        /// <summary>
        /// 获取遮罩层伪图
        /// </summary>
        /// <returns></returns>
        private Bitmap GetLayerBitmap()
        {
            if (this.ParentContainer.IsDisposed) return null;
            if (this.ParentContainer.Width == 0 || ParentContainer.Height == 0) return null;
            if (!this.IsHandleCreated)
                this.CreateControl();
            //遮罩图像 默认等于父容器大小
            Bitmap bitmap = new Bitmap(this.ParentContainer.Width, this.ParentContainer.Height);
            //先隐藏当前遮罩层 ，防止算入父容器图像中
            this.Hide();
            //写入父容器图像
            this.ParentContainer.DrawToBitmap(bitmap, new Rectangle(0, 0, this.ParentContainer.Width, this.ParentContainer.Height));
            //显示遮罩
            this.Show();
            //如果遮罩层与父容器不等,则需要裁剪图像
            //防止把遮罩边界外区域计算入内
            if (this.Size != this.ParentContainer.Size)
            {
                if (this.Width == 0 || this.Height == 0)
                {
                    bitmap.Dispose();
                    return null;
                }
                //获取父容器屏幕坐标
                Point parentScreenLoaction;
                if (this.ParentContainer.Parent != null)
                    parentScreenLoaction = this.ParentContainer.Parent.PointToScreen(this.ParentContainer.Location);
                else
                    parentScreenLoaction = this.ParentContainer.Location;
                //获取遮罩屏幕坐标
                Point layerScreenLocation = this.ParentContainer.PointToScreen(this.Location);
                //计算出遮罩与父容器的实际偏移
                Point offset = new Point(Math.Abs(layerScreenLocation.X - parentScreenLoaction.X), Math.Abs(layerScreenLocation.Y - parentScreenLoaction.Y));
                //裁剪出实际遮罩层所显示的图像
                var bitmap2 = DSkin.Common.BitmapHelper.CutImage(bitmap, new Rectangle(offset, this.Size));
                bitmap.Dispose();
                bitmap = bitmap2;
            }
            //设置遮罩透明效果
            using (var g = Graphics.FromImage(bitmap))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(this._alpha, this.BackColor)))
                {
                    g.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
                }
            }
            return bitmap;
        }
        private void SetSize()
        {
            if (this.ParentContainer != null && !this.ParentContainer.IsDisposed)
            {
                this.Location = Point.Empty;
                if (this.ParentContainer is Form)
                {
                    //当为窗体时 且满足一定条件下 留1个像素的白用于 不影响窗体的大小拉动
                    var form = this.ParentContainer as Form;
                    if (form.ClientSize == form.Size && form.TopLevel)
                    {
                        int padding = 1;
                        this.Location = new Point(padding, padding);
                        this.Size = new Size(Math.Max(0, form.ClientSize.Width - 2 * padding), Math.Max(0, form.Height - 2 * padding));
                    }
                    else
                        this.Size = this.ParentContainer.ClientSize;
                }
                else
                    this.Size = this.ParentContainer.ClientSize;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.ParentContainer != null && this.Parent != null)
            {
                this.BackgroundImage = GetLayerBitmap();
                this.BackgroundImageLayout = ImageLayout.None;
            }

        }

        private void ParentContainer_ClientSizeChanged(object sender, EventArgs e)
        {
            this.SetSize();
        }








    }
}
