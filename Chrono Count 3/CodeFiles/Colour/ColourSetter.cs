using Chrono_Count_3.CodeFiles.Settings;

namespace Chrono_Count_3.Forms
{
    internal class ColourSetter
    {
        private readonly UserSettings settings;

        public List<Control> ForeControls { get; } = new();
        public List<Control> MidControls { get; } = new();
        public List<Control> BackControls { get; } = new();

        public ColourSetter(UserSettings settings, Form form)
        {
            this.settings = settings;

            BackControls.Add(form);

            DiscoverControls(form.Controls);
        }

        private void DiscoverControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                AssignToDefaultGroup(control);

                if (control.HasChildren)
                {
                    DiscoverControls(control.Controls);
                }
            }
        }

        private void AssignToDefaultGroup(Control control)
        {
            switch (control)
            {
                case Button:
                    ForeControls.Add(control);
                    break;

                case ListBox:
                case TextBox:
                case ComboBox:
                    MidControls.Add(control);
                    break;

                case Panel:
                case GroupBox:
                    BackControls.Add(control);
                    break;
            }
        }

        public void ApplyColours()
        {
            Color fore = ToColor(settings.ColourScheme[0]);
            Color mid = ToColor(settings.ColourScheme[1]);
            Color back = ToColor(settings.ColourScheme[2]);

            SetColour(fore, ForeControls);
            SetColour(mid, MidControls);
            SetColour(back, BackControls);
        }

        private static void SetColour(Color colour, IEnumerable<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.BackColor = colour;
            }
        }

        private static Color ToColor(int[] rgb)
        {
            return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }
    }
}
