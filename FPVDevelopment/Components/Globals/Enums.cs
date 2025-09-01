using System.ComponentModel;

namespace FPVDevelopment.Components.Globals
{
    public class Enums
    {
        public enum MapDifficulty
        {
            UNRATED,
            Easy,
            Medium,
            Hard
        }

        public enum DroneSize
        {
            [Description("3\"")]
            ThreeInch,
            [Description("4\"")]
            FourInch,
            [Description("5\"")]
            FiveInch,
            [Description("6\"")]
            SixInch,
            [Description("7\"")]
            SevenInch
        }
    }
}
