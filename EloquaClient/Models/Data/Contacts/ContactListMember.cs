namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts
{
    [Resource("/data/contacts/list", "Contact")]
    public class ContactListMember : RestObject, ISearchable
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}
