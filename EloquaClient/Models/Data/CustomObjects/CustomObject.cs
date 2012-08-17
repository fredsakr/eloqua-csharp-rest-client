using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.CustomObjects
{
    [Resource("/data/customObject", "CustomObject")]
    public class CustomObject : RestObject, ISearchable
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
