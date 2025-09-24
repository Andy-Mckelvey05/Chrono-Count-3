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
            string dataPath = $@"{Environment.CurrentDirectory}\Data.csv";
            string settingsPath = $@"{Environment.CurrentDirectory}\UserSettings.json";

            UserSettings userSettings = new UserSettings(settingsPath);
            TimeStampHandler timeStampHandler = new TimeStampHandler(userSettings, dataPath);        

            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm(userSettings, timeStampHandler));
        }
    }
}