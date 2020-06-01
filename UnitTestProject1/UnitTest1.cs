using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = new int[5] { -1, -3, 2, 2, -3 };
            int min = Program.MinAbs(arr, 5);
            Assert.AreEqual(min, 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = new int[5] { -1, -3, 2, 2, -3 };
            int sum = Program.Sum(arr, 5);
            Assert.AreEqual(sum, 1);
        }
    }
}
