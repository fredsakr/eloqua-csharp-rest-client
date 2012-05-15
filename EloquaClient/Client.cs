using Eloqua.Clients.Assets;

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

        #region clients

        public EmailClient Email
        {
            get { return _emailClient ?? (_emailClient = new EmailClient(GenericRequest)); }
        }
        private EmailClient _emailClient;

        #endregion
    }
}
