using System;
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

        public void LoadImage(string filename)
        {
            originalBitmap = new Bitmap(Image.FromFile(filename));
        }


        public Bitmap UploadImage()
        {
            return editedBitmap;
        }
    }
}
