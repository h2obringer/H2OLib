using System;
using System.Collections.Generic;
using System.Text;

namespace H2OLib.Enums.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class TagAttribute : Attribute
    {
        public string Tag { get; set; }

        public TagAttribute(string tag)
        {
            Tag = tag;
        }
    }
}
