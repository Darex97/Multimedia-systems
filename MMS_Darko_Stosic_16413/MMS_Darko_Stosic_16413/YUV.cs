using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS_Darko_Stosic_16413
{
        
  public class YUV
  {

        public static Bitmap toYUV(Bitmap bmp)
        {
            Bitmap yuvImage = (Bitmap)bmp.Clone();

            BitmapData bmData = yuvImage.LockBits(new Rectangle(0, 0, yuvImage.Width, yuvImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - yuvImage.Width * 3;

                int b, g, r;

                for (int y = 0; y < yuvImage.Height; ++y)
                {

                    for (int x = 0; x < yuvImage.Width; ++x)
                    {

                        b = p[0];
                        g = p[1];
                        r = p[2];

                        // BT.601 standard

                        p[0] = (byte)(int)(+0.299 * r + 0.587 * g + 0.114 * b);
                        p[1] = (byte)(int)(128 - 0.168736 * r - 0.331264 * g + 0.5 * b);
                        p[2] = (byte)(int)(128 + 0.5 * r - 0.418688 * g - 0.081312 * b);
                        p += 3;

                    }
                    p += nOffset;
                }
            }

            yuvImage.UnlockBits(bmData);

            return yuvImage;
        }
        public static Bitmap toRGB(Bitmap bmp)
        {
            Bitmap rgbImage = (Bitmap)bmp.Clone();

            BitmapData bmData = rgbImage.LockBits(new Rectangle(0, 0, rgbImage.Width, rgbImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - rgbImage.Width * 3;

                int yC, uC, vC;

                for (int y = 0; y < rgbImage.Height; ++y)
                {

                    for (int x = 0; x < rgbImage.Width; ++x)
                    {
                        yC = p[0];
                        uC = p[1];
                        vC = p[2];

                        // BT.601 standard

                        int r = (int)(yC + 1.402 * (vC - 128));
                        int g = (int)(yC - 0.344136 * (uC - 128) - (0.714136 * (vC - 128)));
                        int b = (int)(yC + 1.772 * (uC - 128));


                        r = (r < 0) ? 0 : r;
                        r = (r > 255) ? 255 : r;
                        g = (g < 0) ? 0 : g;
                        g = (g > 255) ? 255 : g;
                        b = (b < 0) ? 0 : b;
                        b = (b > 255) ? 255 : b;


                        p[0] = (byte)b;
                        p[1] = (byte)g;
                        p[2] = (byte)r;
                        p += 3;
                    }
                    p += nOffset;
                }
            }


            rgbImage.UnlockBits(bmData);

            return rgbImage;
        }

       
    }
}

