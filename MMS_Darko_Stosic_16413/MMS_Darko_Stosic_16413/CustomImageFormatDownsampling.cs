using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS_Darko_Stosic_16413
{
    public class CustomImageFormatDownsampling
    {
        ////////////////SHANON FANO/////////////
        private static byte[] GetStreamFromBitmap(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int bmpStride = bmpData.Stride;
            System.IntPtr Scan0 = bmpData.Scan0;

            byte[] stream = new byte[height * width * 3];

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = bmpStride - width * 3;

                int pixelIndex = 0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        stream[pixelIndex++] = p[0];
                        stream[pixelIndex++] = p[1];
                        stream[pixelIndex++] = p[2];
                        p += 3;
                    }
                    p += nOffset;
                }
            }

            bmp.UnlockBits(bmpData);

            return stream;
        }

        private static byte[] MyFormat(uint width, uint height, byte[] data)
        {
            byte[] stream = new byte[2 * sizeof(uint) + data.Length];

            int index = 0;


            WriteUInt32ToByteArray(stream, ref index, width);
            WriteUInt32ToByteArray(stream, ref index, height);

            Array.Copy(data, 0, stream, index, data.Length);

            return stream;
        }

        private static void WriteUInt32ToByteArray(byte[] byteArray, ref int index, uint value)
        {
            byte[] intArray = BitConverter.GetBytes(value);

            Array.Copy(intArray, 0, byteArray, index, sizeof(uint));

            index += sizeof(uint);

        }

        private static byte[] Compress(byte[] data)
        {
            byte[] compressedData = new byte[data.Length * (101 / 100) + 384];

            int acualSize = ShannonFano.Compress(data, compressedData, (uint)data.Length);

            Array.Resize(ref compressedData, acualSize);

            return compressedData;
        }

        protected static byte[] Decompress(int width, int height, byte[] data)
        {
            int decompressedSize =  width * height * 3;
            byte[] decompressedData = new byte[decompressedSize];

            ShannonFano.Decompress(data, decompressedData, (uint)data.Length, (uint)decompressedData.Length);

            return decompressedData;
        }

        public static bool SaveShannon(string fileName, Bitmap bmp)
        {
            Bitmap yuvImage = YUV.toYUV(bmp);


            byte[] data = Compress(GetStreamFromBitmap(yuvImage));

           

            byte[] dataStream = MyFormat((uint)yuvImage.Width, (uint)yuvImage.Height, data);

            File.WriteAllBytes(fileName, dataStream);

            return true;
        }

        private static Bitmap GetBitmapFromStream(byte[] stream,int width,int height)
        {


            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, bmp.PixelFormat);

            int bmpStride = bmpData.Stride;
            System.IntPtr Scan0 = bmpData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = bmpStride - width * 3;

                int pixelIndex = 0;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[0] = stream[pixelIndex++];
                        p[1] = stream[pixelIndex++];
                        p[2] = stream[pixelIndex++];
                        p += 3;
                    }
                    p += nOffset;
                }
            }

            bmp.UnlockBits(bmpData);

            return bmp;
        }

        public static Bitmap loadShanon(string fileName)
        {
            byte[] dataStream = File.ReadAllBytes(fileName);

            byte[] data = new byte[dataStream.Length - 8];

            Array.Copy(dataStream, 8, data, 0, dataStream.Length - 10);

            int width = BitConverter.ToInt32(dataStream, 0);
            int height = BitConverter.ToInt32(dataStream, 4);

            
            data = Decompress(width, height, data);
            

           
            Bitmap yuvImage = GetBitmapFromStream(data,width,height);

            return YUV.toRGB(yuvImage);
        }


        //////////////////////////////////////
        ///DOWNSAMPLE////////////////////////

        private static Bitmap Downsample(Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
         

            for (int i = 0; i < height - 1; i+=2)
            {
                for (int j = 0; j < width - 1; j+=2)
                {
                    Color pixel1 = bmp.GetPixel(j, i);
                    Color pixel2 = bmp.GetPixel(j+1, i);
                    Color pixel3 = bmp.GetPixel(j, i+1);
                    Color pixel4 = bmp.GetPixel(j+1, i+1);
                    int Y1 = pixel1.R;
                    int Y2 = pixel2.R;
                    int Y3 = pixel3.R;
                    int Y4 = pixel4.R;
                    int U1 = pixel1.G;
                    int U2 = pixel2.G;
                    int U3 = pixel3.G;
                    int U4 = pixel4.G;
                    int V1 = pixel1.B;
                    int V2 = pixel2.B;
                    int V3 = pixel3.B;
                    int V4 = pixel4.B;
                    int Uprosek = (U1 + U2 + U3 + U4) / 4;
                    int Vprosek = (V1 + V2 + V3 + V4) / 4;
                    

                    bmp.SetPixel(j, i, Color.FromArgb(Y1, Uprosek, Vprosek));
                    bmp.SetPixel(j+1, i, Color.FromArgb(Y2, 0, 0));
                    bmp.SetPixel(j, i+1, Color.FromArgb(Y3, 0, 0));
                    bmp.SetPixel(j+1, i+1, Color.FromArgb(Y4, 0, 0));
                }
            }

            return bmp;
        }


        public static bool SaveDownsample(string fileName, Bitmap bmp)
        {
            Bitmap yuvImage = YUV.toYUV(bmp);
            yuvImage = Downsample(yuvImage);


            byte[] data = Compress(GetStreamFromBitmap(yuvImage));



            byte[] dataStream = MyFormat((uint)yuvImage.Width, (uint)yuvImage.Height, data);

            File.WriteAllBytes(fileName, dataStream);

            return true;
        }

        private static Bitmap UpSample(Bitmap bmp)
        {


            int height = bmp.Height;
            int width = bmp.Width;


            for (int i = 0; i < height - 1; i += 2)
            {
                for (int j = 0; j < width - 1; j += 2)
                {
                    Color pixel1 = bmp.GetPixel(j, i);
                    Color pixel2 = bmp.GetPixel(j + 1, i);
                    Color pixel3 = bmp.GetPixel(j, i + 1);
                    Color pixel4 = bmp.GetPixel(j + 1, i + 1);
                    int Y1 = pixel1.R;
                    int Y2 = pixel2.R;
                    int Y3 = pixel3.R;
                    int Y4 = pixel4.R;
                    int U1 = pixel1.G;
                    int V1 = pixel1.B;
                   


                    bmp.SetPixel(j, i, Color.FromArgb(Y1, U1, V1));
                    bmp.SetPixel(j + 1, i, Color.FromArgb(Y2, U1, V1));
                    bmp.SetPixel(j, i + 1, Color.FromArgb(Y3, U1, V1));
                    bmp.SetPixel(j + 1, i + 1, Color.FromArgb(Y4, U1, V1));
                }
            }

            return bmp;
        }

        public static Bitmap loadDownsample(string fileName)
        {
            byte[] dataStream = File.ReadAllBytes(fileName);

            byte[] data = new byte[dataStream.Length - 8];

            Array.Copy(dataStream, 8, data, 0, dataStream.Length - 10);

            int width = BitConverter.ToInt32(dataStream, 0);
            int height = BitConverter.ToInt32(dataStream, 4);


            data = Decompress(width, height, data);



            Bitmap yuvImage = GetBitmapFromStream(data, width, height);

            yuvImage = UpSample(yuvImage);

            return YUV.toRGB(yuvImage);
        }

        public static bool SaveDownsampleWithoutShanon(string fileName, Bitmap bmp)
        {
            Bitmap yuvImage = YUV.toYUV(bmp);
            yuvImage = Downsample(yuvImage);

            byte[] data = GetStreamFromBitmap(yuvImage);

            byte[] dataStream = MyFormat((uint)yuvImage.Width, (uint)yuvImage.Height, data);

            File.WriteAllBytes(fileName, dataStream);

            return true;
        }

        public static Bitmap loadDownsampleWithoutShanon(string fileName)
        {
            byte[] dataStream = File.ReadAllBytes(fileName);

            byte[] data = new byte[dataStream.Length - 8];

            Array.Copy(dataStream, 8, data, 0, dataStream.Length - 10);

            int width = BitConverter.ToInt32(dataStream, 0);
            int height = BitConverter.ToInt32(dataStream, 4);


            Bitmap yuvImage = GetBitmapFromStream(data, width, height);

            yuvImage = UpSample(yuvImage);

            return YUV.toRGB(yuvImage);
        }
        /////
        ////YUV

        public static bool SaveYUV(string fileName, Bitmap bmp)
        {
            Bitmap yuvImage = YUV.toYUV(bmp);          

            byte[] data = GetStreamFromBitmap(yuvImage);

            byte[] dataStream = MyFormat((uint)yuvImage.Width, (uint)yuvImage.Height, data);

            File.WriteAllBytes(fileName, dataStream);

            return true;
        }

        public static Bitmap loadYUV(string fileName)
        {
            byte[] dataStream = File.ReadAllBytes(fileName);

            byte[] data = new byte[dataStream.Length - 8];

            Array.Copy(dataStream, 8, data, 0, dataStream.Length - 10);

            int width = BitConverter.ToInt32(dataStream, 0);
            int height = BitConverter.ToInt32(dataStream, 4);

            Bitmap yuvImage = GetBitmapFromStream(data, width, height);

            return YUV.toRGB(yuvImage);
        }


        ///


    }
    
}
