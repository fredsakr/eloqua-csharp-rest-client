using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Assets.OptionLists
{
    [Resource("/assets/optionList", "OptionList")]
    public class OptionList : RestObject
    {
        public List<Option> elements { get; set; }
    }
}
