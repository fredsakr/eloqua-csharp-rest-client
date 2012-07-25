using Eloqua.Api.Rest.Client.Models.Content;

namespace Eloqua.Api.Rest.Client.Models.Assets.Emails
{
    [Resource("/assets/email", "Email")]
    public class Email : RestObject
    {
        public string bouncebackEmail { get; set; }
        public int? emailFooterId { get; set; }
        public int? emailGroupId { get; set; }
        public int? emailHeaderId { get; set; }
        public int? encodingId { get; set; }
        public RawHtmlContent htmlContent { get; set; }
        public bool isPlainTextEditable { get; set; }
        public string plainText { get; set; }
        public string replyToName { get; set; }
        public string replyToEmail { get; set; }
        public string senderEmail { get; set; }
        public string senderName { get; set; }
        public bool sendPlainTextOnly { get; set; }
        public string subject { get; set; }
    }
}
