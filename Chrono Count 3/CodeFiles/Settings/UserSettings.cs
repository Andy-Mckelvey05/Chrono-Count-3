using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;
using System.Text.Json;

namespace Chrono_Count_3.CodeFiles.Settings
{
    public class UserSettings
    {
        private readonly string settingsPath;

        private int itemsPerPage;
        private int[][] colourScheme;
        private LengthOptions descSize;
        private LengthOptions dateSize;
        private LengthOptions timeSize;
        
        public UserSettings(string settingsPath) 
        {
            this.settingsPath = settingsPath;
            ReadSettingsJSON(settingsPath);
        }

        public int ItemsPerPage { get { return itemsPerPage; }}
        public int[][] ColourScheme { get { return colourScheme!; } }
        public LengthOptions DescSize { get { return descSize; } }
        public LengthOptions DateSize { get { return dateSize; } }
        public LengthOptions TimeSize { get { return timeSize; } }

        public void ReadSettingsJSON(string settingsPath)
        {
            if (!File.Exists(settingsPath))
            {
                string defaultJson = GetDefaultJSON();
                File.WriteAllText(settingsPath, defaultJson);
                SetSettingsJSON(defaultJson);
                return;
            }
            try
            {
                string json = File.ReadAllText(settingsPath);
                SetSettingsJSON(json);
            }
            catch
            {
                MessageBox.Show("Failed to Load Settings, Setting to Defaults", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string defaultJson = GetDefaultJSON();
                File.WriteAllText(settingsPath, defaultJson);
                SetSettingsJSON(defaultJson);
            }
        }
        public void WriteSettingsJSON(UserSettingDto x)
        {
            string json = JsonSerializer.Serialize(x);
            File.WriteAllText(settingsPath, json);

            string exePath = Application.ExecutablePath;
            System.Diagnostics.Process.Start(exePath);
            Application.Exit();
        }

        private void SetSettingsJSON(string JSON)
        {
            UserSettingDto settings = JsonSerializer.Deserialize<UserSettingDto>(JSON)! ?? throw new InvalidOperationException("Failed to parse settings JSON.");
            itemsPerPage = settings.itemsPerPageDTO;
            colourScheme = settings.colourSchemeDTO;
            descSize = settings.descSizeDTO;
            dateSize = settings.dateSizeDTO;
            timeSize = settings.timeSizeDTO;
        }
        private string GetDefaultJSON()
        {
            return JsonSerializer.Serialize(GetDefaultSettings());
        }

        public UserSettingDto GetDefaultSettings()
        {
            UserSettingDto settings = new UserSettingDto
            {
                itemsPerPageDTO = 5,
                colourSchemeDTO =
                [
                    [128, 128, 255],
                    [160, 204, 250],
                    [76, 116, 212],
                ],
                descSizeDTO = LengthOptions.Medium,
                dateSizeDTO = LengthOptions.Medium,
                timeSizeDTO = LengthOptions.Medium
            };
            return settings;
        }
    }
}
