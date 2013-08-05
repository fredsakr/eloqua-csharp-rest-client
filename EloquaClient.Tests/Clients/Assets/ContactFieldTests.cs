using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class ContactFieldTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void SearchContactFields()
        {
            var fields = _client.Assets.ContactFields.Get("*", 1, 100);
            Assert.Greater(fields.total, 0);
        }
    }
}
