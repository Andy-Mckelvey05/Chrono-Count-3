using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer
{
    internal class ShortDisplay(string name, DateTime date) : ITimeStampInfo // This Class Is used when User Display is set to Short
    {
        public string GetDescription() // Gets Short Desc Format
        {
            return name.Length > 15 ? $"{name[..(15 - 3)]}..." : name; // Uses Python-esc slicing
        }
        public string GetFormatDate() // Gets Short Date Format
        {
            return date.ToString("dd/MM/yyyy");
        }
        public string GetTimeLeft() // Gets Short TimeLeft Format 
        {
            TimeSpan span = date.Subtract(DateTime.Now);
            if (span.TotalSeconds < 0) { return "Done"; } // Escapes if Done

            int d = span.Days;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;

            if (d > 9999) { return "OverLoad"; } // Escapes if Out of Range

            if (d > 0) { return $"{d}d"; } // Returns Dyanmic TimeLeft String
            else if (h > 0) { return $"{h:00}h"; }
            else if (m > 0) { return $"{m:00}m"; }
            else { return $"{s:00}s"; }
        }
    }
}
