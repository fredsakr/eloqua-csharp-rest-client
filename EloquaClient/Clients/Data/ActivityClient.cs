using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Activities;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Data
{
    public class ActivityClient
    {
        public ActivityClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public List<Activity> Get(int? id, string type, int count, long startDate, long endDate, int page)
        {
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Resource = string.Format("/data/activities/contact/{0}/{1}?count={2}&startAt={3}&endAt={4}&page={5}", id, type, count, startDate, endDate, page) 
            };

            return _baseClient.Execute<List<Activity>>(request);
        }

        public List<BouncebackActivity> Get(int? id, int count, long startDate, long endDate, int page)
        {
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                RootElement = "elements",
                Resource = string.Format("/data/activities/contact/{0}/automation/bounceback?count={1}&startAt={2}&endAt={3}&page={4}", id, count, startDate, endDate, page)
            };

            return _baseClient.Execute<List<BouncebackActivity>>(request);
        }
    }
}
