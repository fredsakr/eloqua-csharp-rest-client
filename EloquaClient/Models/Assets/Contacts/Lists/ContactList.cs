using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Lists
{
    [Resource("/assets/contact/list", "ContactList")]
    public class ContactList : RestObject
    {
        public int? count { get; set; }
        public List<string> membershipAdditions { get; set; }
        public List<string> membershipDeletions { get; set; } 
    }
}
