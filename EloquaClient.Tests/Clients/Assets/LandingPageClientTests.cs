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
            _client = new Client("site", "user", "password", "https://secure.eloqua.com/API/REST/2.0/");
        }

        [Test]
        public void SearchLandingPageTest()
        {
            var landingPages = _client.Assets.StructuredLandingPage.Get("fsTest*", 1, 100);
            Assert.Greater(landingPages.elements.Count, 0);
        }

        [Test]
        public void GetandPutTest()
        {
            var lp = _client.Assets.StructuredLandingPage.Get(2500);
            lp.htmlContent.cssHeader = "<style type=\"text/css\">test ab</style>";
            lp.micrositeId= 6;
            lp.name = "fsTest sample 1";
            lp.htmlContent.id = -500001;
            var result = _client.Assets.StructuredLandingPage.Put(lp);
        }
    }
}
