using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/view", "ContactView")]
    public class ContactView : RestObject
    {
        public List<DataField> fields { get; set; }
    }
}
