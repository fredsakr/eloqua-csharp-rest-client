namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.ExternalActivities
{
    [Resource("/data/activity", "ExternalActivities")]
    public class ExternalActivities
    {
        public string type { get; set; }
        public string campaignId { get; set; }
        public string assetName { get; set; }
        public string assetType { get; set; }
        public string activityType { get; set; }
        public string activityDate { get; set; }
        public string contactId { get; set; }
    }
}
