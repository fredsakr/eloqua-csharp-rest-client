using Eloqua.Api.Rest.Client.Models.Assets.Accounts.Views;
using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Lists;
using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Segments;
using Eloqua.Api.Rest.Client.Models.Assets.Contacts.Views;
using Eloqua.Api.Rest.Client.Models.Assets.Emails;
using Eloqua.Api.Rest.Client.Models.Assets.LandingPages;

namespace Eloqua.Api.Rest.Client.Clients
{
    public class AssetClient
    {
        #region constructor 

        public AssetClient(BaseClient baseClient)
        {
            BaseClient = baseClient;
        }

        #endregion

        #region properties

        protected BaseClient BaseClient;

        #endregion

        #region Contact Assets

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

        #region Account Assets

        public GenericClient<AccountView> AccountView
        {
            get { return _accountView ?? (_accountView = new GenericClient<AccountView>(BaseClient)); }
        }
        private GenericClient<AccountView> _accountView;

        #endregion

        #region Email

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(BaseClient)); }
        }
        private GenericClient<Email> _emailClient;

        #endregion

        #region LandingPages

        public GenericClient<LandingPage> LandingPage
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<LandingPage>(BaseClient)); }
        }
        private GenericClient<LandingPage> _landingPage;

        #endregion

        #region CustomObjects

        public GenericClient<Models.Assets.CustomObjects.CustomObject> CustomObject
        {
            get { return _customObjectClient ?? (_customObjectClient = new GenericClient<Models.Assets.CustomObjects.CustomObject>(BaseClient)); }
        }
        private GenericClient<Models.Assets.CustomObjects.CustomObject> _customObjectClient;

        #endregion

        #region Microsites

        public GenericClient<Models.Assets.Microsites.Microsite> Microsite
        {
            get { return _micrositeClient ?? (_micrositeClient = new GenericClient<Models.Assets.Microsites.Microsite>(BaseClient)); }
        }
        private GenericClient<Models.Assets.Microsites.Microsite> _micrositeClient;

        #endregion
    }
}
