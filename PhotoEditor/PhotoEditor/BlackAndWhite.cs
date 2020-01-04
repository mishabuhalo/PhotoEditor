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

            var editedBitmap = originalBitmap;
            for (int i = 0; i < originalBitmap.Width; i++)
            {
                for(int j = 0; j < originalBitmap.Height; j++)
                {
                    var colorValue = originalBitmap.GetPixel(i,j);
                    var avarageValueOfColor = ((int)colorValue.R + (int)colorValue.G + (int)colorValue.B) / 3;
                    editedBitmap.SetPixel(i, j, Color.FromArgb(avarageValueOfColor, avarageValueOfColor, avarageValueOfColor));
                }
            }
           return editedBitmap;
        }
    }
}
