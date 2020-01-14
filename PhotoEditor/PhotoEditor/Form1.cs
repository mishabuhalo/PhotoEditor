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
            string fileName = openFileDialog.FileName.Replace(@"\","\\");


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
                switch(optionsList.Text)
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
                    case "EdgeDetectionFilter":
                        {
                            ConvolutionFilters filter = new EdgeDetectionFilter();
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
                    editedPhoto.Image.Save(saveFileDialog.FileName,  System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Unnable to save the photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
