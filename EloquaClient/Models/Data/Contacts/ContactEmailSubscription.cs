using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Groups;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts
{
    [Resource("/data/contact", "ContactEmailSubscription")]
    public class ContactEmailSubscription : RestObject
    {
        public int? contactId { get; set; }
        public EmailGroup emailGroup { get; set; }
        public bool? isSubscribed { get; set; }
        public int? updatedAt { get; set; }
    }
}
