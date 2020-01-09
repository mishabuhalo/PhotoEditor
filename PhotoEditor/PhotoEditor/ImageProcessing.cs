﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class ImageProcessing
    {
        public Bitmap originalBitmap;
        public Bitmap editedBitmap;
        public double[,] kernel = new double[,] { {0.000789,0.006581,0.013347,0.006581,0.000789},
                                           {0.006581,0.054901,0.111345,0.054901,0.006581},
                                           {0.013347,0.111345,0.225821,0.111345,0.013347},
                                           {0.006581,0.054901,0.111345,0.054901,0.006581},
                                           {0.000789,0.006581,0.013347,0.006581,0.000789} };
        public ImageProcessing(Bitmap bitmap)
        {
            originalBitmap = bitmap;
            editedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
        }
        public ImageProcessing()
        {
            originalBitmap = null;
            editedBitmap = null;
        }

        public void LoadImage(string filename)
        {
            originalBitmap = new Bitmap(Image.FromFile(filename));
            editedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
        }

        public Bitmap UploadImage()
        {
            return editedBitmap;
        }

        public Bitmap Convolution(Bitmap input, double[,] kernel)
        {
            byte[] inputBytes = BitmapByte.GetBytes(input);
            byte[] outputBytes = new byte[inputBytes.Length];

            int width = input.Width;
            int height = input.Height;

            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double rSum = 0, gSum = 0, bSum = 0, kSum = 0;

                    for (int i = 0; i < kernelWidth; i++)
                    {
                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int pixelPosX = x + (i - (kernelWidth / 2));
                            int pixelPosY = y + (j - (kernelHeight / 2));
                            if ((pixelPosX < 0) ||
                              (pixelPosX >= width) ||
                              (pixelPosY < 0) ||
                              (pixelPosY >= height)) continue;

                            byte r = inputBytes[3 * (width * pixelPosY + pixelPosX) + 0];
                            byte g = inputBytes[3 * (width * pixelPosY + pixelPosX) + 1];
                            byte b = inputBytes[3 * (width * pixelPosY + pixelPosX) + 2];

                            double kernelVal = kernel[i, j];

                            rSum += r * kernelVal;
                            gSum += g * kernelVal;
                            bSum += b * kernelVal;

                            kSum += kernelVal;
                        }
                    }

                    if (kSum <= 0) kSum = 1;
                    
                    rSum /= kSum;
                    if (rSum < 0) rSum = 0;
                    if (rSum > 255) rSum = 255;

                    gSum /= kSum;
                    if (gSum < 0) gSum = 0;
                    if (gSum > 255) gSum = 255;

                    bSum /= kSum;
                    if (bSum < 0) bSum = 0;
                    if (bSum > 255) bSum = 255;
                    
                    outputBytes[3 * (width * y + x) + 0] = (byte)rSum;
                    outputBytes[3 * (width * y + x) + 1] = (byte)gSum;
                    outputBytes[3 * (width * y + x) + 2] = (byte)bSum;
                }
            }
            return BitmapByte.GetBitmap(outputBytes, width, height);
        }
    }
}
