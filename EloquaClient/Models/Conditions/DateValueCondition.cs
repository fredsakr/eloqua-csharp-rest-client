namespace Eloqua.Api.Rest.Client.Models.Conditions
{
    public class DateValueCondition : ValueCondition
    {
        public string @operator { get; set; }
        public RelativeDate value { get; set; }
    }
}
