using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/view", "ContactView")]
    public class ContactView : RestObject
    {
        public List<DataField> fields { get; set; }
    }
}
