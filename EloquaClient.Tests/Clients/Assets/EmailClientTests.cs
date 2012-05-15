using System;
using NUnit.Framework;

namespace EloquaClient.Tests.Clients.Assets
{
    [TestFixture]
    public class EmailClientTests
    {
        private Eloqua.Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Eloqua.Client("site", "user", "pass");
        }

        [Test]
        public void GetEmailTest()
        {
            const int originalId = 8;
            var email = _client.Email.Get(originalId);

            Assert.AreEqual(originalId, email.Id);
        }

        [Test]
        public void GetEmailListTest()
        {
            var emails = _client.Email.Get("searchTerm", 1, 1);
            Assert.AreEqual(1, emails.Count);
        }

        [Test]
        public void PostEmailTest()
        {
            var expectedEmail = new Eloqua.Models.Assets.Email()
                            {
                                name = "test-email",
                                emailGroupId = 1
                            };
            var email = _client.Email.Post(expectedEmail);
            Assert.AreEqual(expectedEmail, email);

            _client.Email.Delete(email.Id);
        }

        [Test]
        public void DeleteEmailTest()
        {
            var emailName = Guid.NewGuid().ToString();
            var email = new Eloqua.Models.Assets.Email()
            {
                name = emailName,
                emailGroupId = 1
            };

            email = _client.Email.Post(email);
            _client.Email.Delete(email.Id);

            var result = _client.Email.Get(emailName, 1, 1);
            //Assert.AreEqual(0, result.elements.Count);
        }
    }
}
