using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 5;
        int counter = 0;
        string[] images = null;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnimationFrame_Tick(object sender, EventArgs e)
        {
            images = Directory.GetFiles(@"C:\Users\User\Documents\GitHub\AnimationFramesPNG");
            pictureBox1.ImageLocation = images[counter++];
            if (counter >= images.Length) counter = 0;
                pictureBox1.Left += x;

            if (pictureBox1.Left + pictureBox1.Width > ClientSize.Width || pictureBox1.Left < 0)
            {
                x = -x;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
