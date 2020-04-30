using Geone.IdentityServer4.Client.Models;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Net.Http;

namespace Geone.IdentityServer4.Client
{
    public class IdSAdminClient
    {
        private readonly RestClient _client;
        private readonly IdSConfig _config;

        public IdSAdminClient(IdSConfig config)
        {
            _config = config;
            _client = new RestClient(config.ApiBaseUrl);
            _client.Authenticator = new JwtAuthenticator(GetToken());
        }

        string GetToken()
        {
            var client = HttpClientFactory.Create();
            var tokenResponse = client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = $"{_config.Authority.Trim('/')}/connect/token",
                GrantType = _config.GrantType,
                ClientId = _config.ClientId,
                ClientSecret = _config.ClientSecret,
                UserName = _config.UserName,
                Password = _config.Password
            }).Result;

            if (tokenResponse.IsError)
            {
                throw new IdSException(tokenResponse.Error, (int)tokenResponse.HttpResponse.StatusCode);
            }

            return tokenResponse.AccessToken;
        }

        public ApiResourceRegistry GetApiResource(string name, bool throwIfNotFound)
        {
            var request = new RestRequest($"/api/My/GetApiResource", Method.GET, DataFormat.Json);
            request.AddParameter("apiName", name);
            IRestResponse response = ExcuteRequest(request);
            if (!response.IsSuccessful)
            {
                throw new IdSException("调用IdS4 RESTful API失败(查询服务): \r\n" + response.Content, (int)response.StatusCode);
            }

            ApiResourceRegistry api = JObject.Parse(response.Content).ToObject<ApiResourceRegistry>();
            if (api == null)
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
                return api;
            }
        }

        public string SaveApiResource(ApiResourceRegistry api)
        {
            api.Check();
            IRestRequest request = new RestRequest("/api/My/SaveApiResource", Method.POST, DataFormat.Json);
            request = request.AddJsonBody(api);
            IRestResponse response = ExcuteRequest(request);

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
            IRestRequest request = new RestRequest("/api/My/SaveClient", Method.POST, DataFormat.Json);
            request = request.AddJsonBody(client);
            IRestResponse response = ExcuteRequest(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdSException($"调用IdS4 RESTful API失败(注册客户端)\r\n: {response.Content}", (int)response.StatusCode);
            }
        }

        public User[] GetUsers()
        {
            var request = new RestRequest("api/Users", Method.GET);
            request.AddParameter("page", "1");
            request.AddParameter("pageSize", int.MaxValue);

            IRestResponse response = ExcuteRequest(request);
            if (!response.IsSuccessful)
            {
                throw new IdSException("获取所有用户失败: \r\n" + response.Content, (int)response.StatusCode);
            }

            return JObject.Parse(response.Content)["users"].ToObject<User[]>();
        }

        IRestResponse ExcuteRequest(IRestRequest request)
        {
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                _client.Authenticator = new JwtAuthenticator(GetToken());
                return _client.Execute(request);
            }
            else
            {
                return response;
            }
        }
    }
}
