using NUnit.Framework;

namespace EloquaClient.Tests.Clients.Data
{
    [TestFixture]
    public class CustomObjectClientTests
    {
        private Eloqua.Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Eloqua.Client("site", "user", "password");
        }

        [Test]
        public void GetCustomObjectTest()
        {
            const int originalId = 1;
            var customObject = _client.CustomObject.Get(originalId);

            Assert.AreEqual(originalId, customObject.id);
        }

        [Test]
        public void SearchCustomObjectTest()
        {
            var result = _client.CustomObject.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }
    }
}
