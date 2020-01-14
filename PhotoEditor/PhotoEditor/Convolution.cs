using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PhotoEditor
{
   public static  class Convolution
    {
        public static Bitmap ConvolutionMethod<T>(this Bitmap input, T filter) where T : ConvolutionFilters
        {
            BitmapData sourceData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


            byte[] inputBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, inputBuffer, 0, inputBuffer.Length);

            input.UnlockBits(sourceData);

            double Red = 0.0;
            double Green = 0.0;
            double Blue = 0.0;

            int filterWidth = filter.filterMatrix.GetLength(1);
            int filterHeight = filter.filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;

            int neighbourPixel = 0;

            int pixel = 0;

            for (int i = filterOffset; i < input.Height - filterOffset; i++)
            {
                for (int j = filterOffset; j < input.Width - filterOffset; j++)
                {
                    Red = 0;
                    Green = 0;
                    Blue = 0;

                    pixel = i * sourceData.Stride + j * 4;

                    for (int k = -filterOffset; k <= filterOffset; k++)
                    {
                        for (int l = -filterOffset; l <= filterOffset; l++)
                        {
                            neighbourPixel = pixel + (l * 4) + (k * sourceData.Stride);

                            Red += (inputBuffer[neighbourPixel + 2]) * filter.filterMatrix[k + filterOffset, l + filterOffset];
                            Green += (inputBuffer[neighbourPixel + 1]) * filter.filterMatrix[k + filterOffset, l + filterOffset];
                            Blue += (inputBuffer[neighbourPixel]) * filter.filterMatrix[k + filterOffset, l + filterOffset];
                        }
                    }

                    Blue = filter.Factor * Blue + filter.Bias;
                    Green = filter.Factor * Green + filter.Bias;
                    Red = filter.Factor * Red + filter.Bias;

                    if (Blue > 255)
                        Blue = 255;
                    else if (Blue < 0)
                        Blue = 0;

                    if (Green > 255)
                        Green = 255;
                    else if (Green < 0)
                        Green = 0;

                    if (Red > 255)
                        Red = 255;
                    else if (Red < 0)
                        Red = 0;

                    resultBuffer[pixel] = (byte)Blue;
                    resultBuffer[pixel + 1] = (byte)Green;
                    resultBuffer[pixel + 2] = (byte)Red;
                    resultBuffer[pixel + 3] = 255;

                }
            }
            Bitmap resultBitmap = new Bitmap(input.Width, input.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;

        }
    }
}
