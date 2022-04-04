using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryAuthorization;

namespace UnitTestProjectAuthorization
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool chek_act;
            bool chek_exp = true;
            Aut.Authoriz("admin", "admin", out chek_act);
            Assert.AreEqual(chek_exp, chek_act);
        }
    }
}
