namespace Chrono_Count_3.CodeFiles
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataPath = $@"{Environment.CurrentDirectory}\ChronoCount2.csv";
            string settingsPath = $@"{Environment.CurrentDirectory}\UserSettings.json";

            UserSettings userSettings = new UserSettings(settingsPath);

            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
        }
    }
}