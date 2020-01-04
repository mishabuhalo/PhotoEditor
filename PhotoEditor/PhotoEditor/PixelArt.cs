using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class PixelArt
    {
        public static Bitmap Edit(Bitmap originalBitmap, int n)
        {
            
            var newHeight = originalBitmap.Height - originalBitmap.Height % n;
            var newWidth = originalBitmap.Width - originalBitmap.Width % n;

            var editedBitmap = new Bitmap(newWidth, newHeight);

            var tmpRed = 0;
            var tmpGreen = 0;
            var tmpBlue = 0;
            for (int i = 0; i < newWidth; i += n)
            {
               
                for (int j = 0; j< newHeight; j+=n)
                {
                    for(int k = i; k< i+ n; k ++ )
                    {
                        for(int l = j; l< j+ n; l++)
                        {
                            tmpRed += (int)originalBitmap.GetPixel(k, l).R;
                            tmpGreen += (int)originalBitmap.GetPixel(k, l).G;
                            tmpBlue += (int)originalBitmap.GetPixel(k, l).B;
                        }
                    }

                    var avarageValueOfRed = tmpRed / (n*n);
                    var avarageValueOfBlue = tmpBlue /(n*n);
                    var avarageValueOfGreen = tmpGreen/(n*n);

                    tmpRed = 0;
                    tmpGreen = 0;
                    tmpBlue = 0; 

                    for (int k = i; k <i+ n; k++)
                    {
                        for (int l = j; l <j+ n; l++)
                        {
                            editedBitmap.SetPixel(k, l, Color.FromArgb(avarageValueOfRed, avarageValueOfGreen, avarageValueOfBlue));
                        }
                    }
                   
                }

            }
            
            return editedBitmap;
        }
    }
}
