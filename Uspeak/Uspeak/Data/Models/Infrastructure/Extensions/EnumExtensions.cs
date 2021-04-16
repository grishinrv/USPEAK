using System.ComponentModel;
using System.Reflection;

namespace Uspeak.Data.Models.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescription<T>(this T value)
        {
            var descriptionField = typeof(T).GetField(value.ToString());
            var descriptionAttribute = descriptionField.GetCustomAttribute<DescriptionAttribute>();
            return descriptionAttribute?.Description ?? string.Empty;
        }
    }
}
