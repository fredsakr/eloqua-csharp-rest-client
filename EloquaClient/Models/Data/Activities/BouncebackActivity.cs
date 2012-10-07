using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Activities
{
    [Resource("/data/activities/contact/", "BouncebackActivity")]
    public class BouncebackActivity : RestObject, ISearchable
    {
        public string smtpErrorCode { get; set; }
        public string smtpSatusCode { get; set; }
        public string smtpMessage { get; set; }
        public int emailId { get; set; }
        public string emailName { get; set; }
        public string emailFromAddress { get; set; }
        public string emailToAddress { get; set; }
        public BouncebackType category { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}