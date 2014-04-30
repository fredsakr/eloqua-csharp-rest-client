using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    public class FormClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetFormDataTest()
        {
            var data = _client.Data.FormData.Get(1);
            Assert.Greater(data.fieldValues.Count, 0);
        }
    }
}
