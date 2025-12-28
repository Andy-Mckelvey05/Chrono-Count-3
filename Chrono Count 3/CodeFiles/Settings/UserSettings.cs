using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;
using System.Text.Json;

namespace Chrono_Count_3.CodeFiles.Settings
{
    public class UserSettings
    {
        private int itemsPerPage;
        private int[][] colourScheme;
        private int defaultLength;
        private LengthOptions descSize;
        private LengthOptions dateSize;
        private LengthOptions timeSize;
        private string settingsPath;

        public UserSettings(string settingsPath) 
        {
            this.settingsPath = settingsPath;
            ReadSettingsJSON(settingsPath);
        }

        public int ItemsPerPage { get { return itemsPerPage; }}
        public int[][] ColourScheme { get { return colourScheme!; } }
        public int DefaultLength { get { return defaultLength; } }
        public LengthOptions DescSize { get { return descSize; } }
        public LengthOptions DateSize { get { return dateSize; } }
        public LengthOptions TimeSize { get { return timeSize; } }

        public void ReadSettingsJSON(string settingsPath)
        {
            try
            {
                string json;
                using (var readSettings = new StreamReader(settingsPath))
                {
                    json = readSettings.ReadToEnd() ?? GetDefaultJSON();
                }
                SetSettingsJSON(json);
            }
            catch // Sets to default Settings if any issues occur
            {
                MessageBox.Show("Failed to Load Settings, Setting to Defaults", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                using (StreamWriter writeSettings = new(settingsPath))
                {
                    writeSettings.WriteLine(GetDefaultJSON());
                }
                ReadSettingsJSON(settingsPath);
            }
        }
        public void WriteSettingsJSON(UserSettingDto x)
        {
            string json = JsonSerializer.Serialize(x);
            using (StreamWriter writeSettings = new(settingsPath))
            {
                writeSettings.WriteLine(json);
            }

            string exePath = Application.ExecutablePath;
            System.Diagnostics.Process.Start(exePath);
            Application.Exit();
        }

        private void SetSettingsJSON(string JSON)
        {
            UserSettingDto settings = JsonSerializer.Deserialize<UserSettingDto>(JSON)!;

            itemsPerPage = settings.itemsPerPageDTO;
            colourScheme = settings.colourSchemeDTO;
            defaultLength = settings.defaultLengthDTO;
            descSize = settings.descSizeDTO;
            dateSize = settings.dateSizeDTO;
            timeSize = settings.timeSizeDTO;
        }
        private string GetDefaultJSON()
        {
            UserSettingDto settings = new UserSettingDto
            {
                itemsPerPageDTO = 10,
                colourSchemeDTO =
                [
                    [128, 128, 255],
                    [160, 204, 250],
                    [76, 116, 212],
                ],
                defaultLengthDTO = 718,
                descSizeDTO = LengthOptions.Medium,
                dateSizeDTO = LengthOptions.Medium,
                timeSizeDTO = LengthOptions.Medium
            };
            return JsonSerializer.Serialize(settings);
        }

        public UserSettingDto GetDefaultSettings()
        {
            UserSettingDto settings = new UserSettingDto
            {
                itemsPerPageDTO = 10,
                colourSchemeDTO =
                [
                    [128, 128, 255],
                    [160, 204, 250],
                    [76, 116, 212],
                ],
                defaultLengthDTO = 718,
                descSizeDTO = LengthOptions.Medium,
                dateSizeDTO = LengthOptions.Medium,
                timeSizeDTO = LengthOptions.Medium
            };
            return settings;
        }
    }
}
