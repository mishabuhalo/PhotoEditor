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
    }
}
