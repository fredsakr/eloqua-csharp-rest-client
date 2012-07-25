using Eloqua.Api.Rest.Client.Models.Data.Contacts;
using NUnit.Framework;

namespace Eloqua.Api.Rest.Client.Tests.Clients.Data
{
    [TestFixture]
    public class ContactClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "pass");
        }

        [Test]
        public void GetContactTest()
        {
            const int originalId = 1;
            var contact = _client.Contact.Get(originalId);

            Assert.AreEqual(originalId, contact.id);
        }

        [Test]
        public void SearchContactTest()
        {
            var result = _client.Contact.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }

        [Test]
        public void CreateContactTest()
        {
            Contact contact = new Contact
                                  {
                                      id = -500002,
                                      firstName = "sample",
                                      lastName = "test",
                                      emailAddress = "sample@test.com"
                                  };

            Contact returnedContact = _client.Contact.Post(contact);

            Assert.AreEqual(contact.emailAddress, returnedContact.emailAddress);
        }
    }
}
