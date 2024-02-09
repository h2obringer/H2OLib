using System;
using System.Collections.Generic;
using System.Text;

namespace H2OLib.Enums
{
    internal class EnumUtils
    {
        public static void AssertEnumExists<E>(E @enum, object value)
            where E : Enum
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
