
using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.SizerTools;
using Chrono_Count_3.CodeFiles.TimeStamp;
using Chrono_Count_3.Forms;
using Dyanmic_Form_Sizing_Testing;

namespace Chrono_Count_3
{
    public partial class HomeForm : Form
    {
        private readonly UserSettings userSettings;
        private readonly TimeStampHandler timeStampHandler;

        private readonly DynamicControlResizer dynamicControlResizer;
        private readonly ControlFontSizer listBoxFontSizer;
        private readonly ColourSetter colourSetter;

        public HomeForm(UserSettings userSettings, TimeStampHandler timeStampHandler)
        {
            InitializeComponent();
            this.userSettings = userSettings;
            this.timeStampHandler = timeStampHandler;

            this.dynamicControlResizer = new DynamicControlResizer(this);
            this.listBoxFontSizer = new ControlFontSizer(
            [
                listbox_MainDisplay,
                textbox_CurrentTime,
            ]);
            this.colourSetter = new ColourSetter(userSettings, this);

            timeStampHandler.DisplayItems(listbox_MainDisplay);
            UpdateCurrentTimeDisplay();
            listBoxFontSizer.AdjustFontSizes();
            colourSetter.ApplyColours();
        }

        private void UpdateCurrentTimeDisplay() 
        {
            textbox_CurrentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        // Open Forms:
        private void button_OpenCreateForm_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(timeStampHandler);
            new ColourSetter(userSettings, createForm).ApplyColours();
            createForm.ShowDialog();
            timeStampHandler.UpdateFile();
        }
        private void button_OpenRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            new ColourSetter(userSettings, removeForm).ApplyColours();
            removeForm.ShowDialog();
        }
        private void button_OpenSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(userSettings);
            new ColourSetter(userSettings, settingsForm).ApplyColours();
            settingsForm.ShowDialog();
        }

        private void timer_GameTime_Tick(object sender, EventArgs e)
        {
            timeStampHandler.DisplayItems(listbox_MainDisplay);
            UpdateCurrentTimeDisplay();
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            dynamicControlResizer.ResizeForm();
            listBoxFontSizer.AdjustFontSizes();
        }
    }
}
