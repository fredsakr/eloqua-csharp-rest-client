using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Filters.Criteria;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Filters
{
    public class ContactFilter : IdentifiableObject
    {
        public int? count { get; set; }
        public List<Criterion> criteria { get; set; }
        public string lastCalculatedAt { get; set; }
        public string scope { get; set; }
        public string statement { get; set; }
    }
}
