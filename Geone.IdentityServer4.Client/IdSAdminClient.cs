using Geone.IdentityServer4.Client.Models;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Geone.IdentityServer4.Client
{
    public class IdSAdminClient
    {
        private readonly RestClient _client;
        public IdSAdminClient(IdSAdminConfig config)
        {
            _client = new RestClient(config.BaseUrl);
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
                throw new IdSException("调用IdS4 RESTful API失败(查询服务): \r\n" + response.Content, (int)response.StatusCode);
            }

            ApiResourceRegistry[] apis = JObject.Parse(response.Content)["apiResources"]?.ToObject<ApiResourceRegistry[]>();
            if ((apis == null || apis.Length == 0))
            {
                if (throwIfNotFound)
                {
                    throw new IdSException($"IdS4中未找到服务[{name}]", 404);
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
                throw new IdSException($"调用IdS4 RESTful API失败(注册服务)\r\n: {response.Content}", (int)response.StatusCode);
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
                throw new IdSException($"调用IdS4 RESTful API失败(注册客户端)\r\n: {response.Content}", (int)response.StatusCode);
            }
        }

        public string GetUsers(IdSServerConfig config)
        {
            var request = new RestRequest("api/Users", Method.GET);
            request.AddParameter("page", "1");
            request.AddParameter("pageSize", int.MaxValue);

            request.AddHeader("Authorization", string.Format("Bearer {0}", GetClientToken(config)));

            IRestResponse response = _client.Execute(request);
            if (!response.IsSuccessful)
            {
                throw new IdSException("获取所有用户失败: \r\n" + response.Content, (int)response.StatusCode);
            }

            return response.Content;
        }

        public string GetClientToken(IdSServerConfig config)
        {
            string tokenUrl = config.BaseUrl + "/connect/token";
            HttpClient client = new HttpClient();

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 
                | System.Net.SecurityProtocolType.Tls11 
                | System.Net.SecurityProtocolType.Tls;

            client.BaseAddress = new Uri(tokenUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            var c = client.RequestTokenAsync(new TokenRequest()
            {
                Address = tokenUrl,
                ClientId = config.ApiName,
                ClientSecret = config.ApiSecret,

                //GrantType = ConfigurationManager.AppSettings["GrantType"],
                //Parameters =
                //{
                //    { "scope", ConfigurationManager.AppSettings["Method"] },
                //}

            }).GetAwaiter();

            var r = c.GetResult();

            if (r.IsError) throw new Exception(r.Error);

            return r.AccessToken;
        }
    }
}
