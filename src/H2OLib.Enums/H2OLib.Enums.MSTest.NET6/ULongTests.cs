﻿using H2OLib.Enums.Extensions;

namespace H2OLib.Enums.Test.NET461
{
    [TestClass]
    public class ULongTests
    {

        [TestMethod]
        public void Enum_Parsing_ULongToEnum_Test1()
        {
            ulong test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ULongToEnum_Test2()
        {
            ulong test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ULongToEnum_ThrowsArgumentException()
        {
            ulong test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
