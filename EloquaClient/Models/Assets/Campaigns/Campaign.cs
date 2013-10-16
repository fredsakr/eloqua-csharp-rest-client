using System.Collections.Generic;
using System.Runtime.Serialization;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.ContentSections;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.DynamicContents;
using Eloqua.Api.Rest.ClientLibrary.Models.Content;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Campaigns
{
    [Resource("/assets/campaign", "Campaign")]
    public class Campaign : RestObject, ISearchable
    {
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public int? folderId { get; set; }
        public string name { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }
        public float? actualCost { get; set; }
        public float? budgetedCost { get; set; }
        public string campaignType { get; set; }
        public List<CampaignRelatedElement> elements { get; set; }
        public int? startAt { get; set; }
        public int? endAt { get; set; }
        public bool? isIncludedInROI { get; set; }
        public bool? isMemberAllowedReEntry { get; set; }
        public bool? isReadOnly { get; set; }
        public bool? isSyncedWithCRM { get; set; }
        public int? runAsUserId { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
