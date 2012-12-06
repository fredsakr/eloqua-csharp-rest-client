namespace Eloqua.Api.Rest.ClientLibrary.Models.Content
{
    public class StructuredHtmlContent
    {
        public string cssHeader { get; set; }
        public string customHeader { get; set; }
        public string docType { get; set; }
        public string htmlBody { get; set; }
        public int? id { get; set; }
        public string javascriptHeader { get; set; }
//        public string metaTags { get; set; }
        public string root { get; set; }
        public string systemHeader { get; set; }
        public string type
        {
            get { return "StructuredHtmlContent"; }
        }
    }
}
