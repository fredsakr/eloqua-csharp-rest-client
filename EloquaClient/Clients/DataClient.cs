using Eloqua.Api.Rest.Client.Models.Data.Account;
using Eloqua.Api.Rest.Client.Models.Data.Contacts;
using Eloqua.Api.Rest.Client.Models.Data.CustomObjects;

namespace Eloqua.Api.Rest.Client.Clients
{
    public class DataClient
    {
        #region constructor 

        public DataClient(BaseClient baseClient)
        {
            BaseClient = baseClient;
        }

        #endregion

        #region properties

        protected BaseClient BaseClient;

        #endregion

        #region Contacts

        public GenericClient<Contact> Contact
        {
            get { return _contactClient ?? (_contactClient = new GenericClient<Contact>(BaseClient)); }
        }
        private GenericClient<Contact> _contactClient;

        #endregion

        #region Accounts

        public GenericClient<Account> Account
        {
            get { return _accountClient ?? (_accountClient = new GenericClient<Account>(BaseClient)); }
        }
        private GenericClient<Account> _accountClient;

        #endregion

        #region CustomObjects

        public GenericClient<CustomObject> CustomObject
        {
            get { return _customObjectDataClient ?? (_customObjectDataClient = new GenericClient<CustomObject>(BaseClient)); }
        }
        private GenericClient<CustomObject> _customObjectDataClient;

        #endregion
    }
}
