using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Segments
{
    [Resource("/assets/contact/segment", "ContactSegment")]
    public class ContactSegment : RestObject, ISearchable
    {
        public int? count { get; set; }
        public string lastCalculatedAt { get; set; }
        public List<SegmentElement> elements { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
