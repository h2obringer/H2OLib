using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
