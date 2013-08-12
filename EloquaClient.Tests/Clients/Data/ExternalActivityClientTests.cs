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
            Client client = new Client("site", "user", "password", "baseurl");
            Activity activity = new Activity();
            ExternalActivities externalActivities = new ExternalActivities();
            externalActivities.activityDate = "";
            externalActivities.activityType = "Webinar";
            externalActivities.assetName = "";
            externalActivities.assetType = "";
            externalActivities.contactID = "100";
            externalActivities.fieldValues = "";
            ExternalActivities postExternalActivities;
            postExternalActivities = client.Data.ExternalActivity.Post(externalActivities);
            ExternalActivities returnExternalActivities;
            returnExternalActivities = client.Data.ExternalActivity.Get(int.Parse(postExternalActivities.contactID));
        }
    }
}
