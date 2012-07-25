using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Segments
{
    [Resource("/assets/contact/segment", "ContactSegment")]
    public class ContactSegment : RestObject
    {
        public int? count { get; set; }
        public string lastCalculatedAt { get; set; }
        public List<SegmentElement> elements { get; set; }
    }
}
