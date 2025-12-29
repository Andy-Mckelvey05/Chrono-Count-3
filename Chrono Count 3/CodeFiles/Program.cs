using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp;

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
            string dataPath = Path.Combine(Environment.CurrentDirectory, "Data.csv");
            string settingsPath = Path.Combine(Environment.CurrentDirectory, "UserSettings.json");

            UserSettings userSettings = new(settingsPath);
            TimeStampHandler timeStampHandler = new(userSettings, dataPath);

            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm(userSettings, timeStampHandler));
        }
    }
}