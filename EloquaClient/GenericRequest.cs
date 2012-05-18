using System;
using System.Collections.Generic;
using RestSharp;

namespace Eloqua
{
    public class GenericRequest
    {
        #region constructors

        public GenericRequest(string site, string user, string password)
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

        internal T Get<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Get, restObj);
            return Execute<T>(request);
        }

        internal void Delete<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Delete, restObj);
            Execute<T>(request);
        }

        internal T Post<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Post, restObj);
            request.AddBody(restObj);
            return Execute<T>(request);
        }

        internal T Put<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Put, restObj);
            request.AddBody(restObj);
            return Execute<T>(request);
        }

        internal RestObjectList<T> Search<T>(T restObj) where T : IRestObject, new()
        {
            var request = RequestFactory.GetRequest(RequestFactory.RequestType.Search, restObj);
            return ExecuteForList<T>(request);
        }

        private RestObjectList<T> ExecuteForList<T>(IRestRequest request) where T : new()
        {
            IRestResponse<RestObjectList<T>> response = Client.Execute<RestObjectList<T>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new ApiException(new Exception(response.ErrorMessage, response.ErrorException));
            }
            return response.Data;
        }

        #endregion
    }

    public class RestObjectList<T>
    {
        public List<T> elements { get; set; }
    }
}