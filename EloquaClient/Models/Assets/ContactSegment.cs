
namespace Eloqua.Api.Rest.Client.Models.Assets
{
    public class ContactSegment : RestObject
    {
        public int? count { get; set; }

        public override string requestResource
        {
            get { return "/assets/contact/segment"; }
        }
    }
}
