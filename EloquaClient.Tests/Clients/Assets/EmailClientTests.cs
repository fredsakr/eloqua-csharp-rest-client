using NUnit.Framework;

namespace EloquaClient.Tests.Clients.Assets
{
    [TestFixture]
    public class EmailClientTests
    {
        [Test]
        public void GetEmailTest()
        {
            const int originalId = 8;
            var client = new Eloqua.Client("site", "user", "pass");
            var email = client.Email.Get(originalId);

            Assert.AreEqual(originalId, email.Id);
        }

        [Test]
        public void GetEmailListTest()
        {
            var client = new Eloqua.Client("site", "user", "pass");
            var emails = client.Email.Get("searchTerm", 1, 1);

            Assert.AreEqual(1, emails.elements.Count);
            
        }
    }
}
