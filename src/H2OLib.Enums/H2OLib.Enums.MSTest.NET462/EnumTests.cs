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
