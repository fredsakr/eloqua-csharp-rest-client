using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Microsites
{
    [Resource("/assets/microsite", "Microsite")]
    public class Microsite : RestObject, ISearchable
    {
        public int? defaultLandingPageId { get; set; }
        public List<string> domains { get; set; }
        public string enableWebTrackingOptIn { get; set; }
        public bool? isSecure { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
