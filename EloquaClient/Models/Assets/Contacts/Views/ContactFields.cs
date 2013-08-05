namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/field", "ContactFields")]
    public class ContactField : RestObject, ISearchable
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}