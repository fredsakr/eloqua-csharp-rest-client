using Eloqua.Api.Rest.ClientLibrary.Models.Data.ExternalActivities;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Data
{
    public class ExternalActivityClient
    {
        public ExternalActivityClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public ExternalActivities Get(int? id)
        {
            var request = new RestRequest(Method.GET)
            {
                RequestFormat = DataFormat.Json,
                Resource = string.Format("/data/activity/{0}", id)
            };

            return _baseClient.Execute<ExternalActivities>(request);
        }

        public ExternalActivities Post(ExternalActivities activities)
        {
            var request = new RestRequest(Method.POST)
            {
                RequestFormat = DataFormat.Json,
                Resource = "/data/activity"
            };

            request.AddBody(activities);
            return _baseClient.Execute<ExternalActivities>(request);
        }
    }
}
