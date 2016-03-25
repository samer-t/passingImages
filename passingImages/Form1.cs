using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace passingImages
{
    public partial class Form1 : Form
    {
        public static Image image;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image = pictureBox1.Image;
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changePicImage();
        }
        private void changePicImage()
        {
            pictureBox1.Image = Properties.Resources.personM2;
        }
    }
}
