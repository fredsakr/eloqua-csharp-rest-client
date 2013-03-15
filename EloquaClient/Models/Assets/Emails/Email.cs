using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Hyperlinks;
using Eloqua.Api.Rest.ClientLibrary.Models.Content;
using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    [Resource("/assets/email", "Email")]
    public class Email : RestObject, ISearchable
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
        public List<Hyperlink> hyperlinks { get; set; }
        public new string type = "Email";

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
