using System.Runtime.Serialization;

namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Segments
{
    [KnownType(typeof(ContactFilterSegmentElement))]
    public class SegmentElement : IdentifiableObject
    {
        public int? count { get; set; }
        public bool? isIncluded { get; set; }
        public string lastCalculatedAt { get; set; }
    }
}