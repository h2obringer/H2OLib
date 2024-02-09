using H2OLib.Enums.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace H2OLib.Enums.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Can return the Description attached to an Enum value.
        /// </summary>
        /// <param name="enum">An enumeration type.</param>
        /// <returns>The System.ComponentModel.Display Attribute value assigned to an Enum value.</returns>
        public static string GetTag(this Enum @enum)
        {
            Type @enumType = @enum.GetType();
            MemberInfo[] memberInfo = @enumType.GetMember(@enum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(TagAttribute), false);
                if (attribs != null && attribs.Length > 0)
                {
                    return ((TagAttribute)attribs[0]).Tag;
                }
            }
            return @enum.ToString();
        }
    }
}
