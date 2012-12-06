using Eloqua.Api.Rest.ClientLibrary.Models.Content;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.LandingPages.Structured
{
    [Resource("/assets/landingPage", "LandingPage")]
    public class LandingPage : RestObject, ISearchable
    {
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public StructuredHtmlContent htmlContent { get; set; }
        public int? micrositeId { get; set; }
        public string style { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
