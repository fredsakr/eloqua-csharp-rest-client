using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.CustomObjects
{
    [Resource("/assets/customObject", "CustomObject")]
    public class CustomObject : RestObject
    {
        public string displayNameFieldId { get; set; }
        public List<CustomObjectField> fields { get; set; }
        public string uniqueCodeFieldId { get; set; }
    }
}
