using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Accounts.Views
{
    [Resource("/assets/account/view", "AccountView")]
    public class AccountView : RestObject
    {
        public List<DataField> fields { get; set; }

    }
}
