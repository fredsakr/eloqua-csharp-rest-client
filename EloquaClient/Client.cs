using Eloqua.Api.Rest.Client.Models.Assets;
using Eloqua.Api.Rest.Client.Models.Data;

namespace Eloqua.Api.Rest.Client
{
    public class Client : ClientBase
    {
        #region constructor

        protected ClientBase ClientBase;

        public Client(string site, string user, string password)
        {
            ClientBase = new ClientBase(site, user, password);
        }

        #endregion


        #region Assets

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(ClientBase)); }
        }
        private GenericClient<Email> _emailClient;

        public GenericClient<LandingPage> LandingPage
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<LandingPage>(ClientBase)); }
        }
        private GenericClient<LandingPage> _landingPage;

        #endregion


        #region Contacts

        public GenericClient<Contact> Contact
        {
            get { return _contactClient ?? (_contactClient = new GenericClient<Contact>(ClientBase)); }
        }
        private GenericClient<Contact> _contactClient;

        public GenericClient<ContactSegment> ContactSegment
        {
            get { return _contactSegment ?? (_contactSegment = new GenericClient<ContactSegment>(ClientBase)); }
        }
        private GenericClient<ContactSegment> _contactSegment;

        public GenericClient<ContactList> ContactList
        {
            get { return _contactList ?? (_contactList = new GenericClient<ContactList>(ClientBase)); }
        }
        private GenericClient<ContactList> _contactList;

        #endregion


        #region Custom Object

        public GenericClient<CustomObject> CustomObject
        {
            get { return _customObjectClient ?? (_customObjectClient = new GenericClient<CustomObject>(ClientBase)); }
        }
        private GenericClient<CustomObject> _customObjectClient;

        #endregion
    }
}
