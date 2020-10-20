using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            int expected = 5;
            int actual=Maximum.FindMax(5, 2, 4);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {

            int expected = 7;
            int actual = Maximum.FindMax(5, 7, 4);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {

            int expected = 9;
            int actual = Maximum.FindMax(5, 2, 9);
            Assert.AreEqual(actual, expected);
        }
    }
}
