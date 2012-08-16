using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Microsites
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
