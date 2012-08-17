using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/view", "ContactView")]
    public class ContactView : RestObject, ISearchable
    {
        public List<DataField> fields { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
