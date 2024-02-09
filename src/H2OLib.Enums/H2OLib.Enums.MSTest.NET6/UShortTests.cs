using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class UShortTests
    {

        [TestMethod]
        public void Enum_Parsing_UShortToEnum_Test1()
        {
            ushort test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UShortToEnum_Test2()
        {
            ushort test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UShortToEnum_ThrowsArgumentException()
        {
            ushort test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
