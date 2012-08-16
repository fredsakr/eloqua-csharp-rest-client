using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Segments
{
    [Resource("/assets/contact/segment", "ContactSegment")]
    public class ContactSegment : RestObject
    {
        public int? count { get; set; }
        public string lastCalculatedAt { get; set; }
        public List<SegmentElement> elements { get; set; }
    }
}
