using Eloqua.Api.Rest.Client.Models;

namespace Eloqua.Api.Rest.Client
{
    public class GenericClient<T> where T : IRestObject, new()
    {
        public GenericClient(ClientBase clientBase)
        {
            _client = clientBase;
        }
        readonly ClientBase _client;

        public T Get(int id)
        {
            return _client.Get<T> (id);
        }

        public RequestObjectList<T> Get(string search, int pageNumber, int pageSize)
        {
            return _client.Get<T> (search, pageNumber, pageSize);
        }

        public T Post(T restObj)
        {
            return _client.Post<T>(restObj);
        }

        public T Put(T restObj)
        {
            return _client.Put<T>(restObj);
        }

        public void Delete(int id)
        {
            _client.Delete<T> (id);
        }
    }
}
