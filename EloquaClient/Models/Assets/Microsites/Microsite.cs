using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Microsites
{
    [Resource("/assets/microsite", "Microsite")]
    public class Microsite : RestObject
    {
        public int? defaultLandingPageId { get; set; }
        public List<string> domains { get; set; }
        public string enableWebTrackingOptIn { get; set; }
        public bool? isSecure { get; set; }
    }
}
