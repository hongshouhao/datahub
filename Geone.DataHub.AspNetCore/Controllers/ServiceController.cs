using Consul;
using Geone.AuthorisationFilter;
using Geone.DataHub.AspNetCore.Config;
using Geone.DataHub.AspNetCore.Swagger;
using Geone.DataHub.Core.Exceptions;
using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Repository;
using Geone.DataHub.Core.Service;
using Geone.IdentityServer4.Client;
using Geone.IdentityServer4.Client.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataHub.AspNetCore.Controllers
{
    [Route(serviceRoute)]
    [ApiController]
    [SwaggerOperationFilter(typeof(AuthorizeCheckOperationFilter))]
    public class ServiceController : ControllerBase
    {
        private const string serviceRoute = "service";

        private readonly RootConfig _configRoot;
        private readonly MetaRepository _repository;
        private readonly ServiceExcutor _excutor;
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(
            RootConfig configRoot,
            MetaRepository repository,
            ServiceExcutor excutor,
            ILogger<ServiceController> logger)
        {
            _configRoot = configRoot;
            _repository = repository;
            _excutor = excutor;
            _logger = logger;
        }

        [HttpPost]
        [Route("{name}")]
        [DynamicAuthorize]
        public object Post(string name, [FromBody]object arguments)
        {
            MetaEntity entity = _repository.Get(MetaType.Service, name);
            ServiceMeta serviceMeta = entity.GetMetadata() as ServiceMeta;
            return _excutor.Excute(serviceMeta, arguments);
        }

        [HttpGet]
        [Route("apis")]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "administrator")]
        public object APIs()
        {
            return _repository.Query(x => x.MetaType == MetaType.Service)
                  .Select(x => new { Name = x.Name, URL = $"{Request.Host}/{serviceRoute}/{x.Name}" })
                  .ToArray();
        }

        [HttpPost]
        [Route("registerApisToIds")]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "administrator")]
        public void RegisterApisToIds()
        {
            if (string.IsNullOrWhiteSpace(_configRoot.IdSAdmin?.BaseUrl))
            {
                throw new DataHubException("服务端未正确配置[IdentityServer]", 500);
            }
            else
            {
                IdSAdminClient client = new IdSAdminClient(_configRoot.IdSAdmin);
                ApiResourceRegistry api = new ApiResourceRegistry()
                {
                    Name = _configRoot.Server.Name,
                    DisplayName = "数据服务",
                    Description = $"数据服务[{_configRoot.Server.BaseUrl}]",
                    Enabled = true,
                };
                api.Scopes = new List<ApiScopeRegistry>();

                ApiScopeRegistry[] tests = _repository.Query(x => x.MetaType == MetaType.Service)
                    .Select(x => new ApiScopeRegistry()
                    {
                        Name = $"{_configRoot.Server.Name.ToLower()}.{x.Name.ToLower()}",
                        Description = x.Description,
                        DisplayName = x.Description,
                        Required = false,
                        ShowInDiscoveryDocument = true,
                        Emphasize = false,
                        UserClaims = new List<string>()
                    }).ToArray();

                api.Scopes.AddRange(tests);
                client.SaveApiResource(api);
            }
        }

        [HttpPost]
        [Route("registerChecksToConsul")]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "administrator")]
        public object RegisterChecksToConsul()
        {
            if (string.IsNullOrWhiteSpace(_configRoot.Consul?.BaseUrl))
            {
                throw new DataHubException("服务端未正确配置[Consul]", 500);
            }
            else
            {
                if (_configRoot.Server.Host.ToLower().Contains("localhost"))
                {
                    throw new DataHubException("启用[Consul]时服务地址不能使用[localhost], 必须使用此服务所在服务器的[IP]地址", 500);
                }

                ServiceTestMeta[] tests = _repository.Query(x => x.MetaType == MetaType.ServiceTest)
                    .Select(x => x.GetMetadata() as ServiceTestMeta).ToArray();

                using (var client = new ConsulClient(c =>
                {
                    c.Address = new Uri(_configRoot.Consul.BaseUrl);
                }))
                {
                    ServerConfig serverConfig = _configRoot.Server;
                    client.Agent.ServiceDeregister(serverConfig.Name);

                    string consulHost = client.Config.Address.ToString().TrimEnd('/');
                    var registration = new AgentServiceRegistration()
                    {
                        ID = serverConfig.Name,
                        Name = serverConfig.Name,
                        Address = serverConfig.Host,
                        Port = serverConfig.Port,
                        Tags = new[] { serverConfig.Name }
                    };

                    List<AgentServiceCheck> checks = new List<AgentServiceCheck>();
                    checks.Add(new AgentServiceCheck
                    {
                        TCP = $"{serverConfig.Host}:{serverConfig.Port}",
                        Timeout = new TimeSpan(0, 0, 3),
                        Interval = _configRoot.Consul.Interval
                    });

                    foreach (var item in tests)
                    {
                        checks.Add(new AgentServiceCheck
                        {
                            HTTP = $"{_configRoot.Server.BaseUrl}/{serviceRoute}/{item.ServiceName}",
                            Method = "POST",
                            Header = item.Header,
                            Body = item.Body.ToString(),
                            Interval = _configRoot.Consul.Interval
                        });
                    }

                    registration.Checks = checks.ToArray();
                    WriteResult writeResult = client.Agent.ServiceRegister(registration).Result;
                    if (writeResult.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        throw new DataHubException("向[Consul]中注册服务失败", 500);
                    }
                    else
                    {
                        client.Agent.Services().Result.Response.TryGetValue(serverConfig.Name, out AgentService agentService);
                        return agentService;
                    }
                }
            }
        }
    }
}
