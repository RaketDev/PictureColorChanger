using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureColorCalculator
{
    public partial class PCCalc : Form
    {
        public PCCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Image originalImage;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            originalImage = Image.FromFile(ofd.FileName);
            pictureBoxOriginal.Image = originalImage;

            Bitmap redmap = RGBColorChanger(originalImage, "red");
            pictureBoxRed.Image = redmap;
            Bitmap greenmap = RGBColorChanger(originalImage, "green");
            pictureBoxGreen.Image = greenmap;
            Bitmap bluemap = RGBColorChanger(originalImage, "blue");
            pictureBoxBlue.Image = bluemap;

            Bitmap Ymap = YColorChanger(originalImage);
            pictureBoxY.Image = Ymap;

            Bitmap YCCmap = YCColorChanger(originalImage, (byte)numericUpDown1.Value);
            pictureBoxResult.Image = YCCmap;
        }

        private Bitmap RGBColorChanger(Image img, string color)
        {
            Bitmap bmp = new Bitmap(img);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pxl = bmp.GetPixel(x, y);
                    switch (color)
                    {
                        case "red":
                            Color redcolor = Color.FromArgb(pxl.A, pxl.R, 0, 0);
                            bmp.SetPixel(x, y, redcolor);
                            break;

                        case "green":
                            Color greencolor = Color.FromArgb(pxl.A, 0, pxl.G, 0);
                            bmp.SetPixel(x, y, greencolor);
                            break;

                        case "blue":
                            Color bluecolor = Color.FromArgb(pxl.A, 0, 0, pxl.B);
                            bmp.SetPixel(x, y, bluecolor);
                            break;

                    }
                }
            }

            return bmp;
        }

        private Bitmap YColorChanger(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pxl = bmp.GetPixel(x, y);
                    var Yd = (int)Math.Round(.299 * pxl.R + .587 * pxl.G + .114 * pxl.B);
                    if (Yd > 255) Yd = 255;
                    if (Yd < 0) Yd = 0;
                    bmp.SetPixel(x, y, Color.FromArgb(pxl.A, Yd, Yd, Yd));
                }
            }

            return bmp;
        }
        private Bitmap YCColorChanger(Image img, byte bitdepth)
        {
            Bitmap bmp = new Bitmap(img);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pxl = bmp.GetPixel(x, y);
                    var Yd = (int)Math.Round(.299 * pxl.R + .587 * pxl.G + .114 * pxl.B);
                    if (Yd > 255) Yd = 255;
                    if (Yd < 0) Yd = 0;

                    double Crd = pxl.R - Yd;
                    double Cbd = pxl.B - Yd;

                    byte Cr = (byte)(bitdepth * Crd / 255);
                    byte Cb = (byte)(bitdepth * Cbd / 255);
                    byte Y = (byte)Yd;

                    byte r = (byte)((255.0 * Cr / bitdepth) + Y);
                    byte b = (byte)((255.0 * Cb / bitdepth) + Y);
                    byte g = (byte)((Y - (.3 * r + .1 * b)) / .6);

                    bmp.SetPixel(x, y, Color.FromArgb(pxl.A, r, g, b));



                    //bmp.SetPixel(x, y, Color.FromArgb(pxl.A, Yd, Yd, Yd));



                }
            }

            return bmp;
        }


    }
}
