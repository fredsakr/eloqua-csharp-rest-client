using Eloqua.Api.Rest.ClientLibrary.Models.Systems.Cloud;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Systems
{
    public class SystemClient
    {
        #region constructor 

        public SystemClient(BaseClient baseClient)
        {
            BaseClient = baseClient;
        }

        #endregion

        #region properties

        protected BaseClient BaseClient;

        #endregion

        #region Cloud Data

        public GenericClient<CloudDataInstance> CloudData
        {
            get { return _cloudDataClient ?? (_cloudDataClient = new GenericClient<CloudDataInstance>(BaseClient)); }
        }
        private GenericClient<CloudDataInstance> _cloudDataClient;

        #endregion
    }
}
