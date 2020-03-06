using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.REST;
using Geone.DataService.Core.Service.SOAP;
using System;

namespace Geone.DataService.Core.Service
{
    public class SingleServiceExcutor : IExcutor
    {
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly SoapExcutor _soapExcutor;
        private readonly RestExcutor _restExcutor;

        public SingleServiceExcutor(
              DBaaSExcutor dbaasExcutor,
              SoapExcutor soapExcutor,
              RestExcutor restExcutor)
        {
            _dbaasExcutor = dbaasExcutor;
            _soapExcutor = soapExcutor;
            _restExcutor = restExcutor;
        }

        public object Excute(ServiceMeta service, object arguments)
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
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
