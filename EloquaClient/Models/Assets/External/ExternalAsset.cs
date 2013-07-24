namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.External
{
    [Resource("/assets/external", "ExternalAsset")]
    public class ExternalAsset : RestObject, ISearchable
    {
        public int? externalAssetTypeId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}
