using Eloqua.Api.Rest.ClientLibrary;
using Eloqua.Api.Rest.ClientLibrary.Models.Content;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.LandingPages
{
    [Resource("/assets/landingPage", "LandingPage")]
    public class LandingPage : RestObject
    {
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public RawHtmlContent htmlContent { get; set; }
        public int? micrositeId { get; set; }
        public string style { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }
    }
}
