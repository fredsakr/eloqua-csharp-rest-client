using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class CustomObjectTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetFieldsTest()
        {
            var customObjects = _client.Assets.CustomObject.Get(12);
            var t = customObjects;
        }
    }
}
