namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    public class Hyperlink
    {
        public string href { get; set; }
        public string Type { get; set; } //hyperlinkType according to endpoint
        public string Id { get; set; } //referencedEntityId according to endpoint
    }
}
