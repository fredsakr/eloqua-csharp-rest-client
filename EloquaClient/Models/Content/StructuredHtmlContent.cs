namespace Eloqua.Api.Rest.ClientLibrary.Models.Content
{
    public class StructuredHtmlContent : HtmlContent
    {
        public string cssHeader { get; set; }
        public string customHeader { get; set; }
        public string docType { get; set; }
        public string htmlBody { get; set; }
        public string javascriptHeader { get; set; }
        public string metaTags { get; set; }
    }
}
