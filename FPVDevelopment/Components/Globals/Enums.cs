using System.ComponentModel;
using System.Reflection;

namespace FPVDevelopment.Components.Globals
{
    public class Enums
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes is not null && attributes.Any())
                return attributes.First().Description;

            return value.ToString();
        }
        public enum Difficulty
        {
            Basic,
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
