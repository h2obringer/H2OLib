using System;
using H2OLib.Enums.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H2OLib.Enums.Test.NET47
{
    [TestClass]
    public class ObjectTests
    {
        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_Test1()
        {
            object test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_Test2()
        {
            object test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_Test3()
        {
            object test1 = "A";
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_Test4()
        {
            object test1 = "4";
            Assert.AreEqual(FruitsEnum.D, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_ThrowsArgumentException_Test1()
        {
            object test1 = 0;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_ThrowsArgumentException_Test2()
        {
            object test1 = "a";
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_ThrowsArgumentException_Test3()
        {
            object test1 = "0";
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}
