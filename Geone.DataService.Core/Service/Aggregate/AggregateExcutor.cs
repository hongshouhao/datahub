using Geone.DataService.Core.Metadata;
using Geone.DataService.Core.Repository;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.REST;
using Geone.DataService.Core.Service.SOAP;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geone.DataService.Core.Service.Aggregate
{
    public class AggregateExcutor
    {
        private readonly MetaRepository _repository;
        private readonly ServiceExcutor _excutor;

        public AggregateExcutor(
            MetaRepository repository,
            ServiceExcutor excutor)
        {
            _repository = repository;
            _excutor = excutor;
        }

        public string Excute(ServiceMeta service, object arguments)
        {
            throw new NotImplementedException();
            //if (service.Type != ServiceType.Aggregate)
            //    throw new ArgumentException("服务类型不匹配");

            //JObject jmeta = service.Content as JObject;
            //AggregateMeta meta = (AggregateMeta)service.Content;
            //meta.CheckValid();

            //FuncParser parser = new FuncParser(meta.JsonSchema);
            //string[] svcNames = parser.ValRefs.Select(x => x.FuncName).ToArray();
            //var funcs = _repository.Query(x => svcNames.Contains(x.Name) && x.MetaType == MetaType.Service)
            //    .ToDictionary(x => x.Name, x => x.GetMetadata() as ServiceMeta);

            //Parallel.For(0, funcs.Count, (i) =>
            //{
            //    foreach (var fitem in funcs)
            //    {
            //        ValRef valRef = parser.ValRefs.First(x => x.FuncName.ToLower() == fitem.Key.ToLower());

            //        string result = _excutor.Excute(fitem.Value, arguments);
            //        if (result.StartsWith("["))
            //        {
            //            JArray.Parse(result).SelectToken(valRef.ValuePath);
            //        }
            //        else
            //        {
            //            JObject.Parse(result).SelectToken(valRef.ValuePath);
            //        }
            //    }
            //});

            //foreach (ValRef refItem in parser.ValRefs)
            //{

            //}

            //JObject jAggregate = JObject.Parse(meta.AggregateJson);
            //foreach (var item in jAggregate)
            //{
            //    string key = item.Key;
            //    JToken jtoken = item.Value;

            //    string value = jtoken.ToString();
            //    string[] serviceAndparams = value.Split("$");

            //    string serviceName = serviceAndparams[0];
            //    Dictionary<string, object> dicArguments = new Dictionary<string, object>();
            //    if (serviceAndparams.Length == 2)
            //    {
            //        string paramString = serviceAndparams[1];
            //        foreach (var param in paramString.Trim('(', ')').Split(','))
            //        {
            //            if (arguments.TryGetValue(param, out object paramValue))
            //            {
            //                dicArguments.Add(param, paramValue);
            //            }
            //        }
            //    }

            //    MetaEntity entity = _repository.Get(MetaType.Service, serviceName);
            //    ServiceMeta serviceMeta = entity.Deserialize<ServiceMeta>();
            //    switch (serviceMeta.Type)
            //    {
            //        case ServiceType.REST:
            //            returnJson = returnJson.Replace(value, _restExcutor.Excute(serviceMeta, dicArguments));
            //            break;
            //        case ServiceType.SOAP:
            //            Dictionary<string, object> soapArguments = JsonConvert.DeserializeObject<Dictionary<string, object>>(dicArguments.First().Value.ToString());
            //            returnJson = returnJson.Replace(value, _soapExcutor.Excute(serviceMeta, soapArguments));
            //            break;
            //        case ServiceType.DBaaS:
            //            returnJson = returnJson.Replace(value, _dbaasExcutor.Excute(serviceMeta, dicArguments));
            //            break;
            //        default:
            //            throw new NotSupportedException();
            //    }
            //}

            //return returnJson;
        }
    }
}
