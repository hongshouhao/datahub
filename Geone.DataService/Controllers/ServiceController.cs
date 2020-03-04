using Consul;
using Geone.DataService.Config;
using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.SOAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geone.DataService.Controllers
{
    [Route("service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ConfigRoot _configRoot;
        private readonly MetaRepository _repository;
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly SoapExcutor _soapExcutor;
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(
            ConfigRoot configRoot,
            MetaRepository repository,
            DBaaSExcutor dbaasExcutor,
            SoapExcutor soapExcutor,
            ILogger<ServiceController> logger)
        {
            _configRoot = configRoot;
            _repository = repository;
            _dbaasExcutor = dbaasExcutor;
            _soapExcutor = soapExcutor;
            _logger = logger;
        }

        [HttpPost]
        [Route("{name}")]
        public string Post(string name, [FromBody]object arguments)
        {
            MetaEntity entity = _repository.Get(MetaType.Service, name);
            ServiceMeta serviceMeta = entity.GetMetadata() as ServiceMeta;

            switch (serviceMeta.Type)
            {
                case ServiceType.REST:
                    throw new NotImplementedException();
                case ServiceType.SOAP:
                    return _soapExcutor.Excute(serviceMeta, arguments);
                case ServiceType.DBaaS:
                    return _dbaasExcutor.Excute(serviceMeta, arguments);
                case ServiceType.Aggregate:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }

        [HttpPost]
        [Route("register")]
        public object RegisterAll()
        {
            if (string.IsNullOrWhiteSpace(_configRoot.Consul?.BaseURL))
            {
                return "未配置Consul";
            }
            else
            {
                ServiceTestMeta[] tests = _repository.Query(x => x.MetaType == MetaType.ServiceTest)
                    .Select(x => x.GetMetadata() as ServiceTestMeta).ToArray();

                using (var client = new ConsulClient(c =>
                {
                    c.Address = new Uri(_configRoot.Consul.BaseURL);
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
                        Tags = new[] { serverConfig.Name },
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
                            HTTP = $"http://{serverConfig.Host}:{serverConfig.Port}/service/{item.ServiceName}",
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
                        return "注册服务失败";
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
