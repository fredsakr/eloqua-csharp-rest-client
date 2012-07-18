using System.Collections.Generic;

namespace Eloqua.Models.Data
{
    public class CustomObject : IRestObject
    {
        public int? contactId { get; set; }
        public string currentStatus { get; set; }
        public List<FieldValue> fieldValues { get; set; }

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string RequestResource
        {
            get { return "/assets/customObject"; }
        }

        public string Depth { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }

        #endregion

    }
}
