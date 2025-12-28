using Chrono_Count_3.CodeFiles.Settings;
using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;
using System.Drawing.Printing;
using System.Globalization;

namespace Chrono_Count_3.CodeFiles.TimeStamp
{
    public class TimeStampHandler
    {
        private readonly UserSettings userSettings;
        private readonly string filePath;
        private List<TimeStamp> itemList = new();

        public TimeStampHandler(UserSettings userSettings,string filePath)
        {
            this.userSettings = userSettings;
            this.filePath = filePath;
            ReadFromFile();
        }

        public void AddTimeStamp(string label, DateTime date) 
        {
            var item = new TimeStamp(
                label,
                date,
                userSettings.DescSize,
                userSettings.DateSize,
                userSettings.TimeSize
            );
            itemList.Add(item);
            itemList.Sort();
        }

        private List<TimeStamp> GetPage(int pageIndex)
        {
            int totalPages = GetTotalPages();
            if (totalPages == 0) 
            {
                return new List<TimeStamp>();
            }

            pageIndex = Math.Max(1, Math.Min(pageIndex, totalPages));

            int pageSize = userSettings.ItemsPerPage;
            int startIndex = (pageIndex - 1) * pageSize;

            return itemList.Skip(startIndex).Take(pageSize).ToList();
        }

        public int GetTotalPages()
        {
            if (itemList.Count == 0) 
            {
                return 1;
            }
            int pageSize = userSettings.ItemsPerPage;
            return (int)Math.Ceiling(itemList.Count / (double)pageSize);
        }

        public void DisplayPage(ListBox listbox, int pageIndex) 
        {
            listbox.Items.Clear();
            foreach (var item in GetPage(pageIndex))
            {
                listbox.Items.Add(item.ToString());
            }
        }

        public void DisplayAllItems(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (var item in itemList)
            {
                listbox.Items.Add(item.ToString());
            }
        }

        public void ReadFromFile()
        {
            itemList = new List<TimeStamp>();

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
                return;
            }

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                if (parts.Length < 2) continue;

                string label = parts[0];
                if (DateTime.TryParseExact(parts[1], "o", CultureInfo.InvariantCulture,
                                           DateTimeStyles.None, out DateTime date))
                {
                    AddTimeStamp(label, date);
                }
            }
        }

        public void UpdateFile()
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (var item in itemList)
                {
                    writer.WriteLine($"{item.Name},{item.Date:o}");
                }
            }
        }

        public static string CreateDummyTimeStampString(string label, DateTime date, string descOptionStr, string dateOptionStr, string timeOptionStr)
        {
            LengthOptions descOption = Enum.Parse<LengthOptions>(descOptionStr);
            LengthOptions dateOption = Enum.Parse<LengthOptions>(dateOptionStr);
            LengthOptions timeOption = Enum.Parse<LengthOptions>(timeOptionStr);

            var ts = new TimeStamp(label, date, descOption, dateOption, timeOption, false);
            return $"{ts.GetDesc()}\r\n{ts.GetDate()}\r\n{ts.GetTime()}";
        }
    }
}
