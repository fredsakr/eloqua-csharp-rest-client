namespace Eloqua.Api.Rest.Client
{
    public interface IRestObject
    {
        int id { get; set; }
        string name { get; set; }

        string depth { get; set; }
        string requestResource { get; }

        int page { get; set; }
        int pageSize { get; set; }
        string searchTerm { get; set; }
    }
}
