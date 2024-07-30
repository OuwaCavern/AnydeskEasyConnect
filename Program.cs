namespace AnydeskEasyConnect
{
    internal static class Program
    {
        private static bool basariliGiris = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            if (basariliGiris == true)
            {
                Application.Run(new MainScreen());
            }
        }

        public static void BasariliGirisiAyarla(bool value)
        {
            basariliGiris = value;
        }
    }
}