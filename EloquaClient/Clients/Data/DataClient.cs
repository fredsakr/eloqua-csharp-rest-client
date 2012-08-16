using Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjects;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Account;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Data
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

        public ContactListMemberClient<Contact> ContactListMember
        {
            get { return _contactListMemberClient ?? (_contactListMemberClient = new ContactListMemberClient<Contact>(BaseClient)); }
        }

        private ContactListMemberClient<Contact> _contactListMemberClient;

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
