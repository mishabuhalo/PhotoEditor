using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    public static class OilPainting
    {

        public static Bitmap OilPaintingFilter(this Bitmap input, int levels, int filterSize)
        {
            BitmapData sourceData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


            byte[] inputBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, inputBuffer, 0, inputBuffer.Length);

            input.UnlockBits(sourceData);

            int[] intensityBin = new int[levels];
            int[] redBin = new int[levels];
            int[] greenBin = new int[levels];
            int[] blueBin = new int[levels];

            levels--;

            int filterOffset = (filterSize - 1) / 2;
            int pixel = 0;
            int neighbourPixel = 0;
            int currentIntensity = 0;
            int maxIntensity = 0;
            int maxIndex = 0;

            double red = 0;
            double green = 0;
            double blue = 0;

            for (int i = filterOffset; i < input.Height - filterOffset; i++)
            {
                for (int j = filterOffset; j < input.Width - filterOffset; j++)
                {
                    red = green = blue = 0;

                    currentIntensity = maxIndex = maxIntensity = 0;

                    intensityBin = new int[levels + 1];
                    redBin = new int[levels + 1];
                    greenBin = new int[levels + 1];
                    blueBin = new int[levels + 1];

                    pixel = i * sourceData.Stride + j * 4;

                    for (int k = -filterOffset; k <= filterOffset; k++)
                    {
                        for (int l = -filterOffset; l <= filterOffset; l++)
                        {
                            neighbourPixel = pixel + (l * 4) + (k * sourceData.Stride);

                            currentIntensity = (int)Math.Round(((double)(inputBuffer[neighbourPixel]+inputBuffer[neighbourPixel+1] + inputBuffer[neighbourPixel+2])/3*(levels))/255);

                            intensityBin[currentIntensity] += 1;
                            blueBin[currentIntensity] += inputBuffer[neighbourPixel];
                            greenBin[currentIntensity] += inputBuffer[neighbourPixel+1];
                            redBin[currentIntensity] += inputBuffer[neighbourPixel+2];

                            if(intensityBin[currentIntensity]> maxIntensity)
                            {
                                maxIntensity = intensityBin[currentIntensity];
                                maxIndex = currentIntensity;
                            }

                        }
                    }

                    red = redBin[maxIndex] / maxIntensity;
                    green = greenBin[maxIndex] / maxIntensity;
                    blue = blueBin[maxIndex] / maxIntensity;

                    resultBuffer[pixel] = CheckByte(blue);
                    resultBuffer[pixel + 1] = CheckByte(green);
                    resultBuffer[pixel + 2] = CheckByte(red);
                    resultBuffer[pixel + 3] = 255;


                }
            }

            Bitmap resultBitmap = new Bitmap(input.Width, input.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static byte CheckByte(double colour)
        {
            return (byte)(colour > 255 ? 255 :
                   (colour < 0 ? 0 : colour));
        }
    }
}
