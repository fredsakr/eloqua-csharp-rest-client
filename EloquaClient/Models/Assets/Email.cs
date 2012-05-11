using System.Collections.Generic;

namespace Eloqua.Models.Assets
{
    public class Emails
    {
        public List<Email> elements { get; set; }
    }

    public class Email : IRestObject
    {
        public string BouncebackEmail { get; set; }
        public string IsPlainTextEditable { get; set; }
        public string PlainText { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToEmail { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string SendPlainTextOnly { get; set; }
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
