using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class BitmapByte
    {
        public static byte[] GetBytes(Bitmap input)
        {
            byte[] result = new byte[input.Width*input.Height*3];
            int counter = 0;
            for (int i = 0; i < input.Width; i++)
            {
                for (int j = 0; j < input.Height; j++)
                {
                    result[counter] = (byte)input.GetPixel(i, j).R;
                    counter++;
                    result[counter] = (byte)input.GetPixel(i, j).G;
                    counter++;
                    result[counter] = (byte)input.GetPixel(i, j).B;
                    counter++;
                }
            }
            return result;
        }

        public static Bitmap GetBitmap(byte[] input, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    result.SetPixel(i, j, Color.FromArgb(input[(height * i + j) * 3], input[(height * i + j) * 3 + 1], input[(height * i + j) * 3 + 2]));
                }
            }
            return result;
        }
    }
}
