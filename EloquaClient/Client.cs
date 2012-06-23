using Eloqua.Models.Assets;

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

        #region email client

        public GenericClient<Email> Email
        {
            get { return _emailClient ?? (_emailClient = new GenericClient<Email>(GenericRequest)); }
        }
        private GenericClient<Email> _emailClient;

        #endregion
    }
}
