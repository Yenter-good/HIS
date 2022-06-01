using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System
{
    public static class ImageExtensions
    {
        /// <summary>
        /// 根据base64字符串返回一个封装好的GDI+位图。
        /// </summary>
        /// <param name="base64string">可转换成位图的base64字符串。</param>
        /// <returns>Bitmap对象。</returns>
        public static Bitmap GetImageFromBase64(this string base64string)
        {
            byte[] b = Convert.FromBase64String(base64string);
            MemoryStream ms = new MemoryStream(b);
            Bitmap bitmap = new Bitmap(ms);
            return bitmap;
        }

        /// <summary>
        /// 将图片转换成base64字符串。
        /// </summary>
        /// <param name="imagefile">需要转换的图片文件。</param>
        /// <returns>base64字符串。</returns>
        public static string GetBase64FromImage(this Image image, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            string strbaser64 = "";
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, imageFormat ?? System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arr = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(arr, 0, (int)ms.Length);
                    ms.Close();

                    strbaser64 = Convert.ToBase64String(arr);
                }
            }
            catch (Exception)
            {
                throw new Exception("Something wrong during convert!");
            }

            return strbaser64;
        }
        /// <summary>
        /// 获取图片二进制流
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] GetBinaryStream(this System.Drawing.Image image)
        {
            //将Image转换成流数据，并保存为byte[] 
            MemoryStream mstream = new MemoryStream();
            image.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length);
            mstream.Close();
            return byData;
        }
        /// <summary>
        /// 二进制转图片
        /// </summary>
        /// <param name="binaryStream"></param>
        /// <returns></returns>
        public static System.Drawing.Image GetImage(this byte[] binaryStream)
        {
            if (binaryStream == null || binaryStream.Length == 0) return null;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(binaryStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        /// <summary>
        /// 路径转图片
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Image GetLocalRelativePathImage(this string path)
        {
            var strPath = Application.StartupPath + path;
            if (!File.Exists(strPath))
                return null;

            return Image.FromFile(strPath);
        }
        private static Image ImageColorMatrix(Bitmap bitmap, ColorMatrix colorMatrix)
        {
            if (bitmap == null)
                return null;
            Bitmap b = bitmap.Clone() as Bitmap;
            Graphics g = Graphics.FromImage(b);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(b, new Rectangle(0, 0, b.Width, b.Height), 0, 0, b.Width, b.Height, GraphicsUnit.Pixel, imageAttributes);
            g.Dispose();
            return b;
        }
        /// <summary>
        /// 图像灰度化
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static Image ToGray(this Image image)
        {
            float[][] f = new float[][] {new float[] {0.299f, 0.299f, 0.299f, 0, 0},new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                                         new float[] {0.114f, 0.114f, 0.114f, 0, 0},new float[] {0, 0, 0, 1, 0}, new float[]  {0, 0, 0, 0, 0} };
            ColorMatrix colorMatrix = new ColorMatrix(f);
            return ImageColorMatrix(image as Bitmap, colorMatrix);
        }
        /// <summary>
        /// 图像灰度化
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static Image ToGray(this Bitmap image)
        {
            float[][] f = new float[][] {new float[] {0.299f, 0.299f, 0.299f, 0, 0},new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                                         new float[] {0.114f, 0.114f, 0.114f, 0, 0},new float[] {0, 0, 0, 1, 0}, new float[]  {0, 0, 0, 0, 0} };
            ColorMatrix colorMatrix = new ColorMatrix(f);
            return ImageColorMatrix(image, colorMatrix);
        }
        //// <summary> 
        /// 生成缩略图 
        /// </summary> 
        /// <param name="originalImage">源图</param> 
        /// <param name="width">缩略图宽度</param> 
        /// <param name="height">缩略图高度</param> 
        /// <param name="mode">生成缩略图的方式</param>     
        public static Image MakeThumbnail(this Image originalImage, int width, int height, string mode)
        {
            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                 
                    break;
                case "W"://指定宽，高按比例                     
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例 
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）        
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片 
            Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板 
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //设置高质量,低速度呈现平滑程度 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充 
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分 
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);
            g.Dispose();
            return bitmap;
        }


        /// <summary>
        /// 图片压缩(降低质量以减小文件的大小)
        /// </summary>
        /// <param name="srcBitmap">传入的Bitmap对象</param>
        /// <param name="destStream">压缩后的Stream对象</param>
        /// <param name="level">压缩等级，0到100，0 最差质量，100 最佳</param>
        public static void Compress(this Image srcBitmap, Stream destStream, long level)
        {
            ImageCodecInfo myImageCodecInfo;
            System.Drawing.Imaging.Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            // Get an ImageCodecInfo object that represents the JPEG codec.
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            // Create an Encoder object based on the GUID

            // for the Quality parameter category.
            myEncoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one

            // EncoderParameter object in the array.
            myEncoderParameters = new EncoderParameters(1);

            // Save the bitmap as a JPEG file with 给定的 quality level
            myEncoderParameter = new EncoderParameter(myEncoder, level);
            myEncoderParameters.Param[0] = myEncoderParameter;
            srcBitmap.Save(destStream, myImageCodecInfo, myEncoderParameters);
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

    }
}
