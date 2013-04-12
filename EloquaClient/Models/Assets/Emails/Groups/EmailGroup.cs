using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Groups
{
    [Resource("/assets/email/group", "EmailGroup")]
    public class EmailGroup : RestObject
    {
        public string displayName { get; set; }
        public int? emailFooterId { get; set; }
        public int? emailHeaderId { get; set; }
        public List<int?> emailIds { get; set; }
        public bool? isVisibleInOutlookPlugin { get; set; }
        public int? subscriptionListDataLookupId { get; set; }
        public int? subscriptionLandingPageId { get; set; }
        public int? subscriptionListId { get; set; }
        public int? unSubscriptionListDataLookupId { get; set; }
        public int? unsubscriptionLandingPageId { get; set; }
        public int? unSubscriptionListId { get; set; }
    }
}