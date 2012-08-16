using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.OptionLists
{
    [Resource("/assets/optionList", "OptionList")]
    public class OptionList : RestObject
    {
        public List<Option> elements { get; set; }
    }
}
