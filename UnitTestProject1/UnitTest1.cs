using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private class Range0To10 : IRange
        {
            public int Lower { get { return 0; } }
            public int Upper { get { return 10; } }
        }

        #region Test Class 1
        [TestMethod]
        public void TestClass1()
        {
            const string expected =
                "100, 98, 96, 94, 92, 90, 88, 86, 84, 82, 80, 78, 76, 74, 72, 70, 68, 66, 64, 62, 60, 58, 56, 54, 52, 50, 48, 46, 44, 42, 40, 38, 36, 34, 32, 30, 28, 26, 24, 22, 20, 18, 16, 14, 12, 10, 8, 6, 4, 2, 0";
            var class1 = new Class1();
            var result = class1.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Test Class 2
        [TestMethod]
        public void TestClass2()
        {
            const string expected = "1, 2, 3, 4, 5";
            var class2 = new Class2();
            class2.SetRange(1, 5);
            var result = class2.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Test Class 3
        [TestMethod]
        public void TestClass3()
        {
            const string expected = "1, 3, 5, 7, 9";
            var class3 = new Class3 {Range = new Range0To10()};
            var result = class3.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Test Class 4
        [TestMethod]
        public void TestClass4()
        {
            const string expected = "fizzbuzz 1 fizz buzz fizz 5 fizzbuzz 7 fizz buzz ";
            var class4 = new Class4(new Range0To10());
            var result = class4.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion
    }
}
