using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace MVCHomework.Infra
{
    public static class EnumExt
    {
        public static string GetEnumDisplayName(this Enum value)
        {
            string displayName = string.Empty;

            Type type = value.GetType();
            string enumName = Enum.GetName(type, value);
            MemberInfo member = type.GetMember(enumName).FirstOrDefault();
            var attrs = member.GetCustomAttribute(typeof(DisplayAttribute), false);

            if (attrs == null)
            {
                displayName = enumName;
            }
            else
            {
                displayName = (attrs as DisplayAttribute).Name;
            }

            return displayName;
        }
    }
}