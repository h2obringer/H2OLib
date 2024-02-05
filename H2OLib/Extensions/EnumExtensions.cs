using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace H2OLib.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Can return the Description attached to an Enum value.
        /// </summary>
        /// <param name="enum">An enumeration type.</param>
        /// <returns>The System.ComponentModel.Display Attribute value assigned to an Enum value.</returns>
        public static string GetDescription(this Enum @enum)
        {
            Type @enumType = @enum.GetType();
            MemberInfo[] memberInfo = @enumType.GetMember(@enum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((attribs != null && attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)attribs.ElementAt(0)).Description;
                }
            }
            return @enum.ToString();
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static E ToEnum<E>(this string value)
        {
            E result = (E)Enum.Parse(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 8-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this byte value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 8-bit signed integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this sbyte value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 16-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this ushort value)
        {
            E result =(E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 16-bit signed integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this short value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 32-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this uint value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 32-bit signed integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this int value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 64-bit unsigned integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this ulong value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified 64-bit signed integer to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this long value)
        {
            E result = (E)Enum.ToObject(typeof(E), value);

            AssertEnumExists(result, value);

            return result;
        }

        /// <summary>
        /// Converts the specified object with an integer or string value to an enumeration member.
        /// </summary>
        /// <typeparam name="E">enum type</typeparam>
        /// <param name="value"></param>
        /// <returns>An object of type <typeparamref name="E"/> whose value is represented by <paramref name="value"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public static E ToEnum<E>(this object value)
        {
            E result;
            try
            {
                result = (E)Enum.ToObject(typeof(E), value);
            }
            catch(ArgumentException)
            {
                result = value.ToString()!.ToEnum<E>();
            }

            AssertEnumExists(result, value);

            return result;
        }

        private static void AssertEnumExists<E>(E @enum, object value)
        {
            var items = Enum.GetValues(typeof(E));
            bool doesExist = false;
            foreach (E item in items)
            {
                if (item.Equals(@enum))
                {
                    doesExist = true;
                    break;
                }
            }

            if (!doesExist) throw new ArgumentException($"Requested value '{value}' was not found.");
        }
    }
}
