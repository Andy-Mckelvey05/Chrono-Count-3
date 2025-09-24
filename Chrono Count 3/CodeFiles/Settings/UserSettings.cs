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

        public UserSettings(string settingsPath) 
        {
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
                MessageBox.Show("Failed to Load Settings, Setting to Defaults");
                using (StreamWriter writeSettings = new(settingsPath))
                {
                    writeSettings.WriteLine(GetDefaultJSON());
                }
                ReadSettingsJSON(settingsPath);
            }
        }
        public void WriteSettingsJSON(string settingsPath)
        {
            using (StreamWriter writeSettings = new(settingsPath))
            {
                writeSettings.WriteLine(GetSettingsJSON());
            }
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
        private string GetSettingsJSON() 
        {
            UserSettingDto settings = new UserSettingDto
            {
                itemsPerPageDTO = itemsPerPage,
                colourSchemeDTO = colourScheme,
                defaultLengthDTO = defaultLength,
                descSizeDTO = descSize,
                dateSizeDTO = dateSize,
                timeSizeDTO = timeSize
            };
            return JsonSerializer.Serialize(settings);
        }
        private string GetDefaultJSON()
        {
            UserSettingDto settings = new UserSettingDto
            {
                itemsPerPageDTO = 10,
                colourSchemeDTO =
                [
                    [76, 116, 212],
                    [128, 128, 255],
                    [160, 204, 250]
                ],
                defaultLengthDTO = 718,
                descSizeDTO = LengthOptions.Medium,
                dateSizeDTO = LengthOptions.Medium,
                timeSizeDTO = LengthOptions.Medium
            };
            return JsonSerializer.Serialize(settings);
        }
    }
}
