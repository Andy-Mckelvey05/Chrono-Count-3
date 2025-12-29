using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.CodeFiles.TimeStamp
{
    internal class TimeStamp : IComparable<TimeStamp>
    {
        private readonly string name;
        private readonly DateTime date;

        private static int maxNameLen;
        private static int maxDateLen;
        private static int maxTimeLen;

        private readonly ITimeStampInfo descItem;
        private readonly ITimeStampInfo dateItem;
        private readonly ITimeStampInfo timeItem;

        public TimeStamp(string label, DateTime date, LengthOptions descOption, LengthOptions dateOption, LengthOptions timeOption, bool countToMax = true)
        {
            this.name = label;
            this.date = date;

            descItem = DisplayTypeFactory.Create(descOption, name, date);
            dateItem = DisplayTypeFactory.Create(dateOption, name, date);
            timeItem = DisplayTypeFactory.Create(timeOption, name, date);
        }

        public string Name => name;
        public DateTime Date => date;
        public string GetDesc() => descItem.GetDescription();
        public string GetDate() => dateItem.GetFormatDate();
        public string GetTime() => timeItem.GetTimeLeft();

        // When Sort() is called on a list of TimeStamp, Sorts the List to Closest First
        public int CompareTo(TimeStamp? other)
        {
            if (other is null) return 1;
            return date.Subtract(DateTime.Now).CompareTo(other.date.Subtract(DateTime.Now));
        }

        public override string ToString()
        {
            string descX = descItem.GetDescription();
            string dateX = dateItem.GetFormatDate();
            string timeX = timeItem.GetTimeLeft();

            int descPadding = Math.Max(0, maxNameLen - descX.Length);
            int datePadding = Math.Max(0, maxDateLen - dateX.Length);
            int timePadding = Math.Max(0, maxTimeLen - timeX.Length);
            int inbetween = 2;

            if (descX != string.Empty)
            {
                descX = descX.PadRight(descX.Length + descPadding + inbetween);
            }
            if (dateX != string.Empty)
            {
                dateX = dateX.PadRight(dateX.Length + datePadding + inbetween);
            }
            if (timeX != string.Empty) 
            {
                timeX = timeX.PadLeft(timeX.Length + timePadding);
            }

            return (descX + dateX + timeX).Trim();
        }

        public string ToSimpleString()
        {
            int padding = 32;
            string paddedLabel = name.Length > padding ? $"{name[..(padding - 3)]}..." : name.PadRight(padding);

            var dateItemMedium = DisplayTypeFactory.Create(LengthOptions.Short, name, date);
            string dateStr = dateItemMedium.GetFormatDate();

            return paddedLabel + dateStr;
        }

        public static void UpdateMaxLens(List<TimeStamp> items)
        {
            maxNameLen = maxDateLen = maxTimeLen = 0;
            foreach (TimeStamp item in items)
            {
                maxNameLen = Math.Max(maxNameLen, item.descItem.GetDescription().Length);
                maxDateLen = Math.Max(maxDateLen, item.dateItem.GetFormatDate().Length);
                maxTimeLen = Math.Max(maxTimeLen, item.timeItem.GetTimeLeft().Length);
            }

        }
    }
}
