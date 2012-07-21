namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class ContactList : IRestObject
    {
        public int? count { get; set; }

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string requestResource
        {
            get { return "/assets/contact/list"; }
        }

        public string depth { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion

    }
}
