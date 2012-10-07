using System.Collections.Generic;
using System;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    [Resource("/assets/email/deployment", "EmailDeployment")]
    public class EmailDeployment : RestObject, ISearchable
    {

        public Email email { get; set; }
        public int? successfulSendCount { get; set; }
        public int? failedSendCount { get; set; }
        public string endAt { get; set; }
        public string sentContent { get; set; }
        public string sentSubject { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
