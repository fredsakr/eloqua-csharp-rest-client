using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.OptionLists
{
    [Resource("/assets/optionList", "OptionList")]
    public class OptionList : RestObject, ISearchable
    {
        public List<Option> elements { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
