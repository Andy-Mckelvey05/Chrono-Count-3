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

        private void button_ConfirmSettings_Click(object sender, EventArgs e)
        {
            ConfirmChoises();
        }

        private void button_DecrementIPP_Click(object sender, EventArgs e)
        {
            int ItemsPerPage = int.Parse(textbox_ItemsPerPage.Text);

            if (ItemsPerPage > 1)
            {
                ItemsPerPage--;
                textbox_ItemsPerPage.Text = ItemsPerPage.ToString();
            }
        }

        private void button_IncrementIPP_Click(object sender, EventArgs e)
        {
            int ItemsPerPage = int.Parse(textbox_ItemsPerPage.Text);

            if (ItemsPerPage < 99)
            {
                ItemsPerPage++;
                textbox_ItemsPerPage.Text = ItemsPerPage.ToString();
            }
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
