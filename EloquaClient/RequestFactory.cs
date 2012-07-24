using System;
using RestSharp;
using RestSharp.Serializers;

namespace Eloqua.Api.Rest.Client
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

        internal static RestRequest GetRequest(RequestType type, RestObject restObj)
        {
            var request = new RestRequest
                              {
                                  JsonSerializer = new JsonSerializer(),
                                  RequestFormat = DataFormat.Json,
                                  RootElement = restObj.GetType().ToString()
                              };

            switch (type)
            {
                    case RequestType.Get:
                        request.Method = Method.GET;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        break;
                    case RequestType.Put:
                        request.Method = Method.PUT;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        break;
                    case RequestType.Post:
                        request.Method = Method.POST;
                        request.Resource = restObj.Uri;
                        break;
                    case RequestType.Search:
                        request.Method = Method.GET;
                        request.Resource = restObj.Uri + "s?search=" + restObj.searchTerm + "&count=" +
                                           restObj.pageSize + "&page=" + restObj.page;

                        break;
                    case RequestType.Delete:
                        request.Method = Method.DELETE;
                        request.Resource = restObj.Uri + "/" + restObj.id;
                        break;
                    default:
                        throw new NotSupportedException(type.ToString());
            }

            return request;
        }

    }
}
