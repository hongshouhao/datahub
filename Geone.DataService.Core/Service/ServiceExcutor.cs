using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Service.Aggregate;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.REST;
using Geone.DataService.Core.Service.SOAP;
using System;

namespace Geone.DataService.Core.Service
{
    public class ServiceExcutor
    {
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly SoapExcutor _soapExcutor;
        private readonly RestExcutor _restExcutor;
        //private readonly AggregateExcutor _aggregateExcutor;

        public ServiceExcutor(
              DBaaSExcutor dbaasExcutor,
              SoapExcutor soapExcutor,
              RestExcutor restExcutor
              //AggregateExcutor aggregateExcutor
            )
        {
            _dbaasExcutor = dbaasExcutor;
            _soapExcutor = soapExcutor;
            _restExcutor = restExcutor;
          //  _aggregateExcutor = aggregateExcutor;
        }

        public string Excute(ServiceMeta service, object arguments)
        {
            switch (service.Type)
            {
                case ServiceType.REST:
                    return _restExcutor.Excute(service, arguments);
                case ServiceType.SOAP:
                    return _soapExcutor.Excute(service, arguments);
                case ServiceType.DBaaS:
                    return _dbaasExcutor.Excute(service, arguments);
                case ServiceType.Aggregate:
                   // return _aggregateExcutor.Excute(service, arguments);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
