using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class ExternalActivityClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetActivityTest()
        {
            var response = _client.Data.ExternalActivity.Get(1);
            Assert.IsNotNull(response);
        }

        [Test]
        public void CreateActivityTest()
        {

        }
    }
}
