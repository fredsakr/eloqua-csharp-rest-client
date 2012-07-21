using Eloqua.Api.Rest.Client.Models.Assets;
using Eloqua.Api.Rest.Client.Models.Data;

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
