using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imgNumber = 1, img1, img2, img3, img4, img5, img6, img7;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void LoadNextImage()
        {
            if (imgNumber == 10)
            {
                imgNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imgNumber);

            if (imgNumber == 1) img1 = 8;
            else if (imgNumber == 2) img1 = 9;
            else if (imgNumber == 3) img1 = 10;
            else img1 = imgNumber - 3;
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", img1);

            if (imgNumber == 1) img2 = 9;
            else if (imgNumber == 2) img2 = 10;
            else img2 = imgNumber - 2;
            pictureBox2.ImageLocation = string.Format(@"Images\{0}.jpg", img2);

            if (imgNumber == 1) img3 = 10;
            else img3 = imgNumber - 1;
            pictureBox3.ImageLocation = string.Format(@"Images\{0}.jpg", img3);

            img4 = imgNumber;
            pictureBox4.ImageLocation = string.Format(@"Images\{0}.jpg", img4);

            if (imgNumber == 10) img5 = 1;
            else img5 = imgNumber + 1;
            pictureBox5.ImageLocation = string.Format(@"Images\{0}.jpg", img5);

            if (imgNumber == 10) img6 = 2;
            else if (imgNumber == 9) img6 = 1;
            else img6 = imgNumber + 2;
            pictureBox6.ImageLocation = string.Format(@"Images\{0}.jpg", img6);

            if (imgNumber == 10) img7 = 3;
            else if (imgNumber == 9) img7 = 2;
            else if (imgNumber == 8) img7 = 1;
            else img7 = imgNumber + 3;
            pictureBox7.ImageLocation = string.Format(@"Images\{0}.jpg", img7);

            imgNumber++;

        }
    }
}
