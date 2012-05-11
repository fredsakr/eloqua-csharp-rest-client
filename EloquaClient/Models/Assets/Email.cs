using System.Collections.Generic;
using Eloqua.Models.Content;

namespace Eloqua.Models.Assets
{
    public class Emails
    {
        public List<Email> elements { get; set; }
    }

    public class Email : IRestObject
    {
        public string BouncebackEmail { get; set; }
        public int EmailFooterId { get; set; }
        public int EmailGroupId { get; set; }
        public int EmailHeaderId { get; set; }
        public int EncodingId { get; set; }
        public RawHtmlContent HtmlContent { get; set; }
        public bool IsPlainTextEditable { get; set; }
        public string PlainText { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToEmail { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public bool SendPlainTextOnly { get; set; }
        public string Subject { get; set; }

        #region IRestObject

        public int Id { get; set; }
        public string Name { get; set; }

        public string RequestResource
        {
            get { return "/assets/email"; }
        }

        public string RequestResourceName
        {
            get { return "Email"; }
        }

        public string Depth { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }

        #endregion
    }
}
