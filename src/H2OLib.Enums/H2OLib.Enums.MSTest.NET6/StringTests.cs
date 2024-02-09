using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class StringTests
    {

        [TestMethod]
        public void Enum_Parsing_StringToEnum_Test1()
        {
            string test1 = "A";

            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_StringToEnum_Test2()
        {
            string test1 = "D";

            Assert.AreEqual(FruitsEnum.D, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_StringToEnum_Test3()
        {
            string test1 = "3";

            Assert.AreEqual(FruitsEnum.C, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_StringToEnum_ThrowsArgumentException_Test1()
        {
            string test1 = "a";
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_StringToEnum_ThrowsArgumentException_Test2()
        {
            string test1 = "10";
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
