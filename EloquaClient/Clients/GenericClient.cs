using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Clients
{
    public class GenericClient<T> where T : RestObject, ISearchable, new()
    {
        public GenericClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public T Get(int id)
        {
            return _baseClient.Get<T> (id);
        }

        public RestObjectList<T> Get(string search, int pageNumber, int pageSize)
        {
            return _baseClient.Get<T> (search, pageNumber, pageSize);
        }

        public RestObjectList<T> Get(int? id, string search, int pageNumber, int pageSize)
        {
            return _baseClient.Get<T>(id, search, pageNumber, pageSize);
        }

        public T Post(T restObj)
        {
            return _baseClient.Post<T>(restObj);
        }

        public T Put(T restObj)
        {
            return _baseClient.Put(restObj);
        }

        public void Delete(int? id)
        {
            _baseClient.Delete<T> (id);
        }
    }
}
