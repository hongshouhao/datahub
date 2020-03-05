using Geone.DataService.Core.DBaaS;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.REST;
using Geone.DataService.Core.SOAP;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geone.DataService.Core.Aggregate
{
    public class AggregateExcutor
    {
        private readonly DBaaSExcutor _dbaasExcutor;
        private readonly MetaRepository _repository;
        private readonly SoapExcutor _soapExcutor;
        private readonly RestExcutor _restExcutor;

        public AggregateExcutor(
            MetaRepository repository,
            DBaaSExcutor dbaasExcutor,
            SoapExcutor soapExcutor,
            RestExcutor restExcutor)
        {
            _repository = repository;
            _dbaasExcutor = dbaasExcutor;
            _soapExcutor = soapExcutor;
            _restExcutor = restExcutor;
        }

        public async Task<string> Excute(ServiceMeta service, Dictionary<string, object> arguments)
        {
            if (service.Type != ServiceType.Aggregate)
                throw new ArgumentException("服务类型不匹配");

            JObject jmeta = service.Content as JObject;
            AggregateMeta aggregateMeta;
            try
            {
                aggregateMeta = jmeta.ToObject<AggregateMeta>();
            }
            catch (Exception e)
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(AggregateMeta)}对象", e);
            }

            if (string.IsNullOrWhiteSpace(aggregateMeta.AggregateJson))
            {
                throw new ArgumentException($"服务内容不是合法的{nameof(AggregateMeta)}对象");
            }

            string returnJson = aggregateMeta.AggregateJson;
            JObject jAggregate = JObject.Parse(aggregateMeta.AggregateJson);

            foreach (var item in jAggregate)
            {
                await Task.Run(() =>
                {
                    string key = item.Key;
                    JToken jtoken = item.Value;

                    string value = jtoken.ToString();
                    string[] serviceAndparams = value.Split("$");

                    string serviceName = serviceAndparams[0];
                    Dictionary<string, object> dicArguments = new Dictionary<string, object>();
                    if (serviceAndparams.Length == 2)
                    {
                        string paramString = serviceAndparams[1];
                        foreach (var param in paramString.Trim('(', ')').Split(','))
                        {
                            if (arguments.TryGetValue(param, out object paramValue))
                            {
                                dicArguments.Add(param, paramValue);
                            }
                        }
                    }

                    MetaEntity entity = _repository.Get(MetaType.Service, serviceName);
                    ServiceMeta serviceMeta = entity.Deserialize<ServiceMeta>();
                    switch (serviceMeta.Type)
                    {
                        case ServiceType.REST:
                            returnJson = returnJson.Replace(value, _restExcutor.Excute(serviceMeta, dicArguments));
                            break;
                        case ServiceType.SOAP:
                            Dictionary<string, object> soapArguments = JsonConvert.DeserializeObject<Dictionary<string, object>>(dicArguments.First().Value.ToString());
                            returnJson = returnJson.Replace(value, _soapExcutor.Excute(serviceMeta, soapArguments));
                            break;
                        case ServiceType.DBaaS:
                            returnJson = returnJson.Replace(value, _dbaasExcutor.Excute(serviceMeta, dicArguments));
                            break;
                        default:
                            throw new NotSupportedException();
                    }
                });
            }

            return returnJson;
        }
    }
}
