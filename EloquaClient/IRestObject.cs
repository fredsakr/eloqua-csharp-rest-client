namespace Eloqua
{
    public interface IRestObject
    {
        int id { get; set; }
        string name { get; set; }
        string RequestResource { get; }

        string Depth { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
        string SearchTerm { get; set; }
    }
}
