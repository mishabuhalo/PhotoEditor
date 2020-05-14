using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class MainForm : Form
    {

        ImageProcessing imageProcessing = new ImageProcessing();

        public MainForm()
        {
            InitializeComponent();
        }


        public bool checkOriginalPhoto()
        {
            if (originalImage.Image == null)
            {
                MessageBox.Show("Please open photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
 

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog.FileName.Replace(@"\", "\\");

            try
            {
                imageProcessing.LoadImage(fileName);
                originalImage.Image = Image.FromFile(fileName);
            }
            catch
            {
                MessageBox.Show("Unnable to load the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editedPhoto.Image == null)
            {
                MessageBox.Show("Unnable to save the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveFileDialog.Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.bmp)|*.bmp|Image Files(*.gif)|*.gif|Image Files(*.png)|*.png|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    editedPhoto.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Unnable to save the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void blur3x3FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Blur3x3Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkOriginalPhoto())
            {
                imageProcessing.editedBitmap = null;

                imageProcessing.editedBitmap = BlackAndWhite.Edit(imageProcessing.originalBitmap);

                if (imageProcessing.editedBitmap != null)
                    editedPhoto.Image = (Image)imageProcessing.editedBitmap;
            }
        }

        private void pixelArtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkOriginalPhoto())
            {
                imageProcessing.editedBitmap = null;

                imageProcessing.editedBitmap = PixelArt.Edit(imageProcessing.originalBitmap, 8);

                if (imageProcessing.editedBitmap != null)
                    editedPhoto.Image = (Image)imageProcessing.editedBitmap;

            }
        }

        private void oilPaintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {

                imageProcessing.editedBitmap = null;
                imageProcessing.editedBitmap = imageProcessing.originalBitmap.OilPaintingFilter(25, 7);
                if (imageProcessing.editedBitmap != null)
                    editedPhoto.Image = (Image)imageProcessing.editedBitmap;
            }
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                imageProcessing.editedBitmap = null;

                imageProcessing.editedBitmap = Negative.Edit(imageProcessing.originalBitmap);

                if (imageProcessing.editedBitmap != null)
                    editedPhoto.Image = (Image)imageProcessing.editedBitmap;
            }
        }

        private void edgeDetection45DegreeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new EdgeDetection45DegreeFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void edgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new EdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void horizontalEdgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new HorizontalEdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void verticalEdgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new VerticalEdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void edgeDetectionTopLeftBottomRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new EdgeDetectionTopLeftBottomRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void blur5x5FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Blur5x5Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void gaussian3x3BlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Gaussian3x3BlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void gaussian5x5BlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Gaussian5x5BlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new MotionBlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurLeftToRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new MotionBlurLeftToRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurRightToLeftFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(checkOriginalPhoto())
            {
                ConvolutionFilters filter = new MotionBlurRightToLeftFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);

            }
        }

        private void softenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkOriginalPhoto())
            {
                ConvolutionFilters filter = new SoftenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);

            }
        }

        private void sharpenFilterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new SharpenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen3x3FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Sharpen3x3Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen3x3FactorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Sharpen3x3FactorFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen5x5FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Sharpen5x5Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void intenseSharpenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new IntenseSharpenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void embossFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new EmbossFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void emboss45DegreeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new Emboss45DegreeFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void embossTopLeftBottomRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new EmbossTopLeftBottomRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void intenseEmbossFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new IntenseEmbossFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void highPassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                ConvolutionFilters filter = new HighPassFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void makeEditedPhotoCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editedPhoto.Image != null)
            {
                originalImage.Image = editedPhoto.Image;
                imageProcessing.originalBitmap = (Bitmap)editedPhoto.Image;
                editedPhoto.Image = null;
            }

            else
            {
                MessageBox.Show("You have no edited image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
