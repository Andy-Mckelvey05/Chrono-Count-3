
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

        private int currentPageIndex = 0;

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

            timeStampHandler.DisplayPage(listbox_MainDisplay, currentPageIndex + 1);

            colourSetter.ApplyColours();
            RefreshForm();
        }

        private void RefreshForm()
        {
            int totalPages = timeStampHandler.GetTotalPages();

            currentPageIndex = Math.Max(0, Math.Min(currentPageIndex, totalPages - 1));

            timeStampHandler.DisplayPage(listbox_MainDisplay, currentPageIndex + 1);
            label_PageDisplay.Text = $"{currentPageIndex + 1}/{totalPages}";

            UpdateCurrentTimeDisplay();
            listBoxFontSizer.AdjustFontSizes();
            UpdateSizeDynamic();
        }

        private void UpdateSizeDynamic(int bottomPadding = 15)
        {
            listbox_MainDisplay.Height = listbox_MainDisplay.PreferredHeight;

            int nonClientHeight = this.Height - this.ClientSize.Height;
            this.Height = listbox_MainDisplay.Top + listbox_MainDisplay.Height + bottomPadding + nonClientHeight;
        }

        private void UpdateCurrentTimeDisplay()
        {
            textbox_CurrentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button_OpenCreateForm_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(timeStampHandler);
            new ColourSetter(userSettings, createForm).ApplyColours();
            createForm.ShowDialog();
            timeStampHandler.UpdateFile();
            RefreshForm();
        }
        private void button_OpenRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            new ColourSetter(userSettings, removeForm).ApplyColours();
            removeForm.ShowDialog();
            RefreshForm();
        }
        private void button_OpenSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(userSettings);
            new ColourSetter(userSettings, settingsForm).ApplyColours();
            settingsForm.ShowDialog();
        }

        private void timer_GameTime_Tick(object sender, EventArgs e)
        {
            timeStampHandler.DisplayPage(listbox_MainDisplay, currentPageIndex + 1);
            UpdateCurrentTimeDisplay();
        }

        private void HomeForm_ResizeEnd(object sender, EventArgs e)
        {
            dynamicControlResizer.ResizeFormHorizontally();
            listBoxFontSizer.AdjustFontSizes();
            UpdateSizeDynamic();
        }

        private void button_MovePageLeft_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                timeStampHandler.DisplayPage(listbox_MainDisplay, currentPageIndex + 1);
                label_PageDisplay.Text = $"{currentPageIndex + 1}/{timeStampHandler.GetTotalPages()}";
            }

        }

        private void button_MovePageRight_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < timeStampHandler.GetTotalPages() - 1)
            {
                currentPageIndex++;
                timeStampHandler.DisplayPage(listbox_MainDisplay, currentPageIndex + 1);
                label_PageDisplay.Text = $"{currentPageIndex + 1}/{timeStampHandler.GetTotalPages()}";
            }
        }

    }
}
