using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Accounts.Views
{
    [Resource("/assets/account/view", "AccountView")]
    public class AccountView : RestObject
    {
        public List<DataField> fields { get; set; }

    }
}
