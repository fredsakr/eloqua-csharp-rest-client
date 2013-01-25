using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Clients
{
    public class SearchClient<T>  where T : RestObject, ISearchable, new()
    {
        public SearchClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public SearchResponse<T> Get(string search, int pageNumber, int pageSize, Depth depth = Depth.complete)
        {
            return _baseClient.Get<T>(search, pageNumber, pageSize, depth);
        }
    }
}
