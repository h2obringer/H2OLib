using System;
using System.Collections.Generic;
using System.Text;

namespace H2OLib.Enums.Extensions
{
    public static class ObjectExtensions
    {

        /// <summary>
        /// Converts the specified object with an integer or string value to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this object value)
            where E : Enum
        {
            E result;
            try
            {
                result = (E)Enum.ToObject(typeof(E), value);
            }
            catch (ArgumentException)
            {
                result = value.ToString().ToEnum<E>();
            }

            EnumUtils.AssertEnumExists(result, value);

            return result;
        }
    }
}
