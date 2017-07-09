using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetCrntIPAdrs;
using Notifications;

namespace TestIPAdrsLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIPAdrs()
        {
            string ipAdrs = IPAdrs.getCurrentIP();
            Assert.AreEqual("192.168.6.108", ipAdrs);
        }
    }
}

namespace TestSendEmail
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMail()
        {
            SendNotifications obj = new SendNotifications();
            obj.SendEmail();
        }
    }
}
