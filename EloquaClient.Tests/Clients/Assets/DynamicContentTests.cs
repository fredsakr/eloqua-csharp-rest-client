using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class DynamicContentTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void SearchContentSectionTest()
        {
            var dynamicContents = _client.Assets.DynamicContent.Get("*", 1, 100);
            Assert.Greater(dynamicContents.total, 0);
        }
    }
}
