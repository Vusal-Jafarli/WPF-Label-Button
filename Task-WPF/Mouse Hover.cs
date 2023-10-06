namespace Task_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_MouseHover(object sender, EventArgs e)
        {
            var my_label = sender as Label;

            Random x = new Random();
            Random y = new Random();
            my_label.Location = new Point(x.Next(816), y.Next(489));
        }
    }
}