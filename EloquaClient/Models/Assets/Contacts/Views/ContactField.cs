namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/field", "ContactField")]
    public class ContactField : RestObject, ISearchable
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
        public string updateType { get; set; }
        public string displayType { get; set; }
        public string dataType { get; set; }
    }
}