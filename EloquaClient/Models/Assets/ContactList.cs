namespace Eloqua.Api.Rest.Client.Models.Assets
{
    [Resource("/assets/contact/list")]
    public class ContactList : RestObject
    {
        public int? count { get; set; }
    }
}
