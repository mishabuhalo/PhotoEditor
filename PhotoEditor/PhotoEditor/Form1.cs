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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog.FileName.Replace(@"\", "\\");


            imageProcessing.LoadImage(fileName);

            if (imageProcessing.originalBitmap != null)
                originalImage.Image = Image.FromFile(fileName);
            else
            {
                MessageBox.Show("Unnable to load the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (originalImage.Image == null)
            {
                MessageBox.Show("Unnable to edit the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                switch (optionsList.Text)
                {
                    case "Black And White":
                        {
                            imageProcessing.editedBitmap = null;

                            imageProcessing.editedBitmap = BlackAndWhite.Edit(imageProcessing.originalBitmap);

                            if (imageProcessing.editedBitmap != null)
                                editedPhoto.Image = (Image)imageProcessing.editedBitmap;


                            break;
                        }
                    case "Pixel Art":
                        {
                            imageProcessing.editedBitmap = null;

                            imageProcessing.editedBitmap = PixelArt.Edit(imageProcessing.originalBitmap, 8);

                            if (imageProcessing.editedBitmap != null)
                                editedPhoto.Image = (Image)imageProcessing.editedBitmap;

                            break;
                        }
                    case "Edge Detection Filter":
                        {
                            ConvolutionFilters filter = new EdgeDetectionFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Edge Detection 45 Degree Filter":
                        {
                            ConvolutionFilters filter = new EdgeDetection45DegreeFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Horizontal Edge Detection Filter":
                        {
                            ConvolutionFilters filter = new HorizontalEdgeDetectionFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Vertical Edge Detection Filter":
                        {
                            ConvolutionFilters filter = new VerticalEdgeDetectionFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }

                    case "Edge Detection Top Left Bottom Right Filter":
                        {
                            ConvolutionFilters filter = new EdgeDetectionTopLeftBottomRightFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Blur 3x3 Filter":
                        {
                            ConvolutionFilters filter = new Blur3x3Filter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Blur 5x5 Filter":
                        {
                            ConvolutionFilters filter = new Blur5x5Filter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Gaussian 3x3 Blur Filter":
                        {
                            ConvolutionFilters filter = new Gaussian3x3BlurFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Gaussian 5x5 Blur Filter":
                        {
                            ConvolutionFilters filter = new Gaussian5x5BlurFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Motion Blur Filter":
                        {
                            ConvolutionFilters filter = new MotionBlurFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Motion Blur Left To Right Filter":
                        {
                            ConvolutionFilters filter = new MotionBlurLeftToRightFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Motion Blur Right To Left Filter":
                        {
                            ConvolutionFilters filter = new MotionBlurRightToLeftFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    case "Soften Filter":
                        {
                            ConvolutionFilters filter = new SoftenFilter();
                            editedPhoto.Image = imageProcessing.originalBitmap.ConvolutionMethod(filter);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Please choose editing option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editedPhoto.Image == null)
            {
                MessageBox.Show("Unnable to save the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveFileDialog.Filter = "Image Files(*.bmp)|*.bmp|Image Files(*.jpg)|*.jpg|Image Files(*.gif)|*.gif|Image Files(*.png)|*.png|All files (*.*)|*.*";
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
    }
}
