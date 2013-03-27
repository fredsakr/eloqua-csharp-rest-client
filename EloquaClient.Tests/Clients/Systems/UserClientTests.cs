using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Systems
{
    [TestFixture]
    public class UserClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void SearchUsersTest()
        {
            var response = _client.Systems.User.Get("*", 1, 10);
            Assert.Greater(response.total, 0);
        }
    }
}
