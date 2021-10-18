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
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            Image img = Image.FromFile(ofd.FileName);
            pictureBox.Image = img;
        }
        private void labelRed_Click(object sender, EventArgs e)
        {

        }

        private void labelGreen_Click(object sender, EventArgs e)
        {

        }

        private void labelBlue_Click(object sender, EventArgs e)
        {

        }

       
    }
}
