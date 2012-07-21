using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Data
{
    [Resource("/assets/customObject")]
    public class CustomObject : RestObject
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }
    }
}
