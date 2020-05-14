namespace PhotoEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetection45DegreeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalEdgeDetectionFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalEdgeDetectionFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blur3x3FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blur5x5FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussian3x3BlurFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussian5x5BlurFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurLeftToRightFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurRightToLeftFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softenFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenFilterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpen3x3FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpen3x3FactorFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpen5x5FilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intenseSharpenFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emboss45DegreeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossTopLeftBottomRightFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intenseEmbossFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeEditedPhotoCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editedPhoto = new System.Windows.Forms.PictureBox();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editedPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openFileToolStripMenuItem.Text = "Open photo";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveFileToolStripMenuItem.Text = "Save photo";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackAndWhiteToolStripMenuItem,
            this.pixelArtToolStripMenuItem,
            this.oilPaintingToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.edgeDetectionFiltersToolStripMenuItem,
            this.blurFiltersToolStripMenuItem,
            this.motionBlurFiltersToolStripMenuItem,
            this.softenFilterToolStripMenuItem,
            this.sharpenFilterToolStripMenuItem,
            this.embossFiltersToolStripMenuItem,
            this.highPassFilterToolStripMenuItem,
            this.makeEditedPhotoCurrentToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton2.Text = "Filters";
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Black And White";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // pixelArtToolStripMenuItem
            // 
            this.pixelArtToolStripMenuItem.Name = "pixelArtToolStripMenuItem";
            this.pixelArtToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.pixelArtToolStripMenuItem.Text = "Pixel Art";
            this.pixelArtToolStripMenuItem.Click += new System.EventHandler(this.pixelArtToolStripMenuItem_Click);
            // 
            // oilPaintingToolStripMenuItem
            // 
            this.oilPaintingToolStripMenuItem.Name = "oilPaintingToolStripMenuItem";
            this.oilPaintingToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.oilPaintingToolStripMenuItem.Text = "Oil Painting";
            this.oilPaintingToolStripMenuItem.Click += new System.EventHandler(this.oilPaintingToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // edgeDetectionFiltersToolStripMenuItem
            // 
            this.edgeDetectionFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgeDetectionFilterToolStripMenuItem,
            this.edgeDetection45DegreeFilterToolStripMenuItem,
            this.horizontalEdgeDetectionFilterToolStripMenuItem,
            this.verticalEdgeDetectionFilterToolStripMenuItem,
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem});
            this.edgeDetectionFiltersToolStripMenuItem.Name = "edgeDetectionFiltersToolStripMenuItem";
            this.edgeDetectionFiltersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.edgeDetectionFiltersToolStripMenuItem.Text = "Edge Detection Filters";
            // 
            // edgeDetectionFilterToolStripMenuItem
            // 
            this.edgeDetectionFilterToolStripMenuItem.Name = "edgeDetectionFilterToolStripMenuItem";
            this.edgeDetectionFilterToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.edgeDetectionFilterToolStripMenuItem.Text = "Edge Detection Filter";
            this.edgeDetectionFilterToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionFilterToolStripMenuItem_Click);
            // 
            // edgeDetection45DegreeFilterToolStripMenuItem
            // 
            this.edgeDetection45DegreeFilterToolStripMenuItem.Name = "edgeDetection45DegreeFilterToolStripMenuItem";
            this.edgeDetection45DegreeFilterToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.edgeDetection45DegreeFilterToolStripMenuItem.Text = "Edge Detection 45 Degree Filter";
            this.edgeDetection45DegreeFilterToolStripMenuItem.Click += new System.EventHandler(this.edgeDetection45DegreeFilterToolStripMenuItem_Click);
            // 
            // horizontalEdgeDetectionFilterToolStripMenuItem
            // 
            this.horizontalEdgeDetectionFilterToolStripMenuItem.Name = "horizontalEdgeDetectionFilterToolStripMenuItem";
            this.horizontalEdgeDetectionFilterToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.horizontalEdgeDetectionFilterToolStripMenuItem.Text = "Horizontal Edge Detection Filter";
            this.horizontalEdgeDetectionFilterToolStripMenuItem.Click += new System.EventHandler(this.horizontalEdgeDetectionFilterToolStripMenuItem_Click);
            // 
            // verticalEdgeDetectionFilterToolStripMenuItem
            // 
            this.verticalEdgeDetectionFilterToolStripMenuItem.Name = "verticalEdgeDetectionFilterToolStripMenuItem";
            this.verticalEdgeDetectionFilterToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.verticalEdgeDetectionFilterToolStripMenuItem.Text = "Vertical Edge Detection Filter";
            this.verticalEdgeDetectionFilterToolStripMenuItem.Click += new System.EventHandler(this.verticalEdgeDetectionFilterToolStripMenuItem_Click);
            // 
            // edgeDetectionTopLeftBottomRightFilterToolStripMenuItem
            // 
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem.Name = "edgeDetectionTopLeftBottomRightFilterToolStripMenuItem";
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem.Text = "Edge Detection Top Left Bottom Right Filter";
            this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionTopLeftBottomRightFilterToolStripMenuItem_Click);
            // 
            // blurFiltersToolStripMenuItem
            // 
            this.blurFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blur3x3FilterToolStripMenuItem,
            this.blur5x5FilterToolStripMenuItem,
            this.gaussian3x3BlurFilterToolStripMenuItem,
            this.gaussian5x5BlurFilterToolStripMenuItem});
            this.blurFiltersToolStripMenuItem.Name = "blurFiltersToolStripMenuItem";
            this.blurFiltersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.blurFiltersToolStripMenuItem.Text = "Blur Filters";
            // 
            // blur3x3FilterToolStripMenuItem
            // 
            this.blur3x3FilterToolStripMenuItem.Name = "blur3x3FilterToolStripMenuItem";
            this.blur3x3FilterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.blur3x3FilterToolStripMenuItem.Text = "Blur 3x3 Filter";
            this.blur3x3FilterToolStripMenuItem.Click += new System.EventHandler(this.blur3x3FilterToolStripMenuItem_Click);
            // 
            // blur5x5FilterToolStripMenuItem
            // 
            this.blur5x5FilterToolStripMenuItem.Name = "blur5x5FilterToolStripMenuItem";
            this.blur5x5FilterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.blur5x5FilterToolStripMenuItem.Text = "Blur 5x5 Filter";
            this.blur5x5FilterToolStripMenuItem.Click += new System.EventHandler(this.blur5x5FilterToolStripMenuItem_Click);
            // 
            // gaussian3x3BlurFilterToolStripMenuItem
            // 
            this.gaussian3x3BlurFilterToolStripMenuItem.Name = "gaussian3x3BlurFilterToolStripMenuItem";
            this.gaussian3x3BlurFilterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gaussian3x3BlurFilterToolStripMenuItem.Text = "Gaussian 3x3 Blur Filter";
            this.gaussian3x3BlurFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussian3x3BlurFilterToolStripMenuItem_Click);
            // 
            // gaussian5x5BlurFilterToolStripMenuItem
            // 
            this.gaussian5x5BlurFilterToolStripMenuItem.Name = "gaussian5x5BlurFilterToolStripMenuItem";
            this.gaussian5x5BlurFilterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gaussian5x5BlurFilterToolStripMenuItem.Text = "Gaussian 5x5 Blur Filter";
            this.gaussian5x5BlurFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussian5x5BlurFilterToolStripMenuItem_Click);
            // 
            // motionBlurFiltersToolStripMenuItem
            // 
            this.motionBlurFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motionBlurFilterToolStripMenuItem,
            this.motionBlurLeftToRightFilterToolStripMenuItem,
            this.motionBlurRightToLeftFilterToolStripMenuItem});
            this.motionBlurFiltersToolStripMenuItem.Name = "motionBlurFiltersToolStripMenuItem";
            this.motionBlurFiltersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.motionBlurFiltersToolStripMenuItem.Text = "Motion Blur Filters";
            // 
            // motionBlurFilterToolStripMenuItem
            // 
            this.motionBlurFilterToolStripMenuItem.Name = "motionBlurFilterToolStripMenuItem";
            this.motionBlurFilterToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.motionBlurFilterToolStripMenuItem.Text = "Motion Blur Filter";
            this.motionBlurFilterToolStripMenuItem.Click += new System.EventHandler(this.motionBlurFilterToolStripMenuItem_Click);
            // 
            // motionBlurLeftToRightFilterToolStripMenuItem
            // 
            this.motionBlurLeftToRightFilterToolStripMenuItem.Name = "motionBlurLeftToRightFilterToolStripMenuItem";
            this.motionBlurLeftToRightFilterToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.motionBlurLeftToRightFilterToolStripMenuItem.Text = "Motion Blur Left To Right Filter";
            this.motionBlurLeftToRightFilterToolStripMenuItem.Click += new System.EventHandler(this.motionBlurLeftToRightFilterToolStripMenuItem_Click);
            // 
            // motionBlurRightToLeftFilterToolStripMenuItem
            // 
            this.motionBlurRightToLeftFilterToolStripMenuItem.Name = "motionBlurRightToLeftFilterToolStripMenuItem";
            this.motionBlurRightToLeftFilterToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.motionBlurRightToLeftFilterToolStripMenuItem.Text = "Motion Blur Right To Left Filter";
            this.motionBlurRightToLeftFilterToolStripMenuItem.Click += new System.EventHandler(this.motionBlurRightToLeftFilterToolStripMenuItem_Click);
            // 
            // softenFilterToolStripMenuItem
            // 
            this.softenFilterToolStripMenuItem.Name = "softenFilterToolStripMenuItem";
            this.softenFilterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.softenFilterToolStripMenuItem.Text = "Soften Filter";
            this.softenFilterToolStripMenuItem.Click += new System.EventHandler(this.softenFilterToolStripMenuItem_Click);
            // 
            // sharpenFilterToolStripMenuItem
            // 
            this.sharpenFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sharpenFilterToolStripMenuItem1,
            this.sharpen3x3FilterToolStripMenuItem,
            this.sharpen3x3FactorFilterToolStripMenuItem,
            this.sharpen5x5FilterToolStripMenuItem,
            this.intenseSharpenFilterToolStripMenuItem});
            this.sharpenFilterToolStripMenuItem.Name = "sharpenFilterToolStripMenuItem";
            this.sharpenFilterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sharpenFilterToolStripMenuItem.Text = "Sharpen Filter";
            // 
            // sharpenFilterToolStripMenuItem1
            // 
            this.sharpenFilterToolStripMenuItem1.Name = "sharpenFilterToolStripMenuItem1";
            this.sharpenFilterToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.sharpenFilterToolStripMenuItem1.Text = "Sharpen Filter";
            this.sharpenFilterToolStripMenuItem1.Click += new System.EventHandler(this.sharpenFilterToolStripMenuItem1_Click);
            // 
            // sharpen3x3FilterToolStripMenuItem
            // 
            this.sharpen3x3FilterToolStripMenuItem.Name = "sharpen3x3FilterToolStripMenuItem";
            this.sharpen3x3FilterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.sharpen3x3FilterToolStripMenuItem.Text = "Sharpen 3x3 Filter";
            this.sharpen3x3FilterToolStripMenuItem.Click += new System.EventHandler(this.sharpen3x3FilterToolStripMenuItem_Click);
            // 
            // sharpen3x3FactorFilterToolStripMenuItem
            // 
            this.sharpen3x3FactorFilterToolStripMenuItem.Name = "sharpen3x3FactorFilterToolStripMenuItem";
            this.sharpen3x3FactorFilterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.sharpen3x3FactorFilterToolStripMenuItem.Text = "Sharpen 3x3 Factor Filter";
            this.sharpen3x3FactorFilterToolStripMenuItem.Click += new System.EventHandler(this.sharpen3x3FactorFilterToolStripMenuItem_Click);
            // 
            // sharpen5x5FilterToolStripMenuItem
            // 
            this.sharpen5x5FilterToolStripMenuItem.Name = "sharpen5x5FilterToolStripMenuItem";
            this.sharpen5x5FilterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.sharpen5x5FilterToolStripMenuItem.Text = "Sharpen 5x5 Filter";
            this.sharpen5x5FilterToolStripMenuItem.Click += new System.EventHandler(this.sharpen5x5FilterToolStripMenuItem_Click);
            // 
            // intenseSharpenFilterToolStripMenuItem
            // 
            this.intenseSharpenFilterToolStripMenuItem.Name = "intenseSharpenFilterToolStripMenuItem";
            this.intenseSharpenFilterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.intenseSharpenFilterToolStripMenuItem.Text = "Intense Sharpen Filter";
            this.intenseSharpenFilterToolStripMenuItem.Click += new System.EventHandler(this.intenseSharpenFilterToolStripMenuItem_Click);
            // 
            // embossFiltersToolStripMenuItem
            // 
            this.embossFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embossFilterToolStripMenuItem,
            this.emboss45DegreeFilterToolStripMenuItem,
            this.embossTopLeftBottomRightFilterToolStripMenuItem,
            this.intenseEmbossFilterToolStripMenuItem});
            this.embossFiltersToolStripMenuItem.Name = "embossFiltersToolStripMenuItem";
            this.embossFiltersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.embossFiltersToolStripMenuItem.Text = "Emboss Filters";
            // 
            // embossFilterToolStripMenuItem
            // 
            this.embossFilterToolStripMenuItem.Name = "embossFilterToolStripMenuItem";
            this.embossFilterToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.embossFilterToolStripMenuItem.Text = "Emboss Filter";
            this.embossFilterToolStripMenuItem.Click += new System.EventHandler(this.embossFilterToolStripMenuItem_Click);
            // 
            // emboss45DegreeFilterToolStripMenuItem
            // 
            this.emboss45DegreeFilterToolStripMenuItem.Name = "emboss45DegreeFilterToolStripMenuItem";
            this.emboss45DegreeFilterToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.emboss45DegreeFilterToolStripMenuItem.Text = "Emboss 45 Degree Filter";
            this.emboss45DegreeFilterToolStripMenuItem.Click += new System.EventHandler(this.emboss45DegreeFilterToolStripMenuItem_Click);
            // 
            // embossTopLeftBottomRightFilterToolStripMenuItem
            // 
            this.embossTopLeftBottomRightFilterToolStripMenuItem.Name = "embossTopLeftBottomRightFilterToolStripMenuItem";
            this.embossTopLeftBottomRightFilterToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.embossTopLeftBottomRightFilterToolStripMenuItem.Text = "Emboss Top Left Bottom Right Filter";
            this.embossTopLeftBottomRightFilterToolStripMenuItem.Click += new System.EventHandler(this.embossTopLeftBottomRightFilterToolStripMenuItem_Click);
            // 
            // intenseEmbossFilterToolStripMenuItem
            // 
            this.intenseEmbossFilterToolStripMenuItem.Name = "intenseEmbossFilterToolStripMenuItem";
            this.intenseEmbossFilterToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.intenseEmbossFilterToolStripMenuItem.Text = "Intense Emboss Filter";
            this.intenseEmbossFilterToolStripMenuItem.Click += new System.EventHandler(this.intenseEmbossFilterToolStripMenuItem_Click);
            // 
            // highPassFilterToolStripMenuItem
            // 
            this.highPassFilterToolStripMenuItem.Name = "highPassFilterToolStripMenuItem";
            this.highPassFilterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.highPassFilterToolStripMenuItem.Text = "High Pass Filter";
            this.highPassFilterToolStripMenuItem.Click += new System.EventHandler(this.highPassFilterToolStripMenuItem_Click);
            // 
            // makeEditedPhotoCurrentToolStripMenuItem
            // 
            this.makeEditedPhotoCurrentToolStripMenuItem.Name = "makeEditedPhotoCurrentToolStripMenuItem";
            this.makeEditedPhotoCurrentToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.makeEditedPhotoCurrentToolStripMenuItem.Text = "Make edited photo current";
            this.makeEditedPhotoCurrentToolStripMenuItem.Click += new System.EventHandler(this.makeEditedPhotoCurrentToolStripMenuItem_Click);
            // 
            // editedPhoto
            // 
            this.editedPhoto.Location = new System.Drawing.Point(467, 28);
            this.editedPhoto.Name = "editedPhoto";
            this.editedPhoto.Size = new System.Drawing.Size(265, 465);
            this.editedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editedPhoto.TabIndex = 1;
            this.editedPhoto.TabStop = false;
            // 
            // originalImage
            // 
            this.originalImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.originalImage.BackColor = System.Drawing.SystemColors.Control;
            this.originalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.originalImage.Location = new System.Drawing.Point(12, 28);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(265, 465);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.editedPhoto);
            this.Controls.Add(this.originalImage);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PhotoEditor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editedPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox editedPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelArtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oilPaintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetection45DegreeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalEdgeDetectionFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalEdgeDetectionFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionTopLeftBottomRightFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blur3x3FilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blur5x5FilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussian3x3BlurFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussian5x5BlurFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurLeftToRightFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurRightToLeftFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softenFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenFilterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sharpen3x3FilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpen3x3FactorFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpen5x5FilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intenseSharpenFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emboss45DegreeFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossTopLeftBottomRightFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intenseEmbossFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeEditedPhotoCurrentToolStripMenuItem;
    }
}

