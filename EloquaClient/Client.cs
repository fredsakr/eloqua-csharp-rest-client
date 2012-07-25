using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Lists;
using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Segments;
using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Views;
using Eloqua.Api.Rest.Client.Models.Assets.Emails;
using Eloqua.Api.Rest.Client.Models.Assets.LandingPages;
using Eloqua.Api.Rest.Client.Models.Data.Account;
using Eloqua.Api.Rest.Client.Models.Data.Contacts;
using Eloqua.Api.Rest.Client.Models.Data.CustomObjects;

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

        #region Assets

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(BaseClient)); }
        }
        private GenericClient<Email> _emailClient;

        public GenericClient<LandingPage> LandingPage
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<LandingPage>(BaseClient)); }
        }
        private GenericClient<LandingPage> _landingPage;

        #endregion

        #region Contacts

        public GenericClient<Contact> Contact
        {
            get { return _contactClient ?? (_contactClient = new GenericClient<Contact>(BaseClient)); }
        }
        private GenericClient<Contact> _contactClient;

        public GenericClient<ContactSegment> ContactSegment
        {
            get { return _contactSegment ?? (_contactSegment = new GenericClient<ContactSegment>(BaseClient)); }
        }
        private GenericClient<ContactSegment> _contactSegment;

        public GenericClient<ContactList> ContactList
        {
            get { return _contactList ?? (_contactList = new GenericClient<ContactList>(BaseClient)); }
        }
        private GenericClient<ContactList> _contactList;

        public GenericClient<ContactView> ContactView
        {
            get { return _contactView ?? (_contactView = new GenericClient<ContactView>(BaseClient)); }
        }
        private GenericClient<ContactView> _contactView;

        #endregion

        #region Accounts

        public GenericClient<Account> Account
        {
            get { return _accountClient ?? (_accountClient = new GenericClient<Account>(BaseClient)); }
        }
        private GenericClient<Account> _accountClient;

        #endregion

        #region Custom Object

        public GenericClient<CustomObject> CustomObject
        {
            get { return _customObjectClient ?? (_customObjectClient = new GenericClient<CustomObject>(BaseClient)); }
        }
        private GenericClient<CustomObject> _customObjectClient;

        #endregion
    }
}
