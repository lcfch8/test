using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoUser;

namespace UserTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;
            int x = 1;
            User z = new User(a, b, x);
            Assert.IsTrue(z != null);
        }
    }


}
