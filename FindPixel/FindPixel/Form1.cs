using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void BtnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp, *.jpg) | *.bmp;*.jpg";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                this.PictureBoxOriginal.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void BtnFindObject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp, *.jpg) | *.bmp;*.jpg";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                this.PictureBoxFind.Image = new Bitmap(openFileDialog.FileName);
            }
        }


    }
}
