using H2OLib.Extensions;

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
            [System.ComponentModel.Description(_APPLE_)]
            A = 1,
            [System.ComponentModel.Description(_BANANA_)]
            B = 2,
            [System.ComponentModel.Description(_COCONUT_)]
            C = 3,
            [System.ComponentModel.Description(_DEWBERRY_)]
            D = 4
        }

        [TestMethod]
        public void Enum_Description_Test1()
        {
            Console.WriteLine(FruitsEnum.A.GetDescription());
            Assert.AreEqual(_APPLE_, FruitsEnum.A.GetDescription());
        }

        [TestMethod]
        public void Enum_Description_Test2()
        {
            Assert.AreEqual(_COCONUT_, FruitsEnum.C.GetDescription());
        }
    }
}