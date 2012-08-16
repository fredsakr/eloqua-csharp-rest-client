using System.Runtime.Serialization;
using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Segments
{
    [KnownType(typeof(ContactFilterSegmentElement))]
    public class SegmentElement : IdentifiableObject
    {
        public int? count { get; set; }
        public bool? isIncluded { get; set; }
        public string lastCalculatedAt { get; set; }
    }
}