using System;
using System.Collections.Generic;
using System.Text;

namespace H2OLib.Enums.Extensions
{
    public static class IntExtensions
    {

        /// <summary>
        /// Converts the specified 32-bit signed integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this int value)
            where E : Enum
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            EnumUtils.AssertEnumExists(result, value);

            return result;
        }
    }
}
