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
                MessageBox.Show("You should open photo first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
 

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Image Files(*.jpg)|*.jpg|Image Files(*.bmp)|*.bmp|Image Files(*.gif)|*.gif|Image Files(*.png)|*.png|All files (*.*)|*.*";
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
                MessageBox.Show("There are no edited image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                filterNameTextBox.Text = blur3x3FilterToolStripMenuItem.Text;
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkOriginalPhoto())
            {
                imageProcessing.editedBitmap = null;
                filterNameTextBox.Text = blackAndWhiteToolStripMenuItem.Text;
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
                filterNameTextBox.Text = pixelArtToolStripMenuItem.Text;
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
                filterNameTextBox.Text = oilPaintingToolStripMenuItem.Text;
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
                filterNameTextBox.Text = negativeToolStripMenuItem.Text;
                imageProcessing.editedBitmap = Negative.Edit(imageProcessing.originalBitmap);

                if (imageProcessing.editedBitmap != null)
                    editedPhoto.Image = (Image)imageProcessing.editedBitmap;
            }
        }

        private void edgeDetection45DegreeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = edgeDetection45DegreeFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new EdgeDetection45DegreeFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void edgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = edgeDetectionFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new EdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void horizontalEdgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = horizontalEdgeDetectionFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new HorizontalEdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void verticalEdgeDetectionFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = verticalEdgeDetectionFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new VerticalEdgeDetectionFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void edgeDetectionTopLeftBottomRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = edgeDetectionTopLeftBottomRightFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new EdgeDetectionTopLeftBottomRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void blur5x5FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = blur5x5FilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Blur5x5Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void gaussian3x3BlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = gaussian3x3BlurFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Gaussian3x3BlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void gaussian5x5BlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = gaussian5x5BlurFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Gaussian5x5BlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = motionBlurFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new MotionBlurFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurLeftToRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = motionBlurLeftToRightFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new MotionBlurLeftToRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void motionBlurRightToLeftFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(checkOriginalPhoto())
            {
                filterNameTextBox.Text = motionBlurRightToLeftFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new MotionBlurRightToLeftFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);

            }
        }

        private void softenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkOriginalPhoto())
            {
                filterNameTextBox.Text = softenFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new SoftenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);

            }
        }

        private void sharpenFilterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = sharpenFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new SharpenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen3x3FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = sharpen3x3FilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Sharpen3x3Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen3x3FactorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = sharpen3x3FactorFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Sharpen3x3FactorFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void sharpen5x5FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = sharpen5x5FilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Sharpen5x5Filter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void intenseSharpenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = intenseSharpenFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new IntenseSharpenFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void embossFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = embossFiltersToolStripMenuItem.Text;
                ConvolutionFilters filter = new EmbossFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void emboss45DegreeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = emboss45DegreeFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new Emboss45DegreeFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void embossTopLeftBottomRightFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = embossTopLeftBottomRightFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new EmbossTopLeftBottomRightFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void intenseEmbossFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = intenseEmbossFilterToolStripMenuItem.Text;
                ConvolutionFilters filter = new IntenseEmbossFilter();
                editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
            }
        }

        private void highPassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkOriginalPhoto())
            {
                filterNameTextBox.Text = highPassFilterToolStripMenuItem.Text;
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
                filterNameTextBox.Text = "Please choose filter";
            }

            else
            {
                MessageBox.Show("You have no edited image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            imageProcessing.originalBitmap = (Bitmap)originalImage.Image;
            if (checkOriginalPhoto())
            {
                oilPaintingToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
