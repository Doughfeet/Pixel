using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SaveFileDialog dialog = new SaveFileDialog();
        Bitmap firstPicture;
        Bitmap secondPicture;

        private void BtnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp, *.jpg) | *.bmp;*.jpg";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                this.PictureBoxOriginal.Image = new Bitmap(openFileDialog.FileName);
                firstPicture = (Bitmap)PictureBoxOriginal.Image;
            }
        }

        private void BtnFindObject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp, *.jpg) | *.bmp;*.jpg";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                this.PictureBoxFind.Image = new Bitmap(openFileDialog.FileName);
                secondPicture = (Bitmap)PictureBoxFind.Image;
            }
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            if (Processing.Compare(firstPicture, secondPicture))
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
