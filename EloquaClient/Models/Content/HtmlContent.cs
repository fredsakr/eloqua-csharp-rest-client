using System.Runtime.Serialization;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Content
{
    [KnownType(typeof(RawHtmlContent))]
    [KnownType(typeof(StructuredHtmlContent))]
    public class HtmlContent
    {
        public string contentSource { get; set; }
        public int? id { get; set; }
        public string type { get; set; }
    }
}
