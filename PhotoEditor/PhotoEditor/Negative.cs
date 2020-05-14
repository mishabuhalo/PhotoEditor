using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class Negative
    {
        public static Bitmap Edit(Bitmap originalBitmap)
        {
            ImageProcessing imageProcessing = new ImageProcessing(originalBitmap);
            for (int i = 0; i < imageProcessing.originalBitmap.Width; i++)
            {
                for (int j = 0; j < imageProcessing.originalBitmap.Height; j++)
                {
                    var colorValue = originalBitmap.GetPixel(i, j);
                    imageProcessing.editedBitmap.SetPixel(i, j, Color.FromArgb(255-colorValue.R, 255 -colorValue.G, 255- colorValue.B));
                }
            }
            return imageProcessing.editedBitmap;
        }
    }
}
