using Chrono_Count_3.CodeFiles;
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
    public partial class CreateForm : Form
    {
        private readonly TimeStampHandler timeStampHandler;
        public CreateForm(TimeStampHandler timeStampHandler)
        {
            this.timeStampHandler = timeStampHandler;
            InitializeComponent();
            textbox_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void button_CreateItem_Click(object sender, EventArgs e)
        {
            string name = textbox_Name.Text;
            DateTime time = DateTime.Parse(textbox_Time.Text);
           
            timeStampHandler.AddTimeStamp(name, time);

            this.Close();
            this.Dispose();
        }
    }
}
