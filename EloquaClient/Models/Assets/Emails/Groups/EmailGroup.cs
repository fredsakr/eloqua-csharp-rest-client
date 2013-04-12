using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Groups
{
    [Resource("/assets/email/group", "EmailGroup")]
    public class EmailGroup : RestObject, ISearchable
    {
        public string displayName { get; set; }
        public int? emailFooterId { get; set; }
        public int? emailHeaderId { get; set; }
        public List<string> emailIds { get; set; }
        public bool? isVisibleInOutlookPlugin { get; set; }
        public string subscriptionListDataLookupId { get; set; }
        public int? subscriptionLandingPageId { get; set; }
        public int? subscriptionListId { get; set; }
        public string unSubscriptionListDataLookupId { get; set; }
        public int? unsubscriptionLandingPageId { get; set; }
        public int? unSubscriptionListId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}