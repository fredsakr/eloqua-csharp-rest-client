using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Accounts.Views
{
    [Resource("/assets/account/view", "AccountView")]
    public class AccountView : RestObject, ISearchable
    {
        public List<DataField> fields { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion

    }
}
