using NUnit.Framework;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class ContactClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetContactTest()
        {
            const int originalId = 1;
            var contact = _client.Data.Contact.Get(originalId);

            Assert.AreEqual(originalId, contact.id);
        }

        [Test]
        public void SearchContactTest()
        {
            var result = _client.Data.Contact.Get("*", 1, 1);
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

            Contact returnedContact = _client.Data.Contact.Post(contact);

            Assert.AreEqual(contact.emailAddress, returnedContact.emailAddress);
        }
    }
}
