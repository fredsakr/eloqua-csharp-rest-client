using RestSharp;

namespace Eloqua.Api.Rest.Client
{
    internal class Authenticator : IAuthenticator
    {
        private readonly HttpBasicAuthenticator _authenticator;

        internal Authenticator(string site, string user, string password)
        {
            _authenticator = new HttpBasicAuthenticator(site + "\\" + user, password);
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            _authenticator.Authenticate(client, request);
        }
    }
}
