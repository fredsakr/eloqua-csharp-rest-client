using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Deployment;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    [Resource("/assets/email/deployment", "EmailInlineDeployment")]
    public class EmailInlineDeployment : RestObject, ISearchable
    {
        public int? clickthroughCount { get; set; }
        public List<Contact> contacts { get; set; }
        public int? failedSendCount { get; set; }
        public Deployment.Email email { get; set; }
        public string endAt { get; set; }
        public int? sendFromUserId { get; set; }
        public int? successfulSendCount { get; set; }
        public int? openCount { get; set; }
        public string sentContent { get; set; }
        public string sentSubject { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
