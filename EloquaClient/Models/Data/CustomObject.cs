using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Data
{
    public class CustomObject : RestObject
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }

        public override string requestResource
        {
            get { return "/assets/customObject"; }
        }
    }
}
