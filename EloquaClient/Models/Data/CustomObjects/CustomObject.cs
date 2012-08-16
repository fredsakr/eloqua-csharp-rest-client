using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjects
{
    [Resource("/data/customObject", "CustomObject")]
    public class CustomObject : RestObject
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }
    }
}
