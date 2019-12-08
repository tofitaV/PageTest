using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAHWTaskPage.Pages;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Registration registration;
        Authentication authentication;

        [TestMethod]
        public void TestMethod1()
        {

            //registration = new Registration();
            authentication = new Authentication();
            //Assert.AreEqual(registration.Registr(), true);
            Assert.AreEqual(authentication.Auth(), true);

        }


        
    }
}
