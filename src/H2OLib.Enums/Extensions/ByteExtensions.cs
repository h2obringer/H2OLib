using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2OLib.Enums.Extensions
{
    public static class ByteExtensions
    {

        /// <summary>
        /// Converts the specified 8-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this byte value)
            where E : Enum
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            EnumUtils.AssertEnumExists(result, value);

            return result;
        }
    }
}
