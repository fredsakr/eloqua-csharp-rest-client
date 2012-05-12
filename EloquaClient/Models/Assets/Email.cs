using System.Collections.Generic;
using Eloqua.Models.Content;
using System.ServiceModel;

namespace Eloqua.Models.Assets
{
    public class Emails
    {
        public List<Email> elements { get; set; }
    }

    public class Email : IRestObject
    {
        public string bouncebackEmail { get; set; }
        public int emailFooterId { get; set; }
        public int emailGroupId { get; set; }
        public int emailHeaderId { get; set; }
        public int encodingId { get; set; }
        public RawHtmlContent HtmlContent { get; set; }
        public bool isPlainTextEditable { get; set; }
        public string plainText { get; set; }
        public string replyToName { get; set; }
        public string replyToEmail { get; set; }
        public string senderEmail { get; set; }
        public string senderName { get; set; }
        public bool sendPlainTextOnly { get; set; }
        public string subject { get; set; }

        #region IRestObject

        public int Id { get; set; }
        public string name { get; set; }

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
