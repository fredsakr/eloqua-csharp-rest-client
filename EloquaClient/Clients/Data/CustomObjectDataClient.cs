using Eloqua.Api.Rest.ClientLibrary.Models;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjectData;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Data
{
    public class CustomObjectDataClient<T> where T : RestObject, ISearchable, new()
    {
        public CustomObjectDataClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public CustomObjectData Get(int parentId, int id, Depth depth = Depth.minimal)
        {
            var data = new CustomObjectData { id = id, depth = depth.ToString() };
            var request = Request.Get(Request.Type.Get, parentId, data);
            return _baseClient.Execute<CustomObjectData>(request);
        }

        public CustomObjectData Post(int parentId, CustomObjectData data)
        {
            var request = Request.Get(Request.Type.Post, parentId, data);
            return _baseClient.Execute<CustomObjectData>(request);
        }

        public CustomObjectData Put(int parentId, CustomObjectData data)
        {
            var request = Request.Get(Request.Type.Put, parentId, data);
            return _baseClient.Execute<CustomObjectData>(request);
        }

        public void Delete(int parentId, int? id)
        {
            var data = new CustomObjectData { id = id };
            var request = Request.Get(Request.Type.Delete, parentId, data);
            _baseClient.Execute<CustomObjectData>(request);
        }

        public SearchResponse<CustomObjectData> Get(int parentId, string search, int pageNumber, int pageSize, Depth depth = Depth.complete)
        {
            var request = Request.Get(Request.Type.Search, parentId, new CustomObjectData
            {
                searchTerm = search,
                page = pageNumber,
                pageSize = pageSize,
                depth = depth.ToString()
            });
            return _baseClient.Execute<SearchResponse<CustomObjectData>>(request);
        }
    }
}
