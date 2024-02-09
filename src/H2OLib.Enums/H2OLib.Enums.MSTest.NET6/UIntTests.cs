using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class UIntTests
    {

        [TestMethod]
        public void Enum_Parsing_UIntToEnum_Test1()
        {
            uint test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UIntToEnum_Test2()
        {
            uint test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UIntToEnum_ThrowsArgumentException()
        {
            uint test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
