using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.IO;

namespace FindPixel
{
    class Processing
    {
        public static bool Compare(Bitmap firstImage, Bitmap secondImage)
        {
            MemoryStream memoryStream = new MemoryStream();

            firstImage.Save(memoryStream, ImageFormat.Jpeg);
            String firstBitmap = Convert.ToBase64String(memoryStream.ToArray());
            memoryStream.Position = 0;

            secondImage.Save(memoryStream, ImageFormat.Jpeg);
            String secondBitmap = Convert.ToBase64String(memoryStream.ToArray());

            if (firstBitmap.Equals(secondBitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
