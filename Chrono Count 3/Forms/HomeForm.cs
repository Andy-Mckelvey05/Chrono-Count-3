using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.Forms;

namespace Chrono_Count_3
{
    public partial class HomeForm : Form
    {
        private readonly UserSettings userSettings;
        private readonly TimeStampHandler timeStampHandler;

        public HomeForm(UserSettings userSettings, TimeStampHandler timeStampHandler)
        {
            InitializeComponent();
            this.userSettings = userSettings;
            this.timeStampHandler = timeStampHandler;

            //timeStampHandler.AddTimeStamp("New Year's Day", new DateTime(2025, 1, 1));
            //timeStampHandler.AddTimeStamp("Valentine's Day", new DateTime(2025, 2, 14));
            //timeStampHandler.AddTimeStamp("Presidents' Day", new DateTime(2025, 2, 17));
            //timeStampHandler.AddTimeStamp("Easter Sunday", new DateTime(2025, 4, 20));
            //timeStampHandler.AddTimeStamp("Labour Day", new DateTime(2025, 5, 1));
            //timeStampHandler.AddTimeStamp("Independence Day", new DateTime(2025, 7, 4));
            //timeStampHandler.AddTimeStamp("Bastille Day", new DateTime(2025, 7, 14));
            //timeStampHandler.AddTimeStamp("Assumption Day", new DateTime(2025, 8, 15));
            //timeStampHandler.AddTimeStamp("Oktoberfest", new DateTime(2025, 9, 19));
            //timeStampHandler.AddTimeStamp("Columbus Day", new DateTime(2025, 10, 13));
            //timeStampHandler.AddTimeStamp("Halloween", new DateTime(2025, 10, 31));
            //timeStampHandler.AddTimeStamp("All Saints' Day", new DateTime(2025, 11, 1));
            //timeStampHandler.AddTimeStamp("Labor Day", new DateTime(2025, 9, 1));
            //timeStampHandler.AddTimeStamp("Veterans Day", new DateTime(2025, 11, 11));
            //timeStampHandler.AddTimeStamp("Thanksgiving", new DateTime(2025, 11, 27));
            //timeStampHandler.AddTimeStamp("Christmas Day", new DateTime(2025, 12, 25));
            //timeStampHandler.AddTimeStamp("Memorial Day", new DateTime(2025, 5, 2));
            //timeStampHandler.AddTimeStamp("St. Patrick's Day", new DateTime(2025, 3, 17));
            //timeStampHandler.AddTimeStamp("Boxing Day", new DateTime(2025, 12, 26));
            //timeStampHandler.AddTimeStamp("D-Day", new DateTime(2025, 6, 6));
            //timeStampHandler.AddTimeStamp("Flag Day", new DateTime(2025, 6, 14));
            //timeStampHandler.AddTimeStamp("Australia Day", new DateTime(2025, 1, 26));
            //timeStampHandler.AddTimeStamp("Father's Day", new DateTime(2025, 6, 15));
            //timeStampHandler.AddTimeStamp("Midsummer's Day", new DateTime(2025, 6, 24));
            //timeStampHandler.AddTimeStamp("Midsummer's Day", new DateTime(3025, 6, 24));

            timeStampHandler.DisplayItems(listbox_MainDisplay);
        }

        // Open Forms:
        private void button_OpenCreateForm_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
            //timeStampHandler.UpdateFile();
        }
        private void button_OpenRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            removeForm.ShowDialog();
        }
        private void button_OpenSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(userSettings);
            settingsForm.ShowDialog();
        }

        private void timer_GameTime_Tick(object sender, EventArgs e)
        {
            timeStampHandler.DisplayItems(listbox_MainDisplay);
        }
    }
}
