using H2OLib.Enums.Attributes;
using H2OLib.Enums.Extensions;

namespace H2OLibTest.EnumTests
{
    [TestClass]
    public class EnumTest
    {
        private const string _APPLE_ = "Apple";
        private const string _BANANA_ = "Banana";
        private const string _COCONUT_ = "Coconut";
        private const string _DEWBERRY_ = "Dewberry";

        public enum FruitsEnum
        {
            [Tag(_APPLE_)]
            A = 1,
            [Tag(_BANANA_)]
            B = 2,
            [Tag(_COCONUT_)]
            C = 3,
            [Tag(_DEWBERRY_)]
            D = 4
        }

        [TestMethod]
        public void Enum_Description_Test1()
        {
            Console.WriteLine(FruitsEnum.A.GetTag());
            Assert.AreEqual(_APPLE_, FruitsEnum.A.GetTag());
        }

        [TestMethod]
        public void Enum_Description_Test2()
        {
            Assert.AreEqual(_COCONUT_, FruitsEnum.C.GetTag());
        }
    }
}