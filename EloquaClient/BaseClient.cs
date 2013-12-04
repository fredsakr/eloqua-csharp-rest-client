using RestSharp;
using Eloqua.Api.Rest.ClientLibrary.Models;
using RestSharp.Deserializers;

namespace Eloqua.Api.Rest.ClientLibrary
{
    public class BaseClient
    {
        protected BaseClient() {}

        public BaseClient(string site, string user, string password, string baseUrl)
        {
            Client = new RestClient
            {
                BaseUrl = baseUrl,
                Authenticator = new HttpBasicAuthenticator(site + "\\" + user, password)
            };

            Client.AddHandler("text/plain", new JsonDeserializer());
        }

        internal RestClient Client { get; set; }

        internal T Execute<T>(IRestRequest request) where T : new()
        {
            IRestResponse<T> response = Client.Execute<T>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw Validation.ResponseValidator.GetExceptionFromResponse(response);
            }
            return response.Data;
        }

        public T Get<T>(T data) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Get, data);
            return Execute<T>(request);
        }

        public void Delete<T>(T data) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Delete, data);
            Execute<T>(request);
        }

        public T Post<T>(T data) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Post, data);
            return Execute<T>(request);
        }

        public T Put<T>(T data) where T : RestObject, new()
        {
            var request = Request.Get(Request.Type.Put, data);
            return Execute<T>(request);
        }

        public SearchResponse<T> Search<T>(T data) where T : RestObject, ISearchable, new()
        {
            var request = Request.Get(Request.Type.Search, data);
            return Execute<SearchResponse<T>>(request);
        }

        public SearchResponse<T> Search<T>(int id, T data) where T : RestObject, ISearchable, new()
        {
            var request = Request.Get(Request.Type.Search, data);
            return Execute<SearchResponse<T>>(request);
        }
    }
}