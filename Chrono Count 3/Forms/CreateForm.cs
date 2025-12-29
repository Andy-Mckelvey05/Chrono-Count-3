using Chrono_Count_3.CodeFiles.TimeStamp;

namespace Chrono_Count_3.Forms
{
    public partial class CreateForm : Form
    {
        private readonly TimeStampHandler timeStampHandler;
        public CreateForm(TimeStampHandler timeStampHandler)
        {
            this.timeStampHandler = timeStampHandler;
            InitializeComponent();
            RefreshPage();
        }

        private void RefreshPage() 
        {
            textbox_Name.Text = string.Empty;
            textbox_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        public bool IsNameValid(string name) 
        {
            if (string.IsNullOrWhiteSpace(name?.Trim()))
            {
                MessageBox.Show("Please Enter A Name", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshPage();
                return false;
            }
            return true;
        }
        public bool IsDateValid(string date)
        {
            if (!DateTime.TryParse(date, out _))
            {
                MessageBox.Show("Please Enter A Valid Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshPage();
                return false;
            }
            return true;
        }

        private void button_CreateItem_Click(object sender, EventArgs e)
        {
            string name = textbox_Name.Text.Replace(',','.');
            string time = textbox_Time.Text;

            if (IsNameValid(name) && IsDateValid(time)) 
            {
                timeStampHandler.AddTimeStamp(name, DateTime.Parse(time));

                this.Close();
                this.Dispose();
            }
        }
    }
}
