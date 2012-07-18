using Eloqua.Api.Rest.Client.Models.Content;

namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class LandingPage : IRestObject
    {
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public RawHtmlContent htmlContent { get; set; }
        public int? micrositeId { get; set; }
        public string style { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string RequestResource
        {
            get { return "/assets/landingPage"; }
        }

        public string Depth { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }

        #endregion

    }
}
