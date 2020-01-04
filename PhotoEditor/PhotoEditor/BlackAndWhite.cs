using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class BlackAndWhite
    {
        public static Bitmap Edit(Bitmap originalBitmap)
        {
            ImageProcessing imageProcessing = new ImageProcessing(originalBitmap);
            for (int i = 0; i < imageProcessing.originalBitmap.Width; i++)
            {
                for(int j = 0; j < imageProcessing.originalBitmap.Height; j++)
                {
                    var colorValue = originalBitmap.GetPixel(i,j);
                    var avarageValueOfColor = ((int)colorValue.R + (int)colorValue.G + (int)colorValue.B) / 3;
                    imageProcessing.editedBitmap.SetPixel(i, j, Color.FromArgb(avarageValueOfColor, avarageValueOfColor, avarageValueOfColor));
                }
            }
           return imageProcessing.editedBitmap;
        }
    }
}
