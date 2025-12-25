using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.CodeFiles.Settings
{
    public class UserSettingDto
    {
        public int itemsPerPageDTO { get; set; }
        public required int[][] colourSchemeDTO { get; set; }
        public int defaultLengthDTO { get; set; }
        public LengthOptions descSizeDTO { get; set; }
        public LengthOptions dateSizeDTO { get; set; }
        public LengthOptions timeSizeDTO { get; set; }
    }
}
