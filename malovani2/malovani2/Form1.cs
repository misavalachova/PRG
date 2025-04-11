using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace malovani2
{
    public partial class Form1 : Form
    {
        bool isDrawing = false; //rozpozná, jestli právě kreslím nebo ne
        Point startPoint, endPoint, prevPoint;
        Bitmap bitmap;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.White, 10);
        int currentOption = 1; // 1 - tuzka, 2 - guma, 3 - elipsa, 4 - obdelnik, 5 - cara
        Color currentColor = Color.Black;


        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBoxPaint.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            eraser.Width = trackBar1.Value + 5;
        }

        private void buttonColorPick_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = dialog.Color;
                    currentColor = dialog.Color;
                    buttonCurrentColor.BackColor = currentColor;
                }
            }
            
        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            prevPoint = e.Location;
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (currentOption == 1) //tužka, volné kreslení
            {
                graphics.DrawLine(pen, prevPoint, e.Location);
                prevPoint = e.Location;
                pictureBoxPaint.Refresh();
            }
            else if (currentOption == 2) //guma
            {
                graphics.DrawLine(eraser, prevPoint, e.Location);
                prevPoint = e.Location;
                pictureBoxPaint.Refresh();
            }
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            endPoint = e.Location;

            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;

            

            switch (currentOption) // nakreslíme tvar podle zvoleného tlačítka
            {
                case 3:
                    graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, width, height);
                    break;
                case 4:
                    graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, width, height);
                    break;
                case 5:
                    graphics.DrawLine(pen, startPoint, endPoint);
                    break;
                case 6:
                    graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, width, width);
                    break;
                case 7:
                    graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, width, width);
                    break;

            }

            pictureBoxPaint.Refresh();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            currentOption = 1;
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            currentOption= 2;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            currentOption= 3;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currentOption= 4;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            currentOption= 5;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            buttonCurrentColor.BackColor = Color.Black;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            buttonCurrentColor.BackColor = Color.White;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            buttonCurrentColor.BackColor = Color.Red;
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Pink;
            buttonCurrentColor.BackColor = Color.Pink;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
            buttonCurrentColor.BackColor = Color.Blue;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
            buttonCurrentColor.BackColor = Color.Green;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            buttonCurrentColor.BackColor = Color.Yellow;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Orange;
            buttonCurrentColor.BackColor = Color.Orange;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            currentOption = 7;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            currentOption= 6;
        }

        private void buttonSolidLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Solid;
        }

        private void buttonDottedLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dot;
        }

        private void buttonDashLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dash;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PNG Image|*.png";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(save.FileName);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBoxPaint.Image = bitmap;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = 2;
            pen.DashStyle = DashStyle.Solid;
        }



    }
}
