using Eloqua.Api.Rest.ClientLibrary.Models;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary.Clients
{
    public class ContactListMemberClient<T> where T : RestObject, new()
    {
        public ContactListMemberClient(BaseClient baseClient)
        {
            _baseClient = baseClient;
        }
        readonly BaseClient _baseClient;

        public RestObjectList<T> Get(int listId, string search, int pageNumber, int pageSize)
        {
            var items = new T { searchTerm = search, page = pageNumber, pageSize = pageSize };

            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.GET,
                Resource = string.Format("/data/contacts/list/{0}?depth=minimal&count={1}&page={2}&search={3}", listId, pageSize, pageNumber, search) 
            };

            var result = _baseClient.Execute<RestObjectList<T>>(request);
            return result;
        }
    }
}
