namespace malovani2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonCurrentColor = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.buttonDottedLine = new System.Windows.Forms.PictureBox();
            this.buttonDashLine = new System.Windows.Forms.PictureBox();
            this.buttonSolidLine = new System.Windows.Forms.PictureBox();
            this.buttonCircle = new System.Windows.Forms.PictureBox();
            this.buttonSquare = new System.Windows.Forms.PictureBox();
            this.buttonLine = new System.Windows.Forms.PictureBox();
            this.buttonRectangle = new System.Windows.Forms.PictureBox();
            this.buttonEllipse = new System.Windows.Forms.PictureBox();
            this.buttonErase = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.PictureBox();
            this.buttonColorPick = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDottedLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSolidLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonErase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonColorPick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonDottedLine);
            this.panel1.Controls.Add(this.buttonDashLine);
            this.panel1.Controls.Add(this.buttonSolidLine);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.buttonBlue);
            this.panel1.Controls.Add(this.buttonBlack);
            this.panel1.Controls.Add(this.buttonGreen);
            this.panel1.Controls.Add(this.buttonWhite);
            this.panel1.Controls.Add(this.buttonOrange);
            this.panel1.Controls.Add(this.buttonYellow);
            this.panel1.Controls.Add(this.buttonRed);
            this.panel1.Controls.Add(this.buttonPink);
            this.panel1.Controls.Add(this.buttonCurrentColor);
            this.panel1.Controls.Add(this.buttonCircle);
            this.panel1.Controls.Add(this.buttonSquare);
            this.panel1.Controls.Add(this.buttonLine);
            this.panel1.Controls.Add(this.buttonRectangle);
            this.panel1.Controls.Add(this.buttonEllipse);
            this.panel1.Controls.Add(this.buttonErase);
            this.panel1.Controls.Add(this.buttonDraw);
            this.panel1.Controls.Add(this.buttonColorPick);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 109);
            this.panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(699, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(119, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(824, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 31);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Uložit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(824, 57);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 31);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Smazat";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCurrentColor
            // 
            this.buttonCurrentColor.BackColor = System.Drawing.Color.Black;
            this.buttonCurrentColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentColor.Location = new System.Drawing.Point(554, 16);
            this.buttonCurrentColor.Name = "buttonCurrentColor";
            this.buttonCurrentColor.Size = new System.Drawing.Size(35, 32);
            this.buttonCurrentColor.TabIndex = 5;
            this.buttonCurrentColor.UseVisualStyleBackColor = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(731, 64);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(55, 16);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Velikost";
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPink.Location = new System.Drawing.Point(673, 54);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(20, 20);
            this.buttonPink.TabIndex = 5;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonPink_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(647, 54);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(20, 20);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhite.Location = new System.Drawing.Point(621, 54);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(20, 20);
            this.buttonWhite.TabIndex = 5;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlack.Location = new System.Drawing.Point(595, 54);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(20, 20);
            this.buttonBlack.TabIndex = 5;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrange.Location = new System.Drawing.Point(673, 80);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(20, 20);
            this.buttonOrange.TabIndex = 5;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(595, 80);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(20, 20);
            this.buttonBlue.TabIndex = 5;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(647, 80);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(20, 20);
            this.buttonYellow.TabIndex = 5;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(621, 80);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(20, 20);
            this.buttonGreen.TabIndex = 5;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaint.Location = new System.Drawing.Point(0, 109);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(932, 503);
            this.pictureBoxPaint.TabIndex = 1;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // buttonDottedLine
            // 
            this.buttonDottedLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDottedLine.Image = global::malovani2.Properties.Resources.dotted_line;
            this.buttonDottedLine.Location = new System.Drawing.Point(432, 43);
            this.buttonDottedLine.Name = "buttonDottedLine";
            this.buttonDottedLine.Size = new System.Drawing.Size(99, 27);
            this.buttonDottedLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDottedLine.TabIndex = 7;
            this.buttonDottedLine.TabStop = false;
            this.buttonDottedLine.Click += new System.EventHandler(this.buttonDottedLine_Click);
            // 
            // buttonDashLine
            // 
            this.buttonDashLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashLine.Image = global::malovani2.Properties.Resources.dash2;
            this.buttonDashLine.Location = new System.Drawing.Point(432, 73);
            this.buttonDashLine.Name = "buttonDashLine";
            this.buttonDashLine.Size = new System.Drawing.Size(99, 27);
            this.buttonDashLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDashLine.TabIndex = 7;
            this.buttonDashLine.TabStop = false;
            this.buttonDashLine.Click += new System.EventHandler(this.buttonDashLine_Click);
            // 
            // buttonSolidLine
            // 
            this.buttonSolidLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSolidLine.Image = global::malovani2.Properties.Resources.solid_line;
            this.buttonSolidLine.Location = new System.Drawing.Point(432, 12);
            this.buttonSolidLine.Name = "buttonSolidLine";
            this.buttonSolidLine.Size = new System.Drawing.Size(99, 27);
            this.buttonSolidLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSolidLine.TabIndex = 7;
            this.buttonSolidLine.TabStop = false;
            this.buttonSolidLine.Click += new System.EventHandler(this.buttonSolidLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCircle.Image = global::malovani2.Properties.Resources.circle_icon_512x512_pk2vsfwo;
            this.buttonCircle.Location = new System.Drawing.Point(238, 32);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(50, 47);
            this.buttonCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.TabStop = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSquare.Image = global::malovani2.Properties.Resources.shape_square;
            this.buttonSquare.Location = new System.Drawing.Point(126, 32);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(50, 47);
            this.buttonSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.TabStop = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLine.Image = global::malovani2.Properties.Resources.line;
            this.buttonLine.Location = new System.Drawing.Point(350, 32);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(50, 47);
            this.buttonLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonLine.TabIndex = 4;
            this.buttonLine.TabStop = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRectangle.Image = global::malovani2.Properties.Resources.rectangle;
            this.buttonRectangle.Location = new System.Drawing.Point(182, 32);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(50, 47);
            this.buttonRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.TabStop = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEllipse.Image = global::malovani2.Properties.Resources.elipsa;
            this.buttonEllipse.Location = new System.Drawing.Point(294, 32);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(50, 47);
            this.buttonEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.TabStop = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonErase.Image = global::malovani2.Properties.Resources._254686;
            this.buttonErase.Location = new System.Drawing.Point(70, 32);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(50, 47);
            this.buttonErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonErase.TabIndex = 4;
            this.buttonErase.TabStop = false;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Image = global::malovani2.Properties.Resources.images;
            this.buttonDraw.Location = new System.Drawing.Point(14, 32);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(50, 47);
            this.buttonDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.TabStop = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonColorPick
            // 
            this.buttonColorPick.Image = global::malovani2.Properties.Resources.optical_light_spectrum_rainbow_gradient_background_electromagnetic_visible_color_spectrum_for_human_eye_color_scheme_from_infrared_to_ultraviolet_illustration_vector;
            this.buttonColorPick.Location = new System.Drawing.Point(595, 17);
            this.buttonColorPick.Name = "buttonColorPick";
            this.buttonColorPick.Size = new System.Drawing.Size(98, 31);
            this.buttonColorPick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonColorPick.TabIndex = 3;
            this.buttonColorPick.TabStop = false;
            this.buttonColorPick.Click += new System.EventHandler(this.buttonColorPick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 612);
            this.Controls.Add(this.pictureBoxPaint);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDottedLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDashLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSolidLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonErase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonColorPick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox buttonColorPick;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox buttonDraw;
        private System.Windows.Forms.PictureBox buttonLine;
        private System.Windows.Forms.PictureBox buttonRectangle;
        private System.Windows.Forms.PictureBox buttonEllipse;
        private System.Windows.Forms.PictureBox buttonErase;
        private System.Windows.Forms.Button buttonCurrentColor;
        private System.Windows.Forms.PictureBox buttonCircle;
        private System.Windows.Forms.PictureBox buttonSquare;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.PictureBox buttonSolidLine;
        private System.Windows.Forms.PictureBox buttonDottedLine;
        private System.Windows.Forms.PictureBox buttonDashLine;
    }
}

