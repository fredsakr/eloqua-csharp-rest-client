using System;

namespace Eloqua.Api.Rest.Client
{
    [Resource("")]
    public class RestObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public string depth { get; set; }

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        public string Uri
        {
            get
            {
                if (string.IsNullOrEmpty(_uri))
                {
                    Resource att = (Resource) Attribute.GetCustomAttribute(GetType(), typeof (Resource));
                    _uri = att.Uri;
                }
                return _uri;
            }
        }
        private string _uri;
    }
}
