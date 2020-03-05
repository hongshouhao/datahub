using Geone.DataService.Core;
using Geone.DataService.Core.Aggregate;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.REST;
using Geone.DataService.Core.SOAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Geone.DataService.Controllers
{
    [Route("service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ILogger<ServiceController> _logger;
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly MetaRepository _repository;
        private readonly SoapExcutor _soapExcutor;
        private readonly RestExcutor _restExcutor;
        private readonly AggregateExcutor _aggregateExcutor;


        public ServiceController(MetaRepository repository, 
            DBaaSExcutor dbaasExcutor, 
            SoapExcutor soapExcutor, 
            RestExcutor restExcutor,
            AggregateExcutor aggregateExcutor,
            ILogger<ServiceController> logger)
        {
            _repository = repository;
            _dbaasExcutor = dbaasExcutor;
            _soapExcutor = soapExcutor;
            _restExcutor = restExcutor;
            _aggregateExcutor = aggregateExcutor;
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
                   return _restExcutor.Excute(serviceMeta, arguments);
                case ServiceType.SOAP:
                    return _soapExcutor.Excute(serviceMeta, arguments) ;
                case ServiceType.DBaaS:
                    return _dbaasExcutor.Excute(serviceMeta, arguments);
                case ServiceType.Aggregate:
                    return _aggregateExcutor.Excute(serviceMeta, arguments).Result;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
