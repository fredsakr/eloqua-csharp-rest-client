using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets
{
    public class DataView : IdentifiableObject
    {
        public List<DataField> Fields { get; set; }
    }
}
