using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2OLib.Enums.Extensions
{
    public static class StringExtensions
    {

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static E ToEnum<E>(this string value)
            where E : Enum
        {
            E result = (E)Enum.Parse(typeof(E), value);

            EnumUtils.AssertEnumExists(result, value);

            return result;
        }
    }
}
