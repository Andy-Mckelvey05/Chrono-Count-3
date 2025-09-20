using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.CodeFiles.TimeStamp
{
    internal class TimeStampHandler
    {
        private static List<TimeStamp> itemList = new();

        public static void ReadFromFile() 
        { 
            throw new NotImplementedException();
        }

        public static void AddTimeStamp(string label, DateTime date) 
        {
            var item = new TimeStamp(
                label,
                date,
                UserSettings.DescSize,
                UserSettings.DateSize,
                UserSettings.TimeSize
            );
            itemList.Add(item);
            itemList.Sort();
        }

        public static string CreateDummyTimeStampString(string label, DateTime date, string descOptionStr, string dateOptionStr, string timeOptionStr)
        {
            LengthOptions descOption = Enum.Parse<LengthOptions>(descOptionStr);
            LengthOptions dateOption = Enum.Parse<LengthOptions>(dateOptionStr);
            LengthOptions timeOption = Enum.Parse<LengthOptions>(timeOptionStr);

            var ts = new TimeStamp(label, date, descOption, dateOption, timeOption, false);
            return $"{ts.GetDesc()}\n{ts.GetDate()}\n{ts.GetTime()}";
        }

        public static void DisplayItems(ListBox listbox) 
        {
            foreach (var item in itemList)
            {
                listbox.Items.Add(item.ToString());
            }
        }
    }
}
