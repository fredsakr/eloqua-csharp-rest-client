using NUnit.Framework;
using ContactField = Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views.ContactField;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class ContactFieldTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("sites", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void SearchContactFields()
        {
            var fields = _client.Assets.ContactFields.Get("*", 1, 100);
            Assert.Greater(fields.total, 0);
        }

        [Test]
        public void CreateContactField()
        {
            var field = new ContactField { name = "V_Notes", dataType = "largeText", updateType = "always", displayType = "text" };
            field = _client.Assets.ContactFields.Post(field);
            Assert.That(field.id, Is.Not.Null);

        }
    }
}
