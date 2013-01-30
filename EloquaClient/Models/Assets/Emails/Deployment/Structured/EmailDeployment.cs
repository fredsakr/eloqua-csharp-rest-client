using System;
using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Deployment.Structured
{
    [Resource("/assets/email/deployment", "EmailInlineDeployment")]
    public class EmailInlineDeployment : RestObject, ISearchable
    {
        public int? clickthroughCount { get; set; }
        public List<Contact> contacts { get; set; }
        public int? openCount { get; set; }
        public int? sendFromUserId { get; set; }
        public List<EmailDeploymentStatistics> statistics { get; set; }
        public Assets.Emails.Structured.Email email { get; set; }
        public DateTime endAt { get; set; }
        public int? failedSendCount { get; set; }
        public string sentSubject { get; set; }
        public string successfulSendCount { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
