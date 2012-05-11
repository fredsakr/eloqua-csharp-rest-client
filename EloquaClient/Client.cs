using Eloqua.Clients.Assets;

namespace Eloqua
{
    public class Client 
    {
        #region constructor

        protected GenericSender GenericSender;

        public Client(string site, string user, string password)
        {
            GenericSender = new GenericSender(site, user, password);
        }

        #endregion

        #region clients

        public EmailClient Email
        {
            get { return _emailClient ?? (_emailClient = new EmailClient(GenericSender)); }
        }
        private EmailClient _emailClient;

        #endregion
    }
}
