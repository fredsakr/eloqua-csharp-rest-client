using System.Runtime.Serialization;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Content
{
    [KnownType(typeof(RawHtmlContent))]
    [KnownType(typeof(StructuredHtmlContent))]
    public abstract class HtmlContent
    {
        public string contentSource { get; set; }
    }
}
