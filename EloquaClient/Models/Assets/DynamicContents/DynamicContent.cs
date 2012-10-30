using Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.DynamicContents
{
    [Resource("/assets/dynamicContent", "DynamicContent")]
    public class DynamicContent : RestObject, ISearchable
    {
        public ContentSection defaultContentSection { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
