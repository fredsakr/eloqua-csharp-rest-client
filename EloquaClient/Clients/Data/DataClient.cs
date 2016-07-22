using Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjectData;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Account;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Forms;

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

        public SearchMembersClient<ContactListMember> ContactListMember
        {
            get { return _contactListMemberClient ?? (_contactListMemberClient = new SearchMembersClient<ContactListMember>(BaseClient)); }
        }

        private SearchMembersClient<ContactListMember> _contactListMemberClient;

        public ActivityClient Activity
        {
            get { return _activity ?? (_activity = new ActivityClient(BaseClient)); }
        }

        private ActivityClient _activity;

        public SubscriptionClient ContactEmailSubscription
        {
            get { return _subscription ?? (_subscription = new SubscriptionClient(BaseClient)); }
        }

        private SubscriptionClient _subscription;

        public GenericClient<FormData> FormData
        {
            get { return _formData ?? (_formData = new GenericClient<FormData>(BaseClient)); }
        }

        private GenericClient<FormData> _formData;


        #endregion

        #region Accounts

        public GenericClient<Account> Account
        {
            get { return _accountClient ?? (_accountClient = new GenericClient<Account>(BaseClient)); }
        }
        private GenericClient<Account> _accountClient;

        #endregion

        #region CustomObjects

        public CustomObjectDataClient<CustomObjectData> CustomObjectData
        {
            get { return _customObjectDataClient ?? (_customObjectDataClient = new CustomObjectDataClient<CustomObjectData>(BaseClient)); }
        }
        private CustomObjectDataClient<CustomObjectData> _customObjectDataClient;

        #endregion

        #region External Activities

        public ExternalActivityClient ExternalActivity
        {
            get { return _externalActivity ?? (_externalActivity = new ExternalActivityClient(BaseClient)); }
        }

        private ExternalActivityClient _externalActivity;

        #endregion
    }
}
