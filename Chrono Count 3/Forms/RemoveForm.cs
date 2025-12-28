using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for (int i = 0; i < timeStampHandler.GetTotalPages(); i++)
            {
                comboBox_PageDropDown.Items.Add(i + 1);
            }
            comboBox_PageDropDown.SelectedIndex = 0;
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
            if (comboBox_PageDropDown.SelectedIndex == 0)
            {
                if (combobox_ItemDropDown.SelectedIndex == 0)
                {
                    timeStampHandler.RemoveDoneTimeStamps();
                }
                else 
                {
                    RemoveBasedOnindex();
                }
            }
            else
            {
                RemoveBasedOnPage();
            }
            this.Close();
            this.Dispose();
        }

        private void RemoveBasedOnindex()
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
