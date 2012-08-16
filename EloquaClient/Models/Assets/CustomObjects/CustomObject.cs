using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects
{
    [Resource("/assets/customObject", "CustomObject")]
    public class CustomObject : RestObject
    {
        public string displayNameFieldId { get; set; }
        public List<CustomObjectField> fields { get; set; }
        public string uniqueCodeFieldId { get; set; }
    }
}
