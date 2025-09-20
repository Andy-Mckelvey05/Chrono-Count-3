using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer
{
    internal class MediumDisplay(string name, DateTime date) : ITimeStampInfo // This Class Is used when User Display is set to Medium
    {
        public string GetDescription() // Gets Medium Desc Format
        {
            return name.Length > 30 ? $"{name[..(30 - 3)]}..." : name; // Uses Python-esc slicing
        }
        public string GetFormatDate() // Gets Medium Date Format
        {
            return date.ToString("ddd dd MMM yyyy").Replace("Sept", "Sep");
        }
        public string GetTimeLeft() // Gets Medium TimeLeft Format
        {
            TimeSpan span = date.Subtract(DateTime.Now);
            if (span.TotalSeconds < 0) { return "Done"; } // Escapes if Done

            int d = span.Days;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;

            if (d > 9999) { return "OverLoad"; } // Escapes if Out of Range

            if (d > 0) { return $"{d}d:{h:00}h"; } // Returns Dyanmic TimeLeft String
            else if (h > 0) { return $"{h:00}h:{m:00}m"; }
            else if (m > 0) { return $"{m:00}m:{s:00}s"; }
            else { return $"{s:00}s"; }
        }
    }
}
