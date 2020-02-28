using Geone.DataService.Core;
using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Geone.DataService.Core.SOAP;

namespace Geone.DataService.Controllers
{
    [Route("service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ILogger<ServiceController> _logger;
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly SoapExcutor _soapExcutor;
        private readonly MetaRepository _repository;

        public ServiceController(MetaRepository repository,
            DBaaSExcutor dbaasExcutor,
            SoapExcutor soapExcutor,
            ILogger<ServiceController> logger)
        {
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
            ServiceMeta serviceMeta = entity.Deserialize<ServiceMeta>();

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
    }
}
