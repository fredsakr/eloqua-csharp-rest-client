using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class ExternalAssetTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetExternalAssetsTest()
        {
            var response = _client.Assets.ExternalAsset.Get("*", 1, 10);
            Assert.Greater(response.total, 0);
        }
    }
}
