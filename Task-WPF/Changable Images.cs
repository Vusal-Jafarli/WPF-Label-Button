using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_WPF
{
    public partial class Changable_Images : Form
    {
        bool country = true;
        public Changable_Images()
        {
            Image image = Image.FromFile("..\\..\\..\\Images\\baku.jpg");
            BackgroundImage = image;
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void London_click(object? sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("..\\..\\..\\Images\\london2.jpg");
            BackgroundImage = image;
            country = false;
        }

        private void Baku_click(object? sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("..\\..\\..\\Images\\baku.jpg");
            BackgroundImage = image;
            country = true;
        }

        private void Changable_Images_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {

            if (country)
                label1.Text = DateTime.Now.ToLongTimeString();
            else
                label1.Text = DateTime.Now.AddHours(Convert.ToDouble(-3)).ToLongTimeString();
        }
    }
}
