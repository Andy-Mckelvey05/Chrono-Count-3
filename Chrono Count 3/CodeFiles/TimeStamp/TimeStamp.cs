using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.CodeFiles.TimeStamp
{
    public class TimeStamp : IComparable<TimeStamp>
    {
        // Constructor:
        private readonly string name;
        private readonly DateTime date;
        private static int maxNameLen;
        private static int maxDateLen;
        private static int maxTimeLen;

        // Display Types
        private LengthOptions desc_Options;
        private LengthOptions date_Options;
        private LengthOptions time_Options;

        // Used to Set Edit ToString
        private ITimeStampInfo descItem;
        private ITimeStampInfo dateItem;
        private ITimeStampInfo timeItem;

        public TimeStamp(string label, DateTime date, LengthOptions[]? lengthOptions = null)
        {
            name = label;
            this.date = date;

            if (lengthOptions == null) 
            {
                desc_Options = UserSettings.DescSize;
                date_Options = UserSettings.DateSize;
                time_Options = UserSettings.TimeSize;

                descItem = DisplayTypeFactory.Create(desc_Options, name, date);
                dateItem = DisplayTypeFactory.Create(date_Options, name, date);
                timeItem = DisplayTypeFactory.Create(time_Options, name, date);

                maxNameLen = Math.Max(maxNameLen, descItem.GetDescription().Length);
                maxDateLen = Math.Max(maxDateLen, dateItem.GetFormatDate().Length);
                maxTimeLen = Math.Max(maxTimeLen, timeItem.GetTimeLeft().Length);
            }
            else 
            {
                desc_Options = lengthOptions[0];
                date_Options = lengthOptions[1];
                time_Options = lengthOptions[2];

                descItem = DisplayTypeFactory.Create(desc_Options, name, date);
                dateItem = DisplayTypeFactory.Create(date_Options, name, date);
                timeItem = DisplayTypeFactory.Create(time_Options, name, date);
            }
        }
        // Allows for Indevisual Elements to be Returned
        public string getDesc()
        {
            return descItem.GetDescription();
        }
        public string getDate()
        {
            return dateItem.GetFormatDate();
        }
        public string getTime()
        {
            return timeItem.GetTimeLeft();
        }

        // Sets MaxLens Based Off List, (needed when items are removed)
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
        public int CompareTo(TimeStamp other) // Sorts a list of entries by the length of the span 
        {
            return date.Subtract(DateTime.Now).CompareTo(other.date.Subtract(DateTime.Now));
        }

        // Display String Based on User Settings
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
    }
}
