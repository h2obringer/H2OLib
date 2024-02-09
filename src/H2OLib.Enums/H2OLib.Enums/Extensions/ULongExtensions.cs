using System;
using System.Collections.Generic;
using System.Text;

namespace H2OLib.Enums.Extensions
{
    public static class ULongExtensions
    {

        /// <summary>
        /// Converts the specified 64-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this ulong value)
            where E : Enum
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            EnumUtils.AssertEnumExists(result, value);

            return result;
        }
    }
}
