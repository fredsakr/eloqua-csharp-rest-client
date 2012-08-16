using Eloqua.Api.Rest.ClientLibrary.Models;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Conditions
{
    public class DateValueCondition : ValueCondition
    {
        public string @operator { get; set; }
        public RelativeDate value { get; set; }
    }
}
