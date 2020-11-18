using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private int Expected = 55;
        [TestMethod]
        public void TestMethod1()
        {
            Program test = new Program();
            Assert.AreEqual(Expected, test.mySum(10));
        }
    }
}

