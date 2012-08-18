using System;
using System.Text;
using RestSharp;

namespace Eloqua.Api.Rest.ClientLibrary
{
    internal class Request
    {
        internal enum Type
        {
            Delete,
            Get,
            Post,
            Put,
            Search // todo : move this under the GET method
        }

        internal static RestRequest  Get(Type type, RestObject restObj)
        {
            restObj.type = restObj.Type;

            var request = new RestRequest
                              {
                                  RequestFormat = DataFormat.Json
                              };

            switch (type)
            {
                    case Type.Get:
                        request.Method = Method.GET;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        break;

                    case Type.Put:
                        request.Method = Method.PUT;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        request.AddBody(restObj);
                        break;

                case Type.Post:
                        request.Method = Method.POST;
                        request.Resource = restObj.Uri;
                        request.AddBody(restObj);
                        break;

                case Type.Delete:
                        request.Method = Method.DELETE;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        break;
                
                case Type.Search:
                        request.Method = Method.GET;

                        var resource = new StringBuilder(100);
                        resource.Append(restObj.Uri);

                        if (restObj.id != null && restObj.id > 0)
                        {
                            resource.Append("/" + restObj.id);
                        }
                        
                        var searchObj = restObj as ISearchable;
                        resource.Append("s?search=" + searchObj.searchTerm +
                                           "&count=" + searchObj.pageSize +
                                           "&page=" + searchObj.page + 
                                           "&depth=complete");

                        request.Resource = resource.ToString();

                        break;

                    default:
                        throw new NotSupportedException(type.ToString());
            }
            return request;
        }
    }
}
