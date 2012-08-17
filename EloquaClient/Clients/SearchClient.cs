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

        public RestObjectList<T> Get(int? id, string search, int pageNumber, int pageSize)
        {
            return _baseClient.Get<T>(id, search, pageNumber, pageSize);
        }
    }
}
