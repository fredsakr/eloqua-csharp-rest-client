using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class CustomObjectClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetCustomObjectTest()
        {
            const int originalId = 1;
            var customObject = _client.Data.CustomObject.Get(originalId);

            Assert.AreEqual(originalId, customObject.id);
        }

        [Test]
        public void SearchCustomObjectTest()
        {
            var result = _client.Data.CustomObject.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }
    }
}
