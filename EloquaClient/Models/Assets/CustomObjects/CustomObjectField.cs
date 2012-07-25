namespace Eloqua.Api.Rest.Client.Models.Assets.CustomObjects
{
    public class CustomObjectField
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string dataType { get; set; }
        public string defaultValue { get; set; }
        public string displayType { get; set; }
        public string internalName { get; set; }
        public string type
        {
            get
            {
                if (string.IsNullOrEmpty(type))
                {
                    _type = "CustomObjectField";
                }
                return _type;
            }
            set { _type = value; }
        }

        private string _type;
    }
}
