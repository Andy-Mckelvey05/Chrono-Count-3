using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer
{
    internal class NoneDisplay : ITimeStampInfo // This Class Is used when User Display is set to None
    {
        public string GetDescription() { return string.Empty; } // Returns Empty String
        public string GetFormatDate() { return string.Empty; } // Returns Empty String
        public string GetTimeLeft() { return string.Empty; } // Returns Empty String
    }
}
