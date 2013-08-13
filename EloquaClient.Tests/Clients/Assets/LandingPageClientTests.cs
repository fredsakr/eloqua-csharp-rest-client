using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class LandingPageClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "username", "password", Constants.BaseUrl3);
        }

        [Test]
        public void SearchLandingPageTest()
        {
            var landingPages = _client.Assets.LandingPage.Get("id=9", 1, 100);
            Assert.Greater(landingPages.elements.Count, 0);
        }
    }
}
