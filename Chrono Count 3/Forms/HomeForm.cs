using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.Forms;

namespace Chrono_Count_3
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            TimeStampHandler.AddTimeStamp("New Year's Day", new DateTime(2025, 1, 1));
            TimeStampHandler.AddTimeStamp("Valentine's Day", new DateTime(2025, 2, 14));
            TimeStampHandler.AddTimeStamp("Presidents' Day", new DateTime(2025, 2, 17));
            TimeStampHandler.AddTimeStamp("Easter Sunday", new DateTime(2025, 4, 20));
            TimeStampHandler.AddTimeStamp("Labour Day", new DateTime(2025, 5, 1));
            TimeStampHandler.AddTimeStamp("Independence Day", new DateTime(2025, 7, 4));
            TimeStampHandler.AddTimeStamp("Bastille Day", new DateTime(2025, 7, 14));
            TimeStampHandler.AddTimeStamp("Assumption Day", new DateTime(2025, 8, 15));
            TimeStampHandler.AddTimeStamp("Oktoberfest", new DateTime(2025, 9, 19));
            TimeStampHandler.AddTimeStamp("Columbus Day", new DateTime(2025, 10, 13));
            TimeStampHandler.AddTimeStamp("Halloween", new DateTime(2025, 10, 31));
            TimeStampHandler.AddTimeStamp("All Saints' Day", new DateTime(2025, 11, 1));
            TimeStampHandler.AddTimeStamp("Labor Day", new DateTime(2025, 9, 1));
            TimeStampHandler.AddTimeStamp("Veterans Day", new DateTime(2025, 11, 11));
            TimeStampHandler.AddTimeStamp("Thanksgiving", new DateTime(2025, 11, 27));
            TimeStampHandler.AddTimeStamp("Christmas Day", new DateTime(2025, 12, 25));
            TimeStampHandler.AddTimeStamp("Memorial Day", new DateTime(2025, 5, 2));
            TimeStampHandler.AddTimeStamp("St. Patrick's Day", new DateTime(2025, 3, 17));
            TimeStampHandler.AddTimeStamp("Boxing Day", new DateTime(2025, 12, 26));
            TimeStampHandler.AddTimeStamp("D-Day", new DateTime(2025, 6, 6));
            TimeStampHandler.AddTimeStamp("Flag Day", new DateTime(2025, 6, 14));
            TimeStampHandler.AddTimeStamp("Australia Day", new DateTime(2025, 1, 26));
            TimeStampHandler.AddTimeStamp("Father's Day", new DateTime(2025, 6, 15));
            TimeStampHandler.AddTimeStamp("Midsummer's Day", new DateTime(2025, 6, 24));
            TimeStampHandler.AddTimeStamp("Midsummer's Day", new DateTime(3025, 6, 24));

            TimeStampHandler.DisplayItems(listbox_MainDisplay);
        }

        // Open Forms:
        private void button_OpenCreateForm_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }
        private void button_OpenRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            removeForm.ShowDialog();
        }
        private void button_OpenSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
