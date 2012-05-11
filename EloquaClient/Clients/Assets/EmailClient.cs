using System.Collections.Generic;
using Eloqua.Models.Assets;

namespace Eloqua.Clients.Assets
{
    public class EmailClient
    {
        public EmailClient(GenericSender sender)
        {
            _sender = sender;
        }
        readonly GenericSender _sender;

        public Email Get(int id)
        {
            return _sender.Get<Email> (new Email
                                          {
                                              Id = id
                                          });
        }

        public Emails Get(string search, int pageNumber, int pageSize)
        {
            return _sender.Search<Emails> (new Email
                                                   {
                                                       SearchTerm = search, 
                                                       PageNumber = pageNumber, 
                                                       PageSize = pageSize
                                                   });
        }

        public void Delete(int id)
        {
            _sender.Delete<Email> (new Email
                                      {
                                          Id = id
                                      });
        }
    }
}
