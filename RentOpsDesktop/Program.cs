namespace RentOpsDesktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Landing screen = new Landing();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            Application.Run(screen);

        }
    }
}