using Eloqua.Api.Rest.ClientLibrary.Clients.Assets;
using Eloqua.Api.Rest.ClientLibrary.Clients.Data;

namespace Eloqua.Api.Rest.ClientLibrary
{
    public class Client : BaseClient
    {
        #region constructor

        public Client(string site, string user, string password)
        {
            BaseClient = new BaseClient(site, user, password);
        }

        #endregion

        #region properties

        protected BaseClient BaseClient;

        #endregion

        #region Assets Client

        public AssetClient Assets
        {
            get { return new AssetClient(BaseClient);}
        }

        #endregion

        #region Data Client

        public DataClient Data
        {
            get { return new DataClient(BaseClient); }
        }

        #endregion
    }
}
