using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;
using System.Text.Json;

namespace Chrono_Count_3.CodeFiles.Settings
{
    class UserSettings
    {
        // Static Veribles (Accessed by the rest of the programme)
        private static int itemsPerPage;
        private static int[][] colourScheme;
        private static int defaultLength;

        private static LengthOptions descSize;
        private static LengthOptions dateSize;
        private static LengthOptions timeSize;

        private static readonly LengthOptions[] lengthOptions = (LengthOptions[])Enum.GetValues(typeof(LengthOptions));
        public static LengthOptions[] LengthOptionsList => lengthOptions;

        public UserSettings(string settingsPath) 
        {
            ReadSettingsJSON(settingsPath);
        }

        // Getters For Static Usersettings
        public static int ItemsPerPage { get { return itemsPerPage; }}
        public static int[][] ColourScheme { get { return colourScheme!; } }
        public static int DefaultLength { get { return defaultLength; } }
        public static LengthOptions DescSize { get { return descSize; } }
        public static LengthOptions DateSize { get { return dateSize; } }
        public static LengthOptions TimeSize { get { return timeSize; } }

        public static void ReadSettingsJSON(string settingsPath)
        {
            try
            {
                string json;
                using (var readSettings = new StreamReader(settingsPath))
                {
                    json = readSettings.ReadToEnd() ?? GetDefaultJSON();
                };
                SetSettingsJSON(json);
            }
            catch // Sets to default Settings if any issues occur
            {
                using (StreamWriter writeSettings = new(settingsPath))
                {
                    writeSettings.WriteLine(GetDefaultJSON());
                };
                ReadSettingsJSON(settingsPath);
            }
        }
        public static void WriteSettingsJSON(string settingsPath)
        {
            using (StreamWriter writeSettings = new(settingsPath))
            {
                writeSettings.WriteLine(GetSettingsJSON());
            };
        }

        private static void SetSettingsJSON(string JSON)
        {
            UserSettingDto settings = JsonSerializer.Deserialize<UserSettingDto>(JSON)!;

            itemsPerPage = settings.itemsPerPageDTO;
            colourScheme = settings.colourSchemeDTO;
            defaultLength = settings.defaultLengthDTO;
            descSize = settings.descSizeDTO;
            dateSize = settings.dateSizeDTO;
            timeSize = settings.timeSizeDTO;
        }
        private static string GetSettingsJSON() 
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
        private static string GetDefaultJSON()
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
