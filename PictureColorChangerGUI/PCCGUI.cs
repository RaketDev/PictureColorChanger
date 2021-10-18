using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureColorChangerGUI
{
    public partial class PCCGUI : Form
    {
        public PCCGUI()
        {
            InitializeComponent();
        }
        private int backRed = 0;
        private int backGreen = 0;
        private int backBlue = 0;

        private int imgRed = 0;
        private int imgGreen = 0;
        private int imgBlue = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.BackColor = Color.FromArgb(backRed, backGreen, backBlue);
        }
       
        private void colorBarRed_Scroll(object sender, EventArgs e)
        {
            backRed = colorBarRed.Value;
            pictureBox.BackColor = Color.FromArgb(backRed, backGreen, backBlue);
        }

        private void colorBarGreen_Scroll(object sender, EventArgs e)
        {
            backGreen = colorBarGreen.Value;
            pictureBox.BackColor = Color.FromArgb(backRed, backGreen, backBlue);
        }

        private void colorBarBlue_Scroll(object sender, EventArgs e)
        {
            backBlue = colorBarBlue.Value;
            pictureBox.BackColor = Color.FromArgb(backRed, backGreen, backBlue);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private Image img;

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img = Image.FromFile(ofd.FileName);
            pictureBox.Image = img;
            Bitmap bmp = new Bitmap(img);

        }

        private void imgBoxBlue_Scroll(object sender, EventArgs e)
        {
            imgBlue = imgBoxBlue.Value;
            changeColor(img);

        }

        private void imgBoxGreen_Scroll(object sender, EventArgs e)
        {
            imgGreen = imgBoxGreen.Value;
            changeColor(img);

        }

        private void imgBoxRed_Scroll(object sender, EventArgs e)
        {
            imgRed = imgBoxRed.Value;
            changeColor(img);
           
        } 
        private void changeColor(Image img)
        {
            Bitmap bmp = new Bitmap(img);
          

            for(int x = 0;x < bmp.Width;x++)
            {
                for(int y = 0;y < bmp.Height;y++)
                {
                    int oldRed;
                    int oldGreen;
                    int oldBlue;

                    if (!(bmp.GetPixel(x, y).R + imgRed >= 255))
                    {
                        oldRed = bmp.GetPixel(x, y).R + imgRed;
                    } else oldRed = 255;

                    if (!(bmp.GetPixel(x, y).G + imgGreen >= 255))
                    {
                        oldGreen = bmp.GetPixel(x, y).G + imgGreen;
                    } else oldGreen = 255;

                    if (!(bmp.GetPixel(x, y).B + imgBlue >= 255))
                    {
                        oldBlue = bmp.GetPixel(x, y).B + imgBlue;
                    } else oldBlue = 255;
                    Color color = Color.FromArgb(bmp.GetPixel(x, y).A,oldRed, oldGreen, oldBlue);
                    bmp.SetPixel(x, y, color);
                }
            }

            pictureBox.Image = bmp;
        }
    }
}
