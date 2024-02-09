using H2OLib.Enums.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2OLib.Enums.Test.NET462
{
    public enum FruitsEnum
    {
        [Tag(FruitsConstants._APPLE_)]
        A = 1,
        [Tag(FruitsConstants._BANANA_)]
        B = 2,
        [Tag(FruitsConstants._COCONUT_)]
        C = 3,
        [Tag(FruitsConstants._DEWBERRY_)]
        D = 4
    }

    internal class FruitsConstants
    {
        public const string _APPLE_ = "Apple";
        public const string _BANANA_ = "Banana";
        public const string _COCONUT_ = "Coconut";
        public const string _DEWBERRY_ = "Dewberry";
    }
}
