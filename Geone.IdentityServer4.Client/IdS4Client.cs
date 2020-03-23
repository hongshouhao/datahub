using Geone.IdentityServer4.Client.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Geone.IdentityServer4.Client
{
    public class IdS4Client
    {
        private readonly RestClient _client;
        public IdS4Client(IdS4Config config)
        {
            _client = new RestClient(config.BaseURL);
        }

        public ApiResourceRegistry GetApiResource(string name, bool throwIfNotFound)
        {
            var request = new RestRequest($"/api/ApiResources?page=1&pageSize=1", DataFormat.Json);
            request.AddQueryParameter("page", "1");
            request.AddQueryParameter("pageSize", "1");
            request.AddQueryParameter("searchText", name);

            IRestResponse response = _client.Get(request);
            if (!response.IsSuccessful)
            {
                throw new IdS4Exception("调用IdS4 RESTful API失败(查询服务): \r\n" + response.Content, (int)response.StatusCode);
            }

            ApiResourceRegistry[] apis = JObject.Parse(response.Content)["apiResources"]?.ToObject<ApiResourceRegistry[]>();
            if ((apis == null || apis.Length == 0))
            {
                if (throwIfNotFound)
                {
                    throw new IdS4Exception($"IdS4中未找到服务[{name}]", 404);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return apis[0];
            }
        }

        public string SaveApiResource(ApiResourceRegistry api)
        {
            api.Check();
            IRestRequest request = new RestRequest("/api/OpenApi/SaveApiResource", DataFormat.Json);
            request = request.AddJsonBody(api);
            IRestResponse response = _client.Post(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdS4Exception($"调用IdS4 RESTful API失败(注册服务)\r\n: {response.Content}", (int)response.StatusCode);
            }
        }

        public string SaveClient(ClientRegistry client)
        {
            client.Check();
            IRestRequest request = new RestRequest("/api/OpenApi/SaveClient", DataFormat.Json);
            request = request.AddJsonBody(client);
            IRestResponse response = _client.Post(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdS4Exception($"调用IdS4 RESTful API失败(注册客户端)\r\n: {response.Content}", (int)response.StatusCode);
            }
        }
    }
}
