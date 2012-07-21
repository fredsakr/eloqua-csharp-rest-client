namespace Eloqua.Api.Rest.Client
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class Resource : System.Attribute
    {
        public Resource(string uri)
        {
            _uri = uri;
        }

        public string Uri { get { return _uri; } }
        private string _uri;
    }
}
