using System;
using H2OLib.Enums.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H2OLib.Enums.Test.NET472
{
    [TestClass]
    public class ByteTests
    {
        [TestMethod]
        public void Enum_Parsing_ByteToEnum_Test1()
        {
            byte test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ByteToEnum_Test2()
        {
            byte test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ByteToEnum_ThrowsArgumentException()
        {
            byte test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
