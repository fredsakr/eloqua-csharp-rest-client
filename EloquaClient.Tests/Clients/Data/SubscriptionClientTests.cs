using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class SubscriptionClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetEmailSubscriptionTest()
        {
            int? contactId = 44664;
            var result = _client.Data.ContactEmailSubscription.Get(contactId, "*", 1, 100);
            Assert.Greater(result.Count, 0);
        }
    }
}
