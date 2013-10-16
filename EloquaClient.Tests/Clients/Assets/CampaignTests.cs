using Eloqua.Api.Rest.ClientLibrary.Models;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Campaigns;
using NUnit.Framework;
using ContactField = Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views.ContactField;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class CampaignTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("", "", "", Constants.BaseUrl);
        }

        [Test]
        public void SearchContactFields()
        {
            SearchResponse<Campaign> fields;
            
            int page = 1;
            do
            {
                fields = _client.Assets.Campaign.Get("*", page, 300, Depth.partial);
                page++;

            } while (fields.elements.Count == 300);
            Assert.Greater(fields.total, 0);
        }

    }
}
