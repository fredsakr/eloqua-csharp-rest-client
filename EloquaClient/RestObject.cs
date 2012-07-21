namespace Eloqua.Api.Rest.Client
{
    public abstract class RestObject
    {
        public int id { get; set; }
        public string name { get; set; }

        public string depth { get; set; }
        public abstract string requestResource { get; }

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}
