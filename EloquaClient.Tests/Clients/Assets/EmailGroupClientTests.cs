using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class EmailGroupClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetEmailGroupTest()
        {
            const int emailGroupId = 8;
            var emailGroup = _client.Assets.EmailGroup.Get(emailGroupId);

            Assert.AreEqual(emailGroupId, emailGroup.id);
        }

        [Test]
        public void GetEmailGroupListTest()
        {
            var result = _client.Assets.EmailGroup.Get("*", 1, 100);
            Assert.AreEqual(1, result.elements.Count);
        }
    }
}
