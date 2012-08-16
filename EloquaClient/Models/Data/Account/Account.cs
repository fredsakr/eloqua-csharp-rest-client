using Eloqua.Api.Rest.ClientLibrary;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Account
{
    [Resource("/data/account", "Account")]
    public class Account : RestObject
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string businessPhone { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string fieldValues { get; set; }
    }
}
