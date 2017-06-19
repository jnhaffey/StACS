using System.ComponentModel;
using System.Linq;

namespace System
{
    public static class GetDescriptionExtension
    {
#if NET452
        public static string GetDescription(this Enum source)
        {
            var field = source.GetType().GetField(source.GetName());
            var descriptionAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute == null ? source.GetName() : descriptionAttribute.Description;
        }
#endif
#if NETSTANDARD1_6

        public static string GetDescription(this Enum source)
        {
            throw new NotImplementedException("Waiting for .NET Standard 2.0 RTM");
        }

#endif
    }
}