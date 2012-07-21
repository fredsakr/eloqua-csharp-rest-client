using Eloqua.Api.Rest.Client.Models.Assets;
using Eloqua.Api.Rest.Client.Models.Data;

namespace Eloqua.Api.Rest.Client
{
    public class Client : ClientBase
    {
        #region constructor

        protected ClientBase GenericRequest;

        public Client(string site, string user, string password)
        {
            GenericRequest = new ClientBase(site, user, password);
        }

        #endregion


        #region Assets

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(GenericRequest)); }
        }
        private GenericClient<Email> _emailClient;

        public GenericClient<LandingPage> LandingPage
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<LandingPage>(GenericRequest)); }
        }
        private GenericClient<LandingPage> _landingPage;

        #endregion


        #region Contacts

        public GenericClient<Contact> Contact
        {
            get { return _contactClient ?? (_contactClient = new GenericClient<Contact>(GenericRequest)); }
        }
        private GenericClient<Contact> _contactClient;

        public GenericClient<ContactSegment> ContactSegment
        {
            get { return _contactSegment ?? (_contactSegment = new GenericClient<ContactSegment>(GenericRequest)); }
        }
        private GenericClient<ContactSegment> _contactSegment;

        public GenericClient<ContactList> ContactList
        {
            get { return _contactList ?? (_contactList = new GenericClient<ContactList>(GenericRequest)); }
        }
        private GenericClient<ContactList> _contactList;

        #endregion


        #region Custom Object

        public GenericClient<CustomObject> CustomObject
        {
            get { return _customObjectClient ?? (_customObjectClient = new GenericClient<CustomObject>(GenericRequest)); }
        }
        private GenericClient<CustomObject> _customObjectClient;

        #endregion
    }
}
