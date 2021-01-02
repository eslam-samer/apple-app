using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int apple_point;
        int apple_missing;
        Random r = new Random();
        void apple_down (PictureBox apple , int speed)
        {
            if (apple.Top<=this.Height)
            {
                apple.Top += 10;
            }
            else
            {
                apple.Location = new Point((r.Next(100,this.Width - 80)),0);
                apple_missing++;
                label2.Text = "المفقود =" + apple_missing.ToString();
            }

            if (apple.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                apple.Location = new Point((r.Next(100, this.Width - 80)), 0);
                apple_point++;
                label1.Text = "التفاح =" + apple_point.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(pictureBox4.Left >= 0)
                {
                    pictureBox4.Left -= 5;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox4.Left <= this.Width - 80)
                {
                    pictureBox4.Left += 5;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            apple_down(pictureBox1, 6);
            apple_down(pictureBox2, 8);
            apple_down(pictureBox3, 10);

        }
    }
}
