using Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjectData;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class CustomObjectDataClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetCustomObjectTest()
        {
            const int originalId = 1;
            const int parentId = 1;
            var customObjectData = _client.Data.CustomObjectData.Get(parentId, originalId);

            Assert.AreEqual(originalId, customObjectData.id);
        }

        [Test]
        public void SearchCustomObjectTest()
        {
            const int parentId = 1;
            var result = _client.Data.CustomObjectData.Get(parentId, "*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }
    }
}
