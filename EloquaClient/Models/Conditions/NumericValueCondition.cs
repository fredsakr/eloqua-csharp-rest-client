namespace Eloqua.Api.Rest.ClientLibrary.Models.Conditions
{
    public class NumericValueCondition : ValueCondition
    {
        public string @operator { get; set; }
        public int? value { get; set; }
    }
}
