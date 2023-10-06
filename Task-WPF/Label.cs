using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Task_WPF
{
    public partial class Label : Form
    {
        Point head;
        Point end;
        bool hover = false;
        int size_x = 0;
        int size_y = 0;
        public Label()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            size_x = 0;
            size_y = 0;
            if (e.Button == MouseButtons.Left)
            {
                hover = true;
                head.X = e.X;
                head.Y = e.Y;
            }

        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (hover == true)
            {
                hover = false;
                end.X = e.X;
                end.Y = e.Y;
                int position_x = 10, position_y = 10;


                if (head.X < end.X) //Duz hisse
                {
                    if (head.Y < end.Y)
                    {
                        position_x = head.X;
                        position_y = head.Y;
                        size_x = end.X - head.X;
                        size_y = end.Y - head.Y;
                    }
                    else
                    {
                        position_x = head.X;
                        position_y = end.Y;

                        size_x = end.X - head.X;
                        size_y = head.Y - end.Y;
                    }
                }
                else //eks terefe
                {
                    if (end.Y < head.Y)
                    {
                        position_x = end.X;
                        position_y = end.Y;

                        size_x = head.X - end.X;
                        size_y = head.Y - end.Y;
                    }
                    else
                    {
                        position_x = end.X;
                        position_y = end.Y - (end.Y - head.Y);

                        size_x = head.X - end.X;
                        size_y = end.Y - head.Y;

                    }
                }


                System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
                Controls.Add(label1);
                label1.Location = new Point(position_x, position_y);
                label1.Size = new Size(size_x, size_y);
                label1.BackColor = Color.Blue;
                label1.MouseClick += Label1_MouseClick;
                label1.MouseDoubleClick += Label1_MouseDoubleClick;
            }
        }

        private void Label1_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label? new_label = sender as Label;
                if (new_label != null)
                {
                    Controls.Remove(new_label);
                    new_label.Dispose();
                }
            }
        }

        private void Label1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label? new_label = sender as Label;

                MessageBox.Show($"{new_label.Location.X}{new_label.Location.Y}\nSahe:{new_label.Size}");
            }
        }
    }
}
