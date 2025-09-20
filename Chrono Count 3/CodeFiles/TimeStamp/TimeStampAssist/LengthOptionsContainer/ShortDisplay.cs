namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer
{
    internal class ShortDisplay(string name, DateTime date) : ITimeStampInfo
    {
        public string GetDescription()
        {
            int maxLength = 15;
            return name.Length > maxLength ? $"{name[..(maxLength - 3)]}..." : name;
        }
        public string GetFormatDate()
        {
            return date.ToString("dd/MM/yyyy");
        }
        public string GetTimeLeft()
        {
            TimeSpan span = date.Subtract(DateTime.Now);
            if (span.TotalSeconds < 0) { return "✓"; }

            int d = span.Days;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;

            if (d > 9999) { return ">"; }

            if (d > 0) { return $"{d}d"; }
            else if (h > 0) { return $"{h:00}h"; }
            else if (m > 0) { return $"{m:00}m"; }
            else { return $"{s:00}s"; }
        }
    }
}
