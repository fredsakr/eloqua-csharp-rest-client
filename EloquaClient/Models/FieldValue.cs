namespace Eloqua.Api.Rest.ClientLibrary.Models
{
    public class FieldValue
    {
        public FieldValue()
        {
            type = "FieldValue";
        }

        public int? id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }
}
