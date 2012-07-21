using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Data
{
    public class CustomObject : IRestObject
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string requestResource
        {
            get { return "/assets/customObject"; }
        }

        public string depth { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion

    }
}
