using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects
{
    [Resource("/assets/customObject", "CustomObject")]
    public class CustomObject : RestObject, ISearchable
    {
        public string displayNameFieldId { get; set; }
        public List<CustomObjectField> fields { get; set; }
        public string uniqueCodeFieldId { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
