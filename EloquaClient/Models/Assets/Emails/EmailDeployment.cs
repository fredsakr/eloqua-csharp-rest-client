using System;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    [Resource("/assets/email/deployment", "EmailDeployment")]
    public class EmailDeployment : RestObject, ISearchable
    {
        public Email email { get; set; }
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
