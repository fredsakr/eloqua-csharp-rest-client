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

        public T Get(int id, Depth depth = Depth.minimal)
        {
            var data = new T { id = id, depth = depth.ToString() };
            return _baseClient.Get<T>(data);
        }

        public T Post(T data)
        {
            return _baseClient.Post<T>(data);
        }

        public T Put(T data)
        {
            return _baseClient.Put(data);
        }

        public void Delete(int? id)
        {
            var data = new T { id = id };
            _baseClient.Delete<T>(data);
        }

        public SearchResponse<T> Get(string search, int pageNumber, int pageSize, Depth depth = Depth.complete)
        {
            return _baseClient.Search<T>(new T
                {
                    searchTerm = search,
                    page = pageNumber,
                    pageSize = pageSize,
                    depth = depth.ToString()
                });
        }

        public SearchResponse<T> Get(int? id, string search, int pageNumber, int pageSize, Depth depth = Depth.complete)
        {
            return _baseClient.Search<T>(new T
                    {
                        id = id,
                        searchTerm = search,
                        page = pageNumber,
                        pageSize = pageSize,
                        depth = depth.ToString()
                    });
        }
    }
}