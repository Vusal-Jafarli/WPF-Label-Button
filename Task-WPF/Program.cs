namespace Task_WPF
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new Changable_Images());
            //Application.Run(new Label());
        }
    }
}