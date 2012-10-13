namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails
{
    [Resource("/assets/email/deployment", "EmailTestDeployment")]
    public class EmailTestDeployment : RestObject, ISearchable
    {
        public int? contactId { get; set; }
        public Email email { get; set; }
        public int? successfulSendCount { get; set; }
        public int? failedSendCount { get; set; }
        public string endAt { get; set; }
        public int? sendFromUserId { get; set; }
        public string sentContent { get; set; }
        public string sentSubject { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
