using System.Collections.Generic;

namespace Eloqua
{
    public class GenericClient<T> where T : IRestObject, new()
    {
        public GenericClient(GenericSender sender)
        {
            _sender = sender;
        }
        readonly GenericSender _sender;

        public T Get(int id)
        {
            return _sender.Get<T> (new T
                                          {
                                              Id = id
                                          });
        }

        public IList<T> Get(string search, int pageNumber, int pageSize)
        {
            return _sender.Search<T> (new T
                                                   {
                                                       SearchTerm = search, 
                                                       PageNumber = pageNumber, 
                                                       PageSize = pageSize
                                                   });
        }

        public T Post(T restObj)
        {
            return _sender.Post<T>(restObj);
        }

        public T Put(T restObj)
        {
            return _sender.Put<T>(restObj);
        }

        public void Delete(int id)
        {
            _sender.Delete<T> (new T
                                      {
                                          Id = id
                                      });
        }
    }
}
