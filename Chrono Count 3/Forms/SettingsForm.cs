using Chrono_Count_3.CodeFiles;
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

            combobox_DescLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_DescLength.SelectedItem = UserSettings.DescSize;

            combobox_DateLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_DateLength.SelectedItem = UserSettings.DateSize;

            combobox_TimeLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_TimeLength.SelectedItem = UserSettings.TimeSize;

            mockTimeStamp();
            
            ForeColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[0][0], UserSettings.ColourScheme[0][1], UserSettings.ColourScheme[0][2]);
            MidColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[1][0], UserSettings.ColourScheme[1][1], UserSettings.ColourScheme[1][2]);
            BackColorIndicator.BackColor = Color.FromArgb(UserSettings.ColourScheme[2][0], UserSettings.ColourScheme[2][1], UserSettings.ColourScheme[2][2]);
        }

        private void mockTimeStamp() 
        {
            TimeStamp exampleTimeStamp = new TimeStamp
            (
                "This is an example of an description that you may use",
                DateTime.Now.AddDays(7),
                [
                    (LengthOptions)combobox_DescLength.SelectedItem!,
                    (LengthOptions)combobox_DateLength.SelectedItem!,
                    (LengthOptions)combobox_TimeLength.SelectedItem!
                ]
            );

            string desc = exampleTimeStamp.getDesc();
            string date = exampleTimeStamp.getDate();
            string time = exampleTimeStamp.getTime();
            label_ExampleTimeStamp.Text = $"{desc}\n{date}\n{time}";
        }
        private void combobox_DescLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_TimeLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_DateLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
    }
}
