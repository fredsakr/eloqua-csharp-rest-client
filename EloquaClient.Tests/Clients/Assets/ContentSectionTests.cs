using Eloqua.Api.Rest.ClientLibrary.Models;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.DynamicContents;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class ContentSectionTests
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
            var contentSections = _client.Assets.ContentSection.Get("*", 1, 100);
            Assert.Greater(contentSections.total, 0);
        }

        [Test]
        public void CreateContentSection()
        {
            var contentSection = new ContentSection()
                                     {
                                         id = -1,
                                         name = "sample content",
                                         scope = Scope.global.ToString(),
                                         contentHtml = "<html><head></head><body>sample content</body></html>"
                                     };

            var returnedContentSection = _client.Assets.ContentSection.Post(contentSection);
            Assert.AreEqual(contentSection.name, returnedContentSection.name);
        }
    }
}
