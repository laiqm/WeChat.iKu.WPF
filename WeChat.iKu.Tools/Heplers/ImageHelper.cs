﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing;

namespace WeChat.iKu.Tools.Heplers
{
    public class ImageHelper
    {
        /// <summary>
        /// Memory转成ImageSource
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        public static ImageSource MemoryToImageSource(MemoryStream ms)
        {
            return (ImageSource)(new ImageSourceConverter()).ConvertFrom(ms);
        }

        /// <summary>
        /// Memory转成ImageSource
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        public static ImageSource MemoryToImageSourceOther(MemoryStream ms)
        {
            Image img = Image.FromStream(ms);
            Bitmap bmp = new Bitmap(img);
            BitmapSource bi = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bmp.GetHbitmap(),
                IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            return bi;
        }
    }
}
