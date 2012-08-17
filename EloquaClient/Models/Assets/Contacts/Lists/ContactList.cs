using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Lists
{
    [Resource("/assets/contact/list", "ContactList")]
    public class ContactList : RestObject, ISearchable
    {
        public int? count { get; set; }
        public List<string> membershipAdditions { get; set; }
        public List<string> membershipDeletions { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion

    }
}
