using System.Collections.Generic;

namespace Eloqua.Api.Rest.Client.Models.Data
{
    public class Contact : IRestObject
    {
        public string accountName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string businessPhone { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool? isSubscribed { get; set; }
        public bool? isBounceBack { get; set; }
        public string salesPerson { get; set; }
        public string title { get; set; }
        public List<FieldValue> fieldValues { get; set; }
        #region IRestObject

        public int id { get; set; }
        public string name { get; set; }

        public string RequestResource
        {
            get { return "/data/contact"; }
        }

        public string Depth { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }

        #endregion

    }
}
