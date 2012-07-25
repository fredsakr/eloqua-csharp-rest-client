using System;

namespace Eloqua.Api.Rest.Client
{
    public class RestObject
    {
        public int id { get; set; }
        public string name { get; set; }

        public string type;

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

        public string Type
        {
            get
            {
                if (string.IsNullOrEmpty(_type))
                {
                    Resource att = (Resource)Attribute.GetCustomAttribute(GetType(), typeof(Resource));
                    _type = att.Type;
                }
                return _type;
            }
        }
        private string _type;
    }
}
