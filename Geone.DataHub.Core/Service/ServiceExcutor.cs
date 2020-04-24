using Geone.DataHub.Core.Metadata;
using Geone.DataHub.Core.Service.Aggregate;
using System;

namespace Geone.DataHub.Core.Service
{
    public class ServiceExcutor : IExcutor
    {
        private readonly SingleServiceExcutor _singleExcutor;
        private readonly AggregateExcutor _aggregateExcutor;

        public ServiceExcutor(
              SingleServiceExcutor singleExcutor,
              AggregateExcutor aggregateExcutor)
        {
            _singleExcutor = singleExcutor;
            _aggregateExcutor = aggregateExcutor;
        }

        public object Excute(ServiceMeta service, object arguments)
        {
            switch (service.Type)
            {
                case ServiceType.REST:
                case ServiceType.SOAP:
                case ServiceType.DBaaS:
                    return _singleExcutor.Excute(service, arguments);
                case ServiceType.Aggregate:
                    return _aggregateExcutor.Excute(service, arguments);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
