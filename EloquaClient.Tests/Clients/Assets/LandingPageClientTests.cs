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
            _client = new Client("site", "user", "password", "https://secure.eloqua.com/API/REST/1.0/");
        }

        [Test]
        public void SearchLandingPageTest()
        {
            var landingPages = _client.Assets.StructuredLandingPage.Get("*", 1, 100);
            Assert.Greater(landingPages.elements.Count, 0);
        }
    }
}
