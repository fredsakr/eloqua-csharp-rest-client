using Eloqua;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EloquaClient.Tests.Assets
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void GetEmailTest()
        {
            var client = new Client("site", "user", "pass");
            var email = client.Email.Get(8);

            Assert.AreEqual(8, email.Id);
        }

        [TestMethod]
        public void GetEmailsTest()
        {
            var client = new Client("site", "user", "pass");
            var email = client.Email.Get("test", 1, 1);

            Assert.AreEqual(1, email.elements.Count);
        }
    }
}
