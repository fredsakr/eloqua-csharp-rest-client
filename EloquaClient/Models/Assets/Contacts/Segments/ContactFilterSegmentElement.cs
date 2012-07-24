namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Segments
{
    public class ContactFilterSegmentElement : SegmentElement
    {
        public string type { get; set; }
        public Filters.ContactFilter filter { get; set; }
    }
}
