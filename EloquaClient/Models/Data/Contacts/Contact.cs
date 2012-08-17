using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Data.Contacts
{
    [Resource("/data/contact", "Contact")]
    public class Contact : RestObject, ISearchable
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

        public new string name { get { return emailAddress; } } // TODO : add attribute to ignore these properties

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        #endregion
    }
}
