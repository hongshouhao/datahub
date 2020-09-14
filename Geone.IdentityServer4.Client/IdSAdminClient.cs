using Geone.IdentityServer4.Client.Models;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Password = _config.Password,
                Scope = _config.Scopes
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
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool CheckUser(string account) {


            User target = GetUsers()?.FirstOrDefault(u => u.UserName.ToLower() == account.ToLower() );
            
            if (target == null)
            {
                return false;
            }
            return true;
        } 
        public string SaveUser(SaveUserDto input)
        { 
            IRestRequest request = new RestRequest("/api/Users", Method.POST, DataFormat.Json);
            request = request.AddJsonBody(input);
            IRestResponse response = ExcuteRequest(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdSException($"调用IdS4 RESTful API失败(新增用户)\r\n: {response.Content}", (int)response.StatusCode);
            }
        } 
        public string UpdateUser(UpdateUserDto input)
        {
            IRestRequest request = new RestRequest("/api/Users", Method.PUT, DataFormat.Json);
            request = request.AddJsonBody(input);
            IRestResponse response = ExcuteRequest(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdSException($"调用IdS4 RESTful API失败(修改用户)\r\n: {response.Content}", (int)response.StatusCode);
            }
        } 
        public string DeleteUser(Guid id)
        {
            IRestRequest request = new RestRequest("/api/Users/{id}", Method.DELETE, DataFormat.Json); 
            request.AddUrlSegment("id", id);
            IRestResponse response = ExcuteRequest(request);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                throw new IdSException($"调用IdS4 RESTful API失败(删除用户)\r\n: {response.Content}", (int)response.StatusCode);
            }
        }
        public string ChangePassword(UpdatePasswordInput input)
        {
            IRestRequest request = new RestRequest("/api/Users/ChangePassword", Method.POST, DataFormat.Json);
            request = request.AddJsonBody(input);
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
        public string SaveClaims(SaveClaimsInput input)
        {  
            IRestRequest request = new RestRequest("/api/Users/Claims", Method.POST, DataFormat.Json);
            request = request.AddJsonBody(input);
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
        public string DeleteClaimsCnName(Guid userId)
        {
            var dic = GetUserClaims(userId.ToString(), "claimId");
            dic.TryGetValue("cnname", out string claimId);

            IRestRequest request = new RestRequest("/api/Users/{id}/Claims", Method.DELETE, DataFormat.Json);
            request.AddUrlSegment("id", userId);
            request.AddParameter("claimId", claimId); 
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
        public User[] GetUsers(bool includeClaims = true)
        {
            var request = new RestRequest("api/Users", Method.GET);
            request.AddParameter("page", "1");
            request.AddParameter("pageSize", int.MaxValue);

            IRestResponse response = ExcuteRequest(request);
            if (!response.IsSuccessful)
            {
                throw new IdSException("获取所有用户失败: \r\n" + response.StatusDescription, (int)response.StatusCode);
            }

            JToken jtoken = JObject.Parse(response.Content)["users"];

            if (includeClaims)
            {
                UserWithId[] users = jtoken.ToObject<UserWithId[]>();

                foreach (var item in users)
                {
                    item.Claims = GetUserClaims(item.Id);
                    item.Claims.TryGetValue("cnname", out string name);
                    item.Alias = name;
                }

                return users;
            }
            else
            {
                return jtoken.ToObject<User[]>();
            }
        }

        public Dictionary<string, string> GetUserClaims(string id,string valueType= "claimValue")
        {
            var request = new RestRequest("api/Users/{id}/Claims", Method.GET);
            request.AddUrlSegment("id", id);
            request.AddParameter("page", "1");
            request.AddParameter("pageSize", int.MaxValue);

            IRestResponse response = ExcuteRequest(request);
            if (!response.IsSuccessful)
            {
                throw new IdSException("获取用户声明失败: \r\n" + response.Content, (int)response.StatusCode);
            }

            JToken[] array = JToken.Parse(response.Content)["claims"].ToArray();

            Dictionary<string, string> claims = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var item in array)
            {
                claims.Add(item["claimType"].ToString(), item[valueType].ToString());
            }

            return claims;
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
