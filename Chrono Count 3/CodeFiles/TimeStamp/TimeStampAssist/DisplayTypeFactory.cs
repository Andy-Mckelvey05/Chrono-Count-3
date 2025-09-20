using Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist.LengthOptionsContainer;

namespace Chrono_Count_3.CodeFiles.TimeStamp.TimeStampAssist
{
    internal class DisplayTypeFactory
    {
        public static ITimeStampInfo Create(LengthOptions option, string name, DateTime date)
        {
            return option switch
            {
                LengthOptions.None => new NoneDisplay(),
                LengthOptions.Short => new ShortDisplay(name, date),
                LengthOptions.Medium => new MediumDisplay(name, date),
                LengthOptions.Long => new LongDisplay(name, date),
                _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
            };
        }
    }
}
