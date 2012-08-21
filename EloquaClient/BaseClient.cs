using RestSharp;
using Eloqua.Api.Rest.ClientLibrary.Models;
using RestSharp.Deserializers;

namespace Eloqua.Api.Rest.ClientLibrary
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

            Client.AddHandler("text/plain", new JsonDeserializer());
        }

        #endregion
        
        #region properties

        protected const string BaseUrl = "https://secure.eloqua.com/API/REST/1.0";

        internal RestClient Client { get; set; }

        #endregion

        #region methods

        private IRestResponse Execute(IRestRequest request)
        {
            return Client.Execute(request);
        }

        internal T Execute<T>(IRestRequest request) where T : new()
        {
            IRestResponse<T> response = Client.Execute<T>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

        public T Get<T>(int id) where T : RestObject, new()
        {
            var item = new T { id = id };
            var request = Request.Get(Request.Type.Get, item);
            return Execute<T>(request);
        }

        public void Delete<T>(int? id) where T : RestObject, new()
        {
            var item = new T { id = id };
            var request = Request.Get(Request.Type.Delete, item);
            Execute<T>(request);
        }

        public T Post<T>(T restObj) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Post, restObj);
            return Execute<T>(request);
        }

        public T Put<T>(T restObj) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Put, restObj);
            return Execute<T>(request);
        }

        public RestObjectList<T> Get<T>(string searchTerm, int pageNumber, int pageSize) where T : RestObject, ISearchable, new()
        {
            var items = new T { searchTerm = searchTerm, page = pageNumber, pageSize = pageSize };
            var request = Request.Get(Request.Type.Search, items);
            return Execute<RestObjectList<T>>(request);
        }

        public RestObjectList<T> Get<T>(int? id, string searchTerm, int pageNumber, int pageSize) where T : RestObject, ISearchable, new()
        {
            var items = new T { id = id, searchTerm = searchTerm, page = pageNumber, pageSize = pageSize };
            var request = Request.Get(Request.Type.Search, items);
            return Execute<RestObjectList<T>>(request);
        }

        #endregion
    }
}