using Eloqua.Api.Rest.Client.Models;
using RestSharp;

namespace Eloqua.Api.Rest.Client
{
    public class BaseClient
    {
        #region constructors

        protected BaseClient() {}

        public BaseClient(string site, string user, string password)
        {
            Client = new RestClient
            {
                BaseUrl = BaseUrl,
                Authenticator = new HttpBasicAuthenticator(site + "\\" + user, password)
            };
        }

        #endregion
        
        #region properties

        protected const string BaseUrl = "https://secure.eloqua.com/API/REST/1.0";

        internal RestClient Client { get; set; }

        #endregion

        #region methods

        private T Execute<T>(IRestRequest request) where T : new()
        {
            IRestResponse<T> response = Client.Execute<T>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

        public T Get<T>(int id) where T : IRestObject, new()
        {
            var item = new T { id = id };
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Get, item);
            return Execute<T>(request);
        }

        public RequestObjectList<T> Get<T>(string searchTerm, int pageNumber, int pageSize) where T : IRestObject, new()
        {
            var items = new T { SearchTerm = searchTerm, PageNumber = pageNumber, PageSize = pageSize };
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Search, items);
            var result = Execute<RequestObjectList<T>>(request);
            return result;
        }

        public void Delete<T>(int id) where T : IRestObject, new()
        {
            var item = new T { id = id };
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Delete, item);
            Execute<T>(request);
        }

        public T Post<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Post, restObj);
            request.AddBody(restObj);
            return Execute<T>(request);
        }

        public T Put<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Put, restObj);
            request.AddBody(restObj);
            return Execute<T>(request);
        }
        #endregion
    }
}