namespace Eloqua.Api.Rest.Client.Models.Conditions
{
    public class NumericValueCondition : ValueCondition
    {
        public string @operator { get; set; }
        public int? value { get; set; }
    }
}
