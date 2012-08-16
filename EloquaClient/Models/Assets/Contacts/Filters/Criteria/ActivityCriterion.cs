using Eloqua.Api.Rest.ClientLibrary.Models.Conditions;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Filters.Criteria
{
    public class ActivityCriterion : Criterion
    {
        public Condition activityRestriction { get; set; }
        public Condition timeRestriction { get; set; }
    }
}
