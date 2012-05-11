using RestSharp;

namespace Eloqua
{
    public class GenericSender
    {
        #region constructors

        public GenericSender(string site, string user, string password)
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

        #region generic methods

        private T Execute<T>(IRestRequest request) where T : new()
        {
            IRestResponse<T> response = Client.Execute<T>(request);
            return response.Data;
        }

        // todo : each method is expected to implement its own error handling - based on the HTTP Method
        internal T Get<T>(IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Get, restObj);
            return Execute<T>(request);
        }

        internal void Delete<T>(IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Delete, restObj);
            Client.Execute<T>(request);
        }

        internal T Post<T>(T rest, IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Post, restObj);
            return Execute<T>(request);
        }

        internal T Put<T>(T rest, IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Put, restObj);
            return Execute<T>(request);
        }

        internal T Search<T>(IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Search, restObj);
            return Execute<T>(request);
        }

        #endregion
    }
}
