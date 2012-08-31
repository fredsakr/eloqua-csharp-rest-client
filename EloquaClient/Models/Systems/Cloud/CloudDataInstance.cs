namespace Eloqua.Api.Rest.ClientLibrary.Models.Systems.Cloud
{
    [Resource("/system/cloud/data", "CloudDataInstance")]
    public class CloudDataInstance : RestObject, ISearchable
    {
        public string ActivateUrl { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string IconURL { get; set; }
        public string Name { get; set; }
        public string ProviderURL { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
