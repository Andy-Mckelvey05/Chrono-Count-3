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

        // Used to Set Edit ToString
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

            if (countToMax) 
            {
                maxNameLen = Math.Max(maxNameLen, descItem.GetDescription().Length);
                maxDateLen = Math.Max(maxDateLen, dateItem.GetFormatDate().Length);
                maxTimeLen = Math.Max(maxTimeLen, timeItem.GetTimeLeft().Length);
            }
        }

        public string Name => name;
        public DateTime Date => date;
        public string GetDesc() => descItem.GetDescription();
        public string GetDate() => dateItem.GetFormatDate();
        public string GetTime() => timeItem.GetTimeLeft();

        public static void UpdateMaxLens(TimeStamp[] items)
        {
            maxNameLen = 0;
            foreach (TimeStamp item in items)
            {
                maxNameLen = Math.Max(maxNameLen, item.descItem.GetDescription().Length);
            }
            maxDateLen = 0;
            foreach (TimeStamp item in items)
            {
                maxDateLen = Math.Max(maxDateLen, item.dateItem.GetFormatDate().Length);
            }
            maxTimeLen = 0;
            foreach (TimeStamp item in items)
            {
                maxTimeLen = Math.Max(maxTimeLen, item.timeItem.GetTimeLeft().Length);
            }
        }

        // When Sort() is called on a list of TimeStamp, Sorts the List to Closest First
        public int CompareTo(TimeStamp other)
        {
            return date.Subtract(DateTime.Now).CompareTo(other.date.Subtract(DateTime.Now));
        }

        public override string ToString()
        {
            string desc = descItem.GetDescription();
            string date = dateItem.GetFormatDate();
            string time = timeItem.GetTimeLeft();

            int descPadding = Math.Max(0, maxNameLen - desc.Length);
            int datePadding = Math.Max(0, maxDateLen - date.Length);
            int timePadding = Math.Max(0, maxTimeLen - time.Length);
            int inbetween = 2;

            if (desc != string.Empty)
            {
                desc = desc.PadRight(desc.Length + descPadding + inbetween);
            }
            if (date != string.Empty)
            {
                date = date.PadRight(date.Length + datePadding + inbetween);
            }
            if (time != string.Empty) 
            {
                time = time.PadLeft(time.Length + timePadding);
            }

            return desc + date + time;
        }

        public string ToSimpleString()
        {
            int padding = 32;
            string paddedLabel = name.Length > padding ? $"{name[..(padding - 3)]}..." : name.PadRight(padding);

            var dateItemMedium = DisplayTypeFactory.Create(LengthOptions.Short, name, date);
            string dateStr = dateItemMedium.GetFormatDate();

            return paddedLabel + dateStr;
        }
    }
}
