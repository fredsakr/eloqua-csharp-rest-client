namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets
{
    public class DataField : IdentifiableObject
    {
        public string checkedValue { get; set; }
        public string dataType { get; set; }
        public string defaultValue { get; set; }
        public string displayType { get; set; }
        public string internalName { get; set; }
        public string isReadOnly { get; set; }
        public string isRequired { get; set; }
        public string isStandard { get; set; }
        public int? optionListId { get; set; }
        public string uncheckedValue { get; set; }
    }
}
