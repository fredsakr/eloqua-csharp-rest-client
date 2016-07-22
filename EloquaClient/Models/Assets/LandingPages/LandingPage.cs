using System.Collections.Generic;
using System.Runtime.Serialization;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.DynamicContents;
using Eloqua.Api.Rest.ClientLibrary.Models.Content;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.LandingPages
{
    [Resource("/assets/landingPage", "LandingPage")]
    public class LandingPage : RestObject, ISearchable
    {
        public List<ContentSection> contentSections { get; set; }
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public List<DynamicContent> dynamicContents { get; set; }
        public RawHtmlContent htmlContent { get; set; }
        public int? micrositeId { get; set; }
        public string style { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }
        public new string name { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
