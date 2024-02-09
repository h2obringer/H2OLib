using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class EnumTests
    {

        [TestMethod]
        public void Enum_Description_Test1()
        {
            Assert.AreEqual(FruitsConstants._APPLE_, FruitsEnum.A.GetTag());
        }

        [TestMethod]
        public void Enum_Description_Test2()
        {
            Assert.AreEqual(FruitsConstants._COCONUT_, FruitsEnum.C.GetTag());
        }

    }
}
