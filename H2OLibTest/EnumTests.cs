using H2OLib.Extensions;

namespace H2OLibTest
{
    [TestClass]
    public class EnumTest
    {
        private const string _APPLE_ = "Apple";
        private const string _BANANA_ = "Banana";
        private const string _COCONUT_ = "Coconut";
        private const string _DEWBERRY_ = "Dewberry";

        public enum FruitsEnum
        {
            [System.ComponentModel.Description(_APPLE_)]
            A = 1,
            [System.ComponentModel.Description(_BANANA_)]
            B = 2,
            [System.ComponentModel.Description(_COCONUT_)]
            C = 3,
            [System.ComponentModel.Description(_DEWBERRY_)]
            D = 4,
        }

        [TestMethod]
        public void Enum_Description_Test1()
        {
            Assert.AreEqual(_APPLE_, FruitsEnum.A.GetDescription());
        }

        [TestMethod]
        public void Enum_Description_Test2()
        {
            Assert.AreEqual(_COCONUT_, FruitsEnum.C.GetDescription());
        }

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
        public void Enum_Parsing_ShortToEnum_Test1()
        {
            short test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ShortToEnum_Test2()
        {
            short test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

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
        public void Enum_Parsing_LongToEnum_Test1()
        {
            long test1 = 1;
            Assert.AreEqual(FruitsEnum.A, test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_LongToEnum_Test2()
        {
            long test1 = 2;
            Assert.AreEqual(FruitsEnum.B, test1.ToEnum<FruitsEnum>());
        }

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

        [TestMethod]
        public void Enum_Parsing_ByteToEnum_ThrowsArgumentException()
        {
            byte test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_SByteToEnum_ThrowsArgumentException()
        {
            sbyte test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ShortToEnum_ThrowsArgumentException()
        {
            short test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UShortToEnum_ThrowsArgumentException()
        {
            ushort test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_IntToEnum_ThrowsArgumentException()
        {
            int test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_UIntToEnum_ThrowsArgumentException()
        {
            uint test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_LongToEnum_ThrowsArgumentException()
        {
            long test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ULongToEnum_ThrowsArgumentException()
        {
            ulong test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }

        [TestMethod]
        public void Enum_Parsing_ObjectToEnum_ThrowsArgumentException()
        {
            object test1 = 10;
            Assert.ThrowsException<ArgumentException>(() => test1.ToEnum<FruitsEnum>());
        }
    }
}