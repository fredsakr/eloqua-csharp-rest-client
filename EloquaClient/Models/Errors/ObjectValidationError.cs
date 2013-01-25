namespace Eloqua.Api.Rest.ClientLibrary.Models.Errors
{
    public class ObjectValidationError : ValidationError
    {
        public ObjectKey container { get; set; }
        public string property { get; set; }
        public string requirement { get; set; }
        public string value { get; set; }
    }
}
