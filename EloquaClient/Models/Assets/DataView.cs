using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class DataView : IdentifiableObject
    {
        public List<DataField> Fields { get; set; }
    }
}
