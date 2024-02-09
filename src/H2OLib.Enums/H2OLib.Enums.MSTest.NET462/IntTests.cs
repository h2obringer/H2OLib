using System;
using H2OLib.Enums.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H2OLib.Enums.Test.NET462
{
    [TestClass]
    public class IntTests
    {

        [TestMethod]
        public void Enum_Parsing_IntToEnum_Test1()
        {
            int test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_IntToEnum_Test2()
        {
            int test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_IntToEnum_ThrowsArgumentException()
        {
            int test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
