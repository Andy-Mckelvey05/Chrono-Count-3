using Chrono_Count_3.CodeFiles.TimeStamp;

namespace Chrono_Count_3.Forms
{
    public partial class RemoveForm : Form
    {
        private readonly TimeStampHandler timeStampHandler;
        public RemoveForm(TimeStampHandler timeStampHandler)
        {
            this.timeStampHandler = timeStampHandler;
            InitializeComponent();

            comboBox_PageDropDown.Items.Add("All");
            int totalPages = timeStampHandler.GetTotalPages();
            comboBox_PageDropDown.Items.AddRange(
                [.. Enumerable.Range(1, totalPages).Cast<object>()]
            );

            comboBox_PageDropDown.SelectedIndex = 0;

            bool hasItems = timeStampHandler.GetTotalItems() > 0;
            comboBox_PageDropDown.Enabled = hasItems;
            combobox_ItemDropDown.Enabled = hasItems;
        }

        private void comboBox_PageDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_PageDropDown.SelectedIndex == 0)
            {
                timeStampHandler.DisplayAllShort(combobox_ItemDropDown);
                combobox_ItemDropDown.Items.Insert(0, "Remove 'Done'");
            }
            else
            {
                timeStampHandler.DisplayPageShort(combobox_ItemDropDown, comboBox_PageDropDown.SelectedIndex);
            }
            combobox_ItemDropDown.SelectedIndex = 0;
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (comboBox_PageDropDown.SelectedIndex == 0 && combobox_ItemDropDown.SelectedIndex == 0)
            {
                timeStampHandler.RemoveDoneTimeStamps();
            }
            else if (comboBox_PageDropDown.SelectedIndex == 0)
            {
                RemoveBasedOnIndex();
            }
            else
            {
                RemoveBasedOnPage();
            }

            Close();
        }

        private void RemoveBasedOnIndex()
        {
            int selectedIndex = combobox_ItemDropDown.SelectedIndex - 1;

            if (selectedIndex < 0) 
            {
                return;
            }

            timeStampHandler.RemoveTimeStamp(selectedIndex);
        }
        private void RemoveBasedOnPage() 
        {
            int pageSelection = comboBox_PageDropDown.SelectedIndex;
            int indexOnPage = combobox_ItemDropDown.SelectedIndex;

            if (indexOnPage < 0)
            {
                return;
            }

            int globalIndex = ((pageSelection - 1) * timeStampHandler.GetItemsPerPage()) + indexOnPage;

            timeStampHandler.RemoveTimeStamp(globalIndex);
        }
    }
}
