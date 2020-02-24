using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;

namespace Geone.DataService.Controllers
{
    [Route("service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ILogger<ServiceController> _logger;
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly MetaRepository _repository;

        public ServiceController(MetaRepository repository, DBaaSExcutor dbaasExcutor, ILogger<ServiceController> logger)
        {
            _repository = repository;
            _dbaasExcutor = dbaasExcutor;
            _logger = logger;
        }

        [HttpPost]
        [Route("{name}")]
        public string Post(string name, [FromBody]Dictionary<string, object> arguments)
        {
            MetaEntity entity = _repository.Get(MetaType.Service, name);
            ServiceMeta serviceMeta = entity.Deserialize<ServiceMeta>();

            switch (serviceMeta.Type)
            {
                case ServiceType.REST:
                    throw new NotImplementedException();
                case ServiceType.SOAP:
                    throw new NotImplementedException();
                case ServiceType.DBaaS:
                    return _dbaasExcutor.Excute(serviceMeta, arguments);
                case ServiceType.Aggregate:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
