using Eloqua.Models.Assets;
using Eloqua.Models.Data;

namespace Eloqua
{
    public class Client
    {
        #region constructor

        protected GenericRequest GenericRequest;

        public Client(string site, string user, string password)
        {
            GenericRequest = new GenericRequest(site, user, password);
        }

        #endregion

        #region Email Client

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(GenericRequest)); }
        }
        private GenericClient<Email> _emailClient;

        #endregion

        #region LandingPage Client

        public GenericClient<LandingPage> LandingPage
        {
            get { return _segment ?? (_segment = new GenericClient<LandingPage>(GenericRequest)); }
        }
        private GenericClient<LandingPage> _segment;

        #endregion

        #region Segment Client

        public GenericClient<Segment> Segment
        {
            get { return _landingPage ?? (_landingPage = new GenericClient<Segment>(GenericRequest)); }
        }
        private GenericClient<Segment> _landingPage;

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
