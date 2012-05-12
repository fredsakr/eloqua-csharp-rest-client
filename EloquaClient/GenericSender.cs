using System;
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

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new ApiException(new Exception(response.ErrorMessage, response.ErrorException));
            }
            return response.Data;
        }

        internal T Get<T>(IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Get, restObj);
            return Execute<T>(request);
        }

        internal void Delete<T>(IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Delete, restObj);
            Execute<T>(request);
        }

        internal T Post<T>(T rest, IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Post, restObj);
            request.AddBody(restObj);
            return Execute<T>(request);
        }

        internal T Put<T>(T rest, IRestObject restObj) where T : new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Put, restObj);
            request.AddBody(restObj);
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
