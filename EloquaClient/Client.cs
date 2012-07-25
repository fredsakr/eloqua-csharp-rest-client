using Eloqua.Api.Rest.Client.Clients;

namespace Eloqua.Api.Rest.Client
{
    public class Client : BaseClient
    {
        #region constructor

        protected BaseClient BaseClient;

        public Client(string site, string user, string password)
        {
            BaseClient = new BaseClient(site, user, password);
        }

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
