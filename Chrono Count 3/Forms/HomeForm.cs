using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.Forms;

namespace Chrono_Count_3
{


    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            TimeStamp[] Tlist =
            {
                new TimeStamp("New Year's Day", new DateTime(2025, 1, 1)),
                new TimeStamp("Valentine's Day", new DateTime(2025, 2, 14)),
                new TimeStamp("Presidents' Day", new DateTime(2025, 2, 17)),
                new TimeStamp("Easter Sunday", new DateTime(2025, 4, 20)),
                new TimeStamp("Labour Day", new DateTime(2025, 5, 1)),
                new TimeStamp("Independence Day", new DateTime(2025, 7, 4)),
                new TimeStamp("Bastille Day", new DateTime(2025, 7, 14)),
                new TimeStamp("Assumption Day", new DateTime(2025, 8, 15)),
                new TimeStamp("Oktoberfest", new DateTime(2025, 9, 19)),
                new TimeStamp("Columbus Day", new DateTime(2025, 10, 13)),
                new TimeStamp("Halloween",  new DateTime(2025, 10, 31)),
                new TimeStamp("All Saints' Day", new DateTime(2025, 11, 1)),
                new TimeStamp("Labor Day", new DateTime(2025, 9, 1)),
                new TimeStamp("Veterans Day", new DateTime(2025, 11, 11)),
                new TimeStamp("Thanksgiving", new DateTime(2025, 11, 27)),
                new TimeStamp("Christmas Day", new DateTime(2025, 12, 25)),
                new TimeStamp("Memorial Day", new DateTime(2025, 5, 2)),
                new TimeStamp("St. Patrick's Day", new DateTime(2025, 3, 17)),
                new TimeStamp("Boxing Day", new DateTime(2025, 12, 26)),
                new TimeStamp("D-Day", new DateTime(2025, 6, 6)),
                new TimeStamp("Flag Day", new DateTime(2025, 6, 14)),
                new TimeStamp("Australia Day", new DateTime(2025, 1, 26)),
                new TimeStamp("Father's Day", new DateTime(2025, 6, 15)),
                new TimeStamp("Midsummer's Day", new DateTime(2025, 6, 24)),
                new TimeStamp("Midsummer's Day", new DateTime(3025, 6, 24)),
            };
            Tlist.ToList().Sort();
            List<TimeStamp> TheList = Tlist.ToList();
            TheList.Sort();

            foreach (var item in TheList)
            {
                listbox_MainDisplay.Items.Add(item.ToString());
            }
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
