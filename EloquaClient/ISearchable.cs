namespace Eloqua.Api.Rest.ClientLibrary
{
    public interface ISearchable
    {
        int page { get; set; }
        int pageSize { get; set; }
        string searchTerm { get; set; }
    }
}
