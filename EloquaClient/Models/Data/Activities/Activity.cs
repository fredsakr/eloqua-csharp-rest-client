using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Activities
{
    [Resource("/data/activities/contact/", "Activity")]
    public class Activity : RestObject, ISearchable
    {
        public int activityDate { get; set; }
        public int asset { get; set; }
        public string activityType { get; set; }
        public string assetType { get; set; }
        public int contact { get; set; }
        public List<Dictionary<string, string>> details { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
