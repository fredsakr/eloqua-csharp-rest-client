using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Clients
{
    public class SearchMembersClient<T>  where T : RestObject, ISearchable, new()
    {
        public SearchMembersClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public SearchResponse<T> Get(int? id, string search, int pageNumber, int pageSize, Depth depth = Depth.complete)
        {
            return _baseClient.Get<T>(id, search, pageNumber, pageSize, depth);
        }
    }
}
