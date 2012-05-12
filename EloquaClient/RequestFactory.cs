using System;
using RestSharp;

namespace Eloqua
{
    internal class RequestFactory
    {
        internal enum RequestType
        {
            Delete,
            Get,
            Post,
            Put,
            Search // todo : move this under the GET method
        }

        internal static RestRequest GetRequest(RequestType type, IRestObject restObj)
        {
            var request = new RestRequest
                              {
                                  RequestFormat = DataFormat.Json,
                                  RootElement = restObj.RequestResourceName
                              };

            switch (type)
            {
                    case RequestType.Get:
                        request.Method = Method.GET;
                        request.Resource = restObj.RequestResource + "/" + restObj.Id;
                        break;
                    case RequestType.Put:
                        request.Method = Method.PUT;
                        request.Resource = restObj.RequestResource;
                        break;
                    case RequestType.Post:
                        request.Method = Method.POST;
                        request.Resource = restObj.RequestResource;
                        break;
                    case RequestType.Search:
                        request.Method = Method.GET;
                        request.Resource = restObj.RequestResource + "s?search=" + restObj.SearchTerm + "&count=" +
                                           restObj.PageSize + "&page=" + restObj.PageNumber;

                        break;
                    case RequestType.Delete:
                        request.Method = Method.DELETE;
                        request.Resource = restObj.RequestResource + "/" + restObj.Id;
                        break;
                    default:
                        throw new NotSupportedException(type.ToString());
            }

            return request;
        }
    }
}
