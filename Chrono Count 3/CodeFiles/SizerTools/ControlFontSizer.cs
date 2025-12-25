namespace Chrono_Count_3.CodeFiles.SizerTools
{
    internal class ControlFontSizer
    {
        private readonly List<Control> controls;

        public ControlFontSizer(IEnumerable<Control> controls)
        {
            this.controls = [.. controls];
        }

        public void AdjustFontSizes()
        {
            foreach (Control control in controls)
            {
                AdjustFontSizeForControl(control);
            }
        }

        private static void AdjustFontSizeForControl(Control control)
        {
            int maxSize = 100;
            int minSize = 1;
            int padding = 10;

            string text = GetTextForSizing(control);

            if (string.IsNullOrEmpty(text))
                return;

            float fontSize = maxSize;

            using (Graphics g = control.CreateGraphics())
            {
                while (fontSize > minSize)
                {
                    using (Font testFont = new(control.Font.FontFamily, fontSize))
                    {
                        if (g.MeasureString(text, testFont).Width
                            <= control.Width - padding)
                        {
                            break;
                        }
                    }
                    fontSize--;
                }
            }

            control.Font = new Font(control.Font.FontFamily, fontSize);
        }

        private static string GetTextForSizing(Control control)
        {
            return control switch
            {
                ListBox listBox => GetLongestItem(listBox),
                TextBox textBox => textBox.Text ?? "",
                _ => control.Text ?? "",
            };
        }

        private static string GetLongestItem(ListBox listBox)
        {
            string longest = "";

            foreach (var item in listBox.Items)
            {
                string itemText = item?.ToString() ?? "";
                if (itemText.Length > longest.Length)
                {
                    longest = itemText;
                }
            }

            return longest;
        }
    }
}
