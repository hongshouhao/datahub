using Geone.DataService.Core.Service;
using Geone.DataService.Core.Service.DBaaS;
using Geone.DataService.Core.Service.SOAP;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;

namespace Geone.DataService.Core.Metadata
{
    [Serializable]
    public class ServiceMeta : IMeta
    {
        public ServiceType Type { get; set; }
        public object Content { get; set; }
        public object ParamsExample { get; set; }
        public string Description { get; set; }

        public void CheckValid()
        {
            if (Content == null)
            {
                throw new ArgumentException("服务内容不能为空");
            }

            ((IServiceContent)Content).CheckValid();
        }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            ParamsExample = new JRaw(ParamsExample?.ToString());

            switch (Type)
            {
                case ServiceType.REST:
                case ServiceType.SOAP:
                    if (Content is JObject jsoap)
                    {
                        Content = jsoap.ToObject<SoapMeta>();
                    }
                    break;
                case ServiceType.DBaaS:
                    if (Content is JObject jdbaas)
                    {
                        Content = jdbaas.ToObject<DbCommandMeta>();
                    }
                    break;
                case ServiceType.Aggregate:
                    throw new NotSupportedException();
                default:
                    throw new NotSupportedException();
            }
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceType
    {
        REST,
        SOAP,
        DBaaS,
        Aggregate
    }
}
