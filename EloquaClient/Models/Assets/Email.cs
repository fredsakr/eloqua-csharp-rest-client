using Eloqua.Api.Rest.Client.Models.Content;

namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class Email : IRestObject
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

        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string requestResource
        {
            get { return "/assets/email"; }
        }

        public string depth { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
