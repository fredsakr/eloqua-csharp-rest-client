using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Lists
{
    [Resource("/assets/contact/list", "ContactList")]
    public class ContactList : RestObject
    {
        public int? count { get; set; }
        public List<string> membershipAdditions { get; set; }
        public List<string> membershipDeletions { get; set; } 
    }
}
