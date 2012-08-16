namespace Eloqua.Api.Rest.ClientLibrary
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class Resource : System.Attribute
    {
        public Resource(string uri, string type)
        {
            _uri = uri;
            _type = type;
        }

        public string Uri { get { return _uri; } }
        private readonly string _uri;

        public string Type { get { return _type; } }
        private readonly string _type;

    }
}
