using Eloqua.Api.Rest.ClientLibrary.Clients.Assets;
using Eloqua.Api.Rest.ClientLibrary.Clients.Data;
using Eloqua.Api.Rest.ClientLibrary.Clients.Systems;
using Eloqua.Api.Rest.ClientLibrary.Models.Account;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary
{
    public class Client : BaseClient
    {
        protected BaseClient BaseClient;

        public Client(string site, string user, string password, string baseUrl)
        {
            BaseClient = new BaseClient(site, user, password, baseUrl);
        }

        public static AccountInfo GetAccountInfo(string site, string user, string password)
        {
            var client = new BaseClient(site, user, password, "https://login.eloqua.com");
            return client.Execute<AccountInfo>(new RestRequest("id", Method.GET));
        }

        public AssetClient Assets
        {
            get { return _assetClient ?? (_assetClient = new AssetClient(BaseClient)); }
        }
        private AssetClient _assetClient;

        public DataClient Data
        {
            get { return _dataClient ?? (_dataClient = new DataClient(BaseClient)); }
        }
        private DataClient _dataClient;

        public SystemClient Systems
        {
            get { return _systemClient ?? (_systemClient = new SystemClient(BaseClient)); }
        }
        private SystemClient _systemClient;
    }
}