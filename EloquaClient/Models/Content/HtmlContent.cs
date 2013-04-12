using System.Runtime.Serialization;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Content
{
    [KnownType(typeof(RawHtmlContent))]
    [KnownType(typeof(StructuredHtmlContent))]
    public class HtmlContent
    {
        public string contentSource { get; set; }
        public string cssHeader { get; set; }
        public string docType { get; set; }
        public string html { get; set; }
        public string htmlBody { get; set; }
        public int? id { get; set; }
        public string javascriptHeader { get; set; }
        public string root { get; set; }
        public string type { get; set; }
    }
}
