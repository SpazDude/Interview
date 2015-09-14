using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTests
    {
        private class Range0To10 : IRange
        {
            public int Lower { get { return 0; } }
            public int Upper { get { return 10; } }
        }

        #region Test ReverseEvenNumberGenerator
        [TestMethod]
        public void TestReverseEvenNumberGenerator()
        {
            const string expected =
                "100, 98, 96, 94, 92, 90, 88, 86, 84, 82, 80, 78, 76, 74, 72, 70, 68, 66, 64, 62, 60, 58, 56, 54, 52, 50, 48, 46, 44, 42, 40, 38, 36, 34, 32, 30, 28, 26, 24, 22, 20, 18, 16, 14, 12, 10, 8, 6, 4, 2, 0";
            var generator = new ReverseEvenNumberGenerator();
            var result = generator.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Test Class1
        [TestMethod]
        public void TestClass1()
        {
            const string expected = "1, 2, 3, 4, 5";
            var generator = new Class1();
            generator.SetRange(1, 5);
            var result = generator.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Test OddNumberGenerator
        [TestMethod]
        public void TestOddNumberGenerator()
        {
            const string expected = "1, 3, 5, 7, 9";
            var generator = new OddNumberGenerator {Range = new Range0To10()};
            var result = generator.GenerateOutput();
            Assert.AreEqual(expected, result);
        }
        #endregion
    }
}
