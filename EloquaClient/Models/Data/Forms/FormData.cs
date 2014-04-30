using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Forms
{
    [Resource("/data/form", "FormData")]
    public class FormData : RestObject, ISearchable
    {
        public List<FieldValue> fieldValues { get; set; }
        public int? submittedAt { get; set; }
        public int? submittedByContactId { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
