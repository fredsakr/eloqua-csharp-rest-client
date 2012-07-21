namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class ContactList : RestObject
    {
        public int? count { get; set; }

        public override string requestResource
        {
            get { return "/assets/contact/list"; }
        }
    }
}
