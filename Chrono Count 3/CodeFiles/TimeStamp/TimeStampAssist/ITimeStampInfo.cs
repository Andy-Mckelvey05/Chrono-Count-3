using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist
{
    internal interface ITimeStampInfo
    {
        string GetDescription();
        string GetFormatDate();
        string GetTimeLeft();
    }
}
