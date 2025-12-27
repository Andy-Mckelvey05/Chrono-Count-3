using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.Forms
{
    public partial class SettingsForm : Form
    {
        private UserSettings userSettings;

        public SettingsForm(UserSettings userSettings)
        {
            InitializeComponent();

            this.userSettings = userSettings;

            textbox_ItemsPerPage.Text = userSettings.ItemsPerPage.ToString();

            textbox_ForeColour.Text = string.Join(",", userSettings.ColourScheme[0]);
            textbox_MidColour.Text = string.Join(",", userSettings.ColourScheme[1]);
            textbox_BackColour.Text = string.Join(",", userSettings.ColourScheme[2]);

            combobox_DescLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_DescLength.SelectedItem = userSettings.DescSize;

            combobox_DateLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_DateLength.SelectedItem = userSettings.DateSize;

            combobox_TimeLength.DataSource = Enum.GetValues(typeof(LengthOptions));
            combobox_TimeLength.SelectedItem = userSettings.TimeSize;

            mockTimeStamp();

            ApplyTextboxIndicatorColours();
        }

        private void ApplyTextboxIndicatorColours()
        {
            ForeColourIndicator.BackColor = Color.FromArgb(
                userSettings.ColourScheme[0][0],
                userSettings.ColourScheme[0][1],
                userSettings.ColourScheme[0][2]
            );

            MidColourIndicator.BackColor = Color.FromArgb(
                userSettings.ColourScheme[1][0],
                userSettings.ColourScheme[1][1],
                userSettings.ColourScheme[1][2]
            );

            BackColourIndicator.BackColor = Color.FromArgb(
                userSettings.ColourScheme[2][0],
                userSettings.ColourScheme[2][1],
                userSettings.ColourScheme[2][2]
            );
        }

        private void mockTimeStamp()
        {
            string descOption = combobox_DescLength.SelectedItem!.ToString()!;
            string dateOption = combobox_DateLength.SelectedItem!.ToString()!;
            string timeOption = combobox_TimeLength.SelectedItem!.ToString()!;

            textBox_ExampleTimeStamp.Text = TimeStampHandler.CreateDummyTimeStampString(
                "This is an example of a description that you may use",
                DateTime.Now.AddDays(7),
                descOption,
                dateOption,
                timeOption
            );
        }
        private void combobox_DescLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_TimeLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }
        private void combobox_DateLength_SelectionChangeCommitted(object sender, EventArgs e) { mockTimeStamp(); }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ToggleEditing();
            ApplyTextboxIndicatorColours();
        }
        private void button_EditToggle_Click(object sender, EventArgs e)
        {
            ToggleEditing();
            if (!groupbox_SettingsPage.Enabled && ValidChoises())
            {
                ConfirmChoises();
            }
        }

        private void ToggleEditing()
        {
            if (groupbox_SettingsPage.Enabled)
            {
                button_EditToggle.Text = "Click to Edit Settings";
                groupbox_SettingsPage.Enabled = false;

                int lighten = 25;
                int max = 255;
                groupbox_SettingsPage.BackColor = Color.FromArgb(
                    Math.Min(userSettings.ColourScheme[2][0] + lighten, max),
                    Math.Min(userSettings.ColourScheme[2][1] + lighten, max),
                    Math.Min(userSettings.ColourScheme[2][2] + lighten, max)
                );
            }
            else
            {
                button_EditToggle.Text = "Click to Confirm";
                groupbox_SettingsPage.Enabled = true;

                groupbox_SettingsPage.BackColor = Color.FromArgb(
                    userSettings.ColourScheme[2][0],
                    userSettings.ColourScheme[2][1],
                    userSettings.ColourScheme[2][2]
                );
            }
        }

        private bool ValidChoises()
        {
            return true;
        }

        private void ConfirmChoises()
        {
            UserSettingDto choises = new UserSettingDto
            {
                itemsPerPageDTO = int.Parse(textbox_ItemsPerPage.Text),
                colourSchemeDTO =
                [
                    textbox_ForeColour.Text.Split(',').Select(int.Parse).ToArray(),
                    textbox_MidColour.Text.Split(',').Select(int.Parse).ToArray(),
                    textbox_BackColour.Text.Split(',').Select(int.Parse).ToArray()
                ],
                defaultLengthDTO = 718, // ! May Remove later, currently not implemented
                descSizeDTO = (LengthOptions)Enum.Parse(typeof(LengthOptions), combobox_DescLength.SelectedItem.ToString()!),
                dateSizeDTO = (LengthOptions)Enum.Parse(typeof(LengthOptions), combobox_DateLength.SelectedItem.ToString()!),
                timeSizeDTO = (LengthOptions)Enum.Parse(typeof(LengthOptions), combobox_TimeLength.SelectedItem.ToString()!)
            };

            if (MessageBox.Show("Are you sure? This will close the program.", "Confirm Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                userSettings.WriteSettingsJSON(choises);
            }
        }

        public static void PickColor(TextBox textBox1, Panel textBox2)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.FullOpen = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color chosen = colorDialog.Color;

                    textBox1.Text = $"{chosen.R},{chosen.G},{chosen.B}";
                    textBox2.BackColor = chosen;
                }
            }
        }
        private void button_EditForeColour_Click(object sender, EventArgs e)
        {
            PickColor(textbox_ForeColour, ForeColourIndicator);
        }
        private void button_EditMidColour_Click(object sender, EventArgs e)
        {
            PickColor(textbox_MidColour, MidColourIndicator);
        }
        private void button_EditBackColour_Click(object sender, EventArgs e)
        {
            PickColor(textbox_BackColour, BackColourIndicator);
        }

        private void button_SetDefault_Click(object sender, EventArgs e)
        {
            UserSettingDto choises = userSettings.GetDefaultSettings();
            if (MessageBox.Show("Are you sure? This will close the program.", "Confirm Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                userSettings.WriteSettingsJSON(choises);
            }
        }
    }
}
