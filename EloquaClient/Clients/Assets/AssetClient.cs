using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Accounts.Views;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Lists;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Segments;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.DynamicContents;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Groups;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.LandingPages;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Microsites;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.OptionLists;

namespace Eloqua.Api.Rest.ClientLibrary.Clients.Assets
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

        public GenericClient<Models.Assets.Emails.Structured.Email> StructuredEmail
        {
            get { return _structuredEmailClient ?? ( _structuredEmailClient = new GenericClient<Models.Assets.Emails.Structured.Email>(BaseClient)); }
        }
        private GenericClient<Models.Assets.Emails.Structured.Email> _structuredEmailClient;

        public GenericClient<EmailGroup> EmailGroup
        {
            get { return _emailGroupClient ?? (_emailGroupClient = new GenericClient<EmailGroup>(BaseClient)); }
        }
        private GenericClient<EmailGroup> _emailGroupClient; 

        #endregion

        #region EmailDeployment

        public SearchClient<EmailDeployment> EmailDeployment
        {
            get { return _emailDeployment ?? (_emailDeployment = new SearchClient<EmailDeployment>(BaseClient)); }
        }
        private SearchClient<EmailDeployment> _emailDeployment; 

        public GenericClient<EmailInlineDeployment> EmailInlineDeployment
        {
            get { return _emailInlineDeployment ?? (_emailInlineDeployment = new GenericClient<EmailInlineDeployment>(BaseClient)); }
        }
        private GenericClient<EmailInlineDeployment> _emailInlineDeployment;

        public GenericClient<Models.Assets.Emails.Deployment.Structured.EmailInlineDeployment> StructuredEmailInlineDeployment
        {
            get { return _structuredEmailInlineDeployment ?? (_structuredEmailInlineDeployment = new GenericClient<Models.Assets.Emails.Deployment.Structured.EmailInlineDeployment>(BaseClient)); }
        }
        private GenericClient<Models.Assets.Emails.Deployment.Structured.EmailInlineDeployment> _structuredEmailInlineDeployment;

        public GenericClient<EmailTestDeployment> EmailTestDeployment
        {
            get { return _emailTestDeployment ?? (_emailTestDeployment = new GenericClient<EmailTestDeployment>(BaseClient)); }
        } 

        private GenericClient<EmailTestDeployment> _emailTestDeployment;

        #endregion

        #region LandingPages

        public GenericClient<LandingPage> LandingPage
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<LandingPage>(BaseClient)); }
        }
        private GenericClient<LandingPage> _landingPage;

        public GenericClient<Models.Assets.LandingPages.Structured.LandingPage> StructuredLandingPage
        {
            get { return _structuredLandingPage ?? (_structuredLandingPage = new GenericClient<Models.Assets.LandingPages.Structured.LandingPage>(BaseClient)); }
        }
        private GenericClient<Models.Assets.LandingPages.Structured.LandingPage> _structuredLandingPage;

        #endregion

        #region CustomObjects

        public GenericClient<CustomObject> CustomObject
        {
            get { return _customObjectClient ?? (_customObjectClient = new GenericClient<CustomObject>(BaseClient)); }
        }
        private GenericClient<CustomObject> _customObjectClient;

        #endregion

        #region Microsites

        public GenericClient<Microsite> Microsite
        {
            get { return _micrositeClient ?? (_micrositeClient = new GenericClient<Microsite>(BaseClient)); }
        }
        private GenericClient<Microsite> _micrositeClient;

        #endregion

        #region OptionLists

        public GenericClient<OptionList> OptionList
        {
            get { return _optionList ?? (_optionList = new GenericClient<OptionList>(BaseClient)); }
        }
        private GenericClient<OptionList> _optionList;

        #endregion

        #region Content 

        public GenericClient<DynamicContent> DynamicContent
        {
            get { return _dynamicContent ?? (_dynamicContent = new GenericClient<DynamicContent>(BaseClient)); }
        }
        private GenericClient<DynamicContent> _dynamicContent;

        public GenericClient<ContentSection> ContentSection
        {
            get { return _contentSection ?? (_contentSection = new GenericClient<ContentSection>(BaseClient)); }
        }
        private GenericClient<ContentSection> _contentSection;

        #endregion
    }
}
