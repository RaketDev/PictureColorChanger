using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureColorLabel
{
    public partial class PCLGUI : Form
    {
        public PCLGUI()
        {
            InitializeComponent();
        }
        private Image img;
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img = Image.FromFile(ofd.FileName);
            pictureBox.Image = img;
        }
        private void labelRed_Click(object sender, EventArgs e)
        {
            labelRed.Enabled = false;
            labelGreen.Enabled = true;
            labelBlue.Enabled = true;
            LabelGray.Enabled = true;
            ChangeLabel(img, (int)RGBValue.Value, 0, 0);
        }

        private void labelGreen_Click(object sender, EventArgs e)
        {
            labelGreen.Enabled = false;
            labelRed.Enabled = true;
            labelBlue.Enabled = true;
            LabelGray.Enabled = true;
            ChangeLabel(img, 0, (int)RGBValue.Value, 0);
        }

        private void labelBlue_Click(object sender, EventArgs e)
        {
            labelBlue.Enabled = false;
            labelRed.Enabled = true;
            labelGreen.Enabled = true;
            LabelGray.Enabled = true;
            ChangeLabel(img, 0, 0, (int)RGBValue.Value);
        }

        private void ChangeLabel(Image img, int red, int green, int blue)
        {
            Bitmap bmp = new Bitmap(img);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    int newRed = bmp.GetPixel(x, y).R + red;
                    int newGreen = bmp.GetPixel(x, y).G + green;
                    int newBlue = bmp.GetPixel(x, y).B + blue;

                    if (newRed >= 255) newRed = 255;
                    if (newGreen >= 255) newGreen = 255;
                    if (newBlue >= 255) newBlue = 255;

                    Color color = Color.FromArgb(bmp.GetPixel(x, y).A,newRed, newGreen, newBlue);
                    bmp.SetPixel(x, y, color);
                }
            }
            pictureBox.Image = bmp;
        } 

        private void BlackwhiteLabel(Image img)
        {
            Bitmap bmp = new Bitmap(img);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    int newRed = bmp.GetPixel(x, y).R;
                    int newGreen = bmp.GetPixel(x, y).G;
                    int newBlue = bmp.GetPixel(x, y).B;

                    //int newColor = (newRed + newGreen + newBlue) / 3;
                    //Color color = Color.FromArgb(bmp.GetPixel(x, y).A,newColor, newColor, newColor);
                    //bmp.SetPixel(x, y, color);

                    var c = bmp.GetPixel(x, y);
                    var rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    bmp.SetPixel(x, y, Color.FromArgb(c.A, rgb, rgb, rgb));
                }
            }
            pictureBox.Image = bmp;
        }

        private void LabelGray_Click(object sender, EventArgs e)
        {
            labelBlue.Enabled = true;
            labelRed.Enabled = true;
            labelGreen.Enabled = true;
            LabelGray.Enabled = false;
            BlackwhiteLabel(img);
        }
    }
}
