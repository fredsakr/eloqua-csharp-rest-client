using Eloqua.Api.Rest.ClientLibrary.Models.Data.ExternalActivities;
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
        public void CreateAndReadActivityTest()
        {
            Activity activity = new Activity();
            ExternalActivities externalActivities = new ExternalActivities();
            externalActivities.activityDate = "1362543780";
            externalActivities.activityType = "Webinar";
            externalActivities.assetName = "TEST_GENERIC_Asset";
            externalActivities.assetType = "Test_Generic_Asset_Type";
            externalActivities.contactId = "100";
            externalActivities.campaignId = "4";
            externalActivities.type = "ExternalActivities";

            ExternalActivities postExternalActivities;
            postExternalActivities = _client.Data.ExternalActivity.Post(externalActivities);
            ExternalActivities returnExternalActivities;
            returnExternalActivities = _client.Data.ExternalActivity.Get(int.Parse(postExternalActivities.contactId));
        }
    }
}
