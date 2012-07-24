using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Filters
{
    public class ContactFilter : IdentifiableObject
    {
        public int? count { get; set; }
        public List<Criteria.Criterion> criteria { get; set; }
        public string lastCalculatedAt { get; set; }
        public string scope { get; set; }
        public string statement { get; set; }
    }
}
