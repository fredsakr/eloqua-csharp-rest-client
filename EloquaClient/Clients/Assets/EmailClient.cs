using Eloqua.Models.Assets;

namespace Eloqua.Clients.Assets
{
    public class EmailClient : GenericClient<Email>
    {
        public EmailClient(GenericRequest request) : base(request) {}
    }
}
