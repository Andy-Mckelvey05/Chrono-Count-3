using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            textbox_ItemsPerPage.Text = UserSettings.ItemsPerPage.ToString();

            textbox_ForeColour.Text = string.Join(",", UserSettings.ColourScheme[0]);
            textbox_MidColour.Text = string.Join(",", UserSettings.ColourScheme[1]);
            textbox_BackColour.Text = string.Join(",", UserSettings.ColourScheme[2]);

            combobox_DescLength.DataSource = UserSettings.LengthOptionsList.ToArray();
            combobox_DescLength.SelectedItem = UserSettings.DescSize;

            combobox_DateLength.DataSource = UserSettings.LengthOptionsList.ToArray();
            combobox_DateLength.SelectedItem = UserSettings.DateSize;

            combobox_TimeLength.DataSource = UserSettings.LengthOptionsList.ToArray();
            combobox_TimeLength.SelectedItem = UserSettings.TimeSize;

            mockTimeStamp();
            
            ForeColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[0][0], UserSettings.ColourScheme[0][1], UserSettings.ColourScheme[0][2]);
            MidColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[1][0], UserSettings.ColourScheme[1][1], UserSettings.ColourScheme[1][2]);
            BackColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[2][0], UserSettings.ColourScheme[2][1], UserSettings.ColourScheme[2][2]);
        }

        private void mockTimeStamp()
        {
            label_ExampleTimeStamp.Text = TimeStampHandler.CreateDummyTimeStampString(
                "This is an example of a description that you may use",
                DateTime.Now.AddDays(7),
                combobox_DescLength.SelectedItem!.ToString()!,
                combobox_DateLength.SelectedItem!.ToString()!,
                combobox_TimeLength.SelectedItem!.ToString()!
            );
        }
        private void combobox_DescLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_TimeLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_DateLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
    }
}
