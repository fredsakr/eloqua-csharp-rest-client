namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections
{
    [Resource("/assets/contentSection", "ContentSection")]
    public class ContentSection : RestObject, ISearchable
    {
        public string contentHtml { get; set; }
        public string contentText { get; set; }
        public Size size { get; set; }
        public string scope { get; set; }

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}
