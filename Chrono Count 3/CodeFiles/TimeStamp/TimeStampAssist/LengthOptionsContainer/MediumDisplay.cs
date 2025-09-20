namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer
{
    internal class MediumDisplay(string name, DateTime date) : ITimeStampInfo
    {
        public string GetDescription()
        {
            int maxLength = 30;
            return name.Length > maxLength ? $"{name[..(maxLength - 3)]}..." : name;
        }
        public string GetFormatDate()
        {
            // In this format September is shown in 4 char instead of 3
            return date.ToString("ddd dd MMM yyyy").Replace("Sept", "Sep");
        }
        public string GetTimeLeft()
        {
            TimeSpan span = date.Subtract(DateTime.Now);
            if (span.TotalSeconds < 0) { return "Done"; }

            int d = span.Days;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;

            if (d > 9999) { return "OverLoad"; }

            if (d > 0) { return $"{d}d:{h:00}h"; }
            else if (h > 0) { return $"{h:00}h:{m:00}m"; }
            else if (m > 0) { return $"{m:00}m:{s:00}s"; }
            else { return $"{s:00}s"; }
        }
    }
}
