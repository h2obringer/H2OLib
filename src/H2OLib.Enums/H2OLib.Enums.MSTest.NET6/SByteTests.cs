using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class SByteTests
    {

        [TestMethod]
        public void Enum_Parsing_SByteToEnum_Test1()
        {
            sbyte test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_SByteToEnum_Test2()
        {
            sbyte test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_SByteToEnum_ThrowsArgumentException()
        {
            sbyte test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

    }
}
