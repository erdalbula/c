namespace TaschenRechner_1._0
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}