using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Systems.Users
{
    [Resource("/system/user", "User")]
    public class User : RestObject, ISearchable
    {
        public List<string> betaAccess { get; set; }
        public List<string> capabilities { get; set; }
        public int? defaultContactViewId { get; set; }
        public string emailAddress { get; set; }
        public string loginName { get; set; }
        public string name { get; set; }
        public List<ProductPermission> productPermissions { get; set; }
        public List<TypePermissions> typePermissions { get; set; } 

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
    }
}
