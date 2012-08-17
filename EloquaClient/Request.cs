using System;
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

        internal static RestRequest Get(Type type, RestObject restObj)
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
                        break;
                    case Type.Put:
                        request.Method = Method.PUT;
                        break;
                    case Type.Post:
                        request.Method = Method.POST;
                        break;
                    case Type.Search:
                        request.Method = Method.GET;
                        break;
                    case Type.Delete:
                        request.Method = Method.DELETE;
                        break;
                    default:
                        throw new NotSupportedException(type.ToString());
            }
            return request;
        }
    }
}
